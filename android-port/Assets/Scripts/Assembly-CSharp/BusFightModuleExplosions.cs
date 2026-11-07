using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000658")]
public class BusFightModuleExplosions : MonoBehaviour
{
	[Token(Token = "0x2000659")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x40C60", Offset = "0x40C60")]
	private sealed class _003CPlayExplodingSmallerRoutine_003Ed__13 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40020F2")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x40020F3")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x40020F4")]
		[FieldOffset(Offset = "0x20")]
		public BusFightModuleExplosions _003C_003E4__this;

		[Token(Token = "0x17000337")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6001D0B")]
			[Address(RVA = "0x177DDA4", Offset = "0x177DDA4", VA = "0x177DDA4", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x17000338")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6001D0D")]
			[Address(RVA = "0x177DDEC", Offset = "0x177DDEC", VA = "0x177DDEC", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x6001D08")]
		[Address(RVA = "0x177DCCC", Offset = "0x177DCCC", VA = "0x177DCCC")]
		[DebuggerHidden]
		public _003CPlayExplodingSmallerRoutine_003Ed__13(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6001D09")]
		[Address(RVA = "0x177DCF8", Offset = "0x177DCF8", VA = "0x177DCF8", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6001D0A")]
		[Address(RVA = "0x177DCFC", Offset = "0x177DCFC", VA = "0x177DCFC", Slot = "6")]
		private bool MoveNext()
		{
			return default;
		}

		[Token(Token = "0x6001D0B")]
		[Address(RVA = "0x177DDA4", Offset = "0x177DDA4", VA = "0x177DDA4", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x6001D0C")]
		[Address(RVA = "0x177DDAC", Offset = "0x177DDAC", VA = "0x177DDAC", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}

		[Token(Token = "0x6001D0D")]
		[Address(RVA = "0x177DDEC", Offset = "0x177DDEC", VA = "0x177DDEC", Slot = "7")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}
	}

	[Token(Token = "0x200065A")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x40C70", Offset = "0x40C70")]
	private sealed class _003CExplodeSmallerRoutine_003Ed__16 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40020F5")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x40020F6")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x40020F7")]
		[FieldOffset(Offset = "0x20")]
		public BusFightModuleExplosions _003C_003E4__this;

		[Token(Token = "0x40020F8")]
		[FieldOffset(Offset = "0x28")]
		private List<ParticleSystem>.Enumerator _003C_003E7__wrap1;

		[Token(Token = "0x17000339")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6001D12")]
			[Address(RVA = "0x177DC7C", Offset = "0x177DC7C", VA = "0x177DC7C", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x1700033A")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6001D14")]
			[Address(RVA = "0x177DCC4", Offset = "0x177DCC4", VA = "0x177DCC4", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x6001D0E")]
		[Address(RVA = "0x177D8DC", Offset = "0x177D8DC", VA = "0x177D8DC")]
		[DebuggerHidden]
		public _003CExplodeSmallerRoutine_003Ed__16(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6001D0F")]
		[Address(RVA = "0x177D908", Offset = "0x177D908", VA = "0x177D908", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6001D10")]
		[Address(RVA = "0x177D9DC", Offset = "0x177D9DC", VA = "0x177D9DC", Slot = "6")]
		private bool MoveNext()
		{
			return default;
		}

		[Token(Token = "0x6001D11")]
		[Address(RVA = "0x177D980", Offset = "0x177D980", VA = "0x177D980")]
		private void _003C_003Em__Finally1()
		{
		}

		[Token(Token = "0x6001D12")]
		[Address(RVA = "0x177DC7C", Offset = "0x177DC7C", VA = "0x177DC7C", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x6001D13")]
		[Address(RVA = "0x177DC84", Offset = "0x177DC84", VA = "0x177DC84", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}

		[Token(Token = "0x6001D14")]
		[Address(RVA = "0x177DCC4", Offset = "0x177DCC4", VA = "0x177DCC4", Slot = "7")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}
	}

	[Token(Token = "0x40020E7")]
	[FieldOffset(Offset = "0x18")]
	public AudioClip sfxExplosionBig;

	[Token(Token = "0x40020E8")]
	[FieldOffset(Offset = "0x20")]
	public List<AudioClip> sfxExplosions;

	[Token(Token = "0x40020E9")]
	[FieldOffset(Offset = "0x28")]
	public float smallVolumeMin;

	[Token(Token = "0x40020EA")]
	[FieldOffset(Offset = "0x2C")]
	public float smallVolumeMax;

	[Token(Token = "0x40020EB")]
	[FieldOffset(Offset = "0x30")]
	public float smallPitchMin;

	[Token(Token = "0x40020EC")]
	[FieldOffset(Offset = "0x34")]
	public float smallPitchMax;

	[Token(Token = "0x40020ED")]
	[FieldOffset(Offset = "0x38")]
	public ParticleSystem button;

	[Token(Token = "0x40020EE")]
	[FieldOffset(Offset = "0x40")]
	public ParticleSystem hatch;

	[Token(Token = "0x40020EF")]
	[FieldOffset(Offset = "0x48")]
	public ParticleSystem big;

	[Token(Token = "0x40020F0")]
	[FieldOffset(Offset = "0x50")]
	public List<ParticleSystem> smaller;

	[Token(Token = "0x40020F1")]
	[FieldOffset(Offset = "0x58")]
	public List<ParticleSystem> smoke;

	[Token(Token = "0x6001CFA")]
	[Address(RVA = "0x17D581C", Offset = "0x17D581C", VA = "0x17D581C")]
	public void ExplodeButton()
	{
	}

	[Token(Token = "0x6001CFB")]
	[Address(RVA = "0x17D58FC", Offset = "0x17D58FC", VA = "0x17D58FC")]
	public void ExplodeHatch()
	{
	}

	[Token(Token = "0x6001CFC")]
	[Address(RVA = "0x17D59DC", Offset = "0x17D59DC", VA = "0x17D59DC")]
	public IEnumerator PlayExplodingSmallerRoutine()
	{
		return null;
	}

	[Token(Token = "0x6001CFD")]
	[Address(RVA = "0x17D5A50", Offset = "0x17D5A50", VA = "0x17D5A50")]
	public void ExplodeRandomSmaller()
	{
	}

	[Token(Token = "0x6001CFE")]
	[Address(RVA = "0x17D5B8C", Offset = "0x17D5B8C", VA = "0x17D5B8C")]
	public void PlaySmoke()
	{
	}

	[Token(Token = "0x6001CFF")]
	[Address(RVA = "0x17D5CDC", Offset = "0x17D5CDC", VA = "0x17D5CDC")]
	public IEnumerator ExplodeSmallerRoutine()
	{
		return null;
	}

	[Token(Token = "0x6001D00")]
	[Address(RVA = "0x17D5D50", Offset = "0x17D5D50", VA = "0x17D5D50")]
	public void ExplodeAllSmaller()
	{
	}

	[Token(Token = "0x6001D01")]
	[Address(RVA = "0x17D5FB4", Offset = "0x17D5FB4", VA = "0x17D5FB4")]
	public BusFightModuleExplosions()
	{
	}

	[Token(Token = "0x6001D02")]
	[Address(RVA = "0x17D5FE0", Offset = "0x17D5FE0", VA = "0x17D5FE0")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6442C", Offset = "0x6442C")]
	private void _003CExplodeButton_003Eb__11_0(AudioSource s)
	{
	}

	[Token(Token = "0x6001D03")]
	[Address(RVA = "0x17D6064", Offset = "0x17D6064", VA = "0x17D6064")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6443C", Offset = "0x6443C")]
	private void _003CExplodeHatch_003Eb__12_0(AudioSource s)
	{
	}

	[Token(Token = "0x6001D04")]
	[Address(RVA = "0x17D60E8", Offset = "0x17D60E8", VA = "0x17D60E8")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6444C", Offset = "0x6444C")]
	private void _003CExplodeRandomSmaller_003Eb__14_0(AudioSource s)
	{
	}

	[Token(Token = "0x6001D05")]
	[Address(RVA = "0x17D6174", Offset = "0x17D6174", VA = "0x17D6174")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6445C", Offset = "0x6445C")]
	private void _003CExplodeSmallerRoutine_003Eb__16_0(AudioSource s)
	{
	}

	[Token(Token = "0x6001D06")]
	[Address(RVA = "0x17D6200", Offset = "0x17D6200", VA = "0x17D6200")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6446C", Offset = "0x6446C")]
	private void _003CExplodeAllSmaller_003Eb__17_0(AudioSource s)
	{
	}

	[Token(Token = "0x6001D07")]
	[Address(RVA = "0x17D6284", Offset = "0x17D6284", VA = "0x17D6284")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6447C", Offset = "0x6447C")]
	private void _003CExplodeAllSmaller_003Eb__17_1(AudioSource s)
	{
	}
}
