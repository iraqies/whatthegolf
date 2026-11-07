using Il2CppDummyDll;
using UnityEngine;

namespace Rewired.Data
{
	[Token(Token = "0x20001BC")]
	public class EditorSettings : ScriptableObject
	{
		[Token(Token = "0x4000A08")]
		[FieldOffset(Offset = "0x18")]
		public int programVersion1;

		[Token(Token = "0x4000A09")]
		[FieldOffset(Offset = "0x1C")]
		public int programVersion2;

		[Token(Token = "0x4000A0A")]
		[FieldOffset(Offset = "0x20")]
		public int programVersion3;

		[Token(Token = "0x4000A0B")]
		[FieldOffset(Offset = "0x24")]
		public int programVersion4;

		[Token(Token = "0x4000A0C")]
		[FieldOffset(Offset = "0x28")]
		public int dataVersion;

		[Token(Token = "0x6000D06")]
		[Address(RVA = "0x23C93C0", Offset = "0x23C93C0", VA = "0x23C93C0")]
		public EditorSettings()
		{
		}
	}
}
