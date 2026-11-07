using Il2CppDummyDll;
using UnityEngine;

namespace NaughtyAttributes.Test
{
	[Token(Token = "0x2000042")]
	public class TagTest : MonoBehaviour
	{
		[Token(Token = "0x40000AA")]
		[FieldOffset(Offset = "0x18")]
		public string tag0;

		[Token(Token = "0x40000AB")]
		[FieldOffset(Offset = "0x20")]
		public TagNest1 nest1;

		[Token(Token = "0x6000044")]
		[Address(RVA = "0x22ABD90", Offset = "0x22ABD90", VA = "0x22ABD90")]
		private void LogTag0()
		{
		}

		[Token(Token = "0x6000045")]
		[Address(RVA = "0x22ABE08", Offset = "0x22ABE08", VA = "0x22ABE08")]
		public TagTest()
		{
		}
	}
}
