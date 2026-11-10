using Core;
using UnityEngine;

public class ReplicatingHoleShooter : ShooterBase
{
	public GameObject replicatingHolePrefab;

	private Animator animator;

	private GameObject instantiatedNextHole;

	private void Start()
	{
		animator = GetComponent<Animator>();
	}

	public override void OnShoot(Vector3 boost)
	{
		Vector3 dir = boost.normalized;
		if (replicatingHolePrefab != null)
		{
			instantiatedNextHole = Instantiate(replicatingHolePrefab);
			if (instantiatedNextHole != null)
			{
				instantiatedNextHole.transform.position = transform.position + dir * 11f;
			}
		}
		if (animator != null)
		{
			animator.SetTrigger("Complete");
		}
		GolfBallController ctrl = GetComponent<GolfBallController>();
		if (ctrl != null)
		{
			Destroy(ctrl);
		}
	}
}
