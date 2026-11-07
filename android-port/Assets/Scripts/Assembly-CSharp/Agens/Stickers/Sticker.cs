using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace Agens.Stickers
{
	[Token(Token = "0x2001019")]
	public class Sticker : ScriptableObject
	{
		[Token(Token = "0x40054D4")]
		[FieldOffset(Offset = "0x18")]
		public string Name;

		[Token(Token = "0x40054D5")]
		[FieldOffset(Offset = "0x20")]
		public int Fps;

		[Token(Token = "0x40054D6")]
		[FieldOffset(Offset = "0x24")]
		public int Repetitions;

		[Token(Token = "0x40054D7")]
		[FieldOffset(Offset = "0x28")]
		public int Index;

		[Token(Token = "0x40054D8")]
		[FieldOffset(Offset = "0x2C")]
		public bool Sequence;

		[Token(Token = "0x40054D9")]
		[FieldOffset(Offset = "0x30")]
		public List<Texture2D> Frames;

		[Token(Token = "0x60047F8")]
		[Address(RVA = "0x16DF370", Offset = "0x16DF370", VA = "0x16DF370")]
		public void CopyFrom(Sticker sticker, int i)
		{
		}

		[Token(Token = "0x60047F9")]
		[Address(RVA = "0x16DF3D4", Offset = "0x16DF3D4", VA = "0x16DF3D4")]
		public Sticker()
		{
		}
	}
}
