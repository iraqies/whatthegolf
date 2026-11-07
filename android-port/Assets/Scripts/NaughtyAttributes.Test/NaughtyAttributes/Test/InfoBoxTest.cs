using Il2CppDummyDll;
using UnityEngine;

namespace NaughtyAttributes.Test
{
	[Token(Token = "0x2000017")]
	public class InfoBoxTest : MonoBehaviour
	{
		[Token(Token = "0x400004E")]
		[FieldOffset(Offset = "0x18")]
		public int normal;

		[Token(Token = "0x400004F")]
		[FieldOffset(Offset = "0x20")]
		public InfoBoxNest1 nest1;

		[Token(Token = "0x6000017")]
		[Address(RVA = "0x22AB7A4", Offset = "0x22AB7A4", VA = "0x22AB7A4")]
		public InfoBoxTest()
		{
		}
	}
}
