using System;
using System.Collections.Generic;
using System.Threading;
using Il2CppDummyDll;

namespace Amazon.Runtime
{
	[Token(Token = "0x20000AB")]
	public static class CorrectClockSkew
	{
		[Token(Token = "0x40002FA")]
		[FieldOffset(Offset = "0x0")]
		private static TimeSpan? manualClockCorrection;

		[Token(Token = "0x40002FB")]
		[FieldOffset(Offset = "0x10")]
		private static ReaderWriterLockSlim manualClockCorrectionLock;

		[Token(Token = "0x40002FC")]
		[FieldOffset(Offset = "0x18")]
		private static IDictionary<string, TimeSpan> clockCorrectionDictionary;

		[Token(Token = "0x40002FD")]
		[FieldOffset(Offset = "0x20")]
		private static ReaderWriterLockSlim clockCorrectionDictionaryLock;

		[Token(Token = "0x170001A2")]
		internal static TimeSpan? GlobalClockCorrection
		{
			[Token(Token = "0x600067B")]
			[Address(RVA = "0x11E5EB0", Offset = "0x11E5EB0", VA = "0x11E5EB0")]
			get
			{
				return null;
			}
			[Token(Token = "0x600067C")]
			[Address(RVA = "0x11E5F48", Offset = "0x11E5F48", VA = "0x11E5F48")]
			set
			{
			}
		}

		[Token(Token = "0x600067D")]
		[Address(RVA = "0x11DF928", Offset = "0x11DF928", VA = "0x11DF928")]
		public static TimeSpan GetClockCorrectionForEndpoint(string endpoint)
		{
			return default;
		}

		[Token(Token = "0x600067E")]
		[Address(RVA = "0x11DF504", Offset = "0x11DF504", VA = "0x11DF504")]
		public static DateTime GetCorrectedUtcNowForEndpoint(string endpoint)
		{
			return default;
		}

		[Token(Token = "0x600067F")]
		[Address(RVA = "0x11E5FE8", Offset = "0x11E5FE8", VA = "0x11E5FE8")]
		internal static void SetClockCorrectionForEndpoint(string endpoint, TimeSpan correction)
		{
		}
	}
}
