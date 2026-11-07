using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Audio;
using CameraStack;
using Core;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000D91")]
public class KatamariBallSnake : MonoBehaviour
{
	[Token(Token = "0x2000D92")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x44B08", Offset = "0x44B08")]
	private sealed class _003CMoveObjectInSnake_003Ed__33 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40049DE")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x40049DF")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x40049E0")]
		[FieldOffset(Offset = "0x20")]
		public KatamariBallSnake _003C_003E4__this;

		[Token(Token = "0x40049E1")]
		[FieldOffset(Offset = "0x28")]
		public GameObject otherObject;

		[Token(Token = "0x40049E2")]
		[FieldOffset(Offset = "0x30")]
		private float _003CelapsedTime_003E5__2;

		[Token(Token = "0x40049E3")]
		[FieldOffset(Offset = "0x34")]
		private float _003CwaitTime_003E5__3;

		[Token(Token = "0x40049E4")]
		[FieldOffset(Offset = "0x38")]
		private int _003CrandomPosition_003E5__4;

		[Token(Token = "0x17000685")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6003FD1")]
			[Address(RVA = "0x17CCAF0", Offset = "0x17CCAF0", VA = "0x17CCAF0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x17000686")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6003FD3")]
			[Address(RVA = "0x17CCB38", Offset = "0x17CCB38", VA = "0x17CCB38", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x6003FCE")]
		[Address(RVA = "0x17CC858", Offset = "0x17CC858", VA = "0x17CC858")]
		[DebuggerHidden]
		public _003CMoveObjectInSnake_003Ed__33(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6003FCF")]
		[Address(RVA = "0x17CC884", Offset = "0x17CC884", VA = "0x17CC884", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6003FD0")]
		[Address(RVA = "0x17CC888", Offset = "0x17CC888", VA = "0x17CC888", Slot = "6")]
		private bool MoveNext()
		{
			return default;
		}

		[Token(Token = "0x6003FD1")]
		[Address(RVA = "0x17CCAF0", Offset = "0x17CCAF0", VA = "0x17CCAF0", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x6003FD2")]
		[Address(RVA = "0x17CCAF8", Offset = "0x17CCAF8", VA = "0x17CCAF8", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}

		[Token(Token = "0x6003FD3")]
		[Address(RVA = "0x17CCB38", Offset = "0x17CCB38", VA = "0x17CCB38", Slot = "7")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}
	}

	[Token(Token = "0x40049C1")]
	[FieldOffset(Offset = "0x18")]
	public float CurrentSize;

	[Token(Token = "0x40049C2")]
	[FieldOffset(Offset = "0x1C")]
	public float BallCompression;

	[Token(Token = "0x40049C3")]
	[FieldOffset(Offset = "0x20")]
	public float GrowthMod;

	[Token(Token = "0x40049C4")]
	[FieldOffset(Offset = "0x24")]
	public float ElevationMod;

	[Token(Token = "0x40049C5")]
	[FieldOffset(Offset = "0x28")]
	public float MinCameraElevation;

	[Token(Token = "0x40049C6")]
	[FieldOffset(Offset = "0x2C")]
	public float ElevationChangeSpeed;

	[Token(Token = "0x40049C7")]
	[FieldOffset(Offset = "0x30")]
	public float RequiredSizeToWin;

	[Token(Token = "0x40049C8")]
	[FieldOffset(Offset = "0x34")]
	public float MinShotSpeed;

	[Token(Token = "0x40049C9")]
	[FieldOffset(Offset = "0x38")]
	public float ForceMod;

	[Token(Token = "0x40049CA")]
	[FieldOffset(Offset = "0x3C")]
	public Vector2 ArrowScaleRange;

	[Token(Token = "0x40049CB")]
	[FieldOffset(Offset = "0x44")]
	public bool IncreaseMass;

	[Token(Token = "0x40049CC")]
	[FieldOffset(Offset = "0x45")]
	public bool DestroyCollider;

	[Token(Token = "0x40049CD")]
	[FieldOffset(Offset = "0x48")]
	public GameObject SphereCollider;

	[Token(Token = "0x40049CE")]
	[FieldOffset(Offset = "0x50")]
	public PlayAudioClipSetting audioClipSetting;

	[Token(Token = "0x40049CF")]
	[FieldOffset(Offset = "0x58")]
	public Material snakeMaterial;

	[Token(Token = "0x40049D0")]
	[FieldOffset(Offset = "0x60")]
	public List<Transform> points;

	[Token(Token = "0x40049D1")]
	[FieldOffset(Offset = "0x68")]
	public AnimationCurve swallowedObjectMovement;

	[Token(Token = "0x40049D2")]
	[FieldOffset(Offset = "0x70")]
	public float MoveSpeed;

	[Token(Token = "0x40049D3")]
	[FieldOffset(Offset = "0x74")]
	public float targetScale;

	[Token(Token = "0x40049D4")]
	[FieldOffset(Offset = "0x78")]
	public float timeToLerp;

	[Token(Token = "0x40049D5")]
	[FieldOffset(Offset = "0x80")]
	private GameObject currentObjectToMove;

	[Token(Token = "0x40049D6")]
	[FieldOffset(Offset = "0x88")]
	[SerializeField]
	private ClipSettingsCollection absorbClip;

	[Token(Token = "0x40049D7")]
	[FieldOffset(Offset = "0x90")]
	private CBFollow followCam;

	[Token(Token = "0x40049D8")]
	[FieldOffset(Offset = "0x98")]
	private float targetElevation;

	[Token(Token = "0x40049D9")]
	[FieldOffset(Offset = "0x9C")]
	private float currentElevation;

	[Token(Token = "0x40049DA")]
	[FieldOffset(Offset = "0xA0")]
	private ConstantForce force;

	[Token(Token = "0x40049DB")]
	[FieldOffset(Offset = "0xA8")]
	private GolfBallShooterExperimental shooter;

	[Token(Token = "0x40049DC")]
	[FieldOffset(Offset = "0xB0")]
	private GolfBallController controller;

	[Token(Token = "0x40049DD")]
	[FieldOffset(Offset = "0xB8")]
	private Rigidbody rigidbody;

	[Token(Token = "0x6003FC8")]
	[Address(RVA = "0x14FB084", Offset = "0x14FB084", VA = "0x14FB084")]
	private void Awake()
	{
	}

	[Token(Token = "0x6003FC9")]
	[Address(RVA = "0x14FB1F0", Offset = "0x14FB1F0", VA = "0x14FB1F0")]
	private void Controller_OnReset()
	{
	}

	[Token(Token = "0x6003FCA")]
	[Address(RVA = "0x14FB280", Offset = "0x14FB280", VA = "0x14FB280")]
	private void OnCollisionEnter(Collision other)
	{
	}

	[Token(Token = "0x6003FCB")]
	[Address(RVA = "0x14FB910", Offset = "0x14FB910", VA = "0x14FB910")]
	private void Update()
	{
	}

	[Token(Token = "0x6003FCC")]
	[Address(RVA = "0x14FB898", Offset = "0x14FB898", VA = "0x14FB898")]
	private IEnumerator MoveObjectInSnake(GameObject otherObject)
	{
		return null;
	}

	[Token(Token = "0x6003FCD")]
	[Address(RVA = "0x14FBADC", Offset = "0x14FBADC", VA = "0x14FBADC")]
	public KatamariBallSnake()
	{
	}
}
