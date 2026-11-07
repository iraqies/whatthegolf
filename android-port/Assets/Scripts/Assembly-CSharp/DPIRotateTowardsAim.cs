using UnityEngine;

public class DPIRotateTowardsAim : BaseDailyPrizeInteractions
{
	[SerializeField]
	private Rigidbody _rb;

	[SerializeField]
	private bool useLocalUp;

	[SerializeField]
	private float LookInAimDirectionSpeed;

	public override void OnAimNotWrapped(Vector3 b)
	{
	}
}
