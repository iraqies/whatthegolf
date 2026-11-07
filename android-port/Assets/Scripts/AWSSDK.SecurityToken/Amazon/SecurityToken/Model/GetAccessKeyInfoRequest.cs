using Il2CppDummyDll;

namespace Amazon.SecurityToken.Model
{
	[Token(Token = "0x2000021")]
	public class GetAccessKeyInfoRequest : AmazonSecurityTokenServiceRequest
	{
		[Token(Token = "0x4000054")]
		[FieldOffset(Offset = "0x30")]
		private string _accessKeyId;

		[Token(Token = "0x1700003F")]
		[Attribute(Name = "AWSPropertyAttribute", RVA = "0x314BC", Offset = "0x314BC")]
		public string AccessKeyId
		{
			[Token(Token = "0x6000125")]
			[Address(RVA = "0x12DEA20", Offset = "0x12DEA20", VA = "0x12DEA20")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000126")]
			[Address(RVA = "0x12DEA28", Offset = "0x12DEA28", VA = "0x12DEA28")]
			set
			{
			}
		}

		[Token(Token = "0x6000127")]
		[Address(RVA = "0x12DEA30", Offset = "0x12DEA30", VA = "0x12DEA30")]
		internal bool IsSetAccessKeyId()
		{
			return default;
		}

		[Token(Token = "0x6000128")]
		[Address(RVA = "0x12DEA40", Offset = "0x12DEA40", VA = "0x12DEA40")]
		public GetAccessKeyInfoRequest()
		{
		}
	}
}
