using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.SceneManagement;

namespace I2.Loc
{
	[Serializable]
	[Token(Token = "0x20012EF")]
	[ExecuteInEditMode]
	public class LanguageSourceData
	{
		[Token(Token = "0x20012F0")]
		public enum MissingTranslationAction
		{
			[Token(Token = "0x40065F8")]
			Empty = 0,
			[Token(Token = "0x40065F9")]
			Fallback = 1,
			[Token(Token = "0x40065FA")]
			ShowWarning = 2,
			[Token(Token = "0x40065FB")]
			ShowTerm = 3
		}

		[Token(Token = "0x20012F1")]
		public enum eAllowUnloadLanguages
		{
			[Token(Token = "0x40065FD")]
			Never = 0,
			[Token(Token = "0x40065FE")]
			OnlyInDevice = 1,
			[Token(Token = "0x40065FF")]
			EditorAndDevice = 2
		}

		[Token(Token = "0x20012F2")]
		public enum eGoogleUpdateFrequency
		{
			[Token(Token = "0x4006601")]
			Always = 0,
			[Token(Token = "0x4006602")]
			Never = 1,
			[Token(Token = "0x4006603")]
			Daily = 2,
			[Token(Token = "0x4006604")]
			Weekly = 3,
			[Token(Token = "0x4006605")]
			Monthly = 4,
			[Token(Token = "0x4006606")]
			OnlyOnce = 5,
			[Token(Token = "0x4006607")]
			EveryOtherDay = 6
		}

		[Token(Token = "0x20012F3")]
		public enum eGoogleUpdateSynchronization
		{
			[Token(Token = "0x4006609")]
			Manual = 0,
			[Token(Token = "0x400660A")]
			OnSceneLoaded = 1,
			[Token(Token = "0x400660B")]
			AsSoonAsDownloaded = 2
		}

