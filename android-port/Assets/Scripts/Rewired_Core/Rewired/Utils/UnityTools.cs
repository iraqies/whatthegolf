using System.Collections.Generic;
using Il2CppDummyDll;
using Rewired.Interfaces;
using Rewired.Platforms;
using Rewired.Utils.Interfaces;
using UnityEngine;

namespace Rewired.Utils
{
	[Token(Token = "0x2000343")]
	public static class UnityTools
	{
		[Token(Token = "0x2000344")]
		public enum UnityVersion
		{
			[Token(Token = "0x40010B7")]
			UNITY_2_6 = 0,
			[Token(Token = "0x40010B8")]
			UNITY_2_6_1 = 1,
			[Token(Token = "0x40010B9")]
			UNITY_3_0 = 2,
			[Token(Token = "0x40010BA")]
			UNITY_3_0_0 = 3,
			[Token(Token = "0x40010BB")]
			UNITY_3_1 = 4,
			[Token(Token = "0x40010BC")]
			UNITY_3_2 = 5,
			[Token(Token = "0x40010BD")]
			UNITY_3_3 = 6,
			[Token(Token = "0x40010BE")]
			UNITY_3_4 = 7,
			[Token(Token = "0x40010BF")]
			UNITY_3_5 = 8,
			[Token(Token = "0x40010C0")]
			UNITY_3_5_2 = 9,
			[Token(Token = "0x40010C1")]
			UNITY_3_5_7 = 10,
			[Token(Token = "0x40010C2")]
			UNITY_3_MAX = 11,
			[Token(Token = "0x40010C3")]
			UNITY_4_0 = 12,
			[Token(Token = "0x40010C4")]
			UNITY_4_0_1 = 13,
			[Token(Token = "0x40010C5")]
			UNITY_4_1 = 14,
			[Token(Token = "0x40010C6")]
			UNITY_4_2 = 15,
			[Token(Token = "0x40010C7")]
			UNITY_4_3 = 16,
			[Token(Token = "0x40010C8")]
			UNITY_4_4 = 17,
			[Token(Token = "0x40010C9")]
			UNITY_4_5 = 18,
			[Token(Token = "0x40010CA")]
			UNITY_4_6 = 19,
			[Token(Token = "0x40010CB")]
			UNITY_4_6_3p1 = 20,
			[Token(Token = "0x40010CC")]
			UNITY_4_6_3p1Plus = 21,
			[Token(Token = "0x40010CD")]
			UNITY_4_7 = 22,
			[Token(Token = "0x40010CE")]
			UNITY_4_8 = 23,
			[Token(Token = "0x40010CF")]
			UNITY_4_9 = 24,
			[Token(Token = "0x40010D0")]
			UNITY_4_MAX = 25,
			[Token(Token = "0x40010D1")]
			UNITY_5_0 = 26,
			[Token(Token = "0x40010D2")]
			UNITY_5_0_0p1 = 27,
			[Token(Token = "0x40010D3")]
			UNITY_5_0_0p1Plus = 28,
			[Token(Token = "0x40010D4")]
			UNITY_5_0_1 = 29,
			[Token(Token = "0x40010D5")]
			UNITY_5_0_2 = 30,
			[Token(Token = "0x40010D6")]
			UNITY_5_1 = 31,
			[Token(Token = "0x40010D7")]
			UNITY_5_2 = 32,
			[Token(Token = "0x40010D8")]
			UNITY_5_3 = 33,
			[Token(Token = "0x40010D9")]
			UNITY_5_4 = 34,
			[Token(Token = "0x40010DA")]
			UNITY_5_5 = 35,
			[Token(Token = "0x40010DB")]
			UNITY_5_6 = 36,
			[Token(Token = "0x40010DC")]
			UNITY_5_7 = 37,
			[Token(Token = "0x40010DD")]
			UNITY_5_8 = 38,
			[Token(Token = "0x40010DE")]
			UNITY_5_9 = 39,
			[Token(Token = "0x40010DF")]
			UNITY_5_MAX = 40,
			[Token(Token = "0x40010E0")]
			UNITY_2017_0 = 41,
			[Token(Token = "0x40010E1")]
			UNITY_2017_1 = 42,
			[Token(Token = "0x40010E2")]
			UNITY_2017_2 = 43,
			[Token(Token = "0x40010E3")]
			UNITY_2017_3 = 44,
			[Token(Token = "0x40010E4")]
			UNITY_2017_4 = 45,
			[Token(Token = "0x40010E5")]
			UNITY_2017_5 = 46,
			[Token(Token = "0x40010E6")]
			UNITY_2017_6 = 47,
			[Token(Token = "0x40010E7")]
			UNITY_2017_7 = 48,
			[Token(Token = "0x40010E8")]
			UNITY_2017_8 = 49,
			[Token(Token = "0x40010E9")]
			UNITY_2017_9 = 50,
			[Token(Token = "0x40010EA")]
			UNITY_2017_MAX = 51,
			[Token(Token = "0x40010EB")]
			UNITY_2018_0 = 52,
			[Token(Token = "0x40010EC")]
			UNITY_2018_1 = 53,
			[Token(Token = "0x40010ED")]
			UNITY_2018_2 = 54,
			[Token(Token = "0x40010EE")]
			UNITY_2018_3 = 55,
			[Token(Token = "0x40010EF")]
			UNITY_2018_4 = 56,
			[Token(Token = "0x40010F0")]
			UNITY_2018_5 = 57,
			[Token(Token = "0x40010F1")]
			UNITY_2018_6 = 58,
			[Token(Token = "0x40010F2")]
			UNITY_2018_7 = 59,
			[Token(Token = "0x40010F3")]
			UNITY_2018_8 = 60,
			[Token(Token = "0x40010F4")]
			UNITY_2018_9 = 61,
			[Token(Token = "0x40010F5")]
			UNITY_2018_MAX = 62,
			[Token(Token = "0x40010F6")]
			UNITY_2019_0 = 63,
			[Token(Token = "0x40010F7")]
			UNITY_2019_1 = 64,
			[Token(Token = "0x40010F8")]
			UNITY_2019_2 = 65,
			[Token(Token = "0x40010F9")]
			UNITY_2019_3 = 66,
			[Token(Token = "0x40010FA")]
			UNITY_2019_4 = 67,
			[Token(Token = "0x40010FB")]
			UNITY_2019_5 = 68,
			[Token(Token = "0x40010FC")]
			UNITY_2019_6 = 69,
			[Token(Token = "0x40010FD")]
			UNITY_2019_7 = 70,
			[Token(Token = "0x40010FE")]
			UNITY_2019_8 = 71,
			[Token(Token = "0x40010FF")]
			UNITY_2019_9 = 72,
			[Token(Token = "0x4001100")]
			UNITY_2019_MAX = 73,
			[Token(Token = "0x4001101")]
			UNITY_2020_0 = 74,
			[Token(Token = "0x4001102")]
			UNITY_2020_1 = 75,
			[Token(Token = "0x4001103")]
			UNITY_2020_2 = 76,
			[Token(Token = "0x4001104")]
			UNITY_2020_3 = 77,
			[Token(Token = "0x4001105")]
			UNITY_2020_4 = 78,
			[Token(Token = "0x4001106")]
			UNITY_2020_5 = 79,
			[Token(Token = "0x4001107")]
			UNITY_2020_6 = 80,
			[Token(Token = "0x4001108")]
			UNITY_2020_7 = 81,
			[Token(Token = "0x4001109")]
			UNITY_2020_8 = 82,
			[Token(Token = "0x400110A")]
			UNITY_2020_9 = 83,
			[Token(Token = "0x400110B")]
			UNITY_2020_MAX = 84,
			[Token(Token = "0x400110C")]
			UNITY_2021_0 = 85,
			[Token(Token = "0x400110D")]
			UNITY_2021_1 = 86,
			[Token(Token = "0x400110E")]
			UNITY_2021_2 = 87,
			[Token(Token = "0x400110F")]
			UNITY_2021_3 = 88,
			[Token(Token = "0x4001110")]
			UNITY_2021_4 = 89,
			[Token(Token = "0x4001111")]
			UNITY_2021_5 = 90,
			[Token(Token = "0x4001112")]
			UNITY_2021_6 = 91,
			[Token(Token = "0x4001113")]
			UNITY_2021_7 = 92,
			[Token(Token = "0x4001114")]
			UNITY_2021_8 = 93,
			[Token(Token = "0x4001115")]
			UNITY_2021_9 = 94,
			[Token(Token = "0x4001116")]
			UNITY_2021_MAX = 95,
			[Token(Token = "0x4001117")]
			UNITY_2022_0 = 96,
			[Token(Token = "0x4001118")]
			UNITY_2022_1 = 97,
			[Token(Token = "0x4001119")]
			UNITY_2022_2 = 98,
			[Token(Token = "0x400111A")]
			UNITY_2022_3 = 99,
			[Token(Token = "0x400111B")]
			UNITY_2022_4 = 100,
			[Token(Token = "0x400111C")]
			UNITY_2022_5 = 101,
			[Token(Token = "0x400111D")]
			UNITY_2022_6 = 102,
			[Token(Token = "0x400111E")]
			UNITY_2022_7 = 103,
			[Token(Token = "0x400111F")]
			UNITY_2022_8 = 104,
			[Token(Token = "0x4001120")]
			UNITY_2022_9 = 105,
			[Token(Token = "0x4001121")]
			UNITY_2022_MAX = 106,
			[Token(Token = "0x4001122")]
			UNITY_2023_0 = 107,
			[Token(Token = "0x4001123")]
			UNITY_2023_1 = 108,
			[Token(Token = "0x4001124")]
			UNITY_2023_2 = 109,
			[Token(Token = "0x4001125")]
			UNITY_2023_3 = 110,
			[Token(Token = "0x4001126")]
			UNITY_2023_4 = 111,
			[Token(Token = "0x4001127")]
			UNITY_2023_5 = 112,
			[Token(Token = "0x4001128")]
			UNITY_2023_6 = 113,
			[Token(Token = "0x4001129")]
			UNITY_2023_7 = 114,
			[Token(Token = "0x400112A")]
			UNITY_2023_8 = 115,
			[Token(Token = "0x400112B")]
			UNITY_2023_9 = 116,
			[Token(Token = "0x400112C")]
			UNITY_2023_MAX = 117,
			[Token(Token = "0x400112D")]
			UNITY_2024_0 = 118,
			[Token(Token = "0x400112E")]
			UNITY_2024_1 = 119,
			[Token(Token = "0x400112F")]
			UNITY_2024_2 = 120,
			[Token(Token = "0x4001130")]
			UNITY_2024_3 = 121,
			[Token(Token = "0x4001131")]
			UNITY_2024_4 = 122,
			[Token(Token = "0x4001132")]
			UNITY_2024_5 = 123,
			[Token(Token = "0x4001133")]
			UNITY_2024_6 = 124,
			[Token(Token = "0x4001134")]
			UNITY_2024_7 = 125,
			[Token(Token = "0x4001135")]
			UNITY_2024_8 = 126,
			[Token(Token = "0x4001136")]
			UNITY_2024_9 = 127,
			[Token(Token = "0x4001137")]
			UNITY_2024_MAX = 128,
			[Token(Token = "0x4001138")]
			UNITY_2025_0 = 129,
			[Token(Token = "0x4001139")]
			UNITY_2025_1 = 130,
			[Token(Token = "0x400113A")]
			UNITY_2025_2 = 131,
			[Token(Token = "0x400113B")]
			UNITY_2025_3 = 132,
			[Token(Token = "0x400113C")]
			UNITY_2025_4 = 133,
			[Token(Token = "0x400113D")]
			UNITY_2025_5 = 134,
			[Token(Token = "0x400113E")]
			UNITY_2025_6 = 135,
			[Token(Token = "0x400113F")]
			UNITY_2025_7 = 136,
			[Token(Token = "0x4001140")]
			UNITY_2025_8 = 137,
			[Token(Token = "0x4001141")]
			UNITY_2025_9 = 138,
			[Token(Token = "0x4001142")]
			UNITY_2025_MAX = 139,
			[Token(Token = "0x4001143")]
			Unknown = 1000
		}

