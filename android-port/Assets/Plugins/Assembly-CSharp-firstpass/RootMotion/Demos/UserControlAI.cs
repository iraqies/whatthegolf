using Il2CppDummyDll;
using UnityEngine;

namespace RootMotion.Demos
{
	[Token(Token = "0x2000256")]
	public class UserControlAI : UserControlThirdPerson
	{
		[Token(Token = "0x4000F6B")]
		[FieldOffset(Offset = "0x48")]
		public Transform moveTarget;

		[Token(Token = "0x4000F6C")]
		[FieldOffset(Offset = "0x50")]
		public float stoppingDistance;

		[Token(Token = "0x4000F6D")]
		[FieldOffset(Offset = "0x54")]
		public float stoppingThreshold;

		[Token(Token = "0x4000F6E")]
		[FieldOffset(Offset = "0x58")]
		public Navigator navigator;

		[Token(Token = "0x6000F73")]
		[Address(RVA = "0x1326890", Offset = "0x1326890", VA = "0x1326890", Slot = "4")]
		protected override void Start()
		{
		}

		[Token(Token = "0x6000F74")]
		[Address(RVA = "0x1326920", Offset = "0x1326920", VA = "0x1326920", Slot = "5")]
		protected override void Update()
		{
		}

		[Token(Token = "0x6000F75")]
		[Address(RVA = "0x1326AF8", Offset = "0x1326AF8", VA = "0x1326AF8")]
		private void OnDrawGizmos()
		{
		}

		[Token(Token = "0x6000F76")]
		[Address(RVA = "0x1326B24", Offset = "0x1326B24", VA = "0x1326B24")]
		public UserControlAI()
		{
		}
	}
}
