using System.Collections.Generic;
using Core;
using Il2CppDummyDll;
using UnityEngine;

namespace Audio
{
	[Token(Token = "0x2001374")]
	public class HarmonikaDyrAudio : MonoBehaviour
	{
		[Token(Token = "0x4006847")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private HarmonikaDyrShooter harmonikaDyr;

		[Token(Token = "0x4006848")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private List<AudioClip> slowMoveSequence;

		[Token(Token = "0x4006849")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private List<AudioClip> fastMoveSequence;

		[Token(Token = "0x400684A")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private float maxRate;

		[Token(Token = "0x400684B")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private AudioSource stretchLoop;

		[Token(Token = "0x400684C")]
		[FieldOffset(Offset = "0x40")]
		private int clipIndex;

		[Token(Token = "0x400684D")]
		[FieldOffset(Offset = "0x44")]
		private float rate;

		[Token(Token = "0x400684E")]
		[FieldOffset(Offset = "0x48")]
		private int increment;

		[Token(Token = "0x400684F")]
		[FieldOffset(Offset = "0x4C")]
		private float rateNextPeriod;

		[Token(Token = "0x4006850")]
		[FieldOffset(Offset = "0x50")]
		private float lastDistance;

		[Token(Token = "0x4006851")]
		[FieldOffset(Offset = "0x54")]
		private bool startedStretch;

		[Token(Token = "0x4006852")]
		[FieldOffset(Offset = "0x55")]
		private bool startedSquash;

		[Token(Token = "0x4006853")]
		[FieldOffset(Offset = "0x58")]
		private float rateSmoothVelocity;

		[Token(Token = "0x4006854")]
		[FieldOffset(Offset = "0x5C")]
		private float rateSmooth;

		[Token(Token = "0x4006855")]
		[FieldOffset(Offset = "0x60")]
		private float smoothedRate;

		[Token(Token = "0x4006856")]
		[FieldOffset(Offset = "0x64")]
		private float volume;

		[Token(Token = "0x6005ADC")]
		[Address(RVA = "0x14C3CAC", Offset = "0x14C3CAC", VA = "0x14C3CAC")]
		private void Start()
		{
		}

		[Token(Token = "0x6005ADD")]
		[Address(RVA = "0x14C3E38", Offset = "0x14C3E38", VA = "0x14C3E38")]
		private void OnAimStart()
		{
		}

		[Token(Token = "0x6005ADE")]
		[Address(RVA = "0x14C3EF0", Offset = "0x14C3EF0", VA = "0x14C3EF0")]
		private void OnShoot(Vector3 boost)
		{
		}

		[Token(Token = "0x6005ADF")]
		[Address(RVA = "0x14C3FA8", Offset = "0x14C3FA8", VA = "0x14C3FA8")]
		private void Update()
		{
		}

		[Token(Token = "0x6005AE0")]
		[Address(RVA = "0x14C40C4", Offset = "0x14C40C4", VA = "0x14C40C4")]
		private void HandleOneshots()
		{
		}

		[Token(Token = "0x6005AE1")]
		[Address(RVA = "0x14C4074", Offset = "0x14C4074", VA = "0x14C4074")]
		private void HandleRate()
		{
		}

		[Token(Token = "0x6005AE2")]
		[Address(RVA = "0x14C43BC", Offset = "0x14C43BC", VA = "0x14C43BC")]
		public HarmonikaDyrAudio()
		{
		}

		[Token(Token = "0x6005AE3")]
		[Address(RVA = "0x14C43DC", Offset = "0x14C43DC", VA = "0x14C43DC")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x724B8", Offset = "0x724B8")]
		private void _003CHandleOneshots_003Eb__20_0(AudioSource s)
		{
		}
	}
}
