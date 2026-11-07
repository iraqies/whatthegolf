using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine.Scripting;

namespace Apple.Core.Runtime
{
	[Token(Token = "0x2000006")]
	[Preserve]
	public static class InteropGCHandleTracker
	{
		[Token(Token = "0x4000004")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static readonly Dictionary<string, GCHandle> _arrays;

		[Token(Token = "0x4000005")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static readonly object _arraysLock;

		[Token(Token = "0x600000D")]
		[Address(RVA = "0x12E7390", Offset = "0x12E7390", VA = "0x12E7390")]
		public static void UntrackAndFree(string guid)
		{
		}
	}
}
