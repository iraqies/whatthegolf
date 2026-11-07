using Amazon.Runtime;
using Il2CppDummyDll;

namespace Amazon.CognitoIdentityProvider.Model
{
	[Token(Token = "0x2000075")]
	public class ConfirmDeviceResponse : AmazonWebServiceResponse
	{
		[Token(Token = "0x4000125")]
		[FieldOffset(Offset = "0x24")]
		private bool? _userConfirmationNecessary;

		[Token(Token = "0x170000B2")]
		public bool UserConfirmationNecessary
		{
			[Token(Token = "0x6000432")]
			[Address(RVA = "0x10E5868", Offset = "0x10E5868", VA = "0x10E5868")]
			get
			{
				return default;
			}
			[Token(Token = "0x6000433")]
			[Address(RVA = "0x10E58A8", Offset = "0x10E58A8", VA = "0x10E58A8")]
			set
			{
			}
		}

		[Token(Token = "0x6000434")]
		[Address(RVA = "0x10E591C", Offset = "0x10E591C", VA = "0x10E591C")]
		internal bool IsSetUserConfirmationNecessary()
		{
			return default;
		}

		[Token(Token = "0x6000435")]
		[Address(RVA = "0x10E595C", Offset = "0x10E595C", VA = "0x10E595C")]
		public ConfirmDeviceResponse()
		{
		}
	}
}
