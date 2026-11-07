using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine.Networking;

namespace UnityEngine.ResourceManagement
{
	[Token(Token = "0x2000012")]
	public static class WebRequestQueue
	{
		[Token(Token = "0x4000053")]
		[FieldOffset(Offset = "0x0")]
		internal static int s_MaxRequest;

		[Token(Token = "0x4000054")]
		[FieldOffset(Offset = "0x8")]
		internal static Queue<WebRequestQueueOperation> s_QueuedOperations;

		[Token(Token = "0x4000055")]
		[FieldOffset(Offset = "0x10")]
		internal static List<UnityWebRequestAsyncOperation> s_ActiveRequests;

		[Token(Token = "0x60000A6")]
		[Address(RVA = "0x2A71F64", Offset = "0x2A71F64", VA = "0x2A71F64")]
		public static void SetMaxConcurrentRequests(int maxRequests)
		{
		}

		[Token(Token = "0x60000A7")]
		[Address(RVA = "0x2A5FE1C", Offset = "0x2A5FE1C", VA = "0x2A5FE1C")]
		public static WebRequestQueueOperation QueueRequest(UnityWebRequest request)
		{
			return null;
		}

		[Token(Token = "0x60000A8")]
		[Address(RVA = "0x2A5E734", Offset = "0x2A5E734", VA = "0x2A5E734")]
		public static void WaitForRequestToBeActive(WebRequestQueueOperation request, int millisecondsTimeout)
		{
		}

		[Token(Token = "0x60000A9")]
		[Address(RVA = "0x2A5EBB0", Offset = "0x2A5EBB0", VA = "0x2A5EBB0")]
		internal static void DequeueRequest(UnityWebRequestAsyncOperation operation)
		{
		}

		[Token(Token = "0x60000AA")]
		[Address(RVA = "0x2A7244C", Offset = "0x2A7244C", VA = "0x2A7244C")]
		private static void OnWebAsyncOpComplete(AsyncOperation operation)
		{
		}

		[Token(Token = "0x60000AB")]
		[Address(RVA = "0x2A72320", Offset = "0x2A72320", VA = "0x2A72320")]
		private static void OnWebAsyncOpComplete(UnityWebRequestAsyncOperation operation)
		{
		}

		[Token(Token = "0x60000AC")]
		[Address(RVA = "0x2A7205C", Offset = "0x2A7205C", VA = "0x2A7205C")]
		private static void BeginWebRequest(WebRequestQueueOperation queueOperation)
		{
		}
	}
}
