using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000345")]
public class FauxGravity : MonoBehaviour
{
	[Token(Token = "0x4001217")]
	[FieldOffset(Offset = "0x18")]
	private Rigidbody[] r;

	[Token(Token = "0x4001218")]
	[FieldOffset(Offset = "0x20")]
	public Transform center;

	[Token(Token = "0x4001219")]
	[FieldOffset(Offset = "0x28")]
	public List<string> ignoreTags;

	[Token(Token = "0x400121A")]
	[FieldOffset(Offset = "0x30")]
	public float force;

	[Token(Token = "0x400121B")]
	[FieldOffset(Offset = "0x34")]
	[SerializeField]
	private bool _basedOnDist;

	[Token(Token = "0x6000F31")]
	[Address(RVA = "0x1460D0C", Offset = "0x1460D0C", VA = "0x1460D0C")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000F32")]
	[Address(RVA = "0x1460E3C", Offset = "0x1460E3C", VA = "0x1460E3C")]
	private void FixedUpdate()
	{
	}

	[Token(Token = "0x6000F33")]
	[Address(RVA = "0x146109C", Offset = "0x146109C", VA = "0x146109C")]
	public FauxGravity()
	{
	}

	[Token(Token = "0x6000F34")]
	[Address(RVA = "0x14610A4", Offset = "0x14610A4", VA = "0x14610A4")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x6112C", Offset = "0x6112C")]
	private bool _003CAwake_003Eb__5_0(Rigidbody rb)
	{
		return default;
	}
}
