using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine.ResourceManagement.AsyncOperations;

namespace UnityEngine.ResourceManagement
{
	[Token(Token = "0x2000008")]
	internal class ChainOperationTypelessDepedency<TObject> : AsyncOperationBase<TObject>
	{
		[Token(Token = "0x4000011")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private AsyncOperationHandle m_DepOp;

		[Token(Token = "0x4000012")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private AsyncOperationHandle<TObject> m_WrappedOp;

		[Token(Token = "0x4000013")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private DownloadStatus m_depStatus;

		[Token(Token = "0x4000014")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private DownloadStatus m_wrapStatus;

		[Token(Token = "0x4000015")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private Func<AsyncOperationHandle, AsyncOperationHandle<TObject>> m_Callback;

		[Token(Token = "0x4000016")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private Action<AsyncOperationHandle<TObject>> m_CachedOnWrappedCompleted;

		[Token(Token = "0x4000017")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private bool m_ReleaseDependenciesOnFailure;

		[Token(Token = "0x17000007")]
		internal AsyncOperationHandle<TObject> WrappedOp
		{
			[Token(Token = "0x6000033")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000008")]
		protected override string DebugName
		{
			[Token(Token = "0x6000035")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000009")]
		protected override float Progress
		{
			[Token(Token = "0x600003F")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x6000034")]
		public ChainOperationTypelessDepedency()
		{
		}

		[Token(Token = "0x6000036")]
		public override void GetDependencies(List<AsyncOperationHandle> deps)
		{
		}

		[Token(Token = "0x6000037")]
		public void Init(AsyncOperationHandle dependentOp, Func<AsyncOperationHandle, AsyncOperationHandle<TObject>> callback, bool releaseDependenciesOnFailure)
		{
		}

		[Token(Token = "0x6000038")]
		protected override bool InvokeWaitForCompletion()
		{
			return default;
		}

		[Token(Token = "0x6000039")]
		protected override void Execute()
		{
		}

		[Token(Token = "0x600003A")]
		private void OnWrappedCompleted(AsyncOperationHandle<TObject> x)
		{
		}

		[Token(Token = "0x600003B")]
		protected override void Destroy()
		{
		}

		[Token(Token = "0x600003C")]
		internal override void ReleaseDependencies()
		{
		}

		[Token(Token = "0x600003D")]
		internal override DownloadStatus GetDownloadStatus(HashSet<object> visited)
		{
			return default;
		}

		[Token(Token = "0x600003E")]
		private void RefreshDownloadStatus([Optional] HashSet<object> visited)
		{
		}
	}
}
