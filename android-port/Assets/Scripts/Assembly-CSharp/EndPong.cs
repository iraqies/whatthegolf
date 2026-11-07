using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x20009B0")]
public class EndPong : MonoBehaviour
{
	[Token(Token = "0x4003543")]
	[FieldOffset(Offset = "0x18")]
	public float speed;

	[Token(Token = "0x4003544")]
	[FieldOffset(Offset = "0x20")]
	public Transform target;

	[Token(Token = "0x4003545")]
	[FieldOffset(Offset = "0x28")]
	public float width;

	[Token(Token = "0x4003546")]
	[FieldOffset(Offset = "0x30")]
	private Rigidbody2D rigid;

	[Token(Token = "0x4003547")]
	[FieldOffset(Offset = "0x38")]
	private Vector3 basePos;

	[Token(Token = "0x4003548")]
	[FieldOffset(Offset = "0x44")]
	private float movementSpeed;

	[Token(Token = "0x6002D8F")]
	[Address(RVA = "0x1444758", Offset = "0x1444758", VA = "0x1444758")]
	private void Awake()
	{
	}

	[Token(Token = "0x6002D90")]
	[Address(RVA = "0x14447D0", Offset = "0x14447D0", VA = "0x14447D0")]
	private void Update()
	{
	}

	[Token(Token = "0x6002D91")]
	[Address(RVA = "0x1444918", Offset = "0x1444918", VA = "0x1444918")]
	private void OnDrawGizmosSelected()
	{
	}

	[Token(Token = "0x6002D92")]
	[Address(RVA = "0x1444A1C", Offset = "0x1444A1C", VA = "0x1444A1C")]
	public EndPong()
	{
	}
}
