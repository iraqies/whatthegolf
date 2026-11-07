using UnityEngine;

public class MooseLegJoint : MonoBehaviour
{
	public Vector3 Axis;

	public HingeJoint Joint;

	public float RunSpeed;

	public float StartOffset;

	public Vector2 AngleRange;

	private float timer;

	private JointMotor motor;

	public void UpdateJoint(float speed)
	{
	}

	public void Toggle(bool state)
	{
	}

	public void Init()
	{
	}
}
