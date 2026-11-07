using System.Collections;
using Chronos;
using Cinemachine;
using Core;
using UnityEngine;

[ExecuteInEditMode]
public class CinemachineSmoothTimeAdjustments : CinemachineExtension
{
	[SerializeField]
	protected float startSmoothTime;

	[SerializeField]
	protected float continuousSmoothTime;

	[SerializeField]
	protected float aimSmoothTime;

	[SerializeField]
	protected bool ignoreX;

	[SerializeField]
	protected bool ignoreY;

	[SerializeField]
	protected bool ignoreZ;

	[SerializeField]
	protected bool ignoreYaw;

	[SerializeField]
	protected float continousTrackingTimer;

	protected float smoothTime;

	[SerializeField]
	protected float dampEaseing;

	protected float continousTrackingTimerCountDown;

	public LocalClock Clock;

	protected GolfBallController Ball => null;

	private void Start()
	{
	}

	private IEnumerator WaitForActiveBall()
	{
		return null;
	}

	protected override void PostPipelineStageCallback(CinemachineVirtualCameraBase vcam, CinemachineCore.Stage stage, ref CameraState state, float deltaTime)
	{
	}

	private void Update()
	{
	}
}
