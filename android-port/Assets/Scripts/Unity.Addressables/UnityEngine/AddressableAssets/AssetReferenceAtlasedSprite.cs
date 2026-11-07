using System;
using Il2CppDummyDll;

namespace UnityEngine.AddressableAssets
{
	[Serializable]
	[Token(Token = "0x2000038")]
	public class AssetReferenceAtlasedSprite : AssetReferenceT<Sprite>
	{
		[Token(Token = "0x600019A")]
		[Address(RVA = "0x2A28758", Offset = "0x2A28758", VA = "0x2A28758")]
		public AssetReferenceAtlasedSprite(string guid)
		{
		}

		[Token(Token = "0x600019B")]
		[Address(RVA = "0x2A287B8", Offset = "0x2A287B8", VA = "0x2A287B8", Slot = "20")]
		public override bool ValidateAsset(Object obj)
		{
			return default;
		}

		[Token(Token = "0x600019C")]
		[Address(RVA = "0x2A28834", Offset = "0x2A28834", VA = "0x2A28834", Slot = "21")]
		public override bool ValidateAsset(string path)
		{
			return default;
		}
	}
}
