using Core;
using UnityEngine;

public class WallGrab : MonoBehaviour
{
	public LayerMask WallLayers;

	public float GrabDelay = 0.25f;

	public float BreakForce = float.PositiveInfinity;

	public float BreakTorque = float.PositiveInfinity;

	private FixedJoint joint;

	private void Start()
	{
		if (Level.Instance != null)
		{
			if (Level.Instance.Ball != null)
			{
				Level.Instance.Ball.OnShoot += Ball_OnShoot;
			}
			Level.Instance.OnOutOfBounds += Instance_OnOutOfBounds;
		}
	}

	private void Instance_OnOutOfBounds()
	{
		if (joint != null)
		{
			Object.Destroy(joint);
		}
	}

	private void Update()
	{
		if (GrabDelay > 0f)
		{
			GrabDelay -= Time.deltaTime;
		}
	}

	private void Ball_OnShoot(Vector3 boost)
	{
		if (joint != null)
		{
			Object.Destroy(joint);
		}
		GrabDelay = 0.2f;
	}

	private void OnCollisionEnter(Collision other)
	{
		if (GrabDelay > 0f || joint != null || other == null || other.gameObject == null)
		{
			return;
		}
		if (((1 << other.gameObject.layer) & WallLayers.value) != 0)
		{
			joint = gameObject.AddComponent<FixedJoint>();
			joint.breakForce = BreakForce;
			joint.breakTorque = BreakTorque;
			joint.connectedBody = other.rigidbody;
			joint.enablePreprocessing = false;
		}
	}
}
