using System;
using Audio;
using Chronos;
using Il2CppDummyDll;
using UnityEngine;

namespace Puzzle
{
	[Token(Token = "0x2001037")]
	public class PuzzleBall : MonoBehaviour, ITimedPuzzleObject
	{
		[Serializable]
		[Token(Token = "0x2001038")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x475F4", Offset = "0x475F4")]
		private sealed class _003C_003Ec
		{
			[Token(Token = "0x4005581")]
			[FieldOffset(Offset = "0x0")]
			public static readonly _003C_003Ec _003C_003E9;

			[Token(Token = "0x4005582")]
			[FieldOffset(Offset = "0x8")]
			public static Action _003C_003E9__24_0;

			[Token(Token = "0x4005583")]
			[FieldOffset(Offset = "0x10")]
			public static Action _003C_003E9__24_1;

			[Token(Token = "0x4005584")]
			[FieldOffset(Offset = "0x18")]
			public static Action _003C_003E9__24_2;

			[Token(Token = "0x60048AF")]
			[Address(RVA = "0x182F1BC", Offset = "0x182F1BC", VA = "0x182F1BC")]
			public _003C_003Ec()
			{
			}

			[Token(Token = "0x60048B0")]
			[Address(RVA = "0x182F1C4", Offset = "0x182F1C4", VA = "0x182F1C4")]
			internal void _003C_002Ector_003Eb__24_0()
			{
			}

			[Token(Token = "0x60048B1")]
			[Address(RVA = "0x182F1C8", Offset = "0x182F1C8", VA = "0x182F1C8")]
			internal void _003C_002Ector_003Eb__24_1()
			{
			}

			[Token(Token = "0x60048B2")]
			[Address(RVA = "0x182F1CC", Offset = "0x182F1CC", VA = "0x182F1CC")]
			internal void _003C_002Ector_003Eb__24_2()
			{
			}
		}

		[Token(Token = "0x4005575")]
		[FieldOffset(Offset = "0x18")]
		public float force;

		[Token(Token = "0x4005576")]
		[FieldOffset(Offset = "0x1C")]
		public float angleThreshold;

		[Token(Token = "0x4005577")]
		[FieldOffset(Offset = "0x20")]
		public bool affectCollisions;

		[Token(Token = "0x4005578")]
		[FieldOffset(Offset = "0x28")]
		private Rigidbody2D rb;

		[Token(Token = "0x4005579")]
		[FieldOffset(Offset = "0x30")]
		private Vector2 velocity;

		[Token(Token = "0x400557A")]
		[FieldOffset(Offset = "0x38")]
		private float speed;

		[Token(Token = "0x400557B")]
		[FieldOffset(Offset = "0x40")]
		public RandomAudioClips bounceOnWall;

		[Token(Token = "0x400557C")]
		[FieldOffset(Offset = "0x48")]
		public RandomAudioClips bounceFail;

		[Token(Token = "0x400557D")]
		[FieldOffset(Offset = "0x50")]
		public Action OnShoot;

		[Token(Token = "0x400557E")]
		[FieldOffset(Offset = "0x58")]
		public Action OnBallFail;

		[Token(Token = "0x400557F")]
		[FieldOffset(Offset = "0x60")]
		public Action OnBallReset;

		[Token(Token = "0x4005580")]
		[FieldOffset(Offset = "0x68")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x55570", Offset = "0x55570")]
		private LocalClock BallClock__BackingField;

		[Token(Token = "0x170007AE")]
		public LocalClock BallClock
		{
			[Token(Token = "0x60048A2")]
			[Address(RVA = "0x162DA94", Offset = "0x162DA94", VA = "0x162DA94", Slot = "5")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6F064", Offset = "0x6F064")]
			get
			{
				return null;
			}
			[Token(Token = "0x60048A3")]
			[Address(RVA = "0x162DA9C", Offset = "0x162DA9C", VA = "0x162DA9C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6F074", Offset = "0x6F074")]
			set
			{
			}
		}

		[Token(Token = "0x60048A4")]
		[Address(RVA = "0x162DAA4", Offset = "0x162DAA4", VA = "0x162DAA4", Slot = "4")]
		public void SetClock(LocalClock clock)
		{
		}

		[Token(Token = "0x60048A5")]
		[Address(RVA = "0x162DAAC", Offset = "0x162DAAC", VA = "0x162DAAC", Slot = "6")]
		public float GetDeltaTime()
		{
			return default;
		}

		[Token(Token = "0x60048A6")]
		[Address(RVA = "0x162DB54", Offset = "0x162DB54", VA = "0x162DB54")]
		public void AddSpeed(float add)
		{
		}

		[Token(Token = "0x60048A7")]
		[Address(RVA = "0x162DB98", Offset = "0x162DB98", VA = "0x162DB98")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x60048A8")]
		[Address(RVA = "0x162DD20", Offset = "0x162DD20", VA = "0x162DD20")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x60048A9")]
		[Address(RVA = "0x162DD3C", Offset = "0x162DD3C", VA = "0x162DD3C")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x60048AA")]
		[Address(RVA = "0x162DD78", Offset = "0x162DD78", VA = "0x162DD78")]
		public void Shoot(Vector2 dir)
		{
		}

		[Token(Token = "0x60048AB")]
		[Address(RVA = "0x162DDA8", Offset = "0x162DDA8", VA = "0x162DDA8")]
		private void OnCollisionEnter2D(Collision2D other)
		{
		}

		[Token(Token = "0x60048AC")]
		[Address(RVA = "0x162DFB4", Offset = "0x162DFB4", VA = "0x162DFB4")]
		public void BallFail()
		{
		}

		[Token(Token = "0x60048AD")]
		[Address(RVA = "0x162E028", Offset = "0x162E028", VA = "0x162E028")]
		public PuzzleBall()
		{
		}
	}
}
