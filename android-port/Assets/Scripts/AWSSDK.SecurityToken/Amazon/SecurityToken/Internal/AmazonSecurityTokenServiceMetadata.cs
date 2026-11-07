using System.Collections.Generic;
using Amazon.Runtime.Internal;
using Il2CppDummyDll;

namespace Amazon.SecurityToken.Internal
{
	[Token(Token = "0x200000D")]
	public class AmazonSecurityTokenServiceMetadata : IServiceMetadata
	{
		[Token(Token = "0x17000006")]
		public string ServiceId
		{
			[Token(Token = "0x600005B")]
			[Address(RVA = "0x12D4FD4", Offset = "0x12D4FD4", VA = "0x12D4FD4", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000007")]
		public IDictionary<string, string> OperationNameMapping
		{
			[Token(Token = "0x600005C")]
			[Address(RVA = "0x12D5018", Offset = "0x12D5018", VA = "0x12D5018", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600005D")]
		[Address(RVA = "0x12D4790", Offset = "0x12D4790", VA = "0x12D4790")]
		public AmazonSecurityTokenServiceMetadata()
		{
		}
	}
}
