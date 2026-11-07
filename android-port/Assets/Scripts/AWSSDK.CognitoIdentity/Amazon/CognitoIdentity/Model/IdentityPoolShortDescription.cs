using Il2CppDummyDll;

namespace Amazon.CognitoIdentity.Model
{
	[Token(Token = "0x2000034")]
	public class IdentityPoolShortDescription
	{
		[Token(Token = "0x4000098")]
		[FieldOffset(Offset = "0x10")]
		private string _identityPoolId;

		[Token(Token = "0x4000099")]
		[FieldOffset(Offset = "0x18")]
		private string _identityPoolName;

		[Token(Token = "0x1700005F")]
		[Attribute(Name = "AWSPropertyAttribute", RVA = "0x2303C", Offset = "0x2303C")]
		public string IdentityPoolId
		{
			[Token(Token = "0x60001D1")]
			[Address(RVA = "0x108CF10", Offset = "0x108CF10", VA = "0x108CF10")]
			get
			{
				return null;
			}
			[Token(Token = "0x60001D2")]
			[Address(RVA = "0x108CF18", Offset = "0x108CF18", VA = "0x108CF18")]
			set
			{
			}
		}

		[Token(Token = "0x17000060")]
		[Attribute(Name = "AWSPropertyAttribute", RVA = "0x23084", Offset = "0x23084")]
		public string IdentityPoolName
		{
			[Token(Token = "0x60001D4")]
			[Address(RVA = "0x108CF30", Offset = "0x108CF30", VA = "0x108CF30")]
			get
			{
				return null;
			}
			[Token(Token = "0x60001D5")]
			[Address(RVA = "0x108CF38", Offset = "0x108CF38", VA = "0x108CF38")]
			set
			{
			}
		}

		[Token(Token = "0x60001D3")]
		[Address(RVA = "0x108CF20", Offset = "0x108CF20", VA = "0x108CF20")]
		internal bool IsSetIdentityPoolId()
		{
			return default;
		}

		[Token(Token = "0x60001D6")]
		[Address(RVA = "0x108CF40", Offset = "0x108CF40", VA = "0x108CF40")]
		internal bool IsSetIdentityPoolName()
		{
			return default;
		}

		[Token(Token = "0x60001D7")]
		[Address(RVA = "0x108CF50", Offset = "0x108CF50", VA = "0x108CF50")]
		public IdentityPoolShortDescription()
		{
		}
	}
}
