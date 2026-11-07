using Il2CppDummyDll;

namespace Amazon.CognitoSync.Model
{
	[Token(Token = "0x2000011")]
	public class DeleteDatasetRequest : AmazonCognitoSyncRequest
	{
		[Token(Token = "0x400001C")]
		[FieldOffset(Offset = "0x30")]
		private string _datasetName;

		[Token(Token = "0x400001D")]
		[FieldOffset(Offset = "0x38")]
		private string _identityId;

		[Token(Token = "0x400001E")]
		[FieldOffset(Offset = "0x40")]
		private string _identityPoolId;

		[Token(Token = "0x17000011")]
		[Attribute(Name = "AWSPropertyAttribute", RVA = "0x24424", Offset = "0x24424")]
		public string DatasetName
		{
			[Token(Token = "0x6000097")]
			[Address(RVA = "0x1193B80", Offset = "0x1193B80", VA = "0x1193B80")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000098")]
			[Address(RVA = "0x1193B88", Offset = "0x1193B88", VA = "0x1193B88")]
			set
			{
			}
		}

		[Token(Token = "0x17000012")]
		[Attribute(Name = "AWSPropertyAttribute", RVA = "0x24474", Offset = "0x24474")]
		public string IdentityId
		{
			[Token(Token = "0x600009A")]
			[Address(RVA = "0x1193BA0", Offset = "0x1193BA0", VA = "0x1193BA0")]
			get
			{
				return null;
			}
			[Token(Token = "0x600009B")]
			[Address(RVA = "0x1193BA8", Offset = "0x1193BA8", VA = "0x1193BA8")]
			set
			{
			}
		}

		[Token(Token = "0x17000013")]
		[Attribute(Name = "AWSPropertyAttribute", RVA = "0x244C4", Offset = "0x244C4")]
		public string IdentityPoolId
		{
			[Token(Token = "0x600009D")]
			[Address(RVA = "0x1193BC0", Offset = "0x1193BC0", VA = "0x1193BC0")]
			get
			{
				return null;
			}
			[Token(Token = "0x600009E")]
			[Address(RVA = "0x1193BC8", Offset = "0x1193BC8", VA = "0x1193BC8")]
			set
			{
			}
		}

		[Token(Token = "0x6000099")]
		[Address(RVA = "0x1193B90", Offset = "0x1193B90", VA = "0x1193B90")]
		internal bool IsSetDatasetName()
		{
			return default;
		}

		[Token(Token = "0x600009C")]
		[Address(RVA = "0x1193BB0", Offset = "0x1193BB0", VA = "0x1193BB0")]
		internal bool IsSetIdentityId()
		{
			return default;
		}

		[Token(Token = "0x600009F")]
		[Address(RVA = "0x1193BD0", Offset = "0x1193BD0", VA = "0x1193BD0")]
		internal bool IsSetIdentityPoolId()
		{
			return default;
		}

		[Token(Token = "0x60000A0")]
		[Address(RVA = "0x1193BE0", Offset = "0x1193BE0", VA = "0x1193BE0")]
		public DeleteDatasetRequest()
		{
		}
	}
}
