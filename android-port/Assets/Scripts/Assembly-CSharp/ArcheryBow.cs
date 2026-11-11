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
		archerController.OnShoot += ArcherController_OnShoot;
		archerColliders = archerController.GetComponentsInChildren<Collider>();
		bowColliders = bowShooter.GetComponentsInChildren<Collider>();
		SetCollisionsWithArcher(true);
	}

	private void ArcherController_OnShoot(Vector3 boost)
	{
		archerController.OnShoot -= ArcherController_OnShoot;
		bowShooter.gameObject.transform.parent = null;
		archerController.enabled = false;
		bowController.enabled = true;
		bowRb.isKinematic = false;
		bowShooter.OnShoot(boost);
		StartCoroutine(ReenableCollisionsAfterDelay(0.5f));
		Debug.DrawRay(base.transform.position, boost, Color.red, 5f);
	}

	private IEnumerator ReenableCollisionsAfterDelay(float delay)
	{
		yield return new WaitForSeconds(delay);
		SetCollisionsWithArcher(false);
	}

	private void SetCollisionsWithArcher(bool ignoreCollision)
	{
		for (int i = 0; i < archerColliders.Length; i++)
		{
			for (int j = 0; j < bowColliders.Length; j++)
			{
				Physics.IgnoreCollision(archerColliders[i], bowColliders[j], ignoreCollision);
			}
		}
	}
}
