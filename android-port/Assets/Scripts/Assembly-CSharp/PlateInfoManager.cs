using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Core;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

[Token(Token = "0x20002BD")]
public class PlateInfoManager : MonoBehaviour
{
	[Token(Token = "0x20002BE")]
	public enum AreaState
	{
		[Token(Token = "0x4000EE6")]
		DOOR_CLOSED = 0,
		[Token(Token = "0x4000EE7")]
		DOOR_OPEN = 1,
		[Token(Token = "0x4000EE8")]
		LEVELS_COMLETE = 2,
		[Token(Token = "0x4000EE9")]
		CHALLENGES_COMPLETE = 3
	}

	[Token(Token = "0x20002BF")]
	public enum ChestID
	{
		[Token(Token = "0x4000EEB")]
		CHEST_CARS = 0,
		[Token(Token = "0x4000EEC")]
		CHEST_INTRO = 1,
		[Token(Token = "0x4000EED")]
		CHEST_EASY2D = 2,
		[Token(Token = "0x4000EEE")]
		CHEST_LIVINGROOM = 3,
		[Token(Token = "0x4000EEF")]
		CHEST_PLATFORMER = 4,
		[Token(Token = "0x4000EF0")]
		CHEST_SOCCER1 = 5,
		[Token(Token = "0x4000EF1")]
		CHEST_SPACE = 6,
		[Token(Token = "0x4000EF2")]
		CHEST_EXPLOSION = 7,
		[Token(Token = "0x4000EF3")]
		CHEST_OL = 8,
		[Token(Token = "0x4000EF4")]
		CHEST_LEBOWSKI = 9,
		[Token(Token = "0x4000EF5")]
		CHEST_PORTAL = 10,
		[Token(Token = "0x4000EF6")]
		CHEST_SUPERPUTT = 11,
		[Token(Token = "0x4000EF7")]
		CHEST_KITCHEN = 12,
		[Token(Token = "0x4000EF8")]
		CHEST_GRAVITY_MAIN = 13,
		[Token(Token = "0x4000EF9")]
		CHEST_GRAVITY_SIDE = 14,
		[Token(Token = "0x4000EFA")]
		CHEST_HOLOROOM = 15,
		[Token(Token = "0x4000EFB")]
		CHEST_FPG = 16,
		[Token(Token = "0x4000EFC")]
		CHEST_MUSIC = 17,
		[Token(Token = "0x4000EFD")]
		CHEST_STEALTH = 18,
		[Token(Token = "0x4000EFE")]
		CHEST_JUNGLE = 19,
		[Token(Token = "0x4000EFF")]
		CHEST_WATER = 20,
		[Token(Token = "0x4000F00")]
		CHEST_DESERT1 = 21,
		[Token(Token = "0x4000F01")]
		CHEST_DESERT2 = 22,
		[Token(Token = "0x4000F02")]
		CHEST_SAWABLE = 23,
		[Token(Token = "0x4000F03")]
		CHEST_END = 24
	}

	[Token(Token = "0x20002C0")]
	[SerializeField]
	private enum AreaIDEnum
	{
		[Token(Token = "0x4000F05")]
		INTRO_10 = 0,
		[Token(Token = "0x4000F06")]
		EASY2D_09A = 1,
		[Token(Token = "0x4000F07")]
		LIVINGROOM_09B = 2,
		[Token(Token = "0x4000F08")]
		PLATFORMERS_08A = 3,
		[Token(Token = "0x4000F09")]
		SOCCER_08B = 4,
		[Token(Token = "0x4000F0A")]
		SPACE_08C = 5,
		[Token(Token = "0x4000F0B")]
		EXPLOSION_08D = 6,
		[Token(Token = "0x4000F0C")]
		OL_07A = 7,
		[Token(Token = "0x4000F0D")]
		LEBOWSKI_07B = 8,
		[Token(Token = "0x4000F0E")]
		PORTAL_06A = 9,
		[Token(Token = "0x4000F0F")]
		SUPERPUTT_06B = 10,
		[Token(Token = "0x4000F10")]
		KITCHEN_05A = 11,
		[Token(Token = "0x4000F11")]
		GRAVITY_05B = 12,
		[Token(Token = "0x4000F12")]
		FPG_05C = 13,
		[Token(Token = "0x4000F13")]
		MUSIC_04A = 14,
		[Token(Token = "0x4000F14")]
		STEALTH_04B = 15,
		[Token(Token = "0x4000F15")]
		JUNGLE_03A = 16,
		[Token(Token = "0x4000F16")]
		CARS_03B = 17,
		[Token(Token = "0x4000F17")]
		WATER_02 = 18,
		[Token(Token = "0x4000F18")]
		WETERN_01 = 19,
		[Token(Token = "0x4000F19")]
		END_00 = 20
	}

