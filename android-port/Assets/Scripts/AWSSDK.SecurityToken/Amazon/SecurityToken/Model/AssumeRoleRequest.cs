using System.Collections.Generic;
using Il2CppDummyDll;

namespace Amazon.SecurityToken.Model
{
	[Token(Token = "0x2000017")]
	public class AssumeRoleRequest : AmazonSecurityTokenServiceRequest
	{
		[Token(Token = "0x4000028")]
		[FieldOffset(Offset = "0x2C")]
		private int? _durationSeconds;

		[Token(Token = "0x4000029")]
		[FieldOffset(Offset = "0x38")]
		private string _externalId;

		[Token(Token = "0x400002A")]
		[FieldOffset(Offset = "0x40")]
		private string _policy;

		[Token(Token = "0x400002B")]
		[FieldOffset(Offset = "0x48")]
		private List<PolicyDescriptorType> _policyArns;

		[Token(Token = "0x400002C")]
		[FieldOffset(Offset = "0x50")]
		private string _roleArn;

		[Token(Token = "0x400002D")]
		[FieldOffset(Offset = "0x58")]
		private string _roleSessionName;

		[Token(Token = "0x400002E")]
		[FieldOffset(Offset = "0x60")]
		private string _serialNumber;

		[Token(Token = "0x400002F")]
		[FieldOffset(Offset = "0x68")]
		private List<Tag> _tags;

		[Token(Token = "0x4000030")]
		[FieldOffset(Offset = "0x70")]
		private string _tokenCode;

		[Token(Token = "0x4000031")]
		[FieldOffset(Offset = "0x78")]
		private List<string> _transitiveTagKeys;

		[Token(Token = "0x17000013")]
		[Attribute(Name = "AWSPropertyAttribute", RVA = "0x30D18", Offset = "0x30D18")]
		public int DurationSeconds
		{
			[Token(Token = "0x6000092")]
			[Address(RVA = "0x12D5098", Offset = "0x12D5098", VA = "0x12D5098")]
			get
			{
				return default;
			}
			[Token(Token = "0x6000093")]
			[Address(RVA = "0x12D1DF8", Offset = "0x12D1DF8", VA = "0x12D1DF8")]
			set
			{
			}
		}

