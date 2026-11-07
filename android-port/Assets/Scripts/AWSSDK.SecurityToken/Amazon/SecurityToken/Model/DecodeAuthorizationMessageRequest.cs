using Il2CppDummyDll;

namespace Amazon.SecurityToken.Model
{
	[Token(Token = "0x200001D")]
	public class DecodeAuthorizationMessageRequest : AmazonSecurityTokenServiceRequest
	{
		[Token(Token = "0x4000050")]
		[FieldOffset(Offset = "0x30")]
		private string _encodedMessage;

		[Token(Token = "0x1700003B")]
		[Attribute(Name = "AWSPropertyAttribute", RVA = "0x313CC", Offset = "0x313CC")]
		public string EncodedMessage
		{
			[Token(Token = "0x6000110")]
			[Address(RVA = "0x12DD47C", Offset = "0x12DD47C", VA = "0x12DD47C")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000111")]
			[Address(RVA = "0x12DD484", Offset = "0x12DD484", VA = "0x12DD484")]
			set
			{
			}
		}

		[Token(Token = "0x6000112")]
		[Address(RVA = "0x12DD48C", Offset = "0x12DD48C", VA = "0x12DD48C")]
		internal bool IsSetEncodedMessage()
		{
			return default;
		}

		[Token(Token = "0x6000113")]
		[Address(RVA = "0x12DD49C", Offset = "0x12DD49C", VA = "0x12DD49C")]
		public DecodeAuthorizationMessageRequest()
		{
		}
	}
}
