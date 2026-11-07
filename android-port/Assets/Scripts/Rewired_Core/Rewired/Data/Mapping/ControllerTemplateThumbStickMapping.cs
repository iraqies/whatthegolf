using System;
using Il2CppDummyDll;
using Rewired.Utils.Attributes;

namespace Rewired.Data.Mapping
{
	[Serializable]
	[Token(Token = "0x20001D6")]
	[Preserve]
	internal class ControllerTemplateThumbStickMapping : ControllerTemplateSpecialElementMapping
	{
		[Token(Token = "0x4000AA6")]
		[FieldOffset(Offset = "0x10")]
		public int eid_axisX;

		[Token(Token = "0x4000AA7")]
		[FieldOffset(Offset = "0x14")]
		public int eid_axisY;

		[Token(Token = "0x4000AA8")]
		[FieldOffset(Offset = "0x18")]
		public int eid_button;

		[Token(Token = "0x6000E00")]
		[Address(RVA = "0x236D9E4", Offset = "0x236D9E4", VA = "0x236D9E4")]
		public ControllerTemplateThumbStickMapping()
		{
		}
	}
}
