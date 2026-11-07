using Il2CppDummyDll;
using UnityEngine;

namespace RootMotion
{
	[Token(Token = "0x20000ED")]
	public static class QuaTools
	{
		[Token(Token = "0x60005FE")]
		[Address(RVA = "0x13D5C70", Offset = "0x13D5C70", VA = "0x13D5C70")]
		public static Quaternion Lerp(Quaternion fromRotation, Quaternion toRotation, float weight)
		{
			return default;
		}

		[Token(Token = "0x60005FF")]
		[Address(RVA = "0x13D5CC0", Offset = "0x13D5CC0", VA = "0x13D5CC0")]
		public static Quaternion FromToAroundAxis(Vector3 fromDirection, Vector3 toDirection, Vector3 axis)
		{
			return default;
		}

		[Token(Token = "0x6000600")]
		[Address(RVA = "0x13D5DA8", Offset = "0x13D5DA8", VA = "0x13D5DA8")]
		public static Quaternion RotationToLocalSpace(Quaternion space, Quaternion rotation)
		{
			return default;
		}

		[Token(Token = "0x6000601")]
		[Address(RVA = "0x13D5DFC", Offset = "0x13D5DFC", VA = "0x13D5DFC")]
		public static Quaternion FromToRotation(Quaternion from, Quaternion to)
		{
			return default;
		}

		[Token(Token = "0x6000602")]
		[Address(RVA = "0x13D5ED0", Offset = "0x13D5ED0", VA = "0x13D5ED0")]
		public static Vector3 GetAxis(Vector3 v)
		{
			return default;
		}

		[Token(Token = "0x6000603")]
		[Address(RVA = "0x13D5FDC", Offset = "0x13D5FDC", VA = "0x13D5FDC")]
		public static Quaternion ClampRotation(Quaternion rotation, float clampWeight, int clampSmoothing)
		{
			return default;
		}

		[Token(Token = "0x6000604")]
		[Address(RVA = "0x13D6164", Offset = "0x13D6164", VA = "0x13D6164")]
		public static Quaternion MatchRotation(Quaternion targetRotation, Vector3 targetforwardAxis, Vector3 targetUpAxis, Vector3 forwardAxis, Vector3 upAxis)
		{
			return default;
		}

		[Token(Token = "0x6000605")]
		[Address(RVA = "0x13D6260", Offset = "0x13D6260", VA = "0x13D6260")]
		public static Vector3 ToBiPolar(Vector3 euler)
		{
			return default;
		}

		[Token(Token = "0x6000606")]
		[Address(RVA = "0x13D6364", Offset = "0x13D6364", VA = "0x13D6364")]
		public static float ToBiPolar(float angle)
		{
			return default;
		}
	}
}
