using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Core;
using Il2CppDummyDll;

[Token(Token = "0x2000B4F")]
public class SaveGame
{
	[Token(Token = "0x2000B50")]
	public class OverWorldData
	{
		[Token(Token = "0x4003F11")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string prefix;

		[Token(Token = "0x4003F12")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string ONBOARDING_COMPLETED;

		[Token(Token = "0x4003F13")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public string INTRO_ANIMATION_COMPLETED;

		[Token(Token = "0x4003F14")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public string OPEN_DOORS;

		[Token(Token = "0x4003F15")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public string CONSOLES_HIT;

		[Token(Token = "0x4003F16")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public string OPEN_MAIN_DOORS;

		[Token(Token = "0x4003F17")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public string COMPLETED_LEVELS;

		[Token(Token = "0x4003F18")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public string ACCESSIBLE_LEVELS;

		[Token(Token = "0x4003F19")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public string LEVEL_NOTIFICATIONS;

		[Token(Token = "0x4003F1A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public string COMPLETED_CHALLENGES;

		[Token(Token = "0x4003F1B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public string UNLOCKED_CHESTS;

		[Token(Token = "0x4003F1C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public string CROWN_AWARENESS_MODE;

		[Token(Token = "0x4003F1D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public string SAVE_POSITION;

		[Token(Token = "0x4003F1E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public string SAVE_POSITION_SHAPE;

		[Token(Token = "0x4003F1F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public string TIME_PLAYED;

		[Token(Token = "0x4003F20")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public string TIME_PLAYED_0_PCT;

		[Token(Token = "0x4003F21")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public string TIME_PLAYED_50_PCT;

		[Token(Token = "0x4003F22")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public string TIME_PLAYED_75_PCT;

		[Token(Token = "0x4003F23")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		public string TIME_PLAYED_100_PCT;

		[Token(Token = "0x4003F24")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		public string OVERWORLD_STROKES;

		[Token(Token = "0x4003F25")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		public string OVERWORLD_STROKES_0_PCT;

		[Token(Token = "0x4003F26")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		public string OVERWORLD_STROKES_50_PCT;

		[Token(Token = "0x4003F27")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		public string OVERWORLD_STROKES_75_PCT;

		[Token(Token = "0x4003F28")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		public string OVERWORLD_STROKES_100_PCT;

		[Token(Token = "0x170005A7")]
		public string SavePosition
		{
			[Token(Token = "0x600365B")]
			[Address(RVA = "0x183B1E4", Offset = "0x183B1E4", VA = "0x183B1E4")]
			get
			{
				return null;
			}
			[Token(Token = "0x600365C")]
			[Address(RVA = "0x183B278", Offset = "0x183B278", VA = "0x183B278")]
			set
			{
			}
		}

		[Token(Token = "0x170005A8")]
		public string SavePositionShape
		{
			[Token(Token = "0x600365D")]
			[Address(RVA = "0x183B31C", Offset = "0x183B31C", VA = "0x183B31C")]
			get
			{
				return null;
			}
			[Token(Token = "0x600365E")]
			[Address(RVA = "0x183B3B0", Offset = "0x183B3B0", VA = "0x183B3B0")]
			set
			{
			}
		}

		[Token(Token = "0x170005A9")]
		public int TimePlayed
		{
			[Token(Token = "0x600365F")]
			[Address(RVA = "0x1839870", Offset = "0x1839870", VA = "0x1839870")]
			get
			{
				return default;
			}
			[Token(Token = "0x6003660")]
			[Address(RVA = "0x183B454", Offset = "0x183B454", VA = "0x183B454")]
			set
			{
			}
		}

		[Token(Token = "0x170005AA")]
		public int TimePlayed0Pct
		{
			[Token(Token = "0x6003661")]
			[Address(RVA = "0x183B4F8", Offset = "0x183B4F8", VA = "0x183B4F8")]
			get
			{
				return default;
			}
			[Token(Token = "0x6003662")]
			[Address(RVA = "0x183B58C", Offset = "0x183B58C", VA = "0x183B58C")]
			set
			{
			}
		}

		[Token(Token = "0x170005AB")]
		public int TimePlayed50Pct
		{
			[Token(Token = "0x6003663")]
			[Address(RVA = "0x183B630", Offset = "0x183B630", VA = "0x183B630")]
			get
			{
				return default;
			}
			[Token(Token = "0x6003664")]
			[Address(RVA = "0x183B6C4", Offset = "0x183B6C4", VA = "0x183B6C4")]
			set
			{
			}
		}

		[Token(Token = "0x170005AC")]
		public int TimePlayed75Pct
		{
			[Token(Token = "0x6003665")]
			[Address(RVA = "0x183B768", Offset = "0x183B768", VA = "0x183B768")]
			get
			{
				return default;
			}
			[Token(Token = "0x6003666")]
			[Address(RVA = "0x183B7FC", Offset = "0x183B7FC", VA = "0x183B7FC")]
			set
			{
			}
		}

		[Token(Token = "0x170005AD")]
		public int TimePlayed100Pct
		{
			[Token(Token = "0x6003667")]
			[Address(RVA = "0x183B8A0", Offset = "0x183B8A0", VA = "0x183B8A0")]
			get
			{
				return default;
			}
			[Token(Token = "0x6003668")]
			[Address(RVA = "0x183B934", Offset = "0x183B934", VA = "0x183B934")]
			set
			{
			}
		}

		[Token(Token = "0x170005AE")]
		public int OverworldStrokes
		{
			[Token(Token = "0x6003669")]
			[Address(RVA = "0x18399C0", Offset = "0x18399C0", VA = "0x18399C0")]
			get
			{
				return default;
			}
			[Token(Token = "0x600366A")]
			[Address(RVA = "0x183B9D8", Offset = "0x183B9D8", VA = "0x183B9D8")]
			set
			{
			}
		}

		[Token(Token = "0x170005AF")]
		public int OverworldStrokes0Pct
		{
			[Token(Token = "0x600366B")]
			[Address(RVA = "0x183BA7C", Offset = "0x183BA7C", VA = "0x183BA7C")]
			get
			{
				return default;
			}
			[Token(Token = "0x600366C")]
			[Address(RVA = "0x183BB10", Offset = "0x183BB10", VA = "0x183BB10")]
			set
			{
			}
		}

		[Token(Token = "0x170005B0")]
		public int OverworldStrokes50Pct
		{
			[Token(Token = "0x600366D")]
			[Address(RVA = "0x183BBB4", Offset = "0x183BBB4", VA = "0x183BBB4")]
			get
			{
				return default;
			}
			[Token(Token = "0x600366E")]
			[Address(RVA = "0x183BC48", Offset = "0x183BC48", VA = "0x183BC48")]
			set
			{
			}
		}

		[Token(Token = "0x170005B1")]
		public int OverworldStrokes75Pct
		{
			[Token(Token = "0x600366F")]
			[Address(RVA = "0x183BCEC", Offset = "0x183BCEC", VA = "0x183BCEC")]
			get
			{
				return default;
			}
			[Token(Token = "0x6003670")]
			[Address(RVA = "0x183BD80", Offset = "0x183BD80", VA = "0x183BD80")]
			set
			{
			}
		}

		[Token(Token = "0x170005B2")]
		public int OverworldStrokes100Pct
		{
			[Token(Token = "0x6003671")]
			[Address(RVA = "0x183BE24", Offset = "0x183BE24", VA = "0x183BE24")]
			get
			{
				return default;
			}
			[Token(Token = "0x6003672")]
			[Address(RVA = "0x183BEB8", Offset = "0x183BEB8", VA = "0x183BEB8")]
			set
			{
			}
		}

		[Token(Token = "0x600365A")]
		[Address(RVA = "0x183ADBC", Offset = "0x183ADBC", VA = "0x183ADBC")]
		public OverWorldData(string prefix)
		{
		}
	}

	[Serializable]
	[Token(Token = "0x2000B51")]
	public class SaveSlot : Dictionary<string, object>
	{
		[Token(Token = "0x6003673")]
		[Address(RVA = "0x183D95C", Offset = "0x183D95C", VA = "0x183D95C")]
		public SaveSlot()
		{
		}
	}

	[Serializable]
	[Token(Token = "0x2000B52")]
	public class SaveData : Dictionary<int, SaveSlot>
	{
		[Token(Token = "0x2000B53")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x437A0", Offset = "0x437A0")]
		private sealed class _003C_003Ec__DisplayClass22_0
		{
			[Token(Token = "0x4003F2A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public string jsonString;

			[Token(Token = "0x6003688")]
			[Address(RVA = "0x1882E44", Offset = "0x1882E44", VA = "0x1882E44")]
			public _003C_003Ec__DisplayClass22_0()
			{
			}

			[Token(Token = "0x6003689")]
			[Address(RVA = "0x1882E4C", Offset = "0x1882E4C", VA = "0x1882E4C")]
			internal string _003CFromBytes_003Eb__0()
			{
				return null;
			}
		}

		[Token(Token = "0x4003F29")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public DateTime created;

		[Token(Token = "0x170005B3")]
		public Guid UUID
		{
			[Token(Token = "0x6003674")]
			[Address(RVA = "0x183BF5C", Offset = "0x183BF5C", VA = "0x183BF5C")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x170005B4")]
		public long CloudMegaMergeTimestamp
		{
			[Token(Token = "0x6003676")]
			[Address(RVA = "0x183C2B0", Offset = "0x183C2B0", VA = "0x183C2B0")]
			get
			{
				return default;
			}
			[Token(Token = "0x6003677")]
			[Address(RVA = "0x183C3B4", Offset = "0x183C3B4", VA = "0x183C3B4")]
			set
			{
			}
		}

		[Token(Token = "0x170005B5")]
		public string DeviceName
		{
			[Token(Token = "0x6003678")]
			[Address(RVA = "0x183C50C", Offset = "0x183C50C", VA = "0x183C50C")]
			get
			{
				return null;
			}
			[Token(Token = "0x6003679")]
			[Address(RVA = "0x183C5F8", Offset = "0x183C5F8", VA = "0x183C5F8")]
			set
			{
			}
		}

		[Token(Token = "0x170005B6")]
		public string DeviceModel
		{
			[Token(Token = "0x600367A")]
			[Address(RVA = "0x183C70C", Offset = "0x183C70C", VA = "0x183C70C")]
			get
			{
				return null;
			}
			[Token(Token = "0x600367B")]
			[Address(RVA = "0x183C7F8", Offset = "0x183C7F8", VA = "0x183C7F8")]
			set
			{
			}
		}

		[Token(Token = "0x170005B7")]
		public DateTime SaveTime
		{
			[Token(Token = "0x600367E")]
			[Address(RVA = "0x183CADC", Offset = "0x183CADC", VA = "0x183CADC")]
			get
			{
				return default;
			}
			[Token(Token = "0x600367F")]
			[Address(RVA = "0x183CD00", Offset = "0x183CD00", VA = "0x183CD00")]
			set
			{
			}
		}

		[Token(Token = "0x6003675")]
		[Address(RVA = "0x183C0B4", Offset = "0x183C0B4", VA = "0x183C0B4")]
		public void UpdateUUID()
		{
		}

		[Token(Token = "0x600367C")]
		[Address(RVA = "0x183C90C", Offset = "0x183C90C", VA = "0x183C90C")]
		public bool HasValidSave()
		{
			return default;
		}

		[Token(Token = "0x600367D")]
		[Address(RVA = "0x183C9D4", Offset = "0x183C9D4", VA = "0x183C9D4")]
		public bool IsFirstTime()
		{
			return default;
		}

		[Token(Token = "0x6003680")]
		[Address(RVA = "0x183CEEC", Offset = "0x183CEEC", VA = "0x183CEEC")]
		public int GetPartyWeight(string id, int fallback = int.MinValue)
		{
			return default;
		}

		[Token(Token = "0x6003681")]
		[Address(RVA = "0x183D014", Offset = "0x183D014", VA = "0x183D014")]
		public void DeletePartyWeight(string id)
		{
		}

		[Token(Token = "0x6003682")]
		[Address(RVA = "0x183D110", Offset = "0x183D110", VA = "0x183D110")]
		public void SetPartyWeight(string id, int weight)
		{
		}

		[Token(Token = "0x6003683")]
		[Address(RVA = "0x183D2AC", Offset = "0x183D2AC", VA = "0x183D2AC")]
		public byte[] ToBytes(bool compress = true)
		{
			return null;
		}

		[Token(Token = "0x6003684")]
		[Address(RVA = "0x183A490", Offset = "0x183A490", VA = "0x183A490")]
		public static SaveData FromBytes(byte[] bytes, out bool success)
		{
			return null;
		}

		[Token(Token = "0x6003685")]
		[Address(RVA = "0x183D2E8", Offset = "0x183D2E8", VA = "0x183D2E8")]
		public static byte[] Compress(byte[] data)
		{
			return null;
		}

		[Token(Token = "0x6003686")]
		[Address(RVA = "0x183D5FC", Offset = "0x183D5FC", VA = "0x183D5FC")]
		public static byte[] Decompress(byte[] data)
		{
			return null;
		}

		[Token(Token = "0x6003687")]
		[Address(RVA = "0x183D5A4", Offset = "0x183D5A4", VA = "0x183D5A4")]
		public SaveData()
		{
		}
	}

	[Token(Token = "0x2000B54")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x437B0", Offset = "0x437B0")]
	private sealed class _003C_003Ec__DisplayClass138_0
	{
		[Token(Token = "0x4003F2B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string id;

		[Token(Token = "0x4003F2C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public bool isComplete;

		[Token(Token = "0x600368A")]
		[Address(RVA = "0x1839C40", Offset = "0x1839C40", VA = "0x1839C40")]
		public _003C_003Ec__DisplayClass138_0()
		{
		}

		[Token(Token = "0x600368B")]
		[Address(RVA = "0x1839C48", Offset = "0x1839C48", VA = "0x1839C48")]
		internal string _003CGetIsLevelCompleted_003Eb__0()
		{
			return null;
		}
	}

	[Serializable]
	[Token(Token = "0x2000B55")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x437C0", Offset = "0x437C0")]
	private sealed class _003C_003Ec
	{
		[Token(Token = "0x4003F2D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static readonly _003C_003Ec _003C_003E9;

		[Token(Token = "0x4003F2E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public static Func<string, ConsentRequestTypes> _003C_003E9__143_0;

		[Token(Token = "0x4003F2F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public static Func<KeyValuePair<ECampaignType, OverWorldData>, int> _003C_003E9__163_0;

		[Token(Token = "0x4003F30")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public static Func<KeyValuePair<ECampaignType, OverWorldData>, int> _003C_003E9__165_0;

		[Token(Token = "0x4003F31")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public static Func<string> _003C_003E9__222_0;

		[Token(Token = "0x4003F32")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public static Func<string> _003C_003E9__229_1;

		[Token(Token = "0x4003F33")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public static Func<object, string> _003C_003E9__245_0;

		[Token(Token = "0x4003F34")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public static Func<string, string> _003C_003E9__246_0;

		[Token(Token = "0x4003F35")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public static Func<string, string> _003C_003E9__253_0;

		[Token(Token = "0x4003F36")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public static Func<string> _003C_003E9__259_0;

		[Token(Token = "0x600368D")]
		[Address(RVA = "0x1839698", Offset = "0x1839698", VA = "0x1839698")]
		public _003C_003Ec()
		{
		}

		[Token(Token = "0x600368E")]
		[Address(RVA = "0x18396A0", Offset = "0x18396A0", VA = "0x18396A0")]
		internal ConsentRequestTypes _003CConsentedPopupRequests_003Eb__143_0(string s)
		{
			return default;
		}

		[Token(Token = "0x600368F")]
		[Address(RVA = "0x18397B4", Offset = "0x18397B4", VA = "0x18397B4")]
		internal int _003Cget_TotalTimePlayed_003Eb__163_0(KeyValuePair<ECampaignType, OverWorldData> c)
		{
			return default;
		}

		[Token(Token = "0x6003690")]
		[Address(RVA = "0x1839904", Offset = "0x1839904", VA = "0x1839904")]
		internal int _003Cget_TotalNumberOfStrokes_003Eb__165_0(KeyValuePair<ECampaignType, OverWorldData> d)
		{
			return default;
		}

		[Token(Token = "0x6003691")]
		[Address(RVA = "0x1839A54", Offset = "0x1839A54", VA = "0x1839A54")]
		internal string _003CGetSaveSlot_003Eb__222_0()
		{
			return null;
		}

		[Token(Token = "0x6003692")]
		[Address(RVA = "0x1839B10", Offset = "0x1839B10", VA = "0x1839B10")]
		internal string _003CSave_003Eb__229_1()
		{
			return null;
		}

		[Token(Token = "0x6003693")]
		[Address(RVA = "0x1839B90", Offset = "0x1839B90", VA = "0x1839B90")]
		internal string _003CGetList_003Eb__245_0(object obj)
		{
			return null;
		}

		[Token(Token = "0x6003694")]
		[Address(RVA = "0x1839BB4", Offset = "0x1839BB4", VA = "0x1839BB4")]
		internal string _003CGetStringList_003Eb__246_0(string token)
		{
			return null;
		}

		[Token(Token = "0x6003695")]
		[Address(RVA = "0x1839BD8", Offset = "0x1839BD8", VA = "0x1839BD8")]
		internal string _003CGetListIntersectionCount_003Eb__253_0(string e)
		{
			return null;
		}

		[Token(Token = "0x6003696")]
		[Address(RVA = "0x1839BFC", Offset = "0x1839BFC", VA = "0x1839BFC")]
		internal string _003COverWrite_003Eb__259_0()
		{
			return null;
		}
	}

	[Token(Token = "0x2000B56")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x437D0", Offset = "0x437D0")]
	private sealed class _003C_003Ec__DisplayClass145_0
	{
		[Token(Token = "0x4003F37")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string id;

		[Token(Token = "0x6003697")]
		[Address(RVA = "0x1839CDC", Offset = "0x1839CDC", VA = "0x1839CDC")]
		public _003C_003Ec__DisplayClass145_0()
		{
		}

		[Token(Token = "0x6003698")]
		[Address(RVA = "0x1839CE4", Offset = "0x1839CE4", VA = "0x1839CE4")]
		internal string _003CSetLevelCompleted_003Eb__0()
		{
			return null;
		}
	}

	[Token(Token = "0x2000B57")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x437E0", Offset = "0x437E0")]
	private sealed class _003C_003Ec__DisplayClass152_0
	{
		[Token(Token = "0x4003F38")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public List<string> all;

		[Token(Token = "0x6003699")]
		[Address(RVA = "0x1839D54", Offset = "0x1839D54", VA = "0x1839D54")]
		public _003C_003Ec__DisplayClass152_0()
		{
		}

		[Token(Token = "0x600369A")]
		[Address(RVA = "0x1839D5C", Offset = "0x1839D5C", VA = "0x1839D5C")]
		internal bool _003CGetCompletedChallenges_003Eb__0(string challengeId)
		{
			return default;
		}
	}

	[Token(Token = "0x2000B58")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x437F0", Offset = "0x437F0")]
	private sealed class _003C_003Ec__DisplayClass157_0
	{
		[Token(Token = "0x4003F39")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string language;

		[Token(Token = "0x600369B")]
		[Address(RVA = "0x1839DC0", Offset = "0x1839DC0", VA = "0x1839DC0")]
		public _003C_003Ec__DisplayClass157_0()
		{
		}

		[Token(Token = "0x600369C")]
		[Address(RVA = "0x1839DC8", Offset = "0x1839DC8", VA = "0x1839DC8")]
		internal string _003Cget_Language_003Eb__0()
		{
			return null;
		}
	}

	[Token(Token = "0x2000B59")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x43800", Offset = "0x43800")]
	private sealed class _003C_003Ec__DisplayClass182_0
	{
		[Token(Token = "0x4003F3A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public int saveSlot;

		[Token(Token = "0x600369D")]
		[Address(RVA = "0x1839E38", Offset = "0x1839E38", VA = "0x1839E38")]
		public _003C_003Ec__DisplayClass182_0()
		{
		}

		[Token(Token = "0x600369E")]
		[Address(RVA = "0x1839E40", Offset = "0x1839E40", VA = "0x1839E40")]
		internal int _003CGetTotalPlayTime_003Eb__0(KeyValuePair<ECampaignType, OverWorldData> c)
		{
			return default;
		}
	}

	[Token(Token = "0x2000B5A")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x43810", Offset = "0x43810")]
	private sealed class _003C_003Ec__DisplayClass221_0
	{
		[Token(Token = "0x4003F3B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public int saveSlot;

		[Token(Token = "0x600369F")]
		[Address(RVA = "0x1839F18", Offset = "0x1839F18", VA = "0x1839F18")]
		public _003C_003Ec__DisplayClass221_0()
		{
		}

		[Token(Token = "0x60036A0")]
		[Address(RVA = "0x1839F20", Offset = "0x1839F20", VA = "0x1839F20")]
		internal string _003CSetSaveSlot_003Eb__0()
		{
			return null;
		}
	}

	[Token(Token = "0x2000B5B")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x43820", Offset = "0x43820")]
	private sealed class _003C_003Ec__DisplayClass226_0<T>
	{
		[Token(Token = "0x4003F3C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public int usedSaveSlot;

		[Token(Token = "0x4003F3D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public string key;

		[Token(Token = "0x4003F3E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public T value;

		[Token(Token = "0x60036A1")]
		public _003C_003Ec__DisplayClass226_0()
		{
		}

		[Token(Token = "0x60036A2")]
		internal string _003CSetValue_003Eb__0()
		{
			return null;
		}

		[Token(Token = "0x60036A3")]
		internal string _003CSetValue_003Eb__1()
		{
			return null;
		}
	}

	[Token(Token = "0x2000B5C")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x43830", Offset = "0x43830")]
	private sealed class _003C_003Ec__DisplayClass229_0
	{
		[Token(Token = "0x4003F3F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public bool isIcloud;

		[Token(Token = "0x4003F40")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Action done;

		[Token(Token = "0x60036A4")]
		[Address(RVA = "0x1839FAC", Offset = "0x1839FAC", VA = "0x1839FAC")]
		public _003C_003Ec__DisplayClass229_0()
		{
		}

		[Token(Token = "0x60036A5")]
		[Address(RVA = "0x1839FB4", Offset = "0x1839FB4", VA = "0x1839FB4")]
		internal void _003CSave_003Eb__0()
		{
		}
	}

	[Token(Token = "0x2000B5D")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x43840", Offset = "0x43840")]
	private sealed class _003C_003Ec__DisplayClass231_0
	{
		[Token(Token = "0x4003F41")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public int retries;

		[Token(Token = "0x60036A6")]
		[Address(RVA = "0x183A0F0", Offset = "0x183A0F0", VA = "0x183A0F0")]
		public _003C_003Ec__DisplayClass231_0()
		{
		}

		[Token(Token = "0x60036A7")]
		[Address(RVA = "0x183A0F8", Offset = "0x183A0F8", VA = "0x183A0F8")]
		internal void _003CLoad_003Eb__2()
		{
		}
	}

	[Token(Token = "0x2000B5E")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x43850", Offset = "0x43850")]
	private sealed class _003C_003Ec__DisplayClass231_1
	{
		[Token(Token = "0x4003F42")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public bool isNew;

		[Token(Token = "0x60036A8")]
		[Address(RVA = "0x183A168", Offset = "0x183A168", VA = "0x183A168")]
		public _003C_003Ec__DisplayClass231_1()
		{
		}

		[Token(Token = "0x60036A9")]
		[Address(RVA = "0x183A170", Offset = "0x183A170", VA = "0x183A170")]
		internal void _003CLoad_003Eb__0(byte[] data)
		{
		}
	}

	[Token(Token = "0x2000B5F")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x43860", Offset = "0x43860")]
	private sealed class _003C_003Ec__DisplayClass231_2
	{
		[Token(Token = "0x4003F43")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Exception e;

		[Token(Token = "0x60036AA")]
		[Address(RVA = "0x183AD5C", Offset = "0x183AD5C", VA = "0x183AD5C")]
		public _003C_003Ec__DisplayClass231_2()
		{
		}

		[Token(Token = "0x60036AB")]
		[Address(RVA = "0x183AD64", Offset = "0x183AD64", VA = "0x183AD64")]
		internal string _003CLoad_003Eb__1()
		{
			return null;
		}
	}

	[Token(Token = "0x2000B60")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x43870", Offset = "0x43870")]
	private sealed class _003C_003Ec__DisplayClass236_0<T>
	{
		[Token(Token = "0x4003F44")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public string key;

		[Token(Token = "0x4003F45")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public T value;

		[Token(Token = "0x60036AC")]
		public _003C_003Ec__DisplayClass236_0()
		{
		}

		[Token(Token = "0x60036AD")]
		internal string _003CGetValue_003Eb__0()
		{
			return null;
		}
	}

	[Token(Token = "0x4003ED9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static Action<SaveSlot> OnSave;

	[Token(Token = "0x4003EDA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	public static Action<SaveSlot> OnLoad;

	[Token(Token = "0x4003EDB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public static Action OnDataChanged;

	[Token(Token = "0x4003EDC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private static SaveData savedFields;

	[Token(Token = "0x4003EDD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private static DateTime lastBackup;

	[Token(Token = "0x4003EDE")]
	public const string FILE_EXTENSION = ".golf";

	[Token(Token = "0x4003EDF")]
	public const string FILE_NAME = "GolfSave";

	[Token(Token = "0x4003EE0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public static string FILE_NAME_WITH_EXTENSION;

	[Token(Token = "0x4003EE1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public static Action<int> OnSaveSlotChanged;

	[Token(Token = "0x4003EE2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public static Action OnSaveSlotDeleted;

	[Token(Token = "0x4003EE3")]
	private const string VERSION = "VERSION";

	[Token(Token = "0x4003EE4")]
	public const int SETTINGS_SAVESLOT = -1;

	[Token(Token = "0x4003EE5")]
	public const int ACHIEVEMENTS_SAVESLOT = -2;

	[Token(Token = "0x4003EE6")]
	public const string ACTIVE_SAVESLOT = "ACTIVE_SAVESLOT";

	[Token(Token = "0x4003EE7")]
	public const string IS_FIRST_TIME = "IS_FIRST_TIME";

	[Token(Token = "0x4003EE8")]
	public const string SECOND_ONBOARDING_INDEX = "SECOND_ONBOARDING_INDEX";

	[Token(Token = "0x4003EE9")]
	public const string HAS_SEEN_LOGO = "HAS_SEEN_LOGO";

	[Token(Token = "0x4003EEA")]
	public const string CREATED_TIME = "CREATED_TIME";

	[Token(Token = "0x4003EEB")]
	private const string LANGUAGE = "LANGUAGE";

	[Token(Token = "0x4003EEC")]
	private const string LAST_SAVE_TIME = "LAST_SAVE_TIME";

	[Token(Token = "0x4003EED")]
	private const string DEVICE_UUID = "DEVICE_UUID";

	[Token(Token = "0x4003EEE")]
	private const string DEVICE_NAME = "DEVICE_NAME";

	[Token(Token = "0x4003EEF")]
	private const string CLOUD_MEGA_MERGE_TIMESTAMP = "CLOUD_MEGA_MERGE_TIMESTAMP";

	[Token(Token = "0x4003EF0")]
	private const string DEVICE_MODEL = "DEVICE_MODEL";

	[Token(Token = "0x4003EF1")]
	public const string SESSION_COUNT = "SESSION_COUNT";

	[Token(Token = "0x4003EF2")]
	public const string APPLE_SESSION_COUNT = "APPLE_SESSION_COUNT";

	[Token(Token = "0x4003EF3")]
	private const string SWITCH_USE_GYRO = "SWITCH_USE_GYRO";

	[Token(Token = "0x4003EF4")]
	public const string SAVESLOT_ID = "SAVESLOT_ID";

	[Token(Token = "0x4003EF5")]
	public const string LAST_UPDATE_DISPLAY_TIME = "LAST_UPDATE_DISPLAY_TIME_UTC";

	[Token(Token = "0x4003EF6")]
	public const string CONTENT_PACK_PLAY_COUNT_PREFIX = "CONTENT_PACK_PLAY_COUNT_";

	[Token(Token = "0x4003EF7")]
	public const string UPDATE_SEEN_DATE_PREFIX = "UPDATE_SEEN_DATE_";

	[Token(Token = "0x4003EF8")]
	public const string ASKED_ABOUT_REVIEW = "ASKED_ABOUT_REVIEW";

	[Token(Token = "0x4003EF9")]
	public const string ASKED_ABOUT_EMAIL = "ASKED_ABOUT_EMAIL";

	[Token(Token = "0x4003EFA")]
	public const string SHOWN_MULTIPLE_SAVES_WARNING = "SHOWN_MULTIPLE_SAVES_WARNING";

	[Token(Token = "0x4003EFB")]
	private const string LOCAL_UUID = "LOCAL_UUID";

	[Token(Token = "0x4003EFC")]
	private const string PARTY_WEIGHTS = "PARTY_WEIGHTS_";

	[Token(Token = "0x4003EFD")]
	public const string LAST_PLAYED_TIME = "LAST_PLAYED_TIME";

	[Token(Token = "0x4003EFE")]
	public const string NUMBER_OF_DAILYS_PLAYED = "NUMBER_OF_DAILYS_PLAYED";

	[Token(Token = "0x4003EFF")]
	public const string DAILY_PACKS_PLAYED = "DAILY_PACKS_PLAYED";

	[Token(Token = "0x4003F00")]
	public const string DAILYS_ANIMAL_ID = "DAILYS_ANIMAL_ID";

	[Token(Token = "0x4003F01")]
	public const string LAST_PLAYED_DAY = "LAST_PLAYED_DAY";

	[Token(Token = "0x4003F02")]
	public const string LAST_DAILY_SCORE = "LAST_DAILY_SCORE";

	[Token(Token = "0x4003F03")]
	public const string REMOTE_NOTIFICATION_TOKENS = "REMOTE_NOTIFICATION_TOKENS";

	[Token(Token = "0x4003F04")]
	public const string REMOTE_NOTIFICATION_DEVICE_IDS = "REMOTE_NOTIFICATION_DEVICE_IDS";

	[Token(Token = "0x4003F05")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public static Dictionary<ECampaignType, OverWorldData> campaignDatas;

	[Token(Token = "0x4003F06")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public static CampaignDef currentCampaignDef;

	[Token(Token = "0x4003F07")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private static int activeSaveSlot;

	[Token(Token = "0x4003F08")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x509C8", Offset = "0x509C8")]
	private static bool loaded__BackingField;

	[Token(Token = "0x4003F09")]
	private const int buildVersion = 1;

	[Token(Token = "0x4003F0A")]
	private const string TAG = "SaveGame";

	[Token(Token = "0x4003F0B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private static readonly pLogger dbg;

	[Token(Token = "0x4003F0C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private static readonly pLogger dbg_detail;

	[Token(Token = "0x4003F0D")]
	private const string IS_SAVED_ONLINE = "IS_SAVED_ONLINE_{0}";

	[Token(Token = "0x4003F0E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	public static Action SessionCountIncremented;

	[Token(Token = "0x4003F0F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x509D8", Offset = "0x509D8")]
	private static Action<int> m_OnStrokesUpdated;

	[Token(Token = "0x4003F10")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	private static string _consentRequestCooldown;

	[Token(Token = "0x1700057C")]
	public static string Path
	{
		[Token(Token = "0x60035B9")]
		[Address(RVA = "0x166C674", Offset = "0x166C674", VA = "0x166C674")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700057D")]
	public static string PathBackupFolder
	{
		[Token(Token = "0x60035BA")]
		[Address(RVA = "0x166C738", Offset = "0x166C738", VA = "0x166C738")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700057E")]
	public static SaveData CurrentSave
	{
		[Token(Token = "0x60035BB")]
		[Address(RVA = "0x166C7C0", Offset = "0x166C7C0", VA = "0x166C7C0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700057F")]
	public static OverWorldData currentOverworld
	{
		[Token(Token = "0x60035BC")]
		[Address(RVA = "0x166C824", Offset = "0x166C824", VA = "0x166C824")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000580")]
	private static PlatformSettings.PlatformConfiguration platformSettings
	{
		[Token(Token = "0x60035C4")]
		[Address(RVA = "0x166D5D0", Offset = "0x166D5D0", VA = "0x166D5D0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000581")]
	public static bool loaded
	{
		[Token(Token = "0x60035C5")]
		[Address(RVA = "0x166D63C", Offset = "0x166D63C", VA = "0x166D63C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6AA0C", Offset = "0x6AA0C")]
		get
		{
			return default;
		}
		[Token(Token = "0x60035C6")]
		[Address(RVA = "0x166D6A0", Offset = "0x166D6A0", VA = "0x166D6A0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6AA1C", Offset = "0x6AA1C")]
		private set
		{
		}
	}

	[Token(Token = "0x17000582")]
	public static int _activeSaveSlot
	{
		[Token(Token = "0x60035C7")]
		[Address(RVA = "0x166D710", Offset = "0x166D710", VA = "0x166D710")]
		get
		{
			return default;
		}
	}

	[Token(Token = "0x17000583")]
	public static bool IsSavedOnline
	{
		[Token(Token = "0x60035C8")]
		[Address(RVA = "0x166D774", Offset = "0x166D774", VA = "0x166D774")]
		get
		{
			return default;
		}
		[Token(Token = "0x60035C9")]
		[Address(RVA = "0x166D80C", Offset = "0x166D80C", VA = "0x166D80C")]
		set
		{
		}
	}

	[Token(Token = "0x17000584")]
	public static string RemoteNotificationAppUpdatePrompt
	{
		[Token(Token = "0x60035CF")]
		[Address(RVA = "0x166E25C", Offset = "0x166E25C", VA = "0x166E25C")]
		get
		{
			return null;
		}
		[Token(Token = "0x60035D0")]
		[Address(RVA = "0x166E308", Offset = "0x166E308", VA = "0x166E308")]
		set
		{
		}
	}

	[Token(Token = "0x17000585")]
	public static bool IsFirstTime
	{
		[Token(Token = "0x60035D1")]
		[Address(RVA = "0x166E3A8", Offset = "0x166E3A8", VA = "0x166E3A8")]
		get
		{
			return default;
		}
		[Token(Token = "0x60035D2")]
		[Address(RVA = "0x166E474", Offset = "0x166E474", VA = "0x166E474")]
		set
		{
		}
	}

	[Token(Token = "0x17000586")]
	public static bool HasSeenLogo
	{
		[Token(Token = "0x60035D3")]
		[Address(RVA = "0x166E550", Offset = "0x166E550", VA = "0x166E550")]
		get
		{
			return default;
		}
		[Token(Token = "0x60035D4")]
		[Address(RVA = "0x166E61C", Offset = "0x166E61C", VA = "0x166E61C")]
		set
		{
		}
	}

	[Token(Token = "0x17000587")]
	public static int NumTimeDailyPlayed
	{
		[Token(Token = "0x60035D5")]
		[Address(RVA = "0x166E6F8", Offset = "0x166E6F8", VA = "0x166E6F8")]
		get
		{
			return default;
		}
		[Token(Token = "0x60035D6")]
		[Address(RVA = "0x166E790", Offset = "0x166E790", VA = "0x166E790")]
		set
		{
		}
	}

	[Token(Token = "0x17000588")]
	public static int LastScore
	{
		[Token(Token = "0x60035D7")]
		[Address(RVA = "0x166E830", Offset = "0x166E830", VA = "0x166E830")]
		get
		{
			return default;
		}
		[Token(Token = "0x60035D8")]
		[Address(RVA = "0x166E8C8", Offset = "0x166E8C8", VA = "0x166E8C8")]
		set
		{
		}
	}

	[Token(Token = "0x17000589")]
	public static string LastDayPlayed
	{
		[Token(Token = "0x60035D9")]
		[Address(RVA = "0x166E968", Offset = "0x166E968", VA = "0x166E968")]
		get
		{
			return null;
		}
		[Token(Token = "0x60035DA")]
		[Address(RVA = "0x166EA14", Offset = "0x166EA14", VA = "0x166EA14")]
		set
		{
		}
	}

	[Token(Token = "0x1700058A")]
	public static List<string> RemoteNotificationTokens
	{
		[Token(Token = "0x60035DB")]
		[Address(RVA = "0x166EAB4", Offset = "0x166EAB4", VA = "0x166EAB4")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700058B")]
	public static List<string> DailyPrizes
	{
		[Token(Token = "0x60035DF")]
		[Address(RVA = "0x166FA94", Offset = "0x166FA94", VA = "0x166FA94")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700058C")]
	public static List<string> DailyPacksPlayed
	{
		[Token(Token = "0x60035E1")]
		[Address(RVA = "0x166FB8C", Offset = "0x166FB8C", VA = "0x166FB8C")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700058D")]
	public static int SecondOnboardingIndex
	{
		[Token(Token = "0x60035E6")]
		[Address(RVA = "0x166FF7C", Offset = "0x166FF7C", VA = "0x166FF7C")]
		get
		{
			return default;
		}
		[Token(Token = "0x60035E7")]
		[Address(RVA = "0x1670014", Offset = "0x1670014", VA = "0x1670014")]
		set
		{
		}
	}

	[Token(Token = "0x1700058E")]
	public static DateTime CreatedTime
	{
		[Token(Token = "0x60035E8")]
		[Address(RVA = "0x16700B4", Offset = "0x16700B4", VA = "0x16700B4")]
		get
		{
			return default;
		}
	}

	[Token(Token = "0x1700058F")]
	public static int LastDaySeenTiktok
	{
		[Token(Token = "0x60035E9")]
		[Address(RVA = "0x1670200", Offset = "0x1670200", VA = "0x1670200")]
		get
		{
			return default;
		}
		[Token(Token = "0x60035EA")]
		[Address(RVA = "0x1670298", Offset = "0x1670298", VA = "0x1670298")]
		set
		{
		}
	}

	[Token(Token = "0x17000590")]
	public static int TiktokIndex
	{
		[Token(Token = "0x60035EB")]
		[Address(RVA = "0x1670338", Offset = "0x1670338", VA = "0x1670338")]
		get
		{
			return default;
		}
		[Token(Token = "0x60035EC")]
		[Address(RVA = "0x16703D0", Offset = "0x16703D0", VA = "0x16703D0")]
		set
		{
		}
	}

	[Token(Token = "0x17000591")]
	public static bool IsOnboardingComplete
	{
		[Token(Token = "0x60035EF")]
		[Address(RVA = "0x16706BC", Offset = "0x16706BC", VA = "0x16706BC")]
		get
		{
			return default;
		}
		[Token(Token = "0x60035F0")]
		[Address(RVA = "0x1670744", Offset = "0x1670744", VA = "0x1670744")]
		set
		{
		}
	}

	[Token(Token = "0x17000592")]
	public static string Language
	{
		[Token(Token = "0x6003608")]
		[Address(RVA = "0x1671C1C", Offset = "0x1671C1C", VA = "0x1671C1C")]
		get
		{
			return null;
		}
		[Token(Token = "0x6003609")]
		[Address(RVA = "0x1671DDC", Offset = "0x1671DDC", VA = "0x1671DDC")]
		set
		{
		}
	}

	[Token(Token = "0x17000593")]
	public static bool CrownAwarenessMode
	{
		[Token(Token = "0x600360A")]
		[Address(RVA = "0x1671EB8", Offset = "0x1671EB8", VA = "0x1671EB8")]
		get
		{
			return default;
		}
		[Token(Token = "0x600360B")]
		[Address(RVA = "0x1671F40", Offset = "0x1671F40", VA = "0x1671F40")]
		set
		{
		}
	}

	[Token(Token = "0x17000594")]
	public static int TotalTimePlayed
	{
		[Token(Token = "0x600360C")]
		[Address(RVA = "0x1671FD8", Offset = "0x1671FD8", VA = "0x1671FD8")]
		get
		{
			return default;
		}
	}

	[Token(Token = "0x17000595")]
	public static int TotalNumberOfStrokes
	{
		[Token(Token = "0x600360D")]
		[Address(RVA = "0x167213C", Offset = "0x167213C", VA = "0x167213C")]
		get
		{
			return default;
		}
	}

	[Token(Token = "0x17000596")]
	public static int TimePlayed
	{
		[Token(Token = "0x600360E")]
		[Address(RVA = "0x16722A0", Offset = "0x16722A0", VA = "0x16722A0")]
		get
		{
			return default;
		}
		[Token(Token = "0x600360F")]
		[Address(RVA = "0x1672308", Offset = "0x1672308", VA = "0x1672308")]
		set
		{
		}
	}

	[Token(Token = "0x17000597")]
	public static int SessionCount
	{
		[Token(Token = "0x6003610")]
		[Address(RVA = "0x1672380", Offset = "0x1672380", VA = "0x1672380")]
		get
		{
			return default;
		}
		[Token(Token = "0x6003611")]
		[Address(RVA = "0x167244C", Offset = "0x167244C", VA = "0x167244C")]
		set
		{
		}
	}

	[Token(Token = "0x17000598")]
	public static string SavePosition
	{
		[Token(Token = "0x6003612")]
		[Address(RVA = "0x166AE00", Offset = "0x166AE00", VA = "0x166AE00")]
		get
		{
			return null;
		}
		[Token(Token = "0x6003613")]
		[Address(RVA = "0x166B4D0", Offset = "0x166B4D0", VA = "0x166B4D0")]
		set
		{
		}
	}

	[Token(Token = "0x17000599")]
	public static bool SwitchUseGyro
	{
		[Token(Token = "0x6003614")]
		[Address(RVA = "0x1672558", Offset = "0x1672558", VA = "0x1672558")]
		get
		{
			return default;
		}
		[Token(Token = "0x6003615")]
		[Address(RVA = "0x1672624", Offset = "0x1672624", VA = "0x1672624")]
		set
		{
		}
	}

	[Token(Token = "0x1700059A")]
	public static Transmogrif.BALLSHAPES SavePositionShape
	{
		[Token(Token = "0x6003616")]
		[Address(RVA = "0x166AE68", Offset = "0x166AE68", VA = "0x166AE68")]
		get
		{
			return default;
		}
		[Token(Token = "0x6003617")]
		[Address(RVA = "0x166B548", Offset = "0x166B548", VA = "0x166B548")]
		set
		{
		}
	}

	[Token(Token = "0x1700059B")]
	public static bool IsIntroAnimationComplete
	{
		[Token(Token = "0x6003619")]
		[Address(RVA = "0x167282C", Offset = "0x167282C", VA = "0x167282C")]
		get
		{
			return default;
		}
		[Token(Token = "0x600361A")]
		[Address(RVA = "0x16728B4", Offset = "0x16728B4", VA = "0x16728B4")]
		set
		{
		}
	}

	[Token(Token = "0x1700059C")]
	public static int OverworldStrokes
	{
		[Token(Token = "0x600361D")]
		[Address(RVA = "0x1672B64", Offset = "0x1672B64", VA = "0x1672B64")]
		get
		{
			return default;
		}
		[Token(Token = "0x600361E")]
		[Address(RVA = "0x1672BCC", Offset = "0x1672BCC", VA = "0x1672BCC")]
		set
		{
		}
	}

	[Token(Token = "0x1700059D")]
	public static int OverworldStrokes0Pct
	{
		[Token(Token = "0x600361F")]
		[Address(RVA = "0x1672CB0", Offset = "0x1672CB0", VA = "0x1672CB0")]
		get
		{
			return default;
		}
		[Token(Token = "0x6003620")]
		[Address(RVA = "0x1672D18", Offset = "0x1672D18", VA = "0x1672D18")]
		set
		{
		}
	}

	[Token(Token = "0x1700059E")]
	public static int OverworldStrokes50Pct
	{
		[Token(Token = "0x6003621")]
		[Address(RVA = "0x1672D90", Offset = "0x1672D90", VA = "0x1672D90")]
		get
		{
			return default;
		}
		[Token(Token = "0x6003622")]
		[Address(RVA = "0x1672DF8", Offset = "0x1672DF8", VA = "0x1672DF8")]
		set
		{
		}
	}

	[Token(Token = "0x1700059F")]
	public static int OverworldStrokes75Pct
	{
		[Token(Token = "0x6003623")]
		[Address(RVA = "0x1672E70", Offset = "0x1672E70", VA = "0x1672E70")]
		get
		{
			return default;
		}
		[Token(Token = "0x6003624")]
		[Address(RVA = "0x1672ED8", Offset = "0x1672ED8", VA = "0x1672ED8")]
		set
		{
		}
	}

	[Token(Token = "0x170005A0")]
	public static int OverworldStrokes100Pct
	{
		[Token(Token = "0x6003625")]
		[Address(RVA = "0x1672F50", Offset = "0x1672F50", VA = "0x1672F50")]
		get
		{
			return default;
		}
		[Token(Token = "0x6003626")]
		[Address(RVA = "0x1672FB8", Offset = "0x1672FB8", VA = "0x1672FB8")]
		set
		{
		}
	}

	[Token(Token = "0x170005A1")]
	public static int TimePlayed0Pct
	{
		[Token(Token = "0x6003627")]
		[Address(RVA = "0x1673030", Offset = "0x1673030", VA = "0x1673030")]
		get
		{
			return default;
		}
		[Token(Token = "0x6003628")]
		[Address(RVA = "0x1673098", Offset = "0x1673098", VA = "0x1673098")]
		set
		{
		}
	}

	[Token(Token = "0x170005A2")]
	public static int TimePlayed50Pct
	{
		[Token(Token = "0x6003629")]
		[Address(RVA = "0x1673110", Offset = "0x1673110", VA = "0x1673110")]
		get
		{
			return default;
		}
		[Token(Token = "0x600362A")]
		[Address(RVA = "0x1673178", Offset = "0x1673178", VA = "0x1673178")]
		set
		{
		}
	}

	[Token(Token = "0x170005A3")]
	public static int TimePlayed75Pct
	{
		[Token(Token = "0x600362B")]
		[Address(RVA = "0x16731F0", Offset = "0x16731F0", VA = "0x16731F0")]
		get
		{
			return default;
		}
		[Token(Token = "0x600362C")]
		[Address(RVA = "0x1673258", Offset = "0x1673258", VA = "0x1673258")]
		set
		{
		}
	}

	[Token(Token = "0x170005A4")]
	public static int TimePlayed100Pct
	{
		[Token(Token = "0x600362D")]
		[Address(RVA = "0x16732D0", Offset = "0x16732D0", VA = "0x16732D0")]
		get
		{
			return default;
		}
		[Token(Token = "0x600362E")]
		[Address(RVA = "0x1673338", Offset = "0x1673338", VA = "0x1673338")]
		set
		{
		}
	}

	[Token(Token = "0x170005A5")]
	public static ECampaignType LastPlayedCampaignType
	{
		[Token(Token = "0x600362F")]
		[Address(RVA = "0x16733B0", Offset = "0x16733B0", VA = "0x16733B0")]
		get
		{
			return default;
		}
		[Token(Token = "0x6003630")]
		[Address(RVA = "0x1673538", Offset = "0x1673538", VA = "0x1673538")]
		set
		{
		}
	}

	[Token(Token = "0x170005A6")]
	public static Guid DeviceUUID
	{
		[Token(Token = "0x6003655")]
		[Address(RVA = "0x1675C78", Offset = "0x1675C78", VA = "0x1675C78")]
		get
		{
			return default;
		}
	}

	[Token(Token = "0x14000072")]
	public static event Action<int> OnStrokesUpdated
	{
		[Token(Token = "0x600361B")]
		[Address(RVA = "0x167294C", Offset = "0x167294C", VA = "0x167294C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6AA2C", Offset = "0x6AA2C")]
		add
		{
		}
		[Token(Token = "0x600361C")]
		[Address(RVA = "0x1672A58", Offset = "0x1672A58", VA = "0x1672A58")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6AA3C", Offset = "0x6AA3C")]
		remove
		{
		}
	}

	[Token(Token = "0x60035B8")]
	[Address(RVA = "0x166C5D0", Offset = "0x166C5D0", VA = "0x166C5D0")]
	public static string GetLocalSaveFilePath(string saveFilename)
	{
		return null;
	}

	[Token(Token = "0x60035BD")]
	[Address(RVA = "0x166C8B4", Offset = "0x166C8B4", VA = "0x166C8B4")]
	[AttributeAttribute(Name = "RuntimeInitializeOnLoadMethodAttribute", RVA = "0x6A9F8", Offset = "0x6A9F8")]
	private static void Init()
	{
	}

	[Token(Token = "0x60035BE")]
	[Address(RVA = "0x166CD68", Offset = "0x166CD68", VA = "0x166CD68")]
	private static void SetContentPackReleaseVersions()
	{
	}

	[Token(Token = "0x60035BF")]
	[Address(RVA = "0x166D34C", Offset = "0x166D34C", VA = "0x166D34C")]
	public static void SetContentPackReleaseVersion(string contentPackId, string bundleVersion)
	{
	}

	[Token(Token = "0x60035C0")]
	[Address(RVA = "0x166D27C", Offset = "0x166D27C", VA = "0x166D27C")]
	public static string GetContentPackReleaseVersion(string contentPackId)
	{
		return null;
	}

	[Token(Token = "0x60035C1")]
	[Address(RVA = "0x166CCA4", Offset = "0x166CCA4", VA = "0x166CCA4")]
	public static void SetOverworld(ECampaignType type)
	{
	}

	[Token(Token = "0x60035C2")]
	[Address(RVA = "0x166D410", Offset = "0x166D410", VA = "0x166D410")]
	public static int GetCompletedPercentage(ECampaignType campaignType, [Optional] int? saveSlot, bool includeChallenges = true)
	{
		return default;
	}

	[Token(Token = "0x60035C3")]
	[Address(RVA = "0x166D49C", Offset = "0x166D49C", VA = "0x166D49C")]
	public static OverWorldData GetOverworldData(ECampaignType type)
	{
		return null;
	}

	[Token(Token = "0x60035CA")]
	[Address(RVA = "0x166D8A4", Offset = "0x166D8A4", VA = "0x166D8A4")]
	static SaveGame()
	{
	}

	[Token(Token = "0x60035CB")]
	[Address(RVA = "0x166DE60", Offset = "0x166DE60", VA = "0x166DE60")]
	public static void UpdateLastSaveTime()
	{
	}

	[Token(Token = "0x60035CC")]
	[Address(RVA = "0x166DF84", Offset = "0x166DF84", VA = "0x166DF84")]
	public static void UpdateDeviceName()
	{
	}

	[Token(Token = "0x60035CD")]
	[Address(RVA = "0x166E07C", Offset = "0x166E07C", VA = "0x166E07C")]
	public static void UpdateDeviceModel()
	{
	}

	[Token(Token = "0x60035CE")]
	[Address(RVA = "0x166E174", Offset = "0x166E174", VA = "0x166E174")]
	public static void UpdateUUID()
	{
	}

	[Token(Token = "0x60035DC")]
	[Address(RVA = "0x166ED40", Offset = "0x166ED40", VA = "0x166ED40")]
	public static void AddOrReplaceRemoteNotificationToken(string pushNotificationToken, string deviceId)
	{
	}

	[Token(Token = "0x60035DD")]
	[Address(RVA = "0x166EEA0", Offset = "0x166EEA0", VA = "0x166EEA0")]
	public static string GetRemoteNotificationToken(string deviceUniqueIdentifier)
	{
		return null;
	}

	[Token(Token = "0x60035DE")]
	[Address(RVA = "0x166FA20", Offset = "0x166FA20", VA = "0x166FA20")]
	public static List<string> GetDeviceIds()
	{
		return null;
	}

	[Token(Token = "0x60035E0")]
	[Address(RVA = "0x166FB08", Offset = "0x166FB08", VA = "0x166FB08")]
	public static void AddAnimal(string s)
	{
	}

	[Token(Token = "0x60035E2")]
	[Address(RVA = "0x166FC00", Offset = "0x166FC00", VA = "0x166FC00")]
	public static bool GetIsSpecialPlayed(string specialId)
	{
		return default;
	}

	[Token(Token = "0x60035E3")]
	[Address(RVA = "0x166FD38", Offset = "0x166FD38", VA = "0x166FD38")]
	public static void SetIsSpecialPlayed(string specialId)
	{
	}

	[Token(Token = "0x60035E4")]
	[Address(RVA = "0x166FE74", Offset = "0x166FE74", VA = "0x166FE74")]
	public static void AddPlayedDailyPack(string s)
	{
	}

	[Token(Token = "0x60035E5")]
	[Address(RVA = "0x166FEF8", Offset = "0x166FEF8", VA = "0x166FEF8")]
	public static void RemovePlayedDailyPack(string s)
	{
	}

	[Token(Token = "0x60035ED")]
	[Address(RVA = "0x1670470", Offset = "0x1670470", VA = "0x1670470")]
	public static DateTime GetLastTimePlayed(int saveSlot)
	{
		return default;
	}

	[Token(Token = "0x60035EE")]
	[Address(RVA = "0x16705C8", Offset = "0x16705C8", VA = "0x16705C8")]
	public static void UpdateLastPlayedTime()
	{
	}

	[Token(Token = "0x60035F1")]
	[Address(RVA = "0x16707DC", Offset = "0x16707DC", VA = "0x16707DC")]
	public static void SetContentPackComplete(string contentPackId)
	{
	}

	[Token(Token = "0x60035F2")]
	[Address(RVA = "0x1670898", Offset = "0x1670898", VA = "0x1670898")]
	public static bool IsContentPackComplete(string contentPackId)
	{
		return default;
	}

	[Token(Token = "0x60035F3")]
	[Address(RVA = "0x1670950", Offset = "0x1670950", VA = "0x1670950")]
	public static bool GetIsOnboardingComplete(int saveSlot)
	{
		return default;
	}

	[Token(Token = "0x60035F4")]
	[Address(RVA = "0x1670A1C", Offset = "0x1670A1C", VA = "0x1670A1C")]
	public static bool GetIsOnboardingComplete(int saveSlot, ECampaignType campaign)
	{
		return default;
	}

	[Token(Token = "0x60035F5")]
	[Address(RVA = "0x1670AF0", Offset = "0x1670AF0", VA = "0x1670AF0")]
	public static bool GetIsLevelCompleted(string id, [Optional] int? saveSlot)
	{
		return default;
	}

	[Token(Token = "0x60035F6")]
	[Address(RVA = "0x1670B68", Offset = "0x1670B68", VA = "0x1670B68")]
	public static bool GetIsLevelCompleted(string id, OverWorldData data, [Optional] int? saveSlot)
	{
		return default;
	}

	[Token(Token = "0x60035F7")]
	[Address(RVA = "0x1670D0C", Offset = "0x1670D0C", VA = "0x1670D0C")]
	public static List<string> CompletedLevelsInOverworld(OverWorldData data, [Optional] int? saveSlot)
	{
		return null;
	}

	[Token(Token = "0x60035F8")]
	[Address(RVA = "0x1670DB8", Offset = "0x1670DB8", VA = "0x1670DB8")]
	public static List<string> GetLevelNotifications()
	{
		return null;
	}

	[Token(Token = "0x60035F9")]
	[Address(RVA = "0x1670E28", Offset = "0x1670E28", VA = "0x1670E28")]
	public static void AddLevelNotification(string notificationId)
	{
	}

	[Token(Token = "0x60035FA")]
	[Address(RVA = "0x1670F0C", Offset = "0x1670F0C", VA = "0x1670F0C")]
	public static void RemoveLevelNotification(string notificationId)
	{
	}

	[Token(Token = "0x60035FB")]
	[Address(RVA = "0x1670FF0", Offset = "0x1670FF0", VA = "0x1670FF0")]
	public static List<ConsentRequestTypes> ConsentedPopupRequests()
	{
		return null;
	}

	[Token(Token = "0x60035FC")]
	[Address(RVA = "0x1671198", Offset = "0x1671198", VA = "0x1671198")]
	public static void DisablePopupRequest(ConsentRequestTypes requestType)
	{
	}

	[Token(Token = "0x60035FD")]
	[Address(RVA = "0x16712B8", Offset = "0x16712B8", VA = "0x16712B8")]
	public static void SetLevelCompleted(string id)
	{
	}

	[Token(Token = "0x60035FE")]
	[Address(RVA = "0x16713FC", Offset = "0x16713FC", VA = "0x16713FC")]
	public static bool GetIsDoorOpen(string id)
	{
		return default;
	}

	[Token(Token = "0x60035FF")]
	[Address(RVA = "0x1671498", Offset = "0x1671498", VA = "0x1671498")]
	public static void SetDoorOpen(string id)
	{
	}

	[Token(Token = "0x6003600")]
	[Address(RVA = "0x1671514", Offset = "0x1671514", VA = "0x1671514")]
	public static List<string> GetConsolesHit()
	{
		return null;
	}

	[Token(Token = "0x6003601")]
	[Address(RVA = "0x1671580", Offset = "0x1671580", VA = "0x1671580")]
	public static void SetConsoleHit(string id)
	{
	}

	[Token(Token = "0x6003602")]
	[Address(RVA = "0x16715FC", Offset = "0x16715FC", VA = "0x16715FC")]
	public static bool GetIsMainDoorOpen(string id)
	{
		return default;
	}

	[Token(Token = "0x6003603")]
	[Address(RVA = "0x1671698", Offset = "0x1671698", VA = "0x1671698")]
	public static void SetMainDoorOpen(string id)
	{
	}

	[Token(Token = "0x6003604")]
	[Address(RVA = "0x1671714", Offset = "0x1671714", VA = "0x1671714")]
	public static List<string> GetCompletedChallenges(List<string> challengeIds, [Optional] OverWorldData data, [Optional] int? saveSlot)
	{
		return null;
	}

	[Token(Token = "0x6003605")]
	[Address(RVA = "0x1671894", Offset = "0x1671894", VA = "0x1671894")]
	public static void AddCompletedChallenges(List<string> challengeIds)
	{
	}

	[Token(Token = "0x6003606")]
	[Address(RVA = "0x1671B04", Offset = "0x1671B04", VA = "0x1671B04")]
	public static bool GetIsChestUnlocked(string id)
	{
		return default;
	}

	[Token(Token = "0x6003607")]
	[Address(RVA = "0x1671BA0", Offset = "0x1671BA0", VA = "0x1671BA0")]
	public static void SetChestUnlocked(string id)
	{
	}

	[Token(Token = "0x6003618")]
	[Address(RVA = "0x1672700", Offset = "0x1672700", VA = "0x1672700")]
	public static int GetTotalPlayTime(int saveSlot)
	{
		return default;
	}

	[Token(Token = "0x6003631")]
	[Address(RVA = "0x16735D8", Offset = "0x16735D8", VA = "0x16735D8")]
	public static void ResetSaveLoadCheck()
	{
	}

	[Token(Token = "0x6003632")]
	[Address(RVA = "0x1673674", Offset = "0x1673674", VA = "0x1673674")]
	private static void LoadCheck()
	{
	}

	[Token(Token = "0x6003633")]
	[Address(RVA = "0x1673AB0", Offset = "0x1673AB0", VA = "0x1673AB0")]
	public static void SetSaveSlot(int saveSlot)
	{
	}

	[Token(Token = "0x6003634")]
	[Address(RVA = "0x1673E58", Offset = "0x1673E58", VA = "0x1673E58")]
	public static int GetSaveSlot()
	{
		return default;
	}

	[Token(Token = "0x6003635")]
	[Address(RVA = "0x1674000", Offset = "0x1674000", VA = "0x1674000")]
	public static int GetSaveSlotOrNothing()
	{
		return default;
	}

	[Token(Token = "0x6003636")]
	[Address(RVA = "0x1674064", Offset = "0x1674064", VA = "0x1674064")]
	public static int GetSaveSlotCount()
	{
		return default;
	}

	[Token(Token = "0x6003637")]
	[Address(RVA = "0x16740FC", Offset = "0x16740FC", VA = "0x16740FC")]
	public static void ReplaceSaveSlots(int lowestProgressionSaveslot, int fifthSaveSlot)
	{
	}

	[Token(Token = "0x6003638")]
	public static void SetValue<T>(string key, T value, [Optional][DefaultParameterValue(false)] bool autoSave, [Optional] int? saveSlot)
	{
	}

	[Token(Token = "0x6003639")]
	[Address(RVA = "0x16741C8", Offset = "0x16741C8", VA = "0x16741C8")]
	public static void SaveBackup()
	{
	}

	[Token(Token = "0x600363A")]
	[Address(RVA = "0x166F2BC", Offset = "0x166F2BC", VA = "0x166F2BC")]
	public static bool Save(bool isIcloud = false)
	{
		return default;
	}

	[Token(Token = "0x600363B")]
	[Address(RVA = "0x16741CC", Offset = "0x16741CC", VA = "0x16741CC")]
	private static bool Save(bool isIcloud, Action done)
	{
		return default;
	}

	[Token(Token = "0x600363C")]
	[Address(RVA = "0x1674544", Offset = "0x1674544", VA = "0x1674544")]
	public static void ConvertToJSON()
	{
	}

	[Token(Token = "0x600363D")]
	[Address(RVA = "0x1673738", Offset = "0x1673738", VA = "0x1673738")]
	public static void Load(int retries = 0)
	{
	}

	[Token(Token = "0x600363E")]
	[Address(RVA = "0x1674604", Offset = "0x1674604", VA = "0x1674604")]
	private static void OnLoadDone()
	{
	}

	[Token(Token = "0x600363F")]
	[Address(RVA = "0x16747A8", Offset = "0x16747A8", VA = "0x16747A8")]
	public static void CreateNewCleanSave()
	{
	}

	[Token(Token = "0x6003640")]
	public static bool TryGetValue<T>(string key, out T value, [Optional] int? saveSlot)
	{
		return default;
	}

	[Token(Token = "0x6003641")]
	public static bool TryGetValue<T>(string key, out T value, T defaultValue, [Optional] int? saveSlot)
	{
		return default;
	}

	[Token(Token = "0x6003642")]
	public static T GetValue<T>(string key, T defaultValue, [Optional] int? saveSlot)
	{
		return (T)null;
	}

	[Token(Token = "0x6003643")]
	[Address(RVA = "0x1674AE8", Offset = "0x1674AE8", VA = "0x1674AE8")]
	private static string GetSaveKeyForContentPack(string packId)
	{
		return null;
	}

	[Token(Token = "0x6003644")]
	[Address(RVA = "0x1674B40", Offset = "0x1674B40", VA = "0x1674B40")]
	public static long GetContentPackPlayCount(string packId)
	{
		return default;
	}

	[Token(Token = "0x6003645")]
	[Address(RVA = "0x1674C50", Offset = "0x1674C50", VA = "0x1674C50")]
	public static void IncrementContentPackPlayCount(string packId)
	{
	}

	[Token(Token = "0x6003646")]
	[Address(RVA = "0x1674D60", Offset = "0x1674D60", VA = "0x1674D60")]
	public static void ResetContentPackPlayCount(string packId)
	{
	}

	[Token(Token = "0x6003647")]
	[Address(RVA = "0x1674E64", Offset = "0x1674E64", VA = "0x1674E64")]
	public static bool ContainsKey(string key, [Optional] int? saveSlot)
	{
		return default;
	}

	[Token(Token = "0x6003648")]
	[Address(RVA = "0x1674FC0", Offset = "0x1674FC0", VA = "0x1674FC0")]
	public static void ClearValue(string key, [Optional][DefaultParameterValue(true)] bool autoSave, [Optional] int? saveSlot)
	{
	}

	[Token(Token = "0x6003649")]
	[Address(RVA = "0x16752E4", Offset = "0x16752E4", VA = "0x16752E4")]
	public static void ClearSave()
	{
	}

	[Token(Token = "0x600364A")]
	[Address(RVA = "0x1675438", Offset = "0x1675438", VA = "0x1675438")]
	public static void ClearSaveSlot()
	{
	}

	[Token(Token = "0x600364B")]
	[Address(RVA = "0x166F340", Offset = "0x166F340", VA = "0x166F340")]
	private static List<string> GetList(string key, [Optional] int? saveSlot)
	{
		return null;
	}

	[Token(Token = "0x600364C")]
	[Address(RVA = "0x166EB28", Offset = "0x166EB28", VA = "0x166EB28")]
	public static List<string> GetStringList(string key, [Optional] int? saveSlot)
	{
		return null;
	}

	[Token(Token = "0x600364D")]
	[Address(RVA = "0x166F1C8", Offset = "0x166F1C8", VA = "0x166F1C8")]
	public static void AddToSet(string key, string element, [Optional] int? saveSlot)
	{
	}

	[Token(Token = "0x600364E")]
	[Address(RVA = "0x166F0D4", Offset = "0x166F0D4", VA = "0x166F0D4")]
	public static void RemoveFromSet(string key, string element, [Optional] int? saveSlot)
	{
	}

	[Token(Token = "0x600364F")]
	[Address(RVA = "0x1671910", Offset = "0x1671910", VA = "0x1671910")]
	public static void AddToSet(string key, List<string> elements, [Optional] int? saveSlot)
	{
	}

	[Token(Token = "0x6003650")]
	[Address(RVA = "0x166F954", Offset = "0x166F954", VA = "0x166F954")]
	public static void ClearSet(string key, [Optional] int? saveSlot)
	{
	}

	[Token(Token = "0x6003651")]
	[Address(RVA = "0x167580C", Offset = "0x167580C", VA = "0x167580C")]
	public static bool IsElementInList(string key, string element, [Optional] int? saveSlot)
	{
		return default;
	}

	[Token(Token = "0x6003652")]
	[Address(RVA = "0x16759D8", Offset = "0x16759D8", VA = "0x16759D8")]
	public static int GetListCount(string key, [Optional] int? saveSlot)
	{
		return default;
	}

	[Token(Token = "0x6003653")]
	[Address(RVA = "0x1675A7C", Offset = "0x1675A7C", VA = "0x1675A7C")]
	public static int GetListIntersectionCount(string key1, List<string> list2, [Optional] int? saveSlot)
	{
		return default;
	}

	[Token(Token = "0x6003654")]
	[Address(RVA = "0x1675928", Offset = "0x1675928", VA = "0x1675928")]
	private static bool CheckListForElement(List<string> list, string element)
	{
		return default;
	}

	[Token(Token = "0x6003656")]
	[Address(RVA = "0x1675DB8", Offset = "0x1675DB8", VA = "0x1675DB8")]
	public static bool OverWrite(SaveData newSaveData, bool isIcloud = false)
	{
		return default;
	}

	[Token(Token = "0x6003657")]
	[Address(RVA = "0x1676054", Offset = "0x1676054", VA = "0x1676054")]
	public static void IncrementConsentRequestCooldown()
	{
	}

	[Token(Token = "0x6003658")]
	[Address(RVA = "0x1676190", Offset = "0x1676190", VA = "0x1676190")]
	public static SnoozeData GetConsentRequestCooldown()
	{
		return null;
	}

	[Token(Token = "0x6003659")]
	[Address(RVA = "0x1676240", Offset = "0x1676240", VA = "0x1676240")]
	public SaveGame()
	{
	}
}
