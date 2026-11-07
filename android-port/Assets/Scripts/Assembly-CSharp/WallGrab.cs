using UnityEngine;

public class WallGrab : MonoBehaviour
{
	public LayerMask WallLayers;

	public float GrabDelay;

	public float BreakForce;

	public float BreakTorque;

	private FixedJoint joint;

	private void Start()
	{
	}

	private void Instance_OnOutOfBounds()
	{
	}

	private void Update()
	{
	}

	private void Ball_OnShoot(Vector3 boost)
	{
	}

	private void OnCollisionEnter(Collision other)
	{
	}
}
