using System;
using System.Net;
using Il2CppDummyDll;

namespace Amazon.Runtime
{
	[Token(Token = "0x20000AE")]
	public class AssumeRoleAWSCredentialsOptions
	{
		[Token(Token = "0x4000304")]
		[FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x26888", Offset = "0x26888")]
		private string ExternalId__BackingField;

		[Token(Token = "0x4000305")]
		[FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x26898", Offset = "0x26898")]
		private string Policy__BackingField;

		[Token(Token = "0x4000306")]
		[FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x268A8", Offset = "0x268A8")]
		private int? DurationSeconds__BackingField;

		[Token(Token = "0x4000307")]
		[FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x268B8", Offset = "0x268B8")]
		private IWebProxy ProxySettings__BackingField;

		[Token(Token = "0x4000308")]
		[FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x268C8", Offset = "0x268C8")]
		private string MfaSerialNumber__BackingField;

		[Token(Token = "0x4000309")]
		[FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x268D8", Offset = "0x268D8")]
		private Func<string> MfaTokenCodeCallback__BackingField;

		[Token(Token = "0x170001A7")]
		public string ExternalId
		{
			[Token(Token = "0x600068E")]
			[Address(RVA = "0x11D19C8", Offset = "0x11D19C8", VA = "0x11D19C8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x28DEC", Offset = "0x28DEC")]
			get
			{
				return null;
			}
			[Token(Token = "0x600068F")]
			[Address(RVA = "0x11D19D0", Offset = "0x11D19D0", VA = "0x11D19D0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x28DFC", Offset = "0x28DFC")]
			set
			{
			}
		}

		[Token(Token = "0x170001A8")]
		public string Policy
		{
			[Token(Token = "0x6000690")]
			[Address(RVA = "0x11D19D8", Offset = "0x11D19D8", VA = "0x11D19D8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x28E0C", Offset = "0x28E0C")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000691")]
			[Address(RVA = "0x11D19E0", Offset = "0x11D19E0", VA = "0x11D19E0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x28E1C", Offset = "0x28E1C")]
			set
			{
			}
		}

		[Token(Token = "0x170001A9")]
		public int? DurationSeconds
		{
			[Token(Token = "0x6000692")]
			[Address(RVA = "0x11D19E8", Offset = "0x11D19E8", VA = "0x11D19E8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x28E2C", Offset = "0x28E2C")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000693")]
			[Address(RVA = "0x11D19F0", Offset = "0x11D19F0", VA = "0x11D19F0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x28E3C", Offset = "0x28E3C")]
			set
			{
			}
		}

		[Token(Token = "0x170001AA")]
		public IWebProxy ProxySettings
		{
			[Token(Token = "0x6000694")]
			[Address(RVA = "0x11D19F8", Offset = "0x11D19F8", VA = "0x11D19F8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x28E4C", Offset = "0x28E4C")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000695")]
			[Address(RVA = "0x11D1A00", Offset = "0x11D1A00", VA = "0x11D1A00")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x28E5C", Offset = "0x28E5C")]
			set
			{
			}
		}

		[Token(Token = "0x170001AB")]
		public string MfaSerialNumber
		{
			[Token(Token = "0x6000696")]
			[Address(RVA = "0x11D1A08", Offset = "0x11D1A08", VA = "0x11D1A08")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x28E6C", Offset = "0x28E6C")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000697")]
			[Address(RVA = "0x11D1A10", Offset = "0x11D1A10", VA = "0x11D1A10")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x28E7C", Offset = "0x28E7C")]
			set
			{
			}
		}

		[Token(Token = "0x170001AC")]
		public string MfaTokenCode
		{
			[Token(Token = "0x6000698")]
			[Address(RVA = "0x11D1A18", Offset = "0x11D1A18", VA = "0x11D1A18")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170001AD")]
		public Func<string> MfaTokenCodeCallback
		{
			[Token(Token = "0x6000699")]
			[Address(RVA = "0x11D1AD0", Offset = "0x11D1AD0", VA = "0x11D1AD0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x28E8C", Offset = "0x28E8C")]
			get
			{
				return null;
			}
			[Token(Token = "0x600069A")]
			[Address(RVA = "0x11D1AD8", Offset = "0x11D1AD8", VA = "0x11D1AD8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x28E9C", Offset = "0x28E9C")]
			set
			{
			}
		}

		[Token(Token = "0x600069B")]
		[Address(RVA = "0x11BFACC", Offset = "0x11BFACC", VA = "0x11BFACC")]
		public AssumeRoleAWSCredentialsOptions()
		{
		}
	}
}
