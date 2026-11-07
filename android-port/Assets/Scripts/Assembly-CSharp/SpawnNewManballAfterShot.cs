using System.Collections.Generic;
using Audio;
using Core;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000E30")]
public class SpawnNewManballAfterShot : MonoBehaviour
{
	[Token(Token = "0x4004CF4")]
	[FieldOffset(Offset = "0x18")]
	public List<GameObject> m_ball;

	[Token(Token = "0x4004CF5")]
	[FieldOffset(Offset = "0x20")]
	public ParticleSystem OnDestroySystem;

	[Token(Token = "0x4004CF6")]
	[FieldOffset(Offset = "0x28")]
	private int NumBallsSpawned;

	[Token(Token = "0x4004CF7")]
	[FieldOffset(Offset = "0x2C")]
	public float maxWaitTime;

	[Token(Token = "0x4004CF8")]
	[FieldOffset(Offset = "0x30")]
	public float destroyAfter;

	[Token(Token = "0x4004CF9")]
	[FieldOffset(Offset = "0x34")]
	public int maxAmount;

	[Token(Token = "0x4004CFA")]
	[FieldOffset(Offset = "0x38")]
	private List<GameObject> doughnuts;

	[Token(Token = "0x4004CFB")]
	[FieldOffset(Offset = "0x40")]
	private float shootTime;

	[Token(Token = "0x4004CFC")]
	[FieldOffset(Offset = "0x48")]
	private GameObject ball;

	[Token(Token = "0x4004CFD")]
	[FieldOffset(Offset = "0x50")]
	private GolfBallController controller;

	[Token(Token = "0x4004CFE")]
	[FieldOffset(Offset = "0x58")]
	public ClipSettingsCollection OnAppear;

	[Token(Token = "0x4004CFF")]
	[FieldOffset(Offset = "0x60")]
	public bool isWon;

	[Token(Token = "0x4004D00")]
	[FieldOffset(Offset = "0x61")]
	public bool destroy;

	[Token(Token = "0x4004D01")]
	[FieldOffset(Offset = "0x62")]
	private bool checkForZeroVel;

	[Token(Token = "0x600428D")]
	[Address(RVA = "0x16C82F8", Offset = "0x16C82F8", VA = "0x16C82F8")]
	public void Complete()
	{
	}

	[Token(Token = "0x600428E")]
	[Address(RVA = "0x16C8304", Offset = "0x16C8304", VA = "0x16C8304")]
	private void Start()
	{
	}

	[Token(Token = "0x600428F")]
	[Address(RVA = "0x16C8308", Offset = "0x16C8308", VA = "0x16C8308")]
	private void SpawnNew()
	{
	}

	[Token(Token = "0x6004290")]
	[Address(RVA = "0x16C8604", Offset = "0x16C8604", VA = "0x16C8604")]
	private void StartCheck(Vector3 boost)
	{
	}

	[Token(Token = "0x6004291")]
	[Address(RVA = "0x16C86CC", Offset = "0x16C86CC", VA = "0x16C86CC")]
	private void Update()
	{
	}

	[Token(Token = "0x6004292")]
	[Address(RVA = "0x16C8878", Offset = "0x16C8878", VA = "0x16C8878")]
	public SpawnNewManballAfterShot()
	{
	}
}
