using Cinemachine;
using UnityEngine;

[ExecuteInEditMode]
public class CinemachineGyroShake : CinemachineExtension
{
	[SerializeField]
	private float m_RotationMagnitude;

	[SerializeField]
	private float m_xMagnitude;

	[SerializeField]
	private float m_yMagnitude;

	private float adjustmentMagnitude;

	private float perLevelMagnitude;

	private bool m_IsActive;

	private void Start()
	{
	}

	protected override void PostPipelineStageCallback(CinemachineVirtualCameraBase vcam, CinemachineCore.Stage stage, ref CameraState state, float deltaTime)
	{
	}
}
