using System.ComponentModel;
using UnityEngine.ResourceManagement.ResourceLocations;

namespace UnityEngine.ResourceManagement.ResourceProviders
{
	[DisplayName]
	public class LegacyResourcesProvider : ResourceProviderBase
	{
		internal class InternalOp
		{
			private ResourceRequest m_RequestOperation;

			private ProvideHandle m_ProvideHandle;

			public void Start(ProvideHandle provideHandle)
			{
			}

			private bool WaitForCompletionHandler()
			{
				return false;
			}

			private void AsyncOperationCompleted(AsyncOperation op)
			{
			}

			public float PercentComplete()
			{
				return 0f;
			}
		}

		public override void Provide(ProvideHandle pi)
		{
		}

		public override void Release(IResourceLocation location, object asset)
		{
		}
	}
}
