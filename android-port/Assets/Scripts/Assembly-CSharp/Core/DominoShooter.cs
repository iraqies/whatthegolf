using UnityEngine;

namespace Core
{
	public class DominoShooter : GolfBallShooterBase
	{
		[SerializeField]
		public float minShootVelocity;

		[SerializeField]
		public float fullShootVelocity;

		[SerializeField]
		public float pitch;

		[SerializeField]
		protected float spin;

		[SerializeField]
		protected float maxAngVel;

		[SerializeField]
		protected bool lookInAimDirection;

		[SerializeField]
		protected bool lookInShotDirection;

		[SerializeField]
		public bool zeroPitchIfNotGrouneded;

		public Rigidbody initialRigidbody;

		private BoxCollider box;

		private Vector3 look;

		public float velocityThreshold;

		private Vector3 currentBoost;

		private void Start()
		{
		}

		public void SetRigidbody(Rigidbody rb)
		{
		}

		public override void OnAimStart()
		{
		}

		public override void OnAimUpdate(Vector3 boost, bool onlyAimArrow)
		{
		}

		public override void OnShoot(Vector3 boost)
		{
		}

		public void SetNewRigid(Rigidbody rigid)
		{
		}

		public Rigidbody GetCurrentRigidbody()
		{
			return null;
		}

		protected override void FixedUpdate()
		{
		}
	}
}