		[Token(Token = "0x2000345")]
		internal class UnityVersionClass
		{
			[Token(Token = "0x2000346")]
			public enum IdKBtoGKGXdBiBVmruyzejHHLBeB
			{
				[Token(Token = "0x400114A")]
				Normal = 0,
				[Token(Token = "0x400114B")]
				Beta = 1,
				[Token(Token = "0x400114C")]
				Patch = 2
			}

			[Token(Token = "0x4001144")]
			[FieldOffset(Offset = "0x10")]
			public readonly int major;

			[Token(Token = "0x4001145")]
			[FieldOffset(Offset = "0x14")]
			public readonly int minor;

			[Token(Token = "0x4001146")]
			[FieldOffset(Offset = "0x18")]
			public readonly int maintenance;

			[Token(Token = "0x4001147")]
			[FieldOffset(Offset = "0x1C")]
			public readonly IdKBtoGKGXdBiBVmruyzejHHLBeB type;

			[Token(Token = "0x4001148")]
			[FieldOffset(Offset = "0x20")]
			public readonly int build;

			[Token(Token = "0x6001946")]
			[Address(RVA = "0x2399E24", Offset = "0x2399E24", VA = "0x2399E24")]
			public UnityVersionClass(string P_0)
			{
			}

			[Token(Token = "0x6001947")]
			[Address(RVA = "0x239A15C", Offset = "0x239A15C", VA = "0x239A15C", Slot = "3")]
			public override string ToString()
			{
				return null;
			}

