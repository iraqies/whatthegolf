using Il2CppDummyDll;
using UnityEngine;

namespace Cinemachine
{
	[Token(Token = "0x2000086")]
	[ExecuteAlways]
	public class CinemachineImpulseListener : CinemachineExtension
	{
		[Token(Token = "0x40002EF")]
		[FieldOffset(Offset = "0x28")]
		public int m_ChannelMask;

		[Token(Token = "0x40002F0")]
		[FieldOffset(Offset = "0x2C")]
		public float m_Gain;

		[Token(Token = "0x40002F1")]
		[FieldOffset(Offset = "0x30")]
		public bool m_Use2DDistance;

		[Token(Token = "0x6000320")]
		[Address(RVA = "0x18F8998", Offset = "0x18F8998", VA = "0x18F8998", Slot = "7")]
		protected override void PostPipelineStageCallback(CinemachineVirtualCameraBase vcam, CinemachineCore.Stage stage, ref CameraState state, float deltaTime)
		{
		}

		[Token(Token = "0x6000321")]
		[Address(RVA = "0x18F8DD4", Offset = "0x18F8DD4", VA = "0x18F8DD4")]
		public CinemachineImpulseListener()
		{
		}
	}
}
