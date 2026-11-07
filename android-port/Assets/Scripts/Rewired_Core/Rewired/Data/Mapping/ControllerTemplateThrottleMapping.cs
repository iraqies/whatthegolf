using System;
using Il2CppDummyDll;
using Rewired.Utils.Attributes;

namespace Rewired.Data.Mapping
{
	[Serializable]
	[Token(Token = "0x20001D9")]
	[Preserve]
	internal class ControllerTemplateThrottleMapping : ControllerTemplateSpecialElementMapping
	{
		[Token(Token = "0x4000AB1")]
		[FieldOffset(Offset = "0x10")]
		public int eid_axis;

		[Token(Token = "0x4000AB2")]
		[FieldOffset(Offset = "0x14")]
		public int eid_minDetent;

		[Token(Token = "0x6000E03")]
		[Address(RVA = "0x236D9D4", Offset = "0x236D9D4", VA = "0x236D9D4")]
		public ControllerTemplateThrottleMapping()
		{
		}
	}
}
