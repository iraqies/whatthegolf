using System.Collections.Generic;
using Audio;
using UnityEngine;

namespace Core
{
	public class HarmonikaDyrShooter : GolfBallShooterBase
	{
		public Rigidbody frontPart;

		public CapsuleCollider frontCapsuleCollider;

		public Rigidbody backPart;

		public CapsuleCollider backCapsuleCollider;

		public Rigidbody midPart;

		public List<Transform> firstSegmentParts;

		public List<Transform> lastSegmentParts;

		public LayerMask groundLayer;

		[SerializeField]
		private float walkSpeed = 3f;

		[SerializeField]
		private float retractSpeed = 3f;

		public float maxExtendDistance = 3f;

		public float minExtendDistance = 3f;

		[SerializeField]
		private float raycastDist = 3f;

		[SerializeField]
		public List<LaserSentryTarget> laserTargets;

		[SerializeField]
		private RandomAudioClips explodeClips;

		[SerializeField]
		private bool restartOnOutOfBounds = true;

		public GolfBallController ballController;

		private Vector3 currentBoost;

		private bool isAiming;

		private bool isGrounded;

		private float shotDisableTime;

		private Vector3 lastShootBoost;

		private Joint[] joints;

		private bool hasShot;

		public bool IsRetracting { get; private set; }

		public bool IsPlacing { get; private set; }

		private void OnEnable()
		{
			if (GolfBallController != null)
			{
				GolfBallController.countStrokes = false;
			}
			IsRetracting = true;
			if (backPart != null)
			{
				currentBoost = backPart.transform.forward;
			}
			if (laserTargets != null)
			{
				foreach (LaserSentryTarget target in laserTargets)
				{
					if (target != null)
					{
						target.OnLasered += HandleOnLasered;
					}
				}
			}
			if (base.transform.parent != null)
			{
				joints = base.transform.parent.GetComponentsInChildren<Joint>();
			}
			if (restartOnOutOfBounds && frontPart != null)
			{
				OutOfBoundsTrigger trigger = frontPart.GetComponent<OutOfBoundsTrigger>();
				if (trigger != null)
				{
					trigger.OnOutOfBounds += HarmonikaDyrShooter_OnOutOfBounds;
				}
			}
		}

		private void HarmonikaDyrShooter_OnOutOfBounds(OutOfBoundsTrigger obj)
		{
			if (Level.HasInstance)
			{
				Level.Instance.Restart();
			}
		}

		private void HandleOnLasered()
		{
			if (explodeClips != null)
			{
				explodeClips.PlayRandomClip(base.transform);
			}
			if (laserTargets != null)
			{
				foreach (LaserSentryTarget target in laserTargets)
				{
					if (target != null)
					{
						target.OnLasered -= HandleOnLasered;
					}
				}
			}
			shotDisableTime = Time.time + 10.7f;
			if (isAiming)
			{
				OnShoot(currentBoost);
				if (ballController != null)
				{
					ballController.CancelShooting();
				}
			}
			if (joints != null)
			{
				for (int i = 0; i < joints.Length; i++)
				{
					if (joints[i] != null)
					{
						Object.Destroy(joints[i]);
					}
				}
			}
			if (firstSegmentParts != null)
			{
				foreach (Transform part in firstSegmentParts)
				{
					if (part != null)
					{
						part.gameObject.AddComponent<BoxCollider>();
						part.gameObject.AddComponent<Rigidbody>();
					}
				}
			}
			if (lastSegmentParts != null)
			{
				foreach (Transform part2 in lastSegmentParts)
				{
					if (part2 != null)
					{
						part2.gameObject.AddComponent<BoxCollider>();
						part2.gameObject.AddComponent<Rigidbody>();
					}
				}
			}
			if (Level.HasInstance)
			{
				Level.Instance.Fail(true, true, ballController, 1.3f, true, "ID_FAIL_PINBALL");
			}
		}

		private bool isShot()
		{
			return Time.time < shotDisableTime;
		}

		public override void OnAimUpdate(Vector3 boost, bool onlyAimArrow)
		{
			if (onlyAimArrow || boost.magnitude < 0.05f)
				return;

			if (isGrounded && !IsRetracting && Time.time >= shotDisableTime)
			{
				currentBoost = boost;
				IsPlacing = true;
			}
			if (!isAiming && GolfBallController != null)
			{
				GolfBallController.CountShot();
			}
			isAiming = true;
		}

		public override void OnCancel()
		{
			if (hasShot && backPart != null)
			{
				currentBoost = backPart.transform.forward;
				base.OnCancel();
				_ = Time.time;
			}
			isAiming = false;
			IsPlacing = false;
		}

		public override void OnShoot(Vector3 boost)
		{
			base.OnShoot(boost);
			lastShootBoost = boost;
			IsRetracting = true;
			IsPlacing = false;
			isAiming = false;
			hasShot = true;
		}

		private void Update()
		{
			if (isAiming && ballController != null && ballController.GetPlayerButtonUp(true, "GolfBallShoot"))
			{
				if (ballController.GetPlayerAxisDirection(false, "GolfBallAimHorizontal", "GolfBallAimVertical").magnitude == 0f)
				{
					OnCancel();
				}
			}
		}

