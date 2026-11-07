using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Events;

[Token(Token = "0x2000A2F")]
public class PersistantObjects : MonoBehaviour
{
	[Serializable]
	[Token(Token = "0x2000A30")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x42AF8", Offset = "0x42AF8")]
	private sealed class _003C_003Ec
	{
		[Token(Token = "0x4003850")]
		[FieldOffset(Offset = "0x0")]
		public static readonly _003C_003Ec _003C_003E9;

		[Token(Token = "0x4003851")]
		[FieldOffset(Offset = "0x8")]
		public static Func<OverworldGoal, bool> _003C_003E9__4_0;

		[Token(Token = "0x6003085")]
		[Address(RVA = "0x18238B0", Offset = "0x18238B0", VA = "0x18238B0")]
		public _003C_003Ec()
		{
		}

		[Token(Token = "0x6003086")]
		[Address(RVA = "0x18238B8", Offset = "0x18238B8", VA = "0x18238B8")]
		internal bool _003CisEnabled_003Eb__4_0(OverworldGoal f)
		{
			return default;
		}
	}

	[Token(Token = "0x2000A31")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x42B08", Offset = "0x42B08")]
	private sealed class _003CLateTick_003Ed__6 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4003852")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x4003853")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x4003854")]
		[FieldOffset(Offset = "0x20")]
		public PersistantObjects _003C_003E4__this;

		[Token(Token = "0x17000506")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x600308A")]
			[Address(RVA = "0x18239F4", Offset = "0x18239F4", VA = "0x18239F4", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x17000507")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x600308C")]
			[Address(RVA = "0x1823A3C", Offset = "0x1823A3C", VA = "0x1823A3C", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x6003087")]
		[Address(RVA = "0x18238DC", Offset = "0x18238DC", VA = "0x18238DC")]
		[DebuggerHidden]
		public _003CLateTick_003Ed__6(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6003088")]
		[Address(RVA = "0x1823908", Offset = "0x1823908", VA = "0x1823908", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6003089")]
		[Address(RVA = "0x182390C", Offset = "0x182390C", VA = "0x182390C", Slot = "6")]
		private bool MoveNext()
		{
			return default;
		}

		[Token(Token = "0x600308A")]
		[Address(RVA = "0x18239F4", Offset = "0x18239F4", VA = "0x18239F4", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x600308B")]
		[Address(RVA = "0x18239FC", Offset = "0x18239FC", VA = "0x18239FC", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}

		[Token(Token = "0x600308C")]
		[Address(RVA = "0x1823A3C", Offset = "0x1823A3C", VA = "0x1823A3C", Slot = "7")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}
	}

	[Token(Token = "0x400384C")]
	[FieldOffset(Offset = "0x18")]
	public List<OverworldGoal> flags;

	[Token(Token = "0x400384D")]
	[FieldOffset(Offset = "0x20")]
	public OverworldMainButton button;

	[Token(Token = "0x400384E")]
	[FieldOffset(Offset = "0x28")]
	public OverworldButton2D button2d;

	[Token(Token = "0x400384F")]
	[FieldOffset(Offset = "0x30")]
	public UnityEvent onEnabled;

	[Token(Token = "0x6003080")]
	[Address(RVA = "0x15DEA00", Offset = "0x15DEA00", VA = "0x15DEA00")]
	private bool isEnabled()
	{
		return default;
	}

	[Token(Token = "0x6003081")]
	[Address(RVA = "0x15DEBF4", Offset = "0x15DEBF4", VA = "0x15DEBF4")]
	private void Start()
	{
	}

	[Token(Token = "0x6003082")]
	[Address(RVA = "0x15DEC70", Offset = "0x15DEC70", VA = "0x15DEC70")]
	private IEnumerator LateTick()
	{
		return null;
	}

	[Token(Token = "0x6003083")]
	[Address(RVA = "0x15DECE4", Offset = "0x15DECE4", VA = "0x15DECE4")]
	public PersistantObjects()
	{
	}
}
