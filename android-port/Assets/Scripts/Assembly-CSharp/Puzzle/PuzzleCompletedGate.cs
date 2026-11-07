using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Tilemaps;

namespace Puzzle
{
	[Token(Token = "0x200104D")]
	public class PuzzleCompletedGate : PuzzleObjectBase
	{
		[Token(Token = "0x200104E")]
		public enum ButtonType
		{
			[Token(Token = "0x40055F0")]
			fromLeft = 0,
			[Token(Token = "0x40055F1")]
			fromRight = 1,
			[Token(Token = "0x40055F2")]
			fromBelow = 2
		}

		[Serializable]
		[Token(Token = "0x200104F")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x47724", Offset = "0x47724")]
		private sealed class _003C_003Ec
		{
			[Token(Token = "0x40055F3")]
			[FieldOffset(Offset = "0x0")]
			public static readonly _003C_003Ec _003C_003E9;

			[Token(Token = "0x40055F4")]
			[FieldOffset(Offset = "0x8")]
			public static Action<AudioSource> _003C_003E9__17_0;

			[Token(Token = "0x40055F5")]
			[FieldOffset(Offset = "0x10")]
			public static Action<AudioSource> _003C_003E9__17_1;

			[Token(Token = "0x600491E")]
			[Address(RVA = "0x182F230", Offset = "0x182F230", VA = "0x182F230")]
			public _003C_003Ec()
			{
			}

			[Token(Token = "0x600491F")]
			[Address(RVA = "0x182F238", Offset = "0x182F238", VA = "0x182F238")]
			internal void _003COpenDoor_003Eb__17_0(AudioSource s)
			{
			}

			[Token(Token = "0x6004920")]
			[Address(RVA = "0x182F23C", Offset = "0x182F23C", VA = "0x182F23C")]
			internal void _003COpenDoor_003Eb__17_1(AudioSource s)
			{
			}
		}

		[Token(Token = "0x40055E2")]
		[FieldOffset(Offset = "0x34")]
		public int flagsRequiredOffset;

		[Token(Token = "0x40055E3")]
		[FieldOffset(Offset = "0x38")]
		public ParticleSystem openParticles;

		[Token(Token = "0x40055E4")]
		[FieldOffset(Offset = "0x40")]
		public ButtonType orientation;

		[Token(Token = "0x40055E5")]
		[FieldOffset(Offset = "0x48")]
		public AudioClip sfxOnOpen;

		[Token(Token = "0x40055E6")]
		[FieldOffset(Offset = "0x50")]
		public AudioClip sfxExplosion;

		[Token(Token = "0x40055E7")]
		[FieldOffset(Offset = "0x58")]
		public AudioClip sfxOnHint;

		[Token(Token = "0x40055E8")]
		[FieldOffset(Offset = "0x60")]
		public bool isTilted;

		[Token(Token = "0x40055E9")]
		[FieldOffset(Offset = "0x68")]
		public OverworldDoor HorizontalDoor;

		[Token(Token = "0x40055EA")]
		[FieldOffset(Offset = "0x70")]
		public OverworldDoor VerticalDoor;

		[Token(Token = "0x40055EB")]
		[FieldOffset(Offset = "0x78")]
		public TrailRenderer HintTemplate;

		[Token(Token = "0x40055EC")]
		[FieldOffset(Offset = "0x80")]
		private Tilemap tileMap;

		[Token(Token = "0x40055ED")]
		[FieldOffset(Offset = "0x88")]
		private OverworldDoor door;

		[Token(Token = "0x40055EE")]
		[FieldOffset(Offset = "0x90")]
		private bool openOrOpening;

		[Token(Token = "0x6004916")]
		[Address(RVA = "0x162E99C", Offset = "0x162E99C", VA = "0x162E99C", Slot = "5")]
		public override void ResetObject()
		{
		}

		[Token(Token = "0x6004917")]
		[Address(RVA = "0x162E9A0", Offset = "0x162E9A0", VA = "0x162E9A0", Slot = "8")]
		public override void Trigger(bool active)
		{
		}

		[Token(Token = "0x6004918")]
		[Address(RVA = "0x162ECC4", Offset = "0x162ECC4", VA = "0x162ECC4")]
		public void Init(Tilemap tilemap)
		{
		}

		[Token(Token = "0x6004919")]
		[Address(RVA = "0x162E9A4", Offset = "0x162E9A4", VA = "0x162E9A4")]
		public void OpenDoor()
		{
		}

		[Token(Token = "0x600491A")]
		[Address(RVA = "0x162F030", Offset = "0x162F030", VA = "0x162F030")]
		public bool IsOpenOrOpening()
		{
			return default;
		}

		[Token(Token = "0x600491B")]
		[Address(RVA = "0x162F038", Offset = "0x162F038", VA = "0x162F038")]
		public PuzzleCompletedGate()
		{
		}

		[Token(Token = "0x600491C")]
		[Address(RVA = "0x162F050", Offset = "0x162F050", VA = "0x162F050")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6F1F4", Offset = "0x6F1F4")]
		private void _003COpenDoor_003Eb__17_2()
		{
		}
	}
}
