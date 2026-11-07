using Il2CppDummyDll;
using UnityEngine;

namespace DanceOff
{
	[Token(Token = "0x20011F5")]
	public class DancerGroup : Dancer
	{
		[Token(Token = "0x400608D")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Dancer[] dancers;

		[Token(Token = "0x600527B")]
		[Address(RVA = "0x18D44EC", Offset = "0x18D44EC", VA = "0x18D44EC", Slot = "4")]
		public override void Dance(Vector2 dir)
		{
		}

		[Token(Token = "0x600527C")]
		[Address(RVA = "0x18D457C", Offset = "0x18D457C", VA = "0x18D457C", Slot = "5")]
		public override void Fail(Vector2 dir)
		{
		}

		[Token(Token = "0x600527D")]
		[Address(RVA = "0x18D460C", Offset = "0x18D460C", VA = "0x18D460C")]
		public DancerGroup()
		{
		}
	}
}
