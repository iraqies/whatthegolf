using System;
using Il2CppDummyDll;

namespace Amazon.Runtime.Internal.Util
{
	[Token(Token = "0x20001CE")]
	public interface ILogger
	{
		[Token(Token = "0x6000E32")]
		void InfoFormat(string messageFormat, params object[] args);

		[Token(Token = "0x6000E33")]
		void Debug(Exception exception, string messageFormat, params object[] args);

		[Token(Token = "0x6000E34")]
		void DebugFormat(string messageFormat, params object[] args);

		[Token(Token = "0x6000E35")]
		void Error(Exception exception, string messageFormat, params object[] args);

		[Token(Token = "0x6000E36")]
		void Flush();
	}
}
