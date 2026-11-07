using UnityEngine;

public class MoveToClosestPointInCollider : MonoBehaviour
{
	[SerializeField]
	private Transform m_proximityTarget;

	[SerializeField]
	private Transform targetToMove;

	[SerializeField]
	private float checkCooldown;

	[SerializeField]
	private Collider[] m_collider;

	[SerializeField]
	private Collider2D[] m_collider2D;

	private float m_lastCheckTime;

	private void FixedUpdate()
	{
	}
}
