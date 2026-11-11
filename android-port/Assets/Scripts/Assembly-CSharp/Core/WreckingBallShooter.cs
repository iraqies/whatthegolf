using UnityEngine;

namespace Core
{
	public class WreckingBallShooter : GolfBallShooterBase
	{
		[SerializeField]
		private float AdjustRotationSpeed = 10f;

		[SerializeField]
		private float AngleDampenLimit = 10f;

		[SerializeField]
		private Transform Extendable;

		[SerializeField]
		private Vector2 ExtendableRange = new Vector2(1f, 5f);

		[SerializeField]
		private float ExtendableMoveSpeed = 5f;

		private bool isAiming;

		private float rotationStartupTimer;

		private Vector3 currentBoost;

		private Joint joint;

		private Vector3 startJointAnchor;

		protected override void Awake()
		{
			base.Awake();
			joint = GetComponentInChildren<Joint>();
			if (joint != null)
			{
				startJointAnchor = joint.connectedAnchor;
			}
		}

		public override void OnAimUpdate(Vector3 boost, bool onlyAimArrow)
		{
			isAiming = true;
			currentBoost = boost;
			rotationStartupTimer = Mathf.Clamp01(rotationStartupTimer + Time.deltaTime * 2f);
		}

		public override void OnCancel()
		{
			isAiming = false;
			rotationStartupTimer = 0f;
		}

		public override void OnShoot(Vector3 boost)
		{
			base.OnShoot(boost);
			isAiming = false;
			rotationStartupTimer = 0f;
		}

		private void AdjustRotation(Vector3 dir)
		{
			Vector3 flatDir = new Vector3(dir.x, 0f, dir.z);
			if (flatDir.sqrMagnitude < 0.0001f)
			{
				return;
			}
			Vector3 normDir = flatDir.normalized;
			Vector3 flatFwd = new Vector3(transform.forward.x, 0f, transform.forward.z).normalized;
			float angle = Vector3.Angle(normDir, flatFwd);
			Quaternion targetRot = Quaternion.LookRotation(normDir, Vector3.up);
			float t = Time.fixedDeltaTime * AdjustRotationSpeed * Mathf.Clamp01(angle / Mathf.Max(0.01f, AngleDampenLimit)) * rotationStartupTimer;
			if (rigidbodyC != null)
			{
				rigidbodyC.MoveRotation(Quaternion.Lerp(transform.rotation, targetRot, t));
			}
			else
			{
				transform.rotation = Quaternion.Lerp(transform.rotation, targetRot, t);
			}
			if (Extendable != null)
			{
				Vector3 localPos = Extendable.localPosition;
				float targetZ = Mathf.Lerp(ExtendableRange.x, ExtendableRange.y, Mathf.Clamp01(dir.magnitude));
				localPos.z = Mathf.Lerp(localPos.z, targetZ, Time.fixedDeltaTime * ExtendableMoveSpeed);
				Extendable.localPosition = localPos;
				if (joint != null)
				{
					joint.connectedAnchor = startJointAnchor + Vector3.forward * localPos.z;
				}
			}
		}

		protected override void FixedUpdate()
		{
			base.FixedUpdate();
			if (isAiming)
			{
				AdjustRotation(currentBoost);
			}
		}
	}
}
