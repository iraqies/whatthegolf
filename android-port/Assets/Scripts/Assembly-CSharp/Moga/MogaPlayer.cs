using System.Collections;
using Core;
using UnityEngine;

namespace Moga
{
	public class MogaPlayer : MogaEntity
	{
		public LayerMask DamageLayer;

		public float MinDamgeVelocity = 2f;

		private Rigidbody rigidbody;

		private GolfBallController controller;

		protected override void Start()
		{
			base.Start();
			controller = GetComponent<GolfBallController>();
			rigidbody = GetComponent<Rigidbody>();
			currentTarget = null;
		}

		protected override void SelectNewTarget()
		{
		}

		protected override void Die()
		{
			StartCoroutine(DelayDeath());
		}

		private IEnumerator DelayDeath()
		{
			if (controller != null)
			{
				controller.enabled = false;
			}
			CurrentHealth = StartHealth;
			if (controller != null)
			{
				controller.OutOfBounds("Died", 0f);
			}
			yield return new WaitForSeconds(0.5f);
			if (rigidbody != null)
			{
				rigidbody.velocity = Vector3.zero;
				rigidbody.angularVelocity = Vector3.zero;
			}
			if (controller != null)
			{
				controller.enabled = true;
			}
		}

		private void OnCollisionEnter(Collision other)
		{
			if (other == null || other.gameObject == null || rigidbody == null)
			{
				return;
			}
			if (rigidbody.velocity.magnitude >= MinDamgeVelocity && ((1 << other.gameObject.layer) & DamageLayer.value) != 0)
			{
				MogaEntity entity = other.gameObject.GetComponent<MogaEntity>();
				if (entity != null && entity.TeamIndex != TeamIndex)
				{
					entity.TakeDamage(Damage);
				}
			}
		}
	}
}
