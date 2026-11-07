using Il2CppDummyDll;
using UnityEngine;

namespace Puzzle
{
	[Token(Token = "0x200103A")]
	public class PuzzleBallShooter : MonoBehaviour
	{
		[Token(Token = "0x400558C")]
		[FieldOffset(Offset = "0x18")]
		public PuzzleBall ball;

		[Token(Token = "0x400558D")]
		[FieldOffset(Offset = "0x20")]
		public Transform shootPoint;

		[Token(Token = "0x400558E")]
		[FieldOffset(Offset = "0x28")]
		private float lastShootTime;

		[Token(Token = "0x400558F")]
		[FieldOffset(Offset = "0x30")]
		private OverworldBall2D overworldBall;

		[Token(Token = "0x4005590")]
		[FieldOffset(Offset = "0x38")]
		private bool ignoringCollision;

		[Token(Token = "0x60048B9")]
		[Address(RVA = "0x162E5B4", Offset = "0x162E5B4", VA = "0x162E5B4")]
		private void Awake()
		{
		}

		[Token(Token = "0x60048BA")]
		[Address(RVA = "0x162E5E4", Offset = "0x162E5E4", VA = "0x162E5E4")]
		private void Update()
		{
		}

		[Token(Token = "0x60048BB")]
		[Address(RVA = "0x162E6D4", Offset = "0x162E6D4", VA = "0x162E6D4")]
		private void TryShoot()
		{
		}

		[Token(Token = "0x60048BC")]
		[Address(RVA = "0x162E854", Offset = "0x162E854", VA = "0x162E854")]
		private void OnCollisionEnter2D(Collision2D collision)
		{
		}

		[Token(Token = "0x60048BD")]
		[Address(RVA = "0x162E994", Offset = "0x162E994", VA = "0x162E994")]
		public PuzzleBallShooter()
		{
		}
	}
}
