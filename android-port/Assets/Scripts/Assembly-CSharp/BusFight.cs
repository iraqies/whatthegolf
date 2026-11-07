using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Core;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000652")]
public class BusFight : MonoBehaviour
{
	[Token(Token = "0x2000653")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x40C10", Offset = "0x40C10")]
	private sealed class _003CStart_003Ed__23 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40020D3")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x40020D4")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x40020D5")]
		[FieldOffset(Offset = "0x20")]
		public BusFight _003C_003E4__this;

		[Token(Token = "0x17000331")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6001CE6")]
			[Address(RVA = "0x177D88C", Offset = "0x177D88C", VA = "0x177D88C", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x17000332")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6001CE8")]
			[Address(RVA = "0x177D8D4", Offset = "0x177D8D4", VA = "0x177D8D4", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x6001CE3")]
		[Address(RVA = "0x177D5CC", Offset = "0x177D5CC", VA = "0x177D5CC")]
		[DebuggerHidden]
		public _003CStart_003Ed__23(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6001CE4")]
		[Address(RVA = "0x177D5F8", Offset = "0x177D5F8", VA = "0x177D5F8", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6001CE5")]
		[Address(RVA = "0x177D5FC", Offset = "0x177D5FC", VA = "0x177D5FC", Slot = "6")]
		private bool MoveNext()
		{
			return default;
		}

		[Token(Token = "0x6001CE6")]
		[Address(RVA = "0x177D88C", Offset = "0x177D88C", VA = "0x177D88C", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x6001CE7")]
		[Address(RVA = "0x177D894", Offset = "0x177D894", VA = "0x177D894", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}

		[Token(Token = "0x6001CE8")]
		[Address(RVA = "0x177D8D4", Offset = "0x177D8D4", VA = "0x177D8D4", Slot = "7")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}
	}

	[Token(Token = "0x2000654")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x40C20", Offset = "0x40C20")]
	private sealed class _003CFailDelayed_003Ed__25 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40020D6")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x40020D7")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x17000333")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6001CEC")]
			[Address(RVA = "0x177D57C", Offset = "0x177D57C", VA = "0x177D57C", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x17000334")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6001CEE")]
			[Address(RVA = "0x177D5C4", Offset = "0x177D5C4", VA = "0x177D5C4", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x6001CE9")]
		[Address(RVA = "0x177D464", Offset = "0x177D464", VA = "0x177D464")]
		[DebuggerHidden]
		public _003CFailDelayed_003Ed__25(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6001CEA")]
		[Address(RVA = "0x177D490", Offset = "0x177D490", VA = "0x177D490", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6001CEB")]
		[Address(RVA = "0x177D494", Offset = "0x177D494", VA = "0x177D494", Slot = "6")]
		private bool MoveNext()
		{
			return default;
		}

		[Token(Token = "0x6001CEC")]
		[Address(RVA = "0x177D57C", Offset = "0x177D57C", VA = "0x177D57C", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x6001CED")]
		[Address(RVA = "0x177D584", Offset = "0x177D584", VA = "0x177D584", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}

		[Token(Token = "0x6001CEE")]
		[Address(RVA = "0x177D5C4", Offset = "0x177D5C4", VA = "0x177D5C4", Slot = "7")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}
	}

	[Token(Token = "0x2000655")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x40C30", Offset = "0x40C30")]
	private sealed class _003C_003Ec__DisplayClass26_0
	{
		[Token(Token = "0x40020D8")]
		[FieldOffset(Offset = "0x10")]
		public BusFight _003C_003E4__this;

		[Token(Token = "0x40020D9")]
		[FieldOffset(Offset = "0x18")]
		public float extraSpeedOnObstacleCollision;

		[Token(Token = "0x6001CEF")]
		[Address(RVA = "0x177C6A0", Offset = "0x177C6A0", VA = "0x177C6A0")]
		public _003C_003Ec__DisplayClass26_0()
		{
		}

		[Token(Token = "0x6001CF0")]
		[Address(RVA = "0x177C6A8", Offset = "0x177C6A8", VA = "0x177C6A8")]
		internal void _003CPlayer_OnHitObstacle_003Eb__0(float t)
		{
		}
	}

	[Token(Token = "0x2000656")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x40C40", Offset = "0x40C40")]
	private sealed class _003C_003Ec__DisplayClass28_0
	{
		[Token(Token = "0x40020DA")]
		[FieldOffset(Offset = "0x10")]
		public BusFight _003C_003E4__this;

		[Token(Token = "0x40020DB")]
		[FieldOffset(Offset = "0x18")]
		public float xMovementMultiplierStart;

		[Token(Token = "0x40020DC")]
		[FieldOffset(Offset = "0x1C")]
		public float speedStart;

		[Token(Token = "0x6001CF1")]
		[Address(RVA = "0x177C6F4", Offset = "0x177C6F4", VA = "0x177C6F4")]
		public _003C_003Ec__DisplayClass28_0()
		{
		}

		[Token(Token = "0x6001CF2")]
		[Address(RVA = "0x177C6FC", Offset = "0x177C6FC", VA = "0x177C6FC")]
		internal void _003CBossRoutine_003Eb__0(float t)
		{
		}
	}

	[Token(Token = "0x2000657")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x40C50", Offset = "0x40C50")]
	private sealed class _003CBossRoutine_003Ed__28 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40020DD")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x40020DE")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x40020DF")]
		[FieldOffset(Offset = "0x20")]
		public BusFight _003C_003E4__this;

		[Token(Token = "0x40020E0")]
		[FieldOffset(Offset = "0x28")]
		private _003C_003Ec__DisplayClass28_0 _003C_003E8__1;

		[Token(Token = "0x40020E1")]
		[FieldOffset(Offset = "0x30")]
		private Coroutine _003CrandomExplosions_003E5__2;

		[Token(Token = "0x40020E2")]
		[FieldOffset(Offset = "0x38")]
		private float _003Cwaittill_003E5__3;

		[Token(Token = "0x40020E3")]
		[FieldOffset(Offset = "0x3C")]
		private float _003CrotateSpeed_003E5__4;

		[Token(Token = "0x40020E4")]
		[FieldOffset(Offset = "0x40")]
		private Vector3 _003CgreenPos_003E5__5;

		[Token(Token = "0x40020E5")]
		[FieldOffset(Offset = "0x50")]
		private List<BusFightPart>.Enumerator _003C_003E7__wrap5;

		[Token(Token = "0x40020E6")]
		[FieldOffset(Offset = "0x68")]
		private BusFightPart _003Cpart_003E5__7;

		[Token(Token = "0x17000335")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6001CF7")]
			[Address(RVA = "0x177D414", Offset = "0x177D414", VA = "0x177D414", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x17000336")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6001CF9")]
			[Address(RVA = "0x177D45C", Offset = "0x177D45C", VA = "0x177D45C", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x6001CF3")]
		[Address(RVA = "0x177C768", Offset = "0x177C768", VA = "0x177C768")]
		[DebuggerHidden]
		public _003CBossRoutine_003Ed__28(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6001CF4")]
		[Address(RVA = "0x177C794", Offset = "0x177C794", VA = "0x177C794", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6001CF5")]
		[Address(RVA = "0x177C874", Offset = "0x177C874", VA = "0x177C874", Slot = "6")]
		private bool MoveNext()
		{
			return default;
		}

		[Token(Token = "0x6001CF6")]
		[Address(RVA = "0x177C818", Offset = "0x177C818", VA = "0x177C818")]
		private void _003C_003Em__Finally1()
		{
		}

		[Token(Token = "0x6001CF7")]
		[Address(RVA = "0x177D414", Offset = "0x177D414", VA = "0x177D414", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x6001CF8")]
		[Address(RVA = "0x177D41C", Offset = "0x177D41C", VA = "0x177D41C", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}

		[Token(Token = "0x6001CF9")]
		[Address(RVA = "0x177D45C", Offset = "0x177D45C", VA = "0x177D45C", Slot = "7")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}
	}

	[Token(Token = "0x40020BC")]
	[FieldOffset(Offset = "0x18")]
	public bool isDebugEasy;

	[Token(Token = "0x40020BD")]
	[FieldOffset(Offset = "0x20")]
	public Transform greenWithFlag;

	[Token(Token = "0x40020BE")]
	[FieldOffset(Offset = "0x28")]
	public Rigidbody backwallPusher;

	[Token(Token = "0x40020BF")]
	[FieldOffset(Offset = "0x30")]
	public List<BusFightPart> busParts;

	[Token(Token = "0x40020C0")]
	[FieldOffset(Offset = "0x38")]
	public GolfBallController controller;

	[Token(Token = "0x40020C1")]
	[FieldOffset(Offset = "0x40")]
	public ToggleGenericRagdoll catdoll;

	[Token(Token = "0x40020C2")]
	[FieldOffset(Offset = "0x48")]
	public BusFightModuleExplosions finalExplosions;

	[Token(Token = "0x40020C3")]
	[FieldOffset(Offset = "0x50")]
	public Rigidbody car;

	[Token(Token = "0x40020C4")]
	[FieldOffset(Offset = "0x58")]
	public float curveWidth;

	[Token(Token = "0x40020C5")]
	[FieldOffset(Offset = "0x5C")]
	public float speed;

	[Token(Token = "0x40020C6")]
	[FieldOffset(Offset = "0x60")]
	public float distance;

	[Token(Token = "0x40020C7")]
	[FieldOffset(Offset = "0x68")]
	private BusFightPlayer player;

	[Token(Token = "0x40020C8")]
	[FieldOffset(Offset = "0x70")]
	private BusFightPart currentPart;

	[Token(Token = "0x40020C9")]
	[FieldOffset(Offset = "0x78")]
	private GolfCarShooter carController;

	[Token(Token = "0x40020CA")]
	[FieldOffset(Offset = "0x80")]
	private Vector3 busPosition;

	[Token(Token = "0x40020CB")]
	[FieldOffset(Offset = "0x8C")]
	private float currentSpeed;

	[Token(Token = "0x40020CC")]
	[FieldOffset(Offset = "0x90")]
	private bool isDriving;

	[Token(Token = "0x40020CD")]
	[FieldOffset(Offset = "0x94")]
	private float xMovementMultiplier;

	[Token(Token = "0x40020CE")]
	[FieldOffset(Offset = "0x98")]
	private float moveDistanceForSineMovement;

	[Token(Token = "0x40020CF")]
	[FieldOffset(Offset = "0x9C")]
	private bool isEndAnimation;

	[Token(Token = "0x40020D0")]
	[FieldOffset(Offset = "0xA0")]
	private float introBoost;

	[Token(Token = "0x40020D1")]
	[FieldOffset(Offset = "0xA4")]
	private float nextObstacleHit;

	[Token(Token = "0x40020D2")]
	[FieldOffset(Offset = "0xA8")]
	private float hitMultiplier;

	[Token(Token = "0x6001CD8")]
	[Address(RVA = "0x17D4C04", Offset = "0x17D4C04", VA = "0x17D4C04")]
	private IEnumerator Start()
	{
		return null;
	}

	[Token(Token = "0x6001CD9")]
	[Address(RVA = "0x17D4C78", Offset = "0x17D4C78", VA = "0x17D4C78")]
	private void Player_OnExploded(float obj)
	{
	}

	[Token(Token = "0x6001CDA")]
	[Address(RVA = "0x17D4CE8", Offset = "0x17D4CE8", VA = "0x17D4CE8")]
	private IEnumerator FailDelayed()
	{
		return null;
	}

	[Token(Token = "0x6001CDB")]
	[Address(RVA = "0x17D4D44", Offset = "0x17D4D44", VA = "0x17D4D44")]
	private void Player_OnHitObstacle(float extraSpeedOnObstacleCollision)
	{
	}

	[Token(Token = "0x6001CDC")]
	[Address(RVA = "0x17D4E84", Offset = "0x17D4E84", VA = "0x17D4E84")]
	private void HandleOnShoot(Vector3 obj)
	{
	}

	[Token(Token = "0x6001CDD")]
	[Address(RVA = "0x17D4FE8", Offset = "0x17D4FE8", VA = "0x17D4FE8")]
	private IEnumerator BossRoutine()
	{
		return null;
	}

	[Token(Token = "0x6001CDE")]
	[Address(RVA = "0x17D505C", Offset = "0x17D505C", VA = "0x17D505C")]
	private float GetXMovementFromZ(float z, bool useXmovementMultiplier = true)
	{
		return default;
	}

	[Token(Token = "0x6001CDF")]
	[Address(RVA = "0x17D5090", Offset = "0x17D5090", VA = "0x17D5090")]
	private float GetMoveDistanceFromForward(float forward)
	{
		return default;
	}

	[Token(Token = "0x6001CE0")]
	[Address(RVA = "0x17D5148", Offset = "0x17D5148", VA = "0x17D5148")]
	public Vector3 GetBusPositionForOffsetZ(float zOffset, bool useXmovementMultiplier = true)
	{
		return default;
	}

	[Token(Token = "0x6001CE1")]
	[Address(RVA = "0x17D5260", Offset = "0x17D5260", VA = "0x17D5260")]
	private void Update()
	{
	}

	[Token(Token = "0x6001CE2")]
	[Address(RVA = "0x17D5808", Offset = "0x17D5808", VA = "0x17D5808")]
	public BusFight()
	{
	}
}
