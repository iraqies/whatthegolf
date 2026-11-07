using UnityEngine;

namespace Core
{
	public class GolfBallShooterExperimental : GolfBallShooterBase
	{
		[SerializeField] public float minShootVelocity = 2f;
		[SerializeField] public float fullShootVelocity = 18f;
		[SerializeField] public float pitch;
		[SerializeField] public AnimationCurve powerToPitchWeightCurve;
		[SerializeField] public float spin;
		[SerializeField] protected bool lookInShotDirection;
		public bool lookInAimDirection;
		[SerializeField] protected bool onlyLookWhenChargingOnController;
		public float LookInAimDirectionSpeed = 10f;
		[SerializeField] protected bool dontLookInAimDirectionWhenBlocked;
		[SerializeField] protected bool useLocalUp;
		[SerializeField] public bool zeroPitchIfNotGrouneded;

		protected override void Awake() => base.Awake();
		public override void OnActivate() => StartAndWakeup();

		public override void OnAimUpdate(Vector3 boost, bool onlyAimArrow)
		{
			if (lookInAimDirection && boost.sqrMagnitude > 0.001f)
			{
				Vector3 flat = new Vector3(boost.x, 0f, boost.z);
				if (flat.sqrMagnitude > 0.001f)
				{
					Quaternion targetRot = Quaternion.LookRotation(flat.normalized, Vector3.up);
					transform.rotation = Quaternion.Slerp(transform.rotation, targetRot, Time.unscaledDeltaTime * Mathf.Max(5f, LookInAimDirectionSpeed));
				}
			}
		}

		public override void OnShoot(Vector3 boost)
		{
			float p = (zeroPitchIfNotGrouneded && GolfBallController != null && !GolfBallController.IsGrounded) ? 0f : pitch;
			StandardShoot(boost, p, minShootVelocity, fullShootVelocity > 0f ? fullShootVelocity : 18f, spin);
		}
	}
}
