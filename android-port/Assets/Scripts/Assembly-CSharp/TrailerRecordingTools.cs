using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Core;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000B73")]
public class TrailerRecordingTools : MonoBehaviour
{
	[Token(Token = "0x2000B74")]
	private enum FollowType
	{
		[Token(Token = "0x4003FD6")]
		staticFollow = 0,
		[Token(Token = "0x4003FD7")]
		tightFollow = 1,
		[Token(Token = "0x4003FD8")]
		normalFollow = 2
	}

	[Serializable]
	[Token(Token = "0x2000B75")]
	public struct CameraPreset
	{
		[Token(Token = "0x4003FD9")]
		[FieldOffset(Offset = "0x0")]
		public string Label;

		[Token(Token = "0x4003FDA")]
		[FieldOffset(Offset = "0x8")]
		public Vector3 Rotation;

		[Token(Token = "0x4003FDB")]
		[FieldOffset(Offset = "0x14")]
		public Vector3 Offset;

		[Token(Token = "0x4003FDC")]
		[FieldOffset(Offset = "0x20")]
		public Vector3 GlobalOffset;

		[Token(Token = "0x4003FDD")]
		[FieldOffset(Offset = "0x2C")]
		public float FOV;

		[Token(Token = "0x4003FDE")]
		[FieldOffset(Offset = "0x30")]
		internal bool isActive;
	}

