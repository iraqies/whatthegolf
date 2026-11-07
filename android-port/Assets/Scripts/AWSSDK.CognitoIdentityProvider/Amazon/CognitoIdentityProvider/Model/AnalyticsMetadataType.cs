using Il2CppDummyDll;

namespace Amazon.CognitoIdentityProvider.Model
{
	[Token(Token = "0x2000065")]
	public class AnalyticsMetadataType
	{
		[Token(Token = "0x4000101")]
		[FieldOffset(Offset = "0x10")]
		private string _analyticsEndpointId;

		[Token(Token = "0x1700008E")]
		public string AnalyticsEndpointId
		{
			[Token(Token = "0x60003A9")]
			[Address(RVA = "0x10DCB44", Offset = "0x10DCB44", VA = "0x10DCB44")]
			get
			{
				return null;
			}
			[Token(Token = "0x60003AA")]
			[Address(RVA = "0x10DCB4C", Offset = "0x10DCB4C", VA = "0x10DCB4C")]
			set
			{
			}
		}

		[Token(Token = "0x60003AB")]
		[Address(RVA = "0x10DCB54", Offset = "0x10DCB54", VA = "0x10DCB54")]
		internal bool IsSetAnalyticsEndpointId()
		{
			return default;
		}

		[Token(Token = "0x60003AC")]
		[Address(RVA = "0x10DCB64", Offset = "0x10DCB64", VA = "0x10DCB64")]
		public AnalyticsMetadataType()
		{
		}
	}
}
