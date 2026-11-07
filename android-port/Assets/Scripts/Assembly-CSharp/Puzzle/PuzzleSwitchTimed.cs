using Chronos;
using Il2CppDummyDll;
using UnityEngine;

namespace Puzzle
{
	[Token(Token = "0x200104C")]
	public class PuzzleSwitchTimed : PuzzleSwitchBase, ITimedPuzzleObject
	{
		[Token(Token = "0x40055DD")]
		[FieldOffset(Offset = "0x4C")]
		public float time;

		[Token(Token = "0x40055DE")]
		[FieldOffset(Offset = "0x50")]
		public bool retriggerWhileActive;

		[Token(Token = "0x40055DF")]
		[FieldOffset(Offset = "0x54")]
		private float timer;

		[Token(Token = "0x40055E0")]
		[FieldOffset(Offset = "0x58")]
		private bool running;

		[Token(Token = "0x40055E1")]
		[FieldOffset(Offset = "0x60")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x555C0", Offset = "0x555C0")]
		private LocalClock BallClock__BackingField;

		[Token(Token = "0x170007B9")]
		public LocalClock BallClock
		{
			[Token(Token = "0x600490D")]
			[Address(RVA = "0x1632140", Offset = "0x1632140", VA = "0x1632140", Slot = "5")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x6F1D4", Offset = "0x6F1D4")]
			get
			{
				return null;
			}
			[Token(Token = "0x600490E")]
			[Address(RVA = "0x1632148", Offset = "0x1632148", VA = "0x1632148")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x6F1E4", Offset = "0x6F1E4")]
			set
			{
			}
		}

		[Token(Token = "0x600490F")]
		[Address(RVA = "0x1632150", Offset = "0x1632150", VA = "0x1632150", Slot = "4")]
		public void SetClock(LocalClock clock)
		{
		}

		[Token(Token = "0x6004910")]
		[Address(RVA = "0x1632158", Offset = "0x1632158", VA = "0x1632158", Slot = "6")]
		public float GetDeltaTime()
		{
			return default;
		}

		[Token(Token = "0x6004911")]
		[Address(RVA = "0x1632200", Offset = "0x1632200", VA = "0x1632200")]
		private void OnCollisionEnter2D(Collision2D collision)
		{
		}

		[Token(Token = "0x6004912")]
		[Address(RVA = "0x1632324", Offset = "0x1632324", VA = "0x1632324")]
		private void OnTriggerEnter2D(Collider2D other)
		{
		}

		[Token(Token = "0x6004913")]
		[Address(RVA = "0x1632238", Offset = "0x1632238", VA = "0x1632238")]
		private void OnObjectEnterTrigger(GameObject go)
		{
		}

		[Token(Token = "0x6004914")]
		[Address(RVA = "0x163235C", Offset = "0x163235C", VA = "0x163235C")]
		private void Update()
		{
		}

		[Token(Token = "0x6004915")]
		[Address(RVA = "0x16323C0", Offset = "0x16323C0", VA = "0x16323C0")]
		public PuzzleSwitchTimed()
		{
		}
	}
}
