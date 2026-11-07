using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Core;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x200013A")]
public class MultiplayerScoreBoard : MonoBehaviour
{
	[Token(Token = "0x200013B")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3DBF0", Offset = "0x3DBF0")]
	private sealed class _003C_003Ec__DisplayClass14_0
	{
		[Token(Token = "0x4000583")]
		[FieldOffset(Offset = "0x10")]
		public int i1;

		[Token(Token = "0x4000584")]
		[FieldOffset(Offset = "0x18")]
		public MultiplayerScoreBoard _003C_003E4__this;

		[Token(Token = "0x600055D")]
		[Address(RVA = "0x18034BC", Offset = "0x18034BC", VA = "0x18034BC")]
		public _003C_003Ec__DisplayClass14_0()
		{
		}

		[Token(Token = "0x600055E")]
		[Address(RVA = "0x18034C4", Offset = "0x18034C4", VA = "0x18034C4")]
		internal void _003CShowScores_003Eb__0(float t)
		{
		}
	}

	[Token(Token = "0x200013C")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3DC00", Offset = "0x3DC00")]
	private sealed class _003C_003Ec__DisplayClass14_1
	{
		[Token(Token = "0x4000585")]
		[FieldOffset(Offset = "0x10")]
		public int j1;

		[Token(Token = "0x4000586")]
		[FieldOffset(Offset = "0x18")]
		public MultiplayerScoreBoard _003C_003E4__this;

		[Token(Token = "0x600055F")]
		[Address(RVA = "0x18035BC", Offset = "0x18035BC", VA = "0x18035BC")]
		public _003C_003Ec__DisplayClass14_1()
		{
		}

		[Token(Token = "0x6000560")]
		[Address(RVA = "0x18035C4", Offset = "0x18035C4", VA = "0x18035C4")]
		internal void _003CShowScores_003Eb__1(float t)
		{
		}
	}

	[Token(Token = "0x200013D")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3DC10", Offset = "0x3DC10")]
	private sealed class _003C_003Ec__DisplayClass14_2
	{
		[Token(Token = "0x4000587")]
		[FieldOffset(Offset = "0x10")]
		public int i1;

		[Token(Token = "0x4000588")]
		[FieldOffset(Offset = "0x18")]
		public MultiplayerScoreBoard _003C_003E4__this;

		[Token(Token = "0x6000561")]
		[Address(RVA = "0x1803718", Offset = "0x1803718", VA = "0x1803718")]
		public _003C_003Ec__DisplayClass14_2()
		{
		}

		[Token(Token = "0x6000562")]
		[Address(RVA = "0x1803720", Offset = "0x1803720", VA = "0x1803720")]
		internal void _003CShowScores_003Eb__2(float t)
		{
		}
	}

	[Token(Token = "0x200013E")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3DC20", Offset = "0x3DC20")]
	private sealed class _003CShowScores_003Ed__14 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000589")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x400058A")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x400058B")]
		[FieldOffset(Offset = "0x20")]
		public MultiplayerScoreBoard _003C_003E4__this;

		[Token(Token = "0x400058C")]
		[FieldOffset(Offset = "0x28")]
		private int _003Ci_003E5__2;

		[Token(Token = "0x170000B3")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6000566")]
			[Address(RVA = "0x1803DC8", Offset = "0x1803DC8", VA = "0x1803DC8", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x170000B4")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6000568")]
			[Address(RVA = "0x1803E10", Offset = "0x1803E10", VA = "0x1803E10", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x6000563")]
		[Address(RVA = "0x1803818", Offset = "0x1803818", VA = "0x1803818")]
		[DebuggerHidden]
		public _003CShowScores_003Ed__14(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6000564")]
		[Address(RVA = "0x1803844", Offset = "0x1803844", VA = "0x1803844", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6000565")]
		[Address(RVA = "0x1803848", Offset = "0x1803848", VA = "0x1803848", Slot = "6")]
		private bool MoveNext()
		{
			return default;
		}

		[Token(Token = "0x6000566")]
		[Address(RVA = "0x1803DC8", Offset = "0x1803DC8", VA = "0x1803DC8", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x6000567")]
		[Address(RVA = "0x1803DD0", Offset = "0x1803DD0", VA = "0x1803DD0", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}

		[Token(Token = "0x6000568")]
		[Address(RVA = "0x1803E10", Offset = "0x1803E10", VA = "0x1803E10", Slot = "7")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}
	}

	[Token(Token = "0x400057C")]
	[FieldOffset(Offset = "0x18")]
	public MultiplayerScoreBoardEntry EntryTemplate;

	[Token(Token = "0x400057D")]
	[FieldOffset(Offset = "0x20")]
	public Canvas Canvas;

	[Token(Token = "0x400057E")]
	[FieldOffset(Offset = "0x28")]
	private MultiplayerScoreBoardEntry[] entries;

	[Token(Token = "0x400057F")]
	private const int MAXPLAYERS = 4;

	[Token(Token = "0x4000580")]
	[FieldOffset(Offset = "0x30")]
	private Dictionary<int, int> totalScores;

	[Token(Token = "0x4000581")]
	[FieldOffset(Offset = "0x38")]
	private Dictionary<int, int> scoresThisLevel;

	[Token(Token = "0x4000582")]
	[FieldOffset(Offset = "0x40")]
	public bool LastLevelCompleted;

	[Token(Token = "0x6000554")]
	[Address(RVA = "0x15836C4", Offset = "0x15836C4", VA = "0x15836C4")]
	private void Start()
	{
	}

	[Token(Token = "0x6000555")]
	[Address(RVA = "0x1583A30", Offset = "0x1583A30", VA = "0x1583A30")]
	private void OnLastLevelCompleted()
	{
	}

	[Token(Token = "0x6000556")]
	[Address(RVA = "0x1583A3C", Offset = "0x1583A3C", VA = "0x1583A3C")]
	private void OnReturnToMainMenuExit()
	{
	}

	[Token(Token = "0x6000557")]
	[Address(RVA = "0x1583E50", Offset = "0x1583E50", VA = "0x1583E50")]
	private void OnLevelWillUnload()
	{
	}

	[Token(Token = "0x6000558")]
	[Address(RVA = "0x1584038", Offset = "0x1584038", VA = "0x1584038")]
	private void OnLevelLoaded(LevelData levelData)
	{
	}

	[Token(Token = "0x6000559")]
	[Address(RVA = "0x1584358", Offset = "0x1584358", VA = "0x1584358")]
	private void OnGoal(Level.CompletedState s)
	{
	}

	[Token(Token = "0x600055A")]
	[Address(RVA = "0x1584724", Offset = "0x1584724", VA = "0x1584724")]
	private void OnGoalProgress(int playerIndex, string s)
	{
	}

	[Token(Token = "0x600055B")]
	[Address(RVA = "0x15846B0", Offset = "0x15846B0", VA = "0x15846B0")]
	private IEnumerator ShowScores()
	{
		return null;
	}

	[Token(Token = "0x600055C")]
	[Address(RVA = "0x15847C8", Offset = "0x15847C8", VA = "0x15847C8")]
	public MultiplayerScoreBoard()
	{
	}
}
