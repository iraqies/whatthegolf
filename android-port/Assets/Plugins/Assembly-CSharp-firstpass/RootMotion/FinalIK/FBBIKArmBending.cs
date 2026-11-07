using Il2CppDummyDll;
using UnityEngine;

namespace RootMotion.FinalIK
{
	[Token(Token = "0x200015E")]
	public class FBBIKArmBending : MonoBehaviour
	{
		[Token(Token = "0x4000868")]
		[FieldOffset(Offset = "0x18")]
		public FullBodyBipedIK ik;

		[Token(Token = "0x4000869")]
		[FieldOffset(Offset = "0x20")]
		public Vector3 bendDirectionOffsetLeft;

		[Token(Token = "0x400086A")]
		[FieldOffset(Offset = "0x2C")]
		public Vector3 bendDirectionOffsetRight;

		[Token(Token = "0x400086B")]
		[FieldOffset(Offset = "0x38")]
		public Vector3 characterSpaceBendOffsetLeft;

		[Token(Token = "0x400086C")]
		[FieldOffset(Offset = "0x44")]
		public Vector3 characterSpaceBendOffsetRight;

		[Token(Token = "0x400086D")]
		[FieldOffset(Offset = "0x50")]
		private Quaternion leftHandTargetRotation;

		[Token(Token = "0x400086E")]
		[FieldOffset(Offset = "0x60")]
		private Quaternion rightHandTargetRotation;

		[Token(Token = "0x400086F")]
		[FieldOffset(Offset = "0x70")]
		private bool initiated;

		[Token(Token = "0x60009BB")]
		[Address(RVA = "0x1369384", Offset = "0x1369384", VA = "0x1369384")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60009BC")]
		[Address(RVA = "0x1369800", Offset = "0x1369800", VA = "0x1369800")]
		private void OnPostFBBIK()
		{
		}

		[Token(Token = "0x60009BD")]
		[Address(RVA = "0x13699CC", Offset = "0x13699CC", VA = "0x13699CC")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60009BE")]
		[Address(RVA = "0x1369AE8", Offset = "0x1369AE8", VA = "0x1369AE8")]
		public FBBIKArmBending()
		{
		}
	}
}