	[Token(Token = "0x20002C1")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3EC1C", Offset = "0x3EC1C")]
	private sealed class _003C_003Ec__DisplayClass23_0
	{
		[Token(Token = "0x4000F1A")]
		[FieldOffset(Offset = "0x10")]
		public string sectionName;

		[Token(Token = "0x6000CA1")]
		[Address(RVA = "0x18268CC", Offset = "0x18268CC", VA = "0x18268CC")]
		public _003C_003Ec__DisplayClass23_0()
		{
		}

		[Token(Token = "0x6000CA2")]
		[Address(RVA = "0x18268D4", Offset = "0x18268D4", VA = "0x18268D4")]
		internal bool _003CStartAfter_003Eb__2(OverworldLevelSection s)
		{
			return default;
		}
	}

	[Serializable]
	[Token(Token = "0x20002C2")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3EC2C", Offset = "0x3EC2C")]
	private sealed class _003C_003Ec
	{
		[Token(Token = "0x4000F1B")]
		[FieldOffset(Offset = "0x0")]
		public static readonly _003C_003Ec _003C_003E9;

		[Token(Token = "0x4000F1C")]
		[FieldOffset(Offset = "0x8")]
		public static Func<OverworldGoal, LevelData> _003C_003E9__23_0;

		[Token(Token = "0x4000F1D")]
		[FieldOffset(Offset = "0x10")]
		public static Func<LevelData, bool> _003C_003E9__23_3;

		[Token(Token = "0x4000F1E")]
		[FieldOffset(Offset = "0x18")]
		public static Func<LevelData, bool> _003C_003E9__23_4;

		[Token(Token = "0x4000F1F")]
		[FieldOffset(Offset = "0x20")]
		public static Func<OverworldGoal, bool> _003C_003E9__29_0;

		[Token(Token = "0x4000F20")]
		[FieldOffset(Offset = "0x28")]
		public static Func<OverworldGoal, bool> _003C_003E9__29_1;

		[Token(Token = "0x4000F21")]
		[FieldOffset(Offset = "0x30")]
		public static Func<LevelData, bool> _003C_003E9__29_2;

		[Token(Token = "0x4000F22")]
		[FieldOffset(Offset = "0x38")]
		public static Func<LevelData, bool> _003C_003E9__29_3;

		[Token(Token = "0x6000CA4")]
		[Address(RVA = "0x18265D8", Offset = "0x18265D8", VA = "0x18265D8")]
		public _003C_003Ec()
		{
		}

		[Token(Token = "0x6000CA5")]
		[Address(RVA = "0x18265E0", Offset = "0x18265E0", VA = "0x18265E0")]
		internal LevelData _003CStartAfter_003Eb__23_0(OverworldGoal g)
		{
			return null;
		}

		[Token(Token = "0x6000CA6")]
		[Address(RVA = "0x18265F8", Offset = "0x18265F8", VA = "0x18265F8")]
		internal bool _003CStartAfter_003Eb__23_3(LevelData l)
		{
			return default;
		}

		[Token(Token = "0x6000CA7")]
		[Address(RVA = "0x18266AC", Offset = "0x18266AC", VA = "0x18266AC")]
		internal bool _003CStartAfter_003Eb__23_4(LevelData l)
		{
			return default;
		}

		[Token(Token = "0x6000CA8")]
		[Address(RVA = "0x1826740", Offset = "0x1826740", VA = "0x1826740")]
		internal bool _003CGetCompletedAnCrowns_003Eb__29_0(OverworldGoal l)
		{
			return default;
		}

		[Token(Token = "0x6000CA9")]
		[Address(RVA = "0x182675C", Offset = "0x182675C", VA = "0x182675C")]
		internal bool _003CGetCompletedAnCrowns_003Eb__29_1(OverworldGoal g)
		{
			return default;
		}

		[Token(Token = "0x6000CAA")]
		[Address(RVA = "0x1826778", Offset = "0x1826778", VA = "0x1826778")]
		internal bool _003CGetCompletedAnCrowns_003Eb__29_2(LevelData l)
		{
			return default;
		}

		[Token(Token = "0x6000CAB")]
		[Address(RVA = "0x1826810", Offset = "0x1826810", VA = "0x1826810")]
		internal bool _003CGetCompletedAnCrowns_003Eb__29_3(LevelData l)
		{
			return default;
		}
	}

	[Token(Token = "0x20002C3")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3EC3C", Offset = "0x3EC3C")]
	private sealed class _003CStartAfter_003Ed__23 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000F23")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x4000F24")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x4000F25")]
		[FieldOffset(Offset = "0x20")]
		public PlateInfoManager _003C_003E4__this;

		[Token(Token = "0x17000183")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6000CAF")]
			[Address(RVA = "0x18274B4", Offset = "0x18274B4", VA = "0x18274B4", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x17000184")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6000CB1")]
			[Address(RVA = "0x18274FC", Offset = "0x18274FC", VA = "0x18274FC", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x6000CAC")]
		[Address(RVA = "0x1826C74", Offset = "0x1826C74", VA = "0x1826C74")]
		[DebuggerHidden]
		public _003CStartAfter_003Ed__23(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6000CAD")]
		[Address(RVA = "0x1826CA0", Offset = "0x1826CA0", VA = "0x1826CA0", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6000CAE")]
		[Address(RVA = "0x1826CA4", Offset = "0x1826CA4", VA = "0x1826CA4", Slot = "6")]
		private bool MoveNext()
		{
			return default;
		}

		[Token(Token = "0x6000CAF")]
		[Address(RVA = "0x18274B4", Offset = "0x18274B4", VA = "0x18274B4", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x6000CB0")]
		[Address(RVA = "0x18274BC", Offset = "0x18274BC", VA = "0x18274BC", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}

		[Token(Token = "0x6000CB1")]
		[Address(RVA = "0x18274FC", Offset = "0x18274FC", VA = "0x18274FC", Slot = "7")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}
	}

	[Token(Token = "0x20002C4")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3EC4C", Offset = "0x3EC4C")]
	private sealed class _003CAnimateIn_003Ed__32 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000F26")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x4000F27")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x4000F28")]
		[FieldOffset(Offset = "0x20")]
		public PlateInfoManager _003C_003E4__this;

		[Token(Token = "0x17000185")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6000CB5")]
			[Address(RVA = "0x1826C24", Offset = "0x1826C24", VA = "0x1826C24", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x17000186")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6000CB7")]
			[Address(RVA = "0x1826C6C", Offset = "0x1826C6C", VA = "0x1826C6C", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x6000CB2")]
		[Address(RVA = "0x18268F8", Offset = "0x18268F8", VA = "0x18268F8")]
		[DebuggerHidden]
		public _003CAnimateIn_003Ed__32(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6000CB3")]
		[Address(RVA = "0x1826924", Offset = "0x1826924", VA = "0x1826924", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6000CB4")]
		[Address(RVA = "0x1826928", Offset = "0x1826928", VA = "0x1826928", Slot = "6")]
		private bool MoveNext()
		{
			return default;
		}

		[Token(Token = "0x6000CB5")]
		[Address(RVA = "0x1826C24", Offset = "0x1826C24", VA = "0x1826C24", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x6000CB6")]
		[Address(RVA = "0x1826C2C", Offset = "0x1826C2C", VA = "0x1826C2C", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}

		[Token(Token = "0x6000CB7")]
		[Address(RVA = "0x1826C6C", Offset = "0x1826C6C", VA = "0x1826C6C", Slot = "7")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}
	}

	[Token(Token = "0x4000ED0")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	private Animator BubbleAnimator;

	[Token(Token = "0x4000ED1")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private OverworldMainDoorPlate plate;

	[Token(Token = "0x4000ED2")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	private TextMeshPro text;

	[Token(Token = "0x4000ED3")]
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	private GameObject DefaultIcon;

	[Token(Token = "0x4000ED4")]
	[FieldOffset(Offset = "0x38")]
	[SerializeField]
	private GameObject CrownIcon;

	[Token(Token = "0x4000ED5")]
	[FieldOffset(Offset = "0x40")]
	[SerializeField]
	private GameObject Text;

	[Token(Token = "0x4000ED6")]
	[FieldOffset(Offset = "0x48")]
	[SerializeField]
	private GameObject ABTransition;

	[Token(Token = "0x4000ED7")]
	[FieldOffset(Offset = "0x50")]
	[SerializeField]
	private GameObject BCTransition;

	[Token(Token = "0x4000ED8")]
	[FieldOffset(Offset = "0x58")]
	[SerializeField]
	private OverworldLevelData _campaignData;

	[Token(Token = "0x4000ED9")]
	[FieldOffset(Offset = "0x60")]
	[SerializeField]
	private AreaIDEnum Name;

	[Token(Token = "0x4000EDA")]
	[FieldOffset(Offset = "0x68")]
	[SerializeField]
	private GameObject Container;

	[Token(Token = "0x4000EDB")]
	[FieldOffset(Offset = "0x70")]
	[SerializeField]
	private GameObject Tip;

	[Token(Token = "0x4000EDC")]
	[FieldOffset(Offset = "0x78")]
	private List<LevelData> levels;

	[Token(Token = "0x4000EDD")]
	[FieldOffset(Offset = "0x80")]
	public OverworldButton2D overrideLevels;

	[Token(Token = "0x4000EDE")]
	[FieldOffset(Offset = "0x88")]
	public ChestID chestID;

	[Token(Token = "0x4000EDF")]
	[FieldOffset(Offset = "0x8C")]
	private AreaState areaState;

	[Token(Token = "0x4000EE0")]
	[FieldOffset(Offset = "0x90")]
	public Action<AreaState> onAreaStateChanged;

	[Token(Token = "0x4000EE1")]
	[FieldOffset(Offset = "0x98")]
	private List<OverworldGoal> goals;

	[Token(Token = "0x4000EE2")]
	[FieldOffset(Offset = "0xA0")]
	private bool usingGoals;

	[Token(Token = "0x4000EE3")]
	[FieldOffset(Offset = "0x0")]
	private static OverworldGoal[] overworldGoalCache;

	[Token(Token = "0x4000EE4")]
	[FieldOffset(Offset = "0xA1")]
	private bool isAnimating;

	[Token(Token = "0x6000C8D")]
	[Address(RVA = "0x15E5400", Offset = "0x15E5400", VA = "0x15E5400")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000C8E")]
	[Address(RVA = "0x15E547C", Offset = "0x15E547C", VA = "0x15E547C")]
	private IEnumerator StartAfter()
	{
		return null;
	}

	[Token(Token = "0x6000C8F")]
	[Address(RVA = "0x15E54F0", Offset = "0x15E54F0", VA = "0x15E54F0")]
	private OverworldGoal[] GetOverworldGoalInstances()
	{
		return null;
	}

	[Token(Token = "0x6000C90")]
	[Address(RVA = "0x15E5684", Offset = "0x15E5684", VA = "0x15E5684")]
	private static void onSceneUnloaded(Scene scene)
	{
	}

	[Token(Token = "0x6000C91")]
	[Address(RVA = "0x15E57B4", Offset = "0x15E57B4", VA = "0x15E57B4")]
	private static void ClearOverworldGoalCache()
	{
	}

	[Token(Token = "0x6000C92")]
	[Address(RVA = "0x15E586C", Offset = "0x15E586C", VA = "0x15E586C")]
	private void UpdateState()
	{
	}

	[Token(Token = "0x6000C93")]
	[Address(RVA = "0x15E5914", Offset = "0x15E5914", VA = "0x15E5914")]
	private Tuple<int, int> GetCompletedAnCrowns()
	{
		return null;
	}

	[Token(Token = "0x6000C94")]
	[Address(RVA = "0x15E5E3C", Offset = "0x15E5E3C", VA = "0x15E5E3C")]
	private void UpdateState(bool overworld)
	{
	}

	[Token(Token = "0x6000C95")]
	[Address(RVA = "0x15E5E48", Offset = "0x15E5E48", VA = "0x15E5E48")]
	private IEnumerator AnimateIn()
	{
		return null;
	}

	[Token(Token = "0x6000C96")]
	[Address(RVA = "0x15E5EBC", Offset = "0x15E5EBC", VA = "0x15E5EBC")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x6000C97")]
	[Address(RVA = "0x15E6138", Offset = "0x15E6138", VA = "0x15E6138")]
	public void ShowText()
	{
	}

	[Token(Token = "0x6000C98")]
	[Address(RVA = "0x15E6000", Offset = "0x15E6000", VA = "0x15E6000")]
	public void OnAnimationDone()
	{
	}

	[Token(Token = "0x6000C99")]
	[Address(RVA = "0x15E5CF0", Offset = "0x15E5CF0", VA = "0x15E5CF0")]
	private AreaState GetState(int completed, int crowns)
	{
		return default;
	}

	[Token(Token = "0x6000C9A")]
	[Address(RVA = "0x15E66F4", Offset = "0x15E66F4", VA = "0x15E66F4")]
	private static string SectionID(AreaIDEnum id)
	{
		return null;
	}

	[Token(Token = "0x6000C9B")]
	[Address(RVA = "0x15E67E8", Offset = "0x15E67E8", VA = "0x15E67E8")]
	public PlateInfoManager()
	{
	}

	[Token(Token = "0x6000C9D")]
	[Address(RVA = "0x15E67F4", Offset = "0x15E67F4", VA = "0x15E67F4")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6055C", Offset = "0x6055C")]
	private bool _003CStartAfter_003Eb__23_5(OverworldGoal g)
	{
		return default;
	}

	[Token(Token = "0x6000C9E")]
	[Address(RVA = "0x15E6878", Offset = "0x15E6878", VA = "0x15E6878")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6056C", Offset = "0x6056C")]
	private void _003CStartAfter_003Eb__23_1(bool isOn, bool onLoad)
	{
	}

	[Token(Token = "0x6000C9F")]
	[Address(RVA = "0x15E687C", Offset = "0x15E687C", VA = "0x15E687C")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6057C", Offset = "0x6057C")]
	private void _003CAnimateIn_003Eb__32_0(float t)
	{
	}

	[Token(Token = "0x6000CA0")]
	[Address(RVA = "0x15E69A0", Offset = "0x15E69A0", VA = "0x15E69A0")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6058C", Offset = "0x6058C")]
	private void _003CAnimateIn_003Eb__32_1(float t)
	{
	}
}