			[Token(Token = "0x6001948")]
			[Address(RVA = "0x239A38C", Offset = "0x239A38C", VA = "0x239A38C")]
			private string UcwUkFnuyhCHJjEdMNYqOKrNJrzs(IdKBtoGKGXdBiBVmruyzejHHLBeB P_0)
			{
				return null;
			}

			[Token(Token = "0x6001949")]
			[Address(RVA = "0x239A458", Offset = "0x239A458", VA = "0x239A458", Slot = "0")]
			public override bool Equals(object obj)
			{
				return default;
			}

			[Token(Token = "0x600194A")]
			[Address(RVA = "0x239A510", Offset = "0x239A510", VA = "0x239A510", Slot = "2")]
			public override int GetHashCode()
			{
				return default;
			}

			[Token(Token = "0x600194B")]
			[Address(RVA = "0x239A518", Offset = "0x239A518", VA = "0x239A518")]
			public static bool operator <(UnityVersionClass a, UnityVersionClass b)
			{
				return default;
			}

			[Token(Token = "0x600194C")]
			[Address(RVA = "0x239A650", Offset = "0x239A650", VA = "0x239A650")]
			public static bool operator >(UnityVersionClass a, UnityVersionClass b)
			{
				return default;
			}

			[Token(Token = "0x600194D")]
			[Address(RVA = "0x239A66C", Offset = "0x239A66C", VA = "0x239A66C")]
			public static bool operator >=(UnityVersionClass a, UnityVersionClass b)
			{
				return default;
			}

