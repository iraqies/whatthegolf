using Core;
using UnityEngine;

namespace Olympics.Wrestling
{
	public class WrestlerShooter : GolfBallShooterBase
	{
		public Rigidbody pelvis;

		public Animator animator;

		public override void OnAimStart()
		{
		}

		public override void OnAimUpdate(Vector3 boost, bool onlyAimArrow)
		{
		}

		public override void OnShoot(Vector3 boost)
		{
		StandardShoot(boost, 20f, 18f, 5f);
	}
	}
}
