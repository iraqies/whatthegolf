using System;
using Il2CppDummyDll;

namespace Amazon.Runtime
{
	[Token(Token = "0x20000FE")]
	public interface IMetricsTiming
	{
		[Token(Token = "0x17000254")]
		bool IsFinished
		{
			[Token(Token = "0x60008AE")]
			get;
		}

		[Token(Token = "0x17000255")]
		long ElapsedTicks
		{
			[Token(Token = "0x60008AF")]
			get;
		}

		[Token(Token = "0x17000256")]
		TimeSpan ElapsedTime
		{
			[Token(Token = "0x60008B0")]
			get;
		}
	}
}