			[Token(Token = "0x600194E")]
			[Address(RVA = "0x239A4F4", Offset = "0x239A4F4", VA = "0x239A4F4")]
			public static bool operator ==(UnityVersionClass a, UnityVersionClass b)
			{
				return default;
			}

			[Token(Token = "0x600194F")]
			[Address(RVA = "0x239A688", Offset = "0x239A688", VA = "0x239A688")]
			public static bool operator !=(UnityVersionClass a, UnityVersionClass b)
			{
				return default;
			}

			[Token(Token = "0x6001950")]
			[Address(RVA = "0x239A530", Offset = "0x239A530", VA = "0x239A530")]
			public static int Comparison(UnityVersionClass a, UnityVersionClass b)
			{
				return default;
			}

			[Token(Token = "0x6001951")]
			[Address(RVA = "0x239A714", Offset = "0x239A714", VA = "0x239A714")]
			public static bool IsValidVersionString(string versionString)
			{
				return default;
			}

			[Token(Token = "0x6001952")]
			[Address(RVA = "0x239A6A4", Offset = "0x239A6A4", VA = "0x239A6A4")]
			private static int bpxDajArYFJyvGZidJeJAhYNSlAjb(IdKBtoGKGXdBiBVmruyzejHHLBeB P_0)
			{
				return default;
			}
		}

		[Token(Token = "0x40010A0")]
		[FieldOffset(Offset = "0x0")]
		private static UnityVersionClass WKDGXJHBvvsYdbmNMdZhdRinWpJtA;

