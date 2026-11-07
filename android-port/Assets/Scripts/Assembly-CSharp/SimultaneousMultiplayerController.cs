using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using CameraStack;
using Core;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x200014A")]
public class SimultaneousMultiplayerController : MonoBehaviour
{
	[Token(Token = "0x200014B")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3DC40", Offset = "0x3DC40")]
	private sealed class _003CStart_003Ed__4 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40005CF")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x40005D0")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x40005D1")]
		[FieldOffset(Offset = "0x20")]
		public SimultaneousMultiplayerController _003C_003E4__this;

		[Token(Token = "0x170000B7")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x600058F")]
			[Address(RVA = "0x184FAE4", Offset = "0x184FAE4", VA = "0x184FAE4", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x170000B8")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6000591")]
			[Address(RVA = "0x184FB2C", Offset = "0x184FB2C", VA = "0x184FB2C", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x600058C")]
		[Address(RVA = "0x184F1B4", Offset = "0x184F1B4", VA = "0x184F1B4")]
		[DebuggerHidden]
		public _003CStart_003Ed__4(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x600058D")]
		[Address(RVA = "0x184F1E0", Offset = "0x184F1E0", VA = "0x184F1E0", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x600058E")]
		[Address(RVA = "0x184F1E4", Offset = "0x184F1E4", VA = "0x184F1E4", Slot = "6")]
		private bool MoveNext()
		{
			return default;
		}

		[Token(Token = "0x600058F")]
		[Address(RVA = "0x184FAE4", Offset = "0x184FAE4", VA = "0x184FAE4", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x6000590")]
		[Address(RVA = "0x184FAEC", Offset = "0x184FAEC", VA = "0x184FAEC", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}

		[Token(Token = "0x6000591")]
		[Address(RVA = "0x184FB2C", Offset = "0x184FB2C", VA = "0x184FB2C", Slot = "7")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}
	}

	[Token(Token = "0x40005CB")]
	[FieldOffset(Offset = "0x18")]
	public List<GolfBallController> Players;

	[Token(Token = "0x40005CC")]
	[FieldOffset(Offset = "0x20")]
	public bool isSplitScreen;

	[Token(Token = "0x40005CD")]
	[FieldOffset(Offset = "0x28")]
	private List<CameraManager> cams;

	[Token(Token = "0x40005CE")]
	[FieldOffset(Offset = "0x30")]
	private StrokeCounter strokeCounter;

	[Token(Token = "0x6000588")]
	[Address(RVA = "0x16B2154", Offset = "0x16B2154", VA = "0x16B2154")]
	private IEnumerator Start()
	{
		return null;
	}

	[Token(Token = "0x6000589")]
	[Address(RVA = "0x16B21C8", Offset = "0x16B21C8", VA = "0x16B21C8")]
	private void OnGoal(string obj)
	{
	}

	[Token(Token = "0x600058A")]
	[Address(RVA = "0x16B2338", Offset = "0x16B2338", VA = "0x16B2338")]
	private void OnOnGoalProgress(int playerIndex, string message)
	{
	}

	[Token(Token = "0x600058B")]
	[Address(RVA = "0x16B24B0", Offset = "0x16B24B0", VA = "0x16B24B0")]
	public SimultaneousMultiplayerController()
	{
	}
}
