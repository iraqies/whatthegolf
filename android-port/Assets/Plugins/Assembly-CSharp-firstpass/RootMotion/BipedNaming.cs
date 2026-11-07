using System;
using Il2CppDummyDll;
using UnityEngine;

namespace RootMotion
{
	[Token(Token = "0x20000E2")]
	public static class BipedNaming
	{
		[Serializable]
		[Token(Token = "0x20000E3")]
		public enum BoneType
		{
			[Token(Token = "0x40004F0")]
			Unassigned = 0,
			[Token(Token = "0x40004F1")]
			Spine = 1,
			[Token(Token = "0x40004F2")]
			Head = 2,
			[Token(Token = "0x40004F3")]
			Arm = 3,
			[Token(Token = "0x40004F4")]
			Leg = 4,
			[Token(Token = "0x40004F5")]
			Tail = 5,
			[Token(Token = "0x40004F6")]
			Eye = 6
		}

		[Serializable]
		[Token(Token = "0x20000E4")]
		public enum BoneSide
		{
			[Token(Token = "0x40004F8")]
			Center = 0,
			[Token(Token = "0x40004F9")]
			Left = 1,
			[Token(Token = "0x40004FA")]
			Right = 2
		}

		[Token(Token = "0x40004DD")]
		[FieldOffset(Offset = "0x0")]
		public static string[] typeLeft;

		[Token(Token = "0x40004DE")]
		[FieldOffset(Offset = "0x8")]
		public static string[] typeRight;

		[Token(Token = "0x40004DF")]
		[FieldOffset(Offset = "0x10")]
		public static string[] typeSpine;

		[Token(Token = "0x40004E0")]
		[FieldOffset(Offset = "0x18")]
		public static string[] typeHead;

		[Token(Token = "0x40004E1")]
		[FieldOffset(Offset = "0x20")]
		public static string[] typeArm;

		[Token(Token = "0x40004E2")]
		[FieldOffset(Offset = "0x28")]
		public static string[] typeLeg;

		[Token(Token = "0x40004E3")]
		[FieldOffset(Offset = "0x30")]
		public static string[] typeTail;

		[Token(Token = "0x40004E4")]
		[FieldOffset(Offset = "0x38")]
		public static string[] typeEye;

		[Token(Token = "0x40004E5")]
		[FieldOffset(Offset = "0x40")]
		public static string[] typeExclude;

		[Token(Token = "0x40004E6")]
		[FieldOffset(Offset = "0x48")]
		public static string[] typeExcludeSpine;

		[Token(Token = "0x40004E7")]
		[FieldOffset(Offset = "0x50")]
		public static string[] typeExcludeHead;

		[Token(Token = "0x40004E8")]
		[FieldOffset(Offset = "0x58")]
		public static string[] typeExcludeArm;

		[Token(Token = "0x40004E9")]
		[FieldOffset(Offset = "0x60")]
		public static string[] typeExcludeLeg;

		[Token(Token = "0x40004EA")]
		[FieldOffset(Offset = "0x68")]
		public static string[] typeExcludeTail;

		[Token(Token = "0x40004EB")]
		[FieldOffset(Offset = "0x70")]
		public static string[] typeExcludeEye;

		[Token(Token = "0x40004EC")]
		[FieldOffset(Offset = "0x78")]
		public static string[] pelvis;

		[Token(Token = "0x40004ED")]
		[FieldOffset(Offset = "0x80")]
		public static string[] hand;

		[Token(Token = "0x40004EE")]
		[FieldOffset(Offset = "0x88")]
		public static string[] foot;

		[Token(Token = "0x60005AE")]
		[Address(RVA = "0x13026A8", Offset = "0x13026A8", VA = "0x13026A8")]
		public static Transform[] GetBonesOfType(BoneType boneType, Transform[] bones)
		{
			return null;
		}

		[Token(Token = "0x60005AF")]
		[Address(RVA = "0x13029D4", Offset = "0x13029D4", VA = "0x13029D4")]
		public static Transform[] GetBonesOfSide(BoneSide boneSide, Transform[] bones)
		{
			return null;
		}

