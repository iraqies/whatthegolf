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
		if (!ExecuteOnShoot)
			return;

		if (UseDirection)
		{
			b = GetDir(b);
		}
		Vector3 force = b * multiply;
		base.OnShootNotWrapped(force);
		if (rigidBody != null)
		{
			rigidBody.AddForce(force * multiply);
			if (randomTorque > 0f)
			{
				rigidBody.AddTorque(new Vector3(RandomTourqueFloat(force), RandomTourqueFloat(force), RandomTourqueFloat(force)));
			}
		}
	}

	private float RandomTourqueFloat(Vector3 b)
	{
		float m = b.magnitude;
		return Random.Range(-randomTorque * m, randomTorque * m);
	}

	public override void OnAimNotWrapped(Vector3 b)
	{
		if (!ExecuteOnAim)
			return;

		if (UseDirection)
		{
			b = GetDir(b);
		}
		Vector3 force = b * multiply;
		base.OnAimNotWrapped(force);
		if (rigidBody != null)
		{
			rigidBody.AddForce(force * multiply);
		}
	}

	private Vector3 GetDir(Vector3 b)
	{
		if (TowardsSomewhere == null || rigidBody == null)
			return b;

		float mag = b.magnitude;
		return (TowardsSomewhere.position - rigidBody.transform.position).normalized * mag;
	}
}
