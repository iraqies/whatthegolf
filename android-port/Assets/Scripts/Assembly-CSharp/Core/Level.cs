using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;

namespace Core
{
	[Token(Token = "0x200142D")]
	public class Level : MonoBehaviour
	{
		[Token(Token = "0x200142E")]
		public class State
		{
			[Token(Token = "0x4006D6A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public readonly string Name;

			[Token(Token = "0x4006D6B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static readonly State NotPlaying;

			[Token(Token = "0x4006D6C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public static readonly State Playing;

			[Token(Token = "0x6005E66")]
			[Address(RVA = "0x17D11A4", Offset = "0x17D11A4", VA = "0x17D11A4")]
			protected State(string name)
			{
			}
		}

		[Token(Token = "0x200142F")]
		public class AbortState : State
		{
			[Token(Token = "0x4006D6D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public readonly int Strokes;

			[Token(Token = "0x6005E68")]
			[Address(RVA = "0x17D1110", Offset = "0x17D1110", VA = "0x17D1110")]
			public AbortState(int strokes)
			{
			}
		}

		[Token(Token = "0x2001430")]
		public class RestartState : State
		{
			[Token(Token = "0x4006D6E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public readonly int Strokes;

			[Token(Token = "0x6005E69")]
			[Address(RVA = "0x17D1384", Offset = "0x17D1384", VA = "0x17D1384")]
			public RestartState(int strokes)
			{
			}
		}

		[Token(Token = "0x2001431")]
		public class FailState : State
		{
			[Token(Token = "0x4006D6F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public readonly bool DoReload;

			[Token(Token = "0x4006D70")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
			public readonly bool ShowTransition;

			[Token(Token = "0x4006D71")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public readonly float Delay;

			[Token(Token = "0x4006D72")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public readonly bool PlayFailSFX;

			[Token(Token = "0x4006D73")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			public readonly int Strokes;

			[Token(Token = "0x4006D74")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public string Message;

			[Token(Token = "0x6005E6A")]
			[Address(RVA = "0x17D12B0", Offset = "0x17D12B0", VA = "0x17D12B0")]
			public FailState(bool doReload, bool showTransition, float delay = 0f, bool playFailSFX = false, int strokes = 0, string message = "")
			{
			}
		}

		[Token(Token = "0x2001432")]
		public class CompletedState : State
		{
			[Token(Token = "0x4006D75")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public string Message;

			[Token(Token = "0x4006D76")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public float Delay;

			[Token(Token = "0x4006D77")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			public int Strokes;

			[Token(Token = "0x4006D78")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public TransitionTextEffect TransitionTextEffect;

			[Token(Token = "0x4006D79")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public int LevelSkips;

			[Token(Token = "0x4006D7A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			public bool LeaveLevel;

			[Token(Token = "0x4006D7B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public GolfBallController[] AllControllers;

			[Token(Token = "0x6005E6B")]
			[Address(RVA = "0x17D11D0", Offset = "0x17D11D0", VA = "0x17D11D0")]
			public CompletedState([Optional] string message, [Optional][DefaultParameterValue(1f)] float delay, [Optional][DefaultParameterValue(-1)] int strokes, [Optional] TransitionTextEffect transitionTextEffect, [Optional][DefaultParameterValue(0)] int levelSkips, [Optional][DefaultParameterValue(false)] bool leaveLevel, [Optional] GolfBallController[] allControllers)
			{
			}
		}

		[Token(Token = "0x2001433")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x4907C", Offset = "0x4907C")]
		private sealed class _003CPlay_003Ed__49 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4006D7C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int _003C_003E1__state;

			[Token(Token = "0x4006D7D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object _003C_003E2__current;

			[Token(Token = "0x4006D7E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Level _003C_003E4__this;

			[Token(Token = "0x4006D7F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public Action<State> onDone;

			[Token(Token = "0x17000AB5")]
			private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
			{
				[Token(Token = "0x6005E6F")]
				[Address(RVA = "0x17D10C0", Offset = "0x17D10C0", VA = "0x17D10C0", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
				}
			}

			[Token(Token = "0x17000AB6")]
			private object System_002ECollections_002EIEnumerator_002ECurrent
			{
				[Token(Token = "0x6005E71")]
				[Address(RVA = "0x17D1108", Offset = "0x17D1108", VA = "0x17D1108", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EIEnumerator_002Eget_Current();
				}
			}

			[Token(Token = "0x6005E6C")]
			[Address(RVA = "0x17D0C60", Offset = "0x17D0C60", VA = "0x17D0C60")]
			[DebuggerHidden]
			public _003CPlay_003Ed__49(int _003C_003E1__state)
			{
			}

			[Token(Token = "0x6005E6D")]
			[Address(RVA = "0x17D0C8C", Offset = "0x17D0C8C", VA = "0x17D0C8C", Slot = "5")]
			[DebuggerHidden]
			private void System_002EIDisposable_002EDispose()
			{
			}

			[Token(Token = "0x6005E6E")]
			[Address(RVA = "0x17D0C90", Offset = "0x17D0C90", VA = "0x17D0C90", Slot = "6")]
			private bool MoveNext()
			{
				return default;
			}

			[Token(Token = "0x6005E6F")]
			[Address(RVA = "0x17D10C0", Offset = "0x17D10C0", VA = "0x17D10C0", Slot = "4")]
			[DebuggerHidden]
			private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
			{
				return null;
			}

			[Token(Token = "0x6005E70")]
			[Address(RVA = "0x17D10C8", Offset = "0x17D10C8", VA = "0x17D10C8", Slot = "8")]
			[DebuggerHidden]
			private void System_002ECollections_002EIEnumerator_002EReset()
			{
			}

			[Token(Token = "0x6005E71")]
			[Address(RVA = "0x17D1108", Offset = "0x17D1108", VA = "0x17D1108", Slot = "7")]
			[DebuggerHidden]
			private object System_002ECollections_002EIEnumerator_002Eget_Current()
			{
				return null;
			}
		}

		[Serializable]
		[Token(Token = "0x2001434")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x4908C", Offset = "0x4908C")]
		private sealed class _003C_003Ec
		{
			[Token(Token = "0x4006D80")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static readonly _003C_003Ec _003C_003E9;

			[Token(Token = "0x4006D81")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public static Func<GolfBallController, int> _003C_003E9__56_0;

			[Token(Token = "0x6005E73")]
			[Address(RVA = "0x17D0C40", Offset = "0x17D0C40", VA = "0x17D0C40")]
			public _003C_003Ec()
			{
			}

			[Token(Token = "0x6005E74")]
			[Address(RVA = "0x17D0C48", Offset = "0x17D0C48", VA = "0x17D0C48")]
			internal int _003CGetHighestAmountOfStrokes_003Eb__56_0(GolfBallController c)
			{
				return default;
			}
		}

		[Token(Token = "0x4006D53")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public LevelMusic music;

		[Token(Token = "0x4006D54")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5B96C", Offset = "0x5B96C")]
		private Action m_OnReset;

		[Token(Token = "0x4006D55")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5B97C", Offset = "0x5B97C")]
		private Action m_OnStart;

		[Token(Token = "0x4006D56")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5B98C", Offset = "0x5B98C")]
		private Action<MultiplayerLevelInfo> m_OnMultiplayerSetup;

		[Token(Token = "0x4006D57")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5B99C", Offset = "0x5B99C")]
		private Action<GolfBallController, string, State> m_OnFail;

		[Token(Token = "0x4006D58")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5B9AC", Offset = "0x5B9AC")]
		private Action<CompletedState> m_OnComplete;

		[Token(Token = "0x4006D59")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5B9BC", Offset = "0x5B9BC")]
		private Action m_OnAbort;

		[Token(Token = "0x4006D5A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5B9CC", Offset = "0x5B9CC")]
		private Action m_OnRestart;

		[Token(Token = "0x4006D5B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5B9DC", Offset = "0x5B9DC")]
		private int LevelStartStrokes__BackingField;

		[Token(Token = "0x4006D5C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private State state;

		[Token(Token = "0x4006D5D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[SerializeField]
		private float postCompletionDelay;

		[Token(Token = "0x4006D5E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private LevelManager levelManager;

		[Token(Token = "0x4006D5F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private bool isWaitingForGif;

		[Token(Token = "0x4006D60")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x79")]
		private bool changeStateAfterGif;

		[Token(Token = "0x4006D61")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private MultiplayerConfiguration multiplayerConfiguration;

		[Token(Token = "0x4006D62")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private MultiplayerLevelInfo multiplayerLevelInfo;

		[Token(Token = "0x4006D63")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private List<GolfBallController> controllers;

		[Token(Token = "0x4006D64")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private float mobileCheatTimer;

		[Token(Token = "0x4006D65")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5B9FC", Offset = "0x5B9FC")]
		private Action m_OnOutOfBounds;

		[Token(Token = "0x4006D66")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private GolfBallController _ball;

		[Token(Token = "0x4006D67")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private GolfGoal _goal;

		[Token(Token = "0x4006D68")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		public float WinDelay;

		[Token(Token = "0x4006D69")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static Level instance;

		[Token(Token = "0x17000AAD")]
		public int LevelStartStrokes
		{
			[Token(Token = "0x6005E44")]
			[Address(RVA = "0x152398C", Offset = "0x152398C", VA = "0x152398C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x72C74", Offset = "0x72C74")]
			get
			{
				return default;
			}
			[Token(Token = "0x6005E45")]
			[Address(RVA = "0x1523994", Offset = "0x1523994", VA = "0x1523994")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x72C84", Offset = "0x72C84")]
			set
			{
			}
		}

		[Token(Token = "0x17000AAE")]
		public bool IsMultiplayer
		{
			[Token(Token = "0x6005E46")]
			[Address(RVA = "0x152399C", Offset = "0x152399C", VA = "0x152399C")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000AAF")]
		public GolfBallController Ball
		{
			[Token(Token = "0x6005E5D")]
			[Address(RVA = "0x1523EB0", Offset = "0x1523EB0", VA = "0x1523EB0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000AB0")]
		public GolfGoal Goal
		{
			[Token(Token = "0x6005E5E")]
			[Address(RVA = "0x1523DEC", Offset = "0x1523DEC", VA = "0x1523DEC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000AB1")]
		public bool IsAiming
		{
			[Token(Token = "0x6005E5F")]
			[Address(RVA = "0x1525150", Offset = "0x1525150", VA = "0x1525150")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000AB2")]
		public static Level Instance
		{
			[Token(Token = "0x6005E62")]
			[Address(RVA = "0x1525288", Offset = "0x1525288", VA = "0x1525288")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000AB3")]
		public static bool HasInstance
		{
			[Token(Token = "0x6005E63")]
			[Address(RVA = "0x1525370", Offset = "0x1525370", VA = "0x1525370")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000AB4")]
		public TransitionTextEffects TransitionTextEffects
		{
			[Token(Token = "0x6005E64")]
			[Address(RVA = "0x1525404", Offset = "0x1525404", VA = "0x1525404")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x140000A7")]
		public event Action OnReset
		{
			[Token(Token = "0x6005E36")]
			[Address(RVA = "0x1523094", Offset = "0x1523094", VA = "0x1523094")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x72B94", Offset = "0x72B94")]
			add
			{
			}
			[Token(Token = "0x6005E37")]
			[Address(RVA = "0x1523138", Offset = "0x1523138", VA = "0x1523138")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x72BA4", Offset = "0x72BA4")]
			remove
			{
			}
		}

		[Token(Token = "0x140000A8")]
		public event Action OnStart
		{
			[Token(Token = "0x6005E38")]
			[Address(RVA = "0x15231DC", Offset = "0x15231DC", VA = "0x15231DC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x72BB4", Offset = "0x72BB4")]
			add
			{
			}
			[Token(Token = "0x6005E39")]
			[Address(RVA = "0x1523280", Offset = "0x1523280", VA = "0x1523280")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x72BC4", Offset = "0x72BC4")]
			remove
			{
			}
		}

		[Token(Token = "0x140000A9")]
		public event Action<MultiplayerLevelInfo> OnMultiplayerSetup
		{
			[Token(Token = "0x6005E3A")]
			[Address(RVA = "0x1523324", Offset = "0x1523324", VA = "0x1523324")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x72BD4", Offset = "0x72BD4")]
			add
			{
			}
			[Token(Token = "0x6005E3B")]
			[Address(RVA = "0x15233C8", Offset = "0x15233C8", VA = "0x15233C8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x72BE4", Offset = "0x72BE4")]
			remove
			{
			}
		}

		[Token(Token = "0x140000AA")]
		public event Action<GolfBallController, string, State> OnFail
		{
			[Token(Token = "0x6005E3C")]
			[Address(RVA = "0x152346C", Offset = "0x152346C", VA = "0x152346C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x72BF4", Offset = "0x72BF4")]
			add
			{
			}
			[Token(Token = "0x6005E3D")]
			[Address(RVA = "0x1523510", Offset = "0x1523510", VA = "0x1523510")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x72C04", Offset = "0x72C04")]
			remove
			{
			}
		}

		[Token(Token = "0x140000AB")]
		public event Action<CompletedState> OnComplete
		{
			[Token(Token = "0x6005E3E")]
			[Address(RVA = "0x15235B4", Offset = "0x15235B4", VA = "0x15235B4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x72C14", Offset = "0x72C14")]
			add
			{
			}
			[Token(Token = "0x6005E3F")]
			[Address(RVA = "0x1523658", Offset = "0x1523658", VA = "0x1523658")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x72C24", Offset = "0x72C24")]
			remove
			{
			}
		}

		[Token(Token = "0x140000AC")]
		public event Action OnAbort
		{
			[Token(Token = "0x6005E40")]
			[Address(RVA = "0x15236FC", Offset = "0x15236FC", VA = "0x15236FC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x72C34", Offset = "0x72C34")]
			add
			{
			}
			[Token(Token = "0x6005E41")]
			[Address(RVA = "0x15237A0", Offset = "0x15237A0", VA = "0x15237A0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x72C44", Offset = "0x72C44")]
			remove
			{
			}
		}

		[Token(Token = "0x140000AD")]
		public event Action OnRestart
		{
			[Token(Token = "0x6005E42")]
			[Address(RVA = "0x1523844", Offset = "0x1523844", VA = "0x1523844")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x72C54", Offset = "0x72C54")]
			add
			{
			}
			[Token(Token = "0x6005E43")]
			[Address(RVA = "0x15238E8", Offset = "0x15238E8", VA = "0x15238E8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x72C64", Offset = "0x72C64")]
			remove
			{
			}
		}

		[Token(Token = "0x140000AE")]
		public event Action OnOutOfBounds
		{
			[Token(Token = "0x6005E5B")]
			[Address(RVA = "0x1525008", Offset = "0x1525008", VA = "0x1525008")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x72C94", Offset = "0x72C94")]
			add
			{
			}
			[Token(Token = "0x6005E5C")]
			[Address(RVA = "0x15250AC", Offset = "0x15250AC", VA = "0x15250AC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x72CA4", Offset = "0x72CA4")]
			remove
			{
			}
		}

		[Token(Token = "0x6005E47")]
		[Address(RVA = "0x15239AC", Offset = "0x15239AC", VA = "0x15239AC")]
		public void AddGolfballController(GolfBallController controller)
		{
		}

		[Token(Token = "0x6005E48")]
		[Address(RVA = "0x1523A68", Offset = "0x1523A68", VA = "0x1523A68")]
		public void RemoveGolfballController(GolfBallController controller)
		{
		}

		[Token(Token = "0x6005E49")]
		[Address(RVA = "0x1523ACC", Offset = "0x1523ACC", VA = "0x1523ACC")]
		public List<GolfBallController> GetControllers()
		{
			return null;
		}

		[Token(Token = "0x6005E4A")]
		[Address(RVA = "0x1523B4C", Offset = "0x1523B4C", VA = "0x1523B4C")]
		public bool IsGyro()
		{
			return default;
		}

		[Token(Token = "0x6005E4B")]
		[Address(RVA = "0x1523BD8", Offset = "0x1523BD8", VA = "0x1523BD8")]
		private void Awake()
		{
		}

		[Token(Token = "0x6005E4C")]
		[Address(RVA = "0x1523C9C", Offset = "0x1523C9C", VA = "0x1523C9C")]
		public int GetLevelStartStrokes(int id)
		{
			return default;
		}

		[Token(Token = "0x6005E4D")]
		[Address(RVA = "0x1523CD0", Offset = "0x1523CD0", VA = "0x1523CD0")]
		public MultiplayerConfiguration GetMultiplayerConfiguration()
		{
			return null;
		}

		[Token(Token = "0x6005E4E")]
		[Address(RVA = "0x1523CD8", Offset = "0x1523CD8", VA = "0x1523CD8")]
		public MultiplayerLevelInfo GetMultiplayerLevelInfo()
		{
			return null;
		}

		[Token(Token = "0x6005E4F")]
		[Address(RVA = "0x1523CE0", Offset = "0x1523CE0", VA = "0x1523CE0")]
		public void Initialize(LevelManager levelManager)
		{
		}

		[Token(Token = "0x6005E50")]
		[Address(RVA = "0x15245F0", Offset = "0x15245F0", VA = "0x15245F0")]
		public void SetupMultiplayer(MultiplayerConfiguration config)
		{
		}

		[Token(Token = "0x6005E51")]
		[Address(RVA = "0x15246D8", Offset = "0x15246D8", VA = "0x15246D8")]
		public void ResetLevel()
		{
		}

		[Token(Token = "0x6005E52")]
		[Address(RVA = "0x15246EC", Offset = "0x15246EC", VA = "0x15246EC")]
		public void DoCheat()
		{
		}

		[Token(Token = "0x6005E53")]
		[Address(RVA = "0x1524AC8", Offset = "0x1524AC8", VA = "0x1524AC8")]
		public IEnumerator Play([Optional] Action<State> onDone, [Optional] Action<int> onStrokeChange)
		{
			return null;
		}

		[Token(Token = "0x6005E54")]
		[Address(RVA = "0x1524B40", Offset = "0x1524B40", VA = "0x1524B40")]
		public void WaitForGifStart()
		{
		}

		[Token(Token = "0x6005E55")]
		[Address(RVA = "0x1524B4C", Offset = "0x1524B4C", VA = "0x1524B4C")]
		public void WaitForGifDone()
		{
		}

		[Token(Token = "0x6005E56")]
		[Address(RVA = "0x1524B54", Offset = "0x1524B54", VA = "0x1524B54")]
		public void Fail([Optional][DefaultParameterValue(true)] bool doReload, [Optional][DefaultParameterValue(true)] bool showTransition, [Optional] GolfBallController controller, float delay = 0f, bool playFailSFX = true, string message = "")
		{
		}

		[Token(Token = "0x6005E57")]
		[Address(RVA = "0x1524940", Offset = "0x1524940", VA = "0x1524940")]
		public void Complete([Optional] string message, [Optional] float? delay, [Optional] TransitionTextEffect transitionTextEffect, int levelSkips = 0)
		{
		}

		[Token(Token = "0x6005E58")]
		[Address(RVA = "0x1524EE8", Offset = "0x1524EE8", VA = "0x1524EE8")]
		public void Abort()
		{
		}

		[Token(Token = "0x6005E59")]
		[Address(RVA = "0x1524F78", Offset = "0x1524F78", VA = "0x1524F78")]
		public void Restart()
		{
		}

		[Token(Token = "0x6005E5A")]
		[Address(RVA = "0x1524CFC", Offset = "0x1524CFC", VA = "0x1524CFC")]
		private int GetHighestAmountOfStrokes([Optional] GolfBallController backupController)
		{
			return default;
		}

		[Token(Token = "0x6005E60")]
		[Address(RVA = "0x15251EC", Offset = "0x15251EC", VA = "0x15251EC")]
		public void ToggleBall(GolfBallController c, bool isEnabled)
		{
		}

		[Token(Token = "0x6005E61")]
		[Address(RVA = "0x152520C", Offset = "0x152520C", VA = "0x152520C")]
		public void ToggleBall(GolfBallController[] controllers, bool isEnabled)
		{
		}

		[Token(Token = "0x6005E65")]
		[Address(RVA = "0x1525448", Offset = "0x1525448", VA = "0x1525448")]
		public Level()
		{
		}
	}
}