		[Token(Token = "0x60005B0")]
		[Address(RVA = "0x1302C50", Offset = "0x1302C50", VA = "0x1302C50")]
		public static Transform[] GetBonesOfTypeAndSide(BoneType boneType, BoneSide boneSide, Transform[] bones)
		{
			return null;
		}

		[Token(Token = "0x60005B1")]
		[Address(RVA = "0x1302CE8", Offset = "0x1302CE8", VA = "0x1302CE8")]
		public static Transform GetNamingMatch(Transform[] transforms, params string[][] namings)
		{
			return null;
		}

		[Token(Token = "0x60005B2")]
		[Address(RVA = "0x1302880", Offset = "0x1302880", VA = "0x1302880")]
		public static BoneType GetBoneType(string boneName)
		{
			return default;
		}

		[Token(Token = "0x60005B3")]
		[Address(RVA = "0x1302BAC", Offset = "0x1302BAC", VA = "0x1302BAC")]
		public static BoneSide GetBoneSide(string boneName)
		{
			return default;
		}

		[Token(Token = "0x60005B4")]
		[Address(RVA = "0x1303894", Offset = "0x1303894", VA = "0x1303894")]
		public static Transform GetBone(Transform[] transforms, BoneType boneType, BoneSide boneSide = BoneSide.Center, params string[][] namings)
		{
			return null;
		}

		[Token(Token = "0x60005B5")]
		[Address(RVA = "0x1303574", Offset = "0x1303574", VA = "0x1303574")]
		private static bool isLeft(string boneName)
		{
			return default;
		}

		[Token(Token = "0x60005B6")]
		[Address(RVA = "0x1303704", Offset = "0x1303704", VA = "0x1303704")]
		private static bool isRight(string boneName)
		{
			return default;
		}

		[Token(Token = "0x60005B7")]
		[Address(RVA = "0x1302F44", Offset = "0x1302F44", VA = "0x1302F44")]
		private static bool isSpine(string boneName)
		{
			return default;
		}

		[Token(Token = "0x60005B8")]
		[Address(RVA = "0x130304C", Offset = "0x130304C", VA = "0x130304C")]
		private static bool isHead(string boneName)
		{
			return default;
		}

		[Token(Token = "0x60005B9")]
		[Address(RVA = "0x1303154", Offset = "0x1303154", VA = "0x1303154")]
		private static bool isArm(string boneName)
		{
			return default;
		}

		[Token(Token = "0x60005BA")]
		[Address(RVA = "0x130325C", Offset = "0x130325C", VA = "0x130325C")]
		private static bool isLeg(string boneName)
		{
			return default;
		}

		[Token(Token = "0x60005BB")]
		[Address(RVA = "0x1303364", Offset = "0x1303364", VA = "0x1303364")]
		private static bool isTail(string boneName)
		{
			return default;
		}

		[Token(Token = "0x60005BC")]
		[Address(RVA = "0x130346C", Offset = "0x130346C", VA = "0x130346C")]
		private static bool isEye(string boneName)
		{
			return default;
		}

		[Token(Token = "0x60005BD")]
		[Address(RVA = "0x1302E18", Offset = "0x1302E18", VA = "0x1302E18")]
		private static bool matchesNaming(string boneName, string[] namingConvention)
		{
			return default;
		}

		[Token(Token = "0x60005BE")]
		[Address(RVA = "0x1303A54", Offset = "0x1303A54", VA = "0x1303A54")]
		private static bool excludesNaming(string boneName, string[] namingConvention)
		{
			return default;
		}

		[Token(Token = "0x60005BF")]
		[Address(RVA = "0x13039D8", Offset = "0x13039D8", VA = "0x13039D8")]
		private static string firstLetter(string boneName)
		{
			return null;
		}

		[Token(Token = "0x60005C0")]
		[Address(RVA = "0x1303960", Offset = "0x1303960", VA = "0x1303960")]
		private static string lastLetter(string boneName)
		{
			return null;
		}
	}
}
