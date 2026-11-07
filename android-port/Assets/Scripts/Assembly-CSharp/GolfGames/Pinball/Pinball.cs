using Il2CppDummyDll;
using UnityEngine;

namespace GolfGames.Pinball
{
	[Token(Token = "0x20010B0")]
	public class Pinball : MonoBehaviour
	{
		[Token(Token = "0x40057E9")]
		[FieldOffset(Offset = "0x18")]
		public Transform StartPosition;

		[Token(Token = "0x40057EA")]
		[FieldOffset(Offset = "0x20")]
		public bool BallInStarterPosition;

		[Token(Token = "0x40057EB")]
		[FieldOffset(Offset = "0x28")]
		public Rigidbody2D Rigidbody;

		[Token(Token = "0x6004AD3")]
		[Address(RVA = "0x15E2490", Offset = "0x15E2490", VA = "0x15E2490")]
		private void OnCollisionEnter2D(Collision2D collision)
		{
		}

		[Token(Token = "0x6004AD4")]
		[Address(RVA = "0x15E2554", Offset = "0x15E2554", VA = "0x15E2554")]
		private void OnTriggerEnter2D(Collider2D collision)
		{
		}

		[Token(Token = "0x6004AD5")]
		[Address(RVA = "0x15E2608", Offset = "0x15E2608", VA = "0x15E2608")]
		public Pinball()
		{
		}
	}
}
