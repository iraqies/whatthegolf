using Il2CppDummyDll;

namespace Amazon.CognitoIdentityProvider.Model
{
	[Token(Token = "0x200013C")]
	public class UserContextDataType
	{
		[Token(Token = "0x4000308")]
		[FieldOffset(Offset = "0x10")]
		private string _encodedData;

		[Token(Token = "0x17000295")]
		public string EncodedData
		{
			[Token(Token = "0x6000B17")]
			[Address(RVA = "0x11720DC", Offset = "0x11720DC", VA = "0x11720DC")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000B18")]
			[Address(RVA = "0x11720E4", Offset = "0x11720E4", VA = "0x11720E4")]
			set
			{
			}
		}

		[Token(Token = "0x6000B19")]
		[Address(RVA = "0x11720EC", Offset = "0x11720EC", VA = "0x11720EC")]
		internal bool IsSetEncodedData()
		{
			return default;
		}

		[Token(Token = "0x6000B1A")]
		[Address(RVA = "0x11720FC", Offset = "0x11720FC", VA = "0x11720FC")]
		public UserContextDataType()
		{
		}
	}
}
