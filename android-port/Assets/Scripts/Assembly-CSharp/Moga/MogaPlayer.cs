using System.Collections;
using Core;
using UnityEngine;

namespace Moga
{
	public class MogaPlayer : MogaEntity
	{
		public LayerMask DamageLayer;

		public float MinDamgeVelocity;

		private Rigidbody rigidbody;

		private GolfBallController controller;

		protected override void Start()
		{
		}

		protected override void SelectNewTarget()
		{
		}

		protected override void Die()
		{
		}

		private IEnumerator DelayDeath()
		{
			return null;
		}

		private void OnCollisionEnter(Collision other)
		{
		}
	}
}
