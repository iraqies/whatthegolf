using System.Collections.Generic;
using Il2CppDummyDll;

namespace Amazon.SecurityToken.Model
{
	[Token(Token = "0x2000019")]
	public class AssumeRoleWithSAMLRequest : AmazonSecurityTokenServiceRequest
	{
		[Token(Token = "0x4000035")]
		[FieldOffset(Offset = "0x2C")]
		private int? _durationSeconds;

		[Token(Token = "0x4000036")]
		[FieldOffset(Offset = "0x38")]
		private string _policy;

		[Token(Token = "0x4000037")]
		[FieldOffset(Offset = "0x40")]
		private List<PolicyDescriptorType> _policyArns;

		[Token(Token = "0x4000038")]
		[FieldOffset(Offset = "0x48")]
		private string _principalArn;

		[Token(Token = "0x4000039")]
		[FieldOffset(Offset = "0x50")]
		private string _roleArn;

		[Token(Token = "0x400003A")]
		[FieldOffset(Offset = "0x58")]
		private string _samlAssertion;

		[Token(Token = "0x17000020")]
		[Attribute(Name = "AWSPropertyAttribute", RVA = "0x30FC8", Offset = "0x30FC8")]
		public int DurationSeconds
		{
			[Token(Token = "0x60000BB")]
			[Address(RVA = "0x12D8308", Offset = "0x12D8308", VA = "0x12D8308")]
			get
			{
				return default;
			}
			[Token(Token = "0x60000BC")]
			[Address(RVA = "0x12D8348", Offset = "0x12D8348", VA = "0x12D8348")]
			set
			{
			}
		}

		[Token(Token = "0x17000021")]
		[Attribute(Name = "AWSPropertyAttribute", RVA = "0x31010", Offset = "0x31010")]
		public string Policy
		{
			[Token(Token = "0x60000BE")]
			[Address(RVA = "0x12D83FC", Offset = "0x12D83FC", VA = "0x12D83FC")]
			get
			{
				return null;
			}
			[Token(Token = "0x60000BF")]
			[Address(RVA = "0x12D8404", Offset = "0x12D8404", VA = "0x12D8404")]
			set
			{
			}
		}

		[Token(Token = "0x17000022")]
		public List<PolicyDescriptorType> PolicyArns
		{
			[Token(Token = "0x60000C1")]
			[Address(RVA = "0x12D841C", Offset = "0x12D841C", VA = "0x12D841C")]
			get
			{
				return null;
			}
			[Token(Token = "0x60000C2")]
			[Address(RVA = "0x12D8424", Offset = "0x12D8424", VA = "0x12D8424")]
			set
			{
			}
		}

		[Token(Token = "0x17000023")]
		[Attribute(Name = "AWSPropertyAttribute", RVA = "0x31058", Offset = "0x31058")]
		public string PrincipalArn
		{
			[Token(Token = "0x60000C4")]
			[Address(RVA = "0x12D8484", Offset = "0x12D8484", VA = "0x12D8484")]
			get
			{
				return null;
			}
			[Token(Token = "0x60000C5")]
			[Address(RVA = "0x12D848C", Offset = "0x12D848C", VA = "0x12D848C")]
			set
			{
			}
		}

		[Token(Token = "0x17000024")]
		[Attribute(Name = "AWSPropertyAttribute", RVA = "0x310A8", Offset = "0x310A8")]
		public string RoleArn
		{
			[Token(Token = "0x60000C7")]
			[Address(RVA = "0x12D84A4", Offset = "0x12D84A4", VA = "0x12D84A4")]
			get
			{
				return null;
			}
			[Token(Token = "0x60000C8")]
			[Address(RVA = "0x12D84AC", Offset = "0x12D84AC", VA = "0x12D84AC")]
			set
			{
			}
		}

		[Token(Token = "0x17000025")]
		[Attribute(Name = "AWSPropertyAttribute", RVA = "0x310F8", Offset = "0x310F8")]
		public string SAMLAssertion
		{
			[Token(Token = "0x60000CA")]
			[Address(RVA = "0x12D84C4", Offset = "0x12D84C4", VA = "0x12D84C4")]
			get
			{
				return null;
			}
			[Token(Token = "0x60000CB")]
			[Address(RVA = "0x12D84CC", Offset = "0x12D84CC", VA = "0x12D84CC")]
			set
			{
			}
		}

		[Token(Token = "0x60000BD")]
		[Address(RVA = "0x12D83BC", Offset = "0x12D83BC", VA = "0x12D83BC")]
		internal bool IsSetDurationSeconds()
		{
			return default;
		}

		[Token(Token = "0x60000C0")]
		[Address(RVA = "0x12D840C", Offset = "0x12D840C", VA = "0x12D840C")]
		internal bool IsSetPolicy()
		{
			return default;
		}

		[Token(Token = "0x60000C3")]
		[Address(RVA = "0x12D842C", Offset = "0x12D842C", VA = "0x12D842C")]
		internal bool IsSetPolicyArns()
		{
			return default;
		}

		[Token(Token = "0x60000C6")]
		[Address(RVA = "0x12D8494", Offset = "0x12D8494", VA = "0x12D8494")]
		internal bool IsSetPrincipalArn()
		{
			return default;
		}

		[Token(Token = "0x60000C9")]
		[Address(RVA = "0x12D84B4", Offset = "0x12D84B4", VA = "0x12D84B4")]
		internal bool IsSetRoleArn()
		{
			return default;
		}

		[Token(Token = "0x60000CC")]
		[Address(RVA = "0x12D84D4", Offset = "0x12D84D4", VA = "0x12D84D4")]
		internal bool IsSetSAMLAssertion()
		{
			return default;
		}

		[Token(Token = "0x60000CD")]
		[Address(RVA = "0x12D84E4", Offset = "0x12D84E4", VA = "0x12D84E4")]
		public AssumeRoleWithSAMLRequest()
		{
		}
	}
}
