using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Rewired.Config;
using Rewired.Platforms;
using Rewired.Utils.Attributes;
using Rewired.Utils.Classes.Data;

namespace Rewired.Data
{
	[Serializable]
	[Token(Token = "0x20001AB")]
	public sealed class ConfigVars : IConfigVars_Internal
	{
		[Serializable]
		[Token(Token = "0x20001AC")]
		public class PlatformVars
		{
			[Token(Token = "0x40009C4")]
			[FieldOffset(Offset = "0x10")]
			public bool disableKeyboard;

			[Token(Token = "0x40009C5")]
			[FieldOffset(Offset = "0x11")]
			public bool disableMouse;

			[Token(Token = "0x40009C6")]
			[FieldOffset(Offset = "0x12")]
			public bool ignoreInputWhenAppNotInFocus;

			[Token(Token = "0x6000CCF")]
			[Address(RVA = "0x2451330", Offset = "0x2451330", VA = "0x2451330")]
			public PlatformVars()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20001AD")]
		public class PlatformVars_WindowsStandalone : PlatformVars
		{
			[Token(Token = "0x40009C7")]
			[FieldOffset(Offset = "0x13")]
			public bool useNativeKeyboard;

			[Token(Token = "0x40009C8")]
			[FieldOffset(Offset = "0x14")]
			public int joystickRefreshRate;

			[Token(Token = "0x6000CD0")]
			[Address(RVA = "0x2451398", Offset = "0x2451398", VA = "0x2451398")]
			public PlatformVars_WindowsStandalone()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20001AE")]
		public class PlatformVars_OSXStandalone : PlatformVars
		{
			[Token(Token = "0x40009C9")]
			[FieldOffset(Offset = "0x13")]
			public bool useAppleGameController;

			[Token(Token = "0x40009CA")]
			[FieldOffset(Offset = "0x14")]
			public bool assignJoysticksByUserId;

			[Token(Token = "0x6000CD1")]
			[Address(RVA = "0x2451360", Offset = "0x2451360", VA = "0x2451360")]
			public PlatformVars_OSXStandalone()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20001AF")]
		public class PlatformVars_WindowsUWP : PlatformVars
		{
			[Token(Token = "0x40009CB")]
			[FieldOffset(Offset = "0x13")]
			public bool useGamepadAPI;

			[Token(Token = "0x40009CC")]
			[FieldOffset(Offset = "0x14")]
			public bool useHIDAPI;

			[Token(Token = "0x6000CD2")]
			[Address(RVA = "0x24513B0", Offset = "0x24513B0", VA = "0x24513B0")]
			public PlatformVars_WindowsUWP()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20001B0")]
		public class PlatformVars_Stadia : PlatformVars
		{
			[Token(Token = "0x40009CD")]
			[FieldOffset(Offset = "0x13")]
			public bool useNativeKeyboard;

			[Token(Token = "0x40009CE")]
			[FieldOffset(Offset = "0x14")]
			public bool useNativeMouse;

			[Token(Token = "0x6000CD3")]
			[Address(RVA = "0x2451380", Offset = "0x2451380", VA = "0x2451380")]
			public PlatformVars_Stadia()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20001B1")]
		public class PlatformVars_GameCoreXboxOne : PlatformVars
		{
			[Token(Token = "0x40009CF")]
			[FieldOffset(Offset = "0x13")]
			public bool assignJoysticksByUserId;

			[Token(Token = "0x6000CD4")]
			[Address(RVA = "0x2451350", Offset = "0x2451350", VA = "0x2451350")]
			public PlatformVars_GameCoreXboxOne()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20001B2")]
		public class PlatformVars_GameCoreScarlett : PlatformVars
		{
			[Token(Token = "0x40009D0")]
			[FieldOffset(Offset = "0x13")]
			public bool assignJoysticksByUserId;

