using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.AI;

[Token(Token = "0x2000947")]
public class Skeleton : MonoBehaviour
{
	[Token(Token = "0x2000948")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x42190", Offset = "0x42190")]
	private sealed class _003CDeathAndRebirth_003Ed__29 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40032F6")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x40032F7")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x40032F8")]
		[FieldOffset(Offset = "0x20")]
		public Skeleton _003C_003E4__this;

		[Token(Token = "0x40032F9")]
		[FieldOffset(Offset = "0x28")]
		private Vector3 _003CdeathPosition_003E5__2;

		[Token(Token = "0x40032FA")]
		[FieldOffset(Offset = "0x34")]
		private Quaternion _003CdeathRotation_003E5__3;

		[Token(Token = "0x40032FB")]
		[FieldOffset(Offset = "0x44")]
		private float _003Ct_003E5__4;

		[Token(Token = "0x17000470")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6002B3B")]
			[Address(RVA = "0x1850DE4", Offset = "0x1850DE4", VA = "0x1850DE4", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x17000471")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6002B3D")]
			[Address(RVA = "0x1850E2C", Offset = "0x1850E2C", VA = "0x1850E2C", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x6002B38")]
		[Address(RVA = "0x18509E0", Offset = "0x18509E0", VA = "0x18509E0")]
		[DebuggerHidden]
		public _003CDeathAndRebirth_003Ed__29(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6002B39")]
		[Address(RVA = "0x1850A0C", Offset = "0x1850A0C", VA = "0x1850A0C", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6002B3A")]
		[Address(RVA = "0x1850A10", Offset = "0x1850A10", VA = "0x1850A10", Slot = "6")]
		private bool MoveNext()
		{
			return default;
		}

		[Token(Token = "0x6002B3B")]
		[Address(RVA = "0x1850DE4", Offset = "0x1850DE4", VA = "0x1850DE4", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x6002B3C")]
		[Address(RVA = "0x1850DEC", Offset = "0x1850DEC", VA = "0x1850DEC", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}

		[Token(Token = "0x6002B3D")]
		[Address(RVA = "0x1850E2C", Offset = "0x1850E2C", VA = "0x1850E2C", Slot = "7")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}
	}

	[Token(Token = "0x40032DC")]
	[FieldOffset(Offset = "0x18")]
	public Rigidbody ballRb;

	[Token(Token = "0x40032DD")]
	[FieldOffset(Offset = "0x20")]
	public float upKickForce;

	[Token(Token = "0x40032DE")]
	[FieldOffset(Offset = "0x24")]
	public float forwardKickForce;

	[Token(Token = "0x40032DF")]
	[FieldOffset(Offset = "0x28")]
	public float kickRange;

	[Token(Token = "0x40032E0")]
	[FieldOffset(Offset = "0x2C")]
	public float sightRange;

	[Token(Token = "0x40032E1")]
	[FieldOffset(Offset = "0x30")]
	public float timeBeforeStopChase;

	[Token(Token = "0x40032E2")]
	[FieldOffset(Offset = "0x34")]
	public float sightAngle;

	[Token(Token = "0x40032E3")]
	[FieldOffset(Offset = "0x38")]
	public float breakForce;

	[Token(Token = "0x40032E4")]
	[FieldOffset(Offset = "0x3C")]
	public float rebuildTime;

	[Token(Token = "0x40032E5")]
	[FieldOffset(Offset = "0x40")]
	public Transform raycastOrigin;

	[Token(Token = "0x40032E6")]
	[FieldOffset(Offset = "0x48")]
	public float disableTimeAfterKick;

	[Token(Token = "0x40032E7")]
	[FieldOffset(Offset = "0x50")]
	public Rigidbody[] skeletonParts;

	[Token(Token = "0x40032E8")]
	[FieldOffset(Offset = "0x58")]
	public GameObject skeletonDead;

	[Token(Token = "0x40032E9")]
	[FieldOffset(Offset = "0x60")]
	public GameObject skeletonAlive;

	[Token(Token = "0x40032EA")]
	[FieldOffset(Offset = "0x68")]
	public Transform rebuildForceTarget;

	[Token(Token = "0x40032EB")]
	[FieldOffset(Offset = "0x70")]
	public Skeleton skeletonPrefab;

	[Token(Token = "0x40032EC")]
	[FieldOffset(Offset = "0x78")]
	private NavMeshAgent navAgent;

	[Token(Token = "0x40032ED")]
	[FieldOffset(Offset = "0x80")]
	private bool isAlive;

	[Token(Token = "0x40032EE")]
	[FieldOffset(Offset = "0x88")]
	private Rigidbody rigid;

	[Token(Token = "0x40032EF")]
	[FieldOffset(Offset = "0x90")]
	private NavMeshPath path;

	[Token(Token = "0x40032F0")]
	[FieldOffset(Offset = "0x98")]
	private float lastPlayerSighting;

	[Token(Token = "0x40032F1")]
	[FieldOffset(Offset = "0x9C")]
	private Vector3 target;

	[Token(Token = "0x40032F2")]
	[FieldOffset(Offset = "0xA8")]
	private float lastKickTime;

	[Token(Token = "0x40032F3")]
	[FieldOffset(Offset = "0xAC")]
	private bool initialized;

	[Token(Token = "0x40032F4")]
	[FieldOffset(Offset = "0xB0")]
	public float rebuildForce;

	[Token(Token = "0x40032F5")]
	[FieldOffset(Offset = "0xB8")]
	public AnimationCurve rebuildForceCurve;

	[Token(Token = "0x6002B2F")]
	[Address(RVA = "0x16B3750", Offset = "0x16B3750", VA = "0x16B3750")]
	private void Start()
	{
	}

	[Token(Token = "0x6002B30")]
	[Address(RVA = "0x16B380C", Offset = "0x16B380C", VA = "0x16B380C")]
	public void Initialize(Vector3 position, Quaternion rotation, Rigidbody ballRb, Skeleton prefab)
	{
	}

	[Token(Token = "0x6002B31")]
	[Address(RVA = "0x16B3A84", Offset = "0x16B3A84", VA = "0x16B3A84")]
	private void OnCollisionEnter(Collision collision)
	{
	}

	[Token(Token = "0x6002B32")]
	[Address(RVA = "0x16B3BE0", Offset = "0x16B3BE0", VA = "0x16B3BE0")]
	private IEnumerator DeathAndRebirth()
	{
		return null;
	}

	[Token(Token = "0x6002B33")]
	[Address(RVA = "0x16B3C54", Offset = "0x16B3C54", VA = "0x16B3C54")]
	private void DoKick(Rigidbody other)
	{
	}

	[Token(Token = "0x6002B34")]
	[Address(RVA = "0x16B3DA0", Offset = "0x16B3DA0", VA = "0x16B3DA0")]
	private bool CanSee(GameObject obj)
	{
		return default;
	}

	[Token(Token = "0x6002B35")]
	[Address(RVA = "0x16B4088", Offset = "0x16B4088", VA = "0x16B4088")]
	private void Update()
	{
	}

	[Token(Token = "0x6002B36")]
	[Address(RVA = "0x16B42CC", Offset = "0x16B42CC", VA = "0x16B42CC")]
	private void OnDrawGizmos()
	{
	}

	[Token(Token = "0x6002B37")]
	[Address(RVA = "0x16B44E8", Offset = "0x16B44E8", VA = "0x16B44E8")]
	public Skeleton()
	{
	}
}
