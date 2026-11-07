using UnityEngine;

public class BossBehaviourResetToMiddle : BossBehaviour
{
	public float MiddlePositionX;

	public float Speed;

	public float ForwardSpeed;

	public override Vector3 Position => default;

	public override Quaternion Rotation => default;
}
