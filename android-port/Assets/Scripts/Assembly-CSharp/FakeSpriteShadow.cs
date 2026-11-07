using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x200010A")]
public class FakeSpriteShadow : MonoBehaviour
{
	[Token(Token = "0x400048D")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	private SpriteRenderer shadowSprite;

	[Token(Token = "0x400048E")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private float maxDistance;

	[Token(Token = "0x400048F")]
	[FieldOffset(Offset = "0x24")]
	private Vector3 _maxSize;

	[Token(Token = "0x4000490")]
	[FieldOffset(Offset = "0x30")]
	private Transform _transform;

	[Token(Token = "0x4000491")]
	[FieldOffset(Offset = "0x38")]
	private LayerMask groundLayerMask;

	[Token(Token = "0x4000492")]
	[FieldOffset(Offset = "0x40")]
	private Transform _spriteTransform;

	[Token(Token = "0x6000485")]
	[Address(RVA = "0x145CF24", Offset = "0x145CF24", VA = "0x145CF24")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000486")]
	[Address(RVA = "0x145D03C", Offset = "0x145D03C", VA = "0x145D03C")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x6000487")]
	[Address(RVA = "0x145D10C", Offset = "0x145D10C", VA = "0x145D10C")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x6000488")]
	[Address(RVA = "0x145D1C0", Offset = "0x145D1C0", VA = "0x145D1C0")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x6000489")]
	[Address(RVA = "0x145D274", Offset = "0x145D274", VA = "0x145D274")]
	private void FixedUpdate()
	{
	}

	[Token(Token = "0x600048A")]
	[Address(RVA = "0x145D42C", Offset = "0x145D42C", VA = "0x145D42C")]
	public FakeSpriteShadow()
	{
	}
}
