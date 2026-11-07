using System.Collections.Generic;
using Amazon.Runtime;
using Il2CppDummyDll;

namespace Amazon.Kinesis.Model
{
	[Token(Token = "0x2000029")]
	public class GetRecordsResponse : AmazonWebServiceResponse
	{
		[Token(Token = "0x4000048")]
		[FieldOffset(Offset = "0x28")]
		private long? _millisBehindLatest;

		[Token(Token = "0x4000049")]
		[FieldOffset(Offset = "0x38")]
		private string _nextShardIterator;

		[Token(Token = "0x400004A")]
		[FieldOffset(Offset = "0x40")]
		private List<Record> _records;

		[Token(Token = "0x17000032")]
		[Attribute(Name = "AWSPropertyAttribute", RVA = "0x2F018", Offset = "0x2F018")]
		public long MillisBehindLatest
		{
			[Token(Token = "0x6000138")]
			[Address(RVA = "0x12B11D8", Offset = "0x12B11D8", VA = "0x12B11D8")]
			get
			{
				return default;
			}
			[Token(Token = "0x6000139")]
			[Address(RVA = "0x12B1218", Offset = "0x12B1218", VA = "0x12B1218")]
			set
			{
			}
		}

		[Token(Token = "0x17000033")]
		[Attribute(Name = "AWSPropertyAttribute", RVA = "0x2F050", Offset = "0x2F050")]
		public string NextShardIterator
		{
			[Token(Token = "0x600013B")]
			[Address(RVA = "0x12B12CC", Offset = "0x12B12CC", VA = "0x12B12CC")]
			get
			{
				return null;
			}
			[Token(Token = "0x600013C")]
			[Address(RVA = "0x12B12D4", Offset = "0x12B12D4", VA = "0x12B12D4")]
			set
			{
			}
		}

		[Token(Token = "0x17000034")]
		[Attribute(Name = "AWSPropertyAttribute", RVA = "0x2F098", Offset = "0x2F098")]
		public List<Record> Records
		{
			[Token(Token = "0x600013E")]
			[Address(RVA = "0x12B12EC", Offset = "0x12B12EC", VA = "0x12B12EC")]
			get
			{
				return null;
			}
			[Token(Token = "0x600013F")]
			[Address(RVA = "0x12B12F4", Offset = "0x12B12F4", VA = "0x12B12F4")]
			set
			{
			}
		}

		[Token(Token = "0x600013A")]
		[Address(RVA = "0x12B128C", Offset = "0x12B128C", VA = "0x12B128C")]
		internal bool IsSetMillisBehindLatest()
		{
			return default;
		}

		[Token(Token = "0x600013D")]
		[Address(RVA = "0x12B12DC", Offset = "0x12B12DC", VA = "0x12B12DC")]
		internal bool IsSetNextShardIterator()
		{
			return default;
		}

		[Token(Token = "0x6000140")]
		[Address(RVA = "0x12B12FC", Offset = "0x12B12FC", VA = "0x12B12FC")]
		internal bool IsSetRecords()
		{
			return default;
		}

		[Token(Token = "0x6000141")]
		[Address(RVA = "0x12B1354", Offset = "0x12B1354", VA = "0x12B1354")]
		public GetRecordsResponse()
		{
		}
	}
}
