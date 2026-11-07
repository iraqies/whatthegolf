using System.Collections.Generic;
using Amazon.Runtime;
using Il2CppDummyDll;

namespace Amazon.CognitoSync.Model
{
	[Token(Token = "0x200002B")]
	public class ListIdentityPoolUsageResponse : AmazonWebServiceResponse
	{
		[Token(Token = "0x4000047")]
		[FieldOffset(Offset = "0x24")]
		private int? _count;

		[Token(Token = "0x4000048")]
		[FieldOffset(Offset = "0x30")]
		private List<IdentityPoolUsage> _identityPoolUsages;

		[Token(Token = "0x4000049")]
		[FieldOffset(Offset = "0x38")]
		private int? _maxResults;

		[Token(Token = "0x400004A")]
		[FieldOffset(Offset = "0x40")]
		private string _nextToken;

		[Token(Token = "0x1700003C")]
		public int Count
		{
			[Token(Token = "0x600014E")]
			[Address(RVA = "0x11A04E0", Offset = "0x11A04E0", VA = "0x11A04E0")]
			get
			{
				return default;
			}
			[Token(Token = "0x600014F")]
			[Address(RVA = "0x11A0520", Offset = "0x11A0520", VA = "0x11A0520")]
			set
			{
			}
		}

		[Token(Token = "0x1700003D")]
		public List<IdentityPoolUsage> IdentityPoolUsages
		{
			[Token(Token = "0x6000151")]
			[Address(RVA = "0x11A05D4", Offset = "0x11A05D4", VA = "0x11A05D4")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000152")]
			[Address(RVA = "0x11A05DC", Offset = "0x11A05DC", VA = "0x11A05DC")]
			set
			{
			}
		}

		[Token(Token = "0x1700003E")]
		public int MaxResults
		{
			[Token(Token = "0x6000154")]
			[Address(RVA = "0x11A063C", Offset = "0x11A063C", VA = "0x11A063C")]
			get
			{
				return default;
			}
			[Token(Token = "0x6000155")]
			[Address(RVA = "0x11A067C", Offset = "0x11A067C", VA = "0x11A067C")]
			set
			{
			}
		}

		[Token(Token = "0x1700003F")]
		public string NextToken
		{
			[Token(Token = "0x6000157")]
			[Address(RVA = "0x11A0730", Offset = "0x11A0730", VA = "0x11A0730")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000158")]
			[Address(RVA = "0x11A0738", Offset = "0x11A0738", VA = "0x11A0738")]
			set
			{
			}
		}

		[Token(Token = "0x6000150")]
		[Address(RVA = "0x11A0594", Offset = "0x11A0594", VA = "0x11A0594")]
		internal bool IsSetCount()
		{
			return default;
		}

		[Token(Token = "0x6000153")]
		[Address(RVA = "0x11A05E4", Offset = "0x11A05E4", VA = "0x11A05E4")]
		internal bool IsSetIdentityPoolUsages()
		{
			return default;
		}

		[Token(Token = "0x6000156")]
		[Address(RVA = "0x11A06F0", Offset = "0x11A06F0", VA = "0x11A06F0")]
		internal bool IsSetMaxResults()
		{
			return default;
		}

		[Token(Token = "0x6000159")]
		[Address(RVA = "0x11A0740", Offset = "0x11A0740", VA = "0x11A0740")]
		internal bool IsSetNextToken()
		{
			return default;
		}

		[Token(Token = "0x600015A")]
		[Address(RVA = "0x11A0750", Offset = "0x11A0750", VA = "0x11A0750")]
		public ListIdentityPoolUsageResponse()
		{
		}
	}
}
