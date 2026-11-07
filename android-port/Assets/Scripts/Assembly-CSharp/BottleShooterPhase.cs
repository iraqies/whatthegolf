using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000894")]
public class BottleShooterPhase : MonoBehaviour
{
	[Token(Token = "0x4002F17")]
	[FieldOffset(Offset = "0x18")]
	public bool startOnEnable;

	[Token(Token = "0x4002F18")]
	[FieldOffset(Offset = "0x20")]
	public GameObject[] LauncherObjects;

	[Token(Token = "0x4002F19")]
	[FieldOffset(Offset = "0x28")]
	public BottleShooterPhase nextPhase;

	[Token(Token = "0x4002F1A")]
	[FieldOffset(Offset = "0x30")]
	public bool isRunning;

	[Token(Token = "0x4002F1B")]
	[FieldOffset(Offset = "0x34")]
	private int hitCount;

	[Token(Token = "0x4002F1C")]
	[FieldOffset(Offset = "0x38")]
	private IObjectLauncher[] launchers;

	[Token(Token = "0x4002F1D")]
	[FieldOffset(Offset = "0x40")]
	private List<IHitscanTarget> targets;

	[Token(Token = "0x6002798")]
	[Address(RVA = "0x1701854", Offset = "0x1701854", VA = "0x1701854")]
	private void Awake()
	{
	}

	[Token(Token = "0x6002799")]
	[Address(RVA = "0x1701C64", Offset = "0x1701C64", VA = "0x1701C64")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x600279A")]
	[Address(RVA = "0x1701C78", Offset = "0x1701C78", VA = "0x1701C78")]
	public void StartPhase()
	{
	}

	[Token(Token = "0x600279B")]
	[Address(RVA = "0x1701D80", Offset = "0x1701D80", VA = "0x1701D80")]
	private void OnBottleHit(IHitscanTarget obj)
	{
	}

	[Token(Token = "0x600279C")]
	[Address(RVA = "0x1701E3C", Offset = "0x1701E3C", VA = "0x1701E3C")]
	public BottleShooterPhase()
	{
	}
}
