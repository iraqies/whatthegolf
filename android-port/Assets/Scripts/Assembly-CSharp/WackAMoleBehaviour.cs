using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000EBD")]
public class WackAMoleBehaviour : MonoBehaviour
{
	[Token(Token = "0x2000EBE")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x452C0", Offset = "0x452C0")]
	private sealed class _003CMoveUp_003Ed__13 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4004FBA")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x4004FBB")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x4004FBC")]
		[FieldOffset(Offset = "0x20")]
		public WackAMoleBehaviour _003C_003E4__this;

		[Token(Token = "0x4004FBD")]
		[FieldOffset(Offset = "0x28")]
		private float _003ClerpT_003E5__2;

		[Token(Token = "0x17000717")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x60044D8")]
			[Address(RVA = "0x1876CA4", Offset = "0x1876CA4", VA = "0x1876CA4", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x17000718")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x60044DA")]
			[Address(RVA = "0x1876CEC", Offset = "0x1876CEC", VA = "0x1876CEC", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x60044D5")]
		[Address(RVA = "0x1876A18", Offset = "0x1876A18", VA = "0x1876A18")]
		[DebuggerHidden]
		public _003CMoveUp_003Ed__13(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x60044D6")]
		[Address(RVA = "0x1876A44", Offset = "0x1876A44", VA = "0x1876A44", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x60044D7")]
		[Address(RVA = "0x1876A48", Offset = "0x1876A48", VA = "0x1876A48", Slot = "6")]
		private bool MoveNext()
		{
			return default;
		}

		[Token(Token = "0x60044D8")]
		[Address(RVA = "0x1876CA4", Offset = "0x1876CA4", VA = "0x1876CA4", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x60044D9")]
		[Address(RVA = "0x1876CAC", Offset = "0x1876CAC", VA = "0x1876CAC", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}

		[Token(Token = "0x60044DA")]
		[Address(RVA = "0x1876CEC", Offset = "0x1876CEC", VA = "0x1876CEC", Slot = "7")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}
	}

	[Token(Token = "0x2000EBF")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x452D0", Offset = "0x452D0")]
	private sealed class _003CMoveDown_003Ed__16 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4004FBE")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x4004FBF")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x4004FC0")]
		[FieldOffset(Offset = "0x20")]
		public bool wasHit;

		[Token(Token = "0x4004FC1")]
		[FieldOffset(Offset = "0x28")]
		public WackAMoleBehaviour _003C_003E4__this;

		[Token(Token = "0x4004FC2")]
		[FieldOffset(Offset = "0x30")]
		private float _003ClerpT_003E5__2;

		[Token(Token = "0x17000719")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x60044DE")]
			[Address(RVA = "0x18769C8", Offset = "0x18769C8", VA = "0x18769C8", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x1700071A")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x60044E0")]
			[Address(RVA = "0x1876A10", Offset = "0x1876A10", VA = "0x1876A10", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x60044DB")]
		[Address(RVA = "0x18766EC", Offset = "0x18766EC", VA = "0x18766EC")]
		[DebuggerHidden]
		public _003CMoveDown_003Ed__16(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x60044DC")]
		[Address(RVA = "0x1876718", Offset = "0x1876718", VA = "0x1876718", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x60044DD")]
		[Address(RVA = "0x187671C", Offset = "0x187671C", VA = "0x187671C", Slot = "6")]
		private bool MoveNext()
		{
			return default;
		}

		[Token(Token = "0x60044DE")]
		[Address(RVA = "0x18769C8", Offset = "0x18769C8", VA = "0x18769C8", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x60044DF")]
		[Address(RVA = "0x18769D0", Offset = "0x18769D0", VA = "0x18769D0", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}

		[Token(Token = "0x60044E0")]
		[Address(RVA = "0x1876A10", Offset = "0x1876A10", VA = "0x1876A10", Slot = "7")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}
	}

	[Token(Token = "0x2000EC0")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x452E0", Offset = "0x452E0")]
	private sealed class _003CGotHit_003Ed__17 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4004FC3")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x4004FC4")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x4004FC5")]
		[FieldOffset(Offset = "0x20")]
		public WackAMoleBehaviour _003C_003E4__this;

		[Token(Token = "0x1700071B")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x60044E4")]
			[Address(RVA = "0x187669C", Offset = "0x187669C", VA = "0x187669C", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x1700071C")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x60044E6")]
			[Address(RVA = "0x18766E4", Offset = "0x18766E4", VA = "0x18766E4", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x60044E1")]
		[Address(RVA = "0x18764BC", Offset = "0x18764BC", VA = "0x18764BC")]
		[DebuggerHidden]
		public _003CGotHit_003Ed__17(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x60044E2")]
		[Address(RVA = "0x18764E8", Offset = "0x18764E8", VA = "0x18764E8", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x60044E3")]
		[Address(RVA = "0x18764EC", Offset = "0x18764EC", VA = "0x18764EC", Slot = "6")]
		private bool MoveNext()
		{
			return default;
		}

		[Token(Token = "0x60044E4")]
		[Address(RVA = "0x187669C", Offset = "0x187669C", VA = "0x187669C", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x60044E5")]
		[Address(RVA = "0x18766A4", Offset = "0x18766A4", VA = "0x18766A4", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}

		[Token(Token = "0x60044E6")]
		[Address(RVA = "0x18766E4", Offset = "0x18766E4", VA = "0x18766E4", Slot = "7")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}
	}

	[Token(Token = "0x4004FAC")]
	[FieldOffset(Offset = "0x18")]
	public Transform[] holes;

	[Token(Token = "0x4004FAD")]
	[FieldOffset(Offset = "0x20")]
	public GameObject flag;

	[Token(Token = "0x4004FAE")]
	[FieldOffset(Offset = "0x28")]
	public ParticleSystem poofParticles;

	[Token(Token = "0x4004FAF")]
	[FieldOffset(Offset = "0x30")]
	public float timeOnEachHole;

	[Token(Token = "0x4004FB0")]
	[FieldOffset(Offset = "0x34")]
	public float movementSpeed;

	[Token(Token = "0x4004FB1")]
	[FieldOffset(Offset = "0x38")]
	public int hitNeeded;

	[Token(Token = "0x4004FB2")]
	[FieldOffset(Offset = "0x3C")]
	public Vector3 appearInHoleOffset;

	[Token(Token = "0x4004FB3")]
	[FieldOffset(Offset = "0x48")]
	public Vector3 hideInHoleOffset;

	[Token(Token = "0x4004FB4")]
	[FieldOffset(Offset = "0x54")]
	private int previousIndex;

	[Token(Token = "0x4004FB5")]
	[FieldOffset(Offset = "0x58")]
	private bool isInvincible;

	[Token(Token = "0x4004FB6")]
	[FieldOffset(Offset = "0x60")]
	[SerializeField]
	private ParticleSystem _particles;

	[Token(Token = "0x4004FB7")]
	[FieldOffset(Offset = "0x68")]
	[SerializeField]
	private PlayAudioClipSetting _onHitSFX;

	[Token(Token = "0x4004FB8")]
	[FieldOffset(Offset = "0x70")]
	[SerializeField]
	private AnimationCurve _MoveDownAnimationCurve;

	[Token(Token = "0x4004FB9")]
	[FieldOffset(Offset = "0x78")]
	[SerializeField]
	private AnimationCurve _MoveUpAnimationCurve;

	[Token(Token = "0x60044CB")]
	[Address(RVA = "0x174F0E8", Offset = "0x174F0E8", VA = "0x174F0E8")]
	private void Start()
	{
	}

	[Token(Token = "0x60044CC")]
	[Address(RVA = "0x174F164", Offset = "0x174F164", VA = "0x174F164")]
	private IEnumerator MoveUp()
	{
		return null;
	}

	[Token(Token = "0x60044CD")]
	[Address(RVA = "0x174F1D8", Offset = "0x174F1D8", VA = "0x174F1D8")]
	private IEnumerator MoveDown(bool wasHit = false)
	{
		return null;
	}

	[Token(Token = "0x60044CE")]
	[Address(RVA = "0x174F254", Offset = "0x174F254", VA = "0x174F254")]
	private IEnumerator GotHit()
	{
		return null;
	}

	[Token(Token = "0x60044CF")]
	[Address(RVA = "0x174F2C8", Offset = "0x174F2C8", VA = "0x174F2C8")]
	public int RandomHole()
	{
		return default;
	}

	[Token(Token = "0x60044D0")]
	[Address(RVA = "0x174F41C", Offset = "0x174F41C", VA = "0x174F41C")]
	public void Win()
	{
	}

	[Token(Token = "0x60044D1")]
	[Address(RVA = "0x174F444", Offset = "0x174F444", VA = "0x174F444")]
	private void OnCollisionEnter(Collision collision)
	{
	}

	[Token(Token = "0x60044D2")]
	[Address(RVA = "0x174F534", Offset = "0x174F534", VA = "0x174F534")]
	public void FlagHit()
	{
	}

	[Token(Token = "0x60044D3")]
	[Address(RVA = "0x174F5B0", Offset = "0x174F5B0", VA = "0x174F5B0")]
	private void RemoveBall(GameObject ball)
	{
	}

	[Token(Token = "0x60044D4")]
	[Address(RVA = "0x174F650", Offset = "0x174F650", VA = "0x174F650")]
	public WackAMoleBehaviour()
	{
	}
}
