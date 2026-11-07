using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Chronos;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000AE7")]
public class WindArea2D : MonoBehaviour
{
	[Serializable]
	[Token(Token = "0x2000AE8")]
	public class SpecialCaseWind
	{
		[Token(Token = "0x4003CDF")]
		[FieldOffset(Offset = "0x10")]
		public LayerMask Layer;

		[Token(Token = "0x4003CE0")]
		[FieldOffset(Offset = "0x14")]
		public float ForceMod;

		[Token(Token = "0x6003419")]
		[Address(RVA = "0x187986C", Offset = "0x187986C", VA = "0x187986C")]
		public SpecialCaseWind()
		{
		}
	}

	[Token(Token = "0x2000AE9")]
	private class RigidbodyAdded
	{
		[Token(Token = "0x4003CE1")]
		[FieldOffset(Offset = "0x10")]
		public Rigidbody2D rigidbody;

		[Token(Token = "0x4003CE2")]
		[FieldOffset(Offset = "0x18")]
		public float forceRatio;

		[Token(Token = "0x600341A")]
		[Address(RVA = "0x1879864", Offset = "0x1879864", VA = "0x1879864")]
		public RigidbodyAdded()
		{
		}
	}

	[Token(Token = "0x2000AEA")]
	private class TimelineAdded
	{
		[Token(Token = "0x4003CE3")]
		[FieldOffset(Offset = "0x10")]
		public Timeline timeline;

		[Token(Token = "0x4003CE4")]
		[FieldOffset(Offset = "0x18")]
		public float forceRatio;

		[Token(Token = "0x600341B")]
		[Address(RVA = "0x1879874", Offset = "0x1879874", VA = "0x1879874")]
		public TimelineAdded()
		{
		}
	}

	[Token(Token = "0x2000AEB")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x43368", Offset = "0x43368")]
	private sealed class _003CStart_003Ed__20 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4003CE5")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x4003CE6")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x4003CE7")]
		[FieldOffset(Offset = "0x20")]
		public WindArea2D _003C_003E4__this;

		[Token(Token = "0x4003CE8")]
		[FieldOffset(Offset = "0x28")]
		private Rigidbody2D _003Crigidbody2D_003E5__2;

