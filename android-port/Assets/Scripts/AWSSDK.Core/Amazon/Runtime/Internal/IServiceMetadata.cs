using System.Collections.Generic;
using Il2CppDummyDll;

namespace Amazon.Runtime.Internal
{
	[Token(Token = "0x2000166")]
	public interface IServiceMetadata
	{
		[Token(Token = "0x1700030C")]
		string ServiceId
		{
			[Token(Token = "0x6000B6D")]
			get;
		}

		[Token(Token = "0x1700030D")]
		IDictionary<string, string> OperationNameMapping
		{
			[Token(Token = "0x6000B6E")]
			get;
		}
	}
}
