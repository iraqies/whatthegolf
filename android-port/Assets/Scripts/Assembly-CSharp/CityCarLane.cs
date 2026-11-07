using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000282")]
public class CityCarLane : MonoBehaviour
{
	[Token(Token = "0x4000D37")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	private float minDelay;

	[Token(Token = "0x4000D38")]
	[FieldOffset(Offset = "0x1C")]
	[SerializeField]
	private float maxDelay;

	[Token(Token = "0x4000D39")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private float startDelay;

	[Token(Token = "0x4000D3A")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	private Collider enterCollider;

	[Token(Token = "0x4000D3B")]
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	private Collider exitCollider;

	[Token(Token = "0x4000D3C")]
	[FieldOffset(Offset = "0x38")]
	[SerializeField]
	private CityCar[] cars;

	[Token(Token = "0x4000D3D")]
	[FieldOffset(Offset = "0x40")]
	private int index;

	[Token(Token = "0x4000D3E")]
	[FieldOffset(Offset = "0x44")]
	private float nextSpawnTime;

	[Token(Token = "0x6000B66")]
	[Address(RVA = "0x189F008", Offset = "0x189F008", VA = "0x189F008")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000B67")]
	[Address(RVA = "0x189F1F8", Offset = "0x189F1F8", VA = "0x189F1F8")]
	private void Update()
	{
	}

	[Token(Token = "0x6000B68")]
	[Address(RVA = "0x189F380", Offset = "0x189F380", VA = "0x189F380")]
	private void Car_OnEnterEnd(CityCar car)
	{
	}

	[Token(Token = "0x6000B69")]
	[Address(RVA = "0x189F45C", Offset = "0x189F45C", VA = "0x189F45C")]
	public CityCarLane()
	{
	}
}
