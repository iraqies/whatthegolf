using Cinemachine;
using UnityEngine;

[ExecuteInEditMode]
public class CMFreezePos : CinemachineExtension
{
	public bool continious;

	public bool lockX;

	public float xPosition;

	public bool lockY;

	public float yPosition;

	public bool lockZ;

	public float zPosition;

	protected override void Awake()
	{
		base.Awake();
	}

	public void Lock(bool b)
	{
		lockX = b;
		lockY = b;
		lockZ = b;
		xPosition = transform.position.x;
		yPosition = transform.position.y;
		zPosition = transform.position.z;
	}

	protected override void PostPipelineStageCallback(CinemachineVirtualCameraBase vcam, CinemachineCore.Stage stage, ref CameraState state, float deltaTime)
	{
		if (stage == CinemachineCore.Stage.Body)
		{
			Vector3 pos = state.RawPosition;
			if (lockX)
			{
				pos.x = xPosition;
			}
			if (lockY)
			{
				pos.y = yPosition;
			}
			if (lockZ)
			{
				pos.z = zPosition;
			}
			state.RawPosition = pos;
		}
	}
}
