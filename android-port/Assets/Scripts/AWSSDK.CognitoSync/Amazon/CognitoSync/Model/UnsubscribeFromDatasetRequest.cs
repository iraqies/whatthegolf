using Il2CppDummyDll;

namespace Amazon.CognitoSync.Model
{
	[Token(Token = "0x200003D")]
	public class UnsubscribeFromDatasetRequest : AmazonCognitoSyncRequest
	{
		[Token(Token = "0x4000079")]
		[FieldOffset(Offset = "0x30")]
		private string _datasetName;

		[Token(Token = "0x400007A")]
		[FieldOffset(Offset = "0x38")]
		private string _deviceId;

		[Token(Token = "0x400007B")]
		[FieldOffset(Offset = "0x40")]
		private string _identityId;

		[Token(Token = "0x400007C")]
		[FieldOffset(Offset = "0x48")]
		private string _identityPoolId;

		[Token(Token = "0x1700006E")]
		[Attribute(Name = "AWSPropertyAttribute", RVA = "0x25084", Offset = "0x25084")]
		public string DatasetName
		{
			[Token(Token = "0x6000206")]
			[Address(RVA = "0x11AB998", Offset = "0x11AB998", VA = "0x11AB998")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000207")]
			[Address(RVA = "0x11AB9A0", Offset = "0x11AB9A0", VA = "0x11AB9A0")]
			set
			{
			}
		}

		[Token(Token = "0x1700006F")]
		[Attribute(Name = "AWSPropertyAttribute", RVA = "0x250D4", Offset = "0x250D4")]
		public string DeviceId
		{
			[Token(Token = "0x6000209")]
			[Address(RVA = "0x11AB9B8", Offset = "0x11AB9B8", VA = "0x11AB9B8")]
			get
			{
				return null;
			}
			[Token(Token = "0x600020A")]
			[Address(RVA = "0x11AB9C0", Offset = "0x11AB9C0", VA = "0x11AB9C0")]
			set
			{
			}
		}

		[Token(Token = "0x17000070")]
		[Attribute(Name = "AWSPropertyAttribute", RVA = "0x25124", Offset = "0x25124")]
		public string IdentityId
		{
			[Token(Token = "0x600020C")]
			[Address(RVA = "0x11AB9D8", Offset = "0x11AB9D8", VA = "0x11AB9D8")]
			get
			{
				return null;
			}
			[Token(Token = "0x600020D")]
			[Address(RVA = "0x11AB9E0", Offset = "0x11AB9E0", VA = "0x11AB9E0")]
			set
			{
			}
		}

		[Token(Token = "0x17000071")]
		[Attribute(Name = "AWSPropertyAttribute", RVA = "0x25174", Offset = "0x25174")]
		public string IdentityPoolId
		{
			[Token(Token = "0x600020F")]
			[Address(RVA = "0x11AB9F8", Offset = "0x11AB9F8", VA = "0x11AB9F8")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000210")]
			[Address(RVA = "0x11ABA00", Offset = "0x11ABA00", VA = "0x11ABA00")]
			set
			{
			}
		}

		[Token(Token = "0x6000208")]
		[Address(RVA = "0x11AB9A8", Offset = "0x11AB9A8", VA = "0x11AB9A8")]
		internal bool IsSetDatasetName()
		{
			return default;
		}

		[Token(Token = "0x600020B")]
		[Address(RVA = "0x11AB9C8", Offset = "0x11AB9C8", VA = "0x11AB9C8")]
		internal bool IsSetDeviceId()
		{
			return default;
		}

		[Token(Token = "0x600020E")]
		[Address(RVA = "0x11AB9E8", Offset = "0x11AB9E8", VA = "0x11AB9E8")]
		internal bool IsSetIdentityId()
		{
			return default;
		}

		[Token(Token = "0x6000211")]
		[Address(RVA = "0x11ABA08", Offset = "0x11ABA08", VA = "0x11ABA08")]
		internal bool IsSetIdentityPoolId()
		{
			return default;
		}

		[Token(Token = "0x6000212")]
		[Address(RVA = "0x11ABA18", Offset = "0x11ABA18", VA = "0x11ABA18")]
		public UnsubscribeFromDatasetRequest()
		{
		}
	}
}
