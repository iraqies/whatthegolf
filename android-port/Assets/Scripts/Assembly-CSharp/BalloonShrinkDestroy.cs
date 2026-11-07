using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000E6E")]
public class BalloonShrinkDestroy : MonoBehaviour
{
	[Token(Token = "0x2000E6F")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x45068", Offset = "0x45068")]
	private sealed class _003CShrink_003Ed__21 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4004E22")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x4004E23")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x4004E24")]
		[FieldOffset(Offset = "0x20")]
		public BalloonShrinkDestroy _003C_003E4__this;

		[Token(Token = "0x4004E25")]
		[FieldOffset(Offset = "0x28")]
		private float _003CdurationTimer_003E5__2;

		[Token(Token = "0x4004E26")]
		[FieldOffset(Offset = "0x2C")]
		private Vector3 _003CstartScale_003E5__3;

		[Token(Token = "0x170006EC")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x600437E")]
			[Address(RVA = "0x17713B4", Offset = "0x17713B4", VA = "0x17713B4", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x170006ED")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6004380")]
			[Address(RVA = "0x17713FC", Offset = "0x17713FC", VA = "0x17713FC", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x600437B")]
		[Address(RVA = "0x17711C8", Offset = "0x17711C8", VA = "0x17711C8")]
		[DebuggerHidden]
		public _003CShrink_003Ed__21(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x600437C")]
		[Address(RVA = "0x17711F4", Offset = "0x17711F4", VA = "0x17711F4", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x600437D")]
		[Address(RVA = "0x17711F8", Offset = "0x17711F8", VA = "0x17711F8", Slot = "6")]
		private bool MoveNext()
		{
			return default;
		}

		[Token(Token = "0x600437E")]
		[Address(RVA = "0x17713B4", Offset = "0x17713B4", VA = "0x17713B4", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x600437F")]
		[Address(RVA = "0x17713BC", Offset = "0x17713BC", VA = "0x17713BC", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}

		[Token(Token = "0x6004380")]
		[Address(RVA = "0x17713FC", Offset = "0x17713FC", VA = "0x17713FC", Slot = "7")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}
	}

	[Token(Token = "0x4004E13")]
	[FieldOffset(Offset = "0x18")]
	public float MinPopForceSqr;

	[Token(Token = "0x4004E14")]
	[FieldOffset(Offset = "0x20")]
	public List<string> PopTags;

	[Token(Token = "0x4004E15")]
	[FieldOffset(Offset = "0x28")]
	public List<AudioClip> PopSounds;

	[Token(Token = "0x4004E16")]
	[FieldOffset(Offset = "0x30")]
	public Vector3 ForceChangeRange;

	[Token(Token = "0x4004E17")]
	[FieldOffset(Offset = "0x3C")]
	public Vector3 UpForceIfNoConstantForce;

	[Token(Token = "0x4004E18")]
	[FieldOffset(Offset = "0x48")]
	private ConstantForce upForce;

	[Token(Token = "0x4004E19")]
	[FieldOffset(Offset = "0x50")]
	private Vector3 startForce;

	[Token(Token = "0x4004E1A")]
	[FieldOffset(Offset = "0x60")]
	private Rigidbody rigid;

	[Token(Token = "0x4004E1B")]
	[FieldOffset(Offset = "0x68")]
	public float probabilityToPop;

	[Token(Token = "0x4004E1C")]
	[FieldOffset(Offset = "0x6C")]
	private bool canPop;

	[Token(Token = "0x4004E1D")]
	[FieldOffset(Offset = "0x70")]
	private TreeCounter treeCountScript;

	[Token(Token = "0x4004E1E")]
	[FieldOffset(Offset = "0x78")]
	public AnimationCurve ShrinkCurve;

	[Token(Token = "0x4004E1F")]
	[FieldOffset(Offset = "0x80")]
	public float shrinkDuration;

	[Token(Token = "0x4004E20")]
	[FieldOffset(Offset = "0x84")]
	public bool isPopped;

	[Token(Token = "0x4004E21")]
	[FieldOffset(Offset = "0x88")]
	public Action<BalloonShrinkDestroy> OnPopped;

	[Token(Token = "0x6004372")]
	[Address(RVA = "0x1519C3C", Offset = "0x1519C3C", VA = "0x1519C3C")]
	private void Awake()
	{
	}

	[Token(Token = "0x6004373")]
	[Address(RVA = "0x1519D64", Offset = "0x1519D64", VA = "0x1519D64")]
	private void OnCollisionEnter(Collision other)
	{
	}

	[Token(Token = "0x6004374")]
	[Address(RVA = "0x1519E40", Offset = "0x1519E40", VA = "0x1519E40")]
	public void PopBalloon(float probability)
	{
	}

	[Token(Token = "0x6004375")]
	[Address(RVA = "0x151A044", Offset = "0x151A044", VA = "0x151A044")]
	private void FixedUpdate()
	{
	}

	[Token(Token = "0x6004376")]
	[Address(RVA = "0x151A1F0", Offset = "0x151A1F0", VA = "0x151A1F0")]
	private void Update()
	{
	}

	[Token(Token = "0x6004377")]
	[Address(RVA = "0x1519FC8", Offset = "0x1519FC8", VA = "0x1519FC8")]
	public void StartShrink()
	{
	}

	[Token(Token = "0x6004378")]
	[Address(RVA = "0x151A23C", Offset = "0x151A23C", VA = "0x151A23C")]
	public IEnumerator Shrink()
	{
		return null;
	}

	[Token(Token = "0x6004379")]
	[Address(RVA = "0x151A2B0", Offset = "0x151A2B0", VA = "0x151A2B0")]
	public BalloonShrinkDestroy()
	{
	}

	[Token(Token = "0x600437A")]
	[Address(RVA = "0x151A3F8", Offset = "0x151A3F8", VA = "0x151A3F8")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6DBF4", Offset = "0x6DBF4")]
	private void _003CPopBalloon_003Eb__17_0(AudioSource t)
	{
	}
}
