using System.Collections.Generic;
using Amazon.Runtime;
using Il2CppDummyDll;

namespace Amazon.Kinesis.Model
{
	[Token(Token = "0x200003E")]
	public class ListTagsForStreamResponse : AmazonWebServiceResponse
	{
		[Token(Token = "0x4000069")]
		[FieldOffset(Offset = "0x24")]
		private bool? _hasMoreTags;

		[Token(Token = "0x400006A")]
		[FieldOffset(Offset = "0x28")]
		private List<Tag> _tags;

		[Token(Token = "0x17000053")]
		[Attribute(Name = "AWSPropertyAttribute", RVA = "0x2F758", Offset = "0x2F758")]
		public bool HasMoreTags
		{
			[Token(Token = "0x60001D0")]
			[Address(RVA = "0x12BBEC4", Offset = "0x12BBEC4", VA = "0x12BBEC4")]
			get
			{
				return default;
			}
			[Token(Token = "0x60001D1")]
			[Address(RVA = "0x12BBF04", Offset = "0x12BBF04", VA = "0x12BBF04")]
			set
			{
			}
		}

		[Token(Token = "0x17000054")]
		[Attribute(Name = "AWSPropertyAttribute", RVA = "0x2F78C", Offset = "0x2F78C")]
		public List<Tag> Tags
		{
			[Token(Token = "0x60001D3")]
			[Address(RVA = "0x12BBFB8", Offset = "0x12BBFB8", VA = "0x12BBFB8")]
			get
			{
				return null;
			}
			[Token(Token = "0x60001D4")]
			[Address(RVA = "0x12BBFC0", Offset = "0x12BBFC0", VA = "0x12BBFC0")]
			set
			{
			}
		}

		[Token(Token = "0x60001D2")]
		[Address(RVA = "0x12BBF78", Offset = "0x12BBF78", VA = "0x12BBF78")]
		internal bool IsSetHasMoreTags()
		{
			return default;
		}

		[Token(Token = "0x60001D5")]
		[Address(RVA = "0x12BBFC8", Offset = "0x12BBFC8", VA = "0x12BBFC8")]
		internal bool IsSetTags()
		{
			return default;
		}

		[Token(Token = "0x60001D6")]
		[Address(RVA = "0x12BC020", Offset = "0x12BC020", VA = "0x12BC020")]
		public ListTagsForStreamResponse()
		{
		}
	}
}
