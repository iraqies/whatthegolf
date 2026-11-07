using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000D93")]
public class Katamari_GrowColliderWhenCollecting : MonoBehaviour
{
	[Token(Token = "0x40049E5")]
	[FieldOffset(Offset = "0x18")]
	public float GrowRate;

	[Token(Token = "0x40049E6")]
	[FieldOffset(Offset = "0x20")]
	public Transform trans;

	[Token(Token = "0x40049E7")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	private float duration;

	[Token(Token = "0x40049E8")]
	[FieldOffset(Offset = "0x2C")]
	private Vector3 from;

	[Token(Token = "0x40049E9")]
	[FieldOffset(Offset = "0x38")]
	private Vector3 to;

	[Token(Token = "0x6003FD4")]
	[Address(RVA = "0x14FC3E0", Offset = "0x14FC3E0", VA = "0x14FC3E0")]
	private void Awake()
	{
	}

	[Token(Token = "0x6003FD5")]
	[Address(RVA = "0x14FC490", Offset = "0x14FC490", VA = "0x14FC490")]
	private void OnCollisionEnter(Collision other)
	{
	}

	[Token(Token = "0x6003FD6")]
	[Address(RVA = "0x14FC524", Offset = "0x14FC524", VA = "0x14FC524")]
	public void Grow()
	{
	}

	[Token(Token = "0x6003FD7")]
	[Address(RVA = "0x14FC630", Offset = "0x14FC630", VA = "0x14FC630")]
	public Katamari_GrowColliderWhenCollecting()
	{
	}

	[Token(Token = "0x6003FD8")]
	[Address(RVA = "0x14FC66C", Offset = "0x14FC66C", VA = "0x14FC66C")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x6CB3C", Offset = "0x6CB3C")]
	private void _003CGrow_003Eb__7_0(float t)
	{
	}
}
