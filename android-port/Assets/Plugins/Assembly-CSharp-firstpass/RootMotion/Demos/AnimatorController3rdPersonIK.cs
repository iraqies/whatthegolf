using Il2CppDummyDll;
using RootMotion.FinalIK;
using UnityEngine;

namespace RootMotion.Demos
{
	[Token(Token = "0x20001F1")]
	[Attribute(Name = "RequireComponent", RVA = "0x339F4", Offset = "0x339F4")]
	[Attribute(Name = "RequireComponent", RVA = "0x339F4", Offset = "0x339F4")]
	public class AnimatorController3rdPersonIK : AnimatorController3rdPerson
	{
		[Token(Token = "0x4000D1B")]
		[FieldOffset(Offset = "0x5C")]
		[Attribute(Name = "RangeAttribute", RVA = "0x36C64", Offset = "0x36C64")]
		public float headLookWeight;

		[Token(Token = "0x4000D1C")]
		[FieldOffset(Offset = "0x60")]
		public Vector3 gunHoldOffset;

		[Token(Token = "0x4000D1D")]
		[FieldOffset(Offset = "0x6C")]
		public Vector3 leftHandOffset;

		[Token(Token = "0x4000D1E")]
		[FieldOffset(Offset = "0x78")]
		public Recoil recoil;

		[Token(Token = "0x4000D1F")]
		[FieldOffset(Offset = "0x80")]
		private AimIK aim;

		[Token(Token = "0x4000D20")]
		[FieldOffset(Offset = "0x88")]
		private FullBodyBipedIK ik;

		[Token(Token = "0x4000D21")]
		[FieldOffset(Offset = "0x90")]
		private Vector3 headLookAxis;

		[Token(Token = "0x4000D22")]
		[FieldOffset(Offset = "0x9C")]
		private Vector3 leftHandPosRelToRightHand;

		[Token(Token = "0x4000D23")]
		[FieldOffset(Offset = "0xA8")]
		private Quaternion leftHandRotRelToRightHand;

		[Token(Token = "0x4000D24")]
		[FieldOffset(Offset = "0xB8")]
		private Vector3 aimTarget;

		[Token(Token = "0x4000D25")]
		[FieldOffset(Offset = "0xC4")]
		private Quaternion rightHandRotation;

		[Token(Token = "0x6000DD0")]
		[Address(RVA = "0x12EEEB0", Offset = "0x12EEEB0", VA = "0x12EEEB0", Slot = "4")]
		protected override void Start()
		{
		}

		[Token(Token = "0x6000DD1")]
		[Address(RVA = "0x12EF074", Offset = "0x12EF074", VA = "0x12EF074", Slot = "5")]
		public override void Move(Vector3 moveInput, bool isMoving, Vector3 faceDirection, Vector3 aimTarget)
		{
		}

		[Token(Token = "0x6000DD2")]
		[Address(RVA = "0x12EF130", Offset = "0x12EF130", VA = "0x12EF130")]
		private void Read()
		{
		}

		[Token(Token = "0x6000DD3")]
		[Address(RVA = "0x12EF224", Offset = "0x12EF224", VA = "0x12EF224")]
		private void AimIK()
		{
		}

		[Token(Token = "0x6000DD4")]
		[Address(RVA = "0x12EF260", Offset = "0x12EF260", VA = "0x12EF260")]
		private void FBBIK()
		{
		}

		[Token(Token = "0x6000DD5")]
		[Address(RVA = "0x12EF668", Offset = "0x12EF668", VA = "0x12EF668")]
		private void OnPreRead()
		{
		}

		[Token(Token = "0x6000DD6")]
		[Address(RVA = "0x12EF4F0", Offset = "0x12EF4F0", VA = "0x12EF4F0")]
		private void HeadLookAt(Vector3 lookAtTarget)
		{
		}

		[Token(Token = "0x6000DD7")]
		[Address(RVA = "0x12EF8DC", Offset = "0x12EF8DC", VA = "0x12EF8DC")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000DD8")]
		[Address(RVA = "0x12EF9F8", Offset = "0x12EF9F8", VA = "0x12EF9F8")]
		public AnimatorController3rdPersonIK()
		{
		}
	}
}