		protected override void FixedUpdate()
		{
			if (backPart == null || midPart == null || frontPart == null)
				return;

			backPart.isKinematic = IsPlacing;
			if (Time.time < shotDisableTime)
				return;

			if (currentBoost != Vector3.zero)
			{
				midPart.MoveRotation(Quaternion.LookRotation(currentBoost, Vector3.up));
			}

			Vector3 backToMid = midPart.position - backPart.position;
			backToMid.y = Mathf.Max(0f, backToMid.y);
			if (backToMid != Vector3.zero)
			{
				backPart.MoveRotation(Quaternion.LookRotation(backToMid, Vector3.up));
			}

			Vector3 midToFront = frontPart.position - midPart.position;
			midToFront.y = Mathf.Max(0f, midToFront.y);
			if (midToFront != Vector3.zero)
			{
				frontPart.MoveRotation(Quaternion.LookRotation(midToFront, Vector3.up));
			}

			isGrounded = true;
			if (Physics.Raycast(base.transform.position, Vector3.down, raycastDist, groundLayer, QueryTriggerInteraction.Ignore))
			{
				if (ballController != null)
				{
					ballController.canShoot = !IsRetracting;
				}
			}
			else
			{
				if (ballController != null)
				{
					ballController.canShoot = false;
				}
				isGrounded = false;
			}

			Vector3 backPos = backPart.position;
			Vector3 frontPos = frontPart.position;
			Vector3 targetFrontPos;
			if (IsPlacing)
			{
				float dist = Mathf.Lerp(minExtendDistance, maxExtendDistance, currentBoost.magnitude);
				targetFrontPos = backPart.transform.position + currentBoost.normalized * dist;
			}
			else
			{
				targetFrontPos = frontPos;
			}

			if (IsRetracting)
			{
				Vector3 retractTarget = frontPart.position - frontPart.transform.forward * minExtendDistance;
				Vector3 movedBack = Vector3.MoveTowards(backPos, retractTarget, Time.fixedDeltaTime * retractSpeed);
				movedBack.y = Mathf.Max(movedBack.y, targetFrontPos.y);
				backPos = movedBack;
				if (Vector3.Distance(backPos, frontPart.transform.position) <= minExtendDistance * 1.05f)
				{
					IsRetracting = false;
				}
			}
			else if (!IsPlacing)
			{
				if (Vector3.Distance(targetFrontPos, backPos) < minExtendDistance * 1.5f)
				{
					targetFrontPos += currentBoost.normalized * Time.fixedDeltaTime * walkSpeed;
				}
				Vector3 walkTarget = frontPart.position - currentBoost.normalized * minExtendDistance;
				backPos = Vector3.MoveTowards(backPos, walkTarget, Time.fixedDeltaTime * walkSpeed);
			}

			Vector3 curBackPos = backPart.position;
			float backVelY = backPart.velocity.y;
			if (backPart.position.y < frontPart.position.y && !isGrounded)
			{
				backVelY = Mathf.Max(0f, backVelY);
				backPart.MovePosition(new Vector3(backPart.position.x, frontPart.position.y, backPart.position.z));
			}

			Vector3 curFrontPos = frontPart.position;
			float frontVelY = IsPlacing ? ((targetFrontPos.y - curFrontPos.y) * 10f) : frontPart.velocity.y;
			if (Time.time >= shotDisableTime)
			{
				backPart.velocity = new Vector3((backPos.x - curBackPos.x) * 10f, backVelY, (backPos.z - curBackPos.z) * 10f);
				frontPart.velocity = new Vector3((targetFrontPos.x - curFrontPos.x) * 10f, frontVelY, (targetFrontPos.z - curFrontPos.z) * 10f);
			}

			if (firstSegmentParts != null && firstSegmentParts.Count > 0)
			{
				float count = firstSegmentParts.Count + 1;
				for (int i = 0; i < firstSegmentParts.Count; i++)
				{
					Transform seg = firstSegmentParts[i];
					if (seg == null)
						continue;
					float t = Mathf.Clamp01((i + 1) / count);
					seg.position = Vector3.Lerp(backPart.position, midPart.position, t);
					if (i + 1 < firstSegmentParts.Count && firstSegmentParts[i + 1] != null)
					{
						seg.LookAt(firstSegmentParts[i + 1]);
					}
					else
					{
						seg.LookAt(midPart.position);
					}
				}
			}

			if (lastSegmentParts != null && lastSegmentParts.Count > 0)
			{
				float count2 = lastSegmentParts.Count + 1;
				for (int i = 0; i < lastSegmentParts.Count; i++)
				{
					Transform seg2 = lastSegmentParts[i];
					if (seg2 == null)
						continue;
					float t2 = Mathf.Clamp01((i + 1) / count2);
					seg2.position = Vector3.Lerp(midPart.position, frontPart.position, t2);
					if (i + 1 < lastSegmentParts.Count && lastSegmentParts[i + 1] != null)
					{
						seg2.LookAt(lastSegmentParts[i + 1]);
					}
					else
					{
						seg2.LookAt(frontPart.position);
					}
				}
			}

			if (frontCapsuleCollider != null)
			{
				float frontDist = Vector3.Distance(frontPart.position, midPart.position) / frontPart.transform.lossyScale.x;
				frontCapsuleCollider.height = frontDist;
				frontCapsuleCollider.center = new Vector3(0f, 0f, frontDist * -0.5f);
			}
			if (backCapsuleCollider != null)
			{
				float backDist = Vector3.Distance(midPart.position, backPart.position) / backPart.transform.lossyScale.x;
				backCapsuleCollider.height = backDist;
				backCapsuleCollider.center = new Vector3(0f, 0f, backDist * 0.5f);
			}
		}
	}
}
