using System.Collections.Generic;
using Amazon.Runtime;
using Il2CppDummyDll;

namespace Amazon.CognitoSync.Model
{
	[Token(Token = "0x2000029")]
	public class ListDatasetsResponse : AmazonWebServiceResponse
	{
		[Token(Token = "0x4000042")]
		[FieldOffset(Offset = "0x24")]
		private int? _count;

		[Token(Token = "0x4000043")]
		[FieldOffset(Offset = "0x30")]
		private List<Dataset> _datasets;

		[Token(Token = "0x4000044")]
		[FieldOffset(Offset = "0x38")]
		private string _nextToken;

		[Token(Token = "0x17000037")]
		public int Count
		{
			[Token(Token = "0x600013D")]
			[Address(RVA = "0x119EDBC", Offset = "0x119EDBC", VA = "0x119EDBC")]
			get
			{
				return default;
			}
			[Token(Token = "0x600013E")]
			[Address(RVA = "0x119EDFC", Offset = "0x119EDFC", VA = "0x119EDFC")]
			set
			{
			}
		}

		[Token(Token = "0x17000038")]
		public List<Dataset> Datasets
		{
			[Token(Token = "0x6000140")]
			[Address(RVA = "0x119EEB0", Offset = "0x119EEB0", VA = "0x119EEB0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000141")]
			[Address(RVA = "0x119EEB8", Offset = "0x119EEB8", VA = "0x119EEB8")]
			set
			{
			}
		}

		[Token(Token = "0x17000039")]
		public string NextToken
		{
			[Token(Token = "0x6000143")]
			[Address(RVA = "0x119EF18", Offset = "0x119EF18", VA = "0x119EF18")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000144")]
			[Address(RVA = "0x119EF20", Offset = "0x119EF20", VA = "0x119EF20")]
			set
			{
			}
		}

		[Token(Token = "0x600013F")]
		[Address(RVA = "0x119EE70", Offset = "0x119EE70", VA = "0x119EE70")]
		internal bool IsSetCount()
		{
			return default;
		}

		[Token(Token = "0x6000142")]
		[Address(RVA = "0x119EEC0", Offset = "0x119EEC0", VA = "0x119EEC0")]
		internal bool IsSetDatasets()
		{
			return default;
		}

		[Token(Token = "0x6000145")]
		[Address(RVA = "0x119EF28", Offset = "0x119EF28", VA = "0x119EF28")]
		internal bool IsSetNextToken()
		{
			return default;
		}

		[Token(Token = "0x6000146")]
		[Address(RVA = "0x119EF38", Offset = "0x119EF38", VA = "0x119EF38")]
		public ListDatasetsResponse()
		{
		}
	}
}
