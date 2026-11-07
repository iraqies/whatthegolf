using System;
using System.Collections.Generic;
using Cinemachine;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x20002B0")]
[ExecuteInEditMode]
public class CinemachinePlatformSpecificSettings : CinemachineExtension
{
	[Serializable]
	[Token(Token = "0x20002B1")]
	public class PlatformCameraSettings
	{
		[Token(Token = "0x4000E6C")]
		[FieldOffset(Offset = "0x10")]
		public AvailablePlatformsEnum Platform;

		[Token(Token = "0x4000E6D")]
		[FieldOffset(Offset = "0x14")]
		public float FieldOfView;

		[Token(Token = "0x4000E6E")]
		[FieldOffset(Offset = "0x18")]
		public Vector3 BodyFollowOffset;

		[Token(Token = "0x6000C5A")]
		[Address(RVA = "0x1786EE8", Offset = "0x1786EE8", VA = "0x1786EE8")]
		public PlatformCameraSettings()
		{
		}
	}

	[Token(Token = "0x20002B2")]
	public enum AvailablePlatformsEnum
	{
		[Token(Token = "0x4000E70")]
		Mobile = 0,
		[Token(Token = "0x4000E71")]
		NonMobile = 1
	}

	[Token(Token = "0x4000E6B")]
	[FieldOffset(Offset = "0x28")]
	public List<PlatformCameraSettings> Settings;

	[Token(Token = "0x6000C55")]
	[Address(RVA = "0x189DF4C", Offset = "0x189DF4C", VA = "0x189DF4C", Slot = "7")]
	protected override void PostPipelineStageCallback(CinemachineVirtualCameraBase vcam, CinemachineCore.Stage stage, ref CameraState state, float deltaTime)
	{
	}

	[Token(Token = "0x6000C56")]
	[Address(RVA = "0x189E060", Offset = "0x189E060", VA = "0x189E060")]
	public static Vector2 GetMainGameViewSize()
	{
		return default;
	}

	[Token(Token = "0x6000C57")]
	[Address(RVA = "0x189E188", Offset = "0x189E188", VA = "0x189E188")]
	private AvailablePlatformsEnum GetPlatform()
	{
		return default;
	}

	[Token(Token = "0x6000C58")]
	[Address(RVA = "0x189E1EC", Offset = "0x189E1EC", VA = "0x189E1EC")]
	public CinemachinePlatformSpecificSettings()
	{
	}

	[Token(Token = "0x6000C59")]
	[Address(RVA = "0x189E1F4", Offset = "0x189E1F4", VA = "0x189E1F4")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6053C", Offset = "0x6053C")]
	private bool _003CPostPipelineStageCallback_003Eb__3_0(PlatformCameraSettings s)
	{
		return default;
	}
}
