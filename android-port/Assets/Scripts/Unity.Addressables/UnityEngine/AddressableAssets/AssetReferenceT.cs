using System;
using Il2CppDummyDll;
using UnityEngine.ResourceManagement.AsyncOperations;

namespace UnityEngine.AddressableAssets
{
	[Serializable]
	[Token(Token = "0x2000032")]
	public class AssetReferenceT<TObject> : AssetReference where TObject : Object
	{
		[Token(Token = "0x600018F")]
		public AssetReferenceT(string guid)
		{
		}

		[Token(Token = "0x6000190")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x1B1E14", Offset = "0x1B1E14")]
		public AsyncOperationHandle<TObject> LoadAsset()
		{
			return default;
		}

		[Token(Token = "0x6000191")]
		public virtual AsyncOperationHandle<TObject> LoadAssetAsync()
		{
			return default;
		}

		[Token(Token = "0x6000192")]
		public override bool ValidateAsset(Object obj)
		{
			return default;
		}

		[Token(Token = "0x6000193")]
		public override bool ValidateAsset(string mainAssetPath)
		{
			return default;
		}
	}
}
