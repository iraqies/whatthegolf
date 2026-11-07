using Core;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x200084B")]
public class FakeSkeleton : MonoBehaviour
{
	[Token(Token = "0x4002CF0")]
	[FieldOffset(Offset = "0x18")]
	public MonoBehaviour[] thingsToDisable;

	[Token(Token = "0x4002CF1")]
	[FieldOffset(Offset = "0x20")]
	public Rigidbody rigid;

	[Token(Token = "0x4002CF2")]
	[FieldOffset(Offset = "0x28")]
	public GolfBallController ballController;

	[Token(Token = "0x4002CF3")]
	[FieldOffset(Offset = "0x30")]
	public Rigidbody fakeBall;

	[Token(Token = "0x4002CF4")]
	[FieldOffset(Offset = "0x38")]
	public Vector3 throwDir;

	[Token(Token = "0x4002CF5")]
	[FieldOffset(Offset = "0x44")]
	public float throwForce;

	[Token(Token = "0x4002CF6")]
	[FieldOffset(Offset = "0x48")]
	private Vector3 fakeBallStartPos;

	[Token(Token = "0x6002644")]
	[Address(RVA = "0x145CAF0", Offset = "0x145CAF0", VA = "0x145CAF0")]
	private void Start()
	{
	}

	[Token(Token = "0x6002645")]
	[Address(RVA = "0x145CC1C", Offset = "0x145CC1C", VA = "0x145CC1C")]
	public void Instance_OnOutOfBounds()
	{
	}

	[Token(Token = "0x6002646")]
	[Address(RVA = "0x145CC88", Offset = "0x145CC88", VA = "0x145CC88")]
	private void BallController_OnShoot(Vector3 obj)
	{
	}

	[Token(Token = "0x6002647")]
	[Address(RVA = "0x145CE14", Offset = "0x145CE14", VA = "0x145CE14")]
	private void OnTriggerStay(Collider other)
	{
	}

	[Token(Token = "0x6002648")]
	[Address(RVA = "0x145CF14", Offset = "0x145CF14", VA = "0x145CF14")]
	public FakeSkeleton()
	{
	}
}
