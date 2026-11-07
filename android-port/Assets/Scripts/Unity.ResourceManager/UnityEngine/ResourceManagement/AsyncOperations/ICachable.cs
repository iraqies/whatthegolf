using Il2CppDummyDll;
using UnityEngine.ResourceManagement.Util;

namespace UnityEngine.ResourceManagement.AsyncOperations
{
	[Token(Token = "0x200006B")]
	internal interface ICachable
	{
		[Token(Token = "0x17000080")]
		IOperationCacheKey Key
		{
			[Token(Token = "0x6000282")]
			get;
			[Token(Token = "0x6000283")]
			set;
		}
	}
}