		[Serializable]
		[Token(Token = "0x20012F4")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x48AC0", Offset = "0x48AC0")]
		private sealed class _003C_003Ec
		{
			[Token(Token = "0x400660C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static readonly _003C_003Ec _003C_003E9;

			[Token(Token = "0x400660D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public static Predicate<UnityEngine.Object> _003C_003E9__39_0;

			[Token(Token = "0x400660E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public static Func<UnityEngine.Object, string> _003C_003E9__39_1;

			[Token(Token = "0x400660F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public static Func<IGrouping<string, UnityEngine.Object>, string> _003C_003E9__39_2;

			[Token(Token = "0x4006610")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public static Func<IGrouping<string, UnityEngine.Object>, UnityEngine.Object> _003C_003E9__39_3;

			[Token(Token = "0x4006611")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public static Func<string, int, _003C_003Ef__AnonymousType0<int, string>> _003C_003E9__55_0;

			[Token(Token = "0x4006612")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public static Func<_003C_003Ef__AnonymousType0<int, string>, bool> _003C_003E9__55_1;

			[Token(Token = "0x4006613")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public static Func<_003C_003Ef__AnonymousType0<int, string>, int> _003C_003E9__55_2;

			[Token(Token = "0x60057FF")]
			[Address(RVA = "0x17CDBA4", Offset = "0x17CDBA4", VA = "0x17CDBA4")]
			public _003C_003Ec()
			{
			}

			[Token(Token = "0x6005800")]
			[Address(RVA = "0x17CDBAC", Offset = "0x17CDBAC", VA = "0x17CDBAC")]
			internal bool _003CUpdateAssetDictionary_003Eb__39_0(UnityEngine.Object x)
			{
				return default;
			}

			[Token(Token = "0x6005801")]
			[Address(RVA = "0x17CDC1C", Offset = "0x17CDC1C", VA = "0x17CDC1C")]
			internal string _003CUpdateAssetDictionary_003Eb__39_1(UnityEngine.Object o)
			{
				return null;
			}

			[Token(Token = "0x6005802")]
			[Address(RVA = "0x17CDC38", Offset = "0x17CDC38", VA = "0x17CDC38")]
			internal string _003CUpdateAssetDictionary_003Eb__39_2(IGrouping<string, UnityEngine.Object> g)
			{
				return null;
			}

			[Token(Token = "0x6005803")]
			[Address(RVA = "0x17CDCE8", Offset = "0x17CDCE8", VA = "0x17CDCE8")]
			internal UnityEngine.Object _003CUpdateAssetDictionary_003Eb__39_3(IGrouping<string, UnityEngine.Object> g)
			{
				return null;
			}

			[Token(Token = "0x6005804")]
			[Address(RVA = "0x17CDD3C", Offset = "0x17CDD3C", VA = "0x17CDD3C")]
			internal _003C_003Ef__AnonymousType0<int, string> _003CImport_CSV_003Eb__55_0(string val, int index)
			{
				return null;
			}

			[Token(Token = "0x6005805")]
			[Address(RVA = "0x17CDDC8", Offset = "0x17CDDC8", VA = "0x17CDDC8")]
			internal bool _003CImport_CSV_003Eb__55_1(_003C_003Ef__AnonymousType0<int, string> c)
			{
				return default;
			}

			[Token(Token = "0x6005806")]
			[Address(RVA = "0x17CDE30", Offset = "0x17CDE30", VA = "0x17CDE30")]
			internal int _003CImport_CSV_003Eb__55_2(_003C_003Ef__AnonymousType0<int, string> c)
			{
				return default;
			}
		}

		[Token(Token = "0x20012F5")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x48AD0", Offset = "0x48AD0")]
		private sealed class _003C_003Ec__DisplayClass55_0
		{
			[Token(Token = "0x4006614")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public List<int> columnsToRemove;

			[Token(Token = "0x4006615")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Func<string, int, bool> _003C_003E9__3;

			[Token(Token = "0x6005807")]
			[Address(RVA = "0x17CDE78", Offset = "0x17CDE78", VA = "0x17CDE78")]
			public _003C_003Ec__DisplayClass55_0()
			{
			}

			[Token(Token = "0x6005808")]
			[Address(RVA = "0x17CDE80", Offset = "0x17CDE80", VA = "0x17CDE80")]
			internal bool _003CImport_CSV_003Eb__3(string val, int index)
			{
				return default;
			}
		}

		[Token(Token = "0x20012F6")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x48AE0", Offset = "0x48AE0")]
		private sealed class _003CImport_Google_Coroutine_003Ed__65 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4006616")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int _003C_003E1__state;

			[Token(Token = "0x4006617")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object _003C_003E2__current;

			[Token(Token = "0x4006618")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public LanguageSourceData _003C_003E4__this;

			[Token(Token = "0x4006619")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public bool JustCheck;

			[Token(Token = "0x400661A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private UnityWebRequest _003Cwww_003E5__2;

			[Token(Token = "0x17000A0B")]
			private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
			{
				[Token(Token = "0x600580C")]
				[Address(RVA = "0x17CE218", Offset = "0x17CE218", VA = "0x17CE218", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
				}
			}

			[Token(Token = "0x17000A0C")]
			private object System_002ECollections_002EIEnumerator_002ECurrent
			{
				[Token(Token = "0x600580E")]
				[Address(RVA = "0x17CE260", Offset = "0x17CE260", VA = "0x17CE260", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EIEnumerator_002Eget_Current();
				}
			}

			[Token(Token = "0x6005809")]
			[Address(RVA = "0x17CDEEC", Offset = "0x17CDEEC", VA = "0x17CDEEC")]
			[DebuggerHidden]
			public _003CImport_Google_Coroutine_003Ed__65(int _003C_003E1__state)
			{
			}

			[Token(Token = "0x600580A")]
			[Address(RVA = "0x17CDF18", Offset = "0x17CDF18", VA = "0x17CDF18", Slot = "5")]
			[DebuggerHidden]
			private void System_002EIDisposable_002EDispose()
			{
			}

			[Token(Token = "0x600580B")]
			[Address(RVA = "0x17CDF1C", Offset = "0x17CDF1C", VA = "0x17CDF1C", Slot = "6")]
			private bool MoveNext()
			{
				return default;
			}

			[Token(Token = "0x600580C")]
			[Address(RVA = "0x17CE218", Offset = "0x17CE218", VA = "0x17CE218", Slot = "4")]
			[DebuggerHidden]
			private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
			{
				return null;
			}

			[Token(Token = "0x600580D")]
			[Address(RVA = "0x17CE220", Offset = "0x17CE220", VA = "0x17CE220", Slot = "8")]
			[DebuggerHidden]
			private void System_002ECollections_002EIEnumerator_002EReset()
			{
			}

			[Token(Token = "0x600580E")]
			[Address(RVA = "0x17CE260", Offset = "0x17CE260", VA = "0x17CE260", Slot = "7")]
			[DebuggerHidden]
			private object System_002ECollections_002EIEnumerator_002Eget_Current()
			{
				return null;
			}
		}

		[NonSerialized]
		[Token(Token = "0x40065DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public ILanguageSource owner;

		[Token(Token = "0x40065DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public bool UserAgreesToHaveItOnTheScene;

		[Token(Token = "0x40065DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
		public bool UserAgreesToHaveItInsideThePluginsFolder;

		[Token(Token = "0x40065DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1A")]
		public bool GoogleLiveSyncIsUptoDate;

		[NonSerialized]
		[Token(Token = "0x40065E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1B")]
		public bool mIsGlobalSource;

		[Token(Token = "0x40065E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public List<TermData> mTerms;

		[Token(Token = "0x40065E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public bool CaseInsensitiveTerms;

		[NonSerialized]
		[Token(Token = "0x40065E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Dictionary<string, TermData> mDictionary;

		[Token(Token = "0x40065E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public MissingTranslationAction OnMissingTranslation;

		[Token(Token = "0x40065E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public string mTerm_AppName;

		[Token(Token = "0x40065E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public List<LanguageData> mLanguages;

		[Token(Token = "0x40065E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public bool IgnoreDeviceLanguage;

		[Token(Token = "0x40065E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		public eAllowUnloadLanguages _AllowUnloadingLanguages;

		[Token(Token = "0x40065E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public string Google_WebServiceURL;

		[Token(Token = "0x40065EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public string Google_SpreadsheetKey;

		[Token(Token = "0x40065EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public string Google_SpreadsheetName;

		[Token(Token = "0x40065EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public string Google_LastUpdatedVersion;

		[Token(Token = "0x40065ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public eGoogleUpdateFrequency GoogleUpdateFrequency;

		[Token(Token = "0x40065EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		public eGoogleUpdateFrequency GoogleInEditorCheckFrequency;

		[Token(Token = "0x40065EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public eGoogleUpdateSynchronization GoogleUpdateSynchronization;

		[Token(Token = "0x40065F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		public float GoogleUpdateDelay;

		[Token(Token = "0x40065F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x59B5C", Offset = "0x59B5C")]
		private LanguageSource.fnOnSourceUpdated m_Event_OnSourceUpdateFromGoogle;

		[Token(Token = "0x40065F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public List<UnityEngine.Object> Assets;

		[NonSerialized]
		[Token(Token = "0x40065F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public Dictionary<string, UnityEngine.Object> mAssetDictionary;

		[Token(Token = "0x40065F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private string mDelayedGoogleData;

		[Token(Token = "0x40065F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static string EmptyCategory;

		[Token(Token = "0x40065F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public static char[] CategorySeparators;

		[Token(Token = "0x1400009A")]
		public event LanguageSource.fnOnSourceUpdated Event_OnSourceUpdateFromGoogle
		{
			[Token(Token = "0x60057CD")]
			[Address(RVA = "0x15039BC", Offset = "0x15039BC", VA = "0x15039BC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x71E44", Offset = "0x71E44")]
			add
			{
			}
			[Token(Token = "0x60057CE")]
			[Address(RVA = "0x1503C30", Offset = "0x1503C30", VA = "0x1503C30")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x71E54", Offset = "0x71E54")]
			remove
			{
			}
		}

		[Token(Token = "0x60057CF")]
		[Address(RVA = "0x1503174", Offset = "0x1503174", VA = "0x1503174")]
		public void Awake()
		{
		}

		[Token(Token = "0x60057D0")]
		[Address(RVA = "0x1503278", Offset = "0x1503278", VA = "0x1503278")]
		public void OnDestroy()
		{
		}

		[Token(Token = "0x60057D1")]
		[Address(RVA = "0x1504450", Offset = "0x1504450", VA = "0x1504450")]
		public void ClearAllData()
		{
		}

		[Token(Token = "0x60057D2")]
		[Address(RVA = "0x1504510", Offset = "0x1504510", VA = "0x1504510")]
		public void Editor_SetDirty()
		{
		}

		[Token(Token = "0x60057D3")]
		[Address(RVA = "0x1504024", Offset = "0x1504024", VA = "0x1504024")]
		public void UpdateAssetDictionary()
		{
		}

		[Token(Token = "0x60057D4")]
		[Address(RVA = "0x1504514", Offset = "0x1504514", VA = "0x1504514")]
		public UnityEngine.Object FindAsset(string Name)
		{
			return null;
		}

		[Token(Token = "0x60057D5")]
		[Address(RVA = "0x15045F4", Offset = "0x15045F4", VA = "0x15045F4")]
		private string Export_Language_to_Cache(int langIndex, bool fillTermWithFallback)
		{
			return null;
		}

		[Token(Token = "0x60057D6")]
		[Address(RVA = "0x1504BC0", Offset = "0x1504BC0", VA = "0x1504BC0")]
		public string Import_I2CSV(string Category, string I2CSVstring, eSpreadsheetUpdateMode UpdateMode = eSpreadsheetUpdateMode.Replace)
		{
			return null;
		}

		[Token(Token = "0x60057D7")]
		[Address(RVA = "0x1504C08", Offset = "0x1504C08", VA = "0x1504C08")]
		public string Import_CSV(string Category, List<string[]> CSV, eSpreadsheetUpdateMode UpdateMode = eSpreadsheetUpdateMode.Replace)
		{
			return null;
		}

		[Token(Token = "0x60057D8")]
		[Address(RVA = "0x1505E20", Offset = "0x1505E20", VA = "0x1505E20")]
		private bool ArrayContains(string MainText, params string[] texts)
		{
			return default;
		}

		[Token(Token = "0x60057D9")]
		[Address(RVA = "0x15066DC", Offset = "0x15066DC", VA = "0x15066DC")]
		public static eTermType GetTermType(string type)
		{
			return default;
		}

		[Token(Token = "0x60057DA")]
		[Address(RVA = "0x1506974", Offset = "0x1506974", VA = "0x1506974")]
		private void Import_Language_from_Cache(int langIndex, string langData, bool useFallback, bool onlyCurrentSpecialization)
		{
		}

		[Token(Token = "0x60057DB")]
		[Address(RVA = "0x1506BA4", Offset = "0x1506BA4", VA = "0x1506BA4")]
		public void Import_Google_FromCache()
		{
		}

		[Token(Token = "0x60057DC")]
		[Address(RVA = "0x1507028", Offset = "0x1507028", VA = "0x1507028")]
		private bool IsNewerVersion(string currentVersion, string newVersion)
		{
			return default;
		}

		[Token(Token = "0x60057DD")]
		[Address(RVA = "0x15077A0", Offset = "0x15077A0", VA = "0x15077A0")]
		public void Import_Google(bool ForceUpdate, bool justCheck)
		{
		}

		[Token(Token = "0x60057DE")]
		[Address(RVA = "0x1506E54", Offset = "0x1506E54", VA = "0x1506E54")]
		private string GetSourcePlayerPrefName()
		{
			return null;
		}

		[Token(Token = "0x60057DF")]
		[Address(RVA = "0x1507A98", Offset = "0x1507A98", VA = "0x1507A98")]
		private IEnumerator Import_Google_Coroutine(bool JustCheck)
		{
			return null;
		}

		[Token(Token = "0x60057E0")]
		[Address(RVA = "0x1507B14", Offset = "0x1507B14", VA = "0x1507B14")]
		private void ApplyDownloadedDataOnSceneLoaded(Scene scene, LoadSceneMode mode)
		{
		}

		[Token(Token = "0x60057E1")]
		[Address(RVA = "0x1507BE8", Offset = "0x1507BE8", VA = "0x1507BE8")]
		public void ApplyDownloadedDataFromGoogle()
		{
		}

		[Token(Token = "0x60057E2")]
		[Address(RVA = "0x1507D74", Offset = "0x1507D74", VA = "0x1507D74")]
		public UnityWebRequest Import_Google_CreateWWWcall(bool ForceUpdate, bool justCheck)
		{
			return null;
		}

		[Token(Token = "0x60057E3")]
		[Address(RVA = "0x1507F40", Offset = "0x1507F40", VA = "0x1507F40")]
		public bool HasGoogleSpreadsheet()
		{
			return default;
		}

		[Token(Token = "0x60057E4")]
		[Address(RVA = "0x15070B8", Offset = "0x15070B8", VA = "0x15070B8")]
		public string Import_Google_Result(string JsonString, eSpreadsheetUpdateMode UpdateMode, bool saveInPlayerPrefs = false)
		{
			return null;
		}

		[Token(Token = "0x60057E5")]
		[Address(RVA = "0x15060A0", Offset = "0x15060A0", VA = "0x15060A0")]
		public int GetLanguageIndex(string language, bool AllowDiscartingRegion = true, bool SkipDisabled = true)
		{
			return default;
		}

		[Token(Token = "0x60057E6")]
		[Address(RVA = "0x15081BC", Offset = "0x15081BC", VA = "0x15081BC")]
		public bool IsCurrentLanguage(int languageIndex)
		{
			return default;
		}

		[Token(Token = "0x60057E7")]
		[Address(RVA = "0x1505EC8", Offset = "0x1505EC8", VA = "0x1505EC8")]
		public int GetLanguageIndexFromCode(string Code, bool exactMatch = true, bool ignoreDisabled = false)
		{
			return default;
		}

		[Token(Token = "0x60057E8")]
		[Address(RVA = "0x1507FDC", Offset = "0x1507FDC", VA = "0x1507FDC")]
		public static int GetCommonWordInLanguageNames(string Language1, string Language2)
		{
			return default;
		}

		[Token(Token = "0x60057E9")]
		[Address(RVA = "0x1508278", Offset = "0x1508278", VA = "0x1508278")]
		public List<string> GetLanguages(bool skipDisabled = true)
		{
			return null;
		}

		[Token(Token = "0x60057EA")]
		[Address(RVA = "0x15083D8", Offset = "0x15083D8", VA = "0x15083D8")]
		public List<string> GetLanguagesCode(bool allowRegions = true, bool skipDisabled = true)
		{
			return null;
		}

		[Token(Token = "0x60057EB")]
		[Address(RVA = "0x15085B0", Offset = "0x15085B0", VA = "0x15085B0")]
		public bool IsLanguageEnabled(string Language)
		{
			return default;
		}

		[Token(Token = "0x60057EC")]
		[Address(RVA = "0x150865C", Offset = "0x150865C", VA = "0x150865C")]
		public bool AllowUnloadingLanguages()
		{
			return default;
		}

		[Token(Token = "0x60057ED")]
		[Address(RVA = "0x150866C", Offset = "0x150866C", VA = "0x150866C")]
		private string GetSavedLanguageFileName(int languageIndex)
		{
			return null;
		}

		[Token(Token = "0x60057EE")]
		[Address(RVA = "0x150886C", Offset = "0x150886C", VA = "0x150886C")]
		public void LoadLanguage(int languageIndex, bool UnloadOtherLanguages, bool useFallback, bool onlyCurrentSpecialization, bool forceLoad)
		{
		}

		[Token(Token = "0x60057EF")]
		[Address(RVA = "0x1508A04", Offset = "0x1508A04", VA = "0x1508A04")]
		public void UnloadLanguage(int languageIndex)
		{
		}

		[Token(Token = "0x60057F0")]
		[Address(RVA = "0x150684C", Offset = "0x150684C", VA = "0x150684C")]
		public void SaveLanguages(bool unloadAll, PersistentStorage.eFileType fileLocation = PersistentStorage.eFileType.Temporal)
		{
		}

		[Token(Token = "0x60057F1")]
		[Address(RVA = "0x15067A8", Offset = "0x15067A8", VA = "0x15067A8")]
		public bool HasUnloadedLanguages()
		{
			return default;
		}

		[Token(Token = "0x60057F2")]
		[Address(RVA = "0x1508CA0", Offset = "0x1508CA0", VA = "0x1508CA0")]
		public List<string> GetCategories([Optional][DefaultParameterValue(false)] bool OnlyMainCategory, [Optional] List<string> Categories)
		{
			return null;
		}

		[Token(Token = "0x60057F3")]
		[Address(RVA = "0x1509034", Offset = "0x1509034", VA = "0x1509034")]
		public static string GetKeyFromFullTerm(string FullTerm, bool OnlyMainCategory = false)
		{
			return null;
		}

		[Token(Token = "0x60057F4")]
		[Address(RVA = "0x1508F28", Offset = "0x1508F28", VA = "0x1508F28")]
		public static string GetCategoryFromFullTerm(string FullTerm, bool OnlyMainCategory = false)
		{
			return null;
		}

		[Token(Token = "0x60057F5")]
		[Address(RVA = "0x1503CD4", Offset = "0x1503CD4", VA = "0x1503CD4")]
		public void UpdateDictionary(bool force = false)
		{
		}

		[Token(Token = "0x60057F6")]
		[Address(RVA = "0x1509118", Offset = "0x1509118", VA = "0x1509118")]
		public bool TryGetTranslation(string term, out string Translation, [Optional] string overrideLanguage, [Optional] string overrideSpecialization, bool skipDisabled = false, bool allowCategoryMistmatch = false)
		{
			return default;
		}

		[Token(Token = "0x60057F7")]
		[Address(RVA = "0x15048E4", Offset = "0x15048E4", VA = "0x15048E4")]
		private bool TryGetFallbackTranslation(TermData termData, out string Translation, int langIndex, [Optional] string overrideSpecialization, bool skipDisabled = false)
		{
			return default;
		}

		[Token(Token = "0x60057F8")]
		[Address(RVA = "0x150646C", Offset = "0x150646C", VA = "0x150646C")]
		public TermData GetTermData(string term, bool allowCategoryMistmatch = false)
		{
			return null;
		}

		[Token(Token = "0x60057F9")]
		[Address(RVA = "0x1509360", Offset = "0x1509360", VA = "0x1509360")]
		public bool ContainsTerm(string term)
		{
			return default;
		}

		[Token(Token = "0x60057FA")]
		[Address(RVA = "0x1509380", Offset = "0x1509380", VA = "0x1509380")]
		public List<string> GetTermsList([Optional] string Category)
		{
			return null;
		}

		[Token(Token = "0x60057FB")]
		[Address(RVA = "0x15062BC", Offset = "0x15062BC", VA = "0x15062BC")]
		public static void ValidateFullTerm(ref string Term)
		{
		}

		[Token(Token = "0x60057FC")]
		[Address(RVA = "0x1503750", Offset = "0x1503750", VA = "0x1503750")]
		public LanguageSourceData()
		{
		}
	}
}
