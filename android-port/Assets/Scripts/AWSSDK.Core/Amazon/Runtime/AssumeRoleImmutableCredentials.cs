using System;
using Il2CppDummyDll;

namespace Amazon.Runtime
{
	[Token(Token = "0x20000AF")]
	public class AssumeRoleImmutableCredentials : ImmutableCredentials
	{
		[Token(Token = "0x400030A")]
		[FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x268E8", Offset = "0x268E8")]
		private DateTime Expiration__BackingField;

		[Token(Token = "0x170001AE")]
		public DateTime Expiration
		{
			[Token(Token = "0x600069C")]
			[Address(RVA = "0x11D1AE0", Offset = "0x11D1AE0", VA = "0x11D1AE0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x28EAC", Offset = "0x28EAC")]
			get
			{
				return default;
			}
			[Token(Token = "0x600069D")]
			[Address(RVA = "0x11D1AE8", Offset = "0x11D1AE8", VA = "0x11D1AE8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x28EBC", Offset = "0x28EBC")]
			private set
			{
			}
		}

		[Token(Token = "0x600069E")]
		[Address(RVA = "0x11D1AF0", Offset = "0x11D1AF0", VA = "0x11D1AF0")]
		public AssumeRoleImmutableCredentials(string awsAccessKeyId, string awsSecretAccessKey, string token, DateTime expiration)
		{
		}

		[Token(Token = "0x600069F")]
		[Address(RVA = "0x11D1B80", Offset = "0x11D1B80", VA = "0x11D1B80")]
		public new AssumeRoleImmutableCredentials Copy()
		{
			return null;
		}

		[Token(Token = "0x60006A0")]
		[Address(RVA = "0x11D1C00", Offset = "0x11D1C00", VA = "0x11D1C00", Slot = "2")]
		public override int GetHashCode()
		{
			return default;
		}

		[Token(Token = "0x60006A1")]
		[Address(RVA = "0x11D1D64", Offset = "0x11D1D64", VA = "0x11D1D64", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default;
		}
	}
}
