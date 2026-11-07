using Il2CppDummyDll;
using UnityEngine;

namespace NaughtyAttributes.Test
{
	[Token(Token = "0x200001A")]
	public class InputAxisTest : MonoBehaviour
	{
		[Token(Token = "0x4000053")]
		[FieldOffset(Offset = "0x18")]
		public string inputAxis0;

		[Token(Token = "0x4000054")]
		[FieldOffset(Offset = "0x20")]
		public InputAxisNest1 nest1;

		[Token(Token = "0x600001A")]
		[Address(RVA = "0x22AB7B4", Offset = "0x22AB7B4", VA = "0x22AB7B4")]
		private void LogInputAxis0()
		{
		}

		[Token(Token = "0x600001B")]
		[Address(RVA = "0x22AB82C", Offset = "0x22AB82C", VA = "0x22AB82C")]
		public InputAxisTest()
		{
		}
	}
}