		[Token(Token = "0x40010A1")]
		[FieldOffset(Offset = "0x8")]
		private static UnityVersion qVwNnaIwKNrVpkqQhRBKhjhZuDye;

		[Token(Token = "0x40010A2")]
		[FieldOffset(Offset = "0x10")]
		private static string IoIwulCwEMjdQlJPhJclayYFDMto;

		[Token(Token = "0x40010A3")]
		[FieldOffset(Offset = "0x18")]
		private static Platform NUaVSpthFXYMDNIKPHgmNhOikaUp;

		[Token(Token = "0x40010A4")]
		[FieldOffset(Offset = "0x1C")]
		private static EditorPlatform unICjthLTqHPNnLSrXcmbvFaXzQQ;

		[Token(Token = "0x40010A5")]
		[FieldOffset(Offset = "0x20")]
		private static bool EeJuUBdEjUCoScMzNOpcUaiJIrUTA;

		[Token(Token = "0x40010A6")]
		[FieldOffset(Offset = "0x21")]
		private static bool eASqtHcXNuWOmdyLdlSKBrgLxeyB;

		[Token(Token = "0x40010A7")]
		[FieldOffset(Offset = "0x22")]
		private static bool nsTdBglbvKegswWyQoyVJEKZxqSC;

		[Token(Token = "0x40010A8")]
		[FieldOffset(Offset = "0x24")]
		private static WebplayerPlatform EWHwzexfoiyRFhLiBgPzrmmYiUKt;

		[Token(Token = "0x40010A9")]
		[FieldOffset(Offset = "0x28")]
		private static bool vIcDklTouDODaGoOGHHRvWfRrlaK;

		[Token(Token = "0x40010AA")]
		[FieldOffset(Offset = "0x29")]
		private static bool kxEbCyVbRuHJsRnDcWwMYmtqMfVH;

		[Token(Token = "0x40010AB")]
		[FieldOffset(Offset = "0x2A")]
		private static bool qKowHndTsRGXHOxvxnNvDjwBPAlk;

		[Token(Token = "0x40010AC")]
		[FieldOffset(Offset = "0x2B")]
		private static bool aEEslyeYBovJgvgkzoyLDtbSKGax;

		[Token(Token = "0x40010AD")]
		[FieldOffset(Offset = "0x2C")]
		private static bool tYccRuDCVXrqnFUycwBfpPZuVldmA;

		[Token(Token = "0x40010AE")]
		[FieldOffset(Offset = "0x2D")]
		private static bool KQMNHcNXvGwZMVyxIaWAeUCkuQJb;

		[Token(Token = "0x40010AF")]
		[FieldOffset(Offset = "0x30")]
		private static string gMrbXjGXjLUEIlscMqaLpOhajlzQA;

		[Token(Token = "0x40010B0")]
		[FieldOffset(Offset = "0x38")]
		private static ScriptingBackend ouVOgQVxrwlaSCPFMoLNuMzrRnjD;

		[Token(Token = "0x40010B1")]
		[FieldOffset(Offset = "0x3C")]
		private static ScriptingAPILevel NSSlBrrVItfqnyxPaWEeNHgDiIfc;

		[Token(Token = "0x40010B2")]
		[FieldOffset(Offset = "0x40")]
		private static bool xygumqGoipOjosmbDJIHicflKAUM;

		[Token(Token = "0x40010B3")]
		[FieldOffset(Offset = "0x48")]
		private static IExternalTools GenhOyijtlFUEKeiWBPiAueyRoWEb;

