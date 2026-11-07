using System.Collections.Generic;
using Amazon.Runtime.Internal;
using Il2CppDummyDll;

namespace Amazon.Kinesis.Internal
{
	[Token(Token = "0x20000AB")]
	public class AmazonKinesisMetadata : IServiceMetadata
	{
		[Token(Token = "0x170000F0")]
		public string ServiceId
		{
			[Token(Token = "0x60004A6")]
			[Address(RVA = "0x12A1A70", Offset = "0x12A1A70", VA = "0x12A1A70", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000F1")]
		public IDictionary<string, string> OperationNameMapping
		{
			[Token(Token = "0x60004A7")]
			[Address(RVA = "0x12A1AB4", Offset = "0x12A1AB4", VA = "0x12A1AB4", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60004A8")]
		[Address(RVA = "0x12A18D0", Offset = "0x12A18D0", VA = "0x12A18D0")]
		public AmazonKinesisMetadata()
		{
		}
	}
}
