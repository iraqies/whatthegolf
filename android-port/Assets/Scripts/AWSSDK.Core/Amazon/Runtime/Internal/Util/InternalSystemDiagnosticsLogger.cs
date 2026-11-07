using System;
using System.Diagnostics;
using Il2CppDummyDll;

namespace Amazon.Runtime.Internal.Util
{
	[Token(Token = "0x2000202")]
	internal class InternalSystemDiagnosticsLogger : InternalLogger
	{
		[Token(Token = "0x400079C")]
		[FieldOffset(Offset = "0x1C")]
		private int eventId;

		[Token(Token = "0x400079D")]
		[FieldOffset(Offset = "0x20")]
		private TraceSource trace;

		[Token(Token = "0x170003F9")]
		public override bool IsDebugEnabled
		{
			[Token(Token = "0x6000FCF")]
			[Address(RVA = "0x121EB38", Offset = "0x121EB38", VA = "0x121EB38", Slot = "6")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x170003FA")]
		public override bool IsErrorEnabled
		{
			[Token(Token = "0x6000FD0")]
			[Address(RVA = "0x121EB48", Offset = "0x121EB48", VA = "0x121EB48", Slot = "5")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x170003FB")]
		public override bool IsInfoEnabled
		{
			[Token(Token = "0x6000FD1")]
			[Address(RVA = "0x121EB58", Offset = "0x121EB58", VA = "0x121EB58", Slot = "7")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x6000FC9")]
		[Address(RVA = "0x121E5C0", Offset = "0x121E5C0", VA = "0x121E5C0")]
		public InternalSystemDiagnosticsLogger(Type declaringType)
		{
		}

		[Token(Token = "0x6000FCA")]
		[Address(RVA = "0x121E604", Offset = "0x121E604", VA = "0x121E604", Slot = "4")]
		public override void Flush()
		{
		}

		[Token(Token = "0x6000FCB")]
		[Address(RVA = "0x121E618", Offset = "0x121E618", VA = "0x121E618", Slot = "8")]
		public override void Error(Exception exception, string messageFormat, params object[] args)
		{
		}

		[Token(Token = "0x6000FCC")]
		[Address(RVA = "0x121E7DC", Offset = "0x121E7DC", VA = "0x121E7DC", Slot = "9")]
		public override void Debug(Exception exception, string messageFormat, params object[] args)
		{
		}

		[Token(Token = "0x6000FCD")]
		[Address(RVA = "0x121E960", Offset = "0x121E960", VA = "0x121E960", Slot = "10")]
		public override void DebugFormat(string messageFormat, params object[] args)
		{
		}

		[Token(Token = "0x6000FCE")]
		[Address(RVA = "0x121EA4C", Offset = "0x121EA4C", VA = "0x121EA4C", Slot = "11")]
		public override void InfoFormat(string message, params object[] arguments)
		{
		}
	}
}
