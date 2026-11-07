using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000AAA")]
public class FogOfWar : MonoBehaviour
{
	[Token(Token = "0x2000AAB")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x42F30", Offset = "0x42F30")]
	private sealed class _003CStart_003Ed__4 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4003B5B")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x4003B5C")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x4003B5D")]
		[FieldOffset(Offset = "0x20")]
		public FogOfWar _003C_003E4__this;

		[Token(Token = "0x17000545")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x60032F5")]
			[Address(RVA = "0x17A9618", Offset = "0x17A9618", VA = "0x17A9618", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x17000546")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x60032F7")]
			[Address(RVA = "0x17A9660", Offset = "0x17A9660", VA = "0x17A9660", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x60032F2")]
		[Address(RVA = "0x17A92B0", Offset = "0x17A92B0", VA = "0x17A92B0")]
		[DebuggerHidden]
		public _003CStart_003Ed__4(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x60032F3")]
		[Address(RVA = "0x17A92DC", Offset = "0x17A92DC", VA = "0x17A92DC", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x60032F4")]
		[Address(RVA = "0x17A92E0", Offset = "0x17A92E0", VA = "0x17A92E0", Slot = "6")]
		private bool MoveNext()
		{
			return default;
		}

		[Token(Token = "0x60032F5")]
		[Address(RVA = "0x17A9618", Offset = "0x17A9618", VA = "0x17A9618", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x60032F6")]
		[Address(RVA = "0x17A9620", Offset = "0x17A9620", VA = "0x17A9620", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}

		[Token(Token = "0x60032F7")]
		[Address(RVA = "0x17A9660", Offset = "0x17A9660", VA = "0x17A9660", Slot = "7")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}
	}

	[Token(Token = "0x4003B57")]
	[FieldOffset(Offset = "0x18")]
	public OverworldButton2D DoorToDisolveFog;

	[Token(Token = "0x4003B58")]
	[FieldOffset(Offset = "0x20")]
	public List<ParticleSystem> Particles;

	[Token(Token = "0x4003B59")]
	[FieldOffset(Offset = "0x28")]
	private bool isStopping;

	[Token(Token = "0x4003B5A")]
	[FieldOffset(Offset = "0x30")]
	private ParticleSystem.Particle[] particles;

	[Token(Token = "0x60032ED")]
	[Address(RVA = "0x146E874", Offset = "0x146E874", VA = "0x146E874")]
	private IEnumerator Start()
	{
		return null;
	}

	[Token(Token = "0x60032EE")]
	[Address(RVA = "0x146E8E8", Offset = "0x146E8E8", VA = "0x146E8E8")]
	private void OnTriggerEnter2D(Collider2D other)
	{
	}

	[Token(Token = "0x60032EF")]
	[Address(RVA = "0x146EBA8", Offset = "0x146EBA8", VA = "0x146EBA8")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x60032F0")]
	[Address(RVA = "0x146E968", Offset = "0x146E968", VA = "0x146E968")]
	private void OnOpen()
	{
	}

	[Token(Token = "0x60032F1")]
	[Address(RVA = "0x146ED00", Offset = "0x146ED00", VA = "0x146ED00")]
	public FogOfWar()
	{
	}
}
