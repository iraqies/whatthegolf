using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine.ResourceManagement.AsyncOperations;

namespace UnityEngine.ResourceManagement
{
	[Token(Token = "0x2000007")]
	internal class ChainOperation<TObject, TObjectDependency> : AsyncOperationBase<TObject>
	{
		[Token(Token = "0x400000A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private AsyncOperationHandle<TObjectDependency> m_DepOp;

		[Token(Token = "0x400000B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private AsyncOperationHandle<TObject> m_WrappedOp;

		[Token(Token = "0x400000C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private DownloadStatus m_depStatus;

		[Token(Token = "0x400000D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private DownloadStatus m_wrapStatus;

		[Token(Token = "0x400000E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private Func<AsyncOperationHandle<TObjectDependency>, AsyncOperationHandle<TObject>> m_Callback;

		[Token(Token = "0x400000F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private Action<AsyncOperationHandle<TObject>> m_CachedOnWrappedCompleted;

		[Token(Token = "0x4000010")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private bool m_ReleaseDependenciesOnFailure;

		[Token(Token = "0x17000005")]
		protected override string DebugName
		{
			[Token(Token = "0x6000028")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000006")]
		protected override float Progress
		{
			[Token(Token = "0x6000032")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x6000027")]
		public ChainOperation()
		{
		}

		[Token(Token = "0x6000029")]
		public override void GetDependencies(List<AsyncOperationHandle> deps)
		{
		}

		[Token(Token = "0x600002A")]
		public void Init(AsyncOperationHandle<TObjectDependency> dependentOp, Func<AsyncOperationHandle<TObjectDependency>, AsyncOperationHandle<TObject>> callback, bool releaseDependenciesOnFailure)
		{
		}

		[Token(Token = "0x600002B")]
		protected override bool InvokeWaitForCompletion()
		{
			return default;
		}

		[Token(Token = "0x600002C")]
		protected override void Execute()
		{
		}

		[Token(Token = "0x600002D")]
		private void OnWrappedCompleted(AsyncOperationHandle<TObject> x)
		{
		}

		[Token(Token = "0x600002E")]
		protected override void Destroy()
		{
		}

		[Token(Token = "0x600002F")]
		internal override void ReleaseDependencies()
		{
		}

		[Token(Token = "0x6000030")]
		internal override DownloadStatus GetDownloadStatus(HashSet<object> visited)
		{
			return default;
		}

		[Token(Token = "0x6000031")]
		private void RefreshDownloadStatus([Optional] HashSet<object> visited)
		{
		}
	}
}
