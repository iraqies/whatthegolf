using Il2CppDummyDll;
using RootMotion.FinalIK;
using UnityEngine;

namespace RootMotion.Demos
{
	[Token(Token = "0x20001FE")]
	public class HoldingHands : MonoBehaviour
	{
		[Token(Token = "0x4000D6E")]
		[FieldOffset(Offset = "0x18")]
		public FullBodyBipedIK rightHandChar;

		[Token(Token = "0x4000D6F")]
		[FieldOffset(Offset = "0x20")]
		public FullBodyBipedIK leftHandChar;

		[Token(Token = "0x4000D70")]
		[FieldOffset(Offset = "0x28")]
		public Transform rightHandTarget;

		[Token(Token = "0x4000D71")]
		[FieldOffset(Offset = "0x30")]
		public Transform leftHandTarget;

		[Token(Token = "0x4000D72")]
		[FieldOffset(Offset = "0x38")]
		public float crossFade;

		[Token(Token = "0x4000D73")]
		[FieldOffset(Offset = "0x3C")]
		public float speed;

		[Token(Token = "0x4000D74")]
		[FieldOffset(Offset = "0x40")]
		private Quaternion rightHandRotation;

		[Token(Token = "0x4000D75")]
		[FieldOffset(Offset = "0x50")]
		private Quaternion leftHandRotation;

		[Token(Token = "0x6000E07")]
		[Address(RVA = "0x13838DC", Offset = "0x13838DC", VA = "0x13838DC")]
		private void Start()
		{
		}

		[Token(Token = "0x6000E08")]
		[Address(RVA = "0x1383AC0", Offset = "0x1383AC0", VA = "0x1383AC0")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000E09")]
		[Address(RVA = "0x1383E64", Offset = "0x1383E64", VA = "0x1383E64")]
		public HoldingHands()
		{
		}
	}
}
