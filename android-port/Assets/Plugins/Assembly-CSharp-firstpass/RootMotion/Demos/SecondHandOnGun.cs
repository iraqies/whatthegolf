using Il2CppDummyDll;
using RootMotion.FinalIK;
using UnityEngine;

namespace RootMotion.Demos
{
	[Token(Token = "0x20001E4")]
	public class SecondHandOnGun : MonoBehaviour
	{
		[Token(Token = "0x4000CA8")]
		[FieldOffset(Offset = "0x18")]
		public AimIK aim;

		[Token(Token = "0x4000CA9")]
		[FieldOffset(Offset = "0x20")]
		public LimbIK leftArmIK;

		[Token(Token = "0x4000CAA")]
		[FieldOffset(Offset = "0x28")]
		public Transform leftHand;

		[Token(Token = "0x4000CAB")]
		[FieldOffset(Offset = "0x30")]
		public Transform rightHand;

		[Token(Token = "0x4000CAC")]
		[FieldOffset(Offset = "0x38")]
		public Vector3 leftHandPositionOffset;

		[Token(Token = "0x4000CAD")]
		[FieldOffset(Offset = "0x44")]
		public Vector3 leftHandRotationOffset;

		[Token(Token = "0x4000CAE")]
		[FieldOffset(Offset = "0x50")]
		private Vector3 leftHandPosRelToRight;

		[Token(Token = "0x4000CAF")]
		[FieldOffset(Offset = "0x5C")]
		private Quaternion leftHandRotRelToRight;

		[Token(Token = "0x6000D9E")]
		[Address(RVA = "0x13F976C", Offset = "0x13F976C", VA = "0x13F976C")]
		private void Start()
		{
		}

		[Token(Token = "0x6000D9F")]
		[Address(RVA = "0x13F97B0", Offset = "0x13F97B0", VA = "0x13F97B0")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000DA0")]
		[Address(RVA = "0x13F9964", Offset = "0x13F9964", VA = "0x13F9964")]
		public SecondHandOnGun()
		{
		}
	}
}
