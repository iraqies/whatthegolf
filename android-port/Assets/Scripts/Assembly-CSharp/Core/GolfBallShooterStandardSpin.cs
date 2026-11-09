using UnityEngine;

namespace Core
{
	public class GolfBallShooterStandardSpin : GolfBallShooterBase
	{
		[SerializeField] private float fullShootVelocity = 25f;
		[SerializeField] private float pitch;
		[SerializeField] private float spin;

		public override void OnActivate()
		{
			base.OnActivate();
			if (rigidbodyC != null)
				rigidbodyC.isKinematic = false;
		}

		public override void OnShoot(Vector3 boost)
		{
			base.OnShoot(boost);
			Vector3 cross = Vector3.Cross(boost, Vector3.up);
			if (cross.sqrMagnitude > 1e-6f)
				boost = Quaternion.AngleAxis(pitch, cross) * boost;
			if (rigidbodyC != null)
			{
				rigidbodyC.isKinematic = false;
				rigidbodyC.velocity = Vector3.zero;
				rigidbodyC.AddForce(boost * fullShootVelocity, ForceMode.VelocityChange);
				rigidbodyC.AddTorque(-cross * spin, ForceMode.VelocityChange);
			}
		}
	}
}
