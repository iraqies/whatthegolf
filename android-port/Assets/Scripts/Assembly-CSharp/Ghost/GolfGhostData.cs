using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Ghost
{
	[Serializable]
	[Token(Token = "0x20010EF")]
	public class GolfGhostData
	{
		[Token(Token = "0x4005937")]
		[FieldOffset(Offset = "0x10")]
		public List<GhostStrokeData> Strokes;

		[Token(Token = "0x6004BCB")]
		[Address(RVA = "0x149F168", Offset = "0x149F168", VA = "0x149F168")]
		public GolfGhostData()
		{
		}
	}
}
