using Core;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000829")]
public class LaserSight : MonoBehaviour
{
	[Token(Token = "0x4002BFE")]
	[FieldOffset(Offset = "0x18")]
	public LayerMask HitLayers;

	[Token(Token = "0x4002BFF")]
	[FieldOffset(Offset = "0x1C")]
	public float Distance;

	[Token(Token = "0x4002C00")]
	[FieldOffset(Offset = "0x20")]
	public float RaycastRadius;

	[Token(Token = "0x4002C01")]
	[FieldOffset(Offset = "0x28")]
	private LineRenderer line;

	[Token(Token = "0x4002C02")]
	[FieldOffset(Offset = "0x30")]
	private GolfBallController owner;

	[Token(Token = "0x600258B")]
	[Address(RVA = "0x151E2A0", Offset = "0x151E2A0", VA = "0x151E2A0")]
	private void Awake()
	{
	}

	[Token(Token = "0x600258C")]
	[Address(RVA = "0x151E2FC", Offset = "0x151E2FC", VA = "0x151E2FC")]
	public void SetOwner(GolfBallController controller)
	{
	}

	[Token(Token = "0x600258D")]
	[Address(RVA = "0x151E48C", Offset = "0x151E48C", VA = "0x151E48C")]
	private void BallOnOnAimUpdate(Vector3 boost, bool b)
	{
	}

	[Token(Token = "0x600258E")]
	[Address(RVA = "0x151E704", Offset = "0x151E704", VA = "0x151E704")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x600258F")]
	[Address(RVA = "0x151E748", Offset = "0x151E748", VA = "0x151E748")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x6002590")]
	[Address(RVA = "0x151E768", Offset = "0x151E768", VA = "0x151E768")]
	public LaserSight()
	{
	}
}
