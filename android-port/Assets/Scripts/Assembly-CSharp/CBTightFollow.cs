using CameraStack;
using UnityEngine;

public class CBTightFollow : CameraBehaviorPerspective
{
	[SerializeField]
	private Vector3 offset;

	[SerializeField]
	private Vector3 rotation;

	[SerializeField]
	private bool useBallForward;

	public override Quaternion CalculateRotation()
	{
		return default;
	}

	protected override Vector3 CalculatePosition()
	{
		return default;
	}
}
