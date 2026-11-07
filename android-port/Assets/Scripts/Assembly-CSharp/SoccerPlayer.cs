using System;
using System.Collections.Generic;
using Chronos;
using Core;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000949")]
public class SoccerPlayer : MonoBehaviour
{
	[Serializable]
	[Token(Token = "0x200094A")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x421A0", Offset = "0x421A0")]
	private sealed class _003C_003Ec
	{
		[Token(Token = "0x4003319")]
		[FieldOffset(Offset = "0x0")]
		public static readonly _003C_003Ec _003C_003E9;

		[Token(Token = "0x400331A")]
		[FieldOffset(Offset = "0x8")]
		public static Func<GolfBallController, Rigidbody> _003C_003E9__30_0;

		[Token(Token = "0x6002B5C")]
		[Address(RVA = "0x1852BB8", Offset = "0x1852BB8", VA = "0x1852BB8")]
		public _003C_003Ec()
		{
		}

		[Token(Token = "0x6002B5D")]
		[Address(RVA = "0x1852BC0", Offset = "0x1852BC0", VA = "0x1852BC0")]
		internal Rigidbody _003COnMultiplayerSetup_003Eb__30_0(GolfBallController c)
		{
			return null;
		}
	}

	[Token(Token = "0x40032FC")]
	[FieldOffset(Offset = "0x18")]
	public List<Rigidbody> balls;

	[Token(Token = "0x40032FD")]
	[FieldOffset(Offset = "0x20")]
	public bool KickTarget;

	[Token(Token = "0x40032FE")]
	[FieldOffset(Offset = "0x24")]
	public float KickForce;

	[Token(Token = "0x40032FF")]
	[FieldOffset(Offset = "0x28")]
	public float kickRange;

	[Token(Token = "0x4003300")]
	[FieldOffset(Offset = "0x2C")]
	public float speed;

	[Token(Token = "0x4003301")]
	[FieldOffset(Offset = "0x30")]
	public Vector2 RandomSpeedModRange;

	[Token(Token = "0x4003302")]
	[FieldOffset(Offset = "0x38")]
	public float reactDistance;

	[Token(Token = "0x4003303")]
	[FieldOffset(Offset = "0x3C")]
	public float stopDistance;

	[Token(Token = "0x4003304")]
	[FieldOffset(Offset = "0x40")]
	public List<AudioClip> sfxKick;

	[Token(Token = "0x4003305")]
	[FieldOffset(Offset = "0x48")]
	public float rotateSpeed;

	[Token(Token = "0x4003306")]
	[FieldOffset(Offset = "0x4C")]
	public bool lookAlongVelocity;

	[Token(Token = "0x4003307")]
	[FieldOffset(Offset = "0x4D")]
	public bool AvoidEdges;

	[Token(Token = "0x4003308")]
	[FieldOffset(Offset = "0x50")]
	public float MaxRunTime;

	[Token(Token = "0x4003309")]
	[FieldOffset(Offset = "0x54")]
	public bool MoveOnlyWhenGrounded;

	[Token(Token = "0x400330A")]
	[FieldOffset(Offset = "0x58")]
	public float PlayerBlockTime;

	[Token(Token = "0x400330B")]
	[FieldOffset(Offset = "0x5C")]
	private Vector3 startPosition;

	[Token(Token = "0x400330C")]
	[FieldOffset(Offset = "0x68")]
	private Quaternion startRotation;

	[Token(Token = "0x400330D")]
	[FieldOffset(Offset = "0x78")]
	private Rigidbody rigid;

	[Token(Token = "0x400330E")]
	[FieldOffset(Offset = "0x80")]
	private float nextHit;

	[Token(Token = "0x400330F")]
	[FieldOffset(Offset = "0x88")]
	private Collider col;

	[Token(Token = "0x4003310")]
	[FieldOffset(Offset = "0x90")]
	private float waitTime;

	[Token(Token = "0x4003311")]
	[FieldOffset(Offset = "0x94")]
	private bool targetIsTouching;

	[Token(Token = "0x4003312")]
	[FieldOffset(Offset = "0x98")]
	public Action onKick;

	[Token(Token = "0x4003313")]
	[FieldOffset(Offset = "0xA0")]
	private float runningTime;

	[Token(Token = "0x4003314")]
	[FieldOffset(Offset = "0xA4")]
	private bool didRunTooMuch;

	[Token(Token = "0x4003315")]
	[FieldOffset(Offset = "0xA8")]
	private LaserSentryTarget laserSentryTarget;

	[Token(Token = "0x4003316")]
	[FieldOffset(Offset = "0xB0")]
	private Rigidbody currentTarget;

	[Token(Token = "0x4003317")]
	[FieldOffset(Offset = "0xB8")]
	private Timeline timeline;

	[Token(Token = "0x4003318")]
	[FieldOffset(Offset = "0xC0")]
	private bool timelineFound;

	[Token(Token = "0x17000472")]
	private float FixedDeltaTime
	{
		[Token(Token = "0x6002B4B")]
		[Address(RVA = "0x16BF1FC", Offset = "0x16BF1FC", VA = "0x16BF1FC")]
		get
		{
			return default;
		}
	}

	[Token(Token = "0x17000473")]
	private float DeltaTime
	{
		[Token(Token = "0x6002B4C")]
		[Address(RVA = "0x16BF1D0", Offset = "0x16BF1D0", VA = "0x16BF1D0")]
		get
		{
			return default;
		}
	}

	[Token(Token = "0x17000474")]
	public Vector3 Velocity
	{
		[Token(Token = "0x6002B4D")]
		[Address(RVA = "0x16BF18C", Offset = "0x16BF18C", VA = "0x16BF18C")]
		get
		{
			return default;
		}
		[Token(Token = "0x6002B4E")]
		[Address(RVA = "0x16BF148", Offset = "0x16BF148", VA = "0x16BF148")]
		set
		{
		}
	}

	[Token(Token = "0x17000475")]
	public Vector3 AngularVelocity
	{
		[Token(Token = "0x6002B4F")]
		[Address(RVA = "0x16BF3A0", Offset = "0x16BF3A0", VA = "0x16BF3A0")]
		get
		{
			return default;
		}
		[Token(Token = "0x6002B50")]
		[Address(RVA = "0x16BF228", Offset = "0x16BF228", VA = "0x16BF228")]
		set
		{
		}
	}

	[Token(Token = "0x17000476")]
	public float Drag
	{
		[Token(Token = "0x6002B51")]
		[Address(RVA = "0x16BF3E4", Offset = "0x16BF3E4", VA = "0x16BF3E4")]
		get
		{
			return default;
		}
		[Token(Token = "0x6002B52")]
		[Address(RVA = "0x16BF460", Offset = "0x16BF460", VA = "0x16BF460")]
		set
		{
		}
	}

	[Token(Token = "0x17000477")]
	public float AngularDrag
	{
		[Token(Token = "0x6002B53")]
		[Address(RVA = "0x16BF4F0", Offset = "0x16BF4F0", VA = "0x16BF4F0")]
		get
		{
			return default;
		}
		[Token(Token = "0x6002B54")]
		[Address(RVA = "0x16BF56C", Offset = "0x16BF56C", VA = "0x16BF56C")]
		set
		{
		}
	}

	[Token(Token = "0x17000478")]
	public float LocalTime
	{
		[Token(Token = "0x6002B55")]
		[Address(RVA = "0x16BF5FC", Offset = "0x16BF5FC", VA = "0x16BF5FC")]
		get
		{
			return default;
		}
	}

	[Token(Token = "0x17000479")]
	public bool IsKinematic
	{
		[Token(Token = "0x6002B56")]
		[Address(RVA = "0x16BF628", Offset = "0x16BF628", VA = "0x16BF628")]
		get
		{
			return default;
		}
		[Token(Token = "0x6002B57")]
		[Address(RVA = "0x16BF66C", Offset = "0x16BF66C", VA = "0x16BF66C")]
		set
		{
		}
	}

	[Token(Token = "0x6002B3E")]
	[Address(RVA = "0x16BD240", Offset = "0x16BD240", VA = "0x16BD240")]
	private void Awake()
	{
	}

	[Token(Token = "0x6002B3F")]
	[Address(RVA = "0x16BD390", Offset = "0x16BD390", VA = "0x16BD390")]
	private void OnMultiplayerSetup(MultiplayerLevelInfo info)
	{
	}

	[Token(Token = "0x6002B40")]
	[Address(RVA = "0x16BD808", Offset = "0x16BD808", VA = "0x16BD808")]
	private void Start()
	{
	}

	[Token(Token = "0x6002B41")]
	[Address(RVA = "0x16BDA74", Offset = "0x16BDA74", VA = "0x16BDA74")]
	public void AddBallTarget(Rigidbody ball)
	{
	}

	[Token(Token = "0x6002B42")]
	[Address(RVA = "0x16BDB2C", Offset = "0x16BDB2C", VA = "0x16BDB2C")]
	public void AddBallTarget(GolfBallController controller)
	{
	}

	[Token(Token = "0x6002B43")]
	[Address(RVA = "0x16BDCB8", Offset = "0x16BDCB8", VA = "0x16BDCB8")]
	private void LaserSentryTarget_OnLasered()
	{
	}

	[Token(Token = "0x6002B44")]
	[Address(RVA = "0x16BDCC4", Offset = "0x16BDCC4", VA = "0x16BDCC4")]
	private void OnCollisionEnter(Collision collision)
	{
	}

	[Token(Token = "0x6002B45")]
	[Address(RVA = "0x16BE1E8", Offset = "0x16BE1E8", VA = "0x16BE1E8")]
	private void OnCollisionExit(Collision collision)
	{
	}

	[Token(Token = "0x6002B46")]
	[Address(RVA = "0x16BDEB4", Offset = "0x16BDEB4", VA = "0x16BDEB4")]
	private void DoKick(Rigidbody other)
	{
	}

	[Token(Token = "0x6002B47")]
	[Address(RVA = "0x16BE28C", Offset = "0x16BE28C", VA = "0x16BE28C")]
	private void FixedUpdate()
	{
	}

	[Token(Token = "0x6002B48")]
	[Address(RVA = "0x16BF26C", Offset = "0x16BF26C", VA = "0x16BF26C")]
	public Rigidbody GetRigid()
	{
		return null;
	}

	[Token(Token = "0x6002B49")]
	[Address(RVA = "0x16BF318", Offset = "0x16BF318", VA = "0x16BF318")]
	private void AddForceAtPosition(Vector3 force, Vector3 position, ForceMode forceMode)
	{
	}

	[Token(Token = "0x6002B4A")]
	[Address(RVA = "0x16BF35C", Offset = "0x16BF35C", VA = "0x16BF35C")]
	private void AddForce(Vector3 force, ForceMode forceMode = ForceMode.Force)
	{
	}

	[Token(Token = "0x6002B58")]
	[Address(RVA = "0x16BF6B0", Offset = "0x16BF6B0", VA = "0x16BF6B0")]
	private void OnDrawGizmosSelected()
	{
	}

	[Token(Token = "0x6002B59")]
	[Address(RVA = "0x16BF700", Offset = "0x16BF700", VA = "0x16BF700")]
	public SoccerPlayer()
	{
	}

	[Token(Token = "0x6002B5A")]
	[Address(RVA = "0x16BF768", Offset = "0x16BF768", VA = "0x16BF768")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x67AF4", Offset = "0x67AF4")]
	private void _003CDoKick_003Eb__37_0(AudioSource s)
	{
	}
}
