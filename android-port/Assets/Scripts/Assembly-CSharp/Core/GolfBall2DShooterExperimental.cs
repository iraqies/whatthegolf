using UnityEngine;

namespace Core
{
	public class GolfBall2DShooterExperimental : GolfBall2DShooterBase
	{
		[SerializeField]
		public float minShootVelocity = 5f;

		[SerializeField]
		public float fullShootVelocity = 25f;

		[SerializeField]
		public float pitch;

		[SerializeField]
		public float spin;

		[SerializeField]
		public bool zeroPitchIfNotGrouneded = true;

		[SerializeField]
		public bool lookInAimDirection;

		public override void OnActivate()
		{
			base.OnActivate();
			if (rigid != null)
			{
				rigid.isKinematic = false;
			}
		}

		public override void OnAimUpdate(Vector3 boost, bool onlyAimArrow)
		{
			base.OnAimUpdate(boost, onlyAimArrow);
			if (lookInAimDirection && rigid != null)
			{
				float angle = Vector2.SignedAngle(Vector2.up, new Vector2(boost.x, boost.y));
				rigid.MoveRotation(angle);
			}
		}

		public override void OnShoot(Vector3 boost)
		{
			base.OnShoot(boost);
			if (GolfBallController != null)
			{
				Vector3 normal = GolfBallController.GetPlane(GolfBallController.planeType).normal;
				Vector3 axis = Vector3.Cross(boost, normal);
				if (!zeroPitchIfNotGrouneded || GolfBallController.IsGrounded)
				{
					boost = Quaternion.AngleAxis(pitch, axis) * boost;
				}
			}
			StandardShoot(boost, 0f, minShootVelocity, fullShootVelocity > 0f ? fullShootVelocity : 25f, spin);
		}
	}
}
