using UnityEngine;

namespace TMPro
{
	public static class TMP_TextUtilities
	{
		private static Vector3[] m_rectWorldCorners;

		public static int GetCursorIndexFromPosition(TMP_Text textComponent, Vector3 position, Camera camera, out CaretPosition cursor)
		{
			cursor = default;
			return 0;
		}

		public static int FindNearestLine(TMP_Text text, Vector3 position, Camera camera)
		{
			return 0;
		}

		public static int FindNearestCharacterOnLine(TMP_Text text, Vector3 position, int line, Camera camera, bool visibleOnly)
		{
			return 0;
		}

		public static int FindIntersectingWord(TMP_Text text, Vector3 position, Camera camera)
		{
			return 0;
		}

		public static int FindIntersectingLink(TMP_Text text, Vector3 position, Camera camera)
		{
			return 0;
		}

		private static bool PointIntersectRectangle(Vector3 m, Vector3 a, Vector3 b, Vector3 c, Vector3 d)
		{
			return false;
		}

		public static bool ScreenPointToWorldPointInRectangle(Transform transform, Vector2 screenPoint, Camera cam, out Vector3 worldPoint)
		{
			worldPoint = default;
			return false;
		}

		public static float DistanceToLine(Vector3 a, Vector3 b, Vector3 point)
		{
			return 0f;
		}

		internal static uint ToUpperASCIIFast(uint c)
		{
			return 0u;
		}

		public static int GetSimpleHashCode(string s)
		{
			return 0;
		}
	}
}
