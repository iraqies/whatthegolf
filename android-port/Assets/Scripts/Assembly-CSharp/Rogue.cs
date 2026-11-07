using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.AI;

[Token(Token = "0x2000943")]
public class Rogue : MonoBehaviour
{
	[Token(Token = "0x2000944")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x42170", Offset = "0x42170")]
	private sealed class _003CAttack_003Ed__28 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40032C2")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x40032C3")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x40032C4")]
		[FieldOffset(Offset = "0x20")]
		public Rogue _003C_003E4__this;

		[Token(Token = "0x40032C5")]
		[FieldOffset(Offset = "0x28")]
		public Rigidbody other;

		[Token(Token = "0x1700046C")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6002B19")]
			[Address(RVA = "0x18361FC", Offset = "0x18361FC", VA = "0x18361FC", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x1700046D")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6002B1B")]
			[Address(RVA = "0x1836244", Offset = "0x1836244", VA = "0x1836244", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x6002B16")]
		[Address(RVA = "0x1835E44", Offset = "0x1835E44", VA = "0x1835E44")]
		[DebuggerHidden]
		public _003CAttack_003Ed__28(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6002B17")]
		[Address(RVA = "0x1835E70", Offset = "0x1835E70", VA = "0x1835E70", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6002B18")]
		[Address(RVA = "0x1835E74", Offset = "0x1835E74", VA = "0x1835E74", Slot = "6")]
		private bool MoveNext()
		{
			return default;
		}

		[Token(Token = "0x6002B19")]
		[Address(RVA = "0x18361FC", Offset = "0x18361FC", VA = "0x18361FC", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x6002B1A")]
		[Address(RVA = "0x1836204", Offset = "0x1836204", VA = "0x1836204", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}

		[Token(Token = "0x6002B1B")]
		[Address(RVA = "0x1836244", Offset = "0x1836244", VA = "0x1836244", Slot = "7")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}
	}

	[Token(Token = "0x40032A9")]
	[FieldOffset(Offset = "0x18")]
	public Rigidbody ballRb;

	[Token(Token = "0x40032AA")]
	[FieldOffset(Offset = "0x20")]
	public float upKickForce;

	[Token(Token = "0x40032AB")]
	[FieldOffset(Offset = "0x24")]
	public float forwardKickForce;

	[Token(Token = "0x40032AC")]
	[FieldOffset(Offset = "0x28")]
	public float onAreaCheckDist;

	[Token(Token = "0x40032AD")]
	[FieldOffset(Offset = "0x2C")]
	public float sightRange;

	[Token(Token = "0x40032AE")]
	[FieldOffset(Offset = "0x30")]
	public float fadeInDuration;

	[Token(Token = "0x40032AF")]
	[FieldOffset(Offset = "0x34")]
	public float maxAttackDist;

	[Token(Token = "0x40032B0")]
	[FieldOffset(Offset = "0x38")]
	public SkinnedMeshRenderer rend;

	[Token(Token = "0x40032B1")]
	[FieldOffset(Offset = "0x40")]
	public float shadowSpeed;

	[Token(Token = "0x40032B2")]
	[FieldOffset(Offset = "0x44")]
	public float normalSpeed;

	[Token(Token = "0x40032B3")]
	[FieldOffset(Offset = "0x48")]
	private NavMeshAgent navAgent;

	[Token(Token = "0x40032B4")]
	[FieldOffset(Offset = "0x50")]
	private bool isAlive;

	[Token(Token = "0x40032B5")]
	[FieldOffset(Offset = "0x54")]
	public float speedChangeAreaDistCheck;

	[Token(Token = "0x40032B6")]
	[FieldOffset(Offset = "0x58")]
	public float retreatAfterAttackDuration;

	[Token(Token = "0x40032B7")]
	[FieldOffset(Offset = "0x5C")]
	public float attackAnimationDuration;

	[Token(Token = "0x40032B8")]
	[FieldOffset(Offset = "0x60")]
	public Rect respawnArea;

	[Token(Token = "0x40032B9")]
	[FieldOffset(Offset = "0x70")]
	public string AttackParam;

	[Token(Token = "0x40032BA")]
	[FieldOffset(Offset = "0x78")]
	public Animator anim;

	[Token(Token = "0x40032BB")]
	[FieldOffset(Offset = "0x80")]
	private Rigidbody rigid;

	[Token(Token = "0x40032BC")]
	[FieldOffset(Offset = "0x88")]
	private Vector3 target;

	[Token(Token = "0x40032BD")]
	[FieldOffset(Offset = "0x94")]
	private float lastAttackTime;

	[Token(Token = "0x40032BE")]
	[FieldOffset(Offset = "0x98")]
	private bool initialized;

	[Token(Token = "0x40032BF")]
	[FieldOffset(Offset = "0x99")]
	private bool attacking;

	[Token(Token = "0x40032C0")]
	private const string innerShadow = "InnerShadow";

	[Token(Token = "0x40032C1")]
	private const string outerShadow = "OuterShadow";

	[Token(Token = "0x6002B0B")]
	[Address(RVA = "0x165A704", Offset = "0x165A704", VA = "0x165A704")]
	private void Start()
	{
	}

	[Token(Token = "0x6002B0C")]
	[Address(RVA = "0x165A7B8", Offset = "0x165A7B8", VA = "0x165A7B8")]
	public void Initialize(Vector3 position, Quaternion rotation)
	{
	}

	[Token(Token = "0x6002B0D")]
	[Address(RVA = "0x165AAE8", Offset = "0x165AAE8", VA = "0x165AAE8")]
	private void OnTriggerStay(Collider other)
	{
	}

	[Token(Token = "0x6002B0E")]
	[Address(RVA = "0x165ACF8", Offset = "0x165ACF8", VA = "0x165ACF8")]
	private IEnumerator Attack(Rigidbody other)
	{
		return null;
	}

	[Token(Token = "0x6002B0F")]
	[Address(RVA = "0x165AD70", Offset = "0x165AD70", VA = "0x165AD70")]
	private void WarpToRandomInnerShadowTarget()
	{
	}

	[Token(Token = "0x6002B10")]
	[Address(RVA = "0x165ADFC", Offset = "0x165ADFC", VA = "0x165ADFC")]
	private void SetRandomInnerShadowTarget(bool warp = false)
	{
	}

	[Token(Token = "0x6002B11")]
	[Address(RVA = "0x165AF60", Offset = "0x165AF60", VA = "0x165AF60")]
	private void Update()
	{
	}

	[Token(Token = "0x6002B12")]
	[Address(RVA = "0x165B2C4", Offset = "0x165B2C4", VA = "0x165B2C4")]
	private void OnDrawGizmos()
	{
	}

	[Token(Token = "0x6002B13")]
	[Address(RVA = "0x165B534", Offset = "0x165B534", VA = "0x165B534")]
	public Rogue()
	{
	}

	[Token(Token = "0x6002B14")]
	[Address(RVA = "0x165B5E0", Offset = "0x165B5E0", VA = "0x165B5E0")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x679C0", Offset = "0x679C0")]
	private void _003CAttack_003Eb__28_0(float t)
	{
	}

	[Token(Token = "0x6002B15")]
	[Address(RVA = "0x165B6C8", Offset = "0x165B6C8", VA = "0x165B6C8")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x679D0", Offset = "0x679D0")]
	private void _003CAttack_003Eb__28_1(float t)
	{
	}
}