			[Token(Token = "0x6000CD5")]
			[Address(RVA = "0x2451340", Offset = "0x2451340", VA = "0x2451340")]
			public PlatformVars_GameCoreScarlett()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20001B3")]
		public class PlatformVars_PS5 : PlatformVars
		{
			[Token(Token = "0x40009D1")]
			[FieldOffset(Offset = "0x13")]
			public bool assignJoysticksByPS5JoyId;

			[Token(Token = "0x6000CD6")]
			[Address(RVA = "0x2451370", Offset = "0x2451370", VA = "0x2451370")]
			public PlatformVars_PS5()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20001B4")]
		public sealed class EditorVars
		{
			[Token(Token = "0x40009D2")]
			[FieldOffset(Offset = "0x10")]
			public bool exportConsts_useParentClass;

			[Token(Token = "0x40009D3")]
			[FieldOffset(Offset = "0x18")]
			public string exportConsts_parentClassName;

			[Token(Token = "0x40009D4")]
			[FieldOffset(Offset = "0x20")]
			public bool exportConsts_useNamespace;

			[Token(Token = "0x40009D5")]
			[FieldOffset(Offset = "0x28")]
			public string exportConsts_namespace;

			[Token(Token = "0x40009D6")]
			[FieldOffset(Offset = "0x30")]
			public bool exportConsts_actions;

			[Token(Token = "0x40009D7")]
			[FieldOffset(Offset = "0x38")]
			public string exportConsts_actionsClassName;

			[Token(Token = "0x40009D8")]
			[FieldOffset(Offset = "0x40")]
			public bool exportConsts_actionsIncludeActionCategory;

			[Token(Token = "0x40009D9")]
			[FieldOffset(Offset = "0x41")]
			public bool exportConsts_actionsCreateClassesForActionCategories;

			[Token(Token = "0x40009DA")]
			[FieldOffset(Offset = "0x42")]
			public bool exportConsts_mapCategories;

			[Token(Token = "0x40009DB")]
			[FieldOffset(Offset = "0x48")]
			public string exportConsts_mapCategoriesClassName;

			[Token(Token = "0x40009DC")]
			[FieldOffset(Offset = "0x50")]
			public bool exportConsts_layouts;

			[Token(Token = "0x40009DD")]
			[FieldOffset(Offset = "0x58")]
			public string exportConsts_layoutsClassName;

			[Token(Token = "0x40009DE")]
			[FieldOffset(Offset = "0x60")]
			public bool exportConsts_players;

			[Token(Token = "0x40009DF")]
			[FieldOffset(Offset = "0x68")]
			public string exportConsts_playersClassName;

			[Token(Token = "0x40009E0")]
			[FieldOffset(Offset = "0x70")]
			public bool exportConsts_inputBehaviors;

			[Token(Token = "0x40009E1")]
			[FieldOffset(Offset = "0x78")]
			public string exportConsts_inputBehaviorsClassName;

			[Token(Token = "0x40009E2")]
			[FieldOffset(Offset = "0x80")]
			public bool exportConsts_customControllers;

			[Token(Token = "0x40009E3")]
			[FieldOffset(Offset = "0x88")]
			public string exportConsts_customControllersClassName;

			[Token(Token = "0x40009E4")]
			[FieldOffset(Offset = "0x90")]
			public string exportConsts_customControllersAxesClassName;

			[Token(Token = "0x40009E5")]
			[FieldOffset(Offset = "0x98")]
			public string exportConsts_customControllersButtonsClassName;

			[Token(Token = "0x40009E6")]
			[FieldOffset(Offset = "0xA0")]
			public bool exportConsts_layoutManagerRuleSets;

			[Token(Token = "0x40009E7")]
			[FieldOffset(Offset = "0xA8")]
			public string exportConsts_layoutManagerRuleSetsClassName;

			[Token(Token = "0x40009E8")]
			[FieldOffset(Offset = "0xB0")]
			public bool exportConsts_mapEnablerRuleSets;

			[Token(Token = "0x40009E9")]
			[FieldOffset(Offset = "0xB8")]
			public string exportConsts_mapEnablerRuleSetsClassName;

