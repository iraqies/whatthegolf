using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000037")]
public class ThrowableSnowball : MonoBehaviour
{
	[Token(Token = "0x2000038")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3D358", Offset = "0x3D358")]
	private sealed class _003C_003Ec__DisplayClass13_0
	{
		[Token(Token = "0x40000E2")]
		[FieldOffset(Offset = "0x10")]
		public ThrowableSnowball _003C_003E4__this;

		[Token(Token = "0x40000E3")]
		[FieldOffset(Offset = "0x18")]
		public Vector3 startScale;

		[Token(Token = "0x60000DC")]
		[Address(RVA = "0x1865D38", Offset = "0x1865D38", VA = "0x1865D38")]
		public _003C_003Ec__DisplayClass13_0()
		{
		}

		[Token(Token = "0x60000DD")]
		[Address(RVA = "0x1865D40", Offset = "0x1865D40", VA = "0x1865D40")]
		internal void _003CShrink_003Eb__0(float t)
		{
		}
	}

	[Token(Token = "0x2000039")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3D368", Offset = "0x3D368")]
	private sealed class _003CShrink_003Ed__13 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40000E4")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x40000E5")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x40000E6")]
		[FieldOffset(Offset = "0x20")]
		public ThrowableSnowball _003C_003E4__this;

		[Token(Token = "0x17000030")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x60000E1")]
			[Address(RVA = "0x18662A4", Offset = "0x18662A4", VA = "0x18662A4", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x17000031")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x60000E3")]
			[Address(RVA = "0x18662EC", Offset = "0x18662EC", VA = "0x18662EC", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x60000DE")]
		[Address(RVA = "0x1865F88", Offset = "0x1865F88", VA = "0x1865F88")]
		[DebuggerHidden]
		public _003CShrink_003Ed__13(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x60000DF")]
		[Address(RVA = "0x1865FB4", Offset = "0x1865FB4", VA = "0x1865FB4", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x60000E0")]
		[Address(RVA = "0x1865FB8", Offset = "0x1865FB8", VA = "0x1865FB8", Slot = "6")]
		private bool MoveNext()
		{
			return default;
		}

		[Token(Token = "0x60000E1")]
		[Address(RVA = "0x18662A4", Offset = "0x18662A4", VA = "0x18662A4", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x60000E2")]
		[Address(RVA = "0x18662AC", Offset = "0x18662AC", VA = "0x18662AC", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}

		[Token(Token = "0x60000E3")]
		[Address(RVA = "0x18662EC", Offset = "0x18662EC", VA = "0x18662EC", Slot = "7")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}
	}

	[Token(Token = "0x200003A")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3D378", Offset = "0x3D378")]
	private sealed class _003CFreezeFrame_003Ed__14 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40000E7")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x40000E8")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x40000E9")]
		[FieldOffset(Offset = "0x20")]
		private TimeControl _003Ct_003E5__2;

		[Token(Token = "0x17000032")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x60000E7")]
			[Address(RVA = "0x1865F38", Offset = "0x1865F38", VA = "0x1865F38", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x17000033")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x60000E9")]
			[Address(RVA = "0x1865F80", Offset = "0x1865F80", VA = "0x1865F80", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x60000E4")]
		[Address(RVA = "0x1865DF0", Offset = "0x1865DF0", VA = "0x1865DF0")]
		[DebuggerHidden]
		public _003CFreezeFrame_003Ed__14(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x60000E5")]
		[Address(RVA = "0x1865E1C", Offset = "0x1865E1C", VA = "0x1865E1C", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x60000E6")]
		[Address(RVA = "0x1865E20", Offset = "0x1865E20", VA = "0x1865E20", Slot = "6")]
		private bool MoveNext()
		{
			return default;
		}

		[Token(Token = "0x60000E7")]
		[Address(RVA = "0x1865F38", Offset = "0x1865F38", VA = "0x1865F38", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x60000E8")]
		[Address(RVA = "0x1865F40", Offset = "0x1865F40", VA = "0x1865F40", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}

		[Token(Token = "0x60000E9")]
		[Address(RVA = "0x1865F80", Offset = "0x1865F80", VA = "0x1865F80", Slot = "7")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}
	}

	[Token(Token = "0x40000D9")]
	[FieldOffset(Offset = "0x18")]
	public ParticleSystem HitParticles;

	[Token(Token = "0x40000DA")]
	[FieldOffset(Offset = "0x20")]
	public ParticleSystem FlyParticles;

	[Token(Token = "0x40000DB")]
	[FieldOffset(Offset = "0x28")]
	public TrailRenderer Trail;

	[Token(Token = "0x40000DC")]
	[FieldOffset(Offset = "0x30")]
	public float ShrinkTime;

	[Token(Token = "0x40000DD")]
	[FieldOffset(Offset = "0x38")]
	private Rigidbody rigid;

	[Token(Token = "0x40000DE")]
	[FieldOffset(Offset = "0x40")]
	private float baseDrag;

	[Token(Token = "0x40000DF")]
	[FieldOffset(Offset = "0x44")]
	public float HitShakeDuration;

	[Token(Token = "0x40000E0")]
	[FieldOffset(Offset = "0x48")]
	public float HitShakeSpeed;

	[Token(Token = "0x40000E1")]
	[FieldOffset(Offset = "0x4C")]
	public float HitShakeMagnitude;

	[Token(Token = "0x60000D5")]
	[Address(RVA = "0x1713334", Offset = "0x1713334", VA = "0x1713334")]
	private void Awake()
	{
	}

	[Token(Token = "0x60000D6")]
	[Address(RVA = "0x17133A4", Offset = "0x17133A4", VA = "0x17133A4")]
	private void OnCollisionEnter(Collision other)
	{
	}

	[Token(Token = "0x60000D7")]
	[Address(RVA = "0x1713714", Offset = "0x1713714", VA = "0x1713714")]
	private void OnCollisionStay(Collision other)
	{
	}

	[Token(Token = "0x60000D8")]
	[Address(RVA = "0x1713734", Offset = "0x1713734", VA = "0x1713734")]
	private void OnCollisionExit(Collision other)
	{
	}

	[Token(Token = "0x60000D9")]
	[Address(RVA = "0x17136A0", Offset = "0x17136A0", VA = "0x17136A0")]
	private IEnumerator Shrink()
	{
		return null;
	}

	[Token(Token = "0x60000DA")]
	[Address(RVA = "0x1713644", Offset = "0x1713644", VA = "0x1713644")]
	private IEnumerator FreezeFrame()
	{
		return null;
	}

	[Token(Token = "0x60000DB")]
	[Address(RVA = "0x1713758", Offset = "0x1713758", VA = "0x1713758")]
	public ThrowableSnowball()
	{
	}
}
