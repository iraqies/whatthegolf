using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Audio;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000796")]
public class JumpObstacle : MonoBehaviour
{
	[Token(Token = "0x2000797")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x41500", Offset = "0x41500")]
	private sealed class _003C_003Ec__DisplayClass14_0
	{
		[Token(Token = "0x4002812")]
		[FieldOffset(Offset = "0x10")]
		public JumpObstacle _003C_003E4__this;

		[Token(Token = "0x4002813")]
		[FieldOffset(Offset = "0x18")]
		public Rigidbody rigidbody;

		[Token(Token = "0x4002814")]
		[FieldOffset(Offset = "0x20")]
		public Vector3 pullDir;

		[Token(Token = "0x60022CC")]
		[Address(RVA = "0x17CB988", Offset = "0x17CB988", VA = "0x17CB988")]
		public _003C_003Ec__DisplayClass14_0()
		{
		}

		[Token(Token = "0x60022CD")]
		[Address(RVA = "0x17CB990", Offset = "0x17CB990", VA = "0x17CB990")]
		internal void _003CBounceAndPull_003Eb__0(float t)
		{
		}

		[Token(Token = "0x60022CE")]
		[Address(RVA = "0x17CBA18", Offset = "0x17CBA18", VA = "0x17CBA18")]
		internal void _003CBounceAndPull_003Eb__1(float t)
		{
		}
	}

	[Token(Token = "0x2000798")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x41510", Offset = "0x41510")]
	private sealed class _003CBounceAndPull_003Ed__14 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4002815")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x4002816")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x4002817")]
		[FieldOffset(Offset = "0x20")]
		public JumpObstacle _003C_003E4__this;

		[Token(Token = "0x4002818")]
		[FieldOffset(Offset = "0x28")]
		public Rigidbody rigidbody;

		[Token(Token = "0x170003CD")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x60022D2")]
			[Address(RVA = "0x17CBE28", Offset = "0x17CBE28", VA = "0x17CBE28", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x170003CE")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x60022D4")]
			[Address(RVA = "0x17CBE70", Offset = "0x17CBE70", VA = "0x17CBE70", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x60022CF")]
		[Address(RVA = "0x17CBA88", Offset = "0x17CBA88", VA = "0x17CBA88")]
		[DebuggerHidden]
		public _003CBounceAndPull_003Ed__14(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x60022D0")]
		[Address(RVA = "0x17CBAB4", Offset = "0x17CBAB4", VA = "0x17CBAB4", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x60022D1")]
		[Address(RVA = "0x17CBAB8", Offset = "0x17CBAB8", VA = "0x17CBAB8", Slot = "6")]
		private bool MoveNext()
		{
			return default;
		}

		[Token(Token = "0x60022D2")]
		[Address(RVA = "0x17CBE28", Offset = "0x17CBE28", VA = "0x17CBE28", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x60022D3")]
		[Address(RVA = "0x17CBE30", Offset = "0x17CBE30", VA = "0x17CBE30", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}

		[Token(Token = "0x60022D4")]
		[Address(RVA = "0x17CBE70", Offset = "0x17CBE70", VA = "0x17CBE70", Slot = "7")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}
	}

	[Token(Token = "0x4002806")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	private OnTriggerEnterListener trampolineTrigger;

	[Token(Token = "0x4002807")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private float jumpHeight;

	[Token(Token = "0x4002808")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	private Transform pullPosition;

	[Token(Token = "0x4002809")]
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	private float pullDuration;

	[Token(Token = "0x400280A")]
	[FieldOffset(Offset = "0x34")]
	[SerializeField]
	private float pullForce;

	[Token(Token = "0x400280B")]
	[FieldOffset(Offset = "0x38")]
	[SerializeField]
	private float reactionDelay;

	[Token(Token = "0x400280C")]
	[FieldOffset(Offset = "0x40")]
	[SerializeField]
	private ClipSettingsCollection reactionClips;

	[Token(Token = "0x400280D")]
	[FieldOffset(Offset = "0x48")]
	[SerializeField]
	private ClipSettingsCollection bounceClips;

	[Token(Token = "0x400280E")]
	[FieldOffset(Offset = "0x50")]
	[SerializeField]
	private Transform effectTransform;

	[Token(Token = "0x400280F")]
	[FieldOffset(Offset = "0x58")]
	[SerializeField]
	private AnimationCurve effectScale;

	[Token(Token = "0x4002810")]
	[FieldOffset(Offset = "0x60")]
	[SerializeField]
	private float effectDuration;

	[Token(Token = "0x4002811")]
	[FieldOffset(Offset = "0x64")]
	private bool isPulling;

	[Token(Token = "0x60022C8")]
	[Address(RVA = "0x14F8ACC", Offset = "0x14F8ACC", VA = "0x14F8ACC")]
	private void Awake()
	{
	}

	[Token(Token = "0x60022C9")]
	[Address(RVA = "0x14F8B60", Offset = "0x14F8B60", VA = "0x14F8B60")]
	private void HandleTrigger(Collider other)
	{
	}

	[Token(Token = "0x60022CA")]
	[Address(RVA = "0x14F8C60", Offset = "0x14F8C60", VA = "0x14F8C60")]
	private IEnumerator BounceAndPull(Rigidbody rigidbody)
	{
		return null;
	}

	[Token(Token = "0x60022CB")]
	[Address(RVA = "0x14F8CD8", Offset = "0x14F8CD8", VA = "0x14F8CD8")]
	public JumpObstacle()
	{
	}
}
