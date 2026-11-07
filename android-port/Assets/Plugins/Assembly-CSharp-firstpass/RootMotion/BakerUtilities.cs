using Il2CppDummyDll;
using UnityEngine;

namespace RootMotion
{
	[Token(Token = "0x20000D8")]
	public static class BakerUtilities
	{
		[Token(Token = "0x600056E")]
		[Address(RVA = "0x12F68A0", Offset = "0x12F68A0", VA = "0x12F68A0")]
		public static void ReduceKeyframes(AnimationCurve curve, float maxError)
		{
		}

		[Token(Token = "0x600056F")]
		[Address(RVA = "0x12F8200", Offset = "0x12F8200", VA = "0x12F8200")]
		public static Keyframe[] GetReducedKeyframes(AnimationCurve curve, float maxError)
		{
			return null;
		}

		[Token(Token = "0x6000570")]
		[Address(RVA = "0x12F6254", Offset = "0x12F6254", VA = "0x12F6254")]
		public static void SetLoopFrame(float time, AnimationCurve curve)
		{
		}

		[Token(Token = "0x6000571")]
		[Address(RVA = "0x12F68E8", Offset = "0x12F68E8", VA = "0x12F68E8")]
		public static void SetTangentMode(AnimationCurve curve)
		{
		}

		[Token(Token = "0x6000572")]
		[Address(RVA = "0x12F5D9C", Offset = "0x12F5D9C", VA = "0x12F5D9C")]
		public static Quaternion EnsureQuaternionContinuity(Quaternion lastQ, Quaternion q)
		{
			return default;
		}
	}
}
