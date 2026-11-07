using System;
using Il2CppDummyDll;

namespace Amazon.Kinesis.Model
{
	[Token(Token = "0x2000039")]
	public class ListStreamConsumersRequest : AmazonKinesisRequest
	{
		[Token(Token = "0x400005C")]
		[FieldOffset(Offset = "0x2C")]
		private int? _maxResults;

		[Token(Token = "0x400005D")]
		[FieldOffset(Offset = "0x38")]
		private string _nextToken;

		[Token(Token = "0x400005E")]
		[FieldOffset(Offset = "0x40")]
		private string _streamARN;

		[Token(Token = "0x400005F")]
		[FieldOffset(Offset = "0x48")]
		private DateTime? _streamCreationTimestamp;

		[Token(Token = "0x17000046")]
		[AttributeAttribute(Name = "AWSPropertyAttribute", RVA = "0x2F458", Offset = "0x2F458")]
		public int MaxResults
		{
			[Token(Token = "0x60001A4")]
			[Address(RVA = "0x12B80C0", Offset = "0x12B80C0", VA = "0x12B80C0")]
			get
			{
				return default;
			}
			[Token(Token = "0x60001A5")]
			[Address(RVA = "0x12B8100", Offset = "0x12B8100", VA = "0x12B8100")]
			set
			{
			}
		}

		[Token(Token = "0x17000047")]
		[AttributeAttribute(Name = "AWSPropertyAttribute", RVA = "0x2F4A0", Offset = "0x2F4A0")]
		public string NextToken
		{
			[Token(Token = "0x60001A7")]
			[Address(RVA = "0x12B81B4", Offset = "0x12B81B4", VA = "0x12B81B4")]
			get
			{
				return null;
			}
			[Token(Token = "0x60001A8")]
			[Address(RVA = "0x12B81BC", Offset = "0x12B81BC", VA = "0x12B81BC")]
			set
			{
			}
		}

		[Token(Token = "0x17000048")]
		[AttributeAttribute(Name = "AWSPropertyAttribute", RVA = "0x2F4E8", Offset = "0x2F4E8")]
		public string StreamARN
		{
			[Token(Token = "0x60001AA")]
			[Address(RVA = "0x12B81D4", Offset = "0x12B81D4", VA = "0x12B81D4")]
			get
			{
				return null;
			}
			[Token(Token = "0x60001AB")]
			[Address(RVA = "0x12B81DC", Offset = "0x12B81DC", VA = "0x12B81DC")]
			set
			{
			}
		}

		[Token(Token = "0x17000049")]
		public DateTime StreamCreationTimestamp
		{
			[Token(Token = "0x60001AD")]
			[Address(RVA = "0x12B81F4", Offset = "0x12B81F4", VA = "0x12B81F4")]
			get
			{
				return default;
			}
			[Token(Token = "0x60001AE")]
			[Address(RVA = "0x12B8234", Offset = "0x12B8234", VA = "0x12B8234")]
			set
			{
			}
		}

		[Token(Token = "0x60001A6")]
		[Address(RVA = "0x12B8174", Offset = "0x12B8174", VA = "0x12B8174")]
		internal bool IsSetMaxResults()
		{
			return default;
		}

		[Token(Token = "0x60001A9")]
		[Address(RVA = "0x12B81C4", Offset = "0x12B81C4", VA = "0x12B81C4")]
		internal bool IsSetNextToken()
		{
			return default;
		}

		[Token(Token = "0x60001AC")]
		[Address(RVA = "0x12B81E4", Offset = "0x12B81E4", VA = "0x12B81E4")]
		internal bool IsSetStreamARN()
		{
			return default;
		}

		[Token(Token = "0x60001AF")]
		[Address(RVA = "0x12B82A8", Offset = "0x12B82A8", VA = "0x12B82A8")]
		internal bool IsSetStreamCreationTimestamp()
		{
			return default;
		}

		[Token(Token = "0x60001B0")]
		[Address(RVA = "0x12B82E8", Offset = "0x12B82E8", VA = "0x12B82E8")]
		public ListStreamConsumersRequest()
		{
		}
	}
}
