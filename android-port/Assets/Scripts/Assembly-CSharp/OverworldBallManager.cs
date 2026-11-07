using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Chronos;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000AB0")]
public class OverworldBallManager : MonoBehaviour
{
	[Token(Token = "0x2000AB1")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x42F50", Offset = "0x42F50")]
	private sealed class _003C_003Ec__DisplayClass27_0
	{
		[Token(Token = "0x4003B81")]
		[FieldOffset(Offset = "0x10")]
		public OverworldBallManager _003C_003E4__this;

		[Token(Token = "0x4003B82")]
		[FieldOffset(Offset = "0x18")]
		public Vector3 oldPos;

		[Token(Token = "0x4003B83")]
		[FieldOffset(Offset = "0x28")]
		public Transmogrif grif;

		[Token(Token = "0x600331E")]
		[Address(RVA = "0x180C3D0", Offset = "0x180C3D0", VA = "0x180C3D0")]
		public _003C_003Ec__DisplayClass27_0()
		{
		}

		[Token(Token = "0x600331F")]
		[Address(RVA = "0x180C3D8", Offset = "0x180C3D8", VA = "0x180C3D8")]
		internal void _003CTransmogrifRoutine_003Eb__0(float t)
		{
		}
	}

	[Token(Token = "0x2000AB2")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x42F60", Offset = "0x42F60")]
	private sealed class _003CTransmogrifRoutine_003Ed__27 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4003B84")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x4003B85")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x4003B86")]
		[FieldOffset(Offset = "0x20")]
		public OverworldBallManager _003C_003E4__this;

		[Token(Token = "0x4003B87")]
		[FieldOffset(Offset = "0x28")]
		public Transmogrif grif;

		[Token(Token = "0x4003B88")]
		[FieldOffset(Offset = "0x30")]
		public Transmogriffable ball;

		[Token(Token = "0x4003B89")]
		[FieldOffset(Offset = "0x38")]
		private _003C_003Ec__DisplayClass27_0 _003C_003E8__1;

		[Token(Token = "0x17000549")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6003323")]
			[Address(RVA = "0x180CD10", Offset = "0x180CD10", VA = "0x180CD10", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x1700054A")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6003325")]
			[Address(RVA = "0x180CD58", Offset = "0x180CD58", VA = "0x180CD58", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x6003320")]
		[Address(RVA = "0x180C4A0", Offset = "0x180C4A0", VA = "0x180C4A0")]
		[DebuggerHidden]
		public _003CTransmogrifRoutine_003Ed__27(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6003321")]
		[Address(RVA = "0x180C4CC", Offset = "0x180C4CC", VA = "0x180C4CC", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6003322")]
		[Address(RVA = "0x180C4D0", Offset = "0x180C4D0", VA = "0x180C4D0", Slot = "6")]
		private bool MoveNext()
		{
			return default;
		}

		[Token(Token = "0x6003323")]
		[Address(RVA = "0x180CD10", Offset = "0x180CD10", VA = "0x180CD10", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x6003324")]
		[Address(RVA = "0x180CD18", Offset = "0x180CD18", VA = "0x180CD18", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}

		[Token(Token = "0x6003325")]
		[Address(RVA = "0x180CD58", Offset = "0x180CD58", VA = "0x180CD58", Slot = "7")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}
	}

	[Token(Token = "0x4003B76")]
	[FieldOffset(Offset = "0x0")]
	private static OverworldBallManager _Instance;

	[Token(Token = "0x4003B77")]
	[FieldOffset(Offset = "0x18")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x505F8", Offset = "0x505F8")]
	private Action<OverworldBall2D> m_OnDeath;

	[Token(Token = "0x4003B78")]
	[FieldOffset(Offset = "0x20")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x50608", Offset = "0x50608")]
	private Action<Transmogrif.BALLSHAPES> m_OnNewBall;

	[Token(Token = "0x4003B79")]
	[FieldOffset(Offset = "0x28")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x50618", Offset = "0x50618")]
	private Action<Transmogrif> m_OnTransmoGriffed;

	[Token(Token = "0x4003B7A")]
	[FieldOffset(Offset = "0x30")]
	public OverworldBall2D Ball;

	[Token(Token = "0x4003B7B")]
	[FieldOffset(Offset = "0x38")]
	public float minYVelocity;

	[Token(Token = "0x4003B7C")]
	[FieldOffset(Offset = "0x40")]
	public List<Transmogriffable> balls;

	[Token(Token = "0x4003B7D")]
	[FieldOffset(Offset = "0x48")]
	public GlobalClock clock;

	[Token(Token = "0x4003B7E")]
	[FieldOffset(Offset = "0x50")]
	public OverworldBallFollower ballProxy;

	[Token(Token = "0x4003B7F")]
	[FieldOffset(Offset = "0x58")]
	public Transmogrif.BALLSHAPES currentShape;

	[Token(Token = "0x4003B80")]
	[FieldOffset(Offset = "0x60")]
	private TimeControl timeControl;

	[Token(Token = "0x17000547")]
	public static OverworldBallManager Instance
	{
		[Token(Token = "0x600330D")]
		[Address(RVA = "0x15A3944", Offset = "0x15A3944", VA = "0x15A3944")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000548")]
	public static bool HasInstance
	{
		[Token(Token = "0x600330E")]
		[Address(RVA = "0x15A442C", Offset = "0x15A442C", VA = "0x15A442C")]
		get
		{
			return default;
		}
	}

	[Token(Token = "0x1400006A")]
	public event Action<OverworldBall2D> OnDeath
	{
		[Token(Token = "0x600330F")]
		[Address(RVA = "0x15A44C0", Offset = "0x15A44C0", VA = "0x15A44C0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6A194", Offset = "0x6A194")]
		add
		{
		}
		[Token(Token = "0x6003310")]
		[Address(RVA = "0x15A4564", Offset = "0x15A4564", VA = "0x15A4564")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6A1A4", Offset = "0x6A1A4")]
		remove
		{
		}
	}

	[Token(Token = "0x1400006B")]
	public event Action<Transmogrif.BALLSHAPES> OnNewBall
	{
		[Token(Token = "0x6003311")]
		[Address(RVA = "0x15A3A2C", Offset = "0x15A3A2C", VA = "0x15A3A2C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6A1B4", Offset = "0x6A1B4")]
		add
		{
		}
		[Token(Token = "0x6003312")]
		[Address(RVA = "0x15A4608", Offset = "0x15A4608", VA = "0x15A4608")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6A1C4", Offset = "0x6A1C4")]
		remove
		{
		}
	}

	[Token(Token = "0x1400006C")]
	public event Action<Transmogrif> OnTransmoGriffed
	{
		[Token(Token = "0x6003313")]
		[Address(RVA = "0x15A46AC", Offset = "0x15A46AC", VA = "0x15A46AC")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6A1D4", Offset = "0x6A1D4")]
		add
		{
		}
		[Token(Token = "0x6003314")]
		[Address(RVA = "0x15A4750", Offset = "0x15A4750", VA = "0x15A4750")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6A1E4", Offset = "0x6A1E4")]
		remove
		{
		}
	}

	[Token(Token = "0x6003315")]
	[Address(RVA = "0x15A47F4", Offset = "0x15A47F4", VA = "0x15A47F4")]
	[AttributeAttribute(Name = "RuntimeInitializeOnLoadMethodAttribute", RVA = "0x6A1F4", Offset = "0x6A1F4")]
	private static void Init()
	{
	}

	[Token(Token = "0x6003316")]
	[Address(RVA = "0x15A4840", Offset = "0x15A4840", VA = "0x15A4840")]
	public void Initialize()
	{
	}

	[Token(Token = "0x6003317")]
	[Address(RVA = "0x15A4C9C", Offset = "0x15A4C9C", VA = "0x15A4C9C")]
	public void Load(Transmogrif.BALLSHAPES shape)
	{
	}

	[Token(Token = "0x6003318")]
	[Address(RVA = "0x15A528C", Offset = "0x15A528C", VA = "0x15A528C")]
	private void Ball_OnDeath(OverworldBall2D obj)
	{
	}

	[Token(Token = "0x6003319")]
	[Address(RVA = "0x15A52FC", Offset = "0x15A52FC", VA = "0x15A52FC")]
	public int GetCurrentShapeAsInt()
	{
		return default;
	}

	[Token(Token = "0x600331A")]
	[Address(RVA = "0x15A53DC", Offset = "0x15A53DC", VA = "0x15A53DC")]
	private void Transmogriffable_OnTransmogriffed(Transmogriffable ball, Transmogrif grif)
	{
	}

	[Token(Token = "0x600331B")]
	[Address(RVA = "0x15A546C", Offset = "0x15A546C", VA = "0x15A546C")]
	private IEnumerator TransmogrifRoutine(Transmogriffable ball, Transmogrif grif)
	{
		return null;
	}

	[Token(Token = "0x600331C")]
	[Address(RVA = "0x15A5014", Offset = "0x15A5014", VA = "0x15A5014")]
	private Transmogriffable ChangeBall(Transmogriffable ball, Transmogrif.BALLSHAPES targetShape)
	{
		return null;
	}

	[Token(Token = "0x600331D")]
	[Address(RVA = "0x15A54F4", Offset = "0x15A54F4", VA = "0x15A54F4")]
	public OverworldBallManager()
	{
	}
}
