using System.Collections.Generic;
using Core;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x200000F")]
public class ActivateObjectsOnShoot : MonoBehaviour
{
	[Token(Token = "0x4000032")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	private GolfBallController controller;

	[Token(Token = "0x4000033")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private List<GameObject> Objects;

	[Token(Token = "0x4000034")]
	[FieldOffset(Offset = "0x28")]
	private int index;

	[Token(Token = "0x6000042")]
	[Address(RVA = "0x1404F90", Offset = "0x1404F90", VA = "0x1404F90")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x6000043")]
	[Address(RVA = "0x1405040", Offset = "0x1405040", VA = "0x1405040")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x6000044")]
	[Address(RVA = "0x14050F0", Offset = "0x14050F0", VA = "0x14050F0")]
	private void Controller_OnShoot(Vector3 obj)
	{
	}

	[Token(Token = "0x6000045")]
	[Address(RVA = "0x1405194", Offset = "0x1405194", VA = "0x1405194")]
	public ActivateObjectsOnShoot()
	{
	}
}
