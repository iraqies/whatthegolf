using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000CFF")]
public class FoodSpawner : MonoBehaviour
{
	[Token(Token = "0x2000D00")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x44638", Offset = "0x44638")]
	private sealed class _003CFoodEjectionRoutine_003Ed__10 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400469F")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x40046A0")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x40046A1")]
		[FieldOffset(Offset = "0x20")]
		public FoodSpawner _003C_003E4__this;

		[Token(Token = "0x40046A2")]
		[FieldOffset(Offset = "0x28")]
		private int _003Ci_003E5__2;

		[Token(Token = "0x17000649")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6003D6D")]
			[Address(RVA = "0x17A97CC", Offset = "0x17A97CC", VA = "0x17A97CC", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x1700064A")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6003D6F")]
			[Address(RVA = "0x17A9814", Offset = "0x17A9814", VA = "0x17A9814", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x6003D6A")]
		[Address(RVA = "0x17A9668", Offset = "0x17A9668", VA = "0x17A9668")]
		[DebuggerHidden]
		public _003CFoodEjectionRoutine_003Ed__10(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6003D6B")]
		[Address(RVA = "0x17A9694", Offset = "0x17A9694", VA = "0x17A9694", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6003D6C")]
		[Address(RVA = "0x17A9698", Offset = "0x17A9698", VA = "0x17A9698", Slot = "6")]
		private bool MoveNext()
		{
			return default;
		}

		[Token(Token = "0x6003D6D")]
		[Address(RVA = "0x17A97CC", Offset = "0x17A97CC", VA = "0x17A97CC", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x6003D6E")]
		[Address(RVA = "0x17A97D4", Offset = "0x17A97D4", VA = "0x17A97D4", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}

		[Token(Token = "0x6003D6F")]
		[Address(RVA = "0x17A9814", Offset = "0x17A9814", VA = "0x17A9814", Slot = "7")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}
	}

	[Token(Token = "0x4004696")]
	[FieldOffset(Offset = "0x18")]
	public GameObject[] EjectableFoodPrefabs;

	[Token(Token = "0x4004697")]
	[FieldOffset(Offset = "0x20")]
	public float EjectForce;

	[Token(Token = "0x4004698")]
	[FieldOffset(Offset = "0x24")]
	public float EjectForceAngular;

	[Token(Token = "0x4004699")]
	[FieldOffset(Offset = "0x28")]
	public int FoodEjectedPerHit;

	[Token(Token = "0x400469A")]
	[FieldOffset(Offset = "0x2C")]
	public float CooldownBetweenEachFood;

	[Token(Token = "0x400469B")]
	[FieldOffset(Offset = "0x30")]
	public float EjectCooldown;

	[Token(Token = "0x400469C")]
	[FieldOffset(Offset = "0x34")]
	private bool onCooldown;

	[Token(Token = "0x400469D")]
	[FieldOffset(Offset = "0x38")]
	public int FoodLeft;

	[Token(Token = "0x400469E")]
	[FieldOffset(Offset = "0x40")]
	public Transform FoodEjectPosition;

	[Token(Token = "0x6003D66")]
	[Address(RVA = "0x14715EC", Offset = "0x14715EC", VA = "0x14715EC")]
	private void OnCollisionEnter2D(Collision2D collision)
	{
	}

	[Token(Token = "0x6003D67")]
	[Address(RVA = "0x147178C", Offset = "0x147178C", VA = "0x147178C")]
	private IEnumerator FoodEjectionRoutine()
	{
		return null;
	}

	[Token(Token = "0x6003D68")]
	[Address(RVA = "0x1471800", Offset = "0x1471800", VA = "0x1471800")]
	private void EjectFood()
	{
	}

	[Token(Token = "0x6003D69")]
	[Address(RVA = "0x14719C8", Offset = "0x14719C8", VA = "0x14719C8")]
	public FoodSpawner()
	{
	}
}
