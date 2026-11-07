using Il2CppDummyDll;
using UnityEngine;

namespace NaughtyAttributes.Test
{
	[Token(Token = "0x2000034")]
	public class ResizableTextAreaTest : MonoBehaviour
	{
		[Token(Token = "0x4000087")]
		[FieldOffset(Offset = "0x18")]
		public string text0;

		[Token(Token = "0x4000088")]
		[FieldOffset(Offset = "0x20")]
		public ResizableTextAreaNest1 nest1;

		[Token(Token = "0x6000034")]
		[Address(RVA = "0x22ABC94", Offset = "0x22ABC94", VA = "0x22ABC94")]
		public ResizableTextAreaTest()
		{
		}
	}
}
