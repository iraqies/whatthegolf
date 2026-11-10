using System.Collections;
using System.Collections.Generic;
using CameraStack;
using Core;
using UnityEngine;

public class SkeletonShooter : GolfBallShooterBase
{
	[SerializeField]
	private float minVelocity = 20f;

	[SerializeField]
	private float fullVelocity = 40f;

	[SerializeField]
	private float fullPitch = 30f;

	[SerializeField]
	private float fullSpin = 30f;

	[SerializeField]
	private Animator golfAnimator;

	[SerializeField]
	private List<Rigidbody> skeletonParts;

	private Rigidbody[] rigidbodies;

	[SerializeField]
	private Rigidbody hips;

	private bool hasCollapsed;

	private bool isCollapsing;

	private Vector3 oldPosition;

	private Quaternion oldRotation;

	private CBFollow followCamera;

	private float mass;

	protected override void Awake()
	{
		base.Awake();
		if (hips != null)
		{
			rigidbodies = hips.GetComponentsInChildren<Rigidbody>();
		}
		oldPosition = transform.position;
		oldRotation = transform.rotation;
		if (CameraManager.Instance != null)
		{
			followCamera = CameraManager.Instance.GetComponent<CBFollow>();
		}
		if (rigidbodies != null)
		{
			for (int i = 0; i < rigidbodies.Length; i++)
			{
				if (rigidbodies[i] != null)
				{
					rigidbodies[i].isKinematic = true;
					mass += rigidbodies[i].mass;
				}
			}
		}
	}

	private void Update()
	{
	}

	public override void OnAimUpdate(Vector3 boost, bool onlyAimArrow)
	{
		base.OnAimUpdate(boost, onlyAimArrow);
	}

	public override void OnShoot(Vector3 boost)
	{
		if (isCollapsing)
			return;
		base.OnShoot(boost);
		Vector3 pitched = PitchBoost(boost);
		Vector3 torqueAxis = Vector3.Cross(boost, Vector3.up);

		if (hasCollapsed)
		{
			if (skeletonParts != null && skeletonParts.Count > 0)
			{
				int lastIdx = skeletonParts.Count - 1;
				Rigidbody part = skeletonParts[lastIdx];
				skeletonParts.RemoveAt(lastIdx);
				if (part != null)
				{
					part.transform.parent = null;
					CharacterJoint[] joints = part.gameObject.GetComponents<CharacterJoint>();
					if (joints != null)
					{
						for (int i = joints.Length - 1; i >= 0; i--)
						{
							if (joints[i] != null)
								Destroy(joints[i]);
						}
					}
					part.gameObject.tag = "Untagged";
					part.gameObject.SetActive(true);
					mass -= part.mass;
				}
			}

			if (golfAnimator != null)
				golfAnimator.enabled = false;

			Vector3 norm = pitched.normalized;
			float mag = Mathf.Clamp01(pitched.magnitude);
			if (hips != null)
			{
				Vector3 force = Vector3.Lerp(norm * minVelocity, norm * fullVelocity, mag) * mass;
				hips.AddForce(force, ForceMode.Impulse);
				hips.AddTorque(-torqueAxis * fullSpin * mass, ForceMode.Impulse);
			}
		}
		else
		{
			isCollapsing = true;
			StartCoroutine(PlayShootSequence(boost));
		}
	}

	public override void OnReset()
	{
		base.OnReset();
		if (rigidbodies != null)
		{
			for (int i = 0; i < rigidbodies.Length; i++)
			{
				if (rigidbodies[i] != null)
				{
					rigidbodies[i].velocity = Vector3.zero;
					rigidbodies[i].angularVelocity = Vector3.zero;
				}
			}
		}
	}

	private Vector3 PitchBoost(Vector3 boost)
	{
		Vector3 axis = Vector3.Cross(boost, Vector3.up);
		return Quaternion.AngleAxis(fullPitch * boost.magnitude, axis) * boost;
	}

	private IEnumerator PlayShootSequence(Vector3 boost)
	{
		yield return null;
		hasCollapsed = true;
		isCollapsing = false;
		if (GolfBallController != null)
		{
			GolfBallController.CheckpointHit(oldPosition, oldRotation);
		}
		if (rigidbodies != null)
		{
			for (int i = 0; i < rigidbodies.Length; i++)
			{
				if (rigidbodies[i] != null)
					rigidbodies[i].isKinematic = false;
			}
		}
		if (followCamera != null && hips != null)
		{
			followCamera.FollowTarget = hips.transform;
		}
		if (GolfBallController != null)
		{
			GolfBallController.ArrowPosition = transform;
		}
		OnShoot(boost);
	}
}
