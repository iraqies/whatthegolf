using Audio;
using Il2CppDummyDll;
using UnityEngine;

namespace Puzzle
{
	[Token(Token = "0x2001051")]
	public class PuzzleWall : PuzzleObjectBase
	{
		[Token(Token = "0x40055FB")]
		[FieldOffset(Offset = "0x38")]
		public Animator spriteAnimator;

		[Token(Token = "0x40055FC")]
		[FieldOffset(Offset = "0x40")]
		public Collider2D col;

		[Token(Token = "0x40055FD")]
		[FieldOffset(Offset = "0x48")]
		public bool startOn;

		[Token(Token = "0x40055FE")]
		[FieldOffset(Offset = "0x50")]
		public RandomAudioClips clips;

		[Token(Token = "0x6004929")]
		[Address(RVA = "0x16323C4", Offset = "0x16323C4", VA = "0x16323C4", Slot = "6")]
		public override void OnBallEnter(OverworldBall2D ball)
		{
		}

		[Token(Token = "0x600492A")]
		[Address(RVA = "0x1632448", Offset = "0x1632448", VA = "0x1632448", Slot = "8")]
		public override void Trigger(bool active)
		{
		}

		[Token(Token = "0x600492B")]
		[Address(RVA = "0x163254C", Offset = "0x163254C", VA = "0x163254C")]
		public PuzzleWall()
		{
		}
	}
}
