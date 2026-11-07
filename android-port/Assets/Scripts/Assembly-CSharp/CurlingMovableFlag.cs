using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x20001EE")]
public class CurlingMovableFlag : MonoBehaviour
{
	[Token(Token = "0x400094F")]
	[FieldOffset(Offset = "0x18")]
	public bool moveWhenBroomed;

	[Token(Token = "0x4000950")]
	[FieldOffset(Offset = "0x1C")]
	public float moveDistance;

	[Token(Token = "0x4000951")]
	[FieldOffset(Offset = "0x20")]
	public float moveSpeed;

	[Token(Token = "0x4000952")]
	[FieldOffset(Offset = "0x28")]
	private Rigidbody rbody;

	[Token(Token = "0x4000953")]
	[FieldOffset(Offset = "0x30")]
	private Vector3 originPos;

	[Token(Token = "0x4000954")]
	[FieldOffset(Offset = "0x3C")]
	private Vector3 moveSpeedVector;

	[Token(Token = "0x4000955")]
	[FieldOffset(Offset = "0x48")]
	private bool moving;

	[Token(Token = "0x60008AF")]
	[Address(RVA = "0x18C5570", Offset = "0x18C5570", VA = "0x18C5570")]
	private void Start()
	{
	}

	[Token(Token = "0x60008B0")]
	[Address(RVA = "0x18C55E4", Offset = "0x18C55E4", VA = "0x18C55E4")]
	private void FixedUpdate()
	{
	}

	[Token(Token = "0x60008B1")]
	[Address(RVA = "0x18C570C", Offset = "0x18C570C", VA = "0x18C570C")]
	private void OnCollisionEnter(Collision collision)
	{
	}

	[Token(Token = "0x60008B2")]
	[Address(RVA = "0x18C57F8", Offset = "0x18C57F8", VA = "0x18C57F8")]
	public CurlingMovableFlag()
	{
	}
}
