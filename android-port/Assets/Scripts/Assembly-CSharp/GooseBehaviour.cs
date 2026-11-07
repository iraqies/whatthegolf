using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;
using Triband.Splines;
using UnityEngine;
using UnityEngine.AI;

[Token(Token = "0x2000D89")]
public class GooseBehaviour : MonoBehaviour
{
	[Token(Token = "0x2000D8A")]
	private enum GooseState
	{
		[Token(Token = "0x40049A5")]
		CHILL = 0,
		[Token(Token = "0x40049A6")]
		CHASE = 1,
		[Token(Token = "0x40049A7")]
		KICK = 2,
		[Token(Token = "0x40049A8")]
		LOST = 3,
		[Token(Token = "0x40049A9")]
		POKED = 4
	}

	[Token(Token = "0x2000D8B")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x44AC8", Offset = "0x44AC8")]
	private sealed class _003CGetLost_003Ed__17 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40049AA")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x40049AB")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x40049AC")]
		[FieldOffset(Offset = "0x20")]
		public GooseBehaviour _003C_003E4__this;

		[Token(Token = "0x1700067D")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6003FAD")]
			[Address(RVA = "0x17B775C", Offset = "0x17B775C", VA = "0x17B775C", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x1700067E")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6003FAF")]
			[Address(RVA = "0x17B77A4", Offset = "0x17B77A4", VA = "0x17B77A4", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x6003FAA")]
		[Address(RVA = "0x17B7624", Offset = "0x17B7624", VA = "0x17B7624")]
		[DebuggerHidden]
		public _003CGetLost_003Ed__17(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6003FAB")]
		[Address(RVA = "0x17B7650", Offset = "0x17B7650", VA = "0x17B7650", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6003FAC")]
		[Address(RVA = "0x17B7654", Offset = "0x17B7654", VA = "0x17B7654", Slot = "6")]
		private bool MoveNext()
		{
			return default;
		}

		[Token(Token = "0x6003FAD")]
		[Address(RVA = "0x17B775C", Offset = "0x17B775C", VA = "0x17B775C", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x6003FAE")]
		[Address(RVA = "0x17B7764", Offset = "0x17B7764", VA = "0x17B7764", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}

		[Token(Token = "0x6003FAF")]
		[Address(RVA = "0x17B77A4", Offset = "0x17B77A4", VA = "0x17B77A4", Slot = "7")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}
	}

	[Token(Token = "0x2000D8C")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x44AD8", Offset = "0x44AD8")]
	private sealed class _003CTryKickBall_003Ed__18 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40049AD")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x40049AE")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x40049AF")]
		[FieldOffset(Offset = "0x20")]
		public GooseBehaviour _003C_003E4__this;

		[Token(Token = "0x1700067F")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6003FB3")]
			[Address(RVA = "0x17B7A98", Offset = "0x17B7A98", VA = "0x17B7A98", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x17000680")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6003FB5")]
			[Address(RVA = "0x17B7AE0", Offset = "0x17B7AE0", VA = "0x17B7AE0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x6003FB0")]
		[Address(RVA = "0x17B77AC", Offset = "0x17B77AC", VA = "0x17B77AC")]
		[DebuggerHidden]
		public _003CTryKickBall_003Ed__18(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6003FB1")]
		[Address(RVA = "0x17B77D8", Offset = "0x17B77D8", VA = "0x17B77D8", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6003FB2")]
		[Address(RVA = "0x17B77DC", Offset = "0x17B77DC", VA = "0x17B77DC", Slot = "6")]
		private bool MoveNext()
		{
			return default;
		}

		[Token(Token = "0x6003FB3")]
		[Address(RVA = "0x17B7A98", Offset = "0x17B7A98", VA = "0x17B7A98", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x6003FB4")]
		[Address(RVA = "0x17B7AA0", Offset = "0x17B7AA0", VA = "0x17B7AA0", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}

		[Token(Token = "0x6003FB5")]
		[Address(RVA = "0x17B7AE0", Offset = "0x17B7AE0", VA = "0x17B7AE0", Slot = "7")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}
	}

	[Token(Token = "0x2000D8D")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x44AE8", Offset = "0x44AE8")]
	private sealed class _003CChaseAfterPoked_003Ed__23 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40049B0")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x40049B1")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x40049B2")]
		[FieldOffset(Offset = "0x20")]
		public GooseBehaviour _003C_003E4__this;

		[Token(Token = "0x17000681")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6003FB9")]
			[Address(RVA = "0x17B75D4", Offset = "0x17B75D4", VA = "0x17B75D4", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x17000682")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6003FBB")]
			[Address(RVA = "0x17B761C", Offset = "0x17B761C", VA = "0x17B761C", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x6003FB6")]
		[Address(RVA = "0x17B74F4", Offset = "0x17B74F4", VA = "0x17B74F4")]
		[DebuggerHidden]
		public _003CChaseAfterPoked_003Ed__23(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6003FB7")]
		[Address(RVA = "0x17B7520", Offset = "0x17B7520", VA = "0x17B7520", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6003FB8")]
		[Address(RVA = "0x17B7524", Offset = "0x17B7524", VA = "0x17B7524", Slot = "6")]
		private bool MoveNext()
		{
			return default;
		}

		[Token(Token = "0x6003FB9")]
		[Address(RVA = "0x17B75D4", Offset = "0x17B75D4", VA = "0x17B75D4", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x6003FBA")]
		[Address(RVA = "0x17B75DC", Offset = "0x17B75DC", VA = "0x17B75DC", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}

		[Token(Token = "0x6003FBB")]
		[Address(RVA = "0x17B761C", Offset = "0x17B761C", VA = "0x17B761C", Slot = "7")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}
	}

	[Token(Token = "0x4004999")]
	[FieldOffset(Offset = "0x18")]
	private GooseState currentState;

	[Token(Token = "0x400499A")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private NavMeshAgent agent;

	[Token(Token = "0x400499B")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	private Spline path;

	[Token(Token = "0x400499C")]
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	private Animator animator;

	[Token(Token = "0x400499D")]
	[FieldOffset(Offset = "0x38")]
	[SerializeField]
	private float yeetForce;

	[Token(Token = "0x400499E")]
	[FieldOffset(Offset = "0x3C")]
	[SerializeField]
	private float attackRange;

	[Token(Token = "0x400499F")]
	[FieldOffset(Offset = "0x40")]
	private Transform chaseTarget;

	[Token(Token = "0x40049A0")]
	[FieldOffset(Offset = "0x48")]
	private Vector3 lastPlayerPos;

	[Token(Token = "0x40049A1")]
	[FieldOffset(Offset = "0x54")]
	private float baseSpeed;

	[Token(Token = "0x40049A2")]
	[FieldOffset(Offset = "0x58")]
	private Vector3 startingPos;

	[Token(Token = "0x40049A3")]
	[FieldOffset(Offset = "0x64")]
	private Quaternion startingRot;

	[Token(Token = "0x6003F9C")]
	[Address(RVA = "0x14AE84C", Offset = "0x14AE84C", VA = "0x14AE84C")]
	private void Start()
	{
	}

	[Token(Token = "0x6003F9D")]
	[Address(RVA = "0x14AE91C", Offset = "0x14AE91C", VA = "0x14AE91C")]
	private void Update()
	{
	}

	[Token(Token = "0x6003F9E")]
	[Address(RVA = "0x14AEA20", Offset = "0x14AEA20", VA = "0x14AEA20")]
	public void FollowPath()
	{
	}

	[Token(Token = "0x6003F9F")]
	[Address(RVA = "0x14AEB68", Offset = "0x14AEB68", VA = "0x14AEB68")]
	public void GoesBackToOriginPos()
	{
	}

	[Token(Token = "0x6003FA0")]
	[Address(RVA = "0x14AED1C", Offset = "0x14AED1C", VA = "0x14AED1C")]
	public void Chase()
	{
	}

	[Token(Token = "0x6003FA1")]
	[Address(RVA = "0x14AF0DC", Offset = "0x14AF0DC", VA = "0x14AF0DC")]
	private IEnumerator GetLost()
	{
		return null;
	}

	[Token(Token = "0x6003FA2")]
	[Address(RVA = "0x14AF068", Offset = "0x14AF068", VA = "0x14AF068")]
	private IEnumerator TryKickBall()
	{
		return null;
	}

	[Token(Token = "0x6003FA3")]
	[Address(RVA = "0x14AF048", Offset = "0x14AF048", VA = "0x14AF048")]
	private void StopAfterKick()
	{
	}

	[Token(Token = "0x6003FA4")]
	[Address(RVA = "0x14AF150", Offset = "0x14AF150", VA = "0x14AF150")]
	public void StartChasing(Transform target)
	{
	}

	[Token(Token = "0x6003FA5")]
	[Address(RVA = "0x14AF1A0", Offset = "0x14AF1A0", VA = "0x14AF1A0")]
	public void UpdateChaseTarget(Transform target)
	{
	}

	[Token(Token = "0x6003FA6")]
	[Address(RVA = "0x14AF1E8", Offset = "0x14AF1E8", VA = "0x14AF1E8")]
	public void Poked(Transform target)
	{
	}

	[Token(Token = "0x6003FA7")]
	[Address(RVA = "0x14AF298", Offset = "0x14AF298", VA = "0x14AF298")]
	private IEnumerator ChaseAfterPoked()
	{
		return null;
	}

	[Token(Token = "0x6003FA8")]
	[Address(RVA = "0x14AF30C", Offset = "0x14AF30C", VA = "0x14AF30C")]
	public void LostTarget(Vector3 lastPos)
	{
	}

	[Token(Token = "0x6003FA9")]
	[Address(RVA = "0x14AF328", Offset = "0x14AF328", VA = "0x14AF328")]
	public GooseBehaviour()
	{
	}
}
