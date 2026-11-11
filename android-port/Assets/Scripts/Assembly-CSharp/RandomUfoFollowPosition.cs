using UnityEngine;

public class RandomUfoFollowPosition : MonoBehaviour
{
	public Transform Ufo;

	public float PositionRadius = 10f;

	private Vector3 startPos;

	private void Start()
	{
		startPos = transform.position;
		SetNewPosition();
	}

	private void Update()
	{
		if (Ufo != null && Vector3.Distance(transform.position, Ufo.position) < 1f)
		{
			SetNewPosition();
		}
	}

	private void SetNewPosition()
	{
		Vector3 rnd = Random.onUnitSphere;
		transform.position = startPos + new Vector3(rnd.x, 0f, rnd.z) * PositionRadius;
	}

	private void OnDrawGizmosSelected()
	{
		Gizmos.DrawWireSphere(transform.position, PositionRadius);
	}
}
