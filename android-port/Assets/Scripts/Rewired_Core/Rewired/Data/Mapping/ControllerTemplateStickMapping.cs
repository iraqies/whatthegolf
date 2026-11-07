using System;
using Il2CppDummyDll;
using Rewired.Utils.Attributes;

namespace Rewired.Data.Mapping
{
	[Serializable]
	[Token(Token = "0x20001D8")]
	[Preserve]
	internal class ControllerTemplateStickMapping : ControllerTemplateSpecialElementMapping
	{
		[Token(Token = "0x4000AAE")]
		[FieldOffset(Offset = "0x10")]
		public int eid_axisX;

		[Token(Token = "0x4000AAF")]
		[FieldOffset(Offset = "0x14")]
		public int eid_axisY;

		[Token(Token = "0x4000AB0")]
		[FieldOffset(Offset = "0x18")]
		public int eid_axisZ;

		[Token(Token = "0x6000E02")]
		[Address(RVA = "0x236D9BC", Offset = "0x236D9BC", VA = "0x236D9BC")]
		public ControllerTemplateStickMapping()
		{
		}
	}
}
