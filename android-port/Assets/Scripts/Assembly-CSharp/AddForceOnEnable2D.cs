using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000AF1")]
public class AddForceOnEnable2D : MonoBehaviour
{
	[Token(Token = "0x2000AF2")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x433C8", Offset = "0x433C8")]
	private sealed class _003CPopToast_003Ed__9 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4003CF9")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x4003CFA")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x4003CFB")]
		[FieldOffset(Offset = "0x20")]
		public AddForceOnEnable2D _003C_003E4__this;

		[Token(Token = "0x17000560")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6003438")]
			[Address(RVA = "0x1768E08", Offset = "0x1768E08", VA = "0x1768E08", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x17000561")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x600343A")]
			[Address(RVA = "0x1768E50", Offset = "0x1768E50", VA = "0x1768E50", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x6003435")]
		[Address(RVA = "0x1768C38", Offset = "0x1768C38", VA = "0x1768C38")]
		[DebuggerHidden]
		public _003CPopToast_003Ed__9(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6003436")]
		[Address(RVA = "0x1768C64", Offset = "0x1768C64", VA = "0x1768C64", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6003437")]
		[Address(RVA = "0x1768C68", Offset = "0x1768C68", VA = "0x1768C68", Slot = "6")]
		private bool MoveNext()
		{
			return default;
		}

		[Token(Token = "0x6003438")]
		[Address(RVA = "0x1768E08", Offset = "0x1768E08", VA = "0x1768E08", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x6003439")]
		[Address(RVA = "0x1768E10", Offset = "0x1768E10", VA = "0x1768E10", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}

		[Token(Token = "0x600343A")]
		[Address(RVA = "0x1768E50", Offset = "0x1768E50", VA = "0x1768E50", Slot = "7")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}
	}

	[Token(Token = "0x4003CF2")]
	[FieldOffset(Offset = "0x18")]
	public Rigidbody2D rigid;

	[Token(Token = "0x4003CF3")]
	[FieldOffset(Offset = "0x20")]
	public List<AudioClip> clips;

	[Token(Token = "0x4003CF4")]
	[FieldOffset(Offset = "0x28")]
	public float Delay;

	[Token(Token = "0x4003CF5")]
	[FieldOffset(Offset = "0x2C")]
	public Vector3 Force;

	[Token(Token = "0x4003CF6")]
	[FieldOffset(Offset = "0x38")]
	public float Torque;

	[Token(Token = "0x4003CF7")]
	[FieldOffset(Offset = "0x3C")]
	private Vector3 position;

	[Token(Token = "0x4003CF8")]
	[FieldOffset(Offset = "0x48")]
	private Quaternion rotation;

	[Token(Token = "0x6003431")]
	[Address(RVA = "0x1407410", Offset = "0x1407410", VA = "0x1407410")]
	private void Awake()
	{
	}

	[Token(Token = "0x6003432")]
	[Address(RVA = "0x140746C", Offset = "0x140746C", VA = "0x140746C")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x6003433")]
	[Address(RVA = "0x1407558", Offset = "0x1407558", VA = "0x1407558")]
	private IEnumerator PopToast()
	{
		return null;
	}

	[Token(Token = "0x6003434")]
	[Address(RVA = "0x14075CC", Offset = "0x14075CC", VA = "0x14075CC")]
	public AddForceOnEnable2D()
	{
	}
}
