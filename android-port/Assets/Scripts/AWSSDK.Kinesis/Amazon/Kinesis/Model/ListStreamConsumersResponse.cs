using System.Collections.Generic;
using Amazon.Runtime;
using Il2CppDummyDll;

namespace Amazon.Kinesis.Model
{
	[Token(Token = "0x200003A")]
	public class ListStreamConsumersResponse : AmazonWebServiceResponse
	{
		[Token(Token = "0x4000060")]
		[FieldOffset(Offset = "0x28")]
		private List<Consumer> _consumers;

		[Token(Token = "0x4000061")]
		[FieldOffset(Offset = "0x30")]
		private string _nextToken;

		[Token(Token = "0x1700004A")]
		public List<Consumer> Consumers
		{
			[Token(Token = "0x60001B1")]
			[Address(RVA = "0x12B8F30", Offset = "0x12B8F30", VA = "0x12B8F30")]
			get
			{
				return null;
			}
			[Token(Token = "0x60001B2")]
			[Address(RVA = "0x12B8F38", Offset = "0x12B8F38", VA = "0x12B8F38")]
			set
			{
			}
		}

		[Token(Token = "0x1700004B")]
		[Attribute(Name = "AWSPropertyAttribute", RVA = "0x2F538", Offset = "0x2F538")]
		public string NextToken
		{
			[Token(Token = "0x60001B4")]
			[Address(RVA = "0x12B8F98", Offset = "0x12B8F98", VA = "0x12B8F98")]
			get
			{
				return null;
			}
			[Token(Token = "0x60001B5")]
			[Address(RVA = "0x12B8FA0", Offset = "0x12B8FA0", VA = "0x12B8FA0")]
			set
			{
			}
		}

		[Token(Token = "0x60001B3")]
		[Address(RVA = "0x12B8F40", Offset = "0x12B8F40", VA = "0x12B8F40")]
		internal bool IsSetConsumers()
		{
			return default;
		}

		[Token(Token = "0x60001B6")]
		[Address(RVA = "0x12B8FA8", Offset = "0x12B8FA8", VA = "0x12B8FA8")]
		internal bool IsSetNextToken()
		{
			return default;
		}

		[Token(Token = "0x60001B7")]
		[Address(RVA = "0x12B8FB8", Offset = "0x12B8FB8", VA = "0x12B8FB8")]
		public ListStreamConsumersResponse()
		{
		}
	}
}
