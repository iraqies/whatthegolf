using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x20003CB")]
public class SceneListenerSettings : MonoBehaviour
{
	[Token(Token = "0x20003CC")]
	public enum InitMode
	{
		[Token(Token = "0x40014E1")]
		FromMainAudioListener = 0,
		[Token(Token = "0x40014E2")]
		OnAwake = 1,
		[Token(Token = "0x40014E3")]
		OnStart = 2,
		[Token(Token = "0x40014E4")]
		OnEnable = 3
	}

	[Token(Token = "0x20003CD")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3F7D4", Offset = "0x3F7D4")]
	private sealed class _003CSetFollowAfterDelay_003Ed__11 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40014E5")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x40014E6")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x40014E7")]
		[FieldOffset(Offset = "0x20")]
		public SceneListenerSettings _003C_003E4__this;

		[Token(Token = "0x17000216")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x60011ED")]
			[Address(RVA = "0x183E94C", Offset = "0x183E94C", VA = "0x183E94C", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x17000217")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x60011EF")]
			[Address(RVA = "0x183E994", Offset = "0x183E994", VA = "0x183E994", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x60011EA")]
		[Address(RVA = "0x183E85C", Offset = "0x183E85C", VA = "0x183E85C")]
		[DebuggerHidden]
		public _003CSetFollowAfterDelay_003Ed__11(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x60011EB")]
		[Address(RVA = "0x183E888", Offset = "0x183E888", VA = "0x183E888", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x60011EC")]
		[Address(RVA = "0x183E88C", Offset = "0x183E88C", VA = "0x183E88C", Slot = "6")]
		private bool MoveNext()
		{
			return default;
		}

		[Token(Token = "0x60011ED")]
		[Address(RVA = "0x183E94C", Offset = "0x183E94C", VA = "0x183E94C", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x60011EE")]
		[Address(RVA = "0x183E954", Offset = "0x183E954", VA = "0x183E954", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}

		[Token(Token = "0x60011EF")]
		[Address(RVA = "0x183E994", Offset = "0x183E994", VA = "0x183E994", Slot = "7")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}
	}

	[Token(Token = "0x40014DA")]
	[FieldOffset(Offset = "0x18")]
	public InitMode initMode;

	[Token(Token = "0x40014DB")]
	[FieldOffset(Offset = "0x1C")]
	public float delay;

	[Token(Token = "0x40014DC")]
	[FieldOffset(Offset = "0x20")]
	public bool SetRotation;

	[Token(Token = "0x40014DD")]
	[FieldOffset(Offset = "0x24")]
	public Vector3 Rotation;

	[Token(Token = "0x40014DE")]
	[FieldOffset(Offset = "0x30")]
	public Transform InitializeFollowTo;

	[Token(Token = "0x40014DF")]
	[FieldOffset(Offset = "0x38")]
	public Transform cameraTransform;

	[Token(Token = "0x60011E4")]
	[Address(RVA = "0x167B094", Offset = "0x167B094", VA = "0x167B094")]
	public void Init()
	{
	}

	[Token(Token = "0x60011E5")]
	[Address(RVA = "0x167B13C", Offset = "0x167B13C", VA = "0x167B13C")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x60011E6")]
	[Address(RVA = "0x167B0A4", Offset = "0x167B0A4", VA = "0x167B0A4")]
	private void Execute()
	{
	}

	[Token(Token = "0x60011E7")]
	[Address(RVA = "0x167B1C4", Offset = "0x167B1C4", VA = "0x167B1C4")]
	private void SetFollow()
	{
	}

	[Token(Token = "0x60011E8")]
	[Address(RVA = "0x167B150", Offset = "0x167B150", VA = "0x167B150")]
	private IEnumerator SetFollowAfterDelay()
	{
		return null;
	}

	[Token(Token = "0x60011E9")]
	[Address(RVA = "0x167B2E8", Offset = "0x167B2E8", VA = "0x167B2E8")]
	public SceneListenerSettings()
	{
	}
}
