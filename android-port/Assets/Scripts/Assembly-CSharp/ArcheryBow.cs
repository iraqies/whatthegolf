using System.Collections;
using Core;
using UnityEngine;

public class ArcheryBow : MonoBehaviour
{
	[SerializeField]
	private GolfBallController archerController;

	[SerializeField]
	private GolfBallController bowController;

	[SerializeField]
	private GolfBallShooterExperimental bowShooter;

	[SerializeField]
	private Rigidbody bowRb;

	private Collider[] archerColliders;

	private Collider[] bowColliders;

	private void Start()
	{
	}

	private void ArcherController_OnShoot(Vector3 boost)
	{
	}

	private IEnumerator ReenableCollisionsAfterDelay(float delay)
	{
		return null;
	}

	private void SetCollisionsWithArcher(bool ignoreCollision)
	{
	}
}
