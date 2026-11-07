using Il2CppDummyDll;

namespace Amazon.Runtime
{
	[Token(Token = "0x20000B7")]
	public class ImmutableCredentials
	{
		[Token(Token = "0x400031C")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x26908", Offset = "0x26908")]
		private string AccessKey__BackingField;

		[Token(Token = "0x400031D")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x26918", Offset = "0x26918")]
		private string SecretKey__BackingField;

		[Token(Token = "0x400031E")]
		[FieldOffset(Offset = "0x20")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x26928", Offset = "0x26928")]
		private string Token__BackingField;

		[Token(Token = "0x170001B0")]
		public string AccessKey
		{
			[Token(Token = "0x60006C3")]
			[Address(RVA = "0x1214D9C", Offset = "0x1214D9C", VA = "0x1214D9C")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x28EEC", Offset = "0x28EEC")]
			get
			{
				return null;
			}
			[Token(Token = "0x60006C4")]
			[Address(RVA = "0x1214DA4", Offset = "0x1214DA4", VA = "0x1214DA4")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x28EFC", Offset = "0x28EFC")]
			private set
			{
			}
		}

		[Token(Token = "0x170001B1")]
		public string SecretKey
		{
			[Token(Token = "0x60006C5")]
			[Address(RVA = "0x1214DAC", Offset = "0x1214DAC", VA = "0x1214DAC")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x28F0C", Offset = "0x28F0C")]
			get
			{
				return null;
			}
			[Token(Token = "0x60006C6")]
			[Address(RVA = "0x1214DB4", Offset = "0x1214DB4", VA = "0x1214DB4")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x28F1C", Offset = "0x28F1C")]
			private set
			{
			}
		}

		[Token(Token = "0x170001B2")]
		public string Token
		{
			[Token(Token = "0x60006C7")]
			[Address(RVA = "0x1214DBC", Offset = "0x1214DBC", VA = "0x1214DBC")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x28F2C", Offset = "0x28F2C")]
			get
			{
				return null;
			}
			[Token(Token = "0x60006C8")]
			[Address(RVA = "0x1214DC4", Offset = "0x1214DC4", VA = "0x1214DC4")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x28F3C", Offset = "0x28F3C")]
			private set
			{
			}
		}

		[Token(Token = "0x170001B3")]
		public bool UseToken
		{
			[Token(Token = "0x60006C9")]
			[Address(RVA = "0x1214DCC", Offset = "0x1214DCC", VA = "0x1214DCC")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x60006CA")]
		[Address(RVA = "0x1200688", Offset = "0x1200688", VA = "0x1200688")]
		public ImmutableCredentials(string awsAccessKeyId, string awsSecretAccessKey, string token)
		{
		}

		[Token(Token = "0x60006CB")]
		[Address(RVA = "0x1214DEC", Offset = "0x1214DEC", VA = "0x1214DEC")]
		private ImmutableCredentials()
		{
		}

		[Token(Token = "0x60006CC")]
		[Address(RVA = "0x1214DF4", Offset = "0x1214DF4", VA = "0x1214DF4", Slot = "4")]
		public virtual ImmutableCredentials Copy()
		{
			return null;
		}

		[Token(Token = "0x60006CD")]
		[Address(RVA = "0x1214E70", Offset = "0x1214E70", VA = "0x1214E70", Slot = "2")]
		public override int GetHashCode()
		{
			return default;
		}

		[Token(Token = "0x60006CE")]
		[Address(RVA = "0x1214F70", Offset = "0x1214F70", VA = "0x1214F70", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default;
		}
	}
}
