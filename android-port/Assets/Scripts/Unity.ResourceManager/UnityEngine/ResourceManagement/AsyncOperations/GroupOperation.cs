using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine.ResourceManagement.Util;

namespace UnityEngine.ResourceManagement.AsyncOperations
{
	[Token(Token = "0x2000074")]
	internal class GroupOperation : AsyncOperationBase<IList<AsyncOperationHandle>>, ICachable
	{
		[Token(Token = "0x2000075")]
		[Flags]
		public enum GroupOperationSettings
		{
			[Token(Token = "0x4000147")]
			None = 0,
			[Token(Token = "0x4000148")]
			ReleaseDependenciesOnFailure = 1,
			[Token(Token = "0x4000149")]
			AllowFailedDependencies = 2
		}

		[Token(Token = "0x400013F")]
		[FieldOffset(Offset = "0x98")]
		private Action<AsyncOperationHandle> m_InternalOnComplete;

		[Token(Token = "0x4000140")]
		[FieldOffset(Offset = "0xA0")]
		private int m_LoadedCount;

		[Token(Token = "0x4000141")]
		[FieldOffset(Offset = "0xA4")]
		private GroupOperationSettings m_Settings;

		[Token(Token = "0x4000142")]
		[FieldOffset(Offset = "0xA8")]
		private string debugName;

		[Token(Token = "0x4000143")]
		private const int k_MaxDisplayedLocationLength = 45;

		[Token(Token = "0x4000144")]
		[FieldOffset(Offset = "0xB0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1B828C", Offset = "0x1B828C")]
		private IOperationCacheKey UnityEngine_002EResourceManagement_002EAsyncOperations_002EICachable_002EKey__BackingField;

		[Token(Token = "0x4000145")]
		[FieldOffset(Offset = "0xB8")]
		private HashSet<string> m_CachedDependencyLocations;

		[Token(Token = "0x170000C1")]
		private IOperationCacheKey UnityEngine_002EResourceManagement_002EAsyncOperations_002EICachable_002EKey
		{
			[Token(Token = "0x6000333")]
			[Address(RVA = "0x2A66A7C", Offset = "0x2A66A7C", VA = "0x2A66A7C", Slot = "36")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1B868C", Offset = "0x1B868C")]
			get
			{
				return UnityEngine_002EResourceManagement_002EAsyncOperations_002EICachable_002Eget_Key();
			}
			[Token(Token = "0x6000334")]
			[Address(RVA = "0x2A66A84", Offset = "0x2A66A84", VA = "0x2A66A84", Slot = "37")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1B869C", Offset = "0x1B869C")]
			set
			{
				UnityEngine_002EResourceManagement_002EAsyncOperations_002EICachable_002Eset_Key(value);
			}
		}

		[Token(Token = "0x170000C2")]
		protected override string DebugName
		{
			[Token(Token = "0x600033A")]
			[Address(RVA = "0x2A67388", Offset = "0x2A67388", VA = "0x2A67388", Slot = "31")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000C3")]
		protected override float Progress
		{
			[Token(Token = "0x600033E")]
			[Address(RVA = "0x2A67DA4", Offset = "0x2A67DA4", VA = "0x2A67DA4", Slot = "30")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x6000331")]
		[Address(RVA = "0x2A66104", Offset = "0x2A66104", VA = "0x2A66104")]
		public GroupOperation()
		{
		}

		[Token(Token = "0x6000332")]
		[Address(RVA = "0x2A6625C", Offset = "0x2A6625C", VA = "0x2A6625C", Slot = "33")]
		protected override bool InvokeWaitForCompletion()
		{
			return default;
		}

		[Token(Token = "0x6000333")]
		[Address(RVA = "0x2A66A7C", Offset = "0x2A66A7C", VA = "0x2A66A7C", Slot = "36")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1B868C", Offset = "0x1B868C")]
		private IOperationCacheKey UnityEngine_002EResourceManagement_002EAsyncOperations_002EICachable_002Eget_Key()
		{
			return null;
		}

		[Token(Token = "0x6000334")]
		[Address(RVA = "0x2A66A84", Offset = "0x2A66A84", VA = "0x2A66A84", Slot = "37")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1B869C", Offset = "0x1B869C")]
		private void UnityEngine_002EResourceManagement_002EAsyncOperations_002EICachable_002Eset_Key(IOperationCacheKey value)
		{
		}

		[Token(Token = "0x6000335")]
		[Address(RVA = "0x2A66A8C", Offset = "0x2A66A8C", VA = "0x2A66A8C")]
		internal IList<AsyncOperationHandle> GetDependentOps()
		{
			return null;
		}

		[Token(Token = "0x6000336")]
		[Address(RVA = "0x2A66ACC", Offset = "0x2A66ACC", VA = "0x2A66ACC", Slot = "32")]
		public override void GetDependencies(List<AsyncOperationHandle> deps)
		{
		}

		[Token(Token = "0x6000337")]
		[Address(RVA = "0x2A66B3C", Offset = "0x2A66B3C", VA = "0x2A66B3C", Slot = "34")]
		internal override void ReleaseDependencies()
		{
		}

		[Token(Token = "0x6000338")]
		[Address(RVA = "0x2A66E78", Offset = "0x2A66E78", VA = "0x2A66E78", Slot = "35")]
		internal override DownloadStatus GetDownloadStatus(HashSet<object> visited)
		{
			return default;
		}

		[Token(Token = "0x6000339")]
		[Address(RVA = "0x2A671AC", Offset = "0x2A671AC", VA = "0x2A671AC")]
		private bool DependenciesAreUnchanged(List<AsyncOperationHandle> deps)
		{
			return default;
		}

		[Token(Token = "0x600033B")]
		[Address(RVA = "0x2A67688", Offset = "0x2A67688", VA = "0x2A67688", Slot = "28")]
		protected override void Execute()
		{
		}

		[Token(Token = "0x600033C")]
		[Address(RVA = "0x2A678D0", Offset = "0x2A678D0", VA = "0x2A678D0")]
		private void CompleteIfDependenciesComplete()
		{
		}

		[Token(Token = "0x600033D")]
		[Address(RVA = "0x2A67D94", Offset = "0x2A67D94", VA = "0x2A67D94", Slot = "29")]
		protected override void Destroy()
		{
		}

		[Token(Token = "0x600033F")]
		[Address(RVA = "0x2A67FD0", Offset = "0x2A67FD0", VA = "0x2A67FD0")]
		public void Init(List<AsyncOperationHandle> operations, bool releaseDependenciesOnFailure = true, bool allowFailedDependencies = false)
		{
		}

		[Token(Token = "0x6000340")]
		[Address(RVA = "0x2A6808C", Offset = "0x2A6808C", VA = "0x2A6808C")]
		public void Init(List<AsyncOperationHandle> operations, GroupOperationSettings settings)
		{
		}

		[Token(Token = "0x6000341")]
		[Address(RVA = "0x2A68128", Offset = "0x2A68128", VA = "0x2A68128")]
		private void OnOperationCompleted(AsyncOperationHandle op)
		{
		}
	}
}
