using System;
using Il2CppDummyDll;

namespace Amazon.Runtime
{
	[Token(Token = "0x20000BB")]
	public class SAMLImmutableCredentials : ImmutableCredentials
	{
		[Token(Token = "0x400032B")]
		[FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x26958", Offset = "0x26958")]
		private DateTime Expires__BackingField;

		[Token(Token = "0x400032C")]
		[FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x26968", Offset = "0x26968")]
		private string Subject__BackingField;

		[Token(Token = "0x400032D")]
		private const string AccessKeyProperty = "AccessKey";

		[Token(Token = "0x400032E")]
		private const string SecretKeyProperty = "SecretKey";

		[Token(Token = "0x400032F")]
		private const string TokenProperty = "Token";

		[Token(Token = "0x4000330")]
		private const string ExpiresProperty = "Expires";

		[Token(Token = "0x4000331")]
		private const string SubjectProperty = "Subject";

		[Token(Token = "0x170001B8")]
		public DateTime Expires
		{
			[Token(Token = "0x60006E6")]
			[Address(RVA = "0x126CBCC", Offset = "0x126CBCC", VA = "0x126CBCC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x28FAC", Offset = "0x28FAC")]
			get
			{
				return default;
			}
			[Token(Token = "0x60006E7")]
			[Address(RVA = "0x126CBD4", Offset = "0x126CBD4", VA = "0x126CBD4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x28FBC", Offset = "0x28FBC")]
			private set
			{
			}
		}

		[Token(Token = "0x170001B9")]
		public string Subject
		{
			[Token(Token = "0x60006E8")]
			[Address(RVA = "0x126CBDC", Offset = "0x126CBDC", VA = "0x126CBDC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x28FCC", Offset = "0x28FCC")]
			get
			{
				return null;
			}
			[Token(Token = "0x60006E9")]
			[Address(RVA = "0x126CBE4", Offset = "0x126CBE4", VA = "0x126CBE4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x28FDC", Offset = "0x28FDC")]
			private set
			{
			}
		}

		[Token(Token = "0x60006EA")]
		[Address(RVA = "0x126CBEC", Offset = "0x126CBEC", VA = "0x126CBEC")]
		public SAMLImmutableCredentials(string awsAccessKeyId, string awsSecretAccessKey, string token, DateTime expires, string subject)
		{
		}

		[Token(Token = "0x60006EB")]
		[Address(RVA = "0x126CC24", Offset = "0x126CC24", VA = "0x126CC24")]
		public SAMLImmutableCredentials(ImmutableCredentials credentials, DateTime expires, string subject)
		{
		}

		[Token(Token = "0x60006EC")]
		[Address(RVA = "0x126CC70", Offset = "0x126CC70", VA = "0x126CC70", Slot = "2")]
		public override int GetHashCode()
		{
			return default;
		}

		[Token(Token = "0x60006ED")]
		[Address(RVA = "0x126CE00", Offset = "0x126CE00", VA = "0x126CE00", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default;
		}

		[Token(Token = "0x60006EE")]
		[Address(RVA = "0x126CF28", Offset = "0x126CF28", VA = "0x126CF28", Slot = "4")]
		public override ImmutableCredentials Copy()
		{
			return null;
		}

		[Token(Token = "0x60006EF")]
		[Address(RVA = "0x126CFB8", Offset = "0x126CFB8", VA = "0x126CFB8")]
		internal string ToJson()
		{
			return null;
		}

		[Token(Token = "0x60006F0")]
		[Address(RVA = "0x126D1D0", Offset = "0x126D1D0", VA = "0x126D1D0")]
		internal static SAMLImmutableCredentials FromJson(string json)
		{
			return null;
		}
	}
}
