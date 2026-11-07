using System;
using Il2CppDummyDll;

namespace UnityEngine.AddressableAssets
{
	[Serializable]
	[Token(Token = "0x2000037")]
	public class AssetReferenceSprite : AssetReferenceT<Sprite>
	{
		[Token(Token = "0x6000198")]
		[Address(RVA = "0x2A28948", Offset = "0x2A28948", VA = "0x2A28948")]
		public AssetReferenceSprite(string guid)
		{
		}

		[Token(Token = "0x6000199")]
		[Address(RVA = "0x2A289A8", Offset = "0x2A289A8", VA = "0x2A289A8", Slot = "21")]
		public override bool ValidateAsset(string path)
		{
			return default;
		}
	}
}
