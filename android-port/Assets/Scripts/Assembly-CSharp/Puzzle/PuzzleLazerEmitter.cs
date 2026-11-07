using Chronos;
using Il2CppDummyDll;
using UnityEngine;

namespace Puzzle
{
	[Token(Token = "0x2001035")]
	public class PuzzleLazerEmitter : PuzzleObjectBase, ITimedPuzzleObject
	{
		[Token(Token = "0x400556F")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private LazerJoint initialLazer;

		[Token(Token = "0x4005570")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private AudioSource audioSource;

		[Token(Token = "0x4005571")]
		[FieldOffset(Offset = "0x48")]
		private ParticleSystem emitterParticles;

		[Token(Token = "0x4005572")]
		[FieldOffset(Offset = "0x50")]
		public int jointLimit;

		[Token(Token = "0x4005573")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x55560", Offset = "0x55560")]
		private LocalClock BallClock__BackingField;

		[Token(Token = "0x4005574")]
		[FieldOffset(Offset = "0x60")]
		private LazerJoint[] lazers;

		[Token(Token = "0x170007AD")]
		public LocalClock BallClock
		{
			[Token(Token = "0x6004895")]
			[Address(RVA = "0x162F5A4", Offset = "0x162F5A4", VA = "0x162F5A4", Slot = "10")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x6F044", Offset = "0x6F044")]
			get
			{
				return null;
			}
			[Token(Token = "0x6004896")]
			[Address(RVA = "0x162F5AC", Offset = "0x162F5AC", VA = "0x162F5AC")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x6F054", Offset = "0x6F054")]
			private set
			{
			}
		}

		[Token(Token = "0x6004897")]
		[Address(RVA = "0x162F5B4", Offset = "0x162F5B4", VA = "0x162F5B4", Slot = "9")]
		public void SetClock(LocalClock clock)
		{
		}

		[Token(Token = "0x6004898")]
		[Address(RVA = "0x162F5BC", Offset = "0x162F5BC", VA = "0x162F5BC", Slot = "11")]
		public float GetDeltaTime()
		{
			return default;
		}

		[Token(Token = "0x6004899")]
		[Address(RVA = "0x162F664", Offset = "0x162F664", VA = "0x162F664", Slot = "4")]
		public override void OnPrePlayOrPreCompile()
		{
		}

		[Token(Token = "0x600489A")]
		[Address(RVA = "0x162F6F0", Offset = "0x162F6F0", VA = "0x162F6F0")]
		private void Awake()
		{
		}

		[Token(Token = "0x600489B")]
		[Address(RVA = "0x162F75C", Offset = "0x162F75C", VA = "0x162F75C")]
		public void Init()
		{
		}

		[Token(Token = "0x600489C")]
		[Address(RVA = "0x162FA04", Offset = "0x162FA04", VA = "0x162FA04", Slot = "6")]
		public override void OnBallEnter(OverworldBall2D ball)
		{
		}

		[Token(Token = "0x600489D")]
		[Address(RVA = "0x162FA20", Offset = "0x162FA20", VA = "0x162FA20", Slot = "7")]
		public override void OnBallLeave()
		{
		}

		[Token(Token = "0x600489E")]
		[Address(RVA = "0x162F850", Offset = "0x162F850", VA = "0x162F850")]
		public void SetEmission(bool emit)
		{
		}

		[Token(Token = "0x600489F")]
		[Address(RVA = "0x162FA34", Offset = "0x162FA34", VA = "0x162FA34")]
		private void Update()
		{
		}

		[Token(Token = "0x60048A0")]
		[Address(RVA = "0x162FE40", Offset = "0x162FE40", VA = "0x162FE40")]
		public PuzzleLazerEmitter()
		{
		}
	}
}
