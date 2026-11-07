using System.Diagnostics;
using Il2CppDummyDll;

namespace Amazon.Runtime.Internal.Util
{
	[Token(Token = "0x20001C3")]
	public static class Extensions
	{
		[Token(Token = "0x40006E2")]
		[FieldOffset(Offset = "0x0")]
		private static readonly long TicksPerSecond;

		[Token(Token = "0x40006E3")]
		[FieldOffset(Offset = "0x8")]
		private static readonly double TickFrequency;

		[Token(Token = "0x6000DF5")]
		[Address(RVA = "0x1207110", Offset = "0x1207110", VA = "0x1207110")]
		public static long GetElapsedDateTimeTicks(this Stopwatch self)
		{
			return default;
		}

		[Token(Token = "0x6000DF6")]
		[Address(RVA = "0x12071B8", Offset = "0x12071B8", VA = "0x12071B8")]
		public static bool HasRequestData(this IRequest request)
		{
			return default;
		}
	}
}
