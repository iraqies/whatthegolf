using System.Collections.Generic;
using Il2CppDummyDll;

namespace Amazon.Kinesis.Model
{
	[Token(Token = "0x200000D")]
	public class AddTagsToStreamRequest : AmazonKinesisRequest
	{
		[Token(Token = "0x400001B")]
		[FieldOffset(Offset = "0x30")]
		private string _streamName;

		[Token(Token = "0x400001C")]
		[FieldOffset(Offset = "0x38")]
		private Dictionary<string, string> _tags;

		[Token(Token = "0x17000005")]
		[Attribute(Name = "AWSPropertyAttribute", RVA = "0x2E390", Offset = "0x2E390")]
		public string StreamName
		{
			[Token(Token = "0x600008D")]
			[Address(RVA = "0x1299F7C", Offset = "0x1299F7C", VA = "0x1299F7C")]
			get
			{
				return null;
			}
			[Token(Token = "0x600008E")]
			[Address(RVA = "0x1299F84", Offset = "0x1299F84", VA = "0x1299F84")]
			set
			{
			}
		}

		[Token(Token = "0x17000006")]
		[Attribute(Name = "AWSPropertyAttribute", RVA = "0x2E3E0", Offset = "0x2E3E0")]
		public Dictionary<string, string> Tags
		{
			[Token(Token = "0x6000090")]
			[Address(RVA = "0x1299F9C", Offset = "0x1299F9C", VA = "0x1299F9C")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000091")]
			[Address(RVA = "0x1299FA4", Offset = "0x1299FA4", VA = "0x1299FA4")]
			set
			{
			}
		}

		[Token(Token = "0x600008F")]
		[Address(RVA = "0x1299F8C", Offset = "0x1299F8C", VA = "0x1299F8C")]
		internal bool IsSetStreamName()
		{
			return default;
		}

		[Token(Token = "0x6000092")]
		[Address(RVA = "0x1299FAC", Offset = "0x1299FAC", VA = "0x1299FAC")]
		internal bool IsSetTags()
		{
			return default;
		}

		[Token(Token = "0x6000093")]
		[Address(RVA = "0x129A008", Offset = "0x129A008", VA = "0x129A008")]
		public AddTagsToStreamRequest()
		{
		}
	}
}
