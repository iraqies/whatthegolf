using Il2CppDummyDll;

namespace Amazon.CognitoSync.Model
{
	[Token(Token = "0x2000032")]
	public class RegisterDeviceRequest : AmazonCognitoSyncRequest
	{
		[Token(Token = "0x4000068")]
		[FieldOffset(Offset = "0x30")]
		private string _identityId;

		[Token(Token = "0x4000069")]
		[FieldOffset(Offset = "0x38")]
		private string _identityPoolId;

		[Token(Token = "0x400006A")]
		[FieldOffset(Offset = "0x40")]
		private Platform _platform;

		[Token(Token = "0x400006B")]
		[FieldOffset(Offset = "0x48")]
		private string _token;

		[Token(Token = "0x1700005D")]
		[Attribute(Name = "AWSPropertyAttribute", RVA = "0x24CCC", Offset = "0x24CCC")]
		public string IdentityId
		{
			[Token(Token = "0x60001BC")]
			[Address(RVA = "0x11A58A0", Offset = "0x11A58A0", VA = "0x11A58A0")]
			get
			{
				return null;
			}
			[Token(Token = "0x60001BD")]
			[Address(RVA = "0x11A58A8", Offset = "0x11A58A8", VA = "0x11A58A8")]
			set
			{
			}
		}

		[Token(Token = "0x1700005E")]
		[Attribute(Name = "AWSPropertyAttribute", RVA = "0x24D1C", Offset = "0x24D1C")]
		public string IdentityPoolId
		{
			[Token(Token = "0x60001BF")]
			[Address(RVA = "0x11A58C0", Offset = "0x11A58C0", VA = "0x11A58C0")]
			get
			{
				return null;
			}
			[Token(Token = "0x60001C0")]
			[Address(RVA = "0x11A58C8", Offset = "0x11A58C8", VA = "0x11A58C8")]
			set
			{
			}
		}

		[Token(Token = "0x1700005F")]
		[Attribute(Name = "AWSPropertyAttribute", RVA = "0x24D6C", Offset = "0x24D6C")]
		public Platform Platform
		{
			[Token(Token = "0x60001C2")]
			[Address(RVA = "0x11A58E0", Offset = "0x11A58E0", VA = "0x11A58E0")]
			get
			{
				return null;
			}
			[Token(Token = "0x60001C3")]
			[Address(RVA = "0x11A58E8", Offset = "0x11A58E8", VA = "0x11A58E8")]
			set
			{
			}
		}

		[Token(Token = "0x17000060")]
		[Attribute(Name = "AWSPropertyAttribute", RVA = "0x24DA0", Offset = "0x24DA0")]
		public string Token
		{
			[Token(Token = "0x60001C5")]
			[Address(RVA = "0x11A596C", Offset = "0x11A596C", VA = "0x11A596C")]
			get
			{
				return null;
			}
			[Token(Token = "0x60001C6")]
			[Address(RVA = "0x11A5974", Offset = "0x11A5974", VA = "0x11A5974")]
			set
			{
			}
		}

		[Token(Token = "0x60001BE")]
		[Address(RVA = "0x11A58B0", Offset = "0x11A58B0", VA = "0x11A58B0")]
		internal bool IsSetIdentityId()
		{
			return default;
		}

		[Token(Token = "0x60001C1")]
		[Address(RVA = "0x11A58D0", Offset = "0x11A58D0", VA = "0x11A58D0")]
		internal bool IsSetIdentityPoolId()
		{
			return default;
		}

		[Token(Token = "0x60001C4")]
		[Address(RVA = "0x11A58F0", Offset = "0x11A58F0", VA = "0x11A58F0")]
		internal bool IsSetPlatform()
		{
			return default;
		}

		[Token(Token = "0x60001C7")]
		[Address(RVA = "0x11A597C", Offset = "0x11A597C", VA = "0x11A597C")]
		internal bool IsSetToken()
		{
			return default;
		}

		[Token(Token = "0x60001C8")]
		[Address(RVA = "0x11A598C", Offset = "0x11A598C", VA = "0x11A598C")]
		public RegisterDeviceRequest()
		{
		}
	}
}
