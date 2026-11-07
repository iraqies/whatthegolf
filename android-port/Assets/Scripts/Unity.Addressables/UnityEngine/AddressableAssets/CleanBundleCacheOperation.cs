using System.Collections.Generic;
using System.Threading;
using Il2CppDummyDll;
using UnityEngine.ResourceManagement;
using UnityEngine.ResourceManagement.AsyncOperations;

namespace UnityEngine.AddressableAssets
{
	[Token(Token = "0x200003D")]
	internal class CleanBundleCacheOperation : AsyncOperationBase<bool>, IUpdateReceiver
	{
		[Token(Token = "0x400009E")]
		[FieldOffset(Offset = "0x98")]
		private AddressablesImpl m_Addressables;

		[Token(Token = "0x400009F")]
		[FieldOffset(Offset = "0xA0")]
		private AsyncOperationHandle<IList<AsyncOperationHandle>> m_DepOp;

		[Token(Token = "0x40000A0")]
		[FieldOffset(Offset = "0xC0")]
		private List<string> m_CacheDirsForRemoval;

		[Token(Token = "0x40000A1")]
		[FieldOffset(Offset = "0xC8")]
		private Thread m_EnumerationThread;

		[Token(Token = "0x40000A2")]
		[FieldOffset(Offset = "0xD0")]
		private string m_BaseCachePath;

		[Token(Token = "0x40000A3")]
		[FieldOffset(Offset = "0xD8")]
		private bool m_UseMultiThreading;

		[Token(Token = "0x60001C5")]
		[Address(RVA = "0x2A26B28", Offset = "0x2A26B28", VA = "0x2A26B28")]
		public CleanBundleCacheOperation(AddressablesImpl aa, bool forceSingleThreading)
		{
		}

		[Token(Token = "0x60001C6")]
		[Address(RVA = "0x2A26BC8", Offset = "0x2A26BC8", VA = "0x2A26BC8")]
		public AsyncOperationHandle<bool> Start(AsyncOperationHandle<IList<AsyncOperationHandle>> depOp)
		{
			return default;
		}

		[Token(Token = "0x60001C7")]
		[Address(RVA = "0x2A29C10", Offset = "0x2A29C10", VA = "0x2A29C10")]
		public void CompleteInternal(bool result, bool success, string errorMsg)
		{
		}

		[Token(Token = "0x60001C8")]
		[Address(RVA = "0x2A29CAC", Offset = "0x2A29CAC", VA = "0x2A29CAC", Slot = "33")]
		protected override bool InvokeWaitForCompletion()
		{
			return default;
		}

		[Token(Token = "0x60001C9")]
		[Address(RVA = "0x2A29F6C", Offset = "0x2A29F6C", VA = "0x2A29F6C", Slot = "29")]
		protected override void Destroy()
		{
		}

		[Token(Token = "0x60001CA")]
		[Address(RVA = "0x2A29FF4", Offset = "0x2A29FF4", VA = "0x2A29FF4", Slot = "32")]
		public override void GetDependencies(List<AsyncOperationHandle> dependencies)
		{
		}

		[Token(Token = "0x60001CB")]
		[Address(RVA = "0x2A2A0A0", Offset = "0x2A2A0A0", VA = "0x2A2A0A0", Slot = "28")]
		protected override void Execute()
		{
		}

		[Token(Token = "0x60001CC")]
		[Address(RVA = "0x2A2B078", Offset = "0x2A2B078", VA = "0x2A2B078", Slot = "36")]
		private void UnityEngine_002EResourceManagement_002EIUpdateReceiver_002EUpdate(float unscaledDeltaTime)
		{
		}

		[Token(Token = "0x60001CD")]
		[Address(RVA = "0x2A29D84", Offset = "0x2A29D84", VA = "0x2A29D84")]
		private void RemoveCacheEntries()
		{
		}

		[Token(Token = "0x60001CE")]
		[Address(RVA = "0x2A2B0CC", Offset = "0x2A2B0CC", VA = "0x2A2B0CC")]
		private void DetermineCacheDirsNotInUse(object data)
		{
		}

		[Token(Token = "0x60001CF")]
		[Address(RVA = "0x2A2AC98", Offset = "0x2A2AC98", VA = "0x2A2AC98")]
		private void DetermineCacheDirsNotInUse(HashSet<string> cacheDirsInUse)
		{
		}

		[Token(Token = "0x60001D0")]
		[Address(RVA = "0x2A2A320", Offset = "0x2A2A320", VA = "0x2A2A320")]
		private HashSet<string> GetCacheDirsInUse(IList<AsyncOperationHandle> catalogOps)
		{
			return null;
		}
	}
}
