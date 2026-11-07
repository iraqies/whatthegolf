using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Core;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x200019C")]
public class ImpossibleChallengeMenu : BasePackStarter
{
	[Token(Token = "0x200019D")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3DF10", Offset = "0x3DF10")]
	private sealed class _003C_003Ec__DisplayClass13_0
	{
		[Token(Token = "0x4000758")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public int strokes;

		[Token(Token = "0x4000759")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public ImpossibleChallengeMenu _003C_003E4__this;

		[Token(Token = "0x400075A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public bool completedAllLevels;

		[Token(Token = "0x400075B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x21")]
		public bool aborted;

		[Token(Token = "0x400075C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Action _003C_003E9__3;

		[Token(Token = "0x600072A")]
		[Address(RVA = "0x17C374C", Offset = "0x17C374C", VA = "0x17C374C")]
		public _003C_003Ec__DisplayClass13_0()
		{
		}

		[Token(Token = "0x600072B")]
		[Address(RVA = "0x17C3754", Offset = "0x17C3754", VA = "0x17C3754")]
		internal void _003CPlayRoutine_003Eb__3()
		{
		}
	}

	[Token(Token = "0x200019E")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3DF20", Offset = "0x3DF20")]
	private sealed class _003C_003Ec__DisplayClass13_1
	{
		[Token(Token = "0x400075D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public int i;

		[Token(Token = "0x400075E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public _003C_003Ec__DisplayClass13_0 CS_0024_003C_003E8__locals1;

		[Token(Token = "0x600072C")]
		[Address(RVA = "0x17C3760", Offset = "0x17C3760", VA = "0x17C3760")]
		public _003C_003Ec__DisplayClass13_1()
		{
		}

		[Token(Token = "0x600072D")]
		[Address(RVA = "0x17C3768", Offset = "0x17C3768", VA = "0x17C3768")]
		internal void _003CPlayRoutine_003Eb__0(LevelData l)
		{
		}

		[Token(Token = "0x600072E")]
		[Address(RVA = "0x17C37EC", Offset = "0x17C37EC", VA = "0x17C37EC")]
		internal void _003CPlayRoutine_003Eb__1(Level.CompletedState s)
		{
		}

		[Token(Token = "0x600072F")]
		[Address(RVA = "0x17C38B8", Offset = "0x17C38B8", VA = "0x17C38B8")]
		internal void _003CPlayRoutine_003Eb__2(Level.RestartState s)
		{
		}

		[Token(Token = "0x6000730")]
		[Address(RVA = "0x17C38F4", Offset = "0x17C38F4", VA = "0x17C38F4")]
		internal bool _003CPlayRoutine_003Eb__5()
		{
			return default;
		}
	}

	[Serializable]
	[Token(Token = "0x200019F")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3DF30", Offset = "0x3DF30")]
	private sealed class _003C_003Ec
	{
		[Token(Token = "0x400075F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static readonly _003C_003Ec _003C_003E9;

		[Token(Token = "0x4000760")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public static Action<bool> _003C_003E9__13_4;

		[Token(Token = "0x6000732")]
		[Address(RVA = "0x17C3740", Offset = "0x17C3740", VA = "0x17C3740")]
		public _003C_003Ec()
		{
		}

		[Token(Token = "0x6000733")]
		[Address(RVA = "0x17C3748", Offset = "0x17C3748", VA = "0x17C3748")]
		internal void _003CPlayRoutine_003Eb__13_4(bool s)
		{
		}
	}

	[Token(Token = "0x20001A0")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3DF40", Offset = "0x3DF40")]
	private sealed class _003CPlayRoutine_003Ed__13 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000761")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x4000762")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x4000763")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public ImpossibleChallengeMenu _003C_003E4__this;

		[Token(Token = "0x4000764")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private _003C_003Ec__DisplayClass13_1 _003C_003E8__1;

		[Token(Token = "0x4000765")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private _003C_003Ec__DisplayClass13_0 _003C_003E8__2;

		[Token(Token = "0x170000F8")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6000737")]
			[Address(RVA = "0x17C4448", Offset = "0x17C4448", VA = "0x17C4448", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x170000F9")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6000739")]
			[Address(RVA = "0x17C4490", Offset = "0x17C4490", VA = "0x17C4490", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x6000734")]
		[Address(RVA = "0x17C3B48", Offset = "0x17C3B48", VA = "0x17C3B48")]
		[DebuggerHidden]
		public _003CPlayRoutine_003Ed__13(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6000735")]
		[Address(RVA = "0x17C3B74", Offset = "0x17C3B74", VA = "0x17C3B74", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6000736")]
		[Address(RVA = "0x17C3B78", Offset = "0x17C3B78", VA = "0x17C3B78", Slot = "6")]
		private bool MoveNext()
		{
			return default;
		}

		[Token(Token = "0x6000737")]
		[Address(RVA = "0x17C4448", Offset = "0x17C4448", VA = "0x17C4448", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x6000738")]
		[Address(RVA = "0x17C4450", Offset = "0x17C4450", VA = "0x17C4450", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}

		[Token(Token = "0x6000739")]
		[Address(RVA = "0x17C4490", Offset = "0x17C4490", VA = "0x17C4490", Slot = "7")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Token(Token = "0x20001A1")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3DF50", Offset = "0x3DF50")]
	private struct _003CGoToHub_003Ed__14 : IAsyncStateMachine
	{
		[Token(Token = "0x4000766")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public int _003C_003E1__state;

		[Token(Token = "0x4000767")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public AsyncTaskMethodBuilder _003C_003Et__builder;

		[Token(Token = "0x4000768")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private TaskAwaiter _003C_003Eu__1;

		[Token(Token = "0x600073A")]
		[Address(RVA = "0x17C3904", Offset = "0x17C3904", VA = "0x17C3904", Slot = "4")]
		private void MoveNext()
		{
		}

		[Token(Token = "0x600073B")]
		[Address(RVA = "0x17C3B3C", Offset = "0x17C3B3C", VA = "0x17C3B3C", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Token(Token = "0x20001A2")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3DF60", Offset = "0x3DF60")]
	private sealed class _003CSubmitScore_003Ed__17 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000769")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x400076A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x400076B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public ImpossibleChallengeMenu _003C_003E4__this;

		[Token(Token = "0x400076C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public int strokes;

		[Token(Token = "0x400076D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public float pause;

		[Token(Token = "0x400076E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public int retries;

		[Token(Token = "0x170000FA")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x600073F")]
			[Address(RVA = "0x17C4658", Offset = "0x17C4658", VA = "0x17C4658", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x170000FB")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6000741")]
			[Address(RVA = "0x17C46A0", Offset = "0x17C46A0", VA = "0x17C46A0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x600073C")]
		[Address(RVA = "0x17C4498", Offset = "0x17C4498", VA = "0x17C4498")]
		[DebuggerHidden]
		public _003CSubmitScore_003Ed__17(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x600073D")]
		[Address(RVA = "0x17C44C4", Offset = "0x17C44C4", VA = "0x17C44C4", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x600073E")]
		[Address(RVA = "0x17C44C8", Offset = "0x17C44C8", VA = "0x17C44C8", Slot = "6")]
		private bool MoveNext()
		{
			return default;
		}

		[Token(Token = "0x600073F")]
		[Address(RVA = "0x17C4658", Offset = "0x17C4658", VA = "0x17C4658", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x6000740")]
		[Address(RVA = "0x17C4660", Offset = "0x17C4660", VA = "0x17C4660", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}

		[Token(Token = "0x6000741")]
		[Address(RVA = "0x17C46A0", Offset = "0x17C46A0", VA = "0x17C46A0", Slot = "7")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}
	}

	[Token(Token = "0x400074F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[SerializeField]
	private TextMeshProLocalized TitleLabel;

	[Token(Token = "0x4000750")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private ContentPack contentPack;

	[Token(Token = "0x4000751")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private LevelDataContainerWithChallenge levelPack;

	[Token(Token = "0x4000752")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private List<LevelDataAndChallenge> levelsToPlay;

	[Token(Token = "0x4000753")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	[SerializeField]
	private DailyChallengeCompleted CompletedScreen;

	[Token(Token = "0x4000754")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	[SerializeField]
	private LevelMusicSettings ChallengeMusic;

	[Token(Token = "0x4000755")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private int strokesToSubmit;

	[Token(Token = "0x4000756")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private Coroutine submitScoreRoutine;

	[Token(Token = "0x4000757")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private bool scoreIsSubmitted;

	[Token(Token = "0x600071E")]
	[Address(RVA = "0x14E929C", Offset = "0x14E929C", VA = "0x14E929C", Slot = "4")]
	public override bool StartPack(ContentPack container, params object[] additionalContext)
	{
		return default;
	}

	[Token(Token = "0x600071F")]
	[Address(RVA = "0x14E9418", Offset = "0x14E9418", VA = "0x14E9418")]
	private void Show()
	{
	}

	[Token(Token = "0x6000720")]
	[Address(RVA = "0x14E95C0", Offset = "0x14E95C0", VA = "0x14E95C0")]
	private void Hide()
	{
	}

	[Token(Token = "0x6000721")]
	[Address(RVA = "0x14E94E4", Offset = "0x14E94E4", VA = "0x14E94E4")]
	public void StartButtonClicked()
	{
	}

	[Token(Token = "0x6000722")]
	[Address(RVA = "0x14E962C", Offset = "0x14E962C", VA = "0x14E962C")]
	private IEnumerator PlayRoutine()
	{
		return null;
	}

	[Token(Token = "0x6000723")]
	[Address(RVA = "0x14E96A0", Offset = "0x14E96A0", VA = "0x14E96A0")]
	private Task GoToHub()
	{
		return null;
	}

	[Token(Token = "0x6000724")]
	[Address(RVA = "0x14E976C", Offset = "0x14E976C", VA = "0x14E976C")]
	private void Update()
	{
	}

	[Token(Token = "0x6000725")]
	[Address(RVA = "0x14E9910", Offset = "0x14E9910", VA = "0x14E9910")]
	private void SubmitScoreAndRefreshLeaderboard(int strokes)
	{
	}

	[Token(Token = "0x6000726")]
	[Address(RVA = "0x14E99BC", Offset = "0x14E99BC", VA = "0x14E99BC")]
	private IEnumerator SubmitScore(int strokes, float pause = 0f, int retries = 5)
	{
		return null;
	}

	[Token(Token = "0x6000727")]
	[Address(RVA = "0x14E9A58", Offset = "0x14E9A58", VA = "0x14E9A58")]
	private void SubmitScoreCallback(bool succes, int retries)
	{
	}

	[Token(Token = "0x6000728")]
	[Address(RVA = "0x14E9348", Offset = "0x14E9348", VA = "0x14E9348")]
	private void SetLevelPack(LevelDataContainerWithChallenge pack)
	{
	}

	[Token(Token = "0x6000729")]
	[Address(RVA = "0x14E9B24", Offset = "0x14E9B24", VA = "0x14E9B24")]
	public ImpossibleChallengeMenu()
	{
	}
}
