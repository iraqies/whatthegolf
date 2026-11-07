using System;

namespace Amazon.Runtime.Internal.Util
{
	public static class GuidUtils
	{
		public static bool TryParseNullableGuid(string value, out Guid? result)
		{
			result = null;
			return false;
		}

		public static bool TryParseGuid(string value, out Guid result)
		{
			result = default;
			return false;
		}
	}
}
