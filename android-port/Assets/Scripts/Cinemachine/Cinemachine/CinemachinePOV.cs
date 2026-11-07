using Il2CppDummyDll;
using UnityEngine;

namespace Cinemachine
{
	[Token(Token = "0x200004C")]
	public class CinemachinePOV : CinemachineComponentBase
	{
		[Token(Token = "0x200004D")]
		public enum RecenterTargetMode
		{
			[Token(Token = "0x40001B8")]
			None = 0,
			[Token(Token = "0x40001B9")]
			FollowTargetForward = 1,
			[Token(Token = "0x40001BA")]
			LookAtTargetForward = 2
		}

		[Token(Token = "0x40001B1")]
		[FieldOffset(Offset = "0x50")]
		public bool m_ApplyBeforeBody;

		[Token(Token = "0x40001B2")]
		[FieldOffset(Offset = "0x54")]
		public RecenterTargetMode m_RecenterTarget;

		[Token(Token = "0x40001B3")]
		[FieldOffset(Offset = "0x58")]
		public AxisState m_VerticalAxis;

		[Token(Token = "0x40001B4")]
		[FieldOffset(Offset = "0xB0")]
		public AxisState.Recentering m_VerticalRecentering;

		[Token(Token = "0x40001B5")]
		[FieldOffset(Offset = "0xD0")]
		public AxisState m_HorizontalAxis;

		[Token(Token = "0x40001B6")]
		[FieldOffset(Offset = "0x128")]
		public AxisState.Recentering m_HorizontalRecentering;

		[Token(Token = "0x1700005F")]
		public override bool IsValid
		{
			[Token(Token = "0x60001C1")]
			[Address(RVA = "0x18FB808", Offset = "0x18FB808", VA = "0x18FB808", Slot = "4")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000060")]
		public override CinemachineCore.Stage Stage
		{
			[Token(Token = "0x60001C2")]
			[Address(RVA = "0x18FB810", Offset = "0x18FB810", VA = "0x18FB810", Slot = "6")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x60001C3")]
		[Address(RVA = "0x18FB818", Offset = "0x18FB818", VA = "0x18FB818")]
		private void OnValidate()
		{
		}

		[Token(Token = "0x60001C4")]
		[Address(RVA = "0x18FB860", Offset = "0x18FB860", VA = "0x18FB860", Slot = "5")]
		public override void PrePipelineMutateCameraState(ref CameraState curState, float deltaTime)
		{
		}

		[Token(Token = "0x60001C5")]
		[Address(RVA = "0x18FBAC8", Offset = "0x18FBAC8", VA = "0x18FBAC8", Slot = "7")]
		public override void MutateCameraState(ref CameraState curState, float deltaTime)
		{
		}

		[Token(Token = "0x60001C6")]
		[Address(RVA = "0x18FB874", Offset = "0x18FB874", VA = "0x18FB874")]
		private void ApplyPOV(ref CameraState curState, float deltaTime)
		{
		}

		[Token(Token = "0x60001C7")]
		[Address(RVA = "0x18FBAD8", Offset = "0x18FBAD8", VA = "0x18FBAD8")]
		public Vector2 GetRecenterTarget()
		{
			return default;
		}

		[Token(Token = "0x60001C8")]
		[Address(RVA = "0x18FBCCC", Offset = "0x18FBCCC", VA = "0x18FBCCC", Slot = "8")]
		public override bool OnTransitionFromCamera(ICinemachineCamera fromCam, Vector3 worldUp, float deltaTime, ref CinemachineVirtualCameraBase.TransitionParams transitionParams)
		{
			return default;
		}

		[Token(Token = "0x60001C9")]
		[Address(RVA = "0x18FC0EC", Offset = "0x18FC0EC", VA = "0x18FC0EC")]
		public CinemachinePOV()
		{
		}
	}
}
