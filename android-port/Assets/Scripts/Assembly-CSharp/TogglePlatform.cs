using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000131")]
public class TogglePlatform : MonoBehaviour
{
	[Token(Token = "0x4000544")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	private Transform Position1;

	[Token(Token = "0x4000545")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private Transform Position2;

	[Token(Token = "0x4000546")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	private Transform MovableTransform;

	[Token(Token = "0x4000547")]
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	private float moveSpeed;

	[Token(Token = "0x4000548")]
	[FieldOffset(Offset = "0x34")]
	[SerializeField]
	private float turnSpeed;

	[Token(Token = "0x4000549")]
	[FieldOffset(Offset = "0x38")]
	private bool isToggled;

	[Token(Token = "0x400054A")]
	[FieldOffset(Offset = "0x40")]
	private Transform _currentTarget;

	[Token(Token = "0x6000536")]
	[Address(RVA = "0x171C52C", Offset = "0x171C52C", VA = "0x171C52C")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000537")]
	[Address(RVA = "0x171C59C", Offset = "0x171C59C", VA = "0x171C59C")]
	private void Update()
	{
	}

	[Token(Token = "0x6000538")]
	[Address(RVA = "0x171C5F4", Offset = "0x171C5F4", VA = "0x171C5F4")]
	public void Toggle()
	{
	}

	[Token(Token = "0x6000539")]
	[Address(RVA = "0x171C62C", Offset = "0x171C62C", VA = "0x171C62C")]
	public void SetStatus(bool on)
	{
	}

	[Token(Token = "0x600053A")]
	[Address(RVA = "0x171C65C", Offset = "0x171C65C", VA = "0x171C65C")]
	private void FixedUpdate()
	{
	}

	[Token(Token = "0x600053B")]
	[Address(RVA = "0x171C538", Offset = "0x171C538", VA = "0x171C538")]
	private void LockPosition()
	{
	}

	[Token(Token = "0x600053C")]
	[Address(RVA = "0x171C8D0", Offset = "0x171C8D0", VA = "0x171C8D0")]
	public TogglePlatform()
	{
	}
}
