using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Core;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Events;

[Token(Token = "0x20006B1")]
public class DistanceEvents : MonoBehaviour
{
	[Token(Token = "0x20006B2")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x41000", Offset = "0x41000")]
	private sealed class _003CCheckDistanceRoutine_003Ed__15 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4002305")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x4002306")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x4002307")]
		[FieldOffset(Offset = "0x20")]
		public DistanceEvents _003C_003E4__this;

		[Token(Token = "0x4002308")]
		[FieldOffset(Offset = "0x28")]
		private WaitForSeconds _003Cwait_003E5__2;

		[Token(Token = "0x4002309")]
		[FieldOffset(Offset = "0x30")]
		private List<Transform>.Enumerator _003C_003E7__wrap2;

		[Token(Token = "0x1700038B")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6001EDE")]
			[Address(RVA = "0x179C8A8", Offset = "0x179C8A8", VA = "0x179C8A8", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x1700038C")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6001EE0")]
			[Address(RVA = "0x179C8F0", Offset = "0x179C8F0", VA = "0x179C8F0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x6001EDA")]
		[Address(RVA = "0x179C40C", Offset = "0x179C40C", VA = "0x179C40C")]
		[DebuggerHidden]
		public _003CCheckDistanceRoutine_003Ed__15(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6001EDB")]
		[Address(RVA = "0x179C438", Offset = "0x179C438", VA = "0x179C438", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6001EDC")]
		[Address(RVA = "0x179C50C", Offset = "0x179C50C", VA = "0x179C50C", Slot = "6")]
		private bool MoveNext()
		{
			return default;
		}

		[Token(Token = "0x6001EDD")]
		[Address(RVA = "0x179C4B0", Offset = "0x179C4B0", VA = "0x179C4B0")]
		private void _003C_003Em__Finally1()
		{
		}

		[Token(Token = "0x6001EDE")]
		[Address(RVA = "0x179C8A8", Offset = "0x179C8A8", VA = "0x179C8A8", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x6001EDF")]
		[Address(RVA = "0x179C8B0", Offset = "0x179C8B0", VA = "0x179C8B0", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}

		[Token(Token = "0x6001EE0")]
		[Address(RVA = "0x179C8F0", Offset = "0x179C8F0", VA = "0x179C8F0", Slot = "7")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}
	}

	[Token(Token = "0x40022FC")]
	[FieldOffset(Offset = "0x18")]
	public UnityEvent OnGotClose;

	[Token(Token = "0x40022FD")]
	[FieldOffset(Offset = "0x20")]
	public float radius;

	[Token(Token = "0x40022FE")]
	[FieldOffset(Offset = "0x28")]
	public List<Transform> targets;

	[Token(Token = "0x40022FF")]
	[FieldOffset(Offset = "0x30")]
	public bool addGolfBallControllersToTargets;

	[Token(Token = "0x4002300")]
	[FieldOffset(Offset = "0x34")]
	public float updateInterval;

	[Token(Token = "0x4002301")]
	[FieldOffset(Offset = "0x38")]
	public float activationDelayMin;

	[Token(Token = "0x4002302")]
	[FieldOffset(Offset = "0x3C")]
	public float activationDelayMax;

	[Token(Token = "0x4002303")]
	[FieldOffset(Offset = "0x40")]
	public bool enableOnStart;

	[Token(Token = "0x4002304")]
	[FieldOffset(Offset = "0x41")]
	private bool isActivated;

	[Token(Token = "0x6001ED1")]
	[Address(RVA = "0x142F418", Offset = "0x142F418", VA = "0x142F418")]
	public void Reset()
	{
	}

	[Token(Token = "0x6001ED2")]
	[Address(RVA = "0x142F514", Offset = "0x142F514", VA = "0x142F514")]
	public void SetDistanceCheckStatus(bool enabled)
	{
	}

	[Token(Token = "0x6001ED3")]
	[Address(RVA = "0x142F5B4", Offset = "0x142F5B4", VA = "0x142F5B4")]
	private void Start()
	{
	}

	[Token(Token = "0x6001ED4")]
	[Address(RVA = "0x142F7FC", Offset = "0x142F7FC", VA = "0x142F7FC")]
	private void Instance_OnMultiplayerSetup(MultiplayerLevelInfo multiplayerLevel)
	{
	}

	[Token(Token = "0x6001ED5")]
	[Address(RVA = "0x142FB0C", Offset = "0x142FB0C", VA = "0x142FB0C")]
	private void Instance_OnFail(GolfBallController player, string arg2, Level.State arg3)
	{
	}

	[Token(Token = "0x6001ED6")]
	[Address(RVA = "0x142FB84", Offset = "0x142FB84", VA = "0x142FB84")]
	private void HandleNewPlayerSpawned(GolfBallController newPlayer)
	{
	}

	[Token(Token = "0x6001ED7")]
	[Address(RVA = "0x142F4A0", Offset = "0x142F4A0", VA = "0x142F4A0")]
	private IEnumerator CheckDistanceRoutine()
	{
		return null;
	}

	[Token(Token = "0x6001ED8")]
	[Address(RVA = "0x142FC48", Offset = "0x142FC48", VA = "0x142FC48")]
	private void OnDrawGizmosSelected()
	{
	}

	[Token(Token = "0x6001ED9")]
	[Address(RVA = "0x142FC98", Offset = "0x142FC98", VA = "0x142FC98")]
	public DistanceEvents()
	{
	}
}
