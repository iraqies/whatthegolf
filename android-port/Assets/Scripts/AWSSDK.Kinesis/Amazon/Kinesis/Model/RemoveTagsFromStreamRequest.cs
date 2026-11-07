using System.Collections.Generic;
using Il2CppDummyDll;

namespace Amazon.Kinesis.Model
{
	[Token(Token = "0x200004B")]
	public class RemoveTagsFromStreamRequest : AmazonKinesisRequest
	{
		[Token(Token = "0x400008A")]
		[FieldOffset(Offset = "0x30")]
		private string _streamName;

		[Token(Token = "0x400008B")]
		[FieldOffset(Offset = "0x38")]
		private List<string> _tagKeys;

		[Token(Token = "0x17000074")]
		[Attribute(Name = "AWSPropertyAttribute", RVA = "0x2FDFC", Offset = "0x2FDFC")]
		public string StreamName
		{
			[Token(Token = "0x6000244")]
			[Address(RVA = "0x12C454C", Offset = "0x12C454C", VA = "0x12C454C")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000245")]
			[Address(RVA = "0x12C4554", Offset = "0x12C4554", VA = "0x12C4554")]
			set
			{
			}
		}

		[Token(Token = "0x17000075")]
		[Attribute(Name = "AWSPropertyAttribute", RVA = "0x2FE4C", Offset = "0x2FE4C")]
		public List<string> TagKeys
		{
			[Token(Token = "0x6000247")]
			[Address(RVA = "0x12C456C", Offset = "0x12C456C", VA = "0x12C456C")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000248")]
			[Address(RVA = "0x12C4574", Offset = "0x12C4574", VA = "0x12C4574")]
			set
			{
			}
		}

		[Token(Token = "0x6000246")]
		[Address(RVA = "0x12C455C", Offset = "0x12C455C", VA = "0x12C455C")]
		internal bool IsSetStreamName()
		{
			return default;
		}

		[Token(Token = "0x6000249")]
		[Address(RVA = "0x12C457C", Offset = "0x12C457C", VA = "0x12C457C")]
		internal bool IsSetTagKeys()
		{
			return default;
		}

		[Token(Token = "0x600024A")]
		[Address(RVA = "0x12C45D4", Offset = "0x12C45D4", VA = "0x12C45D4")]
		public RemoveTagsFromStreamRequest()
		{
		}
	}
}
