using Il2CppDummyDll;

namespace Amazon.CognitoSync.Model
{
	[Token(Token = "0x2000013")]
	public class DescribeDatasetRequest : AmazonCognitoSyncRequest
	{
		[Token(Token = "0x4000020")]
		[FieldOffset(Offset = "0x30")]
		private string _datasetName;

		[Token(Token = "0x4000021")]
		[FieldOffset(Offset = "0x38")]
		private string _identityId;

		[Token(Token = "0x4000022")]
		[FieldOffset(Offset = "0x40")]
		private string _identityPoolId;

		[Token(Token = "0x17000015")]
		[Attribute(Name = "AWSPropertyAttribute", RVA = "0x24514", Offset = "0x24514")]
		public string DatasetName
		{
			[Token(Token = "0x60000A5")]
			[Address(RVA = "0x1195048", Offset = "0x1195048", VA = "0x1195048")]
			get
			{
				return null;
			}
			[Token(Token = "0x60000A6")]
			[Address(RVA = "0x1195050", Offset = "0x1195050", VA = "0x1195050")]
			set
			{
			}
		}

		[Token(Token = "0x17000016")]
		[Attribute(Name = "AWSPropertyAttribute", RVA = "0x24564", Offset = "0x24564")]
		public string IdentityId
		{
			[Token(Token = "0x60000A8")]
			[Address(RVA = "0x1195068", Offset = "0x1195068", VA = "0x1195068")]
			get
			{
				return null;
			}
			[Token(Token = "0x60000A9")]
			[Address(RVA = "0x1195070", Offset = "0x1195070", VA = "0x1195070")]
			set
			{
			}
		}

		[Token(Token = "0x17000017")]
		[Attribute(Name = "AWSPropertyAttribute", RVA = "0x245B4", Offset = "0x245B4")]
		public string IdentityPoolId
		{
			[Token(Token = "0x60000AB")]
			[Address(RVA = "0x1195088", Offset = "0x1195088", VA = "0x1195088")]
			get
			{
				return null;
			}
			[Token(Token = "0x60000AC")]
			[Address(RVA = "0x1195090", Offset = "0x1195090", VA = "0x1195090")]
			set
			{
			}
		}

		[Token(Token = "0x60000A7")]
		[Address(RVA = "0x1195058", Offset = "0x1195058", VA = "0x1195058")]
		internal bool IsSetDatasetName()
		{
			return default;
		}

		[Token(Token = "0x60000AA")]
		[Address(RVA = "0x1195078", Offset = "0x1195078", VA = "0x1195078")]
		internal bool IsSetIdentityId()
		{
			return default;
		}

		[Token(Token = "0x60000AD")]
		[Address(RVA = "0x1195098", Offset = "0x1195098", VA = "0x1195098")]
		internal bool IsSetIdentityPoolId()
		{
			return default;
		}

		[Token(Token = "0x60000AE")]
		[Address(RVA = "0x11950A8", Offset = "0x11950A8", VA = "0x11950A8")]
		public DescribeDatasetRequest()
		{
		}
	}
}
