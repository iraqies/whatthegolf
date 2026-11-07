using System.Collections.Generic;
using Il2CppDummyDll;

namespace UnityEngine.ProBuilder
{
	[Token(Token = "0x2000011")]
	public static class Math
	{
		[Token(Token = "0x6000052")]
		[Address(RVA = "0x2A4ADD8", Offset = "0x2A4ADD8", VA = "0x2A4ADD8")]
		internal static Vector2 RotateAroundPoint(this Vector2 v, Vector2 origin, float theta)
		{
			return default;
		}

		[Token(Token = "0x6000053")]
		[Address(RVA = "0x2A4AE44", Offset = "0x2A4AE44", VA = "0x2A4AE44")]
		public static Vector2 ScaleAroundPoint(this Vector2 v, Vector2 origin, Vector2 scale)
		{
			return default;
		}

		[Token(Token = "0x6000054")]
		[Address(RVA = "0x2A4AE60", Offset = "0x2A4AE60", VA = "0x2A4AE60")]
		public static Vector3 Normal(Vector3 p0, Vector3 p1, Vector3 p2)
		{
			return default;
		}

		[Token(Token = "0x6000055")]
		[Address(RVA = "0x2A4AFB4", Offset = "0x2A4AFB4", VA = "0x2A4AFB4")]
		public static Vector3 Normal(ProBuilderMesh mesh, Face face)
		{
			return default;
		}

		[Token(Token = "0x6000056")]
		[Address(RVA = "0x2A4BAEC", Offset = "0x2A4BAEC", VA = "0x2A4BAEC")]
		internal static Vector2 SmallestVector2(Vector2[] v, IList<int> indexes)
		{
			return default;
		}

		[Token(Token = "0x6000057")]
		[Address(RVA = "0x2A4BEA8", Offset = "0x2A4BEA8", VA = "0x2A4BEA8")]
		internal static Vector2 LargestVector2(Vector2[] v, IList<int> indexes)
		{
			return default;
		}

		[Token(Token = "0x6000058")]
		[Address(RVA = "0x2A4C264", Offset = "0x2A4C264", VA = "0x2A4C264")]
		internal static bool Approx2(this Vector2 a, Vector2 b, float delta = 0.0001f)
		{
			return default;
		}

		[Token(Token = "0x6000059")]
		[Address(RVA = "0x2A4C27C", Offset = "0x2A4C27C", VA = "0x2A4C27C")]
		internal static bool Approx3(this Vector3 a, Vector3 b, float delta = 0.0001f)
		{
			return default;
		}

		[Token(Token = "0x600005A")]
		[Address(RVA = "0x2A4C2AC", Offset = "0x2A4C2AC", VA = "0x2A4C2AC")]
		internal static bool Approx4(this Vector4 a, Vector4 b, float delta = 0.0001f)
		{
			return default;
		}

		[Token(Token = "0x600005B")]
		[Address(RVA = "0x2A4C2EC", Offset = "0x2A4C2EC", VA = "0x2A4C2EC")]
		internal static bool ApproxC(this Color a, Color b, float delta = 0.0001f)
		{
			return default;
		}

		[Token(Token = "0x600005C")]
		[Address(RVA = "0x2A4C32C", Offset = "0x2A4C32C", VA = "0x2A4C32C")]
		internal static bool Approx(this float a, float b, float delta = 0.0001f)
		{
			return default;
		}

		[Token(Token = "0x600005D")]
		[Address(RVA = "0x2A4C340", Offset = "0x2A4C340", VA = "0x2A4C340")]
		public static int Clamp(int value, int lowerBound, int upperBound)
		{
			return default;
		}

		[Token(Token = "0x600005E")]
		[Address(RVA = "0x2A4AF80", Offset = "0x2A4AF80", VA = "0x2A4AF80")]
		internal static void Cross(float ax, float ay, float az, float bx, float by, float bz, ref float x, ref float y, ref float z)
		{
		}
	}
}
