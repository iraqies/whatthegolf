using System.Collections.Generic;
using Il2CppDummyDll;

namespace Amazon.CognitoIdentity.Model
{
	[Token(Token = "0x2000048")]
	public class RulesConfigurationType
	{
		[Token(Token = "0x40000BB")]
		[FieldOffset(Offset = "0x10")]
		private List<MappingRule> _rules;

		[Token(Token = "0x17000082")]
		[Attribute(Name = "AWSPropertyAttribute", RVA = "0x237F4", Offset = "0x237F4")]
		public List<MappingRule> Rules
		{
			[Token(Token = "0x600026A")]
			[Address(RVA = "0x10974FC", Offset = "0x10974FC", VA = "0x10974FC")]
			get
			{
				return null;
			}
			[Token(Token = "0x600026B")]
			[Address(RVA = "0x1097504", Offset = "0x1097504", VA = "0x1097504")]
			set
			{
			}
		}

		[Token(Token = "0x600026C")]
		[Address(RVA = "0x109750C", Offset = "0x109750C", VA = "0x109750C")]
		internal bool IsSetRules()
		{
			return default;
		}

		[Token(Token = "0x600026D")]
		[Address(RVA = "0x1097564", Offset = "0x1097564", VA = "0x1097564")]
		public RulesConfigurationType()
		{
		}
	}
}
