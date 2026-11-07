using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

[Serializable]
[Token(Token = "0x2000EF5")]
public class DailyPrizeData : ScriptableObject
{
	[Serializable]
	[Token(Token = "0x2000EF6")]
	public class Prize
	{
		[Token(Token = "0x40050E7")]
		[FieldOffset(Offset = "0x10")]
		public GameObject prefab;

		[Token(Token = "0x40050E8")]
		[FieldOffset(Offset = "0x18")]
		public string ID;

		[Token(Token = "0x60045F5")]
		[Address(RVA = "0x1798F00", Offset = "0x1798F00", VA = "0x1798F00")]
		public Prize()
		{
		}
	}

	[Serializable]
	[Token(Token = "0x2000EF7")]
	public class NormalPrize : Prize
	{
		[Token(Token = "0x60045F6")]
		[Address(RVA = "0x1798EA0", Offset = "0x1798EA0", VA = "0x1798EA0")]
		public NormalPrize()
		{
		}
	}

	[Token(Token = "0x2000EF8")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x455A0", Offset = "0x455A0")]
	private sealed class _003C_003Ec__DisplayClass6_0
	{
		[Token(Token = "0x40050E9")]
		[FieldOffset(Offset = "0x10")]
		public string ID;

		[Token(Token = "0x60045F7")]
		[Address(RVA = "0x1798DC8", Offset = "0x1798DC8", VA = "0x1798DC8")]
		public _003C_003Ec__DisplayClass6_0()
		{
		}

		[Token(Token = "0x60045F8")]
		[Address(RVA = "0x1798DD0", Offset = "0x1798DD0", VA = "0x1798DD0")]
		internal bool _003CGetPrize_003Eb__1(Prize x)
		{
			return default;
		}

		[Token(Token = "0x60045F9")]
		[Address(RVA = "0x1798E7C", Offset = "0x1798E7C", VA = "0x1798E7C")]
		internal bool _003CGetPrize_003Eb__2(NormalPrize a)
		{
			return default;
		}
	}

	[Serializable]
	[Token(Token = "0x2000EF9")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x455B0", Offset = "0x455B0")]
	private sealed class _003C_003Ec
	{
		[Token(Token = "0x40050EA")]
		[FieldOffset(Offset = "0x0")]
		public static readonly _003C_003Ec _003C_003E9;

		[Token(Token = "0x40050EB")]
		[FieldOffset(Offset = "0x8")]
		public static Func<DailyChallengeLevelDataContainer, Prize> _003C_003E9__6_0;

		[Token(Token = "0x60045FB")]
		[Address(RVA = "0x1798DA8", Offset = "0x1798DA8", VA = "0x1798DA8")]
		public _003C_003Ec()
		{
		}

		[Token(Token = "0x60045FC")]
		[Address(RVA = "0x1798DB0", Offset = "0x1798DB0", VA = "0x1798DB0")]
		internal Prize _003CGetPrize_003Eb__6_0(DailyChallengeLevelDataContainer x)
		{
			return null;
		}
	}

	[Token(Token = "0x40050E4")]
	[FieldOffset(Offset = "0x18")]
	public List<NormalPrize> Prizes;

	[Token(Token = "0x40050E5")]
	[FieldOffset(Offset = "0x20")]
	public NormalPrize LockedMountainPrize;

	[Token(Token = "0x40050E6")]
	[FieldOffset(Offset = "0x28")]
	public NormalPrize EndPrizeMountain;

	[Token(Token = "0x60045F2")]
	[Address(RVA = "0x18D3128", Offset = "0x18D3128", VA = "0x18D3128")]
	public Prize GetPrize(string ID)
	{
		return null;
	}

	[Token(Token = "0x60045F3")]
	[Address(RVA = "0x18D34F4", Offset = "0x18D34F4", VA = "0x18D34F4")]
	public Prize GetNextNormalPrize(NormalPrize LastGivenNormalPrize)
	{
		return null;
	}

	[Token(Token = "0x60045F4")]
	[Address(RVA = "0x18D35D8", Offset = "0x18D35D8", VA = "0x18D35D8")]
	public DailyPrizeData()
	{
	}
}
