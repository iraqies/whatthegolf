using System.Runtime.InteropServices;
using UnityEngine;

namespace Apple.GameKit.AccessPoint
{
	public static class GKAccessPointService
	{
		[PreserveSig]
		private static extern void GameKitWrapper_AccessPoint_Show(GKAccessPointLocation location, bool showHighlights);

		public static void Show(GKAccessPointLocation location, bool showHighlights = true)
		{
		}

		[PreserveSig]
		private static extern void GameKitWrapper_AccessPoint_Hide();

		public static void Hide()
		{
		}

		public static bool IsVisible()
		{
			return false;
		}

		[PreserveSig]
		private static extern bool GameKitWrapper_AccessPoint_IsActive();

		public static bool IsActive()
		{
			return false;
		}

		[PreserveSig]
		private static extern bool GameKitWrapper_AccessPoint_IsPresentingGameCenter();

		public static bool IsPresentingGameCenter()
		{
			return false;
		}

		[PreserveSig]
		private static extern GKAccessPointFrameInScreenCoordinates GameKitWrapper_AccessPoint_GetFrameInScreenCoordinates();

		public static Rect GetFrameInScreenCoordinates()
		{
			return default;
		}

		[PreserveSig]
		private static extern bool GameKitWrapper_AccessPoint_IsSupported();

		public static bool IsSupported()
		{
			return false;
		}
	}
}
