using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Il2CppDummyDll;
using UnityEngine.Scripting;

namespace Apple.Core.Runtime
{
	[Token(Token = "0x2000007")]
	[Preserve]
	public static class InteropTasks
	{
		[Token(Token = "0x4000006")]
		[FieldOffset(Offset = "0x0")]
		private static readonly Dictionary<string, object> _taskCompletionSources;

		[Token(Token = "0x4000007")]
		[FieldOffset(Offset = "0x8")]
		private static readonly object _taskLock;

		[Token(Token = "0x600000F")]
		public static TaskCompletionSource<TResult> Create<TResult>(out string guid)
		{
			return null;
		}

		[Token(Token = "0x6000010")]
		public static bool TrySetResultAndRemove<TResult>(string guid, TResult result)
		{
			return default;
		}

		[Token(Token = "0x6000011")]
		public static bool TrySetExceptionAndRemove<TResult>(string guid, Exception exception)
		{
			return default;
		}
	}
}