	[Serializable]
	[Token(Token = "0x2000B76")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x438F0", Offset = "0x438F0")]
	private sealed class _003C_003Ec
	{
		[Token(Token = "0x4003FDF")]
		[FieldOffset(Offset = "0x0")]
		public static readonly _003C_003Ec _003C_003E9;

		[Token(Token = "0x4003FE0")]
		[FieldOffset(Offset = "0x8")]
		public static Action _003C_003E9__94_1;

		[Token(Token = "0x4003FE1")]
		[FieldOffset(Offset = "0x10")]
		public static Action _003C_003E9__94_5;

		[Token(Token = "0x4003FE2")]
		[FieldOffset(Offset = "0x18")]
		public static Action _003C_003E9__94_6;

		[Token(Token = "0x4003FE3")]
		[FieldOffset(Offset = "0x20")]
		public static Action<CameraPreset> _003C_003E9__94_9;

		[Token(Token = "0x6003753")]
		[Address(RVA = "0x186A1EC", Offset = "0x186A1EC", VA = "0x186A1EC")]
		public _003C_003Ec()
		{
		}

		[Token(Token = "0x6003754")]
		[Address(RVA = "0x186A1F4", Offset = "0x186A1F4", VA = "0x186A1F4")]
		internal void _003COnGUI_003Eb__94_1()
		{
		}

		[Token(Token = "0x6003755")]
		[Address(RVA = "0x186A1FC", Offset = "0x186A1FC", VA = "0x186A1FC")]
		internal void _003COnGUI_003Eb__94_5()
		{
		}

		[Token(Token = "0x6003756")]
		[Address(RVA = "0x186A274", Offset = "0x186A274", VA = "0x186A274")]
		internal void _003COnGUI_003Eb__94_6()
		{
		}

		[Token(Token = "0x6003757")]
		[Address(RVA = "0x186A318", Offset = "0x186A318", VA = "0x186A318")]
		internal void _003COnGUI_003Eb__94_9(CameraPreset c)
		{
		}
	}

	[Token(Token = "0x2000B77")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x43900", Offset = "0x43900")]
	private sealed class _003CReset_003Ed__134 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4003FE4")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x4003FE5")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x4003FE6")]
		[FieldOffset(Offset = "0x20")]
		public TrailerRecordingTools _003C_003E4__this;

		[Token(Token = "0x170005D0")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x600375B")]
			[Address(RVA = "0x186A434", Offset = "0x186A434", VA = "0x186A434", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x170005D1")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x600375D")]
			[Address(RVA = "0x186A47C", Offset = "0x186A47C", VA = "0x186A47C", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x6003758")]
		[Address(RVA = "0x186A344", Offset = "0x186A344", VA = "0x186A344")]
		[DebuggerHidden]
		public _003CReset_003Ed__134(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6003759")]
		[Address(RVA = "0x186A370", Offset = "0x186A370", VA = "0x186A370", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x600375A")]
		[Address(RVA = "0x186A374", Offset = "0x186A374", VA = "0x186A374", Slot = "6")]
		private bool MoveNext()
		{
			return default;
		}

		[Token(Token = "0x600375B")]
		[Address(RVA = "0x186A434", Offset = "0x186A434", VA = "0x186A434", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x600375C")]
		[Address(RVA = "0x186A43C", Offset = "0x186A43C", VA = "0x186A43C", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}

		[Token(Token = "0x600375D")]
		[Address(RVA = "0x186A47C", Offset = "0x186A47C", VA = "0x186A47C", Slot = "7")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}
	}

	[Token(Token = "0x2000B78")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x43910", Offset = "0x43910")]
	private sealed class _003C_003Ec__DisplayClass135_0
	{
		[Token(Token = "0x4003FE7")]
		[FieldOffset(Offset = "0x10")]
		public Action cb;

		[Token(Token = "0x600375E")]
		[Address(RVA = "0x186A320", Offset = "0x186A320", VA = "0x186A320")]
		public _003C_003Ec__DisplayClass135_0()
		{
		}

		[Token(Token = "0x600375F")]
		[Address(RVA = "0x186A328", Offset = "0x186A328", VA = "0x186A328")]
		internal void _003CSetTimeout_003Eb__0()
		{
		}
	}

	[Token(Token = "0x4003F85")]
	[FieldOffset(Offset = "0x18")]
	private FollowType followType;

	[Token(Token = "0x4003F86")]
	[FieldOffset(Offset = "0x20")]
	public GameObject clickCatchUIPrefab;

	[Token(Token = "0x4003F87")]
	[FieldOffset(Offset = "0x28")]
	private GameObject clickCatchUI;

	[Token(Token = "0x4003F88")]
	[FieldOffset(Offset = "0x30")]
	private GameObject clickCatchUICameraTools;

	[Token(Token = "0x4003F89")]
	[FieldOffset(Offset = "0x38")]
	private bool forceMobileCamera;

	[Token(Token = "0x4003F8A")]
	[FieldOffset(Offset = "0x39")]
	private bool showingRecordMenu;

	[Token(Token = "0x4003F8B")]
	[FieldOffset(Offset = "0x3A")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x509E8", Offset = "0x509E8")]
	private bool BeenOpenedOnce__BackingField;

	[Token(Token = "0x4003F8C")]
	[FieldOffset(Offset = "0x40")]
	private GameObject cameraManagerGO;

	[Token(Token = "0x4003F8D")]
	[FieldOffset(Offset = "0x48")]
	public GameObject CinemachineCameraPrefab;

	[Token(Token = "0x4003F8E")]
	[FieldOffset(Offset = "0x50")]
	private GameObject m_CinemachineCameraPrefab;

	[Token(Token = "0x4003F8F")]
	[FieldOffset(Offset = "0x58")]
	private bool lookAtGoal;

	[Token(Token = "0x4003F90")]
	[FieldOffset(Offset = "0x60")]
	private GUIStyle labelCenterStyle;

	[Token(Token = "0x4003F91")]
	[FieldOffset(Offset = "0x68")]
	private GUIStyle labelHeaderStyle;

	[Token(Token = "0x4003F92")]
	[FieldOffset(Offset = "0x70")]
	private GUIStyle toggledOnButtonStyle;

	[Token(Token = "0x4003F93")]
	[FieldOffset(Offset = "0x78")]
	private GUIStyle toggledOffButtonStyle;

	[Token(Token = "0x4003F94")]
	[FieldOffset(Offset = "0x80")]
	private GUIStyle trailerBoxStyle;

	[Token(Token = "0x4003F95")]
	[FieldOffset(Offset = "0x88")]
	private float timeScale;

	[Token(Token = "0x4003F96")]
	[FieldOffset(Offset = "0x8C")]
	private bool UIButtonsToggle;

	[Token(Token = "0x4003F97")]
	[FieldOffset(Offset = "0x8D")]
	private bool UIChallengeToggle;

	[Token(Token = "0x4003F98")]
	[FieldOffset(Offset = "0x8E")]
	private bool staticToggle;

	[Token(Token = "0x4003F99")]
	[FieldOffset(Offset = "0x90")]
	private Transform cameraFollowTransform;

	[Token(Token = "0x4003F9A")]
	[FieldOffset(Offset = "0x98")]
	private GameObject staticCameraFollowTransform;

	[Token(Token = "0x4003F9B")]
	[FieldOffset(Offset = "0xA0")]
	private bool cheatCompleteLevel;

	[Token(Token = "0x4003F9C")]
	[FieldOffset(Offset = "0xA1")]
	private bool cheatCompleteChallenge;

	[Token(Token = "0x4003F9D")]
	[FieldOffset(Offset = "0xA2")]
	private bool Use3DCamera;

	[Token(Token = "0x4003F9E")]
	[FieldOffset(Offset = "0xA3")]
	private bool UseCameraPresets;

	[Token(Token = "0x4003F9F")]
	[FieldOffset(Offset = "0xA4")]
	private float goalTimerOffset;

	[Token(Token = "0x4003FA0")]
	[FieldOffset(Offset = "0xA8")]
	private string goalTimerOffsetString;

	[Token(Token = "0x4003FA1")]
	[FieldOffset(Offset = "0xB0")]
	private GameObject golfGoalGO;

	[Token(Token = "0x4003FA2")]
	[FieldOffset(Offset = "0xB8")]
	private float rotationOffsetX;

	[Token(Token = "0x4003FA3")]
	[FieldOffset(Offset = "0xBC")]
	private float rotationOffsetY;

	[Token(Token = "0x4003FA4")]
	[FieldOffset(Offset = "0xC0")]
	private float rotationOffsetZ;

	[Token(Token = "0x4003FA5")]
	[FieldOffset(Offset = "0xC8")]
	private string rotationOffsetXString;

	[Token(Token = "0x4003FA6")]
	[FieldOffset(Offset = "0xD0")]
	private string rotationOffsetYString;

	[Token(Token = "0x4003FA7")]
	[FieldOffset(Offset = "0xD8")]
	private string rotationOffsetZString;

	[Token(Token = "0x4003FA8")]
	[FieldOffset(Offset = "0xE0")]
	private float zoomOffset;

	[Token(Token = "0x4003FA9")]
	[FieldOffset(Offset = "0xE8")]
	private string zoomOffsetString;

	[Token(Token = "0x4003FAA")]
	[FieldOffset(Offset = "0xF0")]
	private float cameraOffsetX;

	[Token(Token = "0x4003FAB")]
	[FieldOffset(Offset = "0xF4")]
	private float cameraOffsetY;

	[Token(Token = "0x4003FAC")]
	[FieldOffset(Offset = "0xF8")]
	private float cameraOffsetZ;

	[Token(Token = "0x4003FAD")]
	[FieldOffset(Offset = "0x100")]
	private string cameraOffsetXString;

	[Token(Token = "0x4003FAE")]
	[FieldOffset(Offset = "0x108")]
	private string cameraOffsetYString;

	[Token(Token = "0x4003FAF")]
	[FieldOffset(Offset = "0x110")]
	private string cameraOffsetZString;

	[Token(Token = "0x4003FB0")]
	[FieldOffset(Offset = "0x118")]
	private float globalOffsetX;

	[Token(Token = "0x4003FB1")]
	[FieldOffset(Offset = "0x11C")]
	private float globalOffsetY;

	[Token(Token = "0x4003FB2")]
	[FieldOffset(Offset = "0x120")]
	private float globalOffsetZ;

	[Token(Token = "0x4003FB3")]
	[FieldOffset(Offset = "0x128")]
	private string globalOffsetXString;

	[Token(Token = "0x4003FB4")]
	[FieldOffset(Offset = "0x130")]
	private string globalOffsetYString;

	[Token(Token = "0x4003FB5")]
	[FieldOffset(Offset = "0x138")]
	private string globalOffsetZString;

	[Token(Token = "0x4003FB6")]
	[FieldOffset(Offset = "0x0")]
	public static TrailerRecordingTools Instance;

	[Token(Token = "0x4003FB7")]
	[FieldOffset(Offset = "0x140")]
	private bool hasMusic;

	[Token(Token = "0x4003FB8")]
	[FieldOffset(Offset = "0x141")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x509F8", Offset = "0x509F8")]
	private bool HasShownTutorial__BackingField;

	[Token(Token = "0x4003FB9")]
	private const float defaultX = 1920f;

	[Token(Token = "0x4003FBA")]
	private const float defaultY = 1080f;

	[Token(Token = "0x4003FBB")]
	private const float jumpSmall = 0.1f;

	[Token(Token = "0x4003FBC")]
	private const float jumpLarge = 0.5f;

	[Token(Token = "0x4003FBD")]
	[FieldOffset(Offset = "0x144")]
	public int fontSize;

	[Token(Token = "0x4003FBE")]
	[FieldOffset(Offset = "0x148")]
	public int fontSizeSmall;

	[Token(Token = "0x4003FBF")]
	[FieldOffset(Offset = "0x14C")]
	public int basePadding;

	[Token(Token = "0x4003FC0")]
	[FieldOffset(Offset = "0x150")]
	public int buttonPadding;

	[Token(Token = "0x4003FC1")]
	[FieldOffset(Offset = "0x154")]
	private Rect RecordingMenu;

	[Token(Token = "0x4003FC2")]
	[FieldOffset(Offset = "0x164")]
	private Rect CameraMenu;

	[Token(Token = "0x4003FC3")]
	[FieldOffset(Offset = "0x174")]
	private bool hasSetupStyles;

	[Token(Token = "0x4003FC4")]
	[FieldOffset(Offset = "0x175")]
	private bool hasSetupCanvases;

	[Token(Token = "0x4003FC5")]
	[FieldOffset(Offset = "0x176")]
	private bool cameraTooCustom;

	[Token(Token = "0x4003FC6")]
	[FieldOffset(Offset = "0x178")]
	private List<CameraPreset> CameraPresets;

	[Token(Token = "0x4003FC7")]
	[FieldOffset(Offset = "0x180")]
	private CameraPreset NormalCameraPreset;

	[Token(Token = "0x4003FC8")]
	[FieldOffset(Offset = "0x1B8")]
	private GameObject StrokeCounterGO;

	[Token(Token = "0x4003FC9")]
	[FieldOffset(Offset = "0x1C0")]
	public float distanceToController;

	[Token(Token = "0x4003FCA")]
	[FieldOffset(Offset = "0x1C4")]
	public float defaultFOV;

	[Token(Token = "0x4003FCB")]
	[FieldOffset(Offset = "0x1C8")]
	private string levelName;

	[Token(Token = "0x4003FCC")]
	[FieldOffset(Offset = "0x1D0")]
	public bool usingCinemachine;

	[Token(Token = "0x4003FCD")]
	[FieldOffset(Offset = "0x1D4")]
	private float damping;

	[Token(Token = "0x4003FCE")]
	[FieldOffset(Offset = "0x1D8")]
	private string dampingString;

	[Token(Token = "0x4003FCF")]
	[FieldOffset(Offset = "0x1E0")]
	private string smoothStartString;

	[Token(Token = "0x4003FD0")]
	[FieldOffset(Offset = "0x1E8")]
	private string smoothUpdateString;

	[Token(Token = "0x4003FD1")]
	[FieldOffset(Offset = "0x1F0")]
	private string smoothAimString;

	[Token(Token = "0x4003FD2")]
	[FieldOffset(Offset = "0x1F8")]
	private float smoothStart;

	[Token(Token = "0x4003FD3")]
	[FieldOffset(Offset = "0x1FC")]
	private float smoothUpdate;

	[Token(Token = "0x4003FD4")]
	[FieldOffset(Offset = "0x200")]
	private float smoothAim;

	[Token(Token = "0x170005CE")]
	public bool BeenOpenedOnce
	{
		[Token(Token = "0x6003717")]
		[Address(RVA = "0x17232AC", Offset = "0x17232AC", VA = "0x17232AC")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6AB84", Offset = "0x6AB84")]
		get
		{
			return default;
		}
		[Token(Token = "0x6003718")]
		[Address(RVA = "0x17232B4", Offset = "0x17232B4", VA = "0x17232B4")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6AB94", Offset = "0x6AB94")]
		private set
		{
		}
	}

	[Token(Token = "0x170005CF")]
	public bool HasShownTutorial
	{
		[Token(Token = "0x6003719")]
		[Address(RVA = "0x17232BC", Offset = "0x17232BC", VA = "0x17232BC")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6ABA4", Offset = "0x6ABA4")]
		get
		{
			return default;
		}
		[Token(Token = "0x600371A")]
		[Address(RVA = "0x17232C4", Offset = "0x17232C4", VA = "0x17232C4")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6ABB4", Offset = "0x6ABB4")]
		private set
		{
		}
	}

	[Token(Token = "0x600371B")]
	[Address(RVA = "0x17232CC", Offset = "0x17232CC", VA = "0x17232CC")]
	private void Start()
	{
	}

	[Token(Token = "0x600371C")]
	[Address(RVA = "0x172374C", Offset = "0x172374C", VA = "0x172374C")]
	private void ResetTrailerTools(LevelData data)
	{
	}

	[Token(Token = "0x600371D")]
	[Address(RVA = "0x1723858", Offset = "0x1723858", VA = "0x1723858")]
	private void CalculatePresets()
	{
	}

	[Token(Token = "0x600371E")]
	[Address(RVA = "0x1723ACC", Offset = "0x1723ACC", VA = "0x1723ACC")]
	private void CreatePreset(Transform targetTransform, string label, Vector3 pos)
	{
	}

	[Token(Token = "0x600371F")]
	[Address(RVA = "0x1723600", Offset = "0x1723600", VA = "0x1723600")]
	public void EnableMenu()
	{
	}

	[Token(Token = "0x6003720")]
	[Address(RVA = "0x1723C40", Offset = "0x1723C40", VA = "0x1723C40")]
	public void DisableMenu()
	{
	}

	[Token(Token = "0x6003721")]
	[Address(RVA = "0x1723D68", Offset = "0x1723D68", VA = "0x1723D68")]
	private void OnGUI()
	{
	}

	[Token(Token = "0x6003722")]
	[Address(RVA = "0x17262F4", Offset = "0x17262F4", VA = "0x17262F4")]
	private void Label(string l, bool big = false)
	{
	}

	[Token(Token = "0x6003723")]
	[Address(RVA = "0x1726498", Offset = "0x1726498", VA = "0x1726498")]
	private void begin()
	{
	}

	[Token(Token = "0x6003724")]
	[Address(RVA = "0x1726560", Offset = "0x1726560", VA = "0x1726560")]
	private void end()
	{
	}

	[Token(Token = "0x6003725")]
	[Address(RVA = "0x1726568", Offset = "0x1726568", VA = "0x1726568")]
	private void ToggleButton(string on, string off, bool control, Action action)
	{
	}

	[Token(Token = "0x6003726")]
	[Address(RVA = "0x17266A0", Offset = "0x17266A0", VA = "0x17266A0")]
	private void plusMinusControl(string label, ref float field, ref string fieldString, float resetVal = 0f)
	{
	}

	[Token(Token = "0x6003727")]
	[Address(RVA = "0x1723500", Offset = "0x1723500", VA = "0x1723500")]
	private void SetMusic(bool enable)
	{
	}

	[Token(Token = "0x6003728")]
	[Address(RVA = "0x1726CB4", Offset = "0x1726CB4", VA = "0x1726CB4")]
	private static void ToggleMusic()
	{
	}

	[Token(Token = "0x6003729")]
	[Address(RVA = "0x1726D84", Offset = "0x1726D84", VA = "0x1726D84")]
	public static bool ShouldCheatCompleteLevel()
	{
		return default;
	}

	[Token(Token = "0x600372A")]
	[Address(RVA = "0x1726E50", Offset = "0x1726E50", VA = "0x1726E50")]
	public static bool ShouldCheatCompleteChallenge()
	{
		return default;
	}

	[Token(Token = "0x600372B")]
	[Address(RVA = "0x1726F1C", Offset = "0x1726F1C", VA = "0x1726F1C")]
	private void Update()
	{
	}

	[Token(Token = "0x600372C")]
	[Address(RVA = "0x1726F24", Offset = "0x1726F24", VA = "0x1726F24")]
	private void LateUpdate()
	{
	}

	[Token(Token = "0x600372D")]
	[Address(RVA = "0x1726034", Offset = "0x1726034", VA = "0x1726034")]
	private void IntroInformation()
	{
	}

	[Token(Token = "0x600372E")]
	[Address(RVA = "0x1725E00", Offset = "0x1725E00", VA = "0x1725E00")]
	private void SetClickCanvasToRect(ref GameObject click, Rect rect)
	{
	}

	[Token(Token = "0x600372F")]
	[Address(RVA = "0x1727348", Offset = "0x1727348", VA = "0x1727348")]
	private void SetActiveOverworldUI(bool enable)
	{
	}

	[Token(Token = "0x6003730")]
	[Address(RVA = "0x17274DC", Offset = "0x17274DC", VA = "0x17274DC")]
	private void SetActiveMenuAndFPS(bool enable)
	{
	}

	[Token(Token = "0x6003731")]
	[Address(RVA = "0x1727640", Offset = "0x1727640", VA = "0x1727640")]
	private void SetActiveLevelUI(bool enable)
	{
	}

	[Token(Token = "0x6003732")]
	[Address(RVA = "0x17278C0", Offset = "0x17278C0", VA = "0x17278C0")]
	private void SetChallengeUIAlpha(bool enable)
	{
	}

	[Token(Token = "0x6003733")]
	[Address(RVA = "0x1727B90", Offset = "0x1727B90", VA = "0x1727B90")]
	private void SetStrokeCounterActive(bool enable)
	{
	}

	[Token(Token = "0x6003734")]
	[Address(RVA = "0x1726F38", Offset = "0x1726F38", VA = "0x1726F38")]
	public void LateTick()
	{
	}

	[Token(Token = "0x6003735")]
	[Address(RVA = "0x1727D64", Offset = "0x1727D64", VA = "0x1727D64")]
	private void AddCam()
	{
	}

	[Token(Token = "0x6003736")]
	[Address(RVA = "0x1727D50", Offset = "0x1727D50", VA = "0x1727D50")]
	private void UpdateCam()
	{
	}

	[Token(Token = "0x6003737")]
	[Address(RVA = "0x17286F4", Offset = "0x17286F4", VA = "0x17286F4")]
	private void DeleteCam()
	{
	}

	[Token(Token = "0x6003738")]
	[Address(RVA = "0x1728A28", Offset = "0x1728A28", VA = "0x1728A28")]
	private void ToggleFreezeCamera()
	{
	}

	[Token(Token = "0x6003739")]
	[Address(RVA = "0x1727E7C", Offset = "0x1727E7C", VA = "0x1727E7C")]
	private void AddCBFollowCam()
	{
	}

	[Token(Token = "0x600373A")]
	[Address(RVA = "0x17284D0", Offset = "0x17284D0", VA = "0x17284D0")]
	private void UpdateCBFollowCam()
	{
	}

	[Token(Token = "0x600373B")]
	[Address(RVA = "0x1728BE8", Offset = "0x1728BE8", VA = "0x1728BE8")]
	private void SetCBStaticCamera()
	{
	}

	[Token(Token = "0x600373C")]
	[Address(RVA = "0x17287AC", Offset = "0x17287AC", VA = "0x17287AC")]
	private void DeleteCBFollowCam()
	{
	}

	[Token(Token = "0x600373D")]
	[Address(RVA = "0x1727D78", Offset = "0x1727D78", VA = "0x1727D78")]
	private void AddCinemachineCamera()
	{
	}

	[Token(Token = "0x600373E")]
	[Address(RVA = "0x17283D4", Offset = "0x17283D4", VA = "0x17283D4")]
	private void UpdateCinemachineCamera()
	{
	}

	[Token(Token = "0x600373F")]
	[Address(RVA = "0x1728708", Offset = "0x1728708", VA = "0x1728708")]
	private void DeleteCinemachineCamera()
	{
	}

	[Token(Token = "0x6003740")]
	[Address(RVA = "0x1728A48", Offset = "0x1728A48", VA = "0x1728A48")]
	private void ToggleCinemachineFreezeCamera()
	{
	}

	[Token(Token = "0x6003741")]
	[Address(RVA = "0x1728E68", Offset = "0x1728E68", VA = "0x1728E68")]
	private void SetFollowTransform(Transform t)
	{
	}

	[Token(Token = "0x6003742")]
	[Address(RVA = "0x1728F50", Offset = "0x1728F50", VA = "0x1728F50")]
	private Transform GetFollowTransform()
	{
		return null;
	}

	[Token(Token = "0x6003743")]
	[Address(RVA = "0x1728D14", Offset = "0x1728D14", VA = "0x1728D14")]
	private Transform GetSceneFollowTarget()
	{
		return null;
	}

	[Token(Token = "0x6003744")]
	[Address(RVA = "0x1727C9C", Offset = "0x1727C9C", VA = "0x1727C9C")]
	private void ToggleCursor()
	{
	}

	[Token(Token = "0x6003745")]
	[Address(RVA = "0x1729010", Offset = "0x1729010", VA = "0x1729010")]
	private void ToggleMobileCamera()
	{
	}

	[Token(Token = "0x6003746")]
	[Address(RVA = "0x17234AC", Offset = "0x17234AC", VA = "0x17234AC")]
	private void SetToCameraPreset(CameraPreset p)
	{
	}

	[Token(Token = "0x6003747")]
	[Address(RVA = "0x172587C", Offset = "0x172587C", VA = "0x172587C")]
	private void SetupStyles()
	{
	}

	[Token(Token = "0x6003748")]
	[Address(RVA = "0x1725CDC", Offset = "0x1725CDC", VA = "0x1725CDC")]
	private void SetupRects()
	{
	}

	[Token(Token = "0x6003749")]
	[Address(RVA = "0x17237E4", Offset = "0x17237E4", VA = "0x17237E4")]
	private IEnumerator Reset()
	{
		return null;
	}

	[Token(Token = "0x600374A")]
	[Address(RVA = "0x1729130", Offset = "0x1729130", VA = "0x1729130")]
	private void SetTimeout(Action cb, int mili)
	{
	}

	[Token(Token = "0x600374B")]
	[Address(RVA = "0x17292C0", Offset = "0x17292C0", VA = "0x17292C0")]
	public TrailerRecordingTools()
	{
	}

	[Token(Token = "0x600374C")]
	[Address(RVA = "0x1729448", Offset = "0x1729448", VA = "0x1729448")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6ABC4", Offset = "0x6ABC4")]
	private void _003COnGUI_003Eb__94_0()
	{
	}

	[Token(Token = "0x600374D")]
	[Address(RVA = "0x172944C", Offset = "0x172944C", VA = "0x172944C")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6ABD4", Offset = "0x6ABD4")]
	private void _003COnGUI_003Eb__94_2()
	{
	}

	[Token(Token = "0x600374E")]
	[Address(RVA = "0x1729450", Offset = "0x1729450", VA = "0x1729450")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6ABE4", Offset = "0x6ABE4")]
	private void _003COnGUI_003Eb__94_3()
	{
	}

	[Token(Token = "0x600374F")]
	[Address(RVA = "0x1729460", Offset = "0x1729460", VA = "0x1729460")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6ABF4", Offset = "0x6ABF4")]
	private void _003COnGUI_003Eb__94_4()
	{
	}

	[Token(Token = "0x6003750")]
	[Address(RVA = "0x1729470", Offset = "0x1729470", VA = "0x1729470")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6AC04", Offset = "0x6AC04")]
	private void _003COnGUI_003Eb__94_7()
	{
	}

	[Token(Token = "0x6003751")]
	[Address(RVA = "0x17294A4", Offset = "0x17294A4", VA = "0x17294A4")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6AC14", Offset = "0x6AC14")]
	private void _003COnGUI_003Eb__94_8()
	{
	}
}
