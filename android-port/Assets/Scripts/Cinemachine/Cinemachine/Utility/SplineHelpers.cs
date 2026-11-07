using Il2CppDummyDll;
using UnityEngine;

namespace Cinemachine.Utility
{
	[Token(Token = "0x2000097")]
	public static class SplineHelpers
	{
		[Token(Token = "0x600035F")]
		[Address(RVA = "0x190C36C", Offset = "0x190C36C", VA = "0x190C36C")]
		public static Vector3 Bezier3(float t, Vector3 p0, Vector3 p1, Vector3 p2, Vector3 p3)
		{
			return default;
		}

		[Token(Token = "0x6000360")]
		[Address(RVA = "0x190C474", Offset = "0x190C474", VA = "0x190C474")]
		public static Vector3 BezierTangent3(float t, Vector3 p0, Vector3 p1, Vector3 p2, Vector3 p3)
		{
			return default;
		}

		[Token(Token = "0x6000361")]
		[Address(RVA = "0x190C5EC", Offset = "0x190C5EC", VA = "0x190C5EC")]
		public static float Bezier1(float t, float p0, float p1, float p2, float p3)
		{
			return default;
		}

		[Token(Token = "0x6000362")]
		[Address(RVA = "0x190C670", Offset = "0x190C670", VA = "0x190C670")]
		public static void ComputeSmoothControlPoints(ref Vector4[] knot, ref Vector4[] ctrl1, ref Vector4[] ctrl2)
		{
		}

		[Token(Token = "0x6000363")]
		[Address(RVA = "0x190CDB4", Offset = "0x190CDB4", VA = "0x190CDB4")]
		public static void ComputeSmoothControlPointsLooped(ref Vector4[] knot, ref Vector4[] ctrl1, ref Vector4[] ctrl2)
		{
		}
	}
}
