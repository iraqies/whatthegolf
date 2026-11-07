using System;
using System.Collections.Generic;
using Cinemachine;
using UnityEngine;

[ExecuteInEditMode]
public class CinemachinePlatformSpecificSettings : CinemachineExtension
{
	[Serializable]
	public class PlatformCameraSettings
	{
		public AvailablePlatformsEnum Platform;

		public float FieldOfView;

		public Vector3 BodyFollowOffset;
	}

	public enum AvailablePlatformsEnum
	{
		Mobile = 0,
		NonMobile = 1
	}

	public List<PlatformCameraSettings> Settings;

	protected override void PostPipelineStageCallback(CinemachineVirtualCameraBase vcam, CinemachineCore.Stage stage, ref CameraState state, float deltaTime)
	{
	}

	public static Vector2 GetMainGameViewSize()
	{
		return default;
	}

	private AvailablePlatformsEnum GetPlatform()
	{
		return AvailablePlatformsEnum.Mobile;
	}
}
