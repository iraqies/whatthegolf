using System;
using Il2CppDummyDll;

namespace Rewired.Utils
{
	[Token(Token = "0x200033E")]
	internal static class NativeTools
	{
		[Token(Token = "0x4001096")]
		[FieldOffset(Offset = "0x0")]
		private static byte[] gSvneBQmqcPdRsiJxIvzzXwlyHsv;

		[Token(Token = "0x60018EF")]
		[Address(RVA = "0x23EDA64", Offset = "0x23EDA64", VA = "0x23EDA64")]
		public static bool CopyMemory(IntPtr source, IntPtr destination, int sourceStartIndex, int destinationStartIndex, int bytesToCopy, bool throwOnError = true)
		{
			return default;
		}

		[Token(Token = "0x60018F0")]
		[Address(RVA = "0x23EDF00", Offset = "0x23EDF00", VA = "0x23EDF00")]
		public static bool FillMemory(IntPtr buffer, int startIndex, int length, byte value, bool throwOnError = true)
		{
			return default;
		}

		[Token(Token = "0x60018F1")]
		[Address(RVA = "0x23EE790", Offset = "0x23EE790", VA = "0x23EE790")]
		public static void ZeroFillMemory(IntPtr buffer, int length)
		{
		}
	}
}
