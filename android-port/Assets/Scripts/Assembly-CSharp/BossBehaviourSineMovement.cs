using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x200061A")]
public class BossBehaviourSineMovement : BossBehaviour
{
	[Token(Token = "0x200061B")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x40A20", Offset = "0x40A20")]
	private sealed class _003CEndRoutine_003Ed__31 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4001F8B")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x4001F8C")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x4001F8D")]
		[FieldOffset(Offset = "0x20")]
		public BossBehaviourSineMovement _003C_003E4__this;

		[Token(Token = "0x1700030F")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6001BDD")]
			[Address(RVA = "0x177485C", Offset = "0x177485C", VA = "0x177485C", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x17000310")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6001BDF")]
			[Address(RVA = "0x17748A4", Offset = "0x17748A4", VA = "0x17748A4", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x6001BDA")]
		[Address(RVA = "0x17747AC", Offset = "0x17747AC", VA = "0x17747AC")]
		[DebuggerHidden]
		public _003CEndRoutine_003Ed__31(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6001BDB")]
		[Address(RVA = "0x17747D8", Offset = "0x17747D8", VA = "0x17747D8", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6001BDC")]
		[Address(RVA = "0x17747DC", Offset = "0x17747DC", VA = "0x17747DC", Slot = "6")]
		private bool MoveNext()
		{
			return default;
		}

		[Token(Token = "0x6001BDD")]
		[Address(RVA = "0x177485C", Offset = "0x177485C", VA = "0x177485C", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x6001BDE")]
		[Address(RVA = "0x1774864", Offset = "0x1774864", VA = "0x1774864", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}

		[Token(Token = "0x6001BDF")]
		[Address(RVA = "0x17748A4", Offset = "0x17748A4", VA = "0x17748A4", Slot = "7")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}
	}

	[Token(Token = "0x4001F75")]
	[FieldOffset(Offset = "0x28")]
	public float curveWidth;

	[Token(Token = "0x4001F76")]
	[FieldOffset(Offset = "0x2C")]
	public float speed;

	[Token(Token = "0x4001F77")]
	[FieldOffset(Offset = "0x30")]
	public float distance;

	[Token(Token = "0x4001F78")]
	[FieldOffset(Offset = "0x34")]
	public float sineMovementSpeed;

	[Token(Token = "0x4001F79")]
	[FieldOffset(Offset = "0x38")]
	public float IntroLength;

	[Token(Token = "0x4001F7A")]
	[FieldOffset(Offset = "0x3C")]
	public float CurveIntroLength;

	[Token(Token = "0x4001F7B")]
	[FieldOffset(Offset = "0x40")]
	public float RotateSpeed;

	[Token(Token = "0x4001F7C")]
	[FieldOffset(Offset = "0x44")]
	public float UpAndDownBobSpeed;

	[Token(Token = "0x4001F7D")]
	[FieldOffset(Offset = "0x48")]
	public float UpAndDownBobAmount;

	[Token(Token = "0x4001F7E")]
	[FieldOffset(Offset = "0x4C")]
	public float BaseCarHeight;

	[Token(Token = "0x4001F7F")]
	[FieldOffset(Offset = "0x50")]
	public float SpeedDecline;

	[Token(Token = "0x4001F80")]
	[FieldOffset(Offset = "0x54")]
	private Vector3 busPosition;

	[Token(Token = "0x4001F81")]
	[FieldOffset(Offset = "0x60")]
	private float currentSpeed;

	[Token(Token = "0x4001F82")]
	[FieldOffset(Offset = "0x64")]
	private bool isDriving;

	[Token(Token = "0x4001F83")]
	[FieldOffset(Offset = "0x68")]
	private float xMovementMultiplier;

	[Token(Token = "0x4001F84")]
	[FieldOffset(Offset = "0x6C")]
	private float moveDistanceForSineMovement;

	[Token(Token = "0x4001F85")]
	[FieldOffset(Offset = "0x70")]
	public float introBoost;

	[Token(Token = "0x4001F86")]
	[FieldOffset(Offset = "0x74")]
	private float curveIntro;

	[Token(Token = "0x4001F87")]
	[FieldOffset(Offset = "0x78")]
	private Vector3 startPos;

	[Token(Token = "0x4001F88")]
	[FieldOffset(Offset = "0x84")]
	private Quaternion startRot;

	[Token(Token = "0x4001F89")]
	[FieldOffset(Offset = "0x94")]
	private float currentCarBaseHeight;

	[Token(Token = "0x4001F8A")]
	[FieldOffset(Offset = "0x98")]
	private float upAndDownBobVal;

	[Token(Token = "0x1700030D")]
	public override Vector3 Position
	{
		[Token(Token = "0x6001BD5")]
		[Address(RVA = "0x16FB8EC", Offset = "0x16FB8EC", VA = "0x16FB8EC", Slot = "5")]
		get
		{
			return default;
		}
	}

	[Token(Token = "0x1700030E")]
	public override Quaternion Rotation
	{
		[Token(Token = "0x6001BD6")]
		[Address(RVA = "0x16FBBC0", Offset = "0x16FBBC0", VA = "0x16FBBC0", Slot = "6")]
		get
		{
			return default;
		}
	}

	[Token(Token = "0x6001BD1")]
	[Address(RVA = "0x16FB7AC", Offset = "0x16FB7AC", VA = "0x16FB7AC")]
	private void Start()
	{
	}

	[Token(Token = "0x6001BD2")]
	[Address(RVA = "0x16FB7FC", Offset = "0x16FB7FC", VA = "0x16FB7FC")]
	private float GetXMovementFromZ(float z, bool useXmovementMultiplier = true)
	{
		return default;
	}

	[Token(Token = "0x6001BD3")]
	[Address(RVA = "0x16FB840", Offset = "0x16FB840", VA = "0x16FB840")]
	public Vector3 GetBusPositionForOffsetZ(float zOffset, bool useXmovementMultiplier = true)
	{
		return default;
	}

	[Token(Token = "0x6001BD4")]
	[Address(RVA = "0x16FB8D8", Offset = "0x16FB8D8", VA = "0x16FB8D8")]
	private float GetMoveDistanceFromForward(float forward)
	{
		return default;
	}

	[Token(Token = "0x6001BD7")]
	[Address(RVA = "0x16FBD24", Offset = "0x16FBD24", VA = "0x16FBD24", Slot = "8")]
	public override float GetSpeed()
	{
		return default;
	}

	[Token(Token = "0x6001BD8")]
	[Address(RVA = "0x16FBD2C", Offset = "0x16FBD2C", VA = "0x16FBD2C", Slot = "4")]
	public override IEnumerator EndRoutine()
	{
		return null;
	}

	[Token(Token = "0x6001BD9")]
	[Address(RVA = "0x16FBDA0", Offset = "0x16FBDA0", VA = "0x16FBDA0")]
	public BossBehaviourSineMovement()
	{
	}
}