		[Token(Token = "0x1700055C")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x600341F")]
			[Address(RVA = "0x1879814", Offset = "0x1879814", VA = "0x1879814", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x1700055D")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6003421")]
			[Address(RVA = "0x187985C", Offset = "0x187985C", VA = "0x187985C", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x600341C")]
		[Address(RVA = "0x1879528", Offset = "0x1879528", VA = "0x1879528")]
		[DebuggerHidden]
		public _003CStart_003Ed__20(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x600341D")]
		[Address(RVA = "0x1879554", Offset = "0x1879554", VA = "0x1879554", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x600341E")]
		[Address(RVA = "0x1879558", Offset = "0x1879558", VA = "0x1879558", Slot = "6")]
		private bool MoveNext()
		{
			return default;
		}

		[Token(Token = "0x600341F")]
		[Address(RVA = "0x1879814", Offset = "0x1879814", VA = "0x1879814", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x6003420")]
		[Address(RVA = "0x187981C", Offset = "0x187981C", VA = "0x187981C", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}

		[Token(Token = "0x6003421")]
		[Address(RVA = "0x187985C", Offset = "0x187985C", VA = "0x187985C", Slot = "7")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}
	}

	[Token(Token = "0x2000AEC")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x43378", Offset = "0x43378")]
	private sealed class _003C_003Ec__DisplayClass21_0
	{
		[Token(Token = "0x4003CE9")]
		[FieldOffset(Offset = "0x10")]
		public Rigidbody2D rigid;

		[Token(Token = "0x4003CEA")]
		[FieldOffset(Offset = "0x18")]
		public Timeline rigidTimeline;

		[Token(Token = "0x6003422")]
		[Address(RVA = "0x1879128", Offset = "0x1879128", VA = "0x1879128")]
		public _003C_003Ec__DisplayClass21_0()
		{
		}

		[Token(Token = "0x6003423")]
		[Address(RVA = "0x1879130", Offset = "0x1879130", VA = "0x1879130")]
		internal bool _003CBall_OnDisabled_003Eb__0(RigidbodyAdded addedRigidbody)
		{
			return default;
		}

		[Token(Token = "0x6003424")]
		[Address(RVA = "0x18791C0", Offset = "0x18791C0", VA = "0x18791C0")]
		internal bool _003CBall_OnDisabled_003Eb__1(TimelineAdded addedTimeline)
		{
			return default;
		}
	}

	[Token(Token = "0x2000AED")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x43388", Offset = "0x43388")]
	private sealed class _003C_003Ec__DisplayClass28_0
	{
		[Token(Token = "0x4003CEB")]
		[FieldOffset(Offset = "0x10")]
		public Collider2D other;

		[Token(Token = "0x6003425")]
		[Address(RVA = "0x1879250", Offset = "0x1879250", VA = "0x1879250")]
		public _003C_003Ec__DisplayClass28_0()
		{
		}

		[Token(Token = "0x6003426")]
		[Address(RVA = "0x1879258", Offset = "0x1879258", VA = "0x1879258")]
		internal bool _003COnTriggerEnter2D_003Eb__0(SpecialCaseWind s)
		{
			return default;
		}
	}

	[Token(Token = "0x2000AEE")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x43398", Offset = "0x43398")]
	private sealed class _003CDelayedDrag_003Ed__29 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4003CEC")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x4003CED")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x4003CEE")]
		[FieldOffset(Offset = "0x20")]
		public RigidbodyTimeline2D rigid;

		[Token(Token = "0x4003CEF")]
		[FieldOffset(Offset = "0x28")]
		public WindArea2D _003C_003E4__this;

		[Token(Token = "0x1700055E")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x600342A")]
			[Address(RVA = "0x18794D8", Offset = "0x18794D8", VA = "0x18794D8", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x1700055F")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x600342C")]
			[Address(RVA = "0x1879520", Offset = "0x1879520", VA = "0x1879520", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x6003427")]
		[Address(RVA = "0x187940C", Offset = "0x187940C", VA = "0x187940C")]
		[DebuggerHidden]
		public _003CDelayedDrag_003Ed__29(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6003428")]
		[Address(RVA = "0x1879438", Offset = "0x1879438", VA = "0x1879438", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6003429")]
		[Address(RVA = "0x187943C", Offset = "0x187943C", VA = "0x187943C", Slot = "6")]
		private bool MoveNext()
		{
			return default;
		}

		[Token(Token = "0x600342A")]
		[Address(RVA = "0x18794D8", Offset = "0x18794D8", VA = "0x18794D8", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x600342B")]
		[Address(RVA = "0x18794E0", Offset = "0x18794E0", VA = "0x18794E0", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}

		[Token(Token = "0x600342C")]
		[Address(RVA = "0x1879520", Offset = "0x1879520", VA = "0x1879520", Slot = "7")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}
	}

	[Token(Token = "0x2000AEF")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x433A8", Offset = "0x433A8")]
	private sealed class _003C_003Ec__DisplayClass31_0
	{
		[Token(Token = "0x4003CF0")]
		[FieldOffset(Offset = "0x10")]
		public Collider2D other;

		[Token(Token = "0x600342D")]
		[Address(RVA = "0x18792D8", Offset = "0x18792D8", VA = "0x18792D8")]
		public _003C_003Ec__DisplayClass31_0()
		{
		}

		[Token(Token = "0x600342E")]
		[Address(RVA = "0x18792E0", Offset = "0x18792E0", VA = "0x18792E0")]
		internal bool _003COnTriggerExit2D_003Eb__0(RigidbodyAdded addedRigidbody)
		{
			return default;
		}
	}

	[Token(Token = "0x2000AF0")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x433B8", Offset = "0x433B8")]
	private sealed class _003C_003Ec__DisplayClass31_1
	{
		[Token(Token = "0x4003CF1")]
		[FieldOffset(Offset = "0x10")]
		public Timeline t;

		[Token(Token = "0x600342F")]
		[Address(RVA = "0x1879374", Offset = "0x1879374", VA = "0x1879374")]
		public _003C_003Ec__DisplayClass31_1()
		{
		}

		[Token(Token = "0x6003430")]
		[Address(RVA = "0x187937C", Offset = "0x187937C", VA = "0x187937C")]
		internal bool _003COnTriggerExit2D_003Eb__1(TimelineAdded addedTimeline)
		{
			return default;
		}
	}

	[Token(Token = "0x4003CCE")]
	[FieldOffset(Offset = "0x18")]
	public ForceMode2D ForceMode;

	[Token(Token = "0x4003CCF")]
	[FieldOffset(Offset = "0x1C")]
	public Vector2 WindForce;

	[Token(Token = "0x4003CD0")]
	[FieldOffset(Offset = "0x24")]
	public bool isUsingTargetAsGravity;

	[Token(Token = "0x4003CD1")]
	[FieldOffset(Offset = "0x28")]
	public Transform gravityTarget;

	[Token(Token = "0x4003CD2")]
	[FieldOffset(Offset = "0x30")]
	public bool isMinimizingDrag;

	[Token(Token = "0x4003CD3")]
	[FieldOffset(Offset = "0x34")]
	public float inZoneDragMultiplier;

	[Token(Token = "0x4003CD4")]
	[FieldOffset(Offset = "0x38")]
	public float OverrideDragValue;

	[Token(Token = "0x4003CD5")]
	[FieldOffset(Offset = "0x3C")]
	public float OverrideMassValue;

	[Token(Token = "0x4003CD6")]
	[FieldOffset(Offset = "0x40")]
	public int inAirShots;

	[Token(Token = "0x4003CD7")]
	[FieldOffset(Offset = "0x44")]
	public bool playGravitySwitchSfxOnBall;

	[Token(Token = "0x4003CD8")]
	[FieldOffset(Offset = "0x48")]
	public List<SpecialCaseWind> SpecialCases;

	[Token(Token = "0x4003CD9")]
	[FieldOffset(Offset = "0x50")]
	private List<RigidbodyAdded> added;

	[Token(Token = "0x4003CDA")]
	[FieldOffset(Offset = "0x58")]
	private List<TimelineAdded> addedTimelines;

	[Token(Token = "0x4003CDB")]
	[FieldOffset(Offset = "0x60")]
	private float baseBallDrag;

	[Token(Token = "0x4003CDC")]
	[FieldOffset(Offset = "0x64")]
	private float baseBallMass;

	[Token(Token = "0x4003CDD")]
	[FieldOffset(Offset = "0x68")]
	private float targetDrag;

	[Token(Token = "0x4003CDE")]
	[FieldOffset(Offset = "0x70")]
	private List<Timeline> destroyedTimelines;

	[Token(Token = "0x600340C")]
	[Address(RVA = "0x17570DC", Offset = "0x17570DC", VA = "0x17570DC")]
	private void Awake()
	{
	}

	[Token(Token = "0x600340D")]
	[Address(RVA = "0x175719C", Offset = "0x175719C", VA = "0x175719C")]
	private IEnumerator Start()
	{
		return null;
	}

	[Token(Token = "0x600340E")]
	[Address(RVA = "0x1757210", Offset = "0x1757210", VA = "0x1757210")]
	private void Ball_OnDisabled(OverworldBall2D ball)
	{
	}

	[Token(Token = "0x600340F")]
	[Address(RVA = "0x17574C8", Offset = "0x17574C8", VA = "0x17574C8")]
	private void Instance_OnNewBall(Transmogrif.BALLSHAPES newShape)
	{
	}

	[Token(Token = "0x6003410")]
	[Address(RVA = "0x17575F0", Offset = "0x17575F0", VA = "0x17575F0")]
	private Vector2 GetWindForce(Vector2 from)
	{
		return default;
	}

	[Token(Token = "0x6003411")]
	[Address(RVA = "0x17576A4", Offset = "0x17576A4", VA = "0x17576A4")]
	private void FixedUpdate()
	{
	}

	[Token(Token = "0x6003412")]
	[Address(RVA = "0x1757A70", Offset = "0x1757A70", VA = "0x1757A70")]
	private bool IsAdded(Timeline timeline)
	{
		return default;
	}

	[Token(Token = "0x6003413")]
	[Address(RVA = "0x1757B74", Offset = "0x1757B74", VA = "0x1757B74")]
	private bool IsAdded(Rigidbody2D rigidbody)
	{
		return default;
	}

	[Token(Token = "0x6003414")]
	[Address(RVA = "0x1757C78", Offset = "0x1757C78", VA = "0x1757C78")]
	private void OnTriggerEnter2D(Collider2D other)
	{
	}

	[Token(Token = "0x6003415")]
	[Address(RVA = "0x1758140", Offset = "0x1758140", VA = "0x1758140")]
	private IEnumerator DelayedDrag(RigidbodyTimeline2D rigid)
	{
		return null;
	}

	[Token(Token = "0x6003416")]
	[Address(RVA = "0x17581B8", Offset = "0x17581B8", VA = "0x17581B8")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x6003417")]
	[Address(RVA = "0x1758230", Offset = "0x1758230", VA = "0x1758230")]
	private void OnTriggerExit2D(Collider2D other)
	{
	}

	[Token(Token = "0x6003418")]
	[Address(RVA = "0x17585D0", Offset = "0x17585D0", VA = "0x17585D0")]
	public WindArea2D()
	{
	}
}
