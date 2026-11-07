using Core;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000D5F")]
public class BallForBushes : MonoBehaviour
{
	[Token(Token = "0x40048AF")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	public float sqrMagnitudeThreshold;

	[Token(Token = "0x40048B0")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private Rigidbody rigidbody;

	[Token(Token = "0x40048B1")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	private bool AddToControllerBlockingFunctions;

	[Token(Token = "0x40048B2")]
	[FieldOffset(Offset = "0x30")]
	private GolfBallController controller;

	[Token(Token = "0x40048B3")]
	[FieldOffset(Offset = "0x38")]
	private float _orgSqrVelocity;

	[Token(Token = "0x40048B4")]
	[FieldOffset(Offset = "0x3C")]
	private float sqrVelocity;

	[Token(Token = "0x6003EDF")]
	[Address(RVA = "0x1518D50", Offset = "0x1518D50", VA = "0x1518D50")]
	private void OnCollisionEnter(Collision collision)
	{
	}

	[Token(Token = "0x6003EE0")]
	[Address(RVA = "0x1518DDC", Offset = "0x1518DDC", VA = "0x1518DDC")]
	private void Awake()
	{
	}

	[Token(Token = "0x6003EE1")]
	[Address(RVA = "0x1518F9C", Offset = "0x1518F9C", VA = "0x1518F9C")]
	private void ControllerOnOnShoot(Vector3 obj)
	{
	}

	[Token(Token = "0x6003EE2")]
	[Address(RVA = "0x1518FB8", Offset = "0x1518FB8", VA = "0x1518FB8")]
	public bool IsBlocking()
	{
		return default;
	}

	[Token(Token = "0x6003EE3")]
	[Address(RVA = "0x1519020", Offset = "0x1519020", VA = "0x1519020")]
	public BallForBushes()
	{
	}
}
