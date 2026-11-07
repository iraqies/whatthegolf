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
	}

	public void Lock(bool b)
	{
	}

	protected override void PostPipelineStageCallback(CinemachineVirtualCameraBase vcam, CinemachineCore.Stage stage, ref CameraState state, float deltaTime)
	{
	}
}
