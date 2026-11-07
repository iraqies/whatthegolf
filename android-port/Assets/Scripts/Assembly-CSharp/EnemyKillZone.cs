using UnityEngine;

public class EnemyKillZone : MonoBehaviour
{
	[SerializeField]
	private GameObject EnemyRoot;

	[SerializeField]
	private BoxCollider KillZone;

	[SerializeField]
	private string playerTag;

	private void OnCollisionEnter(Collision col)
	{
	}
}
