using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.AI;

namespace Moga
{
	public class MogaEntity : MonoBehaviour
	{
		public float AttackRange = 3f;

		public float StartHealth = 100f;

		public float AttackInterval = 1f;

		public float Damage = 10f;

		public int TeamIndex;

		public LayerMask AttackLayer;

		public Transform AttackMuzzle;

		public Transform AttackBase;

		public float CurrentHealth;

		[SerializeField]
		private List<MogaEntity> entitiesInRange = new List<MogaEntity>();

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
			lineRenderer = GetComponent<LineRenderer>();
			renderer = GetComponentInChildren<MeshRenderer>();
			agent = GetComponent<NavMeshAgent>();
			entitiesInRange = new List<MogaEntity>();
			attackTimer = AttackInterval;
			gameController = Object.FindObjectOfType<MogaGameController>();
			if (gameController != null)
			{
				MogaGameController.MogaTeamInfo info = gameController.GetBaseInfoForTeam(TeamIndex);
				if (info != null && renderer != null)
				{
					renderer.material.color = info.TeamColor;
				}
			}
			if (renderer != null)
			{
				startColor = renderer.material.color;
				targetColor = startColor;
			}
			Collider = GetComponent<Collider>();
			CurrentHealth = StartHealth;
			if (gameController != null)
			{
				gameController.RegisterEntity(this);
			}
		}

		private void Update()
		{
			attackTimer += Time.deltaTime;
			if (currentTarget != null)
			{
				Vector3 targetPoint = currentTarget.Collider != null ? currentTarget.Collider.ClosestPoint(transform.position) : currentTarget.transform.position;
				float dist = Vector3.Distance(transform.position, targetPoint);
				if (dist > AttackRange)
				{
					SetNavMeshTarget(currentTarget.transform.position);
				}
				else if (attackTimer >= AttackInterval)
				{
					AttackTarget();
					attackTimer = 0f;
				}
				if (AttackBase != null)
				{
					Vector3 dir = (currentTarget.transform.position - AttackBase.position).normalized;
					if (dir.sqrMagnitude > 0.0001f)
					{
						AttackBase.rotation = Quaternion.RotateTowards(AttackBase.rotation, Quaternion.LookRotation(dir), 360f * Time.deltaTime);
					}
				}
			}
			if (damageTimer > 0f)
			{
				damageTimer -= Time.deltaTime * 5f;
				if (renderer != null)
				{
					renderer.material.color = Color.Lerp(startColor, targetColor, Mathf.Clamp01(damageTimer));
				}
			}
			if (lineTimer > 0f)
			{
				lineTimer -= Time.deltaTime * 10f;
				if (lineRenderer != null)
				{
					lineRenderer.widthMultiplier = Mathf.Max(0f, lineTimer);
				}
			}
		}

		private void AttackTarget()
		{
			if (currentTarget == null)
			{
				return;
			}
			if (AttackMuzzle != null && lineRenderer != null)
			{
				lineRenderer.positionCount = 2;
				lineRenderer.SetPosition(0, AttackMuzzle.position);
				lineRenderer.SetPosition(1, currentTarget.transform.position);
				lineTimer = 1f;
			}
			currentTarget.TakeDamage(Damage);
			if (currentTarget == null || currentTarget.CurrentHealth <= 0f)
			{
				SelectNewTarget();
			}
		}

		private void OnTriggerEnter(Collider other)
		{
			CheckObject(other);
		}

		private void OnTriggerExit(Collider other)
		{
			CheckObject(other);
		}

		protected virtual void SelectNewTarget()
		{
			if (entitiesInRange != null)
			{
				entitiesInRange.RemoveAll(e => e == null || e.CurrentHealth <= 0f);
				if (entitiesInRange.Count > 0)
				{
					currentTarget = entitiesInRange.OrderBy(e => Vector3.Distance(transform.position, e.transform.position)).FirstOrDefault();
				}
				else
				{
					currentTarget = null;
				}
			}
			if (currentTarget == null && agent != null && gameController != null)
			{
				int enemyTeam = TeamIndex == 0 ? 1 : 0;
				MogaGameController.MogaTeamInfo info = gameController.GetBaseInfoForTeam(enemyTeam);
				if (info != null)
				{
					currentTarget = info.HomeBase;
				}
			}
			if (currentTarget != null)
			{
				SetNavMeshTarget(currentTarget.transform.position);
			}
		}

		private void CheckObject(Collider col)
		{
			if (col == null || ((1 << col.gameObject.layer) & AttackLayer.value) == 0)
			{
				return;
			}
			MogaEntity otherEntity = col.gameObject.GetComponent<MogaEntity>();
			if (otherEntity == null || otherEntity.TeamIndex == TeamIndex)
			{
				return;
			}
			if (entitiesInRange.Contains(otherEntity))
			{
				entitiesInRange.Remove(otherEntity);
				if (currentTarget == otherEntity)
				{
					currentTarget = null;
					SelectNewTarget();
				}
			}
			else
			{
				entitiesInRange.Add(otherEntity);
				if (currentTarget == null || Vector3.Distance(transform.position, otherEntity.transform.position) < Vector3.Distance(transform.position, currentTarget.transform.position))
				{
					currentTarget = otherEntity;
					SetNavMeshTarget(currentTarget.transform.position);
				}
			}
		}

		protected virtual void Die()
		{
			Object.Destroy(gameObject);
		}

		public void StartEntity()
		{
			if (agent != null)
			{
				agent.enabled = true;
			}
			SelectNewTarget();
		}

		public void TakeDamage(float damage)
		{
			damageTimer = 1f;
			targetColor = damage >= 0f ? Color.red : Color.green;
			CurrentHealth = Mathf.Clamp(CurrentHealth - damage, 0f, StartHealth);
			if (CurrentHealth <= 0f)
			{
				Die();
			}
		}

		public void SetNavMeshTarget(Vector3 pos)
		{
			if (agent != null && agent.isActiveAndEnabled && lastNavmeshTarget != pos)
			{
				lastNavmeshTarget = pos;
				agent.SetDestination(pos);
			}
		}

		private void OnDrawGizmos()
		{
			if (currentTarget != null)
			{
				Gizmos.DrawLine(transform.position, currentTarget.transform.position);
			}
		}
	}
}
