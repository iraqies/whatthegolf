using Amazon.Runtime;
using Il2CppDummyDll;

namespace Amazon.CognitoSync.Model
{
	[Token(Token = "0x2000039")]
	public class SetIdentityPoolConfigurationResponse : AmazonWebServiceResponse
	{
		[Token(Token = "0x4000072")]
		[FieldOffset(Offset = "0x28")]
		private CognitoStreams _cognitoStreams;

		[Token(Token = "0x4000073")]
		[FieldOffset(Offset = "0x30")]
		private string _identityPoolId;

		[Token(Token = "0x4000074")]
		[FieldOffset(Offset = "0x38")]
		private PushSync _pushSync;

		[Token(Token = "0x17000067")]
		public CognitoStreams CognitoStreams
		{
			[Token(Token = "0x60001E9")]
			[Address(RVA = "0x11A958C", Offset = "0x11A958C", VA = "0x11A958C")]
			get
			{
				return null;
			}
			[Token(Token = "0x60001EA")]
			[Address(RVA = "0x11A9594", Offset = "0x11A9594", VA = "0x11A9594")]
			set
			{
			}
		}

		[Token(Token = "0x17000068")]
		[Attribute(Name = "AWSPropertyAttribute", RVA = "0x24EFC", Offset = "0x24EFC")]
		public string IdentityPoolId
		{
			[Token(Token = "0x60001EC")]
			[Address(RVA = "0x11A95AC", Offset = "0x11A95AC", VA = "0x11A95AC")]
			get
			{
				return null;
			}
			[Token(Token = "0x60001ED")]
			[Address(RVA = "0x11A95B4", Offset = "0x11A95B4", VA = "0x11A95B4")]
			set
			{
			}
		}

		[Token(Token = "0x17000069")]
		public PushSync PushSync
		{
			[Token(Token = "0x60001EF")]
			[Address(RVA = "0x11A95CC", Offset = "0x11A95CC", VA = "0x11A95CC")]
			get
			{
				return null;
			}
			[Token(Token = "0x60001F0")]
			[Address(RVA = "0x11A95D4", Offset = "0x11A95D4", VA = "0x11A95D4")]
			set
			{
			}
		}

		[Token(Token = "0x60001EB")]
		[Address(RVA = "0x11A959C", Offset = "0x11A959C", VA = "0x11A959C")]
		internal bool IsSetCognitoStreams()
		{
			return default;
		}

		[Token(Token = "0x60001EE")]
		[Address(RVA = "0x11A95BC", Offset = "0x11A95BC", VA = "0x11A95BC")]
		internal bool IsSetIdentityPoolId()
		{
			return default;
		}

		[Token(Token = "0x60001F1")]
		[Address(RVA = "0x11A95DC", Offset = "0x11A95DC", VA = "0x11A95DC")]
		internal bool IsSetPushSync()
		{
			return default;
		}

		[Token(Token = "0x60001F2")]
		[Address(RVA = "0x11A95EC", Offset = "0x11A95EC", VA = "0x11A95EC")]
		public SetIdentityPoolConfigurationResponse()
		{
		}
	}
}
