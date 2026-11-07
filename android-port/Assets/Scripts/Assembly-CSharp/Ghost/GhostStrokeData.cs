using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Ghost
{
	[Serializable]
	[Token(Token = "0x20010F0")]
	public class GhostStrokeData
	{
		[Token(Token = "0x4005938")]
		[FieldOffset(Offset = "0x10")]
		public string GhostPrefabID;

		[Token(Token = "0x4005939")]
		[FieldOffset(Offset = "0x18")]
		public List<GolfGhostDataPoint> DataPoints;

		[Token(Token = "0x6004BCC")]
		[Address(RVA = "0x1485FFC", Offset = "0x1485FFC", VA = "0x1485FFC")]
		public GhostStrokeData(string ghostPrefabID)
		{
		}
	}
}
