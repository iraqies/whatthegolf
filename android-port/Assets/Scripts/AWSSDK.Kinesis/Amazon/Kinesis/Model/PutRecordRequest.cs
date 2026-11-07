using System.IO;
using Il2CppDummyDll;

namespace Amazon.Kinesis.Model
{
	[Token(Token = "0x2000042")]
	public class PutRecordRequest : AmazonKinesisRequest
	{
		[Token(Token = "0x400006E")]
		[FieldOffset(Offset = "0x30")]
		private MemoryStream _data;

		[Token(Token = "0x400006F")]
		[FieldOffset(Offset = "0x38")]
		private string _explicitHashKey;

		[Token(Token = "0x4000070")]
		[FieldOffset(Offset = "0x40")]
		private string _partitionKey;

		[Token(Token = "0x4000071")]
		[FieldOffset(Offset = "0x48")]
		private string _sequenceNumberForOrdering;

		[Token(Token = "0x4000072")]
		[FieldOffset(Offset = "0x50")]
		private string _streamName;

		[Token(Token = "0x17000058")]
		[Attribute(Name = "AWSPropertyAttribute", RVA = "0x2F8BC", Offset = "0x2F8BC")]
		public MemoryStream Data
		{
			[Token(Token = "0x60001E7")]
			[Address(RVA = "0x12BE58C", Offset = "0x12BE58C", VA = "0x12BE58C")]
			get
			{
				return null;
			}
			[Token(Token = "0x60001E8")]
			[Address(RVA = "0x12BE594", Offset = "0x12BE594", VA = "0x12BE594")]
			set
			{
			}
		}

		[Token(Token = "0x17000059")]
		public string ExplicitHashKey
		{
			[Token(Token = "0x60001EA")]
			[Address(RVA = "0x12BE5AC", Offset = "0x12BE5AC", VA = "0x12BE5AC")]
			get
			{
				return null;
			}
			[Token(Token = "0x60001EB")]
			[Address(RVA = "0x12BE5B4", Offset = "0x12BE5B4", VA = "0x12BE5B4")]
			set
			{
			}
		}

		[Token(Token = "0x1700005A")]
		[Attribute(Name = "AWSPropertyAttribute", RVA = "0x2F90C", Offset = "0x2F90C")]
		public string PartitionKey
		{
			[Token(Token = "0x60001ED")]
			[Address(RVA = "0x12BE5CC", Offset = "0x12BE5CC", VA = "0x12BE5CC")]
			get
			{
				return null;
			}
			[Token(Token = "0x60001EE")]
			[Address(RVA = "0x12BE5D4", Offset = "0x12BE5D4", VA = "0x12BE5D4")]
			set
			{
			}
		}

		[Token(Token = "0x1700005B")]
		public string SequenceNumberForOrdering
		{
			[Token(Token = "0x60001F0")]
			[Address(RVA = "0x12BE5EC", Offset = "0x12BE5EC", VA = "0x12BE5EC")]
			get
			{
				return null;
			}
			[Token(Token = "0x60001F1")]
			[Address(RVA = "0x12BE5F4", Offset = "0x12BE5F4", VA = "0x12BE5F4")]
			set
			{
			}
		}

		[Token(Token = "0x1700005C")]
		[Attribute(Name = "AWSPropertyAttribute", RVA = "0x2F95C", Offset = "0x2F95C")]
		public string StreamName
		{
			[Token(Token = "0x60001F3")]
			[Address(RVA = "0x12BE60C", Offset = "0x12BE60C", VA = "0x12BE60C")]
			get
			{
				return null;
			}
			[Token(Token = "0x60001F4")]
			[Address(RVA = "0x12BE614", Offset = "0x12BE614", VA = "0x12BE614")]
			set
			{
			}
		}

		[Token(Token = "0x60001E9")]
		[Address(RVA = "0x12BE59C", Offset = "0x12BE59C", VA = "0x12BE59C")]
		internal bool IsSetData()
		{
			return default;
		}

		[Token(Token = "0x60001EC")]
		[Address(RVA = "0x12BE5BC", Offset = "0x12BE5BC", VA = "0x12BE5BC")]
		internal bool IsSetExplicitHashKey()
		{
			return default;
		}

		[Token(Token = "0x60001EF")]
		[Address(RVA = "0x12BE5DC", Offset = "0x12BE5DC", VA = "0x12BE5DC")]
		internal bool IsSetPartitionKey()
		{
			return default;
		}

		[Token(Token = "0x60001F2")]
		[Address(RVA = "0x12BE5FC", Offset = "0x12BE5FC", VA = "0x12BE5FC")]
		internal bool IsSetSequenceNumberForOrdering()
		{
			return default;
		}

		[Token(Token = "0x60001F5")]
		[Address(RVA = "0x12BE61C", Offset = "0x12BE61C", VA = "0x12BE61C")]
		internal bool IsSetStreamName()
		{
			return default;
		}

		[Token(Token = "0x60001F6")]
		[Address(RVA = "0x12BE62C", Offset = "0x12BE62C", VA = "0x12BE62C")]
		public PutRecordRequest()
		{
		}
	}
}
