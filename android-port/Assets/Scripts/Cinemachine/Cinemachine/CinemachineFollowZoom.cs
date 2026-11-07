using Il2CppDummyDll;
using UnityEngine;

namespace Cinemachine
{
	[Token(Token = "0x200001E")]
	[ExecuteAlways]
	public class CinemachineFollowZoom : CinemachineExtension
	{
		[Token(Token = "0x200001F")]
		private class VcamExtraState
		{
			[Token(Token = "0x4000099")]
			[FieldOffset(Offset = "0x10")]
			public float m_previousFrameZoom;

			[Token(Token = "0x60000A2")]
			[Address(RVA = "0x190FF24", Offset = "0x190FF24", VA = "0x190FF24")]
			public VcamExtraState()
			{
			}
		}

		[Token(Token = "0x4000095")]
		[FieldOffset(Offset = "0x28")]
		public float m_Width;

		[Token(Token = "0x4000096")]
		[FieldOffset(Offset = "0x2C")]
		[Attribute(Name = "RangeAttribute", RVA = "0x78480", Offset = "0x78480")]
		public float m_Damping;

		[Token(Token = "0x4000097")]
		[FieldOffset(Offset = "0x30")]
		[Attribute(Name = "RangeAttribute", RVA = "0x78498", Offset = "0x78498")]
		public float m_MinFOV;

		[Token(Token = "0x4000098")]
		[FieldOffset(Offset = "0x34")]
		[Attribute(Name = "RangeAttribute", RVA = "0x784B4", Offset = "0x784B4")]
		public float m_MaxFOV;

		[Token(Token = "0x600009F")]
		[Address(RVA = "0x18F15AC", Offset = "0x18F15AC", VA = "0x18F15AC")]
		private void OnValidate()
		{
		}

		[Token(Token = "0x60000A0")]
		[Address(RVA = "0x18F1610", Offset = "0x18F1610", VA = "0x18F1610", Slot = "7")]
		protected override void PostPipelineStageCallback(CinemachineVirtualCameraBase vcam, CinemachineCore.Stage stage, ref CameraState state, float deltaTime)
		{
		}

		[Token(Token = "0x60000A1")]
		[Address(RVA = "0x18F1870", Offset = "0x18F1870", VA = "0x18F1870")]
		public CinemachineFollowZoom()
		{
		}
	}
}
