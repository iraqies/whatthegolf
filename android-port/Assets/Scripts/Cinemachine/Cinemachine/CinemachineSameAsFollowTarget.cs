using Il2CppDummyDll;
using UnityEngine;

namespace Cinemachine
{
	[Token(Token = "0x200004E")]
	public class CinemachineSameAsFollowTarget : CinemachineComponentBase
	{
		[Token(Token = "0x40001BB")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "FormerlySerializedAsAttribute", RVA = "0x78DA0", Offset = "0x78DA0")]
		public float m_Damping;

		[Token(Token = "0x40001BC")]
		[FieldOffset(Offset = "0x54")]
		private Quaternion m_PreviousReferenceOrientation;

		[Token(Token = "0x17000061")]
		public override bool IsValid
		{
			[Token(Token = "0x60001CA")]
			[Address(RVA = "0x18FD8F4", Offset = "0x18FD8F4", VA = "0x18FD8F4", Slot = "4")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000062")]
		public override CinemachineCore.Stage Stage
		{
			[Token(Token = "0x60001CB")]
			[Address(RVA = "0x18FD98C", Offset = "0x18FD98C", VA = "0x18FD98C", Slot = "6")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x60001CC")]
		[Address(RVA = "0x18FD994", Offset = "0x18FD994", VA = "0x18FD994", Slot = "7")]
		public override void MutateCameraState(ref CameraState curState, float deltaTime)
		{
		}

		[Token(Token = "0x60001CD")]
		[Address(RVA = "0x18FDA64", Offset = "0x18FDA64", VA = "0x18FDA64")]
		public CinemachineSameAsFollowTarget()
		{
		}
	}
}