			[Token(Token = "0x40009EA")]
			[FieldOffset(Offset = "0xC0")]
			public bool exportConsts_allCapsConstantNames;

			[Token(Token = "0x6000CD7")]
			[Address(RVA = "0x2451124", Offset = "0x2451124", VA = "0x2451124")]
			public EditorVars()
			{
			}
		}

		[Token(Token = "0x20001B5")]
		private class OpskQejDgIZSWovHGUlHGilBlTnF
		{
			[Token(Token = "0x40009EB")]
			[FieldOffset(Offset = "0x10")]
			public Func<PlatformVars> KwWcmpxWpdaEZpKWAerfiotksPQf;

			[Token(Token = "0x40009EC")]
			[FieldOffset(Offset = "0x18")]
			public string eHMcnYradBtmTJXOxXSYtHEVcnBD;

			[Token(Token = "0x6000CD8")]
			[Address(RVA = "0x24512F8", Offset = "0x24512F8", VA = "0x24512F8")]
			public OpskQejDgIZSWovHGUlHGilBlTnF(Func<PlatformVars> P_0, string P_1)
			{
			}
		}

		[Token(Token = "0x20001B6")]
		private class RitCkGqDKsfnMMztQPMiYMzIeGYJ
		{
			[Token(Token = "0x40009ED")]
			[FieldOffset(Offset = "0x10")]
			public Func<Platform, object> KwWcmpxWpdaEZpKWAerfiotksPQf;

			[Token(Token = "0x40009EE")]
			[FieldOffset(Offset = "0x18")]
			public Action<Platform, object> GUhNJxVCnnOncLXQZyIcvFXecYAl;
		}

		[Token(Token = "0x4000989")]
		[FieldOffset(Offset = "0x10")]
		public UpdateLoopSetting updateLoop;

		[Token(Token = "0x400098A")]
		[FieldOffset(Offset = "0x14")]
		public bool alwaysUseUnityInput;

		[Token(Token = "0x400098B")]
		[FieldOffset(Offset = "0x18")]
		public WindowsStandalonePrimaryInputSource windowsStandalonePrimaryInputSource;

		[Token(Token = "0x400098C")]
		[FieldOffset(Offset = "0x1C")]
		public OSXStandalonePrimaryInputSource osx_primaryInputSource;

		[Token(Token = "0x400098D")]
		[FieldOffset(Offset = "0x20")]
		public LinuxStandalonePrimaryInputSource linux_primaryInputSource;

		[Token(Token = "0x400098E")]
		[FieldOffset(Offset = "0x24")]
		public WindowsUWPPrimaryInputSource windowsUWP_primaryInputSource;

		[Token(Token = "0x400098F")]
		[FieldOffset(Offset = "0x28")]
		public XboxOnePrimaryInputSource xboxOne_primaryInputSource;

		[Token(Token = "0x4000990")]
		[FieldOffset(Offset = "0x2C")]
		public GameCoreXboxOnePrimaryInputSource gameCoreXboxOne_primaryInputSource;

		[Token(Token = "0x4000991")]
		[FieldOffset(Offset = "0x30")]
		public GameCoreScarlettPrimaryInputSource gameCoreScarlett_primaryInputSource;

		[Token(Token = "0x4000992")]
		[FieldOffset(Offset = "0x34")]
		public PS4PrimaryInputSource ps4_primaryInputSource;

		[Token(Token = "0x4000993")]
		[FieldOffset(Offset = "0x38")]
		public PS5PrimaryInputSource ps5_primaryInputSource;

		[Token(Token = "0x4000994")]
		[FieldOffset(Offset = "0x3C")]
		public WebGLPrimaryInputSource webGL_primaryInputSource;

		[Token(Token = "0x4000995")]
		[FieldOffset(Offset = "0x40")]
		public StadiaPrimaryInputSource stadia_primaryInputSource;

