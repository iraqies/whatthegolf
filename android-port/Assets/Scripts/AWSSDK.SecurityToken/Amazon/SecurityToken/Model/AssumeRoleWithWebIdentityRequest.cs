using System.Collections.Generic;
using Il2CppDummyDll;

namespace Amazon.SecurityToken.Model
{
	[Token(Token = "0x200001B")]
	public class AssumeRoleWithWebIdentityRequest : AmazonSecurityTokenServiceRequest
	{
		[Token(Token = "0x4000043")]
		[FieldOffset(Offset = "0x2C")]
		private int? _durationSeconds;

		[Token(Token = "0x4000044")]
		[FieldOffset(Offset = "0x38")]
		private string _policy;

		[Token(Token = "0x4000045")]
		[FieldOffset(Offset = "0x40")]
		private List<PolicyDescriptorType> _policyArns;

		[Token(Token = "0x4000046")]
		[FieldOffset(Offset = "0x48")]
		private string _providerId;

		[Token(Token = "0x4000047")]
		[FieldOffset(Offset = "0x50")]
		private string _roleArn;

		[Token(Token = "0x4000048")]
		[FieldOffset(Offset = "0x58")]
		private string _roleSessionName;

		[Token(Token = "0x4000049")]
		[FieldOffset(Offset = "0x60")]
		private string _webIdentityToken;

		[Token(Token = "0x1700002E")]
		[Attribute(Name = "AWSPropertyAttribute", RVA = "0x31184", Offset = "0x31184")]
		public int DurationSeconds
		{
			[Token(Token = "0x60000E7")]
			[Address(RVA = "0x12DAAD0", Offset = "0x12DAAD0", VA = "0x12DAAD0")]
			get
			{
				return default;
			}
			[Token(Token = "0x60000E8")]
			[Address(RVA = "0x12D145C", Offset = "0x12D145C", VA = "0x12D145C")]
			set
			{
			}
		}

		[Token(Token = "0x1700002F")]
		[Attribute(Name = "AWSPropertyAttribute", RVA = "0x311CC", Offset = "0x311CC")]
		public string Policy
		{
			[Token(Token = "0x60000EA")]
			[Address(RVA = "0x12DAB50", Offset = "0x12DAB50", VA = "0x12DAB50")]
			get
			{
				return null;
			}
			[Token(Token = "0x60000EB")]
			[Address(RVA = "0x12DAB58", Offset = "0x12DAB58", VA = "0x12DAB58")]
			set
			{
			}
		}

		[Token(Token = "0x17000030")]
		public List<PolicyDescriptorType> PolicyArns
		{
			[Token(Token = "0x60000ED")]
			[Address(RVA = "0x12DAB70", Offset = "0x12DAB70", VA = "0x12DAB70")]
			get
			{
				return null;
			}
			[Token(Token = "0x60000EE")]
			[Address(RVA = "0x12DAB78", Offset = "0x12DAB78", VA = "0x12DAB78")]
			set
			{
			}
		}

		[Token(Token = "0x17000031")]
		[Attribute(Name = "AWSPropertyAttribute", RVA = "0x31214", Offset = "0x31214")]
		public string ProviderId
		{
			[Token(Token = "0x60000F0")]
			[Address(RVA = "0x12DABD8", Offset = "0x12DABD8", VA = "0x12DABD8")]
			get
			{
				return null;
			}
			[Token(Token = "0x60000F1")]
			[Address(RVA = "0x12DABE0", Offset = "0x12DABE0", VA = "0x12DABE0")]
			set
			{
			}
		}

		[Token(Token = "0x17000032")]
		[Attribute(Name = "AWSPropertyAttribute", RVA = "0x3125C", Offset = "0x3125C")]
		public string RoleArn
		{
			[Token(Token = "0x60000F3")]
			[Address(RVA = "0x12DABF8", Offset = "0x12DABF8", VA = "0x12DABF8")]
			get
			{
				return null;
			}
			[Token(Token = "0x60000F4")]
			[Address(RVA = "0x12DAC00", Offset = "0x12DAC00", VA = "0x12DAC00")]
			set
			{
			}
		}

		[Token(Token = "0x17000033")]
		[Attribute(Name = "AWSPropertyAttribute", RVA = "0x312AC", Offset = "0x312AC")]
		public string RoleSessionName
		{
			[Token(Token = "0x60000F6")]
			[Address(RVA = "0x12DAC18", Offset = "0x12DAC18", VA = "0x12DAC18")]
			get
			{
				return null;
			}
			[Token(Token = "0x60000F7")]
			[Address(RVA = "0x12DAC20", Offset = "0x12DAC20", VA = "0x12DAC20")]
			set
			{
			}
		}

		[Token(Token = "0x17000034")]
		[Attribute(Name = "AWSPropertyAttribute", RVA = "0x312FC", Offset = "0x312FC")]
		public string WebIdentityToken
		{
			[Token(Token = "0x60000F9")]
			[Address(RVA = "0x12DAC38", Offset = "0x12DAC38", VA = "0x12DAC38")]
			get
			{
				return null;
			}
			[Token(Token = "0x60000FA")]
			[Address(RVA = "0x12DAC40", Offset = "0x12DAC40", VA = "0x12DAC40")]
			set
			{
			}
		}

		[Token(Token = "0x60000E9")]
		[Address(RVA = "0x12DAB10", Offset = "0x12DAB10", VA = "0x12DAB10")]
		internal bool IsSetDurationSeconds()
		{
			return default;
		}

		[Token(Token = "0x60000EC")]
		[Address(RVA = "0x12DAB60", Offset = "0x12DAB60", VA = "0x12DAB60")]
		internal bool IsSetPolicy()
		{
			return default;
		}

		[Token(Token = "0x60000EF")]
		[Address(RVA = "0x12DAB80", Offset = "0x12DAB80", VA = "0x12DAB80")]
		internal bool IsSetPolicyArns()
		{
			return default;
		}

		[Token(Token = "0x60000F2")]
		[Address(RVA = "0x12DABE8", Offset = "0x12DABE8", VA = "0x12DABE8")]
		internal bool IsSetProviderId()
		{
			return default;
		}

		[Token(Token = "0x60000F5")]
		[Address(RVA = "0x12DAC08", Offset = "0x12DAC08", VA = "0x12DAC08")]
		internal bool IsSetRoleArn()
		{
			return default;
		}

		[Token(Token = "0x60000F8")]
		[Address(RVA = "0x12DAC28", Offset = "0x12DAC28", VA = "0x12DAC28")]
		internal bool IsSetRoleSessionName()
		{
			return default;
		}

		[Token(Token = "0x60000FB")]
		[Address(RVA = "0x12DAC48", Offset = "0x12DAC48", VA = "0x12DAC48")]
		internal bool IsSetWebIdentityToken()
		{
			return default;
		}

		[Token(Token = "0x60000FC")]
		[Address(RVA = "0x12D13DC", Offset = "0x12D13DC", VA = "0x12D13DC")]
		public AssumeRoleWithWebIdentityRequest()
		{
		}
	}
}
