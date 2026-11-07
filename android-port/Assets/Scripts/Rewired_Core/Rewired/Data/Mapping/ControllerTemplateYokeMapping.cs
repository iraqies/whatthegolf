using System;
using Il2CppDummyDll;
using Rewired.Utils.Attributes;

namespace Rewired.Data.Mapping
{
	[Serializable]
	[Token(Token = "0x20001DB")]
	[Preserve]
	internal class ControllerTemplateYokeMapping : ControllerTemplateSpecialElementMapping
	{
		[Token(Token = "0x4000ABB")]
		[FieldOffset(Offset = "0x10")]
		public int eid_axisX;

		[Token(Token = "0x4000ABC")]
		[FieldOffset(Offset = "0x14")]
		public int eid_axisZ;

		[Token(Token = "0x6000E05")]
		[Address(RVA = "0x236D9FC", Offset = "0x236D9FC", VA = "0x236D9FC")]
		public ControllerTemplateYokeMapping()
		{
		}
	}
}