		[Token(Token = "0x4000996")]
		[FieldOffset(Offset = "0x44")]
		public bool useXInput;

		[Token(Token = "0x4000997")]
		[FieldOffset(Offset = "0x45")]
		public bool useNativeMouse;

		[Token(Token = "0x4000998")]
		[FieldOffset(Offset = "0x46")]
		public bool useEnhancedDeviceSupport;

		[Token(Token = "0x4000999")]
		[FieldOffset(Offset = "0x47")]
		public bool windowsStandalone_useSteamRawInputControllerWorkaround;

		[Token(Token = "0x400099A")]
		[FieldOffset(Offset = "0x48")]
		public bool osxStandalone_useEnhancedDeviceSupport;

		[Token(Token = "0x400099B")]
		[FieldOffset(Offset = "0x49")]
		public bool android_supportUnknownGamepads;

		[Token(Token = "0x400099C")]
		[FieldOffset(Offset = "0x4A")]
		public bool ps4_assignJoysticksByPS4JoyId;

		[Token(Token = "0x400099D")]
		[FieldOffset(Offset = "0x4B")]
		public bool useSteamControllerSupport;

		[Token(Token = "0x400099E")]
		[FieldOffset(Offset = "0x4C")]
		public bool logToScreen;

		[Token(Token = "0x400099F")]
		[FieldOffset(Offset = "0x4D")]
		public bool runInEditMode;

		[Token(Token = "0x40009A0")]
		[FieldOffset(Offset = "0x4E")]
		public bool allowInputInEditorSceneView;

		[Token(Token = "0x40009A1")]
		[FieldOffset(Offset = "0x50")]
		public PlatformVars_WindowsStandalone platformVars_windowsStandalone;

		[Token(Token = "0x40009A2")]
		[FieldOffset(Offset = "0x58")]
		public PlatformVars platformVars_linuxStandalone;

		[Token(Token = "0x40009A3")]
		[FieldOffset(Offset = "0x60")]
		public PlatformVars_OSXStandalone platformVars_osxStandalone;

		[Token(Token = "0x40009A4")]
		[FieldOffset(Offset = "0x68")]
		public PlatformVars_WindowsUWP platformVars_windowsUWP;

		[Token(Token = "0x40009A5")]
		[FieldOffset(Offset = "0x70")]
		public PlatformVars platformVars_iOS;

		[Token(Token = "0x40009A6")]
		[FieldOffset(Offset = "0x78")]
		public PlatformVars platformVars_tvOS;

		[Token(Token = "0x40009A7")]
		[FieldOffset(Offset = "0x80")]
		public PlatformVars platformVars_android;

		[Token(Token = "0x40009A8")]
		[FieldOffset(Offset = "0x88")]
		public PlatformVars platformVars_ps4;

		[Token(Token = "0x40009A9")]
		[FieldOffset(Offset = "0x90")]
		public PlatformVars_PS5 platformVars_ps5;

		[Token(Token = "0x40009AA")]
		[FieldOffset(Offset = "0x98")]
		public PlatformVars platformVars_psVita;

		[Token(Token = "0x40009AB")]
		[FieldOffset(Offset = "0xA0")]
		public PlatformVars platformVars_xboxOne;

		[Token(Token = "0x40009AC")]
		[FieldOffset(Offset = "0xA8")]
		public PlatformVars_GameCoreXboxOne platformVars_gameCoreXboxOne;

		[Token(Token = "0x40009AD")]
		[FieldOffset(Offset = "0xB0")]
		public PlatformVars_GameCoreScarlett platformVars_gameCoreScarlett;

		[Token(Token = "0x40009AE")]
		[FieldOffset(Offset = "0xB8")]
		public PlatformVars platformVars_switch;

		[Token(Token = "0x40009AF")]
		[FieldOffset(Offset = "0xC0")]
		public PlatformVars platformVars_webGL;

		[Token(Token = "0x40009B0")]
		[FieldOffset(Offset = "0xC8")]
		public PlatformVars_Stadia platformVars_stadia;

