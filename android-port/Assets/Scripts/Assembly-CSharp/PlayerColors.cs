using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000144")]
public class PlayerColors : ScriptableObject
{
	[Token(Token = "0x2000145")]
	public enum AvatarIDs
	{
		[Token(Token = "0x40005AD")]
		All = 0,
		[Token(Token = "0x40005AE")]
		Toaster = 1,
		[Token(Token = "0x40005AF")]
		HockeyDog = 2,
		[Token(Token = "0x40005B0")]
		BurgerBird = 3,
		[Token(Token = "0x40005B1")]
		BabyVike = 4
	}

	[Serializable]
	[Token(Token = "0x2000146")]
	public class AvatarData
	{
		[Token(Token = "0x40005B2")]
		[FieldOffset(Offset = "0x10")]
		public AvatarIDs AvatarID;

		[Token(Token = "0x40005B3")]
		[FieldOffset(Offset = "0x18")]
		public string NameID;

		[Token(Token = "0x40005B4")]
		[FieldOffset(Offset = "0x20")]
		public bool UnlockedAtStart;

		[Token(Token = "0x40005B5")]
		[FieldOffset(Offset = "0x24")]
		public Color BaseColor;

		[Token(Token = "0x40005B6")]
		[FieldOffset(Offset = "0x34")]
		public Color ArrowColor;

		[Token(Token = "0x40005B7")]
		[FieldOffset(Offset = "0x44")]
		public Color ArrowColorMin;

		[Token(Token = "0x40005B8")]
		[FieldOffset(Offset = "0x54")]
		public Color StrokeCounterColor;

		[Token(Token = "0x40005B9")]
		[FieldOffset(Offset = "0x64")]
		public Color IntroBackgroundColor;

		[Token(Token = "0x600057F")]
		[Address(RVA = "0x1828ED4", Offset = "0x1828ED4", VA = "0x1828ED4")]
		public AvatarData()
		{
		}
	}

	[Token(Token = "0x40005AB")]
	[FieldOffset(Offset = "0x18")]
	public List<AvatarData> Avatars;

	[Token(Token = "0x600057E")]
	[Address(RVA = "0x15F7EF4", Offset = "0x15F7EF4", VA = "0x15F7EF4")]
	public PlayerColors()
	{
	}
}
