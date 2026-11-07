using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine.AddressableAssets;
using UnityEngine.AddressableAssets.Initialization;

namespace UnityEngine.ResourceManagement.AsyncOperations
{
	[Token(Token = "0x200000B")]
	internal class InitalizationObjectsOperation : AsyncOperationBase<bool>
	{
		[Token(Token = "0x4000007")]
		[FieldOffset(Offset = "0x98")]
		private AsyncOperationHandle<ResourceManagerRuntimeData> m_RtdOp;

		[Token(Token = "0x4000008")]
		[FieldOffset(Offset = "0xB8")]
		private AddressablesImpl m_Addressables;

		[Token(Token = "0x4000009")]
		[FieldOffset(Offset = "0xC0")]
		private AsyncOperationHandle<IList<AsyncOperationHandle>> m_DepOp;

		[Token(Token = "0x17000003")]
		protected override string DebugName
		{
			[Token(Token = "0x6000020")]
			[Address(RVA = "0x2A2F6A4", Offset = "0x2A2F6A4", VA = "0x2A2F6A4", Slot = "31")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600001F")]
		[Address(RVA = "0x2A2F66C", Offset = "0x2A2F66C", VA = "0x2A2F66C")]
		public void Init(AsyncOperationHandle<ResourceManagerRuntimeData> rtdOp, AddressablesImpl addressables)
		{
		}

		[Token(Token = "0x6000021")]
		[Address(RVA = "0x2A2F6E8", Offset = "0x2A2F6E8", VA = "0x2A2F6E8")]
		internal bool LogRuntimeWarnings(string pathToBuildLogs)
		{
			return default;
		}

		[Token(Token = "0x6000022")]
		[Address(RVA = "0x2A2F934", Offset = "0x2A2F934", VA = "0x2A2F934", Slot = "33")]
		protected override bool InvokeWaitForCompletion()
		{
			return default;
		}

		[Token(Token = "0x6000023")]
		[Address(RVA = "0x2A2FADC", Offset = "0x2A2FADC", VA = "0x2A2FADC", Slot = "28")]
		protected override void Execute()
		{
		}

		[Token(Token = "0x6000024")]
		[Address(RVA = "0x2A30148", Offset = "0x2A30148", VA = "0x2A30148")]
		public InitalizationObjectsOperation()
		{
		}

		[Token(Token = "0x6000025")]
		[Address(RVA = "0x2A301A0", Offset = "0x2A301A0", VA = "0x2A301A0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1B1B04", Offset = "0x1B1B04")]
		private void _003CExecute_003Eb__8_0(AsyncOperationHandle<IList<AsyncOperationHandle>> obj)
		{
		}
	}
}