		[NonSerialized]
		[Token(Token = "0x40009B1")]
		[FieldOffset(Offset = "0xD0")]
		private PlatformVars platformVars_unknown;

		[Token(Token = "0x40009B2")]
		[FieldOffset(Offset = "0xD8")]
		public int maxJoysticksPerPlayer;

		[Token(Token = "0x40009B3")]
		[FieldOffset(Offset = "0xDC")]
		public bool autoAssignJoysticks;

		[Token(Token = "0x40009B4")]
		[FieldOffset(Offset = "0xDD")]
		public bool assignJoysticksToPlayingPlayersOnly;

		[Token(Token = "0x40009B5")]
		[FieldOffset(Offset = "0xDE")]
		public bool distributeJoysticksEvenly;

		[Token(Token = "0x40009B6")]
		[FieldOffset(Offset = "0xDF")]
		public bool reassignJoystickToPreviousOwnerOnReconnect;

		[Token(Token = "0x40009B7")]
		[FieldOffset(Offset = "0xE0")]
		public DeadZone2DType defaultJoystickAxis2DDeadZoneType;

		[Token(Token = "0x40009B8")]
		[FieldOffset(Offset = "0xE4")]
		public AxisSensitivity2DType defaultJoystickAxis2DSensitivityType;

		[Token(Token = "0x40009B9")]
		[FieldOffset(Offset = "0xE8")]
		public AxisSensitivityType defaultAxisSensitivityType;

		[Token(Token = "0x40009BA")]
		[FieldOffset(Offset = "0xEC")]
		public bool force4WayHats;

		[Token(Token = "0x40009BB")]
		[FieldOffset(Offset = "0xF0")]
		public ThrottleCalibrationMode throttleCalibrationMode;

		[Token(Token = "0x40009BC")]
		[FieldOffset(Offset = "0xF4")]
		public bool activateActionButtonsOnNegativeValue;

		[Token(Token = "0x40009BD")]
		[FieldOffset(Offset = "0xF5")]
		public bool deferControllerConnectedEventsOnStart;

		[Token(Token = "0x40009BE")]
		[FieldOffset(Offset = "0xF8")]
		public LogLevelFlags logLevel;

		[Token(Token = "0x40009BF")]
		[FieldOffset(Offset = "0x100")]
		public EditorVars editorSettings;

		[Token(Token = "0x40009C0")]
		[FieldOffset(Offset = "0x108")]
		private Dictionary<int, OpskQejDgIZSWovHGUlHGilBlTnF> __platformVarsDict;

		[Token(Token = "0x40009C1")]
		[FieldOffset(Offset = "0x110")]
		private Dictionary<int, RitCkGqDKsfnMMztQPMiYMzIeGYJ> __getSetPlatformVariableDict;

		[Token(Token = "0x40009C2")]
		[FieldOffset(Offset = "0x118")]
		private KeyedGetSetValueStore<string> __configVarsValues;

		[Token(Token = "0x40009C3")]
		[FieldOffset(Offset = "0x120")]
		private Dictionary<string, object> __valueDelegates;

