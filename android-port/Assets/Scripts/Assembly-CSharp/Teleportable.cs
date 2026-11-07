using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Audio;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Events;

[Token(Token = "0x2000323")]
public class Teleportable : MonoBehaviour
{
	[Token(Token = "0x2000324")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3EFC0", Offset = "0x3EFC0")]
	private sealed class _003CTeleportCR_003Ed__12 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4001173")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x4001174")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x4001175")]
		[FieldOffset(Offset = "0x20")]
		public Teleportable _003C_003E4__this;

		[Token(Token = "0x4001176")]
		[FieldOffset(Offset = "0x28")]
		public TeleportHole connection;

		[Token(Token = "0x4001177")]
		[FieldOffset(Offset = "0x30")]
		public Vector3 holeEscapeDir;

		[Token(Token = "0x4001178")]
		[FieldOffset(Offset = "0x3C")]
		public float holeEscapeForce;

		[Token(Token = "0x4001179")]
		[FieldOffset(Offset = "0x40")]
		private Rigidbody _003Cr_003E5__2;

		[Token(Token = "0x170001B1")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6000E78")]
			[Address(RVA = "0x1861BAC", Offset = "0x1861BAC", VA = "0x1861BAC", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x170001B2")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6000E7A")]
			[Address(RVA = "0x1861BF4", Offset = "0x1861BF4", VA = "0x1861BF4", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x6000E75")]
		[Address(RVA = "0x1861618", Offset = "0x1861618", VA = "0x1861618")]
		[DebuggerHidden]
		public _003CTeleportCR_003Ed__12(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6000E76")]
		[Address(RVA = "0x1861644", Offset = "0x1861644", VA = "0x1861644", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6000E77")]
		[Address(RVA = "0x1861648", Offset = "0x1861648", VA = "0x1861648", Slot = "6")]
		private bool MoveNext()
		{
			return default;
		}

		[Token(Token = "0x6000E78")]
		[Address(RVA = "0x1861BAC", Offset = "0x1861BAC", VA = "0x1861BAC", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x6000E79")]
		[Address(RVA = "0x1861BB4", Offset = "0x1861BB4", VA = "0x1861BB4", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}

		[Token(Token = "0x6000E7A")]
		[Address(RVA = "0x1861BF4", Offset = "0x1861BF4", VA = "0x1861BF4", Slot = "7")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}
	}

	[Token(Token = "0x4001169")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	private float force;

	[Token(Token = "0x400116A")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private Rigidbody rigid;

	[Token(Token = "0x400116B")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	private Transform tail;

	[Token(Token = "0x400116C")]
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	private bool playSound;

	[Token(Token = "0x400116D")]
	[FieldOffset(Offset = "0x31")]
	[SerializeField]
	private bool rotateUp;

	[Token(Token = "0x400116E")]
	[FieldOffset(Offset = "0x34")]
	[SerializeField]
	private float afterTeleportEventTimer;

	[Token(Token = "0x400116F")]
	[FieldOffset(Offset = "0x38")]
	[SerializeField]
	private AudioClipSettings overrideClips;

	[Token(Token = "0x4001170")]
	[FieldOffset(Offset = "0x40")]
	public UnityEvent OnTeleport;

	[Token(Token = "0x4001171")]
	[FieldOffset(Offset = "0x48")]
	public UnityEvent OnDelayAfterTeleport;

	[Token(Token = "0x4001172")]
	[FieldOffset(Offset = "0x50")]
	private float lastTeleportTime;

	[Token(Token = "0x6000E71")]
	[Address(RVA = "0x16F7F48", Offset = "0x16F7F48", VA = "0x16F7F48")]
	private void Start()
	{
	}

	[Token(Token = "0x6000E72")]
	[Address(RVA = "0x16F7BA0", Offset = "0x16F7BA0", VA = "0x16F7BA0")]
	public void Teleport(TeleportHole connection, Vector3 holeEscapeDir, float holeEscapeForce)
	{
	}

	[Token(Token = "0x6000E73")]
	[Address(RVA = "0x16F8058", Offset = "0x16F8058", VA = "0x16F8058")]
	public IEnumerator TeleportCR(TeleportHole connection, Vector3 holeEscapeDir, float holeEscapeForce)
	{
		return null;
	}

	[Token(Token = "0x6000E74")]
	[Address(RVA = "0x16F80F8", Offset = "0x16F80F8", VA = "0x16F80F8")]
	public Teleportable()
	{
	}
}
