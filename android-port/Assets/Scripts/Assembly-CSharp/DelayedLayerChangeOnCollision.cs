using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000226")]
public class DelayedLayerChangeOnCollision : MonoBehaviour
{
	[Token(Token = "0x2000227")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3E5D4", Offset = "0x3E5D4")]
	private sealed class _003CDelayedLayerChange_003Ed__6 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000AC9")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x4000ACA")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x4000ACB")]
		[FieldOffset(Offset = "0x20")]
		public DelayedLayerChangeOnCollision _003C_003E4__this;

		[Token(Token = "0x1700012B")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x600099C")]
			[Address(RVA = "0x179AF5C", Offset = "0x179AF5C", VA = "0x179AF5C", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x1700012C")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x600099E")]
			[Address(RVA = "0x179AFA4", Offset = "0x179AFA4", VA = "0x179AFA4", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x6000999")]
		[Address(RVA = "0x179AE5C", Offset = "0x179AE5C", VA = "0x179AE5C")]
		[DebuggerHidden]
		public _003CDelayedLayerChange_003Ed__6(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x600099A")]
		[Address(RVA = "0x179AE88", Offset = "0x179AE88", VA = "0x179AE88", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x600099B")]
		[Address(RVA = "0x179AE8C", Offset = "0x179AE8C", VA = "0x179AE8C", Slot = "6")]
		private bool MoveNext()
		{
			return default;
		}

		[Token(Token = "0x600099C")]
		[Address(RVA = "0x179AF5C", Offset = "0x179AF5C", VA = "0x179AF5C", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x600099D")]
		[Address(RVA = "0x179AF64", Offset = "0x179AF64", VA = "0x179AF64", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}

		[Token(Token = "0x600099E")]
		[Address(RVA = "0x179AFA4", Offset = "0x179AFA4", VA = "0x179AFA4", Slot = "7")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}
	}

	[Token(Token = "0x4000AC4")]
	[FieldOffset(Offset = "0x18")]
	public LayerMask ValidLayers;

	[Token(Token = "0x4000AC5")]
	[FieldOffset(Offset = "0x1C")]
	public int NewLayer;

	[Token(Token = "0x4000AC6")]
	[FieldOffset(Offset = "0x20")]
	public float delayInSeconds;

	[Token(Token = "0x4000AC7")]
	[FieldOffset(Offset = "0x24")]
	public Vector3 force;

	[Token(Token = "0x4000AC8")]
	[FieldOffset(Offset = "0x30")]
	private bool collided;

	[Token(Token = "0x6000996")]
	[Address(RVA = "0x18D93C0", Offset = "0x18D93C0", VA = "0x18D93C0")]
	private void OnCollisionEnter(Collision other)
	{
	}

	[Token(Token = "0x6000997")]
	[Address(RVA = "0x18D94F8", Offset = "0x18D94F8", VA = "0x18D94F8")]
	private IEnumerator DelayedLayerChange()
	{
		return null;
	}

	[Token(Token = "0x6000998")]
	[Address(RVA = "0x18D956C", Offset = "0x18D956C", VA = "0x18D956C")]
	public DelayedLayerChangeOnCollision()
	{
	}
}
