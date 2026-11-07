using System.Collections.Generic;
using CameraStack;
using Core;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000407")]
public class ExplodeChallenge : Challenge
{
	[Token(Token = "0x40015FA")]
	[FieldOffset(Offset = "0xA8")]
	public FlyingExplosionShooter flyingExplosionShooterPrefab;

	[Token(Token = "0x40015FB")]
	[FieldOffset(Offset = "0xB0")]
	public Transform spawnPoint;

	[Token(Token = "0x40015FC")]
	[FieldOffset(Offset = "0xB8")]
	private FlyingExplosionShooter _currentFlyingExplosion;

	[Token(Token = "0x40015FD")]
	[FieldOffset(Offset = "0xC0")]
	private CBFollow _cbFollow;

	[Token(Token = "0x40015FE")]
	[FieldOffset(Offset = "0xC8")]
	public int destructionToWin;

	[Token(Token = "0x40015FF")]
	[FieldOffset(Offset = "0xCC")]
	private int _destructionCount;

	[Token(Token = "0x4001600")]
	[FieldOffset(Offset = "0xD0")]
	public List<GameObject> objectsToDestroy;

	[Token(Token = "0x4001601")]
	[FieldOffset(Offset = "0xD8")]
	public float explosionPower;

	[Token(Token = "0x60012EF")]
	[Address(RVA = "0x144F7B0", Offset = "0x144F7B0", VA = "0x144F7B0", Slot = "8")]
	protected override void Activate()
	{
	}

	[Token(Token = "0x60012F0")]
	[Address(RVA = "0x144FF20", Offset = "0x144FF20", VA = "0x144FF20")]
	private void OnOnOutOfBounds(OutOfBoundsTrigger obj)
	{
	}

	[Token(Token = "0x60012F1")]
	[Address(RVA = "0x144FC64", Offset = "0x144FC64", VA = "0x144FC64")]
	private void SpawnNewBarrel()
	{
	}

	[Token(Token = "0x60012F2")]
	[Address(RVA = "0x1450014", Offset = "0x1450014", VA = "0x1450014")]
	private void OnExplode(GameObject explodeObject)
	{
	}

	[Token(Token = "0x60012F3")]
	[Address(RVA = "0x1450114", Offset = "0x1450114", VA = "0x1450114")]
	public ExplodeChallenge()
	{
	}
}
