using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

namespace Moga
{
	public class MogaEntity : MonoBehaviour
	{
		public float AttackRange;

		public float StartHealth;

		public float AttackInterval;

		public float Damage;

		public int TeamIndex;

		public LayerMask AttackLayer;

		public Transform AttackMuzzle;

		public Transform AttackBase;

		public float CurrentHealth;

		[SerializeField]
		private List<MogaEntity> entitiesInRange;

		protected MogaEntity currentTarget;

		private float attackTimer;

		private NavMeshAgent agent;

		private MogaGameController gameController;

		private LineRenderer lineRenderer;

		private float damageTimer;

		private float lineTimer;

		private MeshRenderer renderer;

		private Color startColor;

		private Color targetColor;

		private Vector3 lastNavmeshTarget;

		public Collider Collider { get; private set; }

		protected virtual void Start()
		{
		}

		private void Update()
		{
		}

		private void AttackTarget()
		{
		}

		private void OnTriggerEnter(Collider other)
		{
		}

		private void OnTriggerExit(Collider other)
		{
		}

		protected virtual void SelectNewTarget()
		{
		}

		private void CheckObject(Collider col)
		{
		}

		protected virtual void Die()
		{
		}

		public void StartEntity()
		{
		}

		public void TakeDamage(float damage)
		{
		}

		public void SetNavMeshTarget(Vector3 pos)
		{
		}

		private void OnDrawGizmos()
		{
		}
	}
}
