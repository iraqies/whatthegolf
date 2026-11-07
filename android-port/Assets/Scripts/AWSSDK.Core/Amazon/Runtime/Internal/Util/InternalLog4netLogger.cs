using System;
using System.Reflection;
using Amazon.Util.Internal;
using Il2CppDummyDll;

namespace Amazon.Runtime.Internal.Util
{
	[Token(Token = "0x20001D3")]
	internal class InternalLog4netLogger : InternalLogger
	{
		[Token(Token = "0x20001D4")]
		private enum LoadState
		{
			[Token(Token = "0x4000719")]
			Uninitialized = 0,
			[Token(Token = "0x400071A")]
			Failed = 1,
			[Token(Token = "0x400071B")]
			Loading = 2,
			[Token(Token = "0x400071C")]
			Success = 3
		}

		[Token(Token = "0x4000704")]
		[FieldOffset(Offset = "0x0")]
		private static LoadState loadState;

		[Token(Token = "0x4000705")]
		[FieldOffset(Offset = "0x8")]
		private static readonly object LOCK;

		[Token(Token = "0x4000706")]
		[FieldOffset(Offset = "0x10")]
		private static Type logMangerType;

		[Token(Token = "0x4000707")]
		[FieldOffset(Offset = "0x18")]
		private static ITypeInfo logMangerTypeInfo;

		[Token(Token = "0x4000708")]
		[FieldOffset(Offset = "0x20")]
		private static MethodInfo getLoggerWithTypeMethod;

		[Token(Token = "0x4000709")]
		[FieldOffset(Offset = "0x28")]
		private static Type logType;

		[Token(Token = "0x400070A")]
		[FieldOffset(Offset = "0x30")]
		private static ITypeInfo logTypeInfo;

		[Token(Token = "0x400070B")]
		[FieldOffset(Offset = "0x38")]
		private static MethodInfo logMethod;

		[Token(Token = "0x400070C")]
		[FieldOffset(Offset = "0x40")]
		private static Type levelType;

		[Token(Token = "0x400070D")]
		[FieldOffset(Offset = "0x48")]
		private static ITypeInfo levelTypeInfo;

		[Token(Token = "0x400070E")]
		[FieldOffset(Offset = "0x50")]
		private static object debugLevelPropertyValue;

		[Token(Token = "0x400070F")]
		[FieldOffset(Offset = "0x58")]
		private static object infoLevelPropertyValue;

		[Token(Token = "0x4000710")]
		[FieldOffset(Offset = "0x60")]
		private static object errorLevelPropertyValue;

		[Token(Token = "0x4000711")]
		[FieldOffset(Offset = "0x68")]
		private static MethodInfo isEnabledForMethod;

		[Token(Token = "0x4000712")]
		[FieldOffset(Offset = "0x70")]
		private static Type systemStringFormatType;

		[Token(Token = "0x4000713")]
		[FieldOffset(Offset = "0x78")]
		private static Type loggerType;

		[Token(Token = "0x4000714")]
		[FieldOffset(Offset = "0x20")]
		private object internalLogger;

		[Token(Token = "0x4000715")]
		[FieldOffset(Offset = "0x28")]
		private bool? isErrorEnabled;

		[Token(Token = "0x4000716")]
		[FieldOffset(Offset = "0x2A")]
		private bool? isDebugEnabled;

		[Token(Token = "0x4000717")]
		[FieldOffset(Offset = "0x2C")]
		private bool? isInfoEnabled;

		[Token(Token = "0x170003A2")]
		public override bool IsErrorEnabled
		{
			[Token(Token = "0x6000E5B")]
			[Address(RVA = "0x121B410", Offset = "0x121B410", VA = "0x121B410", Slot = "5")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x170003A3")]
		public override bool IsDebugEnabled
		{
			[Token(Token = "0x6000E5D")]
			[Address(RVA = "0x121B948", Offset = "0x121B948", VA = "0x121B948", Slot = "6")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x170003A4")]
		public override bool IsInfoEnabled
		{
			[Token(Token = "0x6000E60")]
			[Address(RVA = "0x121C05C", Offset = "0x121C05C", VA = "0x121C05C", Slot = "7")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x6000E58")]
		[Address(RVA = "0x121A144", Offset = "0x121A144", VA = "0x121A144")]
		private static void loadStatics()
		{
		}

		[Token(Token = "0x6000E59")]
		[Address(RVA = "0x121B168", Offset = "0x121B168", VA = "0x121B168")]
		public InternalLog4netLogger(Type declaringType)
		{
		}

		[Token(Token = "0x6000E5A")]
		[Address(RVA = "0x121B40C", Offset = "0x121B40C", VA = "0x121B40C", Slot = "4")]
		public override void Flush()
		{
		}

		[Token(Token = "0x6000E5C")]
		[Address(RVA = "0x121B738", Offset = "0x121B738", VA = "0x121B738", Slot = "8")]
		public override void Error(Exception exception, string messageFormat, params object[] args)
		{
		}

		[Token(Token = "0x6000E5E")]
		[Address(RVA = "0x121BC70", Offset = "0x121BC70", VA = "0x121BC70", Slot = "9")]
		public override void Debug(Exception exception, string messageFormat, params object[] args)
		{
		}

		[Token(Token = "0x6000E5F")]
		[Address(RVA = "0x121BE80", Offset = "0x121BE80", VA = "0x121BE80", Slot = "10")]
		public override void DebugFormat(string message, params object[] arguments)
		{
		}

		[Token(Token = "0x6000E61")]
		[Address(RVA = "0x121C384", Offset = "0x121C384", VA = "0x121C384", Slot = "11")]
		public override void InfoFormat(string message, params object[] arguments)
		{
		}
	}
}
