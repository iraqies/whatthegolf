using System.Collections.Generic;
using Il2CppDummyDll;

namespace Amazon.Kinesis.Model
{
	[Token(Token = "0x2000044")]
	public class PutRecordsRequest : AmazonKinesisRequest
	{
		[Token(Token = "0x4000076")]
		[FieldOffset(Offset = "0x30")]
		private List<PutRecordsRequestEntry> _records;

		[Token(Token = "0x4000077")]
		[FieldOffset(Offset = "0x38")]
		private string _streamName;

		[Token(Token = "0x17000060")]
		[Attribute(Name = "AWSPropertyAttribute", RVA = "0x2FA30", Offset = "0x2FA30")]
		public List<PutRecordsRequestEntry> Records
		{
			[Token(Token = "0x6000201")]
			[Address(RVA = "0x12C01D4", Offset = "0x12C01D4", VA = "0x12C01D4")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000202")]
			[Address(RVA = "0x12C01DC", Offset = "0x12C01DC", VA = "0x12C01DC")]
			set
			{
			}
		}

		[Token(Token = "0x17000061")]
		[Attribute(Name = "AWSPropertyAttribute", RVA = "0x2FA80", Offset = "0x2FA80")]
		public string StreamName
		{
			[Token(Token = "0x6000204")]
			[Address(RVA = "0x12C023C", Offset = "0x12C023C", VA = "0x12C023C")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000205")]
			[Address(RVA = "0x12C0244", Offset = "0x12C0244", VA = "0x12C0244")]
			set
			{
			}
		}

		[Token(Token = "0x6000203")]
		[Address(RVA = "0x12C01E4", Offset = "0x12C01E4", VA = "0x12C01E4")]
		internal bool IsSetRecords()
		{
			return default;
		}

		[Token(Token = "0x6000206")]
		[Address(RVA = "0x12C024C", Offset = "0x12C024C", VA = "0x12C024C")]
		internal bool IsSetStreamName()
		{
			return default;
		}

		[Token(Token = "0x6000207")]
		[Address(RVA = "0x12C025C", Offset = "0x12C025C", VA = "0x12C025C")]
		public PutRecordsRequest()
		{
		}
	}
}