		[Token(Token = "0x17000014")]
		[Attribute(Name = "AWSPropertyAttribute", RVA = "0x30D60", Offset = "0x30D60")]
		public string ExternalId
		{
			[Token(Token = "0x6000095")]
			[Address(RVA = "0x12D5118", Offset = "0x12D5118", VA = "0x12D5118")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000096")]
			[Address(RVA = "0x12D5120", Offset = "0x12D5120", VA = "0x12D5120")]
			set
			{
			}
		}

		[Token(Token = "0x17000015")]
		[Attribute(Name = "AWSPropertyAttribute", RVA = "0x30DA8", Offset = "0x30DA8")]
		public string Policy
		{
			[Token(Token = "0x6000098")]
			[Address(RVA = "0x12D5138", Offset = "0x12D5138", VA = "0x12D5138")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000099")]
			[Address(RVA = "0x12D5140", Offset = "0x12D5140", VA = "0x12D5140")]
			set
			{
			}
		}

		[Token(Token = "0x17000016")]
		public List<PolicyDescriptorType> PolicyArns
		{
			[Token(Token = "0x600009B")]
			[Address(RVA = "0x12D5158", Offset = "0x12D5158", VA = "0x12D5158")]
			get
			{
				return null;
			}
			[Token(Token = "0x600009C")]
			[Address(RVA = "0x12D5160", Offset = "0x12D5160", VA = "0x12D5160")]
			set
			{
			}
		}

		[Token(Token = "0x17000017")]
		[Attribute(Name = "AWSPropertyAttribute", RVA = "0x30DF0", Offset = "0x30DF0")]
		public string RoleArn
		{
			[Token(Token = "0x600009E")]
			[Address(RVA = "0x12D51C0", Offset = "0x12D51C0", VA = "0x12D51C0")]
			get
			{
				return null;
			}
			[Token(Token = "0x600009F")]
			[Address(RVA = "0x12D51C8", Offset = "0x12D51C8", VA = "0x12D51C8")]
			set
			{
			}
		}

		[Token(Token = "0x17000018")]
		[Attribute(Name = "AWSPropertyAttribute", RVA = "0x30E40", Offset = "0x30E40")]
		public string RoleSessionName
		{
			[Token(Token = "0x60000A1")]
			[Address(RVA = "0x12D51E0", Offset = "0x12D51E0", VA = "0x12D51E0")]
			get
			{
				return null;
			}
			[Token(Token = "0x60000A2")]
			[Address(RVA = "0x12D51E8", Offset = "0x12D51E8", VA = "0x12D51E8")]
			set
			{
			}
		}

		[Token(Token = "0x17000019")]
		[Attribute(Name = "AWSPropertyAttribute", RVA = "0x30E90", Offset = "0x30E90")]
		public string SerialNumber
		{
			[Token(Token = "0x60000A4")]
			[Address(RVA = "0x12D5200", Offset = "0x12D5200", VA = "0x12D5200")]
			get
			{
				return null;
			}
			[Token(Token = "0x60000A5")]
			[Address(RVA = "0x12D5208", Offset = "0x12D5208", VA = "0x12D5208")]
			set
			{
			}
		}

		[Token(Token = "0x1700001A")]
		[Attribute(Name = "AWSPropertyAttribute", RVA = "0x30ED8", Offset = "0x30ED8")]
		public List<Tag> Tags
		{
			[Token(Token = "0x60000A7")]
			[Address(RVA = "0x12D5220", Offset = "0x12D5220", VA = "0x12D5220")]
			get
			{
				return null;
			}
			[Token(Token = "0x60000A8")]
			[Address(RVA = "0x12D5228", Offset = "0x12D5228", VA = "0x12D5228")]
			set
			{
			}
		}

		[Token(Token = "0x1700001B")]
		[Attribute(Name = "AWSPropertyAttribute", RVA = "0x30F10", Offset = "0x30F10")]
		public string TokenCode
		{
			[Token(Token = "0x60000AA")]
			[Address(RVA = "0x12D5288", Offset = "0x12D5288", VA = "0x12D5288")]
			get
			{
				return null;
			}
			[Token(Token = "0x60000AB")]
			[Address(RVA = "0x12D5290", Offset = "0x12D5290", VA = "0x12D5290")]
			set
			{
			}
		}

		[Token(Token = "0x1700001C")]
		[Attribute(Name = "AWSPropertyAttribute", RVA = "0x30F58", Offset = "0x30F58")]
		public List<string> TransitiveTagKeys
		{
			[Token(Token = "0x60000AD")]
			[Address(RVA = "0x12D52A8", Offset = "0x12D52A8", VA = "0x12D52A8")]
			get
			{
				return null;
			}
			[Token(Token = "0x60000AE")]
			[Address(RVA = "0x12D52B0", Offset = "0x12D52B0", VA = "0x12D52B0")]
			set
			{
			}
		}

		[Token(Token = "0x6000094")]
		[Address(RVA = "0x12D50D8", Offset = "0x12D50D8", VA = "0x12D50D8")]
		internal bool IsSetDurationSeconds()
		{
			return default;
		}

		[Token(Token = "0x6000097")]
		[Address(RVA = "0x12D5128", Offset = "0x12D5128", VA = "0x12D5128")]
		internal bool IsSetExternalId()
		{
			return default;
		}

		[Token(Token = "0x600009A")]
		[Address(RVA = "0x12D5148", Offset = "0x12D5148", VA = "0x12D5148")]
		internal bool IsSetPolicy()
		{
			return default;
		}

		[Token(Token = "0x600009D")]
		[Address(RVA = "0x12D5168", Offset = "0x12D5168", VA = "0x12D5168")]
		internal bool IsSetPolicyArns()
		{
			return default;
		}

		[Token(Token = "0x60000A0")]
		[Address(RVA = "0x12D51D0", Offset = "0x12D51D0", VA = "0x12D51D0")]
		internal bool IsSetRoleArn()
		{
			return default;
		}

		[Token(Token = "0x60000A3")]
		[Address(RVA = "0x12D51F0", Offset = "0x12D51F0", VA = "0x12D51F0")]
		internal bool IsSetRoleSessionName()
		{
			return default;
		}

		[Token(Token = "0x60000A6")]
		[Address(RVA = "0x12D5210", Offset = "0x12D5210", VA = "0x12D5210")]
		internal bool IsSetSerialNumber()
		{
			return default;
		}

		[Token(Token = "0x60000A9")]
		[Address(RVA = "0x12D5230", Offset = "0x12D5230", VA = "0x12D5230")]
		internal bool IsSetTags()
		{
			return default;
		}

		[Token(Token = "0x60000AC")]
		[Address(RVA = "0x12D5298", Offset = "0x12D5298", VA = "0x12D5298")]
		internal bool IsSetTokenCode()
		{
			return default;
		}

		[Token(Token = "0x60000AF")]
		[Address(RVA = "0x12D52B8", Offset = "0x12D52B8", VA = "0x12D52B8")]
		internal bool IsSetTransitiveTagKeys()
		{
			return default;
		}

		[Token(Token = "0x60000B0")]
		[Address(RVA = "0x12D1CE8", Offset = "0x12D1CE8", VA = "0x12D1CE8")]
		public AssumeRoleRequest()
		{
		}
	}
}
