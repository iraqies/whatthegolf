using System;
using System.Net;
using Il2CppDummyDll;

namespace AWSSDK.Runtime.Internal.Util
{
	[Token(Token = "0x2000033")]
	internal static class ExceptionUtils
	{
		[Token(Token = "0x6000201")]
		[Address(RVA = "0x12066AC", Offset = "0x12066AC", VA = "0x12066AC")]
		internal static HttpStatusCode? DetermineHttpStatusCode(Exception e)
		{
			return null;
		}

		[Token(Token = "0x6000202")]
		internal static bool IsInnerException<T>(Exception exception) where T : Exception
		{
			return default;
		}

		[Token(Token = "0x6000203")]
		internal static bool IsInnerException<T>(Exception exception, out T inner) where T : Exception
		{
			return default;
		}
	}
}
