using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Audio;
using Core;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x20006E0")]
public class Egg : MonoBehaviour
{
	[Token(Token = "0x20006E1")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x41170", Offset = "0x41170")]
	private sealed class _003CStart_003Ed__15 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4002408")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x4002409")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x400240A")]
		[FieldOffset(Offset = "0x20")]
		public Egg _003C_003E4__this;

		[Token(Token = "0x170003A9")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6001FC0")]
			[Address(RVA = "0x179E90C", Offset = "0x179E90C", VA = "0x179E90C", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x170003AA")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6001FC2")]
			[Address(RVA = "0x179E954", Offset = "0x179E954", VA = "0x179E954", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x6001FBD")]
		[Address(RVA = "0x179E738", Offset = "0x179E738", VA = "0x179E738")]
		[DebuggerHidden]
		public _003CStart_003Ed__15(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6001FBE")]
		[Address(RVA = "0x179E764", Offset = "0x179E764", VA = "0x179E764", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6001FBF")]
		[Address(RVA = "0x179E768", Offset = "0x179E768", VA = "0x179E768", Slot = "6")]
		private bool MoveNext()
		{
			return default;
		}

		[Token(Token = "0x6001FC0")]
		[Address(RVA = "0x179E90C", Offset = "0x179E90C", VA = "0x179E90C", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x6001FC1")]
		[Address(RVA = "0x179E914", Offset = "0x179E914", VA = "0x179E914", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}

		[Token(Token = "0x6001FC2")]
		[Address(RVA = "0x179E954", Offset = "0x179E954", VA = "0x179E954", Slot = "7")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}
	}

	[Token(Token = "0x40023FA")]
	[FieldOffset(Offset = "0x18")]
	public float smashSpeed;

	[Token(Token = "0x40023FB")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private Transform crackedEgg;

	[Token(Token = "0x40023FC")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	private Transform smashedEgg;

	[Token(Token = "0x40023FD")]
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	private ClipSettingsCollection smashSFX;

	[Token(Token = "0x40023FE")]
	[FieldOffset(Offset = "0x38")]
	[SerializeField]
	private RandomAudioClips smashClips;

	[Token(Token = "0x40023FF")]
	[FieldOffset(Offset = "0x40")]
	[SerializeField]
	private LayerMask blacklistLayers;

	[Token(Token = "0x4002400")]
	[FieldOffset(Offset = "0x44")]
	[SerializeField]
	private bool ReloadWhenSmashed;

	[Token(Token = "0x4002401")]
	[FieldOffset(Offset = "0x45")]
	[SerializeField]
	private bool RotateSmashedEgg;

	[Token(Token = "0x4002402")]
	[FieldOffset(Offset = "0x48")]
	[SerializeField]
	private float SmashedRotationOffset;

	[Token(Token = "0x4002403")]
	[FieldOffset(Offset = "0x4C")]
	[SerializeField]
	private Vector3 SmashedPositionOffset;

	[Token(Token = "0x4002404")]
	[FieldOffset(Offset = "0x58")]
	[SerializeField]
	private float startWaitBeforeDisable;

	[Token(Token = "0x4002405")]
	[FieldOffset(Offset = "0x60")]
	private GolfBallController controller;

	[Token(Token = "0x4002406")]
	[FieldOffset(Offset = "0x68")]
	private Rigidbody rigidbody;

	[Token(Token = "0x4002407")]
	[FieldOffset(Offset = "0x70")]
	private bool didHitGoal;

	[Token(Token = "0x6001FB9")]
	[Address(RVA = "0x143B21C", Offset = "0x143B21C", VA = "0x143B21C")]
	private void Awake()
	{
	}

	[Token(Token = "0x6001FBA")]
	[Address(RVA = "0x143B278", Offset = "0x143B278", VA = "0x143B278")]
	private IEnumerator Start()
	{
		return null;
	}

	[Token(Token = "0x6001FBB")]
	[Address(RVA = "0x143B2EC", Offset = "0x143B2EC", VA = "0x143B2EC")]
	private void OnCollisionEnter(Collision collision)
	{
	}

	[Token(Token = "0x6001FBC")]
	[Address(RVA = "0x143B7EC", Offset = "0x143B7EC", VA = "0x143B7EC")]
	public Egg()
	{
	}
}
