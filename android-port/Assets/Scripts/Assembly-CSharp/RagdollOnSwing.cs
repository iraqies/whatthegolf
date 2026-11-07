using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.InteropServices;
using Audio;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.AI;

[Token(Token = "0x2000871")]
public class RagdollOnSwing : MonoBehaviour
{
	[Token(Token = "0x2000872")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x41AC0", Offset = "0x41AC0")]
	private sealed class _003CDelayedCallback_003Ed__27 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4002E4F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x4002E50")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x4002E51")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public RagdollOnSwing _003C_003E4__this;

		[Token(Token = "0x4002E52")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private float _003CmaxSeconds_003E5__2;

		[Token(Token = "0x1700042C")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6002704")]
			[Address(RVA = "0x182FEF8", Offset = "0x182FEF8", VA = "0x182FEF8", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x1700042D")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6002706")]
			[Address(RVA = "0x182FF40", Offset = "0x182FF40", VA = "0x182FF40", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x6002701")]
		[Address(RVA = "0x182FDBC", Offset = "0x182FDBC", VA = "0x182FDBC")]
		[DebuggerHidden]
		public _003CDelayedCallback_003Ed__27(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6002702")]
		[Address(RVA = "0x182FDE8", Offset = "0x182FDE8", VA = "0x182FDE8", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6002703")]
		[Address(RVA = "0x182FDEC", Offset = "0x182FDEC", VA = "0x182FDEC", Slot = "6")]
		private bool MoveNext()
		{
			return default;
		}

		[Token(Token = "0x6002704")]
		[Address(RVA = "0x182FEF8", Offset = "0x182FEF8", VA = "0x182FEF8", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x6002705")]
		[Address(RVA = "0x182FF00", Offset = "0x182FF00", VA = "0x182FF00", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}

		[Token(Token = "0x6002706")]
		[Address(RVA = "0x182FF40", Offset = "0x182FF40", VA = "0x182FF40", Slot = "7")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}
	}

	[Token(Token = "0x4002E3B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public float minVelocity;

	[Token(Token = "0x4002E3C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public float fullVelocity;

	[Token(Token = "0x4002E3D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public float fullPitch;

	[Token(Token = "0x4002E3E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public float fullSpin;

	[Token(Token = "0x4002E3F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public ClipSettingsCollection sfxOnShoot;

	[Token(Token = "0x4002E40")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public Transform RootBone;

	[Token(Token = "0x4002E41")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public GameObject Root;

	[Token(Token = "0x4002E42")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private Animator animator;

	[Token(Token = "0x4002E43")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private Action<GameObject> onHitGround;

	[Token(Token = "0x4002E44")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private Action<GameObject> onReachedDestination;

	[Token(Token = "0x4002E45")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private bool hasHitGround;

	[Token(Token = "0x4002E46")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x59")]
	private bool wentOutOfBounds;

	[Token(Token = "0x4002E47")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
	private Vector3 rootOffset;

	[Token(Token = "0x4002E48")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	private Vector3 localPosition;

	[Token(Token = "0x4002E49")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	private NavMeshAgent agent;

	[Token(Token = "0x4002E4A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	public LayerMask collisionLayers;

	[Token(Token = "0x4002E4B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	private Dictionary<Rigidbody, Vector3> origPositions;

	[Token(Token = "0x4002E4C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	private Dictionary<Rigidbody, Quaternion> origRotations;

	[Token(Token = "0x4002E4D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	private Rigidbody rootRigid;

	[Token(Token = "0x4002E4E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	private bool _doCollisionChecks;

	[Token(Token = "0x60026F5")]
	[Address(RVA = "0x163B9B8", Offset = "0x163B9B8", VA = "0x163B9B8")]
	private void Awake()
	{
	}

	[Token(Token = "0x60026F6")]
	[Address(RVA = "0x163C05C", Offset = "0x163C05C", VA = "0x163C05C")]
	private void Update()
	{
	}

	[Token(Token = "0x60026F7")]
	[Address(RVA = "0x163BC64", Offset = "0x163BC64", VA = "0x163BC64")]
	public void Reset(bool hasHitTarget)
	{
	}

	[Token(Token = "0x60026F8")]
	[Address(RVA = "0x163C1F0", Offset = "0x163C1F0", VA = "0x163C1F0")]
	public void LaunchKid(Vector3 boost, Action<GameObject> onHitGround)
	{
	}

	[Token(Token = "0x60026F9")]
	[Address(RVA = "0x163C674", Offset = "0x163C674", VA = "0x163C674")]
	public void InLineState(bool state)
	{
	}

	[Token(Token = "0x60026FA")]
	[Address(RVA = "0x163C738", Offset = "0x163C738", VA = "0x163C738")]
	public void RunBack(Vector3 pos, [Optional] Action<GameObject> onReachDestination)
	{
	}

	[Token(Token = "0x60026FB")]
	[Address(RVA = "0x163CA08", Offset = "0x163CA08", VA = "0x163CA08")]
	private void OnCollisionEnter(Collision other)
	{
	}

	[Token(Token = "0x60026FC")]
	[Address(RVA = "0x163CB3C", Offset = "0x163CB3C", VA = "0x163CB3C")]
	private IEnumerator DelayedCallback()
	{
		return null;
	}

	[Token(Token = "0x60026FD")]
	[Address(RVA = "0x163CBB0", Offset = "0x163CBB0", VA = "0x163CBB0")]
	private void OnTriggerEnter(Collider other)
	{
	}

	[Token(Token = "0x60026FE")]
	[Address(RVA = "0x163C5C0", Offset = "0x163C5C0", VA = "0x163C5C0")]
	private Vector3 PitchBoost(Vector3 boost)
	{
		return default;
	}

	[Token(Token = "0x60026FF")]
	[Address(RVA = "0x163CC68", Offset = "0x163CC68", VA = "0x163CC68")]
	public bool IsOutOfBounds()
	{
		return default;
	}

	[Token(Token = "0x6002700")]
	[Address(RVA = "0x163CC70", Offset = "0x163CC70", VA = "0x163CC70")]
	public RagdollOnSwing()
	{
	}
}
