using System;
using UnityEngine.ResourceManagement.AsyncOperations;

namespace UnityEngine.AddressableAssets
{
	[Serializable]
	public class AssetReferenceT<TObject> : AssetReference where TObject : Object
	{
		public AssetReferenceT(string guid)
		{
		}

		[Obsolete]
		public AsyncOperationHandle<TObject> LoadAsset()
		{
			return default;
		}

		public virtual AsyncOperationHandle<TObject> LoadAssetAsync()
		{
			return default;
		}

		public override bool ValidateAsset(Object obj)
		{
			return false;
		}

		public override bool ValidateAsset(string mainAssetPath)
		{
			return false;
		}
	}
}
