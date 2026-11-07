using UnityEngine.Networking;

namespace UnityEngine.ResourceManagement.Util
{
	public class UnityWebRequestUtilities
	{
		public static bool RequestHasErrors(UnityWebRequest webReq, out UnityWebRequestResult result)
		{
			result = null;
			return false;
		}

		public static bool IsAssetBundleDownloaded(UnityWebRequestAsyncOperation op)
		{
			return false;
		}
	}
}
