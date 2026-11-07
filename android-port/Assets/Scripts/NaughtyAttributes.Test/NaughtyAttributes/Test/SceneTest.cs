using Il2CppDummyDll;
using UnityEngine;

namespace NaughtyAttributes.Test
{
	[Token(Token = "0x2000037")]
	public class SceneTest : MonoBehaviour
	{
		[Token(Token = "0x400008C")]
		[FieldOffset(Offset = "0x18")]
		public string scene0;

		[Token(Token = "0x400008D")]
		[FieldOffset(Offset = "0x20")]
		public SceneNest1 nest1;

		[Token(Token = "0x6000037")]
		[Address(RVA = "0x22ABCA4", Offset = "0x22ABCA4", VA = "0x22ABCA4")]
		public SceneTest()
		{
		}
	}
}
