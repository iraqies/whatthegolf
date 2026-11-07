using Il2CppDummyDll;
using UnityEngine;

namespace NaughtyAttributes.Test
{
	[Token(Token = "0x200003A")]
	public class ShowAssetPreviewTest : MonoBehaviour
	{
		[Token(Token = "0x4000091")]
		[FieldOffset(Offset = "0x18")]
		public Sprite sprite0;

		[Token(Token = "0x4000092")]
		[FieldOffset(Offset = "0x20")]
		public GameObject prefab0;

		[Token(Token = "0x4000093")]
		[FieldOffset(Offset = "0x28")]
		public ShowAssetPreviewNest1 nest1;

		[Token(Token = "0x6000039")]
		[Address(RVA = "0x22ABCBC", Offset = "0x22ABCBC", VA = "0x22ABCBC")]
		public ShowAssetPreviewTest()
		{
		}
	}
}
