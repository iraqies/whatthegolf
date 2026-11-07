using Il2CppDummyDll;
using UnityEngine;

namespace NaughtyAttributes.Test
{
	[Token(Token = "0x200001D")]
	public class LabelTest : MonoBehaviour
	{
		[Token(Token = "0x4000058")]
		[FieldOffset(Offset = "0x18")]
		public int int0;

		[Token(Token = "0x4000059")]
		[FieldOffset(Offset = "0x20")]
		public LabelNest1 nest1;

		[Token(Token = "0x600001D")]
		[Address(RVA = "0x22AB844", Offset = "0x22AB844", VA = "0x22AB844")]
		public LabelTest()
		{
		}
	}
}
