using System.Collections.Generic;
using Amazon.Runtime;
using Il2CppDummyDll;

namespace Amazon.Kinesis.Model
{
	[Token(Token = "0x200003C")]
	public class ListStreamsResponse : AmazonWebServiceResponse
	{
		[Token(Token = "0x4000064")]
		[FieldOffset(Offset = "0x24")]
		private bool? _hasMoreStreams;

		[Token(Token = "0x4000065")]
		[FieldOffset(Offset = "0x28")]
		private List<string> _streamNames;

		[Token(Token = "0x1700004E")]
		[Attribute(Name = "AWSPropertyAttribute", RVA = "0x2F610", Offset = "0x2F610")]
		public bool HasMoreStreams
		{
			[Token(Token = "0x60001BF")]
			[Address(RVA = "0x12BA794", Offset = "0x12BA794", VA = "0x12BA794")]
			get
			{
				return default;
			}
			[Token(Token = "0x60001C0")]
			[Address(RVA = "0x12BA7D4", Offset = "0x12BA7D4", VA = "0x12BA7D4")]
			set
			{
			}
		}

		[Token(Token = "0x1700004F")]
		[Attribute(Name = "AWSPropertyAttribute", RVA = "0x2F644", Offset = "0x2F644")]
		public List<string> StreamNames
		{
			[Token(Token = "0x60001C2")]
			[Address(RVA = "0x12BA888", Offset = "0x12BA888", VA = "0x12BA888")]
			get
			{
				return null;
			}
			[Token(Token = "0x60001C3")]
			[Address(RVA = "0x12BA890", Offset = "0x12BA890", VA = "0x12BA890")]
			set
			{
			}
		}

		[Token(Token = "0x60001C1")]
		[Address(RVA = "0x12BA848", Offset = "0x12BA848", VA = "0x12BA848")]
		internal bool IsSetHasMoreStreams()
		{
			return default;
		}

		[Token(Token = "0x60001C4")]
		[Address(RVA = "0x12BA898", Offset = "0x12BA898", VA = "0x12BA898")]
		internal bool IsSetStreamNames()
		{
			return default;
		}

		[Token(Token = "0x60001C5")]
		[Address(RVA = "0x12BA8F0", Offset = "0x12BA8F0", VA = "0x12BA8F0")]
		public ListStreamsResponse()
		{
		}
	}
}
