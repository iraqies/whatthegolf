using System.Collections.Generic;
using Il2CppDummyDll;

namespace Amazon.Runtime.EventStreams
{
	[Token(Token = "0x200011B")]
	public interface IEventStreamMessage
	{
		[Token(Token = "0x1700026F")]
		Dictionary<string, IEventStreamHeader> Headers
		{
			[Token(Token = "0x600093F")]
			get;
			[Token(Token = "0x6000940")]
			set;
		}

		[Token(Token = "0x17000270")]
		byte[] Payload
		{
			[Token(Token = "0x6000941")]
			get;
			[Token(Token = "0x6000942")]
			set;
		}

		[Token(Token = "0x6000943")]
		byte[] ToByteArray();
	}
}
