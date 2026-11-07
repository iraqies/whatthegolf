using UnityEngine;

public class DPIApplyForce : BaseDailyPrizeInteractions
{
	[SerializeField]
	private bool UseDirection;

	[SerializeField]
	private Transform TowardsSomewhere;

	[SerializeField]
	private Rigidbody rigidBody;

	[SerializeField]
	private float multiply;

	[SerializeField]
	private float randomTorque;

	public Vector3 defaultVectorIfZero;

	public override void OnShootNotWrapped(Vector3 b)
	{
	}

	private float RandomTourqueFloat(Vector3 b)
	{
		return 0f;
	}

	public override void OnAimNotWrapped(Vector3 b)
	{
	}

	private Vector3 GetDir(Vector3 b)
	{
		return default;
	}
}
