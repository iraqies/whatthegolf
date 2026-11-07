using System.Collections.Generic;
using Il2CppDummyDll;

namespace UnityEngine.UI
{
	[Token(Token = "0x2000017")]
	public static class FontUpdateTracker
	{
		[Token(Token = "0x4000054")]
		[FieldOffset(Offset = "0x0")]
		private static Dictionary<Font, HashSet<Text>> m_Tracked;

		[Token(Token = "0x60000BA")]
		[Address(RVA = "0x2C04784", Offset = "0x2C04784", VA = "0x2C04784")]
		public static void TrackText(Text t)
		{
		}

		[Token(Token = "0x60000BB")]
		[Address(RVA = "0x2C04A0C", Offset = "0x2C04A0C", VA = "0x2C04A0C")]
		private static void RebuildForFont(Font f)
		{
		}

		[Token(Token = "0x60000BC")]
		[Address(RVA = "0x2C04BBC", Offset = "0x2C04BBC", VA = "0x2C04BBC")]
		public static void UntrackText(Text t)
		{
		}
	}
}
