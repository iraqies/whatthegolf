using System;
using Il2CppDummyDll;
using Rewired.Utils.Attributes;

namespace Rewired.Data.Mapping
{
	[Serializable]
	[Token(Token = "0x20001D7")]
	[Preserve]
	internal class ControllerTemplateDPadMapping : ControllerTemplateSpecialElementMapping
	{
		[Token(Token = "0x4000AA9")]
		[FieldOffset(Offset = "0x10")]
		public int eid_up;

		[Token(Token = "0x4000AAA")]
		[FieldOffset(Offset = "0x14")]
		public int eid_right;

		[Token(Token = "0x4000AAB")]
		[FieldOffset(Offset = "0x18")]
		public int eid_down;

		[Token(Token = "0x4000AAC")]
		[FieldOffset(Offset = "0x1C")]
		public int eid_left;

		[Token(Token = "0x4000AAD")]
		[FieldOffset(Offset = "0x20")]
		public int eid_press;

		[Token(Token = "0x6000E01")]
		[Address(RVA = "0x236D7D4", Offset = "0x236D7D4", VA = "0x236D7D4")]
		public ControllerTemplateDPadMapping()
		{
		}
	}
}
