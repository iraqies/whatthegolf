using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Audio;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x200069E")]
public class SHMUPFrogKing : MonoBehaviour
{
	[Token(Token = "0x200069F")]
	private class WeightedRandomBag<T>
	{
		[Token(Token = "0x20006A0")]
		private struct Entry
		{
			[Token(Token = "0x40022AD")]
			[FieldOffset(Offset = "0x0")]
			public double accumulatedWeight;

			[Token(Token = "0x40022AE")]
			[FieldOffset(Offset = "0x0")]
			public T item;
		}

		[Token(Token = "0x40022AB")]
		[FieldOffset(Offset = "0x0")]
		private List<Entry> entries;

		[Token(Token = "0x40022AC")]
		[FieldOffset(Offset = "0x0")]
		private float accumulatedWeight;

		[Token(Token = "0x6001E6C")]
		public void AddEntry(T item, float weight)
		{
		}

		[Token(Token = "0x6001E6D")]
		public T GetRandom()
		{
			return (T)null;
		}

		[Token(Token = "0x6001E6E")]
		public WeightedRandomBag()
		{
		}
	}

	[Token(Token = "0x20006A1")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x40F60", Offset = "0x40F60")]
	private sealed class _003CWaveRoutine_003Ed__41 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40022AF")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x40022B0")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x40022B1")]
		[FieldOffset(Offset = "0x20")]
		public SHMUPFrogKing _003C_003E4__this;

