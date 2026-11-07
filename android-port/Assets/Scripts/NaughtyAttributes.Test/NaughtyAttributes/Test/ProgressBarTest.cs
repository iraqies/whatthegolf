using Il2CppDummyDll;
using UnityEngine;

namespace NaughtyAttributes.Test
{
	[Token(Token = "0x2000029")]
	public class ProgressBarTest : MonoBehaviour
	{
		[Token(Token = "0x4000072")]
		[FieldOffset(Offset = "0x18")]
		public float health;

		[Token(Token = "0x4000073")]
		[FieldOffset(Offset = "0x20")]
		public ProgressBarNest1 nest1;

		[Token(Token = "0x600002B")]
		[Address(RVA = "0x22ABC30", Offset = "0x22ABC30", VA = "0x22ABC30")]
		public ProgressBarTest()
		{
		}
	}
}
