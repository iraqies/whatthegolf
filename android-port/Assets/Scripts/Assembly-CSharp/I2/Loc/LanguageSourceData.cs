using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.SceneManagement;

namespace I2.Loc
{
	[Serializable]
	[ExecuteInEditMode]
	public class LanguageSourceData
	{
		public enum MissingTranslationAction
		{
			Empty = 0,
			Fallback = 1,
			ShowWarning = 2,
			ShowTerm = 3
		}

		public enum eAllowUnloadLanguages
		{
			Never = 0,
			OnlyInDevice = 1,
			EditorAndDevice = 2
		}

		public enum eGoogleUpdateFrequency
		{
			Always = 0,
			Never = 1,
			Daily = 2,
			Weekly = 3,
			Monthly = 4,
			OnlyOnce = 5,
			EveryOtherDay = 6
		}

		public enum eGoogleUpdateSynchronization
		{
			Manual = 0,
			OnSceneLoaded = 1,
			AsSoonAsDownloaded = 2
		}

		[NonSerialized]
		public ILanguageSource owner;

		public bool UserAgreesToHaveItOnTheScene;

		public bool UserAgreesToHaveItInsideThePluginsFolder;

		public bool GoogleLiveSyncIsUptoDate;

		[NonSerialized]
		public bool mIsGlobalSource;

		public List<TermData> mTerms;

		public bool CaseInsensitiveTerms;

		[NonSerialized]
		public Dictionary<string, TermData> mDictionary;

		public MissingTranslationAction OnMissingTranslation;

		public string mTerm_AppName;

		public List<LanguageData> mLanguages;

		public bool IgnoreDeviceLanguage;

		public eAllowUnloadLanguages _AllowUnloadingLanguages;

		public string Google_WebServiceURL;

		public string Google_SpreadsheetKey;

		public string Google_SpreadsheetName;

		public string Google_LastUpdatedVersion;

		public eGoogleUpdateFrequency GoogleUpdateFrequency;

		public eGoogleUpdateFrequency GoogleInEditorCheckFrequency;

		public eGoogleUpdateSynchronization GoogleUpdateSynchronization;

		public float GoogleUpdateDelay;

		[CompilerGenerated]
		private LanguageSource.fnOnSourceUpdated m_Event_OnSourceUpdateFromGoogle;

		public List<UnityEngine.Object> Assets;

		[NonSerialized]
		public Dictionary<string, UnityEngine.Object> mAssetDictionary;

		private string mDelayedGoogleData;

		public static string EmptyCategory;

		public static char[] CategorySeparators;

		public event LanguageSource.fnOnSourceUpdated Event_OnSourceUpdateFromGoogle
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public void Awake()
		{
		}

		public void OnDestroy()
		{
		}

		public void ClearAllData()
		{
		}

		public void Editor_SetDirty()
		{
		}

		public void UpdateAssetDictionary()
		{
		}

		public UnityEngine.Object FindAsset(string Name)
		{
			return null;
		}

		private string Export_Language_to_Cache(int langIndex, bool fillTermWithFallback)
		{
			return null;
		}

		public string Import_I2CSV(string Category, string I2CSVstring, eSpreadsheetUpdateMode UpdateMode = eSpreadsheetUpdateMode.Replace)
		{
			return null;
		}

		public string Import_CSV(string Category, List<string[]> CSV, eSpreadsheetUpdateMode UpdateMode = eSpreadsheetUpdateMode.Replace)
		{
			return null;
		}

		private bool ArrayContains(string MainText, params string[] texts)
		{
			return false;
		}

		public static eTermType GetTermType(string type)
		{
			return eTermType.Text;
		}

		private void Import_Language_from_Cache(int langIndex, string langData, bool useFallback, bool onlyCurrentSpecialization)
		{
		}

		public void Import_Google_FromCache()
		{
		}

		private bool IsNewerVersion(string currentVersion, string newVersion)
		{
			return false;
		}

		public void Import_Google(bool ForceUpdate, bool justCheck)
		{
		}

		private string GetSourcePlayerPrefName()
		{
			return null;
		}

		private IEnumerator Import_Google_Coroutine(bool JustCheck)
		{
			return null;
		}

		private void ApplyDownloadedDataOnSceneLoaded(Scene scene, LoadSceneMode mode)
		{
		}

		public void ApplyDownloadedDataFromGoogle()
		{
		}

		public UnityWebRequest Import_Google_CreateWWWcall(bool ForceUpdate, bool justCheck)
		{
			return null;
		}

		public bool HasGoogleSpreadsheet()
		{
			return false;
		}

		public string Import_Google_Result(string JsonString, eSpreadsheetUpdateMode UpdateMode, bool saveInPlayerPrefs = false)
		{
			return null;
		}

		public int GetLanguageIndex(string language, bool AllowDiscartingRegion = true, bool SkipDisabled = true)
		{
			return 0;
		}

		public bool IsCurrentLanguage(int languageIndex)
		{
			return false;
		}

		public int GetLanguageIndexFromCode(string Code, bool exactMatch = true, bool ignoreDisabled = false)
		{
			return 0;
		}

		public static int GetCommonWordInLanguageNames(string Language1, string Language2)
		{
			return 0;
		}

		public List<string> GetLanguages(bool skipDisabled = true)
		{
			return null;
		}

		public List<string> GetLanguagesCode(bool allowRegions = true, bool skipDisabled = true)
		{
			return null;
		}

		public bool IsLanguageEnabled(string Language)
		{
			return false;
		}

		public bool AllowUnloadingLanguages()
		{
			return false;
		}

		private string GetSavedLanguageFileName(int languageIndex)
		{
			return null;
		}

		public void LoadLanguage(int languageIndex, bool UnloadOtherLanguages, bool useFallback, bool onlyCurrentSpecialization, bool forceLoad)
		{
		}

		public void UnloadLanguage(int languageIndex)
		{
		}

		public void SaveLanguages(bool unloadAll, PersistentStorage.eFileType fileLocation = PersistentStorage.eFileType.Temporal)
		{
		}

		public bool HasUnloadedLanguages()
		{
			return false;
		}

		public List<string> GetCategories(bool OnlyMainCategory = false, List<string> Categories = null)
		{
			return null;
		}

		public static string GetKeyFromFullTerm(string FullTerm, bool OnlyMainCategory = false)
		{
			return null;
		}

		public static string GetCategoryFromFullTerm(string FullTerm, bool OnlyMainCategory = false)
		{
			return null;
		}

		public void UpdateDictionary(bool force = false)
		{
		}

		public bool TryGetTranslation(string term, out string Translation, string overrideLanguage = null, string overrideSpecialization = null, bool skipDisabled = false, bool allowCategoryMistmatch = false)
		{
			Translation = null;
			return false;
		}

		private bool TryGetFallbackTranslation(TermData termData, out string Translation, int langIndex, string overrideSpecialization = null, bool skipDisabled = false)
		{
			Translation = null;
			return false;
		}

		public TermData GetTermData(string term, bool allowCategoryMistmatch = false)
		{
			return null;
		}

		public bool ContainsTerm(string term)
		{
			return false;
		}

		public List<string> GetTermsList(string Category = null)
		{
			return null;
		}

		public static void ValidateFullTerm(ref string Term)
		{
		}
	}
}
