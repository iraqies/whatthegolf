using System.Collections.Generic;
using Amazon.Runtime.Internal;
using Il2CppDummyDll;

namespace Amazon.CognitoIdentity.Internal
{
	[Token(Token = "0x2000019")]
	public class AmazonCognitoIdentityMetadata : IServiceMetadata
	{
		[Token(Token = "0x17000015")]
		public string ServiceId
		{
			[Token(Token = "0x60000CF")]
			[Address(RVA = "0x1075DE8", Offset = "0x1075DE8", VA = "0x1075DE8", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000016")]
		public IDictionary<string, string> OperationNameMapping
		{
			[Token(Token = "0x60000D0")]
			[Address(RVA = "0x1075E2C", Offset = "0x1075E2C", VA = "0x1075E2C", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60000D1")]
		[Address(RVA = "0x1075C40", Offset = "0x1075C40", VA = "0x1075C40")]
		public AmazonCognitoIdentityMetadata()
		{
		}
	}
}
