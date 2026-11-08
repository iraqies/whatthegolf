using System.Collections;
using UnityEngine;

namespace Core
{
	public class SonicShooter : GolfBallShooterBase
	{
		private Rigidbody rb;

		private float groundLevel;

		private bool touchingGround;

		private Vector3 levitatingPos;

		public float levitatingHeight;

		public float minShootVelocity;

		public float fullShootVelocity;

		public float pitch;

		public float spin;

		private float gravity;

		private bool canAim;

		private float drag;

		private SonicBounce[] bouncers;

		public ParticleSystem particle;

		private LineRenderer line;

		public MeshRenderer ghost;

		private float thickness;

		private GolfBallController controller;

		private float freezeTime;

		private bool frozen;

		public ParticleSystem active;

		private void Start()
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
		StandardShoot(boost, 20f, 18f, 5f);
	}

		private void OnCollisionEnter(Collision other)
		{
		}

		private void Chill(Vector3 point)
		{
		}

		private IEnumerator FreezeAndShoot(Vector3 outVel, float newHigh)
		{
			return null;
		}

		private void OnCollisionExit(Collision other)
		{
		}

		private void OnCollisionStay(Collision other)
		{
		}

		protected override void FixedUpdate()
		{
		base.FixedUpdate();
	}
	}
}
