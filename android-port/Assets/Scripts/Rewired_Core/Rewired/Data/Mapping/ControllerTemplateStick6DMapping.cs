using System;
using Il2CppDummyDll;
using Rewired.Utils.Attributes;

namespace Rewired.Data.Mapping
{
	[Serializable]
	[Token(Token = "0x20001DC")]
	[Preserve]
	internal class ControllerTemplateStick6DMapping : ControllerTemplateSpecialElementMapping
	{
		[Token(Token = "0x4000ABD")]
		[FieldOffset(Offset = "0x10")]
		public int eid_positionX;

		[Token(Token = "0x4000ABE")]
		[FieldOffset(Offset = "0x14")]
		public int eid_positionY;

		[Token(Token = "0x4000ABF")]
		[FieldOffset(Offset = "0x18")]
		public int eid_positionZ;

		[Token(Token = "0x4000AC0")]
		[FieldOffset(Offset = "0x1C")]
		public int eid_rotationX;

		[Token(Token = "0x4000AC1")]
		[FieldOffset(Offset = "0x20")]
		public int eid_rotationY;

		[Token(Token = "0x4000AC2")]
		[FieldOffset(Offset = "0x24")]
		public int eid_rotationZ;

		[Token(Token = "0x6000E06")]
		[Address(RVA = "0x236D9A8", Offset = "0x236D9A8", VA = "0x236D9A8")]
		public ControllerTemplateStick6DMapping()
		{
		}
	}
}
