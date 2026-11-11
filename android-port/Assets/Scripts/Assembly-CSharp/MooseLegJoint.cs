using UnityEngine;

public class MooseLegJoint : MonoBehaviour
{
	public Vector3 Axis = new Vector3(1f, 0f, 0f);

	public HingeJoint Joint;

	public float RunSpeed = 1f;

	public float StartOffset;

	public Vector2 AngleRange = new Vector2(200f, 150f);

	private float timer;

	private JointMotor motor;

	public void UpdateJoint(float speed)
	{
		timer += speed * Time.deltaTime;
		motor.targetVelocity = Mathf.Lerp(AngleRange.x, AngleRange.y, Mathf.SmoothStep(0f, 1f, Mathf.PingPong(timer, 1f)));
		if (Joint != null)
		{
			Joint.motor = motor;
		}
	}

	public void Toggle(bool state)
	{
		if (Joint != null)
		{
			Joint.useMotor = state;
			Joint.useLimits = state;
		}
	}

	public void Init()
	{
		timer = StartOffset;
		if (Joint != null)
		{
			motor = Joint.motor;
		}
	}
}
