using System;
using System.Collections.Generic;
using Audio;
using Core;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000AAE")]
public class OverworldBallInGravityHelper : MonoBehaviour
{
	[Serializable]
	[Token(Token = "0x2000AAF")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x42F40", Offset = "0x42F40")]
	private sealed class _003C_003Ec
	{
		[Token(Token = "0x4003B74")]
		[FieldOffset(Offset = "0x0")]
		public static readonly _003C_003Ec _003C_003E9;

		[Token(Token = "0x4003B75")]
		[FieldOffset(Offset = "0x8")]
		public static Predicate<WindArea2D> _003C_003E9__25_0;

		[Token(Token = "0x600330B")]
		[Address(RVA = "0x180C39C", Offset = "0x180C39C", VA = "0x180C39C")]
		public _003C_003Ec()
		{
		}

		[Token(Token = "0x600330C")]
		[Address(RVA = "0x180C3A4", Offset = "0x180C3A4", VA = "0x180C3A4")]
		internal bool _003CisInGravityZone_003Eb__25_0(WindArea2D z)
		{
			return default;
		}
	}

	[Token(Token = "0x4003B62")]
	[FieldOffset(Offset = "0x18")]
	public LayerMask wallLayerMask;

	[Token(Token = "0x4003B63")]
	[FieldOffset(Offset = "0x1C")]
	public float raycastDistance;

	[Token(Token = "0x4003B64")]
	[FieldOffset(Offset = "0x20")]
	public bool useCustomStopThreshold;

	[Token(Token = "0x4003B65")]
	[FieldOffset(Offset = "0x24")]
	public float customStopThreshold;

	[Token(Token = "0x4003B66")]
	[FieldOffset(Offset = "0x28")]
	public AudioClipSettings sfxOnUp;

	[Token(Token = "0x4003B67")]
	[FieldOffset(Offset = "0x30")]
	public AudioClipSettings sfxOnRight;

	[Token(Token = "0x4003B68")]
	[FieldOffset(Offset = "0x38")]
	public AudioClipSettings sfxOnDown;

	[Token(Token = "0x4003B69")]
	[FieldOffset(Offset = "0x40")]
	public AudioClipSettings sfxOnLeft;

	[Token(Token = "0x4003B6A")]
	[FieldOffset(Offset = "0x48")]
	private float baseStopThreshold;

	[Token(Token = "0x4003B6B")]
	[FieldOffset(Offset = "0x50")]
	private OverworldBall2D ball;

	[Token(Token = "0x4003B6C")]
	[FieldOffset(Offset = "0x58")]
	private GolfBallController controller;

	[Token(Token = "0x4003B6D")]
	[FieldOffset(Offset = "0x60")]
	private int shotsSinceGrounded;

	[Token(Token = "0x4003B6E")]
	[FieldOffset(Offset = "0x64")]
	private int maxInAirShots;

	[Token(Token = "0x4003B6F")]
	[FieldOffset(Offset = "0x68")]
	private Vector2 currentWindDirection;

	[Token(Token = "0x4003B70")]
	[FieldOffset(Offset = "0x70")]
	private List<WindArea2D> zones;

	[Token(Token = "0x4003B71")]
	[FieldOffset(Offset = "0x78")]
	private float stillTime;

	[Token(Token = "0x4003B72")]
	[FieldOffset(Offset = "0x7C")]
	private Vector3 lastPosition;

	[Token(Token = "0x4003B73")]
	[FieldOffset(Offset = "0x88")]
	private float stillThreshold;

	[Token(Token = "0x6003301")]
	[Address(RVA = "0x15A3B84", Offset = "0x15A3B84", VA = "0x15A3B84")]
	private void Awake()
	{
	}

	[Token(Token = "0x6003302")]
	[Address(RVA = "0x15A3CE0", Offset = "0x15A3CE0", VA = "0x15A3CE0")]
	private void Controller_OnPreShoot(Vector3 obj)
	{
	}

	[Token(Token = "0x6003303")]
	[Address(RVA = "0x15A3FDC", Offset = "0x15A3FDC", VA = "0x15A3FDC")]
	private void FixedUpdate()
	{
	}

	[Token(Token = "0x6003304")]
	[Address(RVA = "0x15A3E80", Offset = "0x15A3E80", VA = "0x15A3E80")]
	private bool IsGrounded()
	{
		return default;
	}

	[Token(Token = "0x6003305")]
	[Address(RVA = "0x15A40B8", Offset = "0x15A40B8", VA = "0x15A40B8")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x6003306")]
	[Address(RVA = "0x15A4168", Offset = "0x15A4168", VA = "0x15A4168")]
	public void EnterGravityZone(WindArea2D zone, int zoneMaxInAirShots)
	{
	}

	[Token(Token = "0x6003307")]
	[Address(RVA = "0x15A4340", Offset = "0x15A4340", VA = "0x15A4340")]
	public void ExitGravityZone(WindArea2D zone)
	{
	}

	[Token(Token = "0x6003308")]
	[Address(RVA = "0x15A3D1C", Offset = "0x15A3D1C", VA = "0x15A3D1C")]
	private bool isInGravityZone()
	{
		return default;
	}

	[Token(Token = "0x6003309")]
	[Address(RVA = "0x15A440C", Offset = "0x15A440C", VA = "0x15A440C")]
	public OverworldBallInGravityHelper()
	{
	}
}
