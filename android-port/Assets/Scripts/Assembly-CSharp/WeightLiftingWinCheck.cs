using System.Collections.Generic;
using Audio;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x200072A")]
public class WeightLiftingWinCheck : MonoBehaviour
{
	[Token(Token = "0x40025D3")]
	[FieldOffset(Offset = "0x18")]
	public float SleepMagnitude;

	[Token(Token = "0x40025D4")]
	[FieldOffset(Offset = "0x20")]
	public BoxCollider2D WinZone;

	[Token(Token = "0x40025D5")]
	[FieldOffset(Offset = "0x28")]
	public Collider2D BarCol;

	[Token(Token = "0x40025D6")]
	[FieldOffset(Offset = "0x30")]
	public List<Collider2D> ResetColliders;

	[Token(Token = "0x40025D7")]
	[FieldOffset(Offset = "0x38")]
	public List<Transform> WinPoints;

	[Token(Token = "0x40025D8")]
	[FieldOffset(Offset = "0x40")]
	public ClipSettingsCollection sfxOnWin;

	[Token(Token = "0x40025D9")]
	[FieldOffset(Offset = "0x48")]
	private Rigidbody2D rigid;

	[Token(Token = "0x40025DA")]
	[FieldOffset(Offset = "0x50")]
	private Vector3 startPos;

	[Token(Token = "0x40025DB")]
	[FieldOffset(Offset = "0x5C")]
	private Quaternion startRot;

	[Token(Token = "0x40025DC")]
	[FieldOffset(Offset = "0x6C")]
	private float nextGruntSfxTime;

	[Token(Token = "0x6002115")]
	[Address(RVA = "0x1751488", Offset = "0x1751488", VA = "0x1751488")]
	private void Awake()
	{
	}

	[Token(Token = "0x6002116")]
	[Address(RVA = "0x1751528", Offset = "0x1751528", VA = "0x1751528")]
	private void OnTriggerStay2D(Collider2D other)
	{
	}

	[Token(Token = "0x6002117")]
	[Address(RVA = "0x17518A0", Offset = "0x17518A0", VA = "0x17518A0")]
	private void OnTriggerEnter2D(Collider2D other)
	{
	}

	[Token(Token = "0x6002118")]
	[Address(RVA = "0x1751920", Offset = "0x1751920", VA = "0x1751920")]
	private void Reset()
	{
	}

	[Token(Token = "0x6002119")]
	[Address(RVA = "0x1751978", Offset = "0x1751978", VA = "0x1751978")]
	public WeightLiftingWinCheck()
	{
	}
}
