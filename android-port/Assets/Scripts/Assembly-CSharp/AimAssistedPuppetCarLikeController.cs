using UnityEngine;

public class AimAssistedPuppetCarLikeController : PuppetCarLikeController
{
	public float angleThresholdToCorrect;

	public Transform flagPosition;

	private bool shotTowardsFlag;

	public override void OnShoot(Vector3 boost)
	{
	}

	protected override void Update()
	{
	}
}
