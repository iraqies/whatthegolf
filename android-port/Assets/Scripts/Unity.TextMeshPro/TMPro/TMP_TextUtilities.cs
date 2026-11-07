using Il2CppDummyDll;
using UnityEngine;

namespace TMPro
{
	[Token(Token = "0x2000075")]
	public static class TMP_TextUtilities
	{
		[Token(Token = "0x40004A2")]
		[FieldOffset(Offset = "0x0")]
		private static Vector3[] m_rectWorldCorners;

		[Token(Token = "0x6000478")]
		[Address(RVA = "0x2AB9CF8", Offset = "0x2AB9CF8", VA = "0x2AB9CF8")]
		public static int GetCursorIndexFromPosition(TMP_Text textComponent, Vector3 position, Camera camera, out CaretPosition cursor)
		{
			return default;
		}

		[Token(Token = "0x6000479")]
		[Address(RVA = "0x2AB9EEC", Offset = "0x2AB9EEC", VA = "0x2AB9EEC")]
		public static int FindNearestLine(TMP_Text text, Vector3 position, Camera camera)
		{
			return default;
		}

		[Token(Token = "0x600047A")]
		[Address(RVA = "0x2ABA080", Offset = "0x2ABA080", VA = "0x2ABA080")]
		public static int FindNearestCharacterOnLine(TMP_Text text, Vector3 position, int line, Camera camera, bool visibleOnly)
		{
			return default;
		}

		[Token(Token = "0x600047B")]
		[Address(RVA = "0x2ABAA3C", Offset = "0x2ABAA3C", VA = "0x2ABAA3C")]
		public static int FindIntersectingWord(TMP_Text text, Vector3 position, Camera camera)
		{
			return default;
		}

		[Token(Token = "0x600047C")]
		[Address(RVA = "0x2ABB1A0", Offset = "0x2ABB1A0", VA = "0x2ABB1A0")]
		public static int FindIntersectingLink(TMP_Text text, Vector3 position, Camera camera)
		{
			return default;
		}

		[Token(Token = "0x600047D")]
		[Address(RVA = "0x2ABA8B8", Offset = "0x2ABA8B8", VA = "0x2ABA8B8")]
		private static bool PointIntersectRectangle(Vector3 m, Vector3 a, Vector3 b, Vector3 c, Vector3 d)
		{
			return default;
		}

		[Token(Token = "0x600047E")]
		[Address(RVA = "0x2ABA6FC", Offset = "0x2ABA6FC", VA = "0x2ABA6FC")]
		public static bool ScreenPointToWorldPointInRectangle(Transform transform, Vector2 screenPoint, Camera cam, out Vector3 worldPoint)
		{
			return default;
		}

		[Token(Token = "0x600047F")]
		[Address(RVA = "0x2ABA970", Offset = "0x2ABA970", VA = "0x2ABA970")]
		public static float DistanceToLine(Vector3 a, Vector3 b, Vector3 point)
		{
			return default;
		}

		[Token(Token = "0x6000480")]
		[Address(RVA = "0x2ABB6E4", Offset = "0x2ABB6E4", VA = "0x2ABB6E4")]
		internal static uint ToUpperASCIIFast(uint c)
		{
			return default;
		}

		[Token(Token = "0x6000481")]
		[Address(RVA = "0x2ABB764", Offset = "0x2ABB764", VA = "0x2ABB764")]
		public static int GetSimpleHashCode(string s)
		{
			return default;
		}
	}
}
