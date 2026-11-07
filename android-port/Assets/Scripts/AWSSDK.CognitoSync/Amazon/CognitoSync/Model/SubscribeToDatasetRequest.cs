using Il2CppDummyDll;

namespace Amazon.CognitoSync.Model
{
	[Token(Token = "0x200003A")]
	public class SubscribeToDatasetRequest : AmazonCognitoSyncRequest
	{
		[Token(Token = "0x4000075")]
		[FieldOffset(Offset = "0x30")]
		private string _datasetName;

		[Token(Token = "0x4000076")]
		[FieldOffset(Offset = "0x38")]
		private string _deviceId;

		[Token(Token = "0x4000077")]
		[FieldOffset(Offset = "0x40")]
		private string _identityId;

		[Token(Token = "0x4000078")]
		[FieldOffset(Offset = "0x48")]
		private string _identityPoolId;

		[Token(Token = "0x1700006A")]
		[Attribute(Name = "AWSPropertyAttribute", RVA = "0x24F44", Offset = "0x24F44")]
		public string DatasetName
		{
			[Token(Token = "0x60001F3")]
			[Address(RVA = "0x11AA434", Offset = "0x11AA434", VA = "0x11AA434")]
			get
			{
				return null;
			}
			[Token(Token = "0x60001F4")]
			[Address(RVA = "0x11AA43C", Offset = "0x11AA43C", VA = "0x11AA43C")]
			set
			{
			}
		}

		[Token(Token = "0x1700006B")]
		[Attribute(Name = "AWSPropertyAttribute", RVA = "0x24F94", Offset = "0x24F94")]
		public string DeviceId
		{
			[Token(Token = "0x60001F6")]
			[Address(RVA = "0x11AA454", Offset = "0x11AA454", VA = "0x11AA454")]
			get
			{
				return null;
			}
			[Token(Token = "0x60001F7")]
			[Address(RVA = "0x11AA45C", Offset = "0x11AA45C", VA = "0x11AA45C")]
			set
			{
			}
		}

		[Token(Token = "0x1700006C")]
		[Attribute(Name = "AWSPropertyAttribute", RVA = "0x24FE4", Offset = "0x24FE4")]
		public string IdentityId
		{
			[Token(Token = "0x60001F9")]
			[Address(RVA = "0x11AA474", Offset = "0x11AA474", VA = "0x11AA474")]
			get
			{
				return null;
			}
			[Token(Token = "0x60001FA")]
			[Address(RVA = "0x11AA47C", Offset = "0x11AA47C", VA = "0x11AA47C")]
			set
			{
			}
		}

		[Token(Token = "0x1700006D")]
		[Attribute(Name = "AWSPropertyAttribute", RVA = "0x25034", Offset = "0x25034")]
		public string IdentityPoolId
		{
			[Token(Token = "0x60001FC")]
			[Address(RVA = "0x11AA494", Offset = "0x11AA494", VA = "0x11AA494")]
			get
			{
				return null;
			}
			[Token(Token = "0x60001FD")]
			[Address(RVA = "0x11AA49C", Offset = "0x11AA49C", VA = "0x11AA49C")]
			set
			{
			}
		}

		[Token(Token = "0x60001F5")]
		[Address(RVA = "0x11AA444", Offset = "0x11AA444", VA = "0x11AA444")]
		internal bool IsSetDatasetName()
		{
			return default;
		}

		[Token(Token = "0x60001F8")]
		[Address(RVA = "0x11AA464", Offset = "0x11AA464", VA = "0x11AA464")]
		internal bool IsSetDeviceId()
		{
			return default;
		}

		[Token(Token = "0x60001FB")]
		[Address(RVA = "0x11AA484", Offset = "0x11AA484", VA = "0x11AA484")]
		internal bool IsSetIdentityId()
		{
			return default;
		}

		[Token(Token = "0x60001FE")]
		[Address(RVA = "0x11AA4A4", Offset = "0x11AA4A4", VA = "0x11AA4A4")]
		internal bool IsSetIdentityPoolId()
		{
			return default;
		}

		[Token(Token = "0x60001FF")]
		[Address(RVA = "0x11AA4B4", Offset = "0x11AA4B4", VA = "0x11AA4B4")]
		public SubscribeToDatasetRequest()
		{
		}
	}
}
