using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace Audio
{
	[Token(Token = "0x200137D")]
	public class KatamariAudio : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x200137E")]
		public class CactusAudioTiers
		{
			[Token(Token = "0x4006898")]
			[FieldOffset(Offset = "0x10")]
			public int minAmount;

			[Token(Token = "0x4006899")]
			[FieldOffset(Offset = "0x14")]
			public int maxAmount;

			[Token(Token = "0x400689A")]
			[FieldOffset(Offset = "0x18")]
			public OnCollisionAudioRemote collisionAudio;

			[Token(Token = "0x6005B11")]
			[Address(RVA = "0x17CC850", Offset = "0x17CC850", VA = "0x17CC850")]
			public CactusAudioTiers()
			{
			}
		}

		[Token(Token = "0x4006894")]
		[FieldOffset(Offset = "0x18")]
		public Rigidbody2D katamari;

		[Token(Token = "0x4006895")]
		[FieldOffset(Offset = "0x20")]
		public RandomAudioClips attachClips;

		[Token(Token = "0x4006896")]
		[FieldOffset(Offset = "0x28")]
		public List<CactusAudioTiers> cactusAudios;

		[Token(Token = "0x4006897")]
		[FieldOffset(Offset = "0x30")]
		private int cacti;

		[Token(Token = "0x6005B0C")]
		[Address(RVA = "0x14FA3F0", Offset = "0x14FA3F0", VA = "0x14FA3F0")]
		private void Awake()
		{
		}

		[Token(Token = "0x6005B0D")]
		[Address(RVA = "0x14FA498", Offset = "0x14FA498", VA = "0x14FA498")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6005B0E")]
		[Address(RVA = "0x14FA594", Offset = "0x14FA594", VA = "0x14FA594")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6005B0F")]
		[Address(RVA = "0x14FA690", Offset = "0x14FA690", VA = "0x14FA690")]
		private void KatamariCactus2D_OnAttach(KatamariCactus2D arg1, Rigidbody2D arg2)
		{
		}

		[Token(Token = "0x6005B10")]
		[Address(RVA = "0x14FA7A4", Offset = "0x14FA7A4", VA = "0x14FA7A4")]
		public KatamariAudio()
		{
		}
	}
}