		[Token(Token = "0x1700038D")]
		private Dictionary<int, OpskQejDgIZSWovHGUlHGilBlTnF> platformVarsDict
		{
			[Token(Token = "0x6000CB0")]
			[Address(RVA = "0x235238C", Offset = "0x235238C", VA = "0x235238C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000CB1")]
		[Address(RVA = "0x2352C20", Offset = "0x2352C20", VA = "0x2352C20")]
		[Preserve]
		public ConfigVars()
		{
		}

		[Token(Token = "0x6000CB2")]
		[Address(RVA = "0x2352C5C", Offset = "0x2352C5C", VA = "0x2352C5C")]
		internal bool DoesPlatformUseFallback(Platform platform, WebplayerPlatform webplayerPlatform, bool isEditor)
		{
			return default;
		}

		[Token(Token = "0x6000CB3")]
		[Address(RVA = "0x2352D0C", Offset = "0x2352D0C", VA = "0x2352D0C")]
		internal bool DoesPlatformUseSDL2(Platform platform, WebplayerPlatform webplayerPlatform, bool isEditor)
		{
			return default;
		}

		[Token(Token = "0x6000CB4")]
		[Address(RVA = "0x2352D6C", Offset = "0x2352D6C", VA = "0x2352D6C")]
		internal string GetDebugConfigSettings()
		{
			return null;
		}

		[Token(Token = "0x6000CB5")]
		[Address(RVA = "0x235359C", Offset = "0x235359C", VA = "0x235359C")]
		internal PlatformVars GetPlatformVars(Platform platform)
		{
			return null;
		}

		[Token(Token = "0x6000CB6")]
		[Address(RVA = "0x23536BC", Offset = "0x23536BC", VA = "0x23536BC")]
		internal bool GetPlatformVar_disableKeyboard()
		{
			return default;
		}

		[Token(Token = "0x6000CB7")]
		[Address(RVA = "0x235378C", Offset = "0x235378C", VA = "0x235378C")]
		internal bool GetPlatformVar_disableMouse()
		{
			return default;
		}

		[Token(Token = "0x6000CB8")]
		[Address(RVA = "0x23537AC", Offset = "0x23537AC", VA = "0x23537AC")]
		internal bool GetPlatformVar_ignoreInputWhenAppNotInFocus()
		{
			return default;
		}

		[Token(Token = "0x6000CB9")]
		[Address(RVA = "0x2353508", Offset = "0x2353508", VA = "0x2353508")]
		internal bool GetPlatformVar_useEnhancedDeviceSupport()
		{
			return default;
		}

		[Token(Token = "0x6000CBA")]
		[Address(RVA = "0x2353418", Offset = "0x2353418", VA = "0x2353418")]
		internal bool GetPlatformVar_useNativeMouse()
		{
			return default;
		}

		[Token(Token = "0x6000CBB")]
		[Address(RVA = "0x23536DC", Offset = "0x23536DC", VA = "0x23536DC")]
		private PlatformVars GetPlatformVars()
		{
			return null;
		}

		[Token(Token = "0x6000CBC")]
		private T GetOrCreatePlatformVars<T>(ref T var) where T : PlatformVars, new()
		{
			return null;
		}

		[Token(Token = "0x6000CBD")]
		[Address(RVA = "0x23537CC", Offset = "0x23537CC", VA = "0x23537CC")]
		internal bool IsEditModeInputSupported(ControllerType controllerType, EditorPlatform editorPlatform)
		{
			return default;
		}

		[Token(Token = "0x6000CBE")]
		[Address(RVA = "0x2353894", Offset = "0x2353894", VA = "0x2353894")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x195B04", Offset = "0x195B04")]
		private PlatformVars _003Cget_platformVarsDict_003Eb__57_0()
		{
			return null;
		}

		[Token(Token = "0x6000CBF")]
		[Address(RVA = "0x23538F0", Offset = "0x23538F0", VA = "0x23538F0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x195B14", Offset = "0x195B14")]
		private PlatformVars _003Cget_platformVarsDict_003Eb__57_1()
		{
			return null;
		}

		[Token(Token = "0x6000CC0")]
		[Address(RVA = "0x235394C", Offset = "0x235394C", VA = "0x235394C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x195B24", Offset = "0x195B24")]
		private PlatformVars _003Cget_platformVarsDict_003Eb__57_2()
		{
			return null;
		}

		[Token(Token = "0x6000CC1")]
		[Address(RVA = "0x23539A8", Offset = "0x23539A8", VA = "0x23539A8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x195B34", Offset = "0x195B34")]
		private PlatformVars _003Cget_platformVarsDict_003Eb__57_3()
		{
			return null;
		}

		[Token(Token = "0x6000CC2")]
		[Address(RVA = "0x2353A04", Offset = "0x2353A04", VA = "0x2353A04")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x195B44", Offset = "0x195B44")]
		private PlatformVars _003Cget_platformVarsDict_003Eb__57_4()
		{
			return null;
		}

		[Token(Token = "0x6000CC3")]
		[Address(RVA = "0x2353A60", Offset = "0x2353A60", VA = "0x2353A60")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x195B54", Offset = "0x195B54")]
		private PlatformVars _003Cget_platformVarsDict_003Eb__57_5()
		{
			return null;
		}

		[Token(Token = "0x6000CC4")]
		[Address(RVA = "0x2353ABC", Offset = "0x2353ABC", VA = "0x2353ABC")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x195B64", Offset = "0x195B64")]
		private PlatformVars _003Cget_platformVarsDict_003Eb__57_6()
		{
			return null;
		}

		[Token(Token = "0x6000CC5")]
		[Address(RVA = "0x2353B18", Offset = "0x2353B18", VA = "0x2353B18")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x195B74", Offset = "0x195B74")]
		private PlatformVars _003Cget_platformVarsDict_003Eb__57_7()
		{
			return null;
		}

		[Token(Token = "0x6000CC6")]
		[Address(RVA = "0x2353B74", Offset = "0x2353B74", VA = "0x2353B74")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x195B84", Offset = "0x195B84")]
		private PlatformVars _003Cget_platformVarsDict_003Eb__57_8()
		{
			return null;
		}

		[Token(Token = "0x6000CC7")]
		[Address(RVA = "0x2353BD0", Offset = "0x2353BD0", VA = "0x2353BD0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x195B94", Offset = "0x195B94")]
		private PlatformVars _003Cget_platformVarsDict_003Eb__57_9()
		{
			return null;
		}

		[Token(Token = "0x6000CC8")]
		[Address(RVA = "0x2353C2C", Offset = "0x2353C2C", VA = "0x2353C2C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x195BA4", Offset = "0x195BA4")]
		private PlatformVars _003Cget_platformVarsDict_003Eb__57_10()
		{
			return null;
		}

		[Token(Token = "0x6000CC9")]
		[Address(RVA = "0x2353C88", Offset = "0x2353C88", VA = "0x2353C88")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x195BB4", Offset = "0x195BB4")]
		private PlatformVars _003Cget_platformVarsDict_003Eb__57_11()
		{
			return null;
		}

		[Token(Token = "0x6000CCA")]
		[Address(RVA = "0x2353CE4", Offset = "0x2353CE4", VA = "0x2353CE4")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x195BC4", Offset = "0x195BC4")]
		private PlatformVars _003Cget_platformVarsDict_003Eb__57_12()
		{
			return null;
		}

		[Token(Token = "0x6000CCB")]
		[Address(RVA = "0x2353D40", Offset = "0x2353D40", VA = "0x2353D40")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x195BD4", Offset = "0x195BD4")]
		private PlatformVars _003Cget_platformVarsDict_003Eb__57_13()
		{
			return null;
		}

		[Token(Token = "0x6000CCC")]
		[Address(RVA = "0x2353D9C", Offset = "0x2353D9C", VA = "0x2353D9C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x195BE4", Offset = "0x195BE4")]
		private PlatformVars _003Cget_platformVarsDict_003Eb__57_14()
		{
			return null;
		}

		[Token(Token = "0x6000CCD")]
		[Address(RVA = "0x2353DF8", Offset = "0x2353DF8", VA = "0x2353DF8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x195BF4", Offset = "0x195BF4")]
		private PlatformVars _003Cget_platformVarsDict_003Eb__57_15()
		{
			return null;
		}

		[Token(Token = "0x6000CCE")]
		[Address(RVA = "0x2353E54", Offset = "0x2353E54", VA = "0x2353E54")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x195C04", Offset = "0x195C04")]
		private PlatformVars _003Cget_platformVarsDict_003Eb__57_16()
		{
			return null;
		}
	}
}
