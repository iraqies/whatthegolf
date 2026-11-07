using System;
using Il2CppDummyDll;
using Rewired.Utils.Attributes;

namespace Rewired.Data.Mapping
{
	[Serializable]
	[Token(Token = "0x20001DA")]
	[Preserve]
	internal class ControllerTemplateHatMapping : ControllerTemplateSpecialElementMapping
	{
		[Token(Token = "0x4000AB3")]
		[FieldOffset(Offset = "0x10")]
		public int eid_up;

		[Token(Token = "0x4000AB4")]
		[FieldOffset(Offset = "0x14")]
		public int eid_upRight;

		[Token(Token = "0x4000AB5")]
		[FieldOffset(Offset = "0x18")]
		public int eid_right;

		[Token(Token = "0x4000AB6")]
		[FieldOffset(Offset = "0x1C")]
		public int eid_downRight;

		[Token(Token = "0x4000AB7")]
		[FieldOffset(Offset = "0x20")]
		public int eid_down;

		[Token(Token = "0x4000AB8")]
		[FieldOffset(Offset = "0x24")]
		public int eid_downLeft;

		[Token(Token = "0x4000AB9")]
		[FieldOffset(Offset = "0x28")]
		public int eid_left;

		[Token(Token = "0x4000ABA")]
		[FieldOffset(Offset = "0x2C")]
		public int eid_upLeft;

		[Token(Token = "0x6000E04")]
		[Address(RVA = "0x236D998", Offset = "0x236D998", VA = "0x236D998")]
		public ControllerTemplateHatMapping()
		{
		}
	}
}
