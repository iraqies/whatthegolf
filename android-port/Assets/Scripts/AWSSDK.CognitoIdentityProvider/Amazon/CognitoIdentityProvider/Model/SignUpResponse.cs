using Amazon.Runtime;
using Il2CppDummyDll;

namespace Amazon.CognitoIdentityProvider.Model
{
	[Token(Token = "0x2000114")]
	public class SignUpResponse : AmazonWebServiceResponse
	{
		[Token(Token = "0x40002A6")]
		[FieldOffset(Offset = "0x28")]
		private CodeDeliveryDetailsType _codeDeliveryDetails;

		[Token(Token = "0x40002A7")]
		[FieldOffset(Offset = "0x30")]
		private bool? _userConfirmed;

		[Token(Token = "0x40002A8")]
		[FieldOffset(Offset = "0x38")]
		private string _userSub;

		[Token(Token = "0x17000233")]
		public CodeDeliveryDetailsType CodeDeliveryDetails
		{
			[Token(Token = "0x60009B0")]
			[Address(RVA = "0x1155240", Offset = "0x1155240", VA = "0x1155240")]
			get
			{
				return null;
			}
			[Token(Token = "0x60009B1")]
			[Address(RVA = "0x1155248", Offset = "0x1155248", VA = "0x1155248")]
			set
			{
			}
		}

		[Token(Token = "0x17000234")]
		[Attribute(Name = "AWSPropertyAttribute", RVA = "0x205DC", Offset = "0x205DC")]
		public bool UserConfirmed
		{
			[Token(Token = "0x60009B3")]
			[Address(RVA = "0x1155260", Offset = "0x1155260", VA = "0x1155260")]
			get
			{
				return default;
			}
			[Token(Token = "0x60009B4")]
			[Address(RVA = "0x11552A0", Offset = "0x11552A0", VA = "0x11552A0")]
			set
			{
			}
		}

		[Token(Token = "0x17000235")]
		[Attribute(Name = "AWSPropertyAttribute", RVA = "0x20610", Offset = "0x20610")]
		public string UserSub
		{
			[Token(Token = "0x60009B6")]
			[Address(RVA = "0x1155354", Offset = "0x1155354", VA = "0x1155354")]
			get
			{
				return null;
			}
			[Token(Token = "0x60009B7")]
			[Address(RVA = "0x115535C", Offset = "0x115535C", VA = "0x115535C")]
			set
			{
			}
		}

		[Token(Token = "0x60009B2")]
		[Address(RVA = "0x1155250", Offset = "0x1155250", VA = "0x1155250")]
		internal bool IsSetCodeDeliveryDetails()
		{
			return default;
		}

		[Token(Token = "0x60009B5")]
		[Address(RVA = "0x1155314", Offset = "0x1155314", VA = "0x1155314")]
		internal bool IsSetUserConfirmed()
		{
			return default;
		}

		[Token(Token = "0x60009B8")]
		[Address(RVA = "0x1155364", Offset = "0x1155364", VA = "0x1155364")]
		internal bool IsSetUserSub()
		{
			return default;
		}

		[Token(Token = "0x60009B9")]
		[Address(RVA = "0x1155374", Offset = "0x1155374", VA = "0x1155374")]
		public SignUpResponse()
		{
		}
	}
}