		[Token(Token = "0x40010B4")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x194F74", Offset = "0x194F74")]
		private static IAndroidFallbackPlatformHelper EEBIvpMrPPGTmswSJPQoShMLTmzo;

		[Token(Token = "0x40010B5")]
		[FieldOffset(Offset = "0x58")]
		private static bool hOiPNTabIuSmDxoUqjBuGeUlmqMQ;

		[Token(Token = "0x1700069D")]
		internal static UnityVersionClass unityVersionObj
		{
			[Token(Token = "0x600190E")]
			[Address(RVA = "0x2434A08", Offset = "0x2434A08", VA = "0x2434A08")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700069E")]
		public static UnityVersion unityVersion
		{
			[Token(Token = "0x600190F")]
			[Address(RVA = "0x2434B2C", Offset = "0x2434B2C", VA = "0x2434B2C")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x1700069F")]
		public static string unityVersionString
		{
			[Token(Token = "0x6001910")]
			[Address(RVA = "0x2434BF8", Offset = "0x2434BF8", VA = "0x2434BF8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170006A0")]
		public static Platform platform
		{
			[Token(Token = "0x6001911")]
			[Address(RVA = "0x2434CE0", Offset = "0x2434CE0", VA = "0x2434CE0")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x170006A1")]
		internal static Platform effectivePlatform
		{
			[Token(Token = "0x6001912")]
			[Address(RVA = "0x2434DA8", Offset = "0x2434DA8", VA = "0x2434DA8")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x170006A2")]
		public static EditorPlatform editorPlatform
		{
			[Token(Token = "0x6001913")]
			[Address(RVA = "0x2434EF8", Offset = "0x2434EF8", VA = "0x2434EF8")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x170006A3")]
		public static bool isEditor
		{
			[Token(Token = "0x6001914")]
			[Address(RVA = "0x2434FC0", Offset = "0x2434FC0", VA = "0x2434FC0")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x170006A4")]
		public static WebplayerPlatform webplayerPlatform
		{
			[Token(Token = "0x6001915")]
			[Address(RVA = "0x2435090", Offset = "0x2435090", VA = "0x2435090")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x170006A5")]
		public static bool logToDebugLog
		{
			[Token(Token = "0x6001916")]
			[Address(RVA = "0x2435158", Offset = "0x2435158", VA = "0x2435158")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x170006A6")]
		public static bool isAndroidPlatform
		{
			[Token(Token = "0x6001917")]
			[Address(RVA = "0x2435314", Offset = "0x2435314", VA = "0x2435314")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x170006A7")]
		public static bool isIOSPlatform
		{
			[Token(Token = "0x6001918")]
			[Address(RVA = "0x2435464", Offset = "0x2435464", VA = "0x2435464")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x170006A8")]
		public static bool isStandalonePlatform
		{
			[Token(Token = "0x6001919")]
			[Address(RVA = "0x2435564", Offset = "0x2435564", VA = "0x2435564")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x170006A9")]
		public static bool windowsJoystickNamesReturnsEmptyStringsIfJoystickNull
		{
			[Token(Token = "0x600191A")]
			[Address(RVA = "0x243568C", Offset = "0x243568C", VA = "0x243568C")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x170006AA")]
		public static bool supportsUnityUIGraphicRaycastTarget
		{
			[Token(Token = "0x600191B")]
			[Address(RVA = "0x243575C", Offset = "0x243575C", VA = "0x243575C")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x170006AB")]
		public static IExternalTools externalTools
		{
			[Token(Token = "0x600191C")]
			[Address(RVA = "0x243582C", Offset = "0x243582C", VA = "0x243582C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170006AC")]
		internal static IAndroidFallbackPlatformHelper YamuuACgfaSgRUmyfSScpMCIdkMJ
		{
			[Token(Token = "0x600191D")]
			[Address(RVA = "0x24358F8", Offset = "0x24358F8", VA = "0x24358F8")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x197460", Offset = "0x197460")]
			get
			{
				return hOWRNKQaZRobGqmUAaeSIGKDMVZo();
			}
			[Token(Token = "0x600191E")]
			[Address(RVA = "0x243595C", Offset = "0x243595C", VA = "0x243595C")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x197470", Offset = "0x197470")]
			set
			{
				ANewaltkJCoDsFjRazvRNtaaGRue(androidFallbackPlatformHelper);
			}
		}

		[Token(Token = "0x170006AD")]
		internal static bool isInitialized
		{
			[Token(Token = "0x600191F")]
			[Address(RVA = "0x24359CC", Offset = "0x24359CC", VA = "0x24359CC")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x170006AE")]
		private static bool jYTNgflwwEgvgbZuuTHYnPAnuRao
		{
			[Token(Token = "0x6001920")]
			[Address(RVA = "0x2434AD4", Offset = "0x2434AD4", VA = "0x2434AD4")]
			get
			{
				return oWiLLgLAcaWwLQraDxjPnTAHOnSe();
			}
		}

		[Token(Token = "0x600191D")]
		[Address(RVA = "0x24358F8", Offset = "0x24358F8", VA = "0x24358F8")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x197460", Offset = "0x197460")]
		internal static IAndroidFallbackPlatformHelper hOWRNKQaZRobGqmUAaeSIGKDMVZo()
		{
			return null;
		}

		[Token(Token = "0x600191E")]
		[Address(RVA = "0x243595C", Offset = "0x243595C", VA = "0x243595C")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x197470", Offset = "0x197470")]
		internal static void ANewaltkJCoDsFjRazvRNtaaGRue(IAndroidFallbackPlatformHelper P_0)
		{
		}

		[Token(Token = "0x6001920")]
		[Address(RVA = "0x2434AD4", Offset = "0x2434AD4", VA = "0x2434AD4")]
		private static bool oWiLLgLAcaWwLQraDxjPnTAHOnSe()
		{
			return default;
		}

		[Token(Token = "0x6001921")]
		[Address(RVA = "0x2435A30", Offset = "0x2435A30", VA = "0x2435A30")]
		private static bool rCpHLxCNrAeHtqhxEZNVQHSUNDrwA()
		{
			return default;
		}

		[Token(Token = "0x6001922")]
		[Address(RVA = "0x2435D00", Offset = "0x2435D00", VA = "0x2435D00")]
		internal static void zQQfvDZMmpVqPPLYlLuSJXXpwJcI(Platform P_0, EditorPlatform P_1, bool P_2, WebplayerPlatform P_3, ScriptingBackend P_4, ScriptingAPILevel P_5, IExternalTools P_6)
		{
		}

		[Token(Token = "0x6001923")]
		[Address(RVA = "0x24362F0", Offset = "0x24362F0", VA = "0x24362F0")]
		public static bool IsUnityVersionInRange(string minVersionStr, string maxVersionStr)
		{
			return default;
		}

		[Token(Token = "0x6001924")]
		[Address(RVA = "0x24366CC", Offset = "0x24366CC", VA = "0x24366CC")]
		private static bool nsgecAbbzQBoZawtDCxTLGoqbMgqb(string P_0, out int P_1)
		{
			return default;
		}

		[Token(Token = "0x6001925")]
		[Address(RVA = "0x2435BD8", Offset = "0x2435BD8", VA = "0x2435BD8")]
		private static void AoPTostLTAzbmulaZRzQbWAogDGr()
		{
		}

		[Token(Token = "0x6001926")]
		[Address(RVA = "0x24367D4", Offset = "0x24367D4", VA = "0x24367D4")]
		private static UnityVersion gRolDcIonkgmZfMqIjqxrMqqDLbAA(string P_0)
		{
			return default;
		}

		[Token(Token = "0x6001927")]
		[Address(RVA = "0x2435F50", Offset = "0x2435F50", VA = "0x2435F50")]
		private static void VsuyKCUSXYpmazQaXxRJqaRPMOru()
		{
		}

		[Token(Token = "0x6001928")]
		[Address(RVA = "0x2436EC4", Offset = "0x2436EC4", VA = "0x2436EC4")]
		public static List<string> GetCurrentPlatformResourecesDLLPaths()
		{
			return null;
		}

		[Token(Token = "0x6001929")]
		public static T GetComponent<T>(Transform transform) where T : class
		{
			return null;
		}

		[Token(Token = "0x600192A")]
		public static T GetComponent<T>(Component component) where T : class
		{
			return null;
		}

		[Token(Token = "0x600192B")]
		public static T GetComponent<T>(GameObject gameObject) where T : class
		{
			return null;
		}

		[Token(Token = "0x600192C")]
		public static T GetComponentInChildren<T>(GameObject gameObject) where T : class
		{
			return null;
		}

		[Token(Token = "0x600192D")]
		public static T GetComponentInChildren<T>(Transform transform) where T : class
		{
			return null;
		}

		[Token(Token = "0x600192E")]
		public static T GetComponentInSelfOrChildren<T>(GameObject gameObject) where T : class
		{
			return null;
		}

		[Token(Token = "0x600192F")]
		public static T GetComponentInSelfOrParents<T>(GameObject gameObject) where T : class
		{
			return null;
		}

		[Token(Token = "0x6001930")]
		public static T GetComponentInSelfOrParents<T>(Transform transform) where T : class
		{
			return null;
		}

		[Token(Token = "0x6001931")]
		public static List<T> GetComponentsInSelfAndChildren<T>(Component component) where T : class
		{
			return null;
		}

		[Token(Token = "0x6001932")]
		public static List<T> GetComponentsInSelfAndChildren<T>(GameObject gameObject) where T : class
		{
			return null;
		}

		[Token(Token = "0x6001933")]
		public static int GetComponents<T>(Transform transform, List<T> results, bool append) where T : class
		{
			return default;
		}

		[Token(Token = "0x6001934")]
		public static int GetComponents<T>(GameObject gameObject, List<T> results, bool append) where T : class
		{
			return default;
		}

		[Token(Token = "0x6001935")]
		public static int GetComponentsInSelfAndChildren<T>(Transform transform, List<T> results, bool append) where T : class
		{
			return default;
		}

		[Token(Token = "0x6001936")]
		public static int GetComponentsInParents<T>(Transform transform, List<T> results, bool append) where T : class
		{
			return default;
		}

		[Token(Token = "0x6001937")]
		public static int GetComponentsInParents<T>(GameObject gameObject, List<T> results, bool append) where T : class
		{
			return default;
		}

		[Token(Token = "0x6001938")]
		[Address(RVA = "0x242FD90", Offset = "0x242FD90", VA = "0x242FD90")]
		public static bool IsActiveAndEnabled(Component component)
		{
			return default;
		}

		[Token(Token = "0x6001939")]
		public static T Instantiate<T>(Object original, Transform parent, bool instantiateInWorldSpace) where T : Object
		{
			return null;
		}

		[Token(Token = "0x600193A")]
		public static T Instantiate<T>(Object original, Vector3 position, Quaternion rotation, Transform parent, bool instantiateInWorldSpace) where T : Object
		{
			return null;
		}

		[Token(Token = "0x600193B")]
		[Address(RVA = "0x2437060", Offset = "0x2437060", VA = "0x2437060")]
		public static Vector3 TransformPoint(Transform from, Transform to, Vector3 point)
		{
			return default;
		}

		[Token(Token = "0x600193C")]
		internal static bool IsObjectInScene<T>(T @object) where T : Object
		{
			return default;
		}

		[Token(Token = "0x600193D")]
		[Address(RVA = "0x2437184", Offset = "0x2437184", VA = "0x2437184")]
		public static string GetUnityInputAxisName(int unityJoystickIndex, int axisIndex)
		{
			return null;
		}

		[Token(Token = "0x600193E")]
		[Address(RVA = "0x2437278", Offset = "0x2437278", VA = "0x2437278")]
		public static string GetUnityInputAxisNameByJoystickId(int unityJoystickId, int axisIndex)
		{
			return null;
		}

		[Token(Token = "0x600193F")]
		[Address(RVA = "0x2437324", Offset = "0x2437324", VA = "0x2437324")]
		public static string GetUnityInputButtonName(int unityJoystickIndex, int buttonIndex)
		{
			return null;
		}

		[Token(Token = "0x6001940")]
		[Address(RVA = "0x243740C", Offset = "0x243740C", VA = "0x243740C")]
		public static string GetUnityInputButtonNameByJoystickId(int unityJoystickId, int buttonIndex)
		{
			return null;
		}

		[Token(Token = "0x6001941")]
		[Address(RVA = "0x24374A8", Offset = "0x24374A8", VA = "0x24374A8")]
		public static bool IsValidUnityJoystickName(string name)
		{
			return default;
		}

		[Token(Token = "0x6001942")]
		[Address(RVA = "0x243765C", Offset = "0x243765C", VA = "0x243765C")]
		public static AnimationCurve Copy(AnimationCurve orig)
		{
			return null;
		}

		[Token(Token = "0x6001943")]
		public static bool IsNullOrDestroyed<T>(T @object) where T : class
		{
			return default;
		}

		[Token(Token = "0x6001944")]
		private static _0001 VVfnZlmfPVrEJDFZDSLyMYXCGIlt<_0001>(_0001 P_0) where _0001 : class
		{
			return null;
		}
	}
}
