using System;
using Il2CppDummyDll;

namespace ZXing
{
	[Serializable]
	[Token(Token = "0x2000016")]
	public sealed class WriterException : Exception
	{
		[Token(Token = "0x6000086")]
		[Address(RVA = "0x2EE1698", Offset = "0x2EE1698", VA = "0x2EE1698")]
		public WriterException()
		{
		}

		[Token(Token = "0x6000087")]
		[Address(RVA = "0x2EE1714", Offset = "0x2EE1714", VA = "0x2EE1714")]
		public WriterException(string message)
		{
		}

		[Token(Token = "0x6000088")]
		[Address(RVA = "0x2EE17A0", Offset = "0x2EE17A0", VA = "0x2EE17A0")]
		public WriterException(string message, Exception innerExc)
		{
		}
	}
}
