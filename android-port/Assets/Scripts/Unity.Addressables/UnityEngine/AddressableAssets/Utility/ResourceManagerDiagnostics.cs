using System;
using System.Collections.Generic;
using UnityEngine.ResourceManagement;
using UnityEngine.ResourceManagement.AsyncOperations;

namespace UnityEngine.AddressableAssets.Utility
{
	internal class ResourceManagerDiagnostics : IDisposable
	{
		private ResourceManager m_ResourceManager;

		private const int k_NumberOfCompletedOpResultEntriesToShow = 4;

		private const int k_MaximumCompletedOpResultEntryLength = 30;

		private Dictionary<int, DiagnosticInfo> m_cachedDiagnosticInfo;

		public ResourceManagerDiagnostics(ResourceManager resourceManager)
		{
		}

		internal int SumDependencyNameHashCodes(AsyncOperationHandle handle)
		{
			return 0;
		}

		internal int CalculateHashCode(AsyncOperationHandle handle)
		{
			return 0;
		}

		internal int CalculateCompletedOperationHashcode(AsyncOperationHandle handle)
		{
			return 0;
		}

		internal string GenerateCompletedOperationDisplayName(AsyncOperationHandle handle)
		{
			return null;
		}

		private void OnResourceManagerDiagnosticEvent(ResourceManager.DiagnosticEventContext eventContext)
		{
		}

		public void Dispose()
		{
		}
	}
}
