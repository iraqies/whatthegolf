using System;
using Il2CppDummyDll;

namespace Amazon.Runtime.Internal.Util
{
	[Token(Token = "0x20001DD")]
	public class MetricError
	{
		[Token(Token = "0x400073A")]
		[FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x279D8", Offset = "0x279D8")]
		private Metric Metric__BackingField;

		[Token(Token = "0x400073B")]
		[FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x279E8", Offset = "0x279E8")]
		private string Message__BackingField;

		[Token(Token = "0x400073C")]
		[FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x279F8", Offset = "0x279F8")]
		private Exception Exception__BackingField;

		[Token(Token = "0x400073D")]
		[FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x27A08", Offset = "0x27A08")]
		private DateTime Time__BackingField;

		[Token(Token = "0x170003B8")]
		public Metric Metric
		{
			[Token(Token = "0x6000EAE")]
			[Address(RVA = "0x123E3A8", Offset = "0x123E3A8", VA = "0x123E3A8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x2B7F4", Offset = "0x2B7F4")]
			get
			{
				return default;
			}
			[Token(Token = "0x6000EAF")]
			[Address(RVA = "0x123E3B0", Offset = "0x123E3B0", VA = "0x123E3B0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x2B804", Offset = "0x2B804")]
			private set
			{
			}
		}

		[Token(Token = "0x170003B9")]
		public string Message
		{
			[Token(Token = "0x6000EB0")]
			[Address(RVA = "0x123E3B8", Offset = "0x123E3B8", VA = "0x123E3B8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x2B814", Offset = "0x2B814")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000EB1")]
			[Address(RVA = "0x123E3C0", Offset = "0x123E3C0", VA = "0x123E3C0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x2B824", Offset = "0x2B824")]
			private set
			{
			}
		}

		[Token(Token = "0x170003BA")]
		public Exception Exception
		{
			[Token(Token = "0x6000EB2")]
			[Address(RVA = "0x123E3C8", Offset = "0x123E3C8", VA = "0x123E3C8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x2B834", Offset = "0x2B834")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000EB3")]
			[Address(RVA = "0x123E3D0", Offset = "0x123E3D0", VA = "0x123E3D0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x2B844", Offset = "0x2B844")]
			private set
			{
			}
		}

		[Token(Token = "0x170003BB")]
		public DateTime Time
		{
			[Token(Token = "0x6000EB4")]
			[Address(RVA = "0x123E3D8", Offset = "0x123E3D8", VA = "0x123E3D8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x2B854", Offset = "0x2B854")]
			get
			{
				return default;
			}
			[Token(Token = "0x6000EB5")]
			[Address(RVA = "0x123E3E0", Offset = "0x123E3E0", VA = "0x123E3E0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x2B864", Offset = "0x2B864")]
			private set
			{
			}
		}

		[Token(Token = "0x6000EB6")]
		[Address(RVA = "0x123E3E8", Offset = "0x123E3E8", VA = "0x123E3E8")]
		public MetricError(Metric metric, string messageFormat, params object[] args)
		{
		}

		[Token(Token = "0x6000EB7")]
		[Address(RVA = "0x123E3F8", Offset = "0x123E3F8", VA = "0x123E3F8")]
		public MetricError(Metric metric, Exception exception, string messageFormat, params object[] args)
		{
		}
	}
}
