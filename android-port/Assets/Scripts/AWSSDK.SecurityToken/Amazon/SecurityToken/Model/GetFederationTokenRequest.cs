using System.Collections.Generic;
using Il2CppDummyDll;

namespace Amazon.SecurityToken.Model
{
	[Token(Token = "0x2000025")]
	public class GetFederationTokenRequest : AmazonSecurityTokenServiceRequest
	{
		[Token(Token = "0x4000059")]
		[FieldOffset(Offset = "0x2C")]
		private int? _durationSeconds;

		[Token(Token = "0x400005A")]
		[FieldOffset(Offset = "0x38")]
		private string _name;

		[Token(Token = "0x400005B")]
		[FieldOffset(Offset = "0x40")]
		private string _policy;

		[Token(Token = "0x400005C")]
		[FieldOffset(Offset = "0x48")]
		private List<PolicyDescriptorType> _policyArns;

		[Token(Token = "0x400005D")]
		[FieldOffset(Offset = "0x50")]
		private List<Tag> _tags;

		[Token(Token = "0x17000044")]
		[Attribute(Name = "AWSPropertyAttribute", RVA = "0x31554", Offset = "0x31554")]
		public int DurationSeconds
		{
			[Token(Token = "0x600013A")]
			[Address(RVA = "0x12E0790", Offset = "0x12E0790", VA = "0x12E0790")]
			get
			{
				return default;
			}
			[Token(Token = "0x600013B")]
			[Address(RVA = "0x12E07D0", Offset = "0x12E07D0", VA = "0x12E07D0")]
			set
			{
			}
		}

		[Token(Token = "0x17000045")]
		[Attribute(Name = "AWSPropertyAttribute", RVA = "0x315A0", Offset = "0x315A0")]
		public string Name
		{
			[Token(Token = "0x600013D")]
			[Address(RVA = "0x12E0884", Offset = "0x12E0884", VA = "0x12E0884")]
			get
			{
				return null;
			}
			[Token(Token = "0x600013E")]
			[Address(RVA = "0x12E088C", Offset = "0x12E088C", VA = "0x12E088C")]
			set
			{
			}
		}

		[Token(Token = "0x17000046")]
		[Attribute(Name = "AWSPropertyAttribute", RVA = "0x315F0", Offset = "0x315F0")]
		public string Policy
		{
			[Token(Token = "0x6000140")]
			[Address(RVA = "0x12E08A4", Offset = "0x12E08A4", VA = "0x12E08A4")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000141")]
			[Address(RVA = "0x12E08AC", Offset = "0x12E08AC", VA = "0x12E08AC")]
			set
			{
			}
		}

		[Token(Token = "0x17000047")]
		public List<PolicyDescriptorType> PolicyArns
		{
			[Token(Token = "0x6000143")]
			[Address(RVA = "0x12E08C4", Offset = "0x12E08C4", VA = "0x12E08C4")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000144")]
			[Address(RVA = "0x12E08CC", Offset = "0x12E08CC", VA = "0x12E08CC")]
			set
			{
			}
		}

		[Token(Token = "0x17000048")]
		[Attribute(Name = "AWSPropertyAttribute", RVA = "0x31638", Offset = "0x31638")]
		public List<Tag> Tags
		{
			[Token(Token = "0x6000146")]
			[Address(RVA = "0x12E092C", Offset = "0x12E092C", VA = "0x12E092C")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000147")]
			[Address(RVA = "0x12E0934", Offset = "0x12E0934", VA = "0x12E0934")]
			set
			{
			}
		}

		[Token(Token = "0x6000138")]
		[Address(RVA = "0x12E05EC", Offset = "0x12E05EC", VA = "0x12E05EC")]
		public GetFederationTokenRequest()
		{
		}

		[Token(Token = "0x6000139")]
		[Address(RVA = "0x12E06B4", Offset = "0x12E06B4", VA = "0x12E06B4")]
		public GetFederationTokenRequest(string name)
		{
		}

		[Token(Token = "0x600013C")]
		[Address(RVA = "0x12E0844", Offset = "0x12E0844", VA = "0x12E0844")]
		internal bool IsSetDurationSeconds()
		{
			return default;
		}

		[Token(Token = "0x600013F")]
		[Address(RVA = "0x12E0894", Offset = "0x12E0894", VA = "0x12E0894")]
		internal bool IsSetName()
		{
			return default;
		}

		[Token(Token = "0x6000142")]
		[Address(RVA = "0x12E08B4", Offset = "0x12E08B4", VA = "0x12E08B4")]
		internal bool IsSetPolicy()
		{
			return default;
		}

		[Token(Token = "0x6000145")]
		[Address(RVA = "0x12E08D4", Offset = "0x12E08D4", VA = "0x12E08D4")]
		internal bool IsSetPolicyArns()
		{
			return default;
		}

		[Token(Token = "0x6000148")]
		[Address(RVA = "0x12E093C", Offset = "0x12E093C", VA = "0x12E093C")]
		internal bool IsSetTags()
		{
			return default;
		}
	}
}
