using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Cinemachine;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000626")]
public class BossFrogKingInside : MonoBehaviour
{
	[Token(Token = "0x2000627")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x40A50", Offset = "0x40A50")]
	private sealed class _003CMoveRoutine_003Ed__22 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4001FCA")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x4001FCB")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x4001FCC")]
		[FieldOffset(Offset = "0x20")]
		public Rigidbody tentacle;

		[Token(Token = "0x4001FCD")]
		[FieldOffset(Offset = "0x28")]
		public BossFrogKingInside _003C_003E4__this;

		[Token(Token = "0x4001FCE")]
		[FieldOffset(Offset = "0x30")]
		private float _003CmoveTimer_003E5__2;

		[Token(Token = "0x4001FCF")]
		[FieldOffset(Offset = "0x34")]
		private float _003CbaseY_003E5__3;

		[Token(Token = "0x17000313")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6001C0A")]
			[Address(RVA = "0x1774AC0", Offset = "0x1774AC0", VA = "0x1774AC0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x17000314")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6001C0C")]
			[Address(RVA = "0x1774B08", Offset = "0x1774B08", VA = "0x1774B08", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x6001C07")]
		[Address(RVA = "0x17748AC", Offset = "0x17748AC", VA = "0x17748AC")]
		[DebuggerHidden]
		public _003CMoveRoutine_003Ed__22(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6001C08")]
		[Address(RVA = "0x17748D8", Offset = "0x17748D8", VA = "0x17748D8", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6001C09")]
		[Address(RVA = "0x17748DC", Offset = "0x17748DC", VA = "0x17748DC", Slot = "6")]
		private bool MoveNext()
		{
			return default;
		}

		[Token(Token = "0x6001C0A")]
		[Address(RVA = "0x1774AC0", Offset = "0x1774AC0", VA = "0x1774AC0", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x6001C0B")]
		[Address(RVA = "0x1774AC8", Offset = "0x1774AC8", VA = "0x1774AC8", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}

		[Token(Token = "0x6001C0C")]
		[Address(RVA = "0x1774B08", Offset = "0x1774B08", VA = "0x1774B08", Slot = "7")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}
	}

	[Token(Token = "0x2000628")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x40A60", Offset = "0x40A60")]
	private sealed class _003CPlayRoutine_003Ed__24 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4001FD0")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x4001FD1")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x4001FD2")]
		[FieldOffset(Offset = "0x20")]
		public BossFrogKingInside _003C_003E4__this;

		[Token(Token = "0x17000315")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6001C10")]
			[Address(RVA = "0x1774B90", Offset = "0x1774B90", VA = "0x1774B90", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x17000316")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6001C12")]
			[Address(RVA = "0x1774BD8", Offset = "0x1774BD8", VA = "0x1774BD8", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x6001C0D")]
		[Address(RVA = "0x1774B10", Offset = "0x1774B10", VA = "0x1774B10")]
		[DebuggerHidden]
		public _003CPlayRoutine_003Ed__24(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6001C0E")]
		[Address(RVA = "0x1774B3C", Offset = "0x1774B3C", VA = "0x1774B3C", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6001C0F")]
		[Address(RVA = "0x1774B40", Offset = "0x1774B40", VA = "0x1774B40", Slot = "6")]
		private bool MoveNext()
		{
			return default;
		}

		[Token(Token = "0x6001C10")]
		[Address(RVA = "0x1774B90", Offset = "0x1774B90", VA = "0x1774B90", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x6001C11")]
		[Address(RVA = "0x1774B98", Offset = "0x1774B98", VA = "0x1774B98", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}

		[Token(Token = "0x6001C12")]
		[Address(RVA = "0x1774BD8", Offset = "0x1774BD8", VA = "0x1774BD8", Slot = "7")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}
	}

	[Token(Token = "0x4001FB6")]
	[FieldOffset(Offset = "0x18")]
	public GameObject StandaloneCamera;

	[Token(Token = "0x4001FB7")]
	[FieldOffset(Offset = "0x20")]
	public GameObject MobileCamera;

	[Token(Token = "0x4001FB8")]
	[FieldOffset(Offset = "0x28")]
	public GameObject TentacleObstaclePrefab;

	[Token(Token = "0x4001FB9")]
	[FieldOffset(Offset = "0x30")]
	public float TentacleSpawnRate;

	[Token(Token = "0x4001FBA")]
	[FieldOffset(Offset = "0x34")]
	public float TentacleMoveSpeed;

	[Token(Token = "0x4001FBB")]
	[FieldOffset(Offset = "0x38")]
	public float TentacleLifeTime;

	[Token(Token = "0x4001FBC")]
	[FieldOffset(Offset = "0x40")]
	public AnimationCurve TentacleHeightCurve;

	[Token(Token = "0x4001FBD")]
	[FieldOffset(Offset = "0x48")]
	public List<Transform> TentacleSpawnPositions;

	[Token(Token = "0x4001FBE")]
	[FieldOffset(Offset = "0x50")]
	public GameObject Container;

	[Token(Token = "0x4001FBF")]
	[FieldOffset(Offset = "0x58")]
	public Vector3 Gravity;

	[Token(Token = "0x4001FC0")]
	[FieldOffset(Offset = "0x64")]
	public bool SpawnTentacles;

	[Token(Token = "0x4001FC1")]
	[FieldOffset(Offset = "0x68")]
	public CinemachineBlendListCamera OutroCamera;

	[Token(Token = "0x4001FC2")]
	[FieldOffset(Offset = "0x70")]
	public Rigidbody Player;

	[Token(Token = "0x4001FC3")]
	[FieldOffset(Offset = "0x78")]
	public SpiderManShooter PlayerShooter;

	[Token(Token = "0x4001FC4")]
	[FieldOffset(Offset = "0x80")]
	public Animator OutroAnimator;

	[Token(Token = "0x4001FC5")]
	[FieldOffset(Offset = "0x88")]
	public List<Transform> SpiderWebShootPoints;

	[Token(Token = "0x4001FC6")]
	[FieldOffset(Offset = "0x90")]
	public Transform Brain;

	[Token(Token = "0x4001FC7")]
	[FieldOffset(Offset = "0x98")]
	public Rigidbody BrainRigid;

	[Token(Token = "0x4001FC8")]
	[FieldOffset(Offset = "0xA0")]
	private float timer;

	[Token(Token = "0x4001FC9")]
	[FieldOffset(Offset = "0xA4")]
	private bool playingOutro;

	[Token(Token = "0x6001C01")]
	[Address(RVA = "0x16FC914", Offset = "0x16FC914", VA = "0x16FC914")]
	private void Awake()
	{
	}

	[Token(Token = "0x6001C02")]
	[Address(RVA = "0x16FCA00", Offset = "0x16FCA00", VA = "0x16FCA00")]
	private void Update()
	{
	}

	[Token(Token = "0x6001C03")]
	[Address(RVA = "0x16FCC60", Offset = "0x16FCC60", VA = "0x16FCC60")]
	private IEnumerator MoveRoutine(Rigidbody tentacle)
	{
		return null;
	}

	[Token(Token = "0x6001C04")]
	[Address(RVA = "0x16FCCD8", Offset = "0x16FCCD8", VA = "0x16FCCD8")]
	public void PlayerHitBrain()
	{
	}

	[Token(Token = "0x6001C05")]
	[Address(RVA = "0x16FCCEC", Offset = "0x16FCCEC", VA = "0x16FCCEC")]
	public IEnumerator PlayRoutine()
	{
		return null;
	}

	[Token(Token = "0x6001C06")]
	[Address(RVA = "0x16FCD60", Offset = "0x16FCD60", VA = "0x16FCD60")]
	public BossFrogKingInside()
	{
	}
}
