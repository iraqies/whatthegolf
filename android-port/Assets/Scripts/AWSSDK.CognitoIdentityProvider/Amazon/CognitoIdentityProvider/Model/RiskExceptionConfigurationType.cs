using System.Collections.Generic;
using Il2CppDummyDll;

namespace Amazon.CognitoIdentityProvider.Model
{
	[Token(Token = "0x2000106")]
	public class RiskExceptionConfigurationType
	{
		[Token(Token = "0x400027D")]
		[FieldOffset(Offset = "0x10")]
		private List<string> _blockedIPRangeList;

		[Token(Token = "0x400027E")]
		[FieldOffset(Offset = "0x18")]
		private List<string> _skippedIPRangeList;

		[Token(Token = "0x1700020A")]
		[Attribute(Name = "AWSPropertyAttribute", RVA = "0x20168", Offset = "0x20168")]
		public List<string> BlockedIPRangeList
		{
			[Token(Token = "0x6000921")]
			[Address(RVA = "0x1149724", Offset = "0x1149724", VA = "0x1149724")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000922")]
			[Address(RVA = "0x114972C", Offset = "0x114972C", VA = "0x114972C")]
			set
			{
			}
		}

		[Token(Token = "0x1700020B")]
		[Attribute(Name = "AWSPropertyAttribute", RVA = "0x201A0", Offset = "0x201A0")]
		public List<string> SkippedIPRangeList
		{
			[Token(Token = "0x6000924")]
			[Address(RVA = "0x114978C", Offset = "0x114978C", VA = "0x114978C")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000925")]
			[Address(RVA = "0x1149794", Offset = "0x1149794", VA = "0x1149794")]
			set
			{
			}
		}

		[Token(Token = "0x6000923")]
		[Address(RVA = "0x1149734", Offset = "0x1149734", VA = "0x1149734")]
		internal bool IsSetBlockedIPRangeList()
		{
			return default;
		}

		[Token(Token = "0x6000926")]
		[Address(RVA = "0x114979C", Offset = "0x114979C", VA = "0x114979C")]
		internal bool IsSetSkippedIPRangeList()
		{
			return default;
		}

		[Token(Token = "0x6000927")]
		[Address(RVA = "0x11497F4", Offset = "0x11497F4", VA = "0x11497F4")]
		public RiskExceptionConfigurationType()
		{
		}
	}
}
