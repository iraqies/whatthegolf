using Il2CppDummyDll;
using UnityEngine;

namespace StylizedWater
{
	[Token(Token = "0x20000D1")]
	public static class StylizedWaterUtilities
	{
		[Token(Token = "0x20000D2")]
		public static class CameraUtils
		{
			[Token(Token = "0x600054D")]
			[Address(RVA = "0x135640C", Offset = "0x135640C", VA = "0x135640C")]
			public static Vector4 CameraSpacePlane(Camera cam, Vector3 pos, Vector3 normal, float sideSign, float clipPlaneOffset)
			{
				return default;
			}

			[Token(Token = "0x600054E")]
			[Address(RVA = "0x1356520", Offset = "0x1356520", VA = "0x1356520")]
			public static void CalculateReflectionMatrix(ref Matrix4x4 reflectionMat, Vector4 plane)
			{
			}

			[Token(Token = "0x600054F")]
			[Address(RVA = "0x13567C4", Offset = "0x13567C4", VA = "0x13567C4")]
			public static void CopyCameraSettings(Camera src, Camera dest)
			{
			}
		}

		[Token(Token = "0x600054C")]
		[Address(RVA = "0x1401874", Offset = "0x1401874", VA = "0x1401874")]
		public static bool IsApproximatelyEqual(float a, float b)
		{
			return default;
		}
	}
}
