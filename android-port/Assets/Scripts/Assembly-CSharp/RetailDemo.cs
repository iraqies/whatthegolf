using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Core;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000019")]
public class RetailDemo : MonoBehaviour
{
	[Token(Token = "0x200001A")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3D250", Offset = "0x3D250")]
	private sealed class _003C_003Ec__DisplayClass2_0
	{
		[Token(Token = "0x4000059")]
		[FieldOffset(Offset = "0x10")]
		public int i;

		[Token(Token = "0x6000068")]
		[Address(RVA = "0x183433C", Offset = "0x183433C", VA = "0x183433C")]
		public _003C_003Ec__DisplayClass2_0()
		{
		}

		[Token(Token = "0x6000069")]
		[Address(RVA = "0x1834344", Offset = "0x1834344", VA = "0x1834344")]
		internal void _003CPlayLevels_003Eb__1()
		{
		}
	}

	[Serializable]
	[Token(Token = "0x200001B")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3D260", Offset = "0x3D260")]
	private sealed class _003C_003Ec
	{
		[Token(Token = "0x400005A")]
		[FieldOffset(Offset = "0x0")]
		public static readonly _003C_003Ec _003C_003E9;

		[Token(Token = "0x400005B")]
		[FieldOffset(Offset = "0x8")]
		public static Action<Level.CompletedState> _003C_003E9__2_0;

		[Token(Token = "0x400005C")]
		[FieldOffset(Offset = "0x10")]
		public static Action<bool> _003C_003E9__2_2;

		[Token(Token = "0x400005D")]
		[FieldOffset(Offset = "0x18")]
		public static Action _003C_003E9__4_0;

		[Token(Token = "0x600006B")]
		[Address(RVA = "0x1834300", Offset = "0x1834300", VA = "0x1834300")]
		public _003C_003Ec()
		{
		}

		[Token(Token = "0x600006C")]
		[Address(RVA = "0x1834308", Offset = "0x1834308", VA = "0x1834308")]
		internal void _003CPlayLevels_003Eb__2_0(Level.CompletedState s)
		{
		}

		[Token(Token = "0x600006D")]
		[Address(RVA = "0x183430C", Offset = "0x183430C", VA = "0x183430C")]
		internal void _003CPlayLevels_003Eb__2_2(bool isCompleted)
		{
		}

		[Token(Token = "0x600006E")]
		[Address(RVA = "0x1834310", Offset = "0x1834310", VA = "0x1834310")]
		internal void _003CdelayedStartMusic_003Eb__4_0()
		{
		}
	}

	[Token(Token = "0x200001C")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3D270", Offset = "0x3D270")]
	private sealed class _003CPlayLevels_003Ed__2 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400005E")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x400005F")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x4000060")]
		[FieldOffset(Offset = "0x20")]
		public RetailDemo _003C_003E4__this;

		[Token(Token = "0x4000061")]
		[FieldOffset(Offset = "0x28")]
		private _003C_003Ec__DisplayClass2_0 _003C_003E8__1;

		[Token(Token = "0x4000062")]
		[FieldOffset(Offset = "0x30")]
		private List<LevelData> _003ClevelsToPlay_003E5__2;

		[Token(Token = "0x17000013")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6000072")]
			[Address(RVA = "0x1834818", Offset = "0x1834818", VA = "0x1834818", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x17000014")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6000074")]
			[Address(RVA = "0x1834860", Offset = "0x1834860", VA = "0x1834860", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x600006F")]
		[Address(RVA = "0x1834350", Offset = "0x1834350", VA = "0x1834350")]
		[DebuggerHidden]
		public _003CPlayLevels_003Ed__2(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6000070")]
		[Address(RVA = "0x183437C", Offset = "0x183437C", VA = "0x183437C", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6000071")]
		[Address(RVA = "0x1834380", Offset = "0x1834380", VA = "0x1834380", Slot = "6")]
		private bool MoveNext()
		{
			return default;
		}

		[Token(Token = "0x6000072")]
		[Address(RVA = "0x1834818", Offset = "0x1834818", VA = "0x1834818", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x6000073")]
		[Address(RVA = "0x1834820", Offset = "0x1834820", VA = "0x1834820", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}

		[Token(Token = "0x6000074")]
		[Address(RVA = "0x1834860", Offset = "0x1834860", VA = "0x1834860", Slot = "7")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}
	}

	[Token(Token = "0x200001D")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3D280", Offset = "0x3D280")]
	private sealed class _003CdelayedStartMusic_003Ed__4 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000063")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x4000064")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x17000015")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6000078")]
			[Address(RVA = "0x1834A24", Offset = "0x1834A24", VA = "0x1834A24", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x17000016")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x600007A")]
			[Address(RVA = "0x1834A6C", Offset = "0x1834A6C", VA = "0x1834A6C", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x6000075")]
		[Address(RVA = "0x1834868", Offset = "0x1834868", VA = "0x1834868")]
		[DebuggerHidden]
		public _003CdelayedStartMusic_003Ed__4(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6000076")]
		[Address(RVA = "0x1834894", Offset = "0x1834894", VA = "0x1834894", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6000077")]
		[Address(RVA = "0x1834898", Offset = "0x1834898", VA = "0x1834898", Slot = "6")]
		private bool MoveNext()
		{
			return default;
		}

		[Token(Token = "0x6000078")]
		[Address(RVA = "0x1834A24", Offset = "0x1834A24", VA = "0x1834A24", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x6000079")]
		[Address(RVA = "0x1834A2C", Offset = "0x1834A2C", VA = "0x1834A2C", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}

		[Token(Token = "0x600007A")]
		[Address(RVA = "0x1834A6C", Offset = "0x1834A6C", VA = "0x1834A6C", Slot = "7")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}
	}

	[Token(Token = "0x4000058")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	private LevelDataContainer levels;

	[Token(Token = "0x6000063")]
	[Address(RVA = "0x164D8A4", Offset = "0x164D8A4", VA = "0x164D8A4")]
	private void Start()
	{
	}

	[Token(Token = "0x6000064")]
	[Address(RVA = "0x164D920", Offset = "0x164D920", VA = "0x164D920")]
	private IEnumerator PlayLevels()
	{
		return null;
	}

	[Token(Token = "0x6000065")]
	[Address(RVA = "0x164D994", Offset = "0x164D994", VA = "0x164D994")]
	public void Restart()
	{
	}

	[Token(Token = "0x6000066")]
	[Address(RVA = "0x164D9B8", Offset = "0x164D9B8", VA = "0x164D9B8")]
	private IEnumerator delayedStartMusic()
	{
		return null;
	}

	[Token(Token = "0x6000067")]
	[Address(RVA = "0x164DA14", Offset = "0x164DA14", VA = "0x164DA14")]
	public RetailDemo()
	{
	}
}
