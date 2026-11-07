using Il2CppDummyDll;
using UnityEngine;

namespace Triband.GolfTerrainTool
{
	[Token(Token = "0x2000004")]
	public static class BrushExtensions
	{
		[Token(Token = "0x6000026")]
		[Address(RVA = "0x29FA444", Offset = "0x29FA444", VA = "0x29FA444")]
		public static Vector3 GetScaleWS(this Brush brush)
		{
			return default;
		}

		[Token(Token = "0x6000027")]
		[Address(RVA = "0x29FA49C", Offset = "0x29FA49C", VA = "0x29FA49C")]
		public static Bounds GetBounds(this Brush brush, Matrix4x4 scalingMatrix)
		{
			return default;
		}

		[Token(Token = "0x6000028")]
		[Address(RVA = "0x29FA610", Offset = "0x29FA610", VA = "0x29FA610")]
		public static float GetDistance(this Brush brush, Vector3 sourcePosition)
		{
			return default;
		}

		[Token(Token = "0x6000029")]
		[Address(RVA = "0x29FA6F0", Offset = "0x29FA6F0", VA = "0x29FA6F0")]
		private static float GetCircleDistance(this Brush brush, Vector3 sourcePosition)
		{
			return default;
		}

		[Token(Token = "0x600002A")]
		[Address(RVA = "0x29FA73C", Offset = "0x29FA73C", VA = "0x29FA73C")]
		private static float GetRectangleDistance(this Brush brush, Vector3 sourcePosition)
		{
			return default;
		}
	}
}
