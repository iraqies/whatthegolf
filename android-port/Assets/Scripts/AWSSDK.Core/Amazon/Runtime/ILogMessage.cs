using System;
using Il2CppDummyDll;

namespace Amazon.Runtime
{
	[Token(Token = "0x20000E1")]
	public interface ILogMessage
	{
		[Token(Token = "0x17000213")]
		string Format
		{
			[Token(Token = "0x60007EA")]
			get;
		}

		[Token(Token = "0x17000214")]
		object[] Args
		{
			[Token(Token = "0x60007EB")]
			get;
		}

		[Token(Token = "0x17000215")]
		IFormatProvider Provider
		{
			[Token(Token = "0x60007EC")]
			get;
		}
	}
}
