using System;
using Il2CppDummyDll;

namespace Amazon.Runtime.Internal.Util
{
	[Token(Token = "0x20001D5")]
	public class LogMessage : ILogMessage
	{
		[Token(Token = "0x400071D")]
		[FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x278E8", Offset = "0x278E8")]
		private object[] Args__BackingField;

		[Token(Token = "0x400071E")]
		[FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x278F8", Offset = "0x278F8")]
		private IFormatProvider Provider__BackingField;

		[Token(Token = "0x400071F")]
		[FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x27908", Offset = "0x27908")]
		private string Format__BackingField;

		[Token(Token = "0x170003A5")]
		public object[] Args
		{
			[Token(Token = "0x6000E63")]
			[Address(RVA = "0x1239F24", Offset = "0x1239F24", VA = "0x1239F24", Slot = "5")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x2B614", Offset = "0x2B614")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000E64")]
			[Address(RVA = "0x1239F2C", Offset = "0x1239F2C", VA = "0x1239F2C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x2B624", Offset = "0x2B624")]
			private set
			{
			}
		}

		[Token(Token = "0x170003A6")]
		public IFormatProvider Provider
		{
			[Token(Token = "0x6000E65")]
			[Address(RVA = "0x1239F34", Offset = "0x1239F34", VA = "0x1239F34", Slot = "6")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x2B634", Offset = "0x2B634")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000E66")]
			[Address(RVA = "0x1239F3C", Offset = "0x1239F3C", VA = "0x1239F3C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x2B644", Offset = "0x2B644")]
			private set
			{
			}
		}

		[Token(Token = "0x170003A7")]
		public string Format
		{
			[Token(Token = "0x6000E67")]
			[Address(RVA = "0x1239F44", Offset = "0x1239F44", VA = "0x1239F44", Slot = "4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x2B654", Offset = "0x2B654")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000E68")]
			[Address(RVA = "0x1239F4C", Offset = "0x1239F4C", VA = "0x1239F4C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x2B664", Offset = "0x2B664")]
			private set
			{
			}
		}

		[Token(Token = "0x6000E69")]
		[Address(RVA = "0x1239F54", Offset = "0x1239F54", VA = "0x1239F54")]
		public LogMessage(string message)
		{
		}

		[Token(Token = "0x6000E6A")]
		[Address(RVA = "0x123A07C", Offset = "0x123A07C", VA = "0x123A07C")]
		public LogMessage(string format, params object[] args)
		{
		}

		[Token(Token = "0x6000E6B")]
		[Address(RVA = "0x121E79C", Offset = "0x121E79C", VA = "0x121E79C")]
		public LogMessage(IFormatProvider provider, string format, params object[] args)
		{
		}

		[Token(Token = "0x6000E6C")]
		[Address(RVA = "0x123A110", Offset = "0x123A110", VA = "0x123A110", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
}
