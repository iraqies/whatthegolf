using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;

[Serializable]
[Token(Token = "0x2000F2E")]
public class UserCriteria : ScriptableObject
{
	[Serializable]
	[Token(Token = "0x2000F2F")]
	[SerializeField]
	private class CampaignData
	{
		[Token(Token = "0x4005200")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public ECampaignType pack;

		[Token(Token = "0x4005201")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public bool useMinProgress;

		[Token(Token = "0x4005202")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x54054", Offset = "0x54054")]
		public int MinProgrees;

		[Token(Token = "0x4005203")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public bool useMaxProgress;

		[Token(Token = "0x4005204")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x54070", Offset = "0x54070")]
		public int MaxProgrees;

		[Token(Token = "0x4005205")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public bool useMinProgressExclusive;

		[Token(Token = "0x4005206")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x5408C", Offset = "0x5408C")]
		public int minProgressExclusive;

		[Token(Token = "0x4005207")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public bool useMaxProgressExclusive;

		[Token(Token = "0x4005208")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x540A8", Offset = "0x540A8")]
		public int maxProgressExclusive;

		[Token(Token = "0x4005209")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public bool includeChallengesInCalculation;

		[Token(Token = "0x400520A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x35")]
		public bool useMinTime;

		[Token(Token = "0x400520B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public int MinTimePlayed;

		[Token(Token = "0x400520C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public bool useMaxTime;

		[Token(Token = "0x400520D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public int MaxTimePlayed;

		[Token(Token = "0x60046F6")]
		[Address(RVA = "0x1874174", Offset = "0x1874174", VA = "0x1874174")]
		public CampaignData()
		{
		}
	}

	[Token(Token = "0x2000F30")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x45760", Offset = "0x45760")]
	private sealed class _003C_003Ec__DisplayClass38_0
	{
		[Token(Token = "0x400520E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public UserCriteria _003C_003E4__this;

		[Token(Token = "0x400520F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public bool hasFailed;

		[Token(Token = "0x60046F7")]
		[Address(RVA = "0x1872A58", Offset = "0x1872A58", VA = "0x1872A58")]
		public _003C_003Ec__DisplayClass38_0()
		{
		}

		[Token(Token = "0x60046F8")]
		[Address(RVA = "0x1872A60", Offset = "0x1872A60", VA = "0x1872A60")]
		internal void _003CDoesUserFit_003Eg__Deny_007C0(string reason)
		{
		}

		[Token(Token = "0x60046F9")]
		[Address(RVA = "0x1872AD8", Offset = "0x1872AD8", VA = "0x1872AD8")]
		internal bool _003CDoesUserFit_003Eg__CheckPack_007C4(CampaignData c)
		{
			return default;
		}
	}

	[Token(Token = "0x2000F31")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x45770", Offset = "0x45770")]
	private sealed class _003C_003Ec__DisplayClass38_1
	{
		[Token(Token = "0x4005210")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string challengeId;

		[Token(Token = "0x60046FA")]
		[Address(RVA = "0x18737E0", Offset = "0x18737E0", VA = "0x18737E0")]
		public _003C_003Ec__DisplayClass38_1()
		{
		}

		[Token(Token = "0x60046FB")]
		[Address(RVA = "0x18737E8", Offset = "0x18737E8", VA = "0x18737E8")]
		internal bool _003CDoesUserFit_003Eb__5(string x)
		{
			return default;
		}
	}

	[Serializable]
	[Token(Token = "0x2000F32")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x45780", Offset = "0x45780")]
	private sealed class _003C_003Ec
	{
		[Token(Token = "0x4005211")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static readonly _003C_003Ec _003C_003E9;

		[Token(Token = "0x4005212")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public static Func<ContentPack, bool> _003C_003E9__38_1;

		[Token(Token = "0x4005213")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public static Func<ContentPack, bool> _003C_003E9__38_2;

		[Token(Token = "0x4005214")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public static Func<ContentPack, string> _003C_003E9__41_0;

		[Token(Token = "0x4005215")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public static Func<string, string> _003C_003E9__41_1;

		[Token(Token = "0x4005216")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public static Func<ContentPack, string> _003C_003E9__41_2;

		[Token(Token = "0x60046FD")]
		[Address(RVA = "0x1872950", Offset = "0x1872950", VA = "0x1872950")]
		public _003C_003Ec()
		{
		}

		[Token(Token = "0x60046FE")]
		[Address(RVA = "0x1872958", Offset = "0x1872958", VA = "0x1872958")]
		internal bool _003CDoesUserFit_003Eb__38_1(ContentPack p)
		{
			return default;
		}

		[Token(Token = "0x60046FF")]
		[Address(RVA = "0x18729A4", Offset = "0x18729A4", VA = "0x18729A4")]
		internal bool _003CDoesUserFit_003Eb__38_2(ContentPack p)
		{
			return default;
		}

		[Token(Token = "0x6004700")]
		[Address(RVA = "0x18729EC", Offset = "0x18729EC", VA = "0x18729EC")]
		internal string _003CGenerateDescription_003Eb__41_0(ContentPack p)
		{
			return null;
		}

		[Token(Token = "0x6004701")]
		[Address(RVA = "0x1872A10", Offset = "0x1872A10", VA = "0x1872A10")]
		internal string _003CGenerateDescription_003Eb__41_1(string p)
		{
			return null;
		}

		[Token(Token = "0x6004702")]
		[Address(RVA = "0x1872A34", Offset = "0x1872A34", VA = "0x1872A34")]
		internal string _003CGenerateDescription_003Eb__41_2(ContentPack p)
		{
			return null;
		}
	}

	[Token(Token = "0x2000F33")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x45790", Offset = "0x45790")]
	private sealed class _003C_003Ec__DisplayClass41_0
	{
		[Token(Token = "0x4005217")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string res;

		[Token(Token = "0x4005218")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string lineEnd;

		[Token(Token = "0x6004703")]
		[Address(RVA = "0x187385C", Offset = "0x187385C", VA = "0x187385C")]
		public _003C_003Ec__DisplayClass41_0()
		{
		}

		[Token(Token = "0x6004704")]
		[Address(RVA = "0x1873864", Offset = "0x1873864", VA = "0x1873864")]
		internal void _003CGenerateDescription_003Eb__3(CampaignData p)
		{
		}
	}

	[Token(Token = "0x40051DC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public string UserDescription;

	[Token(Token = "0x40051DD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[SerializeField]
	private string requiredVersion;

	[Token(Token = "0x40051DE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[SerializeField]
	private bool useLastPlayed;

	[Token(Token = "0x40051DF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	[SerializeField]
	private ECampaignType lastPlayedPack;

	[Token(Token = "0x40051E0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[SerializeField]
	private bool useMinSessionCount;

	[Token(Token = "0x40051E1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	[SerializeField]
	private int minSessionCount;

	[Token(Token = "0x40051E2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	[SerializeField]
	private bool useMaxSessionCount;

	[Token(Token = "0x40051E3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	[SerializeField]
	private int maxSessionCount;

	[Token(Token = "0x40051E4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	[SerializeField]
	private List<ContentPack> NotPlayedPacks;

	[Token(Token = "0x40051E5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	[SerializeField]
	private List<ContentPack> PlayedPaks;

	[Token(Token = "0x40051E6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	[SerializeField]
	private List<string> NotPlayedSpecials;

	[Token(Token = "0x40051E7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	[SerializeField]
	private bool useMinNumDailysPlayed;

	[Token(Token = "0x40051E8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
	[SerializeField]
	private int minNumDailysPlayed;

	[Token(Token = "0x40051E9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	[SerializeField]
	private bool useMaxNumDailysPlayed;

	[Token(Token = "0x40051EA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
	[SerializeField]
	private int maxNumDailysPlayed;

	[Token(Token = "0x40051EB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	[SerializeField]
	private bool useIsImpossiblePlayed;

	[Token(Token = "0x40051EC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x69")]
	[SerializeField]
	private bool isImpossiblePlayed;

	[Token(Token = "0x40051ED")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x6A")]
	[SerializeField]
	private bool useMinPlayTime;

	[Token(Token = "0x40051EE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
	[SerializeField]
	private int minPlayTime;

	[Token(Token = "0x40051EF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	[SerializeField]
	private bool useMaxPlayTime;

	[Token(Token = "0x40051F0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
	[SerializeField]
	private int maxPlayTime;

	[Token(Token = "0x40051F1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	[SerializeField]
	private List<CampaignData> ProgressData;

	[Token(Token = "0x40051F2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	[SerializeField]
	private bool useMinSessionPlaytime;

	[Token(Token = "0x40051F3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
	[SerializeField]
	private int minSessionPlaytime;

	[Token(Token = "0x40051F4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	[SerializeField]
	private bool useMaxFailsInLastLevel;

	[Token(Token = "0x40051F5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
	[SerializeField]
	private int maxFailsInLastLevel;

	[Token(Token = "0x40051F6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	[SerializeField]
	private List<string> allowedLevelsToAskAfter;

	[Token(Token = "0x40051F7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	[SerializeField]
	[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x53F98", Offset = "0x53F98")]
	private bool useChallengeChecks;

	[Token(Token = "0x40051F8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x99")]
	[SerializeField]
	private bool requireChallengeNotPlayed;

	[Token(Token = "0x40051F9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x9A")]
	[SerializeField]
	private bool requireChallengePlayed;

	[Token(Token = "0x40051FA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x9B")]
	[SerializeField]
	private bool requireChallengeActiveToday;

	[Token(Token = "0x40051FB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	[SerializeField]
	private string requiredChallengeActiveToday;

	[Token(Token = "0x40051FC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	[SerializeField]
	private bool notPlayedTomorrowsDaily;

	[Token(Token = "0x40051FD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA9")]
	[SerializeField]
	private bool useSupportedPlatforms;

	[Token(Token = "0x40051FE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
	[SerializeField]
	private EPlatformType[] supportedPlatforms;

	[Token(Token = "0x40051FF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
	private List<string> _reasons;

	[Token(Token = "0x60046EF")]
	[Address(RVA = "0x173D960", Offset = "0x173D960", VA = "0x173D960")]
	public bool DoesUserFit([Optional][DefaultParameterValue(-1)] int fails, [Optional][DefaultParameterValue("")] string levelID, [Optional][DefaultParameterValue("")] string packName, [Optional] DateTime? day)
	{
		return default;
	}

	[Token(Token = "0x60046F0")]
	[Address(RVA = "0x173D998", Offset = "0x173D998", VA = "0x173D998")]
	public bool DoesUserFit(out List<string> reasons, [Optional][DefaultParameterValue(-1)] int fails, [Optional][DefaultParameterValue("")] string levelID, [Optional][DefaultParameterValue("")] string packName, [Optional] DateTime? day)
	{
		return default;
	}

	[Token(Token = "0x60046F1")]
	[Address(RVA = "0x173F120", Offset = "0x173F120", VA = "0x173F120")]
	public static bool IsChallengeActiveToday(string packId, DateTime dt)
	{
		return default;
	}

	[Token(Token = "0x60046F2")]
	[Address(RVA = "0x173F254", Offset = "0x173F254", VA = "0x173F254")]
	public static bool IsDailyChallengeActiveToday(string packId, DateTime dt)
	{
		return default;
	}

	[Token(Token = "0x60046F3")]
	[Address(RVA = "0x173F320", Offset = "0x173F320", VA = "0x173F320")]
	public string GenerateDescription()
	{
		return null;
	}

	[Token(Token = "0x60046F4")]
	[Address(RVA = "0x1740570", Offset = "0x1740570", VA = "0x1740570")]
	public UserCriteria()
	{
	}

	[Token(Token = "0x60046F5")]
	[Address(RVA = "0x173EFE0", Offset = "0x173EFE0", VA = "0x173EFE0")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6EB64", Offset = "0x6EB64")]
	internal static bool _003CDoesUserFit_003Eg__ChallengeIsPlayed_007C38_3(string challengeId)
	{
		return default;
	}
}
