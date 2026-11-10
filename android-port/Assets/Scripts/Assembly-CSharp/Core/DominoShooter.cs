using UnityEngine;

namespace Core
{
	public class DominoShooter : GolfBallShooterBase
	{
		[SerializeField]
		public float minShootVelocity = 5f;

		[SerializeField]
		public float fullShootVelocity = 25f;

		[SerializeField]
		public float pitch;

		[SerializeField]
		protected float spin;

		[SerializeField]
		protected float maxAngVel = 7f;

		[SerializeField]
		protected bool lookInAimDirection;

		[SerializeField]
		protected bool lookInShotDirection;

		[SerializeField]
		public bool zeroPitchIfNotGrouneded = true;

		public Rigidbody initialRigidbody;

		private BoxCollider box;

		private Vector3 look = Vector3.zero;

		public float velocityThreshold = 5f;

		private Vector3 currentBoost;

		private void Start()
		{
			rigidbodyC = initialRigidbody;
			if (rigidbodyC != null)
			{
				box = rigidbodyC.GetComponent<BoxCollider>();
				rigidbodyC.maxAngularVelocity = maxAngVel;
			}
			sqrVelocityShootingThreshold = velocityThreshold;
		}

		public void SetRigidbody(Rigidbody rb)
		{
			rigidbodyC = rb;
			if (rb != null)
			{
				box = rb.GetComponent<BoxCollider>();
				rigidbodyC.maxAngularVelocity = maxAngVel;
			}
		}

		public override void OnAimStart()
		{
			if (rigidbodyC != null && rigidbodyC.velocity.magnitude < 25f)
			{
				rigidbodyC.velocity = Vector3.zero;
				rigidbodyC.angularVelocity = Vector3.zero;
			}
		}

		public override void OnAimUpdate(Vector3 boost, bool onlyAimArrow)
		{
			if (GolfBallController == null || GolfBallController.BlockShooting)
				return;

			if (lookInAimDirection && boost.magnitude > 0.2f && rigidbodyC != null && rigidbodyC.velocity.magnitude < 25f)
			{
				currentBoost = boost;
			}
			else if (rigidbodyC != null)
			{
				rigidbodyC.velocity = Vector3.Lerp(rigidbodyC.velocity, Physics.gravity, Mathf.Clamp01(Time.deltaTime * 2f));
			}
		}

		public override void OnShoot(Vector3 boost)
		{
			base.OnShoot(boost);
			if (lookInShotDirection && rigidbodyC != null)
			{
				Vector3 proj = Vector3.ProjectOnPlane(boost.normalized, look);
				if (look.sqrMagnitude > 1e-6f && proj.sqrMagnitude > 1e-6f)
					rigidbodyC.MoveRotation(Quaternion.LookRotation(look, proj));
			}

			StandardShoot(boost, pitch, fullShootVelocity, spin);
			currentBoost = Vector3.zero;
		}

		public void SetNewRigid(Rigidbody rigid)
		{
			rigidbodyC = rigid;
			if (GolfBallController != null)
				GolfBallController.TimedBlockShot(1.5f);
		}

		public Rigidbody GetCurrentRigidbody()
		{
			return rigidbodyC;
		}

		protected override void FixedUpdate()
		{
			if (rigidbodyC != null && box != null)
			{
				transform.position = rigidbodyC.transform.TransformPoint(box.center);
			}
			if (currentBoost.magnitude > 0f && rigidbodyC != null)
			{
				Quaternion targetRot = Quaternion.LookRotation(currentBoost.normalized, Vector3.up);
				rigidbodyC.angularVelocity = Vector3.zero;
				Quaternion nextRot = Quaternion.Slerp(rigidbodyC.transform.rotation, targetRot, Time.deltaTime * 10f);
				rigidbodyC.MoveRotation(nextRot);
			}
		}
	}
}
