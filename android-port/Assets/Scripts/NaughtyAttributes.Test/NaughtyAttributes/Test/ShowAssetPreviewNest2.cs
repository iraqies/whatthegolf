using System;
using Il2CppDummyDll;
using UnityEngine;

namespace NaughtyAttributes.Test
{
	[Serializable]
	[Token(Token = "0x200003C")]
	public class ShowAssetPreviewNest2
	{
		[Token(Token = "0x4000097")]
		[FieldOffset(Offset = "0x10")]
		public Sprite sprite2;

		[Token(Token = "0x4000098")]
		[FieldOffset(Offset = "0x18")]
		public GameObject prefab2;

		[Token(Token = "0x600003B")]
		[Address(RVA = "0x22ABCB4", Offset = "0x22ABCB4", VA = "0x22ABCB4")]
		public ShowAssetPreviewNest2()
		{
		}
	}
}
