using UnityEngine;

public class ConstantForceUsingSineWave : MonoBehaviour
{
	public Vector3 ForceAxis;

	public Vector3 RelativeForceAxis;

	public Vector3 TorqueAxis;

	public Vector3 RelativeTorqueAxis;

	public float Speed;

	public float Strength;

	public float TimeOffset;

	private ConstantForce force;

	private void Start()
	{
	}

	private void FixedUpdate()
	{
	}
}
