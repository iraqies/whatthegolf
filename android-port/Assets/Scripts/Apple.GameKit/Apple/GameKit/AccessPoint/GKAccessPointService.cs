using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;

namespace Apple.GameKit.AccessPoint
{
	[Token(Token = "0x2000014")]
	public static class GKAccessPointService
	{
		[PreserveSig]
		[Token(Token = "0x6000026")]
		[Address(RVA = "0x12E7B14", Offset = "0x12E7B14", VA = "0x12E7B14")]
		private static extern void GameKitWrapper_AccessPoint_Show(GKAccessPointLocation location, bool showHighlights);

		[Token(Token = "0x6000027")]
		[Address(RVA = "0x12E7B18", Offset = "0x12E7B18", VA = "0x12E7B18")]
		public static void Show(GKAccessPointLocation location, bool showHighlights = true)
		{
		}

		[PreserveSig]
		[Token(Token = "0x6000028")]
		[Address(RVA = "0x12E7B1C", Offset = "0x12E7B1C", VA = "0x12E7B1C")]
		private static extern void GameKitWrapper_AccessPoint_Hide();

		[Token(Token = "0x6000029")]
		[Address(RVA = "0x12E7B20", Offset = "0x12E7B20", VA = "0x12E7B20")]
		public static void Hide()
		{
		}

		[Token(Token = "0x600002A")]
		[Address(RVA = "0x12E7B24", Offset = "0x12E7B24", VA = "0x12E7B24")]
		public static bool IsVisible()
		{
			return default;
		}

		[PreserveSig]
		[Token(Token = "0x600002B")]
		[Address(RVA = "0x12E7C14", Offset = "0x12E7C14", VA = "0x12E7C14")]
		private static extern bool GameKitWrapper_AccessPoint_IsActive();

		[Token(Token = "0x600002C")]
		[Address(RVA = "0x12E7BF8", Offset = "0x12E7BF8", VA = "0x12E7BF8")]
		public static bool IsActive()
		{
			return default;
		}

		[PreserveSig]
		[Token(Token = "0x600002D")]
		[Address(RVA = "0x12E7C30", Offset = "0x12E7C30", VA = "0x12E7C30")]
		private static extern bool GameKitWrapper_AccessPoint_IsPresentingGameCenter();

		[Token(Token = "0x600002E")]
		[Address(RVA = "0x12E7C4C", Offset = "0x12E7C4C", VA = "0x12E7C4C")]
		public static bool IsPresentingGameCenter()
		{
			return default;
		}

		[PreserveSig]
		[Token(Token = "0x600002F")]
		[Address(RVA = "0x12E7C68", Offset = "0x12E7C68", VA = "0x12E7C68")]
		private static extern GKAccessPointFrameInScreenCoordinates GameKitWrapper_AccessPoint_GetFrameInScreenCoordinates();

		[Token(Token = "0x6000030")]
		[Address(RVA = "0x12E7BC4", Offset = "0x12E7BC4", VA = "0x12E7BC4")]
		public static Rect GetFrameInScreenCoordinates()
		{
			return default;
		}

		[PreserveSig]
		[Token(Token = "0x6000031")]
		[Address(RVA = "0x12E7C6C", Offset = "0x12E7C6C", VA = "0x12E7C6C")]
		private static extern bool GameKitWrapper_AccessPoint_IsSupported();

		[Token(Token = "0x6000032")]
		[Address(RVA = "0x12E7BA8", Offset = "0x12E7BA8", VA = "0x12E7BA8")]
		public static bool IsSupported()
		{
			return default;
		}
	}
}
