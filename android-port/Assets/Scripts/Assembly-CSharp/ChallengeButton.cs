using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000031")]
public class ChallengeButton : MonoBehaviour
{
	[Token(Token = "0x40000B0")]
	[FieldOffset(Offset = "0x18")]
	public bool disableOnExit;

	[Token(Token = "0x40000B1")]
	[FieldOffset(Offset = "0x20")]
	private Animator m_Animator;

	[Token(Token = "0x40000B2")]
	[FieldOffset(Offset = "0x28")]
	private List<Rigidbody> m_rigidsOnTop;

	[Token(Token = "0x40000B3")]
	[FieldOffset(Offset = "0x30")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x49308", Offset = "0x49308")]
	private bool IsButtonOn__BackingField;

	[Token(Token = "0x40000B4")]
	[FieldOffset(Offset = "0x38")]
	public Action<ChallengeButton> OnButtonTrigger;

	[Token(Token = "0x1700002D")]
	public bool IsButtonOn
	{
		[Token(Token = "0x60000B8")]
		[Address(RVA = "0x18927EC", Offset = "0x18927EC", VA = "0x18927EC")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5D184", Offset = "0x5D184")]
		get
		{
			return default;
		}
		[Token(Token = "0x60000B9")]
		[Address(RVA = "0x18927F4", Offset = "0x18927F4", VA = "0x18927F4")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5D194", Offset = "0x5D194")]
		set
		{
		}
	}

	[Token(Token = "0x60000BA")]
	[Address(RVA = "0x18927FC", Offset = "0x18927FC", VA = "0x18927FC")]
	private void Awake()
	{
	}

	[Token(Token = "0x60000BB")]
	[Address(RVA = "0x1892858", Offset = "0x1892858", VA = "0x1892858")]
	private void OnTriggerEnter(Collider other)
	{
	}

	[Token(Token = "0x60000BC")]
	[Address(RVA = "0x1892A3C", Offset = "0x1892A3C", VA = "0x1892A3C")]
	private void OnTriggerExit(Collider other)
	{
	}

	[Token(Token = "0x60000BD")]
	[Address(RVA = "0x1892BC4", Offset = "0x1892BC4", VA = "0x1892BC4")]
	public ChallengeButton()
	{
	}
}
