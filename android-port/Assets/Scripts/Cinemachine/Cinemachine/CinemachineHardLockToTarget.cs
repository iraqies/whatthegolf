using Il2CppDummyDll;
using UnityEngine;

namespace Cinemachine
{
	[Token(Token = "0x2000045")]
	public class CinemachineHardLockToTarget : CinemachineComponentBase
	{
		[Token(Token = "0x4000196")]
		[FieldOffset(Offset = "0x50")]
		public float m_Damping;

		[Token(Token = "0x4000197")]
		[FieldOffset(Offset = "0x54")]
		private Vector3 m_PreviousTargetPosition;

		[Token(Token = "0x17000059")]
		public override bool IsValid
		{
			[Token(Token = "0x60001A1")]
			[Address(RVA = "0x18F8154", Offset = "0x18F8154", VA = "0x18F8154", Slot = "4")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x1700005A")]
		public override CinemachineCore.Stage Stage
		{
			[Token(Token = "0x60001A2")]
			[Address(RVA = "0x18F81EC", Offset = "0x18F81EC", VA = "0x18F81EC", Slot = "6")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x60001A3")]
		[Address(RVA = "0x18F81F4", Offset = "0x18F81F4", VA = "0x18F81F4", Slot = "7")]
		public override void MutateCameraState(ref CameraState curState, float deltaTime)
		{
		}

		[Token(Token = "0x60001A4")]
		[Address(RVA = "0x18F8288", Offset = "0x18F8288", VA = "0x18F8288")]
		public CinemachineHardLockToTarget()
		{
		}
	}
}
