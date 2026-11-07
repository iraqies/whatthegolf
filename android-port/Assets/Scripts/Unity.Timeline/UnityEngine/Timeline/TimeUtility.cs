using Il2CppDummyDll;

namespace UnityEngine.Timeline
{
	[Token(Token = "0x200003F")]
	internal static class TimeUtility
	{
		[Token(Token = "0x40000EE")]
		[FieldOffset(Offset = "0x0")]
		public static readonly double kTimeEpsilon;

		[Token(Token = "0x40000EF")]
		[FieldOffset(Offset = "0x8")]
		public static readonly double kFrameRateEpsilon;

		[Token(Token = "0x40000F0")]
		[FieldOffset(Offset = "0x10")]
		public static readonly double k_MaxTimelineDurationInSeconds;

		[Token(Token = "0x6000216")]
		[Address(RVA = "0x2AE1300", Offset = "0x2AE1300", VA = "0x2AE1300")]
		public static double GetAnimationClipLength(AnimationClip clip)
		{
			return default;
		}
	}
}
