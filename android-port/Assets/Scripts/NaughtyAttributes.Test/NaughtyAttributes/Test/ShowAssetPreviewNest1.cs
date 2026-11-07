using System;
using Il2CppDummyDll;
using UnityEngine;

namespace NaughtyAttributes.Test
{
	[Serializable]
	[Token(Token = "0x200003B")]
	public class ShowAssetPreviewNest1
	{
		[Token(Token = "0x4000094")]
		[FieldOffset(Offset = "0x10")]
		public Sprite sprite1;

		[Token(Token = "0x4000095")]
		[FieldOffset(Offset = "0x18")]
		public GameObject prefab1;

		[Token(Token = "0x4000096")]
		[FieldOffset(Offset = "0x20")]
		public ShowAssetPreviewNest2 nest2;

		[Token(Token = "0x600003A")]
		[Address(RVA = "0x22ABCAC", Offset = "0x22ABCAC", VA = "0x22ABCAC")]
		public ShowAssetPreviewNest1()
		{
		}
	}
}
