using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;
using Il2CppDummyDll;
using UnityEngine;

namespace I2.Loc
{
	[Token(Token = "0x20012FD")]
	public static class LocalizationManager
	{
		[Token(Token = "0x20012FE")]
		public delegate object _GetParam(string param);

		[Token(Token = "0x20012FF")]
		public delegate void OnLocalizeCallback();

		[Token(Token = "0x2001300")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x48B00", Offset = "0x48B00")]
		private sealed class _003C_003Ec__DisplayClass34_0
		{
			[Token(Token = "0x400665B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public List<string> Languages;

			[Token(Token = "0x400665C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Func<string, bool> _003C_003E9__0;

			[Token(Token = "0x6005884")]
			[Address(RVA = "0x17ED26C", Offset = "0x17ED26C", VA = "0x17ED26C")]
			public _003C_003Ec__DisplayClass34_0()
			{
			}

			[Token(Token = "0x6005885")]
			[Address(RVA = "0x17ED274", Offset = "0x17ED274", VA = "0x17ED274")]
			internal bool _003CGetAllLanguages_003Eb__0(string x)
			{
				return default;
			}
		}

		[Token(Token = "0x2001301")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x48B10", Offset = "0x48B10")]
		private sealed class _003C_003Ec__DisplayClass35_0
		{
			[Token(Token = "0x400665D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public List<string> Languages;

			[Token(Token = "0x400665E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Func<string, bool> _003C_003E9__0;

			[Token(Token = "0x6005886")]
			[Address(RVA = "0x17ED2E0", Offset = "0x17ED2E0", VA = "0x17ED2E0")]
			public _003C_003Ec__DisplayClass35_0()
			{
			}

			[Token(Token = "0x6005887")]
			[Address(RVA = "0x17ED2E8", Offset = "0x17ED2E8", VA = "0x17ED2E8")]
			internal bool _003CGetAllLanguagesCode_003Eb__0(string x)
			{
				return default;
			}
		}

		[Serializable]
		[Token(Token = "0x2001302")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x48B20", Offset = "0x48B20")]
		private sealed class _003C_003Ec
		{
			[Token(Token = "0x400665F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static readonly _003C_003Ec _003C_003E9;

			[Token(Token = "0x4006660")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public static _GetParam _003C_003E9__42_0;

			[Token(Token = "0x6005889")]
			[Address(RVA = "0x17ED1F4", Offset = "0x17ED1F4", VA = "0x17ED1F4")]
			public _003C_003Ec()
			{
			}

			[Token(Token = "0x600588A")]
			[Address(RVA = "0x17ED1FC", Offset = "0x17ED1FC", VA = "0x17ED1FC")]
			internal object _003CApplyLocalizationParams_003Eb__42_0(string p)
			{
				return null;
			}
		}

		[Token(Token = "0x2001303")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x48B30", Offset = "0x48B30")]
		private sealed class _003C_003Ec__DisplayClass43_0
		{
			[Token(Token = "0x4006661")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public GameObject root;

			[Token(Token = "0x600588B")]
			[Address(RVA = "0x17ED354", Offset = "0x17ED354", VA = "0x17ED354")]
			public _003C_003Ec__DisplayClass43_0()
			{
			}

			[Token(Token = "0x600588C")]
			[Address(RVA = "0x17ED35C", Offset = "0x17ED35C", VA = "0x17ED35C")]
			internal object _003CApplyLocalizationParams_003Eb__0(string p)
			{
				return null;
			}
		}

		[Token(Token = "0x2001304")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x48B40", Offset = "0x48B40")]
		private sealed class _003C_003Ec__DisplayClass44_0
		{
			[Token(Token = "0x4006662")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Dictionary<string, object> parameters;

			[Token(Token = "0x600588D")]
			[Address(RVA = "0x17ED3D8", Offset = "0x17ED3D8", VA = "0x17ED3D8")]
			public _003C_003Ec__DisplayClass44_0()
			{
			}

			[Token(Token = "0x600588E")]
			[Address(RVA = "0x17ED3E0", Offset = "0x17ED3E0", VA = "0x17ED3E0")]
			internal object _003CApplyLocalizationParams_003Eb__0(string p)
			{
				return null;
			}
		}

		[Token(Token = "0x2001305")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x48B50", Offset = "0x48B50")]
		private sealed class _003CDelayed_Import_Google_003Ed__60 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4006663")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int _003C_003E1__state;

			[Token(Token = "0x4006664")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object _003C_003E2__current;

			[Token(Token = "0x4006665")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public float delay;

			[Token(Token = "0x4006666")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public LanguageSourceData source;

			[Token(Token = "0x4006667")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public bool justCheck;

			[Token(Token = "0x17000A14")]
			private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
			{
				[Token(Token = "0x6005892")]
				[Address(RVA = "0x17ED6E8", Offset = "0x17ED6E8", VA = "0x17ED6E8", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
				}
			}

			[Token(Token = "0x17000A15")]
			private object System_002ECollections_002EIEnumerator_002ECurrent
			{
				[Token(Token = "0x6005894")]
				[Address(RVA = "0x17ED730", Offset = "0x17ED730", VA = "0x17ED730", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EIEnumerator_002Eget_Current();
				}
			}

			[Token(Token = "0x600588F")]
			[Address(RVA = "0x17ED5F8", Offset = "0x17ED5F8", VA = "0x17ED5F8")]
			[DebuggerHidden]
			public _003CDelayed_Import_Google_003Ed__60(int _003C_003E1__state)
			{
			}

			[Token(Token = "0x6005890")]
			[Address(RVA = "0x17ED624", Offset = "0x17ED624", VA = "0x17ED624", Slot = "5")]
			[DebuggerHidden]
			private void System_002EIDisposable_002EDispose()
			{
			}

			[Token(Token = "0x6005891")]
			[Address(RVA = "0x17ED628", Offset = "0x17ED628", VA = "0x17ED628", Slot = "6")]
			private bool MoveNext()
			{
				return default;
			}

			[Token(Token = "0x6005892")]
			[Address(RVA = "0x17ED6E8", Offset = "0x17ED6E8", VA = "0x17ED6E8", Slot = "4")]
			[DebuggerHidden]
			private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
			{
				return null;
			}

			[Token(Token = "0x6005893")]
			[Address(RVA = "0x17ED6F0", Offset = "0x17ED6F0", VA = "0x17ED6F0", Slot = "8")]
			[DebuggerHidden]
			private void System_002ECollections_002EIEnumerator_002EReset()
			{
			}

			[Token(Token = "0x6005894")]
			[Address(RVA = "0x17ED730", Offset = "0x17ED730", VA = "0x17ED730", Slot = "7")]
			[DebuggerHidden]
			private object System_002ECollections_002EIEnumerator_002Eget_Current()
			{
				return null;
			}
		}

		[Token(Token = "0x2001306")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x48B60", Offset = "0x48B60")]
		private sealed class _003C_003Ec__DisplayClass70_0
		{
			[Token(Token = "0x4006668")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public ILocalizeTargetDescriptor desc;

			[Token(Token = "0x6005895")]
			[Address(RVA = "0x17ED464", Offset = "0x17ED464", VA = "0x17ED464")]
			public _003C_003Ec__DisplayClass70_0()
			{
			}

			[Token(Token = "0x6005896")]
			[Address(RVA = "0x17ED46C", Offset = "0x17ED46C", VA = "0x17ED46C")]
			internal bool _003CRegisterTarget_003Eb__0(ILocalizeTargetDescriptor x)
			{
				return default;
			}
		}

		[Token(Token = "0x2001307")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x48B70", Offset = "0x48B70")]
		private sealed class _003CCoroutine_LocalizeAll_003Ed__85 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4006669")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int _003C_003E1__state;

			[Token(Token = "0x400666A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object _003C_003E2__current;

			[Token(Token = "0x17000A16")]
			private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
			{
				[Token(Token = "0x600589A")]
				[Address(RVA = "0x17ED5A8", Offset = "0x17ED5A8", VA = "0x17ED5A8", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
				}
			}

			[Token(Token = "0x17000A17")]
			private object System_002ECollections_002EIEnumerator_002ECurrent
			{
				[Token(Token = "0x600589C")]
				[Address(RVA = "0x17ED5F0", Offset = "0x17ED5F0", VA = "0x17ED5F0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EIEnumerator_002Eget_Current();
				}
			}

			[Token(Token = "0x6005897")]
			[Address(RVA = "0x17ED498", Offset = "0x17ED498", VA = "0x17ED498")]
			[DebuggerHidden]
			public _003CCoroutine_LocalizeAll_003Ed__85(int _003C_003E1__state)
			{
			}

			[Token(Token = "0x6005898")]
			[Address(RVA = "0x17ED4C4", Offset = "0x17ED4C4", VA = "0x17ED4C4", Slot = "5")]
			[DebuggerHidden]
			private void System_002EIDisposable_002EDispose()
			{
			}

			[Token(Token = "0x6005899")]
			[Address(RVA = "0x17ED4C8", Offset = "0x17ED4C8", VA = "0x17ED4C8", Slot = "6")]
			private bool MoveNext()
			{
				return default;
			}

			[Token(Token = "0x600589A")]
			[Address(RVA = "0x17ED5A8", Offset = "0x17ED5A8", VA = "0x17ED5A8", Slot = "4")]
			[DebuggerHidden]
			private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
			{
				return null;
			}

			[Token(Token = "0x600589B")]
			[Address(RVA = "0x17ED5B0", Offset = "0x17ED5B0", VA = "0x17ED5B0", Slot = "8")]
			[DebuggerHidden]
			private void System_002ECollections_002EIEnumerator_002EReset()
			{
			}

			[Token(Token = "0x600589C")]
			[Address(RVA = "0x17ED5F0", Offset = "0x17ED5F0", VA = "0x17ED5F0", Slot = "7")]
			[DebuggerHidden]
			private object System_002ECollections_002EIEnumerator_002Eget_Current()
			{
				return null;
			}
		}

		[Token(Token = "0x400664B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static string mCurrentLanguage;

		[Token(Token = "0x400664C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static string mLanguageCode;

		[Token(Token = "0x400664D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static CultureInfo mCurrentCulture;

		[Token(Token = "0x400664E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private static bool mChangeCultureInfo;

		[Token(Token = "0x400664F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
		public static bool IsRight2Left;

		[Token(Token = "0x4006650")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1A")]
		public static bool HasJoinedWords;

		[Token(Token = "0x4006651")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public static List<ILocalizationParamsManager> ParamManagers;

		[Token(Token = "0x4006652")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private static string[] LanguagesRTL;

		[Token(Token = "0x4006653")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public static List<LanguageSourceData> Sources;

		[Token(Token = "0x4006654")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public static string[] GlobalSources;

		[Token(Token = "0x4006655")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private static string mCurrentDeviceLanguage;

		[Token(Token = "0x4006656")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public static List<ILocalizeTargetDescriptor> mLocalizeTargets;

		[Token(Token = "0x4006657")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x59B7C", Offset = "0x59B7C")]
		private static OnLocalizeCallback m_OnLocalizeEvent;

		[Token(Token = "0x4006658")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private static bool mLocalizeIsScheduled;

		[Token(Token = "0x4006659")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x59")]
		private static bool mLocalizeIsScheduledWithForcedValue;

		[Token(Token = "0x400665A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5A")]
		public static bool HighlightLocalizedTargets;

		[Token(Token = "0x17000A0F")]
		public static string CurrentLanguage
		{
			[Token(Token = "0x600583C")]
			[Address(RVA = "0x153B454", Offset = "0x153B454", VA = "0x153B454")]
			get
			{
				return null;
			}
			[Token(Token = "0x600583D")]
			[Address(RVA = "0x153B4BC", Offset = "0x153B4BC", VA = "0x153B4BC")]
			set
			{
			}
		}

		[Token(Token = "0x17000A10")]
		public static string CurrentLanguageCode
		{
			[Token(Token = "0x600583E")]
			[Address(RVA = "0x153E864", Offset = "0x153E864", VA = "0x153E864")]
			get
			{
				return null;
			}
			[Token(Token = "0x600583F")]
			[Address(RVA = "0x153E8CC", Offset = "0x153E8CC", VA = "0x153E8CC")]
			set
			{
			}
		}

		[Token(Token = "0x17000A11")]
		public static string CurrentRegion
		{
			[Token(Token = "0x6005840")]
			[Address(RVA = "0x153EBF4", Offset = "0x153EBF4", VA = "0x153EBF4")]
			get
			{
				return null;
			}
			[Token(Token = "0x6005841")]
			[Address(RVA = "0x153EDA8", Offset = "0x153EDA8", VA = "0x153EDA8")]
			set
			{
			}
		}

		[Token(Token = "0x17000A12")]
		public static string CurrentRegionCode
		{
			[Token(Token = "0x6005842")]
			[Address(RVA = "0x153EFA8", Offset = "0x153EFA8", VA = "0x153EFA8")]
			get
			{
				return null;
			}
			[Token(Token = "0x6005843")]
			[Address(RVA = "0x153F0C0", Offset = "0x153F0C0", VA = "0x153F0C0")]
			set
			{
			}
		}

		[Token(Token = "0x17000A13")]
		public static CultureInfo CurrentCulture
		{
			[Token(Token = "0x6005844")]
			[Address(RVA = "0x153F214", Offset = "0x153F214", VA = "0x153F214")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1400009B")]
		public static event OnLocalizeCallback OnLocalizeEvent
		{
			[Token(Token = "0x600586C")]
			[Address(RVA = "0x153C9B0", Offset = "0x153C9B0", VA = "0x153C9B0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x71EC8", Offset = "0x71EC8")]
			add
			{
			}
			[Token(Token = "0x600586D")]
			[Address(RVA = "0x1542464", Offset = "0x1542464", VA = "0x1542464")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x71ED8", Offset = "0x71ED8")]
			remove
			{
			}
		}

		[Token(Token = "0x6005837")]
		[Address(RVA = "0x153D340", Offset = "0x153D340", VA = "0x153D340")]
		public static void InitializeIfNeeded()
		{
		}

		[Token(Token = "0x6005838")]
		[Address(RVA = "0x153DEB0", Offset = "0x153DEB0", VA = "0x153DEB0")]
		public static string GetVersion()
		{
			return null;
		}

		[Token(Token = "0x6005839")]
		[Address(RVA = "0x153DEF4", Offset = "0x153DEF4", VA = "0x153DEF4")]
		public static int GetRequiredWebServiceVersion()
		{
			return default;
		}

		[Token(Token = "0x600583A")]
		[Address(RVA = "0x153DEFC", Offset = "0x153DEFC", VA = "0x153DEFC")]
		public static string GetWebServiceURL([Optional] LanguageSourceData source)
		{
			return null;
		}

		[Token(Token = "0x600583B")]
		[Address(RVA = "0x153E0E4", Offset = "0x153E0E4", VA = "0x153E0E4")]
		[AttributeAttribute(Name = "RuntimeInitializeOnLoadMethodAttribute", RVA = "0x71EB4", Offset = "0x71EB4")]
		private static void Init()
		{
		}

		[Token(Token = "0x6005845")]
		[Address(RVA = "0x153E600", Offset = "0x153E600", VA = "0x153E600")]
		public static void SetLanguageAndCode(string LanguageName, string LanguageCode, bool RememberLanguage = true, bool Force = false)
		{
		}

		[Token(Token = "0x6005846")]
		[Address(RVA = "0x153F278", Offset = "0x153F278", VA = "0x153F278")]
		private static CultureInfo CreateCultureForCode(string code)
		{
			return null;
		}

		[Token(Token = "0x6005847")]
		[Address(RVA = "0x153F568", Offset = "0x153F568", VA = "0x153F568")]
		public static void EnableChangingCultureInfo(bool bEnable)
		{
		}

		[Token(Token = "0x6005848")]
		[Address(RVA = "0x153F3A8", Offset = "0x153F3A8", VA = "0x153F3A8")]
		private static void SetCurrentCultureInfo()
		{
		}

		[Token(Token = "0x6005849")]
		[Address(RVA = "0x153D9E0", Offset = "0x153D9E0", VA = "0x153D9E0")]
		private static void SelectStartupLanguage()
		{
		}

		[Token(Token = "0x600584A")]
		[Address(RVA = "0x153F6D4", Offset = "0x153F6D4", VA = "0x153F6D4")]
		public static bool HasLanguage(string Language, bool AllowDiscartingRegion = true, bool Initialize = true, bool SkipDisabled = true)
		{
			return default;
		}

		[Token(Token = "0x600584B")]
		[Address(RVA = "0x153E154", Offset = "0x153E154", VA = "0x153E154")]
		public static string GetSupportedLanguage(string Language, bool ignoreDisabled = false)
		{
			return null;
		}

		[Token(Token = "0x600584C")]
		[Address(RVA = "0x153C4B0", Offset = "0x153C4B0", VA = "0x153C4B0")]
		public static string GetLanguageCode(string Language)
		{
			return null;
		}

		[Token(Token = "0x600584D")]
		[Address(RVA = "0x153E9BC", Offset = "0x153E9BC", VA = "0x153E9BC")]
		public static string GetLanguageFromCode(string Code, bool exactMatch = true)
		{
			return null;
		}

		[Token(Token = "0x600584E")]
		[Address(RVA = "0x153B870", Offset = "0x153B870", VA = "0x153B870")]
		public static List<string> GetAllLanguages(bool SkipDisabled = true)
		{
			return null;
		}

		[Token(Token = "0x600584F")]
		[Address(RVA = "0x153F8E8", Offset = "0x153F8E8", VA = "0x153F8E8")]
		public static List<string> GetAllLanguagesCode(bool allowRegions = true, bool SkipDisabled = true)
		{
			return null;
		}

		[Token(Token = "0x6005850")]
		[Address(RVA = "0x153FB60", Offset = "0x153FB60", VA = "0x153FB60")]
		public static bool IsLanguageEnabled(string Language)
		{
			return default;
		}

		[Token(Token = "0x6005851")]
		[Address(RVA = "0x153FC78", Offset = "0x153FC78", VA = "0x153FC78")]
		private static void LoadCurrentLanguage()
		{
		}

		[Token(Token = "0x6005852")]
		[Address(RVA = "0x153FDD8", Offset = "0x153FDD8", VA = "0x153FDD8")]
		public static void PreviewLanguage(string NewLanguage)
		{
		}

		[Token(Token = "0x6005853")]
		[Address(RVA = "0x153D784", Offset = "0x153D784", VA = "0x153D784")]
		public static void AutoLoadGlobalParamManagers()
		{
		}

		[Token(Token = "0x6005854")]
		[Address(RVA = "0x153FF38", Offset = "0x153FF38", VA = "0x153FF38")]
		public static void ApplyLocalizationParams(ref string translation, bool allowLocalizedParameters = true)
		{
		}

		[Token(Token = "0x6005855")]
		[Address(RVA = "0x1540554", Offset = "0x1540554", VA = "0x1540554")]
		public static void ApplyLocalizationParams(ref string translation, GameObject root, bool allowLocalizedParameters = true)
		{
		}

		[Token(Token = "0x6005856")]
		[Address(RVA = "0x154064C", Offset = "0x154064C", VA = "0x154064C")]
		public static void ApplyLocalizationParams(ref string translation, Dictionary<string, object> parameters, bool allowLocalizedParameters = true)
		{
		}

		[Token(Token = "0x6005857")]
		[Address(RVA = "0x1540070", Offset = "0x1540070", VA = "0x1540070")]
		public static void ApplyLocalizationParams(ref string translation, _GetParam getParam, bool allowLocalizedParameters = true)
		{
		}

		[Token(Token = "0x6005858")]
		[Address(RVA = "0x15408D8", Offset = "0x15408D8", VA = "0x15408D8")]
		internal static string GetLocalizationParam(string ParamName, GameObject root)
		{
			return null;
		}

		[Token(Token = "0x6005859")]
		[Address(RVA = "0x1540BC0", Offset = "0x1540BC0", VA = "0x1540BC0")]
		private static string GetPluralType(MatchCollection matches, string langCode, _GetParam getParam)
		{
			return null;
		}

		[Token(Token = "0x600585A")]
		[Address(RVA = "0x153BE84", Offset = "0x153BE84", VA = "0x153BE84")]
		public static string ApplyRTLfix(string line)
		{
			return null;
		}

		[Token(Token = "0x600585B")]
		[Address(RVA = "0x1540DBC", Offset = "0x1540DBC", VA = "0x1540DBC")]
		public static string ApplyRTLfix(string line, int maxCharacters, bool ignoreNumbers)
		{
			return null;
		}

		[Token(Token = "0x600585C")]
		[Address(RVA = "0x15411E8", Offset = "0x15411E8", VA = "0x15411E8")]
		public static string FixRTL_IfNeeded(string text, int maxCharacters = 0, bool ignoreNumber = false)
		{
			return null;
		}

		[Token(Token = "0x600585D")]
		[Address(RVA = "0x153C6DC", Offset = "0x153C6DC", VA = "0x153C6DC")]
		public static bool IsRTL(string Code)
		{
			return default;
		}

		[Token(Token = "0x600585E")]
		[Address(RVA = "0x153D950", Offset = "0x153D950", VA = "0x153D950")]
		public static bool UpdateSources()
		{
			return default;
		}

		[Token(Token = "0x600585F")]
		[Address(RVA = "0x15412A8", Offset = "0x15412A8", VA = "0x15412A8")]
		private static void UnregisterDeletededSources()
		{
		}

		[Token(Token = "0x6005860")]
		[Address(RVA = "0x15415C0", Offset = "0x15415C0", VA = "0x15415C0")]
		private static void RegisterSceneSources()
		{
		}

		[Token(Token = "0x6005861")]
		[Address(RVA = "0x15413EC", Offset = "0x15413EC", VA = "0x15413EC")]
		private static void RegisterSourceInResources()
		{
		}

		[Token(Token = "0x6005862")]
		[Address(RVA = "0x1541824", Offset = "0x1541824", VA = "0x1541824")]
		internal static void AddSource(LanguageSourceData Source)
		{
		}

		[Token(Token = "0x6005863")]
		[Address(RVA = "0x1541AA4", Offset = "0x1541AA4", VA = "0x1541AA4")]
		private static IEnumerator Delayed_Import_Google(LanguageSourceData source, float delay, bool justCheck)
		{
			return null;
		}

		[Token(Token = "0x6005864")]
		[Address(RVA = "0x1541790", Offset = "0x1541790", VA = "0x1541790")]
		internal static void RemoveSource(LanguageSourceData Source)
		{
		}

		[Token(Token = "0x6005865")]
		[Address(RVA = "0x1541B30", Offset = "0x1541B30", VA = "0x1541B30")]
		public static bool IsGlobalSource(string SourceName)
		{
			return default;
		}

		[Token(Token = "0x6005866")]
		[Address(RVA = "0x1541BC8", Offset = "0x1541BC8", VA = "0x1541BC8")]
		public static LanguageSourceData GetSourceContaining(string term, bool fallbackToFirst = true)
		{
			return null;
		}

		[Token(Token = "0x6005867")]
		[Address(RVA = "0x1541DC4", Offset = "0x1541DC4", VA = "0x1541DC4")]
		public static UnityEngine.Object FindAsset(string value)
		{
			return null;
		}

		[Token(Token = "0x6005868")]
		[Address(RVA = "0x1541F18", Offset = "0x1541F18", VA = "0x1541F18")]
		public static void ApplyDownloadedDataFromGoogle()
		{
		}

		[Token(Token = "0x6005869")]
		[Address(RVA = "0x153F61C", Offset = "0x153F61C", VA = "0x153F61C")]
		public static string GetCurrentDeviceLanguage(bool force = false)
		{
			return null;
		}

		[Token(Token = "0x600586A")]
		[Address(RVA = "0x1542014", Offset = "0x1542014", VA = "0x1542014")]
		private static void DetectDeviceLanguage()
		{
		}

		[Token(Token = "0x600586B")]
		[Address(RVA = "0x15421CC", Offset = "0x15421CC", VA = "0x15421CC")]
		public static void RegisterTarget(ILocalizeTargetDescriptor desc)
		{
		}

		[Token(Token = "0x600586E")]
		[Address(RVA = "0x1542570", Offset = "0x1542570", VA = "0x1542570")]
		public static string GetTranslation(string Term, [Optional][DefaultParameterValue(true)] bool FixForRTL, [Optional][DefaultParameterValue(0)] int maxLineLengthForRTL, [Optional][DefaultParameterValue(true)] bool ignoreRTLnumbers, [Optional][DefaultParameterValue(false)] bool applyParameters, [Optional] GameObject localParametersRoot, [Optional] string overrideLanguage)
		{
			return null;
		}

		[Token(Token = "0x600586F")]
		[Address(RVA = "0x153BD84", Offset = "0x153BD84", VA = "0x153BD84")]
		public static string GetTermTranslation(string Term, [Optional][DefaultParameterValue(true)] bool FixForRTL, [Optional][DefaultParameterValue(0)] int maxLineLengthForRTL, [Optional][DefaultParameterValue(true)] bool ignoreRTLnumbers, [Optional][DefaultParameterValue(false)] bool applyParameters, [Optional] GameObject localParametersRoot, [Optional] string overrideLanguage)
		{
			return null;
		}

		[Token(Token = "0x6005870")]
		[Address(RVA = "0x1542648", Offset = "0x1542648", VA = "0x1542648")]
		public static bool TryGetTranslation(string Term, out string Translation, [Optional][DefaultParameterValue(true)] bool FixForRTL, [Optional][DefaultParameterValue(0)] int maxLineLengthForRTL, [Optional][DefaultParameterValue(true)] bool ignoreRTLnumbers, [Optional][DefaultParameterValue(false)] bool applyParameters, [Optional] GameObject localParametersRoot, [Optional] string overrideLanguage)
		{
			return default;
		}

		[Token(Token = "0x6005871")]
		public static T GetTranslatedObject<T>(string AssetName, [Optional] Localize optionalLocComp) where T : UnityEngine.Object
		{
			return null;
		}

		[Token(Token = "0x6005872")]
		public static T GetTranslatedObjectByTermName<T>(string Term, [Optional] Localize optionalLocComp) where T : UnityEngine.Object
		{
			return null;
		}

		[Token(Token = "0x6005873")]
		[Address(RVA = "0x1542854", Offset = "0x1542854", VA = "0x1542854")]
		public static string GetAppName(string languageCode)
		{
			return null;
		}

		[Token(Token = "0x6005874")]
		[Address(RVA = "0x153F42C", Offset = "0x153F42C", VA = "0x153F42C")]
		public static void LocalizeAll(bool Force = false)
		{
		}

		[Token(Token = "0x6005875")]
		[Address(RVA = "0x1542C6C", Offset = "0x1542C6C", VA = "0x1542C6C")]
		private static IEnumerator Coroutine_LocalizeAll()
		{
			return null;
		}

		[Token(Token = "0x6005876")]
		[Address(RVA = "0x1542ABC", Offset = "0x1542ABC", VA = "0x1542ABC")]
		private static void DoLocalizeAll(bool Force = false)
		{
		}

		[Token(Token = "0x6005877")]
		[Address(RVA = "0x154378C", Offset = "0x154378C", VA = "0x154378C")]
		public static List<string> GetCategories()
		{
			return null;
		}

		[Token(Token = "0x6005878")]
		[Address(RVA = "0x15438D8", Offset = "0x15438D8", VA = "0x15438D8")]
		public static List<string> GetTermsList([Optional] string Category)
		{
			return null;
		}

		[Token(Token = "0x6005879")]
		[Address(RVA = "0x153C394", Offset = "0x153C394", VA = "0x153C394")]
		public static TermData GetTermData(string term)
		{
			return null;
		}

		[Token(Token = "0x600587A")]
		[Address(RVA = "0x1540744", Offset = "0x1540744", VA = "0x1540744")]
		public static TermData GetTermData(string term, out LanguageSourceData source)
		{
			return null;
		}
	}
}
