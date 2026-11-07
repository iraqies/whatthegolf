using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Audio;
using Core;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000F1F")]
public class ReplicatingFruitsShooter : ShooterBase
{
	[Token(Token = "0x2000F20")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x456E0", Offset = "0x456E0")]
	private sealed class _003C_003Ec__DisplayClass16_0
	{
		[Token(Token = "0x400519D")]
		[FieldOffset(Offset = "0x10")]
		public GameObject instantiatedFruit;

		[Token(Token = "0x400519E")]
		[FieldOffset(Offset = "0x18")]
		public Vector3 end;

		[Token(Token = "0x400519F")]
		[FieldOffset(Offset = "0x28")]
		public ReplicatingFruitsShooter _003C_003E4__this;

		[Token(Token = "0x60046B7")]
		[Address(RVA = "0x1833320", Offset = "0x1833320", VA = "0x1833320")]
		public _003C_003Ec__DisplayClass16_0()
		{
		}

		[Token(Token = "0x60046B8")]
		[Address(RVA = "0x1833328", Offset = "0x1833328", VA = "0x1833328")]
		internal void _003CShootFruits_003Eb__0(float t)
		{
		}
	}

	[Token(Token = "0x2000F21")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x456F0", Offset = "0x456F0")]
	private sealed class _003CShootFruits_003Ed__16 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40051A0")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x40051A1")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x40051A2")]
		[FieldOffset(Offset = "0x20")]
		public Vector3 boost;

		[Token(Token = "0x40051A3")]
		[FieldOffset(Offset = "0x30")]
		public ReplicatingFruitsShooter _003C_003E4__this;

		[Token(Token = "0x40051A4")]
		[FieldOffset(Offset = "0x38")]
		private Vector3 _003CaimDir_003E5__2;

		[Token(Token = "0x40051A5")]
		[FieldOffset(Offset = "0x44")]
		private int _003CnumberOfFruitsToSpawn_003E5__3;

		[Token(Token = "0x40051A6")]
		[FieldOffset(Offset = "0x48")]
		private int _003Ci_003E5__4;

		[Token(Token = "0x17000750")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x60046BC")]
			[Address(RVA = "0x1833D20", Offset = "0x1833D20", VA = "0x1833D20", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x17000751")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x60046BE")]
			[Address(RVA = "0x1833D68", Offset = "0x1833D68", VA = "0x1833D68", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x60046B9")]
		[Address(RVA = "0x1833740", Offset = "0x1833740", VA = "0x1833740")]
		[DebuggerHidden]
		public _003CShootFruits_003Ed__16(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x60046BA")]
		[Address(RVA = "0x183376C", Offset = "0x183376C", VA = "0x183376C", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x60046BB")]
		[Address(RVA = "0x1833770", Offset = "0x1833770", VA = "0x1833770", Slot = "6")]
		private bool MoveNext()
		{
			return default;
		}

		[Token(Token = "0x60046BC")]
		[Address(RVA = "0x1833D20", Offset = "0x1833D20", VA = "0x1833D20", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x60046BD")]
		[Address(RVA = "0x1833D28", Offset = "0x1833D28", VA = "0x1833D28", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}

		[Token(Token = "0x60046BE")]
		[Address(RVA = "0x1833D68", Offset = "0x1833D68", VA = "0x1833D68", Slot = "7")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}
	}

	[Token(Token = "0x2000F22")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x45700", Offset = "0x45700")]
	private sealed class _003C_003Ec__DisplayClass17_0
	{
		[Token(Token = "0x40051A7")]
		[FieldOffset(Offset = "0x10")]
		public Vector3 start;

		[Token(Token = "0x40051A8")]
		[FieldOffset(Offset = "0x20")]
		public ReplicatingFruitsShooter _003C_003E4__this;

		[Token(Token = "0x60046BF")]
		[Address(RVA = "0x18334B4", Offset = "0x18334B4", VA = "0x18334B4")]
		public _003C_003Ec__DisplayClass17_0()
		{
		}

		[Token(Token = "0x60046C0")]
		[Address(RVA = "0x18334BC", Offset = "0x18334BC", VA = "0x18334BC")]
		internal void _003CDestroyFruit_003Eb__0(float t)
		{
		}
	}

	[Token(Token = "0x2000F23")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x45710", Offset = "0x45710")]
	private sealed class _003CDestroyFruit_003Ed__17 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40051A9")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x40051AA")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x40051AB")]
		[FieldOffset(Offset = "0x20")]
		public ReplicatingFruitsShooter _003C_003E4__this;

		[Token(Token = "0x40051AC")]
		[FieldOffset(Offset = "0x28")]
		public GameObject fruit;

		[Token(Token = "0x17000752")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x60046C4")]
			[Address(RVA = "0x18336F0", Offset = "0x18336F0", VA = "0x18336F0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x17000753")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x60046C6")]
			[Address(RVA = "0x1833738", Offset = "0x1833738", VA = "0x1833738", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x60046C1")]
		[Address(RVA = "0x1833510", Offset = "0x1833510", VA = "0x1833510")]
		[DebuggerHidden]
		public _003CDestroyFruit_003Ed__17(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x60046C2")]
		[Address(RVA = "0x183353C", Offset = "0x183353C", VA = "0x183353C", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x60046C3")]
		[Address(RVA = "0x1833540", Offset = "0x1833540", VA = "0x1833540", Slot = "6")]
		private bool MoveNext()
		{
			return default;
		}

		[Token(Token = "0x60046C4")]
		[Address(RVA = "0x18336F0", Offset = "0x18336F0", VA = "0x18336F0", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x60046C5")]
		[Address(RVA = "0x18336F8", Offset = "0x18336F8", VA = "0x18336F8", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}

		[Token(Token = "0x60046C6")]
		[Address(RVA = "0x1833738", Offset = "0x1833738", VA = "0x1833738", Slot = "7")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}
	}

	[Token(Token = "0x400518F")]
	[FieldOffset(Offset = "0x20")]
	public Rigidbody controller_rb;

	[Token(Token = "0x4005190")]
	[FieldOffset(Offset = "0x28")]
	public GameObject[] objectsList;

	[Token(Token = "0x4005191")]
	[FieldOffset(Offset = "0x30")]
	public int maxNumberOfFruits;

	[Token(Token = "0x4005192")]
	[FieldOffset(Offset = "0x34")]
	public int maxNumberOfFruitChain;

	[Token(Token = "0x4005193")]
	[FieldOffset(Offset = "0x38")]
	public float distanceBetweenFruits;

	[Token(Token = "0x4005194")]
	[FieldOffset(Offset = "0x3C")]
	public bool randomRotation;

	[Token(Token = "0x4005195")]
	[FieldOffset(Offset = "0x40")]
	private Animator animator;

	[Token(Token = "0x4005196")]
	[FieldOffset(Offset = "0x48")]
	private GolfBallController ballController;

	[Token(Token = "0x4005197")]
	[FieldOffset(Offset = "0x50")]
	private List<GameObject> listOfFruits;

	[Token(Token = "0x4005198")]
	[FieldOffset(Offset = "0x58")]
	[SerializeField]
	private GameObject startObject;

	[Token(Token = "0x4005199")]
	[FieldOffset(Offset = "0x60")]
	[SerializeField]
	private ClipSettingsCollection AudioOnSpawn;

	[Token(Token = "0x400519A")]
	[FieldOffset(Offset = "0x68")]
	[SerializeField]
	private AnimationCurve curve;

	[Token(Token = "0x400519B")]
	[FieldOffset(Offset = "0x70")]
	[SerializeField]
	private float inDuration;

	[Token(Token = "0x400519C")]
	[FieldOffset(Offset = "0x74")]
	[SerializeField]
	private float outDuration;

	[Token(Token = "0x60046B2")]
	[Address(RVA = "0x164A104", Offset = "0x164A104", VA = "0x164A104")]
	private void Start()
	{
	}

	[Token(Token = "0x60046B3")]
	[Address(RVA = "0x164A188", Offset = "0x164A188", VA = "0x164A188", Slot = "7")]
	public override void OnShoot(Vector3 boost)
	{
	}

	[Token(Token = "0x60046B4")]
	[Address(RVA = "0x164A23C", Offset = "0x164A23C", VA = "0x164A23C")]
	private IEnumerator ShootFruits(Vector3 boost)
	{
		return null;
	}

	[Token(Token = "0x60046B5")]
	[Address(RVA = "0x164A2D4", Offset = "0x164A2D4", VA = "0x164A2D4")]
	private IEnumerator DestroyFruit(GameObject fruit)
	{
		return null;
	}

	[Token(Token = "0x60046B6")]
	[Address(RVA = "0x164A34C", Offset = "0x164A34C", VA = "0x164A34C")]
	public ReplicatingFruitsShooter()
	{
	}
}
