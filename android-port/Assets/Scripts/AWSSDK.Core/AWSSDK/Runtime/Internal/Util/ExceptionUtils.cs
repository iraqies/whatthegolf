using System;
using System.Net;

namespace AWSSDK.Runtime.Internal.Util
{
	internal static class ExceptionUtils
	{
		internal static HttpStatusCode? DetermineHttpStatusCode(Exception e)
		{
			return null;
		}

		internal static bool IsInnerException<T>(Exception exception) where T : Exception
		{
			return false;
		}

		internal static bool IsInnerException<T>(Exception exception, out T inner) where T : Exception
		{
			inner = null;
			return false;
		}
	}
}
