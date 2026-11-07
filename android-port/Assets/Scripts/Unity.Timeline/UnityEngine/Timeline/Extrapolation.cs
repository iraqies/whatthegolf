using System;
using Il2CppDummyDll;

namespace UnityEngine.Timeline
{
	[Token(Token = "0x2000039")]
	internal static class Extrapolation
	{
		[Serializable]
		[Token(Token = "0x200003A")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1BBAB0", Offset = "0x1BBAB0")]
		private sealed class _003C_003Ec
		{
			[Token(Token = "0x40000EC")]
			[FieldOffset(Offset = "0x0")]
			public static readonly _003C_003Ec _003C_003E9;

			[Token(Token = "0x40000ED")]
			[FieldOffset(Offset = "0x8")]
			public static Comparison<TimelineClip> _003C_003E9__2_0;

			[Token(Token = "0x6000207")]
			[Address(RVA = "0x2AF9FC0", Offset = "0x2AF9FC0", VA = "0x2AF9FC0")]
			public _003C_003Ec()
			{
			}

			[Token(Token = "0x6000208")]
			[Address(RVA = "0x2AF9FC8", Offset = "0x2AF9FC8", VA = "0x2AF9FC8")]
			internal int _003CSortClipsByStartTime_003Eb__2_0(TimelineClip clip1, TimelineClip clip2)
			{
				return default;
			}
		}

		[Token(Token = "0x40000EB")]
		[FieldOffset(Offset = "0x0")]
		internal static readonly double kMinExtrapolationTime;

		[Token(Token = "0x6000203")]
		[Address(RVA = "0x2AE75E8", Offset = "0x2AE75E8", VA = "0x2AE75E8")]
		internal static void CalculateExtrapolationTimes(this TrackAsset asset)
		{
		}

		[Token(Token = "0x6000204")]
		[Address(RVA = "0x2AE7A24", Offset = "0x2AE7A24", VA = "0x2AE7A24")]
		private static TimelineClip[] SortClipsByStartTime(TimelineClip[] clips)
		{
			return null;
		}
	}
}
