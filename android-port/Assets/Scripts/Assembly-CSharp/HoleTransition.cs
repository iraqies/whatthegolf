using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000B97")]
public class HoleTransition : MonoBehaviour
{
	[Token(Token = "0x2000B98")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x43B20", Offset = "0x43B20")]
	private sealed class _003C_003Ec__DisplayClass23_0
	{
		[Token(Token = "0x40040A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public HoleTransition _003C_003E4__this;

		[Token(Token = "0x40040A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float startTimescale;

		[Token(Token = "0x60037FB")]
		[Address(RVA = "0x17BE040", Offset = "0x17BE040", VA = "0x17BE040")]
		public _003C_003Ec__DisplayClass23_0()
		{
		}

		[Token(Token = "0x60037FC")]
		[Address(RVA = "0x17BE048", Offset = "0x17BE048", VA = "0x17BE048")]
		internal void _003CStartHole_003Eb__0(float t)
		{
		}

		[Token(Token = "0x60037FD")]
		[Address(RVA = "0x17BE0C4", Offset = "0x17BE0C4", VA = "0x17BE0C4")]
		internal void _003CStartHole_003Eb__1(float t)
		{
		}
	}

	[Token(Token = "0x2000B99")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x43B30", Offset = "0x43B30")]
	private sealed class _003CStartHole_003Ed__23 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40040A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x40040A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x40040A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public HoleTransition _003C_003E4__this;

		[Token(Token = "0x40040A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private _003C_003Ec__DisplayClass23_0 _003C_003E8__1;

		[Token(Token = "0x170005DD")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6003801")]
			[Address(RVA = "0x17BE9E4", Offset = "0x17BE9E4", VA = "0x17BE9E4", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x170005DE")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6003803")]
			[Address(RVA = "0x17BEA2C", Offset = "0x17BEA2C", VA = "0x17BEA2C", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x60037FE")]
		[Address(RVA = "0x17BE530", Offset = "0x17BE530", VA = "0x17BE530")]
		[DebuggerHidden]
		public _003CStartHole_003Ed__23(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x60037FF")]
		[Address(RVA = "0x17BE55C", Offset = "0x17BE55C", VA = "0x17BE55C", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6003800")]
		[Address(RVA = "0x17BE560", Offset = "0x17BE560", VA = "0x17BE560", Slot = "6")]
		private bool MoveNext()
		{
			return default;
		}

		[Token(Token = "0x6003801")]
		[Address(RVA = "0x17BE9E4", Offset = "0x17BE9E4", VA = "0x17BE9E4", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x6003802")]
		[Address(RVA = "0x17BE9EC", Offset = "0x17BE9EC", VA = "0x17BE9EC", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}

		[Token(Token = "0x6003803")]
		[Address(RVA = "0x17BEA2C", Offset = "0x17BEA2C", VA = "0x17BEA2C", Slot = "7")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}
	}

	[Token(Token = "0x2000B9A")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x43B40", Offset = "0x43B40")]
	private sealed class _003C_003Ec__DisplayClass24_0
	{
		[Token(Token = "0x40040A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public HoleTransition _003C_003E4__this;

		[Token(Token = "0x40040AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Color transparent;

		[Token(Token = "0x6003804")]
		[Address(RVA = "0x17BE104", Offset = "0x17BE104", VA = "0x17BE104")]
		public _003C_003Ec__DisplayClass24_0()
		{
		}

		[Token(Token = "0x6003805")]
		[Address(RVA = "0x17BE10C", Offset = "0x17BE10C", VA = "0x17BE10C")]
		internal void _003CEndHole_003Eb__0(float t)
		{
		}

		[Token(Token = "0x6003806")]
		[Address(RVA = "0x17BE148", Offset = "0x17BE148", VA = "0x17BE148")]
		internal void _003CEndHole_003Eb__1(float t)
		{
		}
	}

	[Token(Token = "0x2000B9B")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x43B50", Offset = "0x43B50")]
	private sealed class _003CEndHole_003Ed__24 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40040AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x40040AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x40040AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public HoleTransition _003C_003E4__this;

		[Token(Token = "0x40040AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private _003C_003Ec__DisplayClass24_0 _003C_003E8__1;

		[Token(Token = "0x40040AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Action onDone;

		[Token(Token = "0x170005DF")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x600380A")]
			[Address(RVA = "0x17BE4E0", Offset = "0x17BE4E0", VA = "0x17BE4E0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x170005E0")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x600380C")]
			[Address(RVA = "0x17BE528", Offset = "0x17BE528", VA = "0x17BE528", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x6003807")]
		[Address(RVA = "0x17BE1A4", Offset = "0x17BE1A4", VA = "0x17BE1A4")]
		[DebuggerHidden]
		public _003CEndHole_003Ed__24(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6003808")]
		[Address(RVA = "0x17BE1D0", Offset = "0x17BE1D0", VA = "0x17BE1D0", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6003809")]
		[Address(RVA = "0x17BE1D4", Offset = "0x17BE1D4", VA = "0x17BE1D4", Slot = "6")]
		private bool MoveNext()
		{
			return default;
		}

		[Token(Token = "0x600380A")]
		[Address(RVA = "0x17BE4E0", Offset = "0x17BE4E0", VA = "0x17BE4E0", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x600380B")]
		[Address(RVA = "0x17BE4E8", Offset = "0x17BE4E8", VA = "0x17BE4E8", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}

		[Token(Token = "0x600380C")]
		[Address(RVA = "0x17BE528", Offset = "0x17BE528", VA = "0x17BE528", Slot = "7")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}
	}

	[Token(Token = "0x400408E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Transform start;

	[Token(Token = "0x400408F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public SpriteRenderer circle;

	[Token(Token = "0x4004090")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public SpriteRenderer circleEnd;

	[Token(Token = "0x4004091")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public SpriteRenderer fullCircle;

	[Token(Token = "0x4004092")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public Color dark;

	[Token(Token = "0x4004093")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public Color bright;

	[Token(Token = "0x4004094")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public GameObject fullScreenUIBlocker;

	[Token(Token = "0x4004095")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private List<SpriteRenderer> circles;

	[Token(Token = "0x4004096")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	private List<SpriteRenderer> circlesPool;

	[Token(Token = "0x4004097")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	private List<SpriteRenderer> allPool;

	[Token(Token = "0x4004098")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	private List<float> circleTimes;

	[Token(Token = "0x4004099")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	private float timescale;

	[Token(Token = "0x400409A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	private SpriteRenderer endCircle;

	[Token(Token = "0x400409B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	private SpriteRenderer fullCircleEnd;

	[Token(Token = "0x400409C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	private float nextCircleSpawn;

	[Token(Token = "0x400409D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
	private int sortingOrder;

	[Token(Token = "0x400409E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	private bool isSpawning;

	[Token(Token = "0x400409F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
	private float endTimer;

	[Token(Token = "0x40040A0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	private Vector3 endCircleScale;

	[Token(Token = "0x40040A1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
	private WaitForSeconds shortwait;

	[Token(Token = "0x40040A2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
	private WaitForSeconds longwait;

	[Token(Token = "0x60037F6")]
	[Address(RVA = "0x14D15E4", Offset = "0x14D15E4", VA = "0x14D15E4")]
	private void Start()
	{
	}

	[Token(Token = "0x60037F7")]
	[Address(RVA = "0x14D1918", Offset = "0x14D1918", VA = "0x14D1918")]
	private void Update()
	{
	}

	[Token(Token = "0x60037F8")]
	[Address(RVA = "0x14D2448", Offset = "0x14D2448", VA = "0x14D2448")]
	public IEnumerator StartHole()
	{
		return null;
	}

	[Token(Token = "0x60037F9")]
	[Address(RVA = "0x14D24BC", Offset = "0x14D24BC", VA = "0x14D24BC")]
	public IEnumerator EndHole([Optional] Action onDone)
	{
		return null;
	}

	[Token(Token = "0x60037FA")]
	[Address(RVA = "0x14D2538", Offset = "0x14D2538", VA = "0x14D2538")]
	public HoleTransition()
	{
	}
}
