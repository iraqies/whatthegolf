using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Audio;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000AA4")]
public class FaceRoom : MonoBehaviour
{
	[Token(Token = "0x2000AA5")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x42EF0", Offset = "0x42EF0")]
	private sealed class _003CCooldownRoutine_003Ed__15 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4003B3B")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x4003B3C")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x4003B3D")]
		[FieldOffset(Offset = "0x20")]
		public FaceRoom _003C_003E4__this;

		[Token(Token = "0x1700053F")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x60032D5")]
			[Address(RVA = "0x17A2620", Offset = "0x17A2620", VA = "0x17A2620", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x17000540")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x60032D7")]
			[Address(RVA = "0x17A2668", Offset = "0x17A2668", VA = "0x17A2668", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x60032D2")]
		[Address(RVA = "0x17A2530", Offset = "0x17A2530", VA = "0x17A2530")]
		[DebuggerHidden]
		public _003CCooldownRoutine_003Ed__15(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x60032D3")]
		[Address(RVA = "0x17A255C", Offset = "0x17A255C", VA = "0x17A255C", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x60032D4")]
		[Address(RVA = "0x17A2560", Offset = "0x17A2560", VA = "0x17A2560", Slot = "6")]
		private bool MoveNext()
		{
			return default;
		}

		[Token(Token = "0x60032D5")]
		[Address(RVA = "0x17A2620", Offset = "0x17A2620", VA = "0x17A2620", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x60032D6")]
		[Address(RVA = "0x17A2628", Offset = "0x17A2628", VA = "0x17A2628", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}

		[Token(Token = "0x60032D7")]
		[Address(RVA = "0x17A2668", Offset = "0x17A2668", VA = "0x17A2668", Slot = "7")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}
	}

	[Token(Token = "0x2000AA6")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x42F00", Offset = "0x42F00")]
	private sealed class _003CWakeUp_003Ed__16 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4003B3E")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x4003B3F")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x4003B40")]
		[FieldOffset(Offset = "0x20")]
		public FaceRoom _003C_003E4__this;

		[Token(Token = "0x17000541")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x60032DB")]
			[Address(RVA = "0x17A2AD8", Offset = "0x17A2AD8", VA = "0x17A2AD8", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x17000542")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x60032DD")]
			[Address(RVA = "0x17A2B20", Offset = "0x17A2B20", VA = "0x17A2B20", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x60032D8")]
		[Address(RVA = "0x17A2670", Offset = "0x17A2670", VA = "0x17A2670")]
		[DebuggerHidden]
		public _003CWakeUp_003Ed__16(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x60032D9")]
		[Address(RVA = "0x17A269C", Offset = "0x17A269C", VA = "0x17A269C", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x60032DA")]
		[Address(RVA = "0x17A26A0", Offset = "0x17A26A0", VA = "0x17A26A0", Slot = "6")]
		private bool MoveNext()
		{
			return default;
		}

		[Token(Token = "0x60032DB")]
		[Address(RVA = "0x17A2AD8", Offset = "0x17A2AD8", VA = "0x17A2AD8", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x60032DC")]
		[Address(RVA = "0x17A2AE0", Offset = "0x17A2AE0", VA = "0x17A2AE0", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}

		[Token(Token = "0x60032DD")]
		[Address(RVA = "0x17A2B20", Offset = "0x17A2B20", VA = "0x17A2B20", Slot = "7")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}
	}

	[Token(Token = "0x4003B2E")]
	[FieldOffset(Offset = "0x18")]
	public ClipSettingsCollection wakeupSFX;

	[Token(Token = "0x4003B2F")]
	[FieldOffset(Offset = "0x20")]
	public Transform eyeLeft;

	[Token(Token = "0x4003B30")]
	[FieldOffset(Offset = "0x28")]
	public Transform eyeRight;

	[Token(Token = "0x4003B31")]
	[FieldOffset(Offset = "0x30")]
	public Transform mouth;

	[Token(Token = "0x4003B32")]
	[FieldOffset(Offset = "0x38")]
	private Vector3 eyeBaseScale;

	[Token(Token = "0x4003B33")]
	[FieldOffset(Offset = "0x44")]
	private Vector3 mouthScale;

	[Token(Token = "0x4003B34")]
	[FieldOffset(Offset = "0x50")]
	private Vector3 closedMouthScale;

	[Token(Token = "0x4003B35")]
	[FieldOffset(Offset = "0x5C")]
	private bool isAwake;

	[Token(Token = "0x4003B36")]
	[FieldOffset(Offset = "0x60")]
	private Vector3 baseScale;

	[Token(Token = "0x4003B37")]
	[FieldOffset(Offset = "0x6C")]
	public bool UseAnimation;

	[Token(Token = "0x4003B38")]
	[FieldOffset(Offset = "0x70")]
	public Animator animator;

	[Token(Token = "0x4003B39")]
	[FieldOffset(Offset = "0x78")]
	private bool onCooldown;

	[Token(Token = "0x4003B3A")]
	[FieldOffset(Offset = "0x7C")]
	public float CooldownDuration;

	[Token(Token = "0x60032C6")]
	[Address(RVA = "0x145A10C", Offset = "0x145A10C", VA = "0x145A10C")]
	private void Start()
	{
	}

	[Token(Token = "0x60032C7")]
	[Address(RVA = "0x145A1D0", Offset = "0x145A1D0", VA = "0x145A1D0")]
	private void OnCollisionEnter2D(Collision2D collision)
	{
	}

	[Token(Token = "0x60032C8")]
	[Address(RVA = "0x145A434", Offset = "0x145A434", VA = "0x145A434")]
	private IEnumerator CooldownRoutine()
	{
		return null;
	}

	[Token(Token = "0x60032C9")]
	[Address(RVA = "0x145A3C0", Offset = "0x145A3C0", VA = "0x145A3C0")]
	private IEnumerator WakeUp()
	{
		return null;
	}

	[Token(Token = "0x60032CA")]
	[Address(RVA = "0x145A4A8", Offset = "0x145A4A8", VA = "0x145A4A8")]
	public FaceRoom()
	{
	}

	[Token(Token = "0x60032CB")]
	[Address(RVA = "0x145A4B0", Offset = "0x145A4B0", VA = "0x145A4B0")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x69FC4", Offset = "0x69FC4")]
	private void _003CWakeUp_003Eb__16_0(float t)
	{
	}

	[Token(Token = "0x60032CC")]
	[Address(RVA = "0x145A558", Offset = "0x145A558", VA = "0x145A558")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x69FD4", Offset = "0x69FD4")]
	private void _003CWakeUp_003Eb__16_1(float t)
	{
	}

	[Token(Token = "0x60032CD")]
	[Address(RVA = "0x145A600", Offset = "0x145A600", VA = "0x145A600")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x69FE4", Offset = "0x69FE4")]
	private void _003CWakeUp_003Eb__16_2(float t)
	{
	}

	[Token(Token = "0x60032CE")]
	[Address(RVA = "0x145A684", Offset = "0x145A684", VA = "0x145A684")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x69FF4", Offset = "0x69FF4")]
	private void _003CWakeUp_003Eb__16_3(float t)
	{
	}

	[Token(Token = "0x60032CF")]
	[Address(RVA = "0x145A72C", Offset = "0x145A72C", VA = "0x145A72C")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6A004", Offset = "0x6A004")]
	private void _003CWakeUp_003Eb__16_4(float t)
	{
	}

	[Token(Token = "0x60032D0")]
	[Address(RVA = "0x145A7D0", Offset = "0x145A7D0", VA = "0x145A7D0")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6A014", Offset = "0x6A014")]
	private void _003CWakeUp_003Eb__16_5(float t)
	{
	}

	[Token(Token = "0x60032D1")]
	[Address(RVA = "0x145A874", Offset = "0x145A874", VA = "0x145A874")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6A024", Offset = "0x6A024")]
	private void _003CWakeUp_003Eb__16_6(float t)
	{
	}
}
