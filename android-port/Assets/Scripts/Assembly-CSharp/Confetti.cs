using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000596")]
public class Confetti : MonoBehaviour
{
	[Token(Token = "0x4001C85")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	private Rigidbody2D rigidbody;

	[Token(Token = "0x4001C86")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private Renderer renderer;

	[Token(Token = "0x4001C87")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	private List<Material> materials;

	[Token(Token = "0x4001C88")]
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	private float lifeTime;

	[Token(Token = "0x4001C89")]
	[FieldOffset(Offset = "0x34")]
	[SerializeField]
	private Vector2 shootForceRange;

	[Token(Token = "0x4001C8A")]
	[FieldOffset(Offset = "0x3C")]
	[SerializeField]
	private float minVelocity;

	[Token(Token = "0x4001C8B")]
	[FieldOffset(Offset = "0x40")]
	private float spawnTime;

	[Token(Token = "0x4001C8C")]
	[FieldOffset(Offset = "0x44")]
	private float startDrag;

	[Token(Token = "0x4001C8D")]
	[FieldOffset(Offset = "0x48")]
	private int preventionzoneDepth;

	[Token(Token = "0x4001C8E")]
	[FieldOffset(Offset = "0x50")]
	private ConfettiPrevention lastPrevention;

	[Token(Token = "0x4001C8F")]
	[FieldOffset(Offset = "0x58")]
	private float lifeTimeLeft;

	[Token(Token = "0x4001C90")]
	[FieldOffset(Offset = "0x5C")]
	private Vector3 startScale;

	[Token(Token = "0x4001C91")]
	[FieldOffset(Offset = "0x68")]
	private float originalDrag;

	[Token(Token = "0x6001970")]
	[Address(RVA = "0x18AB034", Offset = "0x18AB034", VA = "0x18AB034")]
	private void Awake()
	{
	}

	[Token(Token = "0x6001971")]
	[Address(RVA = "0x18AB084", Offset = "0x18AB084", VA = "0x18AB084")]
	public void Initiate()
	{
	}

	[Token(Token = "0x6001972")]
	[Address(RVA = "0x18AB2A0", Offset = "0x18AB2A0", VA = "0x18AB2A0")]
	private void OnTriggerEnter2D(Collider2D collision)
	{
	}

	[Token(Token = "0x6001973")]
	[Address(RVA = "0x18AB364", Offset = "0x18AB364", VA = "0x18AB364")]
	private void OnTriggerExit2D(Collider2D collision)
	{
	}

	[Token(Token = "0x6001974")]
	[Address(RVA = "0x18AB428", Offset = "0x18AB428", VA = "0x18AB428")]
	private void Kill()
	{
	}

	[Token(Token = "0x6001975")]
	[Address(RVA = "0x18AB450", Offset = "0x18AB450", VA = "0x18AB450")]
	private void FixedUpdate()
	{
	}

	[Token(Token = "0x6001976")]
	[Address(RVA = "0x18AB60C", Offset = "0x18AB60C", VA = "0x18AB60C")]
	public Confetti()
	{
	}
}
