using Il2CppDummyDll;
using UnityEngine;

namespace RootMotion
{
	[Token(Token = "0x20000F1")]
	public static class V3Tools
	{
		[Token(Token = "0x600061D")]
		[Address(RVA = "0x13274F8", Offset = "0x13274F8", VA = "0x13274F8")]
		public static Vector3 Lerp(Vector3 fromVector, Vector3 toVector, float weight)
		{
			return default;
		}

		[Token(Token = "0x600061E")]
		[Address(RVA = "0x1327590", Offset = "0x1327590", VA = "0x1327590")]
		public static Vector3 ExtractVertical(Vector3 v, Vector3 verticalAxis, float weight)
		{
			return default;
		}

		[Token(Token = "0x600061F")]
		[Address(RVA = "0x13275D0", Offset = "0x13275D0", VA = "0x13275D0")]
		public static Vector3 ExtractHorizontal(Vector3 v, Vector3 normal, float weight)
		{
			return default;
		}

		[Token(Token = "0x6000620")]
		[Address(RVA = "0x132766C", Offset = "0x132766C", VA = "0x132766C")]
		public static Vector3 ClampDirection(Vector3 direction, Vector3 normalDirection, float clampWeight, int clampSmoothing, out bool changed)
		{
			return default;
		}

		[Token(Token = "0x6000621")]
		[Address(RVA = "0x1327810", Offset = "0x1327810", VA = "0x1327810")]
		public static Vector3 LineToPlane(Vector3 origin, Vector3 direction, Vector3 planeNormal, Vector3 planePoint)
		{
			return default;
		}

		[Token(Token = "0x6000622")]
		[Address(RVA = "0x13278CC", Offset = "0x13278CC", VA = "0x13278CC")]
		public static Vector3 PointToPlane(Vector3 point, Vector3 planePosition, Vector3 planeNormal)
		{
			return default;
		}

		[Token(Token = "0x6000623")]
		[Address(RVA = "0x13279CC", Offset = "0x13279CC", VA = "0x13279CC")]
		public static Vector3 TransformPointUnscaled(Transform t, Vector3 point)
		{
			return default;
		}
	}
}
