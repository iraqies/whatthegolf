using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x20005B6")]
public class HorseShooter : MonoBehaviour
{
	[Token(Token = "0x4001D2A")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	private Transform frontTransform;

	[Token(Token = "0x4001D2B")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private Transform backTransform;

	[Token(Token = "0x4001D2C")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	private float distance;

	[Token(Token = "0x4001D2D")]
	[FieldOffset(Offset = "0x30")]
	private Rigidbody rigidbody;

	[Token(Token = "0x4001D2E")]
	[FieldOffset(Offset = "0x38")]
	private float sphereCastRadius;

	[Token(Token = "0x4001D2F")]
	[FieldOffset(Offset = "0x3C")]
	private int layerMask;

	[Token(Token = "0x60019EE")]
	[Address(RVA = "0x14D8904", Offset = "0x14D8904", VA = "0x14D8904")]
	private void Awake()
	{
	}

	[Token(Token = "0x60019EF")]
	[Address(RVA = "0x14D89FC", Offset = "0x14D89FC", VA = "0x14D89FC")]
	private void FixedUpdate()
	{
	}

	[Token(Token = "0x60019F0")]
	[Address(RVA = "0x14D8AA0", Offset = "0x14D8AA0", VA = "0x14D8AA0")]
	private Vector3 CalculateTarget(Vector3 position)
	{
		return default;
	}

	[Token(Token = "0x60019F1")]
	[Address(RVA = "0x14D8D00", Offset = "0x14D8D00", VA = "0x14D8D00")]
	public void Bounce()
	{
	}

	[Token(Token = "0x60019F2")]
	[Address(RVA = "0x14D8D74", Offset = "0x14D8D74", VA = "0x14D8D74")]
	public HorseShooter()
	{
	}
}
