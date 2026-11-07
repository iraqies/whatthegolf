using System;
using System.Collections.Generic;
using System.ComponentModel;
using Il2CppDummyDll;

namespace Amazon.Runtime.Internal.Util
{
	[Token(Token = "0x20001D1")]
	public class Logger : ILogger
	{
		[Token(Token = "0x40006FF")]
		[FieldOffset(Offset = "0x0")]
		private static IDictionary<Type, Logger> cachedLoggers;

		[Token(Token = "0x4000700")]
		[FieldOffset(Offset = "0x10")]
		private List<InternalLogger> loggers;

		[Token(Token = "0x4000701")]
		[FieldOffset(Offset = "0x8")]
		private static Logger emptyLogger;

		[Token(Token = "0x1700039C")]
		public static Logger EmptyLogger
		{
			[Token(Token = "0x6000E44")]
			[Address(RVA = "0x123AB68", Offset = "0x123AB68", VA = "0x123AB68")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000E3E")]
		[Address(RVA = "0x123A124", Offset = "0x123A124", VA = "0x123A124")]
		private Logger()
		{
		}

		[Token(Token = "0x6000E3F")]
		[Address(RVA = "0x123A1A8", Offset = "0x123A1A8", VA = "0x123A1A8")]
		private Logger(Type type)
		{
		}

		[Token(Token = "0x6000E40")]
		[Address(RVA = "0x123A62C", Offset = "0x123A62C", VA = "0x123A62C")]
		private void ConfigsChanged(object sender, PropertyChangedEventArgs e)
		{
		}

		[Token(Token = "0x6000E41")]
		[Address(RVA = "0x123A3AC", Offset = "0x123A3AC", VA = "0x123A3AC")]
		private void ConfigureLoggers()
		{
		}

		[Token(Token = "0x6000E42")]
		[Address(RVA = "0x123A6B8", Offset = "0x123A6B8", VA = "0x123A6B8")]
		public static Logger GetLogger(Type type)
		{
			return null;
		}

		[Token(Token = "0x6000E43")]
		[Address(RVA = "0x123A9F0", Offset = "0x123A9F0", VA = "0x123A9F0")]
		public static void ClearLoggerCache()
		{
		}

		[Token(Token = "0x6000E45")]
		[Address(RVA = "0x123ABCC", Offset = "0x123ABCC", VA = "0x123ABCC", Slot = "8")]
		public void Flush()
		{
		}

		[Token(Token = "0x6000E46")]
		[Address(RVA = "0x123AD20", Offset = "0x123AD20", VA = "0x123AD20", Slot = "7")]
		public void Error(Exception exception, string messageFormat, params object[] args)
		{
		}

		[Token(Token = "0x6000E47")]
		[Address(RVA = "0x123AEB8", Offset = "0x123AEB8", VA = "0x123AEB8", Slot = "5")]
		public void Debug(Exception exception, string messageFormat, params object[] args)
		{
		}

		[Token(Token = "0x6000E48")]
		[Address(RVA = "0x123B050", Offset = "0x123B050", VA = "0x123B050", Slot = "6")]
		public void DebugFormat(string messageFormat, params object[] args)
		{
		}

		[Token(Token = "0x6000E49")]
		[Address(RVA = "0x123B1E0", Offset = "0x123B1E0", VA = "0x123B1E0", Slot = "4")]
		public void InfoFormat(string messageFormat, params object[] args)
		{
		}
	}
}
