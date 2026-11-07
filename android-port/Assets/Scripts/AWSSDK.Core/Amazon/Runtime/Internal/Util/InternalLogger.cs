using System;
using Il2CppDummyDll;

namespace Amazon.Runtime.Internal.Util
{
	[Token(Token = "0x20001D2")]
	internal abstract class InternalLogger
	{
		[Token(Token = "0x4000702")]
		[FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x278C8", Offset = "0x278C8")]
		private Type DeclaringType__BackingField;

		[Token(Token = "0x4000703")]
		[FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x278D8", Offset = "0x278D8")]
		private bool IsEnabled__BackingField;

		[Token(Token = "0x1700039D")]
		public Type DeclaringType
		{
			[Token(Token = "0x6000E4B")]
			[Address(RVA = "0x121C5E8", Offset = "0x121C5E8", VA = "0x121C5E8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x2B5D4", Offset = "0x2B5D4")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000E4C")]
			[Address(RVA = "0x121C5F0", Offset = "0x121C5F0", VA = "0x121C5F0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x2B5E4", Offset = "0x2B5E4")]
			private set
			{
			}
		}

		[Token(Token = "0x1700039E")]
		public bool IsEnabled
		{
			[Token(Token = "0x6000E4D")]
			[Address(RVA = "0x121C5F8", Offset = "0x121C5F8", VA = "0x121C5F8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x2B5F4", Offset = "0x2B5F4")]
			get
			{
				return default;
			}
			[Token(Token = "0x6000E4E")]
			[Address(RVA = "0x121C600", Offset = "0x121C600", VA = "0x121C600")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x2B604", Offset = "0x2B604")]
			set
			{
			}
		}

		[Token(Token = "0x1700039F")]
		public virtual bool IsErrorEnabled
		{
			[Token(Token = "0x6000E51")]
			[Address(RVA = "0x121C63C", Offset = "0x121C63C", VA = "0x121C63C", Slot = "5")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x170003A0")]
		public virtual bool IsDebugEnabled
		{
			[Token(Token = "0x6000E52")]
			[Address(RVA = "0x121C644", Offset = "0x121C644", VA = "0x121C644", Slot = "6")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x170003A1")]
		public virtual bool IsInfoEnabled
		{
			[Token(Token = "0x6000E53")]
			[Address(RVA = "0x121C64C", Offset = "0x121C64C", VA = "0x121C64C", Slot = "7")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x6000E4F")]
		[Address(RVA = "0x121C608", Offset = "0x121C608", VA = "0x121C608")]
		public InternalLogger(Type declaringType)
		{
		}

		[Token(Token = "0x6000E50")]
		public abstract void Flush();

		[Token(Token = "0x6000E54")]
		public abstract void Error(Exception exception, string messageFormat, params object[] args);

		[Token(Token = "0x6000E55")]
		public abstract void Debug(Exception exception, string messageFormat, params object[] args);

		[Token(Token = "0x6000E56")]
		public abstract void DebugFormat(string message, params object[] arguments);

		[Token(Token = "0x6000E57")]
		public abstract void InfoFormat(string message, params object[] arguments);
	}
}
