using System;
using System.Collections.Generic;
using Core;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000028")]
public class RuntimeStoreData : ScriptableObject
{
	[Token(Token = "0x2000029")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3D2A0", Offset = "0x3D2A0")]
	private sealed class _003C_003Ec__DisplayClass21_0
	{
		[Token(Token = "0x40000A0")]
		[FieldOffset(Offset = "0x10")]
		public string contentPackID;

		[Token(Token = "0x60000A6")]
		[Address(RVA = "0x183750C", Offset = "0x183750C", VA = "0x183750C")]
		public _003C_003Ec__DisplayClass21_0()
		{
		}

		[Token(Token = "0x60000A7")]
		[Address(RVA = "0x1837514", Offset = "0x1837514", VA = "0x1837514")]
		internal bool _003CTryGetContent_003Eb__0(ContentPackDef d)
		{
			return default;
		}
	}

	[Token(Token = "0x200002A")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3D2B0", Offset = "0x3D2B0")]
	private sealed class _003C_003Ec__DisplayClass22_0
	{
		[Token(Token = "0x40000A1")]
		[FieldOffset(Offset = "0x10")]
		public ECampaignType type;

		[Token(Token = "0x60000A8")]
		[Address(RVA = "0x1837544", Offset = "0x1837544", VA = "0x1837544")]
		public _003C_003Ec__DisplayClass22_0()
		{
		}

		[Token(Token = "0x60000A9")]
		[Address(RVA = "0x183754C", Offset = "0x183754C", VA = "0x183754C")]
		internal bool _003CTryGetContent_003Eb__0(ContentPackDef d)
		{
			return default;
		}
	}

	[Serializable]
	[Token(Token = "0x200002B")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3D2C0", Offset = "0x3D2C0")]
	private sealed class _003C_003Ec
	{
		[Token(Token = "0x40000A2")]
		[FieldOffset(Offset = "0x0")]
		public static readonly _003C_003Ec _003C_003E9;

		[Token(Token = "0x40000A3")]
		[FieldOffset(Offset = "0x8")]
		public static Func<DailyChallengeLevelDataContainer, int> _003C_003E9__42_0;

		[Token(Token = "0x40000A4")]
		[FieldOffset(Offset = "0x10")]
		public static Func<DailyChallengeLevelDataContainer, DayOfWeek> _003C_003E9__42_1;

		[Token(Token = "0x40000A5")]
		[FieldOffset(Offset = "0x18")]
		public static Func<DailyChallengeLevelDataContainer, DailyChallengeLevelDataContainer> _003C_003E9__42_2;

		[Token(Token = "0x40000A6")]
		[FieldOffset(Offset = "0x20")]
		public static Func<DayOfWeek, IEnumerable<DailyChallengeLevelDataContainer>, DailyChallengeLevelDataContainer[]> _003C_003E9__42_3;

		[Token(Token = "0x60000AB")]
		[Address(RVA = "0x1837474", Offset = "0x1837474", VA = "0x1837474")]
		public _003C_003Ec()
		{
		}

		[Token(Token = "0x60000AC")]
		[Address(RVA = "0x183747C", Offset = "0x183747C", VA = "0x183747C")]
		internal int _003Cget_Dailies_003Eb__42_0(DailyChallengeLevelDataContainer x)
		{
			return default;
		}

		[Token(Token = "0x60000AD")]
		[Address(RVA = "0x1837498", Offset = "0x1837498", VA = "0x1837498")]
		internal DayOfWeek _003Cget_Dailies_003Eb__42_1(DailyChallengeLevelDataContainer x)
		{
			return default;
		}

		[Token(Token = "0x60000AE")]
		[Address(RVA = "0x18374B0", Offset = "0x18374B0", VA = "0x18374B0")]
		internal DailyChallengeLevelDataContainer _003Cget_Dailies_003Eb__42_2(DailyChallengeLevelDataContainer x)
		{
			return null;
		}

		[Token(Token = "0x60000AF")]
		[Address(RVA = "0x18374B8", Offset = "0x18374B8", VA = "0x18374B8")]
		internal DailyChallengeLevelDataContainer[] _003Cget_Dailies_003Eb__42_3(DayOfWeek dayOfWeek, IEnumerable<DailyChallengeLevelDataContainer> containers)
		{
			return null;
		}
	}

	[Token(Token = "0x400008F")]
	private const string ASSET_PATH = "Assets/Resources/RuntimeStoreData.asset";

	[Token(Token = "0x4000090")]
	[FieldOffset(Offset = "0x18")]
	public Store storeType;

	[Token(Token = "0x4000091")]
	[FieldOffset(Offset = "0x1C")]
	public EPlatformType editorOverridePlatformType;

	[Token(Token = "0x4000092")]
	[FieldOffset(Offset = "0x20")]
	public List<ContentPackDef> contentPacksDefs;

	[Token(Token = "0x4000093")]
	[FieldOffset(Offset = "0x28")]
	public List<UpdateInfo> updateInfos;

	[Token(Token = "0x4000094")]
	[FieldOffset(Offset = "0x30")]
	public PlatformSettings.OnlineLeaderboardType onlineLeaderboardType;

	[Token(Token = "0x4000095")]
	[FieldOffset(Offset = "0x34")]
	public bool leaderboardsAutologin;

	[Token(Token = "0x4000096")]
	[FieldOffset(Offset = "0x35")]
	public bool supportsAchievements;

	[Token(Token = "0x4000097")]
	[FieldOffset(Offset = "0x36")]
	public bool supportsAnalytics;

	[Token(Token = "0x4000098")]
	[FieldOffset(Offset = "0x37")]
	public bool analyticsRequiresConsent;

	[Token(Token = "0x4000099")]
	[FieldOffset(Offset = "0x38")]
	public int analyticsBatchSize;

	[Token(Token = "0x400009A")]
	[FieldOffset(Offset = "0x3C")]
	public float analyticsCacheDurationHours;

	[Token(Token = "0x400009B")]
	[FieldOffset(Offset = "0x40")]
	public bool allowCustomizedOutboundLinks;

	[Token(Token = "0x400009C")]
	[FieldOffset(Offset = "0x41")]
	public bool notificationsEnabled;

	[Token(Token = "0x400009D")]
	[FieldOffset(Offset = "0x0")]
	private static RuntimeStoreData _instance;

	[Token(Token = "0x400009E")]
	[FieldOffset(Offset = "0x8")]
	private static Dictionary<string, ContentPackDef> _contentLookup;

	[Token(Token = "0x400009F")]
	[FieldOffset(Offset = "0x10")]
	private static List<DailyChallengeLevelDataContainer[]> _dailyChallenges;

	[Token(Token = "0x17000022")]
	private static Dictionary<string, ContentPackDef> ContentLookup
	{
		[Token(Token = "0x6000097")]
		[Address(RVA = "0x1664D00", Offset = "0x1664D00", VA = "0x1664D00")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000023")]
	public static RuntimeStoreData instance
	{
		[Token(Token = "0x6000098")]
		[Address(RVA = "0x1664D9C", Offset = "0x1664D9C", VA = "0x1664D9C")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000024")]
	public ContentPackDef mainCampaignPackDef
	{
		[Token(Token = "0x600009C")]
		[Address(RVA = "0x16655D4", Offset = "0x16655D4", VA = "0x16655D4")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000025")]
	public ContentPack mainCampaignPack
	{
		[Token(Token = "0x600009D")]
		[Address(RVA = "0x1665630", Offset = "0x1665630", VA = "0x1665630")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000026")]
	public ContentPack secondOnboarding
	{
		[Token(Token = "0x600009E")]
		[Address(RVA = "0x1665694", Offset = "0x1665694", VA = "0x1665694")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000027")]
	public ContentPack mainOnboardingPack
	{
		[Token(Token = "0x600009F")]
		[Address(RVA = "0x16656F4", Offset = "0x16656F4", VA = "0x16656F4")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000028")]
	public ContentPackDef dailyChallengePack
	{
		[Token(Token = "0x60000A0")]
		[Address(RVA = "0x1665754", Offset = "0x1665754", VA = "0x1665754")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000029")]
	public ContentPackDef specialEventsPack
	{
		[Token(Token = "0x60000A1")]
		[Address(RVA = "0x16657AC", Offset = "0x16657AC", VA = "0x16657AC")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700002A")]
	public static DailyChallengeLevelDataContainerContainer DailyPackContainer
	{
		[Token(Token = "0x60000A2")]
		[Address(RVA = "0x1665804", Offset = "0x1665804", VA = "0x1665804")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700002B")]
	public static DailyChallengeLevelDataContainerContainer SpecialPackContainer
	{
		[Token(Token = "0x60000A3")]
		[Address(RVA = "0x16658DC", Offset = "0x16658DC", VA = "0x16658DC")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700002C")]
	public static List<DailyChallengeLevelDataContainer[]> Dailies
	{
		[Token(Token = "0x60000A4")]
		[Address(RVA = "0x16659B4", Offset = "0x16659B4", VA = "0x16659B4")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6000096")]
	[Address(RVA = "0x1664C20", Offset = "0x1664C20", VA = "0x1664C20")]
	public EPlatformType GetPlatformType(bool isBuilding)
	{
		return default;
	}

	[Token(Token = "0x6000099")]
	[Address(RVA = "0x1664F10", Offset = "0x1664F10", VA = "0x1664F10")]
	public ContentPackDef TryGetContent(string contentPackID)
	{
		return null;
	}

	[Token(Token = "0x600009A")]
	[Address(RVA = "0x166517C", Offset = "0x166517C", VA = "0x166517C")]
	private ContentPackDef TryGetContent(string key, ECampaignType type)
	{
		return null;
	}

	[Token(Token = "0x600009B")]
	[Address(RVA = "0x16653E0", Offset = "0x16653E0", VA = "0x16653E0")]
	public List<ContentPackDef> GetCampaignPackDefs()
	{
		return null;
	}

	[Token(Token = "0x60000A5")]
	[Address(RVA = "0x1665DE8", Offset = "0x1665DE8", VA = "0x1665DE8")]
	public RuntimeStoreData()
	{
	}
}
