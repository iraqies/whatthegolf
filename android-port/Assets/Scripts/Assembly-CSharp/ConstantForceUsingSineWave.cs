using UnityEngine;

public class ConstantForceUsingSineWave : MonoBehaviour
{
	public Vector3 ForceAxis;

	public Vector3 RelativeForceAxis;

	public Vector3 TorqueAxis;

	public Vector3 RelativeTorqueAxis;

	public float Speed = 1f;

	public float Strength = 1f;

	public float TimeOffset;

	private ConstantForce force;

	private void Start()
	{
		force = GetComponent<ConstantForce>();
	}

	private void FixedUpdate()
	{
		if (force == null) return;
		float s = Mathf.Sin((Time.time + TimeOffset) * Speed) * Strength;
		force.relativeForce = RelativeForceAxis * s;
		force.force = ForceAxis * s;
		force.torque = TorqueAxis * s;
		force.relativeTorque = RelativeTorqueAxis * s;
	}
}
