using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000715")]
public class DramaticRemoveObjectOnHit : MonoBehaviour
{
	[Token(Token = "0x4002552")]
	[FieldOffset(Offset = "0x18")]
	public Vector2 DisappearDirection;

	[Token(Token = "0x4002553")]
	[FieldOffset(Offset = "0x20")]
	public LayerMask ValidObjects;

	[Token(Token = "0x4002554")]
	[FieldOffset(Offset = "0x24")]
	public float DisappearSpeed;

	[Token(Token = "0x4002555")]
	[FieldOffset(Offset = "0x28")]
	public float DisappearDuration;

	[Token(Token = "0x4002556")]
	[FieldOffset(Offset = "0x2C")]
	private bool isDisappearing;

	[Token(Token = "0x4002557")]
	[FieldOffset(Offset = "0x30")]
	private Rigidbody2D rigid;

	[Token(Token = "0x4002558")]
	[FieldOffset(Offset = "0x38")]
	private float timer;

	[Token(Token = "0x60020BB")]
	[Address(RVA = "0x14347FC", Offset = "0x14347FC", VA = "0x14347FC")]
	private void Start()
	{
	}

	[Token(Token = "0x60020BC")]
	[Address(RVA = "0x1434858", Offset = "0x1434858", VA = "0x1434858")]
	private void Update()
	{
	}

	[Token(Token = "0x60020BD")]
	[Address(RVA = "0x14348C8", Offset = "0x14348C8", VA = "0x14348C8")]
	private void FixedUpdate()
	{
	}

	[Token(Token = "0x60020BE")]
	[Address(RVA = "0x1434968", Offset = "0x1434968", VA = "0x1434968")]
	private void ObjectHit(GameObject hit)
	{
	}

	[Token(Token = "0x60020BF")]
	[Address(RVA = "0x1434A1C", Offset = "0x1434A1C", VA = "0x1434A1C")]
	private void OnCollisionEnter2D(Collision2D col)
	{
	}

	[Token(Token = "0x60020C0")]
	[Address(RVA = "0x1434A54", Offset = "0x1434A54", VA = "0x1434A54")]
	private void OnTriggerEnter2D(Collider2D col)
	{
	}

	[Token(Token = "0x60020C1")]
	[Address(RVA = "0x1434A8C", Offset = "0x1434A8C", VA = "0x1434A8C")]
	public DramaticRemoveObjectOnHit()
	{
	}
}
