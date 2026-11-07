using Il2CppDummyDll;
using UnityEngine;

namespace xmas
{
	[Token(Token = "0x20011ED")]
	[Attribute(Name = "RequireComponent", RVA = "0x48324", Offset = "0x48324")]
	public class RollingNumber : MonoBehaviour
	{
		[Token(Token = "0x4006074")]
		[FieldOffset(Offset = "0x18")]
		public float speed;

		[Token(Token = "0x4006075")]
		[FieldOffset(Offset = "0x1C")]
		public float MoveSpeed;

		[Token(Token = "0x4006076")]
		[FieldOffset(Offset = "0x20")]
		public float LookInAimDirectionSpeed;

		[Token(Token = "0x4006077")]
		[FieldOffset(Offset = "0x24")]
		public float CorrectSideFallSpeed;

		[Token(Token = "0x4006078")]
		[FieldOffset(Offset = "0x28")]
		public Transform number;

		[Token(Token = "0x4006079")]
		[FieldOffset(Offset = "0x30")]
		private Rigidbody rigid;

		[Token(Token = "0x600525D")]
		[Address(RVA = "0x165DCD0", Offset = "0x165DCD0", VA = "0x165DCD0")]
		private void Start()
		{
		}

		[Token(Token = "0x600525E")]
		[Address(RVA = "0x165DDC8", Offset = "0x165DDC8", VA = "0x165DDC8")]
		private void Controller_OnAimUpdate(Vector3 boost, bool IsNotOrange)
		{
		}

		[Token(Token = "0x600525F")]
		[Address(RVA = "0x165DEEC", Offset = "0x165DEEC", VA = "0x165DEEC")]
		public RollingNumber()
		{
		}
	}
}
