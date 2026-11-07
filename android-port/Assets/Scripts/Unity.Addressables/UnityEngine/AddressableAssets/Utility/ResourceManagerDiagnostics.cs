using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine.ResourceManagement;
using UnityEngine.ResourceManagement.AsyncOperations;

namespace UnityEngine.AddressableAssets.Utility
{
	[Token(Token = "0x2000045")]
	internal class ResourceManagerDiagnostics : IDisposable
	{
		[Token(Token = "0x40000BF")]
		[FieldOffset(Offset = "0x10")]
		private ResourceManager m_ResourceManager;

		[Token(Token = "0x40000C0")]
		private const int k_NumberOfCompletedOpResultEntriesToShow = 4;

		[Token(Token = "0x40000C1")]
		private const int k_MaximumCompletedOpResultEntryLength = 30;

		[Token(Token = "0x40000C2")]
		[FieldOffset(Offset = "0x18")]
		private Dictionary<int, DiagnosticInfo> m_cachedDiagnosticInfo;

		[Token(Token = "0x60001EC")]
		[Address(RVA = "0x2A303E8", Offset = "0x2A303E8", VA = "0x2A303E8")]
		public ResourceManagerDiagnostics(ResourceManager resourceManager)
		{
		}

		[Token(Token = "0x60001ED")]
		[Address(RVA = "0x2A379D0", Offset = "0x2A379D0", VA = "0x2A379D0")]
		internal int SumDependencyNameHashCodes(AsyncOperationHandle handle)
		{
			return default;
		}

		[Token(Token = "0x60001EE")]
		[Address(RVA = "0x2A37BF0", Offset = "0x2A37BF0", VA = "0x2A37BF0")]
		internal int CalculateHashCode(AsyncOperationHandle handle)
		{
			return default;
		}

		[Token(Token = "0x60001EF")]
		[Address(RVA = "0x2A37D40", Offset = "0x2A37D40", VA = "0x2A37D40")]
		internal int CalculateCompletedOperationHashcode(AsyncOperationHandle handle)
		{
			return default;
		}

		[Token(Token = "0x60001F0")]
		[Address(RVA = "0x2A37DD0", Offset = "0x2A37DD0", VA = "0x2A37DD0")]
		internal string GenerateCompletedOperationDisplayName(AsyncOperationHandle handle)
		{
			return null;
		}

		[Token(Token = "0x60001F1")]
		[Address(RVA = "0x2A38250", Offset = "0x2A38250", VA = "0x2A38250")]
		private void OnResourceManagerDiagnosticEvent(ResourceManager.DiagnosticEventContext eventContext)
		{
		}

		[Token(Token = "0x60001F2")]
		[Address(RVA = "0x2A31704", Offset = "0x2A31704", VA = "0x2A31704", Slot = "4")]
		public void Dispose()
		{
		}
	}
}
