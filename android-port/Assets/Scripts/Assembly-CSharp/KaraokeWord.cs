using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.AddressableAssets;
using UnityEngine.ResourceManagement.AsyncOperations;

[Token(Token = "0x20007B8")]
public class KaraokeWord : MonoBehaviour
{
	[Token(Token = "0x20007B9")]
	public enum WordState
	{
		[Token(Token = "0x40028CB")]
		Starting = 0,
		[Token(Token = "0x40028CC")]
		Playing = 1,
		[Token(Token = "0x40028CD")]
		Stopping = 2,
		[Token(Token = "0x40028CE")]
		None = 3
	}

	[Token(Token = "0x20007BA")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x415B0", Offset = "0x415B0")]
	private sealed class _003CLoadAudioClips_003Ed__29 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40028CF")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x40028D0")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x40028D1")]
		[FieldOffset(Offset = "0x20")]
		public KaraokeWord _003C_003E4__this;

		[Token(Token = "0x170003DF")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6002362")]
			[Address(RVA = "0x17CC800", Offset = "0x17CC800", VA = "0x17CC800", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x170003E0")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6002364")]
			[Address(RVA = "0x17CC848", Offset = "0x17CC848", VA = "0x17CC848", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x600235F")]
		[Address(RVA = "0x17CC488", Offset = "0x17CC488", VA = "0x17CC488")]
		[DebuggerHidden]
		public _003CLoadAudioClips_003Ed__29(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6002360")]
		[Address(RVA = "0x17CC4B4", Offset = "0x17CC4B4", VA = "0x17CC4B4", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6002361")]
		[Address(RVA = "0x17CC4B8", Offset = "0x17CC4B8", VA = "0x17CC4B8", Slot = "6")]
		private bool MoveNext()
		{
			return default;
		}

		[Token(Token = "0x6002362")]
		[Address(RVA = "0x17CC800", Offset = "0x17CC800", VA = "0x17CC800", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x6002363")]
		[Address(RVA = "0x17CC808", Offset = "0x17CC808", VA = "0x17CC808", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}

		[Token(Token = "0x6002364")]
		[Address(RVA = "0x17CC848", Offset = "0x17CC848", VA = "0x17CC848", Slot = "7")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}
	}

	[Token(Token = "0x40028B2")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	private AudioSource audioSource;

	[Token(Token = "0x40028B3")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private Transform endMarkerTransform;

	[Token(Token = "0x40028B4")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	private ParticleSystem TreesSystem;

	[Token(Token = "0x40028B5")]
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	private ParticleSystem InstrumentSystem;

	[Token(Token = "0x40028B6")]
	[FieldOffset(Offset = "0x38")]
	[SerializeField]
	private int TreesAmount;

	[Token(Token = "0x40028B7")]
	[FieldOffset(Offset = "0x3C")]
	[SerializeField]
	private int InstrumentsAmount;

	[Token(Token = "0x40028B8")]
	[FieldOffset(Offset = "0x40")]
	[SerializeField]
	private AudioSource audioSourcePrefab;

	[Token(Token = "0x40028B9")]
	[FieldOffset(Offset = "0x48")]
	[SerializeField]
	private AssetReference startClipAssetReference;

	[Token(Token = "0x40028BA")]
	[FieldOffset(Offset = "0x50")]
	[SerializeField]
	private AssetReference midClipAssetReference;

	[Token(Token = "0x40028BB")]
	[FieldOffset(Offset = "0x58")]
	[SerializeField]
	private AssetReference endClipAssetReference;

	[Token(Token = "0x40028BC")]
	[FieldOffset(Offset = "0x60")]
	[SerializeField]
	private float volume;

	[Token(Token = "0x40028BD")]
	[FieldOffset(Offset = "0x64")]
	[SerializeField]
	private float fadeInTime;

	[Token(Token = "0x40028BE")]
	[FieldOffset(Offset = "0x68")]
	[SerializeField]
	private float fadeOutTime;

	[Token(Token = "0x40028BF")]
	[FieldOffset(Offset = "0x70")]
	private AsyncOperationHandle<AudioClip> startAsyncOperationHandle;

	[Token(Token = "0x40028C0")]
	[FieldOffset(Offset = "0x90")]
	private AsyncOperationHandle<AudioClip> midAsyncOperationHandle;

	[Token(Token = "0x40028C1")]
	[FieldOffset(Offset = "0xB0")]
	private AsyncOperationHandle<AudioClip> endAsyncOperationHandle;

	[Token(Token = "0x40028C2")]
	[FieldOffset(Offset = "0xD0")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x4EC9C", Offset = "0x4EC9C")]
	private bool InAnyPlayState__BackingField;

	[Token(Token = "0x40028C3")]
	[FieldOffset(Offset = "0xD4")]
	private float minX;

	[Token(Token = "0x40028C4")]
	[FieldOffset(Offset = "0xD8")]
	private float maxX;

	[Token(Token = "0x40028C5")]
	[FieldOffset(Offset = "0xDC")]
	public WordState currentState;

	[Token(Token = "0x40028C6")]
	[FieldOffset(Offset = "0xE0")]
	private float timeInState;

	[Token(Token = "0x40028C7")]
	[FieldOffset(Offset = "0xE8")]
	private AudioSource startSource;

	[Token(Token = "0x40028C8")]
	[FieldOffset(Offset = "0xF0")]
	private AudioSource midSource;

	[Token(Token = "0x40028C9")]
	[FieldOffset(Offset = "0xF8")]
	private AudioSource endSource;

	[Token(Token = "0x170003DC")]
	public bool InAnyPlayState
	{
		[Token(Token = "0x6002354")]
		[Address(RVA = "0x14F9F18", Offset = "0x14F9F18", VA = "0x14F9F18")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6611C", Offset = "0x6611C")]
		get
		{
			return default;
		}
		[Token(Token = "0x6002355")]
		[Address(RVA = "0x14F9F20", Offset = "0x14F9F20", VA = "0x14F9F20")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6612C", Offset = "0x6612C")]
		private set
		{
		}
	}

	[Token(Token = "0x170003DD")]
	public float MinX
	{
		[Token(Token = "0x600235B")]
		[Address(RVA = "0x14FA22C", Offset = "0x14FA22C", VA = "0x14FA22C")]
		get
		{
			return default;
		}
	}

	[Token(Token = "0x170003DE")]
	public float MaxX
	{
		[Token(Token = "0x600235C")]
		[Address(RVA = "0x14FA234", Offset = "0x14FA234", VA = "0x14FA234")]
		get
		{
			return default;
		}
	}

	[Token(Token = "0x6002356")]
	[Address(RVA = "0x14F9F28", Offset = "0x14F9F28", VA = "0x14F9F28")]
	public void Awake()
	{
	}

	[Token(Token = "0x6002357")]
	[Address(RVA = "0x14F9FD0", Offset = "0x14F9FD0", VA = "0x14F9FD0")]
	private IEnumerator LoadAudioClips()
	{
		return null;
	}

	[Token(Token = "0x6002358")]
	[Address(RVA = "0x14F9820", Offset = "0x14F9820", VA = "0x14F9820")]
	public void EnterWord()
	{
	}

	[Token(Token = "0x6002359")]
	[Address(RVA = "0x14F98FC", Offset = "0x14F98FC", VA = "0x14F98FC")]
	public void ExitWord()
	{
	}

	[Token(Token = "0x600235A")]
	[Address(RVA = "0x14FA044", Offset = "0x14FA044", VA = "0x14FA044")]
	private void Update()
	{
	}

	[Token(Token = "0x600235D")]
	[Address(RVA = "0x14FA23C", Offset = "0x14FA23C", VA = "0x14FA23C")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x600235E")]
	[Address(RVA = "0x14FA318", Offset = "0x14FA318", VA = "0x14FA318")]
	public KaraokeWord()
	{
	}
}
