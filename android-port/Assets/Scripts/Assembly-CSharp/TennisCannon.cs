using System;
using System.Collections.Generic;
using Audio;
using Core;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000EB0")]
public class TennisCannon : MonoBehaviour
{
	[Token(Token = "0x4004F51")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	private List<GameObject> tennisBall;

	[Token(Token = "0x4004F52")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private Transform spawnPosition;

	[Token(Token = "0x4004F53")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	private float force;

	[Token(Token = "0x4004F54")]
	[FieldOffset(Offset = "0x2C")]
	[SerializeField]
	private float upModifyer;

	[Token(Token = "0x4004F55")]
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	private ClipSettingsCollection clipCollection;

	[Token(Token = "0x4004F56")]
	[FieldOffset(Offset = "0x38")]
	public Action<Rigidbody> OnBallSpawned;

	[Token(Token = "0x4004F57")]
	[FieldOffset(Offset = "0x40")]
	[SerializeField]
	private bool attachToController;

	[Token(Token = "0x4004F58")]
	[FieldOffset(Offset = "0x48")]
	[SerializeField]
	private GolfBallController controller;

	[Token(Token = "0x6004499")]
	[Address(RVA = "0x16F93F4", Offset = "0x16F93F4", VA = "0x16F93F4")]
	private void Awake()
	{
	}

	[Token(Token = "0x600449A")]
	[Address(RVA = "0x16F9538", Offset = "0x16F9538", VA = "0x16F9538")]
	public void SpawnBall()
	{
	}

	[Token(Token = "0x600449B")]
	[Address(RVA = "0x16F9560", Offset = "0x16F9560", VA = "0x16F9560")]
	public void SpawnBall(Vector3 v)
	{
	}

	[Token(Token = "0x600449C")]
	[Address(RVA = "0x16F97C8", Offset = "0x16F97C8", VA = "0x16F97C8")]
	public TennisCannon()
	{
	}
}
