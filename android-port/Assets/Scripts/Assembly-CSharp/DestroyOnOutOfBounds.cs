using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000337")]
public class DestroyOnOutOfBounds : MonoBehaviour
{
	[Token(Token = "0x2000338")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3F070", Offset = "0x3F070")]
	private sealed class _003CDestroyCR_003Ed__7 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40011D2")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x40011D3")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x40011D4")]
		[FieldOffset(Offset = "0x20")]
		public DestroyOnOutOfBounds _003C_003E4__this;

		[Token(Token = "0x170001C2")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6000EDD")]
			[Address(RVA = "0x179BA24", Offset = "0x179BA24", VA = "0x179BA24", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x170001C3")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6000EDF")]
			[Address(RVA = "0x179BA6C", Offset = "0x179BA6C", VA = "0x179BA6C", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x6000EDA")]
		[Address(RVA = "0x179B934", Offset = "0x179B934", VA = "0x179B934")]
		[DebuggerHidden]
		public _003CDestroyCR_003Ed__7(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6000EDB")]
		[Address(RVA = "0x179B960", Offset = "0x179B960", VA = "0x179B960", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6000EDC")]
		[Address(RVA = "0x179B964", Offset = "0x179B964", VA = "0x179B964", Slot = "6")]
		private bool MoveNext()
		{
			return default;
		}

		[Token(Token = "0x6000EDD")]
		[Address(RVA = "0x179BA24", Offset = "0x179BA24", VA = "0x179BA24", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x6000EDE")]
		[Address(RVA = "0x179BA2C", Offset = "0x179BA2C", VA = "0x179BA2C", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}

		[Token(Token = "0x6000EDF")]
		[Address(RVA = "0x179BA6C", Offset = "0x179BA6C", VA = "0x179BA6C", Slot = "7")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}
	}

	[Token(Token = "0x40011CE")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	private GameObject ToDestroy;

	[Token(Token = "0x40011CF")]
	[FieldOffset(Offset = "0x20")]
	public float DestroyAfter;

	[Token(Token = "0x40011D0")]
	[FieldOffset(Offset = "0x28")]
	public Action OnBeforeDestroy;

	[Token(Token = "0x40011D1")]
	[FieldOffset(Offset = "0x30")]
	private bool MarkedForDestroy;

	[Token(Token = "0x6000ED3")]
	[Address(RVA = "0x18DB3D4", Offset = "0x18DB3D4", VA = "0x18DB3D4")]
	public void SetObjectToDestroy(GameObject g)
	{
	}

	[Token(Token = "0x6000ED4")]
	[Address(RVA = "0x18DB3DC", Offset = "0x18DB3DC", VA = "0x18DB3DC")]
	private void OnCollisionEnter(Collision collision)
	{
	}

	[Token(Token = "0x6000ED5")]
	[Address(RVA = "0x18DB4D0", Offset = "0x18DB4D0", VA = "0x18DB4D0")]
	private void DestroyNowOrLater()
	{
	}

	[Token(Token = "0x6000ED6")]
	[Address(RVA = "0x18DB5A4", Offset = "0x18DB5A4", VA = "0x18DB5A4")]
	private IEnumerator DestroyCR()
	{
		return null;
	}

	[Token(Token = "0x6000ED7")]
	[Address(RVA = "0x18DB618", Offset = "0x18DB618", VA = "0x18DB618")]
	private void DestroyGO()
	{
	}

	[Token(Token = "0x6000ED8")]
	[Address(RVA = "0x18DB710", Offset = "0x18DB710", VA = "0x18DB710")]
	private void OnTriggerEnter(Collider other)
	{
	}

	[Token(Token = "0x6000ED9")]
	[Address(RVA = "0x18DB804", Offset = "0x18DB804", VA = "0x18DB804")]
	public DestroyOnOutOfBounds()
	{
	}
}
