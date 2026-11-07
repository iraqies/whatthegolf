using Il2CppDummyDll;
using UnityEngine;

namespace RootMotion.Demos
{
	[Token(Token = "0x2000257")]
	public class UserControlThirdPerson : MonoBehaviour
	{
		[Token(Token = "0x2000258")]
		public struct State
		{
			[Token(Token = "0x4000F74")]
			[FieldOffset(Offset = "0x0")]
			public Vector3 move;

			[Token(Token = "0x4000F75")]
			[FieldOffset(Offset = "0xC")]
			public Vector3 lookPos;

			[Token(Token = "0x4000F76")]
			[FieldOffset(Offset = "0x18")]
			public bool crouch;

			[Token(Token = "0x4000F77")]
			[FieldOffset(Offset = "0x19")]
			public bool jump;

			[Token(Token = "0x4000F78")]
			[FieldOffset(Offset = "0x1C")]
			public int actionIndex;
		}

		[Token(Token = "0x4000F6F")]
		[FieldOffset(Offset = "0x18")]
		public bool walkByDefault;

		[Token(Token = "0x4000F70")]
		[FieldOffset(Offset = "0x19")]
		public bool canCrouch;

		[Token(Token = "0x4000F71")]
		[FieldOffset(Offset = "0x1A")]
		public bool canJump;

		[Token(Token = "0x4000F72")]
		[FieldOffset(Offset = "0x1C")]
		public State state;

		[Token(Token = "0x4000F73")]
		[FieldOffset(Offset = "0x40")]
		protected Transform cam;

		[Token(Token = "0x6000F77")]
		[Address(RVA = "0x13268E8", Offset = "0x13268E8", VA = "0x13268E8", Slot = "4")]
		protected virtual void Start()
		{
		}

		[Token(Token = "0x6000F78")]
		[Address(RVA = "0x1326F8C", Offset = "0x1326F8C", VA = "0x1326F8C", Slot = "5")]
		protected virtual void Update()
		{
		}

		[Token(Token = "0x6000F79")]
		[Address(RVA = "0x1326B40", Offset = "0x1326B40", VA = "0x1326B40")]
		public UserControlThirdPerson()
		{
		}
	}
}
