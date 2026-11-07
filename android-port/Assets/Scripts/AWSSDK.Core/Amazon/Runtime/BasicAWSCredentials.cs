using Il2CppDummyDll;

namespace Amazon.Runtime
{
	[Token(Token = "0x20000B1")]
	public class BasicAWSCredentials : AWSCredentials
	{
		[Token(Token = "0x400030B")]
		[FieldOffset(Offset = "0x10")]
		private ImmutableCredentials _credentials;

		[Token(Token = "0x60006A6")]
		[Address(RVA = "0x11BF538", Offset = "0x11BF538", VA = "0x11BF538")]
		public BasicAWSCredentials(string accessKey, string secretKey)
		{
		}

		[Token(Token = "0x60006A7")]
		[Address(RVA = "0x11D3FB0", Offset = "0x11D3FB0", VA = "0x11D3FB0", Slot = "4")]
		public override ImmutableCredentials GetCredentials()
		{
			return null;
		}

		[Token(Token = "0x60006A8")]
		[Address(RVA = "0x11D3FC8", Offset = "0x11D3FC8", VA = "0x11D3FC8", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default;
		}

		[Token(Token = "0x60006A9")]
		[Address(RVA = "0x11D4154", Offset = "0x11D4154", VA = "0x11D4154", Slot = "2")]
		public override int GetHashCode()
		{
			return default;
		}
	}
}
