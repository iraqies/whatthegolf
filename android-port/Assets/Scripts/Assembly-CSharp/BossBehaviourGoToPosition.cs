using UnityEngine;

public class BossBehaviourGoToPosition : BossBehaviour
{
	public Vector3 EndPosition;

	public float Speed;

	public override Vector3 Position => default;

	public override Quaternion Rotation => default;
}