		[Token(Token = "0x17000377")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6001E72")]
			[Address(RVA = "0x183897C", Offset = "0x183897C", VA = "0x183897C", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x17000378")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6001E74")]
			[Address(RVA = "0x18389C4", Offset = "0x18389C4", VA = "0x18389C4", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x6001E6F")]
		[Address(RVA = "0x1838728", Offset = "0x1838728", VA = "0x1838728")]
		[DebuggerHidden]
		public _003CWaveRoutine_003Ed__41(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6001E70")]
		[Address(RVA = "0x1838754", Offset = "0x1838754", VA = "0x1838754", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6001E71")]
		[Address(RVA = "0x1838758", Offset = "0x1838758", VA = "0x1838758", Slot = "6")]
		private bool MoveNext()
		{
			return default;
		}

		[Token(Token = "0x6001E72")]
		[Address(RVA = "0x183897C", Offset = "0x183897C", VA = "0x183897C", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x6001E73")]
		[Address(RVA = "0x1838984", Offset = "0x1838984", VA = "0x1838984", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}

		[Token(Token = "0x6001E74")]
		[Address(RVA = "0x18389C4", Offset = "0x18389C4", VA = "0x18389C4", Slot = "7")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}
	}

	[Token(Token = "0x20006A2")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x40F70", Offset = "0x40F70")]
	private sealed class _003CWaitForPlayerShot_003Ed__45 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40022B2")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x40022B3")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x40022B4")]
		[FieldOffset(Offset = "0x20")]
		public SHMUPFrogKing _003C_003E4__this;

		[Token(Token = "0x40022B5")]
		[FieldOffset(Offset = "0x28")]
		public GameObject ball;

		[Token(Token = "0x17000379")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6001E78")]
			[Address(RVA = "0x18386D8", Offset = "0x18386D8", VA = "0x18386D8", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x1700037A")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6001E7A")]
			[Address(RVA = "0x1838720", Offset = "0x1838720", VA = "0x1838720", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x6001E75")]
		[Address(RVA = "0x183861C", Offset = "0x183861C", VA = "0x183861C")]
		[DebuggerHidden]
		public _003CWaitForPlayerShot_003Ed__45(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6001E76")]
		[Address(RVA = "0x1838648", Offset = "0x1838648", VA = "0x1838648", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6001E77")]
		[Address(RVA = "0x183864C", Offset = "0x183864C", VA = "0x183864C", Slot = "6")]
		private bool MoveNext()
		{
			return default;
		}

		[Token(Token = "0x6001E78")]
		[Address(RVA = "0x18386D8", Offset = "0x18386D8", VA = "0x18386D8", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x6001E79")]
		[Address(RVA = "0x18386E0", Offset = "0x18386E0", VA = "0x18386E0", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}

		[Token(Token = "0x6001E7A")]
		[Address(RVA = "0x1838720", Offset = "0x1838720", VA = "0x1838720", Slot = "7")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}
	}

	[Token(Token = "0x20006A3")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x40F80", Offset = "0x40F80")]
	private sealed class _003CHurtRoutine_003Ed__46 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40022B6")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x40022B7")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x40022B8")]
		[FieldOffset(Offset = "0x20")]
		public SHMUPFrogKing _003C_003E4__this;

		[Token(Token = "0x1700037B")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6001E7E")]
			[Address(RVA = "0x18385CC", Offset = "0x18385CC", VA = "0x18385CC", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x1700037C")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6001E80")]
			[Address(RVA = "0x1838614", Offset = "0x1838614", VA = "0x1838614", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x6001E7B")]
		[Address(RVA = "0x1838390", Offset = "0x1838390", VA = "0x1838390")]
		[DebuggerHidden]
		public _003CHurtRoutine_003Ed__46(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6001E7C")]
		[Address(RVA = "0x18383BC", Offset = "0x18383BC", VA = "0x18383BC", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6001E7D")]
		[Address(RVA = "0x18383C0", Offset = "0x18383C0", VA = "0x18383C0", Slot = "6")]
		private bool MoveNext()
		{
			return default;
		}

		[Token(Token = "0x6001E7E")]
		[Address(RVA = "0x18385CC", Offset = "0x18385CC", VA = "0x18385CC", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x6001E7F")]
		[Address(RVA = "0x18385D4", Offset = "0x18385D4", VA = "0x18385D4", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}

		[Token(Token = "0x6001E80")]
		[Address(RVA = "0x1838614", Offset = "0x1838614", VA = "0x1838614", Slot = "7")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}
	}

	[Token(Token = "0x400228E")]
	[FieldOffset(Offset = "0x18")]
	public Vector2 MoveSpeed;

	[Token(Token = "0x400228F")]
	[FieldOffset(Offset = "0x20")]
	public float MoveWarmupTime;

	[Token(Token = "0x4002290")]
	[FieldOffset(Offset = "0x24")]
	public Vector2 RangeX;

	[Token(Token = "0x4002291")]
	[FieldOffset(Offset = "0x30")]
	public List<FrogKingBaseWave> WaveTypes;

	[Token(Token = "0x4002292")]
	[FieldOffset(Offset = "0x38")]
	public FrogKingBaseWave BallWave;

	[Token(Token = "0x4002293")]
	[FieldOffset(Offset = "0x40")]
	public int BallWaveCooldown;

	[Token(Token = "0x4002294")]
	[FieldOffset(Offset = "0x48")]
	public SkinnedMeshRenderer FrogModel;

	[Token(Token = "0x4002295")]
	[FieldOffset(Offset = "0x50")]
	public Material NormalMaterial;

	[Token(Token = "0x4002296")]
	[FieldOffset(Offset = "0x58")]
	public Material HitMaterial;

	[Token(Token = "0x4002297")]
	[FieldOffset(Offset = "0x60")]
	public Material HurtMaterial;

	[Token(Token = "0x4002298")]
	[FieldOffset(Offset = "0x68")]
	public float HurtTime;

	[Token(Token = "0x4002299")]
	[FieldOffset(Offset = "0x6C")]
	public float HitTime;

	[Token(Token = "0x400229A")]
	[FieldOffset(Offset = "0x70")]
	public int Health;

	[Token(Token = "0x400229B")]
	[FieldOffset(Offset = "0x78")]
	public Animator FrogKingAnimator;

	[Token(Token = "0x400229C")]
	[FieldOffset(Offset = "0x80")]
	public ClipSettingsCollection hurtSFX;

	[Token(Token = "0x400229D")]
	[FieldOffset(Offset = "0x88")]
	public bool InWebPhase;

	[Token(Token = "0x400229E")]
	[FieldOffset(Offset = "0x8C")]
	public float WebPhaseMoveSpeed;

	[Token(Token = "0x400229F")]
	[FieldOffset(Offset = "0x90")]
	public Transform WebPlayer;

	[Token(Token = "0x40022A0")]
	[FieldOffset(Offset = "0x98")]
	private FrogKingBaseWave currentStateRoutine;

	[Token(Token = "0x40022A1")]
	[FieldOffset(Offset = "0xA0")]
	private float currentSpeed;

	[Token(Token = "0x40022A2")]
	[FieldOffset(Offset = "0xA8")]
	private Rigidbody rigid;

	[Token(Token = "0x40022A3")]
	[FieldOffset(Offset = "0xB0")]
	private WeightedRandomBag<FrogKingBaseWave> weightedBag;

	[Token(Token = "0x40022A4")]
	[FieldOffset(Offset = "0xB8")]
	private int waveNumber;

	[Token(Token = "0x40022A5")]
	[FieldOffset(Offset = "0xBC")]
	private float xPosition;

	[Token(Token = "0x40022A6")]
	[FieldOffset(Offset = "0xC0")]
	private Material origMaterial;

	[Token(Token = "0x40022A7")]
	[FieldOffset(Offset = "0xC8")]
	private Vector3 startPos;

	[Token(Token = "0x40022A8")]
	[FieldOffset(Offset = "0xD4")]
	private bool playerIsResetting;

	[Token(Token = "0x40022A9")]
	[FieldOffset(Offset = "0xD5")]
	private bool canStartNewWave;

	[Token(Token = "0x40022AA")]
	[FieldOffset(Offset = "0xD8")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x4E4F4", Offset = "0x4E4F4")]
	private int HitsTaken__BackingField;

	[Token(Token = "0x17000375")]
	public int HitsTaken
	{
		[Token(Token = "0x6001E5D")]
		[Address(RVA = "0x16682B8", Offset = "0x16682B8", VA = "0x16682B8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x64E9C", Offset = "0x64E9C")]
		get
		{
			return default;
		}
		[Token(Token = "0x6001E5E")]
		[Address(RVA = "0x16682C0", Offset = "0x16682C0", VA = "0x16682C0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x64EAC", Offset = "0x64EAC")]
		set
		{
		}
	}

	[Token(Token = "0x17000376")]
	public bool IsAlive
	{
		[Token(Token = "0x6001E5F")]
		[Address(RVA = "0x16678FC", Offset = "0x16678FC", VA = "0x16678FC")]
		get
		{
			return default;
		}
	}

	[Token(Token = "0x6001E60")]
	[Address(RVA = "0x16682C8", Offset = "0x16682C8", VA = "0x16682C8")]
	public void Initialize()
	{
	}

	[Token(Token = "0x6001E61")]
	[Address(RVA = "0x16684B0", Offset = "0x16684B0", VA = "0x16684B0")]
	private void Start()
	{
	}

	[Token(Token = "0x6001E62")]
	[Address(RVA = "0x16685BC", Offset = "0x16685BC", VA = "0x16685BC")]
	private void FixedUpdate()
	{
	}

	[Token(Token = "0x6001E63")]
	[Address(RVA = "0x16687A8", Offset = "0x16687A8", VA = "0x16687A8")]
	public void PlayerIsAboutToReset()
	{
	}

	[Token(Token = "0x6001E64")]
	[Address(RVA = "0x16687B4", Offset = "0x16687B4", VA = "0x16687B4")]
	public void SinkReset()
	{
	}

	[Token(Token = "0x6001E65")]
	[Address(RVA = "0x1668968", Offset = "0x1668968", VA = "0x1668968")]
	public void SinkResetAfter()
	{
	}

	[Token(Token = "0x6001E66")]
	[Address(RVA = "0x1668548", Offset = "0x1668548", VA = "0x1668548")]
	private IEnumerator WaveRoutine()
	{
		return null;
	}

	[Token(Token = "0x6001E67")]
	[Address(RVA = "0x1668974", Offset = "0x1668974", VA = "0x1668974")]
	private FrogKingBaseWave GetNextState()
	{
		return null;
	}

	[Token(Token = "0x6001E68")]
	[Address(RVA = "0x16689F4", Offset = "0x16689F4", VA = "0x16689F4")]
	private void OnTriggerEnter(Collider other)
	{
	}

	[Token(Token = "0x6001E69")]
	[Address(RVA = "0x1668C18", Offset = "0x1668C18", VA = "0x1668C18")]
	public IEnumerator WaitForPlayerShot(GameObject ball)
	{
		return null;
	}

	[Token(Token = "0x6001E6A")]
	[Address(RVA = "0x1668BA4", Offset = "0x1668BA4", VA = "0x1668BA4")]
	private IEnumerator HurtRoutine()
	{
		return null;
	}

	[Token(Token = "0x6001E6B")]
	[Address(RVA = "0x1668C90", Offset = "0x1668C90", VA = "0x1668C90")]
	public SHMUPFrogKing()
	{
	}
}
