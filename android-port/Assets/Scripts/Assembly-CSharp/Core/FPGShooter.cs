using UnityEngine;

namespace Core
{
	public class FPGShooter : GolfBallShooterBase
	{
		[SerializeField]
		public float minShootVelocity = 5f;

		[SerializeField]
		public float fullShootVelocity = 25f;

		[SerializeField]
		public float pitch;

		[SerializeField]
		public bool zeroPitchIfNotGrouneded = true;

		private Quaternion startRot;

		private float lastShotTime;

		protected override void Awake()
		{
			base.Awake();
			rigidbodyC = GetComponent<Rigidbody>();
			startRot = base.transform.rotation;
		}

		public override void OnActivate()
		{
			base.OnActivate();
			if (rigidbodyC != null)
			{
				rigidbodyC.isKinematic = false;
			}
		}

		public override void OnShoot(Vector3 boost)
		{
			lastShotTime = Time.time;
			Shoot(boost, false);
		}

		private void Shoot(Vector3 boost, bool comingFromUpdate)
		{
			if (!comingFromUpdate && PlatformSettings.IsAppleTV)
			{
				return;
			}
			if (GolfBallController != null && GolfBallController.mainCamera != null)
			{
				Vector3 fwd = GolfBallController.mainCamera.transform.forward;
				float mag = boost.magnitude;
				boost = new Vector3(fwd.x * mag, 0f, fwd.z * mag);
			}
			base.OnShoot(boost);
			Vector3 axis = Vector3.Cross(boost, Vector3.up);
			if (!zeroPitchIfNotGrouneded || (GolfBallController != null && GolfBallController.IsGrounded))
			{
				boost = Quaternion.AngleAxis(pitch, axis) * boost;
			}
			StandardShoot(boost, pitch, minShootVelocity, fullShootVelocity, 0f);
		}

		private void LateUpdate()
		{
			bool shootPressed = false;
			if (Time.timeScale > 0f && GolfBallController != null)
			{
				shootPressed = Input.GetMouseButtonUp(0);
			}
			if (shootPressed && GolfBallController != null && !GolfBallController.BlockShooting && GolfBallController.mainCamera != null)
			{
				Shoot(base.transform.forward, true);
				if (Time.time - lastShotTime > 0.1f)
				{
					GolfBallController.CountShot();
					GolfBallController.TimedBlockShot(0.01f);
				}
			}
		}

		public override void OnReset()
		{
			base.OnReset();
			base.transform.rotation = startRot;
		}
	}
}
