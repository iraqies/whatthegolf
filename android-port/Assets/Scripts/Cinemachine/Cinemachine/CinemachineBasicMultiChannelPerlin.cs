using Il2CppDummyDll;
using UnityEngine;

namespace Cinemachine
{
	[Token(Token = "0x200003C")]
	public class CinemachineBasicMultiChannelPerlin : CinemachineComponentBase
	{
		[Token(Token = "0x400012B")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "FormerlySerializedAsAttribute", RVA = "0x787E8", Offset = "0x787E8")]
		public NoiseSettings m_NoiseProfile;

		[Token(Token = "0x400012C")]
		[FieldOffset(Offset = "0x58")]
		public Vector3 m_PivotOffset;

		[Token(Token = "0x400012D")]
		[FieldOffset(Offset = "0x64")]
		public float m_AmplitudeGain;

		[Token(Token = "0x400012E")]
		[FieldOffset(Offset = "0x68")]
		public float m_FrequencyGain;

		[Token(Token = "0x400012F")]
		[FieldOffset(Offset = "0x6C")]
		private bool mInitialized;

		[Token(Token = "0x4000130")]
		[FieldOffset(Offset = "0x70")]
		private float mNoiseTime;

		[Token(Token = "0x4000131")]
		[FieldOffset(Offset = "0x74")]
		[SerializeField]
		private Vector3 mNoiseOffsets;

		[Token(Token = "0x17000048")]
		public override bool IsValid
		{
			[Token(Token = "0x6000169")]
			[Address(RVA = "0x18E0D7C", Offset = "0x18E0D7C", VA = "0x18E0D7C", Slot = "4")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000049")]
		public override CinemachineCore.Stage Stage
		{
			[Token(Token = "0x600016A")]
			[Address(RVA = "0x18E0E0C", Offset = "0x18E0E0C", VA = "0x18E0E0C", Slot = "6")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x600016B")]
		[Address(RVA = "0x18E0E14", Offset = "0x18E0E14", VA = "0x18E0E14", Slot = "7")]
		public override void MutateCameraState(ref CameraState curState, float deltaTime)
		{
		}

		[Token(Token = "0x600016C")]
		[Address(RVA = "0x18E1184", Offset = "0x18E1184", VA = "0x18E1184")]
		public void ReSeed()
		{
		}

		[Token(Token = "0x600016D")]
		[Address(RVA = "0x18E10C8", Offset = "0x18E10C8", VA = "0x18E10C8")]
		private void Initialize()
		{
		}

		[Token(Token = "0x600016E")]
		[Address(RVA = "0x18E1200", Offset = "0x18E1200", VA = "0x18E1200")]
		public CinemachineBasicMultiChannelPerlin()
		{
		}
	}
}
