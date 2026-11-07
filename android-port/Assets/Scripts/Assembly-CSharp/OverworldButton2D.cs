using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Audio;
using CameraStack;
using Core;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;
using UnityEngine.Tilemaps;

[Token(Token = "0x20009E8")]
public class OverworldButton2D : GolfBehaviour
{
	[Token(Token = "0x20009E9")]
	public enum ButtonType
	{
		[Token(Token = "0x40036AE")]
		fromLeft = 0,
		[Token(Token = "0x40036AF")]
		fromRight = 1,
		[Token(Token = "0x40036B0")]
		fromBelow = 2,
		[Token(Token = "0x40036B1")]
		fromAboveTilted = 3
	}

	[Token(Token = "0x20009EA")]
	public enum AddOrRemoveNotification
	{
		[Token(Token = "0x40036B3")]
		Add = 0,
		[Token(Token = "0x40036B4")]
		Remove = 1
	}

	[Token(Token = "0x20009EB")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x42828", Offset = "0x42828")]
	private sealed class _003C_003Ec__DisplayClass68_0
	{
		[Token(Token = "0x40036B5")]
		[FieldOffset(Offset = "0x10")]
		public float targetY;

		[Token(Token = "0x40036B6")]
		[FieldOffset(Offset = "0x18")]
		public System.Random r;

		[Token(Token = "0x6002EF6")]
		[Address(RVA = "0x180D614", Offset = "0x180D614", VA = "0x180D614")]
		public _003C_003Ec__DisplayClass68_0()
		{
		}

		[Token(Token = "0x6002EF7")]
		[Address(RVA = "0x180D61C", Offset = "0x180D61C", VA = "0x180D61C")]
		internal bool _003CFlagHintRoutine_003Eb__3(Vector3 pos)
		{
			return default;
		}

		[Token(Token = "0x6002EF8")]
		[Address(RVA = "0x180D62C", Offset = "0x180D62C", VA = "0x180D62C")]
		internal int _003CFlagHintRoutine_003Eb__4(Vector3 a)
		{
			return default;
		}
	}

	[Serializable]
	[Token(Token = "0x20009EC")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x42838", Offset = "0x42838")]
	private sealed class _003C_003Ec
	{
		[Token(Token = "0x40036B7")]
		[FieldOffset(Offset = "0x0")]
		public static readonly _003C_003Ec _003C_003E9;

		[Token(Token = "0x40036B8")]
		[FieldOffset(Offset = "0x8")]
		public static Func<LevelData, bool> _003C_003E9__68_2;

		[Token(Token = "0x40036B9")]
		[FieldOffset(Offset = "0x10")]
		public static Converter<OverworldGoal, Vector3> _003C_003E9__68_1;

		[Token(Token = "0x40036BA")]
		[FieldOffset(Offset = "0x18")]
		public static Func<OverworldGoal, bool> _003C_003E9__76_0;

		[Token(Token = "0x40036BB")]
		[FieldOffset(Offset = "0x20")]
		public static Func<OverworldGoal, bool> _003C_003E9__80_0;

		[Token(Token = "0x40036BC")]
		[FieldOffset(Offset = "0x28")]
		public static Action _003C_003E9__84_0;

		[Token(Token = "0x40036BD")]
		[FieldOffset(Offset = "0x30")]
		public static Action _003C_003E9__84_1;

		[Token(Token = "0x6002EFA")]
		[Address(RVA = "0x180D570", Offset = "0x180D570", VA = "0x180D570")]
		public _003C_003Ec()
		{
		}

		[Token(Token = "0x6002EFB")]
		[Address(RVA = "0x180D578", Offset = "0x180D578", VA = "0x180D578")]
		internal bool _003CFlagHintRoutine_003Eb__68_2(LevelData g)
		{
			return default;
		}

		[Token(Token = "0x6002EFC")]
		[Address(RVA = "0x180D5A0", Offset = "0x180D5A0", VA = "0x180D5A0")]
		internal Vector3 _003CFlagHintRoutine_003Eb__68_1(OverworldGoal goal)
		{
			return default;
		}

		[Token(Token = "0x6002EFD")]
		[Address(RVA = "0x180D5CC", Offset = "0x180D5CC", VA = "0x180D5CC")]
		internal bool _003CUpdateStatus_003Eb__76_0(OverworldGoal g)
		{
			return default;
		}

		[Token(Token = "0x6002EFE")]
		[Address(RVA = "0x180D5E8", Offset = "0x180D5E8", VA = "0x180D5E8")]
		internal bool _003CCanDoorBeOpened_003Eb__80_0(OverworldGoal r)
		{
			return default;
		}

		[Token(Token = "0x6002EFF")]
		[Address(RVA = "0x180D60C", Offset = "0x180D60C", VA = "0x180D60C")]
		internal void _003COpenAndClose_003Eb__84_0()
		{
		}

		[Token(Token = "0x6002F00")]
		[Address(RVA = "0x180D610", Offset = "0x180D610", VA = "0x180D610")]
		internal void _003COpenAndClose_003Eb__84_1()
		{
		}
	}

	[Token(Token = "0x20009ED")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x42848", Offset = "0x42848")]
	private sealed class _003CFlagHintRoutine_003Ed__68 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40036BE")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x40036BF")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x40036C0")]
		[FieldOffset(Offset = "0x20")]
		public OverworldButton2D _003C_003E4__this;

		[Token(Token = "0x170004CE")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6002F04")]
			[Address(RVA = "0x180E150", Offset = "0x180E150", VA = "0x180E150", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x170004CF")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6002F06")]
			[Address(RVA = "0x180E198", Offset = "0x180E198", VA = "0x180E198", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x6002F01")]
		[Address(RVA = "0x180DA6C", Offset = "0x180DA6C", VA = "0x180DA6C")]
		[DebuggerHidden]
		public _003CFlagHintRoutine_003Ed__68(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6002F02")]
		[Address(RVA = "0x180DA98", Offset = "0x180DA98", VA = "0x180DA98", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6002F03")]
		[Address(RVA = "0x180DA9C", Offset = "0x180DA9C", VA = "0x180DA9C", Slot = "6")]
		private bool MoveNext()
		{
			return default;
		}

		[Token(Token = "0x6002F04")]
		[Address(RVA = "0x180E150", Offset = "0x180E150", VA = "0x180E150", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x6002F05")]
		[Address(RVA = "0x180E158", Offset = "0x180E158", VA = "0x180E158", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}

		[Token(Token = "0x6002F06")]
		[Address(RVA = "0x180E198", Offset = "0x180E198", VA = "0x180E198", Slot = "7")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}
	}

	[Token(Token = "0x20009EE")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x42858", Offset = "0x42858")]
	private sealed class _003CBlinkRoutine_003Ed__69 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40036C1")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x40036C2")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x40036C3")]
		[FieldOffset(Offset = "0x20")]
		public OverworldButton2D _003C_003E4__this;

		[Token(Token = "0x40036C4")]
		[FieldOffset(Offset = "0x28")]
		private WaitForSeconds _003Cwait_003E5__2;

		[Token(Token = "0x170004D0")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6002F0A")]
			[Address(RVA = "0x180D8AC", Offset = "0x180D8AC", VA = "0x180D8AC", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x170004D1")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6002F0C")]
			[Address(RVA = "0x180D8F4", Offset = "0x180D8F4", VA = "0x180D8F4", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x6002F07")]
		[Address(RVA = "0x180D64C", Offset = "0x180D64C", VA = "0x180D64C")]
		[DebuggerHidden]
		public _003CBlinkRoutine_003Ed__69(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6002F08")]
		[Address(RVA = "0x180D678", Offset = "0x180D678", VA = "0x180D678", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6002F09")]
		[Address(RVA = "0x180D67C", Offset = "0x180D67C", VA = "0x180D67C", Slot = "6")]
		private bool MoveNext()
		{
			return default;
		}

		[Token(Token = "0x6002F0A")]
		[Address(RVA = "0x180D8AC", Offset = "0x180D8AC", VA = "0x180D8AC", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x6002F0B")]
		[Address(RVA = "0x180D8B4", Offset = "0x180D8B4", VA = "0x180D8B4", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}

		[Token(Token = "0x6002F0C")]
		[Address(RVA = "0x180D8F4", Offset = "0x180D8F4", VA = "0x180D8F4", Slot = "7")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}
	}

	[Token(Token = "0x20009EF")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x42868", Offset = "0x42868")]
	private sealed class _003COpenAndClose_003Ed__84 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40036C5")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x40036C6")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x40036C7")]
		[FieldOffset(Offset = "0x20")]
		public OverworldButton2D _003C_003E4__this;

		[Token(Token = "0x40036C8")]
		[FieldOffset(Offset = "0x28")]
		public float delay;

		[Token(Token = "0x170004D2")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6002F10")]
			[Address(RVA = "0x180E4D0", Offset = "0x180E4D0", VA = "0x180E4D0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x170004D3")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6002F12")]
			[Address(RVA = "0x180E518", Offset = "0x180E518", VA = "0x180E518", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x6002F0D")]
		[Address(RVA = "0x180E1A0", Offset = "0x180E1A0", VA = "0x180E1A0")]
		[DebuggerHidden]
		public _003COpenAndClose_003Ed__84(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6002F0E")]
		[Address(RVA = "0x180E1CC", Offset = "0x180E1CC", VA = "0x180E1CC", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6002F0F")]
		[Address(RVA = "0x180E1D0", Offset = "0x180E1D0", VA = "0x180E1D0", Slot = "6")]
		private bool MoveNext()
		{
			return default;
		}

		[Token(Token = "0x6002F10")]
		[Address(RVA = "0x180E4D0", Offset = "0x180E4D0", VA = "0x180E4D0", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x6002F11")]
		[Address(RVA = "0x180E4D8", Offset = "0x180E4D8", VA = "0x180E4D8", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}

		[Token(Token = "0x6002F12")]
		[Address(RVA = "0x180E518", Offset = "0x180E518", VA = "0x180E518", Slot = "7")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}
	}

	[Token(Token = "0x20009F0")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x42878", Offset = "0x42878")]
	private sealed class _003CCheatingRoutine_003Ed__94 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40036C9")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x40036CA")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x40036CB")]
		[FieldOffset(Offset = "0x20")]
		public OverworldButton2D _003C_003E4__this;

		[Token(Token = "0x170004D4")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6002F16")]
			[Address(RVA = "0x180DA1C", Offset = "0x180DA1C", VA = "0x180DA1C", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x170004D5")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6002F18")]
			[Address(RVA = "0x180DA64", Offset = "0x180DA64", VA = "0x180DA64", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x6002F13")]
		[Address(RVA = "0x180D8FC", Offset = "0x180D8FC", VA = "0x180D8FC")]
		[DebuggerHidden]
		public _003CCheatingRoutine_003Ed__94(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6002F14")]
		[Address(RVA = "0x180D928", Offset = "0x180D928", VA = "0x180D928", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6002F15")]
		[Address(RVA = "0x180D92C", Offset = "0x180D92C", VA = "0x180D92C", Slot = "6")]
		private bool MoveNext()
		{
			return default;
		}

		[Token(Token = "0x6002F16")]
		[Address(RVA = "0x180DA1C", Offset = "0x180DA1C", VA = "0x180DA1C", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x6002F17")]
		[Address(RVA = "0x180DA24", Offset = "0x180DA24", VA = "0x180DA24", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}

		[Token(Token = "0x6002F18")]
		[Address(RVA = "0x180DA64", Offset = "0x180DA64", VA = "0x180DA64", Slot = "7")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}
	}

	[Token(Token = "0x4003674")]
	[FieldOffset(Offset = "0x20")]
	public OverworldButton2D previous;

	[Token(Token = "0x4003675")]
	[FieldOffset(Offset = "0x28")]
	public OverworldMainDoorRobot previousBoss;

	[Token(Token = "0x4003676")]
	[FieldOffset(Offset = "0x30")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5009C", Offset = "0x5009C")]
	private Action m_OnOpen;

	[Token(Token = "0x4003677")]
	[FieldOffset(Offset = "0x38")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x500AC", Offset = "0x500AC")]
	private Action m_OnStartingToOpen;

	[Token(Token = "0x4003678")]
	[FieldOffset(Offset = "0x40")]
	public bool isStartingOpen;

	[Token(Token = "0x4003679")]
	[FieldOffset(Offset = "0x48")]
	public Transform flagContainer;

	[Token(Token = "0x400367A")]
	[FieldOffset(Offset = "0x50")]
	public int flagsRequiredOffset;

	[Token(Token = "0x400367B")]
	[FieldOffset(Offset = "0x58")]
	public TextMeshPro missingFlagsText;

	[Token(Token = "0x400367C")]
	[FieldOffset(Offset = "0x60")]
	public Transform openIndicator;

	[Token(Token = "0x400367D")]
	[FieldOffset(Offset = "0x68")]
	public PlantParticles openParticles;

	[Token(Token = "0x400367E")]
	[FieldOffset(Offset = "0x70")]
	public float BallDistanceThreshold;

	[Token(Token = "0x400367F")]
	[FieldOffset(Offset = "0x74")]
	public bool canOpen;

	[Token(Token = "0x4003680")]
	[FieldOffset(Offset = "0x78")]
	public float volumeMultiplier;

	[Token(Token = "0x4003681")]
	[FieldOffset(Offset = "0x7C")]
	public ButtonType orientation;

	[Token(Token = "0x4003682")]
	[FieldOffset(Offset = "0x80")]
	public AudioClip sfxOnOpen;

	[Token(Token = "0x4003683")]
	[FieldOffset(Offset = "0x88")]
	public AudioClip sfxExplosion;

	[Token(Token = "0x4003684")]
	[FieldOffset(Offset = "0x90")]
	public bool isTilted;

	[Token(Token = "0x4003685")]
	[FieldOffset(Offset = "0x98")]
	public OverworldDoor HorizontalDoor;

	[Token(Token = "0x4003686")]
	[FieldOffset(Offset = "0xA0")]
	public OverworldDoor VerticalDoor;

	[Token(Token = "0x4003687")]
	[FieldOffset(Offset = "0xA8")]
	public Transform DoorBubbleTransform;

	[Token(Token = "0x4003688")]
	[FieldOffset(Offset = "0xB0")]
	public SpriteRenderer BubbleSprite;

	[Token(Token = "0x4003689")]
	[FieldOffset(Offset = "0xB8")]
	public SpriteRenderer SubObjectiveSprite;

	[Token(Token = "0x400368A")]
	[FieldOffset(Offset = "0xC0")]
	public bool isSnappingToGrid;

	[Token(Token = "0x400368B")]
	[FieldOffset(Offset = "0xC1")]
	public bool isShowingHintLines;

	[Token(Token = "0x400368C")]
	[FieldOffset(Offset = "0xC4")]
	public int maxHintLinesToShow;

	[Token(Token = "0x400368D")]
	[FieldOffset(Offset = "0xC8")]
	public bool onlyIncludeFlagsBelowThis;

	[Token(Token = "0x400368E")]
	[FieldOffset(Offset = "0xC9")]
	public bool useOpenIndicator;

	[Token(Token = "0x400368F")]
	[FieldOffset(Offset = "0xD0")]
	public Collectable subObjective;

	[Token(Token = "0x4003690")]
	[FieldOffset(Offset = "0xD8")]
	public int subObjectiveGoal;

	[Token(Token = "0x4003691")]
	[FieldOffset(Offset = "0xE0")]
	public List<OverworldGoal> requireGoals;

	[Token(Token = "0x4003692")]
	[FieldOffset(Offset = "0xE8")]
	public ClipSettingsCollection sfxOpen;

	[Token(Token = "0x4003693")]
	[FieldOffset(Offset = "0xF0")]
	public ClipSettingsCollection sfxAfterOpen;

	[Token(Token = "0x4003694")]
	[FieldOffset(Offset = "0xF8")]
	public bool OnlyAcceptCrowns;

	[Token(Token = "0x4003695")]
	[FieldOffset(Offset = "0xF9")]
	public bool UseAllFlagsInOverworld;

	[Token(Token = "0x4003696")]
	[FieldOffset(Offset = "0x100")]
	private OverworldCamera camera;

	[Token(Token = "0x4003697")]
	[FieldOffset(Offset = "0x108")]
	private bool currentlyCheating;

	[Token(Token = "0x4003698")]
	[FieldOffset(Offset = "0x10C")]
	private float cheatUnlockTimer;

	[Token(Token = "0x4003699")]
	[FieldOffset(Offset = "0x110")]
	private Tilemap tileMap;

	[Token(Token = "0x400369A")]
	[FieldOffset(Offset = "0x118")]
	protected DoorBubble doorBubble;

	[Token(Token = "0x400369B")]
	[FieldOffset(Offset = "0x120")]
	private OverworldDoor door;

	[Token(Token = "0x400369C")]
	[FieldOffset(Offset = "0x128")]
	public OverworldMainButton ConsoleButton;

	[NonSerialized]
	[Token(Token = "0x400369D")]
	[FieldOffset(Offset = "0x130")]
	public bool openOrOpening;

	[Token(Token = "0x400369E")]
	[FieldOffset(Offset = "0x131")]
	private bool hasSubobjectives;

	[Token(Token = "0x400369F")]
	[FieldOffset(Offset = "0x138")]
	[SerializeField]
	private PerlinShake bubbleShake;

	[Token(Token = "0x40036A0")]
	[FieldOffset(Offset = "0x140")]
	private int count;

	[Token(Token = "0x40036A1")]
	[FieldOffset(Offset = "0x144")]
	public float UnlockBlinkRate;

	[Token(Token = "0x40036A2")]
	[FieldOffset(Offset = "0x148")]
	public Color[] OpenColors;

	[Token(Token = "0x40036A3")]
	[FieldOffset(Offset = "0x150")]
	public Color[] UnlockedColors;

	[Token(Token = "0x40036A4")]
	[FieldOffset(Offset = "0x158")]
	public Color[] LockedColors;

	[Token(Token = "0x40036A5")]
	[FieldOffset(Offset = "0x160")]
	public SpriteRenderer[] ButtonRenderers;

	[Token(Token = "0x40036A6")]
	[FieldOffset(Offset = "0x168")]
	public SpriteRenderer[] ButtonBackRenderers;

	[Token(Token = "0x40036A7")]
	[FieldOffset(Offset = "0x170")]
	private OverworldID overworldID;

	[Token(Token = "0x40036A8")]
	[FieldOffset(Offset = "0x178")]
	private Coroutine currentBlinkRoutine;

	[Token(Token = "0x40036A9")]
	[FieldOffset(Offset = "0x180")]
	private bool isActive;

	[Token(Token = "0x40036AA")]
	[FieldOffset(Offset = "0x181")]
	private bool canShowBubble;

	[Token(Token = "0x40036AB")]
	[FieldOffset(Offset = "0x184")]
	[SerializeField]
	private AddOrRemoveNotification addOrRemoveNotification;

	[Token(Token = "0x40036AC")]
	[FieldOffset(Offset = "0x188")]
	[SerializeField]
	private string levelNotificationId;

	[Token(Token = "0x170004CB")]
	public int GetTotalCount
	{
		[Token(Token = "0x6002ED6")]
		[Address(RVA = "0x15AA278", Offset = "0x15AA278", VA = "0x15AA278")]
		get
		{
			return default;
		}
	}

	[Token(Token = "0x170004CC")]
	public bool IsOpenOrOpening
	{
		[Token(Token = "0x6002EE3")]
		[Address(RVA = "0x15AC028", Offset = "0x15AC028", VA = "0x15AC028")]
		get
		{
			return default;
		}
	}

	[Token(Token = "0x170004CD")]
	public bool CanOpen
	{
		[Token(Token = "0x6002EE4")]
		[Address(RVA = "0x15AC030", Offset = "0x15AC030", VA = "0x15AC030")]
		get
		{
			return default;
		}
	}

	[Token(Token = "0x14000058")]
	public event Action OnOpen
	{
		[Token(Token = "0x6002ECA")]
		[Address(RVA = "0x15A882C", Offset = "0x15A882C", VA = "0x15A882C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x68AF8", Offset = "0x68AF8")]
		add
		{
		}
		[Token(Token = "0x6002ECB")]
		[Address(RVA = "0x15A88D0", Offset = "0x15A88D0", VA = "0x15A88D0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x68B08", Offset = "0x68B08")]
		remove
		{
		}
	}

	[Token(Token = "0x14000059")]
	public event Action OnStartingToOpen
	{
		[Token(Token = "0x6002ECC")]
		[Address(RVA = "0x15A8974", Offset = "0x15A8974", VA = "0x15A8974")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x68B18", Offset = "0x68B18")]
		add
		{
		}
		[Token(Token = "0x6002ECD")]
		[Address(RVA = "0x15A8A18", Offset = "0x15A8A18", VA = "0x15A8A18")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x68B28", Offset = "0x68B28")]
		remove
		{
		}
	}

	[Token(Token = "0x6002ECE")]
	[Address(RVA = "0x15A8ABC", Offset = "0x15A8ABC", VA = "0x15A8ABC", Slot = "4")]
	public override void OnPrePlayOrPreCompile()
	{
	}

	[Token(Token = "0x6002ECF")]
	[Address(RVA = "0x15A8B24", Offset = "0x15A8B24", VA = "0x15A8B24")]
	private void Awake()
	{
	}

	[Token(Token = "0x6002ED0")]
	[Address(RVA = "0x15A8B54", Offset = "0x15A8B54", VA = "0x15A8B54", Slot = "5")]
	public virtual void Init(Tilemap tilemap, List<OverworldGoal> goals, OverworldCamera camera)
	{
	}

	[Token(Token = "0x6002ED1")]
	[Address(RVA = "0x15A9F9C", Offset = "0x15A9F9C", VA = "0x15A9F9C")]
	private void HandlePreviousOpened()
	{
	}

	[Token(Token = "0x6002ED2")]
	[Address(RVA = "0x15AA178", Offset = "0x15AA178", VA = "0x15AA178")]
	public void AfterInit()
	{
	}

	[Token(Token = "0x6002ED3")]
	[Address(RVA = "0x15AA184", Offset = "0x15AA184", VA = "0x15AA184")]
	private IEnumerator FlagHintRoutine()
	{
		return null;
	}

	[Token(Token = "0x6002ED4")]
	[Address(RVA = "0x15AA1F8", Offset = "0x15AA1F8", VA = "0x15AA1F8")]
	private IEnumerator BlinkRoutine()
	{
		return null;
	}

	[Token(Token = "0x6002ED5")]
	[Address(RVA = "0x15AA26C", Offset = "0x15AA26C", VA = "0x15AA26C")]
	private void Goal_OnUpdateData(OverworldGoal obj)
	{
	}

	[Token(Token = "0x6002ED7")]
	[Address(RVA = "0x15AA330", Offset = "0x15AA330", VA = "0x15AA330", Slot = "6")]
	public virtual int GetFlagsLeft()
	{
		return default;
	}

	[Token(Token = "0x6002ED8")]
	[Address(RVA = "0x15A9D84", Offset = "0x15A9D84", VA = "0x15A9D84")]
	public void SetOpenIndicator(bool open, bool setRotation = false)
	{
	}

	[Token(Token = "0x6002ED9")]
	[Address(RVA = "0x15AA7C8", Offset = "0x15AA7C8", VA = "0x15AA7C8")]
	public void ToggleBlinkRoutine(bool turnOn)
	{
	}

	[Token(Token = "0x6002EDA")]
	[Address(RVA = "0x15AA890", Offset = "0x15AA890", VA = "0x15AA890", Slot = "7")]
	public virtual void UpdateStatus()
	{
	}

	[Token(Token = "0x6002EDB")]
	[Address(RVA = "0x15AB1A0", Offset = "0x15AB1A0", VA = "0x15AB1A0")]
	public void CheckOpen()
	{
	}

	[Token(Token = "0x6002EDC")]
	[Address(RVA = "0x15AB578", Offset = "0x15AB578", VA = "0x15AB578")]
	private void OnOpenDoorAnalytcis()
	{
	}

	[Token(Token = "0x6002EDD")]
	[Address(RVA = "0x15AB710", Offset = "0x15AB710", VA = "0x15AB710")]
	public void InstantOpenDoor()
	{
	}

	[Token(Token = "0x6002EDE")]
	[Address(RVA = "0x15AB8D8", Offset = "0x15AB8D8", VA = "0x15AB8D8")]
	public bool CanDoorBeOpened()
	{
		return default;
	}

	[Token(Token = "0x6002EDF")]
	[Address(RVA = "0x15ABB2C", Offset = "0x15ABB2C", VA = "0x15ABB2C")]
	public void OpenDoor()
	{
	}

	[Token(Token = "0x6002EE0")]
	[Address(RVA = "0x15ABE48", Offset = "0x15ABE48", VA = "0x15ABE48")]
	public void RemoveButton()
	{
	}

	[Token(Token = "0x6002EE1")]
	[Address(RVA = "0x15ABE94", Offset = "0x15ABE94", VA = "0x15ABE94")]
	public void JustOpen(bool instant = false)
	{
	}

	[Token(Token = "0x6002EE2")]
	[Address(RVA = "0x15ABFA4", Offset = "0x15ABFA4", VA = "0x15ABFA4")]
	public IEnumerator OpenAndClose(float delay)
	{
		return null;
	}

	[Token(Token = "0x6002EE5")]
	[Address(RVA = "0x15AC038", Offset = "0x15AC038", VA = "0x15AC038")]
	private void OnCollisionEnter2D(Collision2D collision)
	{
	}

	[Token(Token = "0x6002EE6")]
	[Address(RVA = "0x15A98F8", Offset = "0x15A98F8", VA = "0x15A98F8")]
	private Vector3 GetSnappedPosition()
	{
		return default;
	}

	[Token(Token = "0x6002EE7")]
	[Address(RVA = "0x15A9BE4", Offset = "0x15A9BE4", VA = "0x15A9BE4")]
	private ButtonType FlipTiltedOrientation(ButtonType orientation)
	{
		return default;
	}

	[Token(Token = "0x6002EE8")]
	[Address(RVA = "0x15AC250", Offset = "0x15AC250", VA = "0x15AC250")]
	public void OnDrawGizmos()
	{
	}

	[Token(Token = "0x6002EE9")]
	[Address(RVA = "0x15AC494", Offset = "0x15AC494", VA = "0x15AC494")]
	private void OnDrawGizmosSelected()
	{
	}

	[Token(Token = "0x6002EEA")]
	[Address(RVA = "0x15AC7F0", Offset = "0x15AC7F0", VA = "0x15AC7F0")]
	private IEnumerator CheatingRoutine()
	{
		return null;
	}

	[Token(Token = "0x6002EEB")]
	[Address(RVA = "0x15AC864", Offset = "0x15AC864", VA = "0x15AC864")]
	public void OnMouseDown()
	{
	}

	[Token(Token = "0x6002EEC")]
	[Address(RVA = "0x15AC948", Offset = "0x15AC948", VA = "0x15AC948")]
	public void OnMouseExit()
	{
	}

	[Token(Token = "0x6002EED")]
	[Address(RVA = "0x15AC960", Offset = "0x15AC960", VA = "0x15AC960")]
	public void OnMouseUp()
	{
	}

	[Token(Token = "0x6002EEE")]
	[Address(RVA = "0x15AC96C", Offset = "0x15AC96C", VA = "0x15AC96C")]
	public void DebugOpenDoor()
	{
	}

	[Token(Token = "0x6002EEF")]
	[Address(RVA = "0x15AC9F0", Offset = "0x15AC9F0", VA = "0x15AC9F0")]
	public OverworldButton2D()
	{
	}

	[Token(Token = "0x6002EF0")]
	[Address(RVA = "0x15ACA30", Offset = "0x15ACA30", VA = "0x15ACA30")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x68B38", Offset = "0x68B38")]
	private void _003CInit_003Eb__65_0()
	{
	}

	[Token(Token = "0x6002EF1")]
	[Address(RVA = "0x15ACAAC", Offset = "0x15ACAAC", VA = "0x15ACAAC")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x68B48", Offset = "0x68B48")]
	private bool _003CFlagHintRoutine_003Eb__68_0(OverworldGoal goal)
	{
		return default;
	}

	[Token(Token = "0x6002EF2")]
	[Address(RVA = "0x15AD0B0", Offset = "0x15AD0B0", VA = "0x15AD0B0")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x68B58", Offset = "0x68B58")]
	private void _003CCheckOpen_003Eb__77_0()
	{
	}

	[Token(Token = "0x6002EF3")]
	[Address(RVA = "0x15AD148", Offset = "0x15AD148", VA = "0x15AD148")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x68B68", Offset = "0x68B68")]
	private void _003CInstantOpenDoor_003Eb__79_0()
	{
	}

	[Token(Token = "0x6002EF4")]
	[Address(RVA = "0x15AD1C4", Offset = "0x15AD1C4", VA = "0x15AD1C4")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x68B78", Offset = "0x68B78")]
	private void _003COpenDoor_003Eb__81_0()
	{
	}

	[Token(Token = "0x6002EF5")]
	[Address(RVA = "0x15AD240", Offset = "0x15AD240", VA = "0x15AD240")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x68B88", Offset = "0x68B88")]
	private void _003CJustOpen_003Eb__83_0()
	{
	}
}
