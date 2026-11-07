using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Audio;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.AddressableAssets;
using UnityEngine.ResourceManagement.AsyncOperations;

[Token(Token = "0x20003E0")]
public class SetAmbientAudioClipFromAssetReference : MonoBehaviour
{
	[Token(Token = "0x20003E1")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3F8B4", Offset = "0x3F8B4")]
	private sealed class _003CLoadAudioClip_003Ed__4 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400152F")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x4001530")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x4001531")]
		[FieldOffset(Offset = "0x20")]
		public SetAmbientAudioClipFromAssetReference _003C_003E4__this;

		[Token(Token = "0x17000219")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x600123C")]
			[Address(RVA = "0x18428DC", Offset = "0x18428DC", VA = "0x18428DC", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x1700021A")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x600123E")]
			[Address(RVA = "0x1842924", Offset = "0x1842924", VA = "0x1842924", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x6001239")]
		[Address(RVA = "0x18426F4", Offset = "0x18426F4", VA = "0x18426F4")]
		[DebuggerHidden]
		public _003CLoadAudioClip_003Ed__4(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x600123A")]
		[Address(RVA = "0x1842720", Offset = "0x1842720", VA = "0x1842720", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x600123B")]
		[Address(RVA = "0x1842724", Offset = "0x1842724", VA = "0x1842724", Slot = "6")]
		private bool MoveNext()
		{
			return default;
		}

		[Token(Token = "0x600123C")]
		[Address(RVA = "0x18428DC", Offset = "0x18428DC", VA = "0x18428DC", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x600123D")]
		[Address(RVA = "0x18428E4", Offset = "0x18428E4", VA = "0x18428E4", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}

		[Token(Token = "0x600123E")]
		[Address(RVA = "0x1842924", Offset = "0x1842924", VA = "0x1842924", Slot = "7")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}
	}

	[Token(Token = "0x400152C")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	private AmbientAudio ambientAudio;

	[Token(Token = "0x400152D")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private AssetReference audioClipAssetReference;

	[Token(Token = "0x400152E")]
	[FieldOffset(Offset = "0x28")]
	private AsyncOperationHandle<AudioClip> asyncOperationHandle;

	[Token(Token = "0x6001235")]
	[Address(RVA = "0x168B074", Offset = "0x168B074", VA = "0x168B074")]
	private void Awake()
	{
	}

	[Token(Token = "0x6001236")]
	[Address(RVA = "0x168B0F0", Offset = "0x168B0F0", VA = "0x168B0F0")]
	private IEnumerator LoadAudioClip()
	{
		return null;
	}

	[Token(Token = "0x6001237")]
	[Address(RVA = "0x168B164", Offset = "0x168B164", VA = "0x168B164")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x6001238")]
	[Address(RVA = "0x168B204", Offset = "0x168B204", VA = "0x168B204")]
	public SetAmbientAudioClipFromAssetReference()
	{
	}
}
