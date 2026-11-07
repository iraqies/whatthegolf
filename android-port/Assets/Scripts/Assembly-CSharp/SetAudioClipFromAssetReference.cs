using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.AddressableAssets;
using UnityEngine.ResourceManagement.AsyncOperations;

[Token(Token = "0x20003E2")]
public class SetAudioClipFromAssetReference : MonoBehaviour
{
	[Token(Token = "0x20003E3")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3F8C4", Offset = "0x3F8C4")]
	private sealed class _003CLoadAudioClip_003Ed__4 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4001535")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x4001536")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x4001537")]
		[FieldOffset(Offset = "0x20")]
		public SetAudioClipFromAssetReference _003C_003E4__this;

		[Token(Token = "0x1700021B")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6001246")]
			[Address(RVA = "0x1842B58", Offset = "0x1842B58", VA = "0x1842B58", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x1700021C")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6001248")]
			[Address(RVA = "0x1842BA0", Offset = "0x1842BA0", VA = "0x1842BA0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x6001243")]
		[Address(RVA = "0x184292C", Offset = "0x184292C", VA = "0x184292C")]
		[DebuggerHidden]
		public _003CLoadAudioClip_003Ed__4(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6001244")]
		[Address(RVA = "0x1842958", Offset = "0x1842958", VA = "0x1842958", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6001245")]
		[Address(RVA = "0x184295C", Offset = "0x184295C", VA = "0x184295C", Slot = "6")]
		private bool MoveNext()
		{
			return default;
		}

		[Token(Token = "0x6001246")]
		[Address(RVA = "0x1842B58", Offset = "0x1842B58", VA = "0x1842B58", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x6001247")]
		[Address(RVA = "0x1842B60", Offset = "0x1842B60", VA = "0x1842B60", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}

		[Token(Token = "0x6001248")]
		[Address(RVA = "0x1842BA0", Offset = "0x1842BA0", VA = "0x1842BA0", Slot = "7")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}
	}

	[Token(Token = "0x4001532")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	private AudioSource audioSource;

	[Token(Token = "0x4001533")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private AssetReference audioClipAssetReference;

	[Token(Token = "0x4001534")]
	[FieldOffset(Offset = "0x28")]
	private AsyncOperationHandle<AudioClip> asyncOperationHandle;

	[Token(Token = "0x600123F")]
	[Address(RVA = "0x168BA78", Offset = "0x168BA78", VA = "0x168BA78")]
	private void Awake()
	{
	}

	[Token(Token = "0x6001240")]
	[Address(RVA = "0x168BAF4", Offset = "0x168BAF4", VA = "0x168BAF4")]
	private IEnumerator LoadAudioClip()
	{
		return null;
	}

	[Token(Token = "0x6001241")]
	[Address(RVA = "0x168BB68", Offset = "0x168BB68", VA = "0x168BB68")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x6001242")]
	[Address(RVA = "0x168BC08", Offset = "0x168BC08", VA = "0x168BC08")]
	public SetAudioClipFromAssetReference()
	{
	}
}
