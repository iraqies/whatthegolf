using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000B8C")]
public class ChangeBallOnShot : MonoBehaviour
{
	[Token(Token = "0x4004054")]
	[FieldOffset(Offset = "0x18")]
	public List<GameObject> OtherBalls;

	[Token(Token = "0x4004055")]
	[FieldOffset(Offset = "0x20")]
	public ParticleSystem ChangeParticles;

	[Token(Token = "0x4004056")]
	[FieldOffset(Offset = "0x28")]
	private GameObject currentBall;

	[Token(Token = "0x60037BA")]
	[Address(RVA = "0x1895EDC", Offset = "0x1895EDC", VA = "0x1895EDC")]
	private void Start()
	{
	}

	[Token(Token = "0x60037BB")]
	[Address(RVA = "0x1896020", Offset = "0x1896020", VA = "0x1896020")]
	private void OnShoot(Vector3 boost)
	{
	}

	[Token(Token = "0x60037BC")]
	[Address(RVA = "0x1896024", Offset = "0x1896024", VA = "0x1896024")]
	private void ChangeBall()
	{
	}

	[Token(Token = "0x60037BD")]
	[Address(RVA = "0x189617C", Offset = "0x189617C", VA = "0x189617C")]
	public ChangeBallOnShot()
	{
	}
}
