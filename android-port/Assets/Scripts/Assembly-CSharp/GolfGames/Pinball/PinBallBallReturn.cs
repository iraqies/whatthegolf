using Il2CppDummyDll;
using UnityEngine;

namespace GolfGames.Pinball
{
	[Token(Token = "0x20010AF")]
	public class PinBallBallReturn : MonoBehaviour
	{
		[Token(Token = "0x40057E8")]
		[FieldOffset(Offset = "0x18")]
		public Transform StartPosition;

		[Token(Token = "0x6004AD1")]
		[Address(RVA = "0x15E2324", Offset = "0x15E2324", VA = "0x15E2324")]
		private void OnTriggerEnter2D(Collider2D other)
		{
		}

		[Token(Token = "0x6004AD2")]
		[Address(RVA = "0x15E2488", Offset = "0x15E2488", VA = "0x15E2488")]
		public PinBallBallReturn()
		{
		}
	}
}
