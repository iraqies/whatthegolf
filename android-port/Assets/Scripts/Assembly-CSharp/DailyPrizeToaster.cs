using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000EFA")]
public class DailyPrizeToaster : BaseDailyPrizeInteractions
{
	[Token(Token = "0x2000EFB")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x455C0", Offset = "0x455C0")]
	private sealed class _003CAddToastRoutine_003Ed__12 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40050F5")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x40050F6")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x40050F7")]
		[FieldOffset(Offset = "0x20")]
		public DailyPrizeToaster _003C_003E4__this;

		[Token(Token = "0x40050F8")]
		[FieldOffset(Offset = "0x28")]
		public Transform p;

		[Token(Token = "0x17000744")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x600460D")]
			[Address(RVA = "0x1799498", Offset = "0x1799498", VA = "0x1799498", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x17000745")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x600460F")]
			[Address(RVA = "0x17994E0", Offset = "0x17994E0", VA = "0x17994E0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x600460A")]
		[Address(RVA = "0x17992B4", Offset = "0x17992B4", VA = "0x17992B4")]
		[DebuggerHidden]
		public _003CAddToastRoutine_003Ed__12(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x600460B")]
		[Address(RVA = "0x17992E0", Offset = "0x17992E0", VA = "0x17992E0", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x600460C")]
		[Address(RVA = "0x17992E4", Offset = "0x17992E4", VA = "0x17992E4", Slot = "6")]
		private bool MoveNext()
		{
			return default;
		}

		[Token(Token = "0x600460D")]
		[Address(RVA = "0x1799498", Offset = "0x1799498", VA = "0x1799498", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x600460E")]
		[Address(RVA = "0x17994A0", Offset = "0x17994A0", VA = "0x17994A0", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}

		[Token(Token = "0x600460F")]
		[Address(RVA = "0x17994E0", Offset = "0x17994E0", VA = "0x17994E0", Slot = "7")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}
	}

	[Token(Token = "0x2000EFC")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x455D0", Offset = "0x455D0")]
	private sealed class _003C_003Ec__DisplayClass13_0
	{
		[Token(Token = "0x40050F9")]
		[FieldOffset(Offset = "0x10")]
		public DailyPrizeToaster _003C_003E4__this;

		[Token(Token = "0x40050FA")]
		[FieldOffset(Offset = "0x18")]
		public float mag;

		[Token(Token = "0x6004610")]
		[Address(RVA = "0x1799088", Offset = "0x1799088", VA = "0x1799088")]
		public _003C_003Ec__DisplayClass13_0()
		{
		}

		[Token(Token = "0x6004611")]
		[Address(RVA = "0x1799090", Offset = "0x1799090", VA = "0x1799090")]
		internal void _003CShootToastRoutine_003Eb__2(Rigidbody rb)
		{
		}

		[Token(Token = "0x6004612")]
		[Address(RVA = "0x17990FC", Offset = "0x17990FC", VA = "0x17990FC")]
		internal void _003CShootToastRoutine_003Eb__3(Rigidbody rb)
		{
		}

		[Token(Token = "0x6004613")]
		[Address(RVA = "0x179918C", Offset = "0x179918C", VA = "0x179918C")]
		internal void _003CShootToastRoutine_003Eb__4(Rigidbody rb)
		{
		}
	}

	[Serializable]
	[Token(Token = "0x2000EFD")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x455E0", Offset = "0x455E0")]
	private sealed class _003C_003Ec
	{
		[Token(Token = "0x40050FB")]
		[FieldOffset(Offset = "0x0")]
		public static readonly _003C_003Ec _003C_003E9;

		[Token(Token = "0x40050FC")]
		[FieldOffset(Offset = "0x8")]
		public static Action<Rigidbody> _003C_003E9__13_0;

		[Token(Token = "0x40050FD")]
		[FieldOffset(Offset = "0x10")]
		public static Action<Rigidbody> _003C_003E9__13_1;

		[Token(Token = "0x6004615")]
		[Address(RVA = "0x1798FC0", Offset = "0x1798FC0", VA = "0x1798FC0")]
		public _003C_003Ec()
		{
		}

		[Token(Token = "0x6004616")]
		[Address(RVA = "0x1798FC8", Offset = "0x1798FC8", VA = "0x1798FC8")]
		internal void _003CShootToastRoutine_003Eb__13_0(Rigidbody rb)
		{
		}

		[Token(Token = "0x6004617")]
		[Address(RVA = "0x1798FE8", Offset = "0x1798FE8", VA = "0x1798FE8")]
		internal void _003CShootToastRoutine_003Eb__13_1(Rigidbody rb)
		{
		}
	}

	[Token(Token = "0x2000EFE")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x455F0", Offset = "0x455F0")]
	private sealed class _003CShootToastRoutine_003Ed__13 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40050FE")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x40050FF")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x4005100")]
		[FieldOffset(Offset = "0x20")]
		public DailyPrizeToaster _003C_003E4__this;

		[Token(Token = "0x4005101")]
		[FieldOffset(Offset = "0x28")]
		public Vector3 b;

		[Token(Token = "0x4005102")]
		[FieldOffset(Offset = "0x38")]
		private _003C_003Ec__DisplayClass13_0 _003C_003E8__1;

		[Token(Token = "0x17000746")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x600461B")]
			[Address(RVA = "0x1799C6C", Offset = "0x1799C6C", VA = "0x1799C6C", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x17000747")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x600461D")]
			[Address(RVA = "0x1799CB4", Offset = "0x1799CB4", VA = "0x1799CB4", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x6004618")]
		[Address(RVA = "0x1799758", Offset = "0x1799758", VA = "0x1799758")]
		[DebuggerHidden]
		public _003CShootToastRoutine_003Ed__13(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6004619")]
		[Address(RVA = "0x1799784", Offset = "0x1799784", VA = "0x1799784", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x600461A")]
		[Address(RVA = "0x1799788", Offset = "0x1799788", VA = "0x1799788", Slot = "6")]
		private bool MoveNext()
		{
			return default;
		}

		[Token(Token = "0x600461B")]
		[Address(RVA = "0x1799C6C", Offset = "0x1799C6C", VA = "0x1799C6C", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x600461C")]
		[Address(RVA = "0x1799C74", Offset = "0x1799C74", VA = "0x1799C74", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}

		[Token(Token = "0x600461D")]
		[Address(RVA = "0x1799CB4", Offset = "0x1799CB4", VA = "0x1799CB4", Slot = "7")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}
	}

	[Token(Token = "0x2000EFF")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x45600", Offset = "0x45600")]
	private sealed class _003C_003Ec__DisplayClass14_0
	{
		[Token(Token = "0x4005103")]
		[FieldOffset(Offset = "0x10")]
		public GameObject g;

		[Token(Token = "0x600461E")]
		[Address(RVA = "0x17991DC", Offset = "0x17991DC", VA = "0x17991DC")]
		public _003C_003Ec__DisplayClass14_0()
		{
		}

		[Token(Token = "0x600461F")]
		[Address(RVA = "0x17991E4", Offset = "0x17991E4", VA = "0x17991E4")]
		internal void _003CDestroyAfter_003Eb__0(float t)
		{
		}
	}

	[Token(Token = "0x2000F00")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x45610", Offset = "0x45610")]
	private sealed class _003CDestroyAfter_003Ed__14 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4005104")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x4005105")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x4005106")]
		[FieldOffset(Offset = "0x20")]
		public GameObject g;

		[Token(Token = "0x4005107")]
		[FieldOffset(Offset = "0x28")]
		public DailyPrizeToaster _003C_003E4__this;

		[Token(Token = "0x4005108")]
		[FieldOffset(Offset = "0x30")]
		private _003C_003Ec__DisplayClass14_0 _003C_003E8__1;

		[Token(Token = "0x17000748")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6004623")]
			[Address(RVA = "0x1799708", Offset = "0x1799708", VA = "0x1799708", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x17000749")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6004625")]
			[Address(RVA = "0x1799750", Offset = "0x1799750", VA = "0x1799750", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x6004620")]
		[Address(RVA = "0x17994E8", Offset = "0x17994E8", VA = "0x17994E8")]
		[DebuggerHidden]
		public _003CDestroyAfter_003Ed__14(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6004621")]
		[Address(RVA = "0x1799514", Offset = "0x1799514", VA = "0x1799514", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6004622")]
		[Address(RVA = "0x1799518", Offset = "0x1799518", VA = "0x1799518", Slot = "6")]
		private bool MoveNext()
		{
			return default;
		}

		[Token(Token = "0x6004623")]
		[Address(RVA = "0x1799708", Offset = "0x1799708", VA = "0x1799708", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x6004624")]
		[Address(RVA = "0x1799710", Offset = "0x1799710", VA = "0x1799710", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}

		[Token(Token = "0x6004625")]
		[Address(RVA = "0x1799750", Offset = "0x1799750", VA = "0x1799750", Slot = "7")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}
	}

	[Token(Token = "0x40050EC")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	private GameObject ToastPrefab;

	[Token(Token = "0x40050ED")]
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	private Rigidbody ToasterBody;

	[Token(Token = "0x40050EE")]
	[FieldOffset(Offset = "0x38")]
	[SerializeField]
	private Vector3 up;

	[Token(Token = "0x40050EF")]
	[FieldOffset(Offset = "0x44")]
	[SerializeField]
	private float forceMultiplyer;

	[Token(Token = "0x40050F0")]
	[FieldOffset(Offset = "0x48")]
	[SerializeField]
	private List<Transform> ToastPositions;

	[Token(Token = "0x40050F1")]
	[FieldOffset(Offset = "0x50")]
	private List<Rigidbody> toasts;

	[Token(Token = "0x40050F2")]
	[FieldOffset(Offset = "0x58")]
	[SerializeField]
	private float rnTorque;

	[Token(Token = "0x40050F3")]
	[FieldOffset(Offset = "0x5C")]
	[SerializeField]
	private float minForce;

	[Token(Token = "0x40050F4")]
	[FieldOffset(Offset = "0x60")]
	private bool canShoot;

	[Token(Token = "0x60045FD")]
	[Address(RVA = "0x18D35E0", Offset = "0x18D35E0", VA = "0x18D35E0")]
	private void Start()
	{
	}

	[Token(Token = "0x60045FE")]
	[Address(RVA = "0x18D36D8", Offset = "0x18D36D8", VA = "0x18D36D8", Slot = "8")]
	public override void OnShootNotWrapped(Vector3 b)
	{
	}

	[Token(Token = "0x60045FF")]
	[Address(RVA = "0x18D38C0", Offset = "0x18D38C0", VA = "0x18D38C0")]
	private void AddToast(Transform p)
	{
	}

	[Token(Token = "0x6004600")]
	[Address(RVA = "0x18D3940", Offset = "0x18D3940", VA = "0x18D3940")]
	private IEnumerator AddToastRoutine(Transform p)
	{
		return null;
	}

	[Token(Token = "0x6004601")]
	[Address(RVA = "0x18D39B8", Offset = "0x18D39B8", VA = "0x18D39B8")]
	private IEnumerator ShootToastRoutine(Vector3 b)
	{
		return null;
	}

	[Token(Token = "0x6004602")]
	[Address(RVA = "0x18D3A50", Offset = "0x18D3A50", VA = "0x18D3A50")]
	private IEnumerator DestroyAfter(GameObject g)
	{
		return null;
	}

	[Token(Token = "0x6004603")]
	[Address(RVA = "0x18D35E4", Offset = "0x18D35E4", VA = "0x18D35E4")]
	private void ResetToasts()
	{
	}

	[Token(Token = "0x6004604")]
	[Address(RVA = "0x18D3AC8", Offset = "0x18D3AC8", VA = "0x18D3AC8")]
	private float Mag(Vector3 b)
	{
		return default;
	}

	[Token(Token = "0x6004605")]
	[Address(RVA = "0x18D3B10", Offset = "0x18D3B10", VA = "0x18D3B10")]
	private float rnV3(float r)
	{
		return default;
	}

	[Token(Token = "0x6004606")]
	[Address(RVA = "0x18D37FC", Offset = "0x18D37FC", VA = "0x18D37FC")]
	public void ShootToast(Vector3 b)
	{
	}

	[Token(Token = "0x6004607")]
	[Address(RVA = "0x18D3B20", Offset = "0x18D3B20", VA = "0x18D3B20")]
	private Vector3 Dir(Rigidbody r)
	{
		return default;
	}

	[Token(Token = "0x6004608")]
	[Address(RVA = "0x18D3B2C", Offset = "0x18D3B2C", VA = "0x18D3B2C")]
	public DailyPrizeToaster()
	{
	}

	[Token(Token = "0x6004609")]
	[Address(RVA = "0x18D3BC4", Offset = "0x18D3BC4", VA = "0x18D3BC4")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6E714", Offset = "0x6E714")]
	private void _003CResetToasts_003Eb__15_0(Transform p)
	{
	}
}
