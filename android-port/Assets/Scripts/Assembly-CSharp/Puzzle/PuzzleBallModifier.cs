using Il2CppDummyDll;
using UnityEngine;

namespace Puzzle
{
	[Token(Token = "0x2001039")]
	[Attribute(Name = "RequireComponent", RVA = "0x47604", Offset = "0x47604")]
	public class PuzzleBallModifier : MonoBehaviour
	{
		[Token(Token = "0x4005585")]
		[FieldOffset(Offset = "0x18")]
		public float speedChange;

		[Token(Token = "0x4005586")]
		[FieldOffset(Offset = "0x20")]
		public SpriteRenderer shadowSprite;

		[Token(Token = "0x4005587")]
		[FieldOffset(Offset = "0x28")]
		public Transform iconParent;

		[Token(Token = "0x4005588")]
		[FieldOffset(Offset = "0x30")]
		private Collider2D col;

		[Token(Token = "0x4005589")]
		[FieldOffset(Offset = "0x38")]
		private PuzzleBall puzzleBall;

		[Token(Token = "0x400558A")]
		[FieldOffset(Offset = "0x40")]
		private bool hasInitializedBall;

		[Token(Token = "0x400558B")]
		[FieldOffset(Offset = "0x41")]
		private bool hit;

		[Token(Token = "0x60048B3")]
		[Address(RVA = "0x162E284", Offset = "0x162E284", VA = "0x162E284")]
		private void Awake()
		{
		}

		[Token(Token = "0x60048B4")]
		[Address(RVA = "0x162E2F0", Offset = "0x162E2F0", VA = "0x162E2F0")]
		private void OnTriggerEnter2D(Collider2D collision)
		{
		}

		[Token(Token = "0x60048B5")]
		[Address(RVA = "0x162E504", Offset = "0x162E504", VA = "0x162E504")]
		private void HandlePower(PuzzleBall ball)
		{
		}

		[Token(Token = "0x60048B6")]
		[Address(RVA = "0x162E438", Offset = "0x162E438", VA = "0x162E438")]
		private void SubscribeToBall(PuzzleBall ball)
		{
		}

		[Token(Token = "0x60048B7")]
		[Address(RVA = "0x162E554", Offset = "0x162E554", VA = "0x162E554")]
		private void ResetPowerup()
		{
		}

		[Token(Token = "0x60048B8")]
		[Address(RVA = "0x162E5AC", Offset = "0x162E5AC", VA = "0x162E5AC")]
		public PuzzleBallModifier()
		{
		}
	}
}
