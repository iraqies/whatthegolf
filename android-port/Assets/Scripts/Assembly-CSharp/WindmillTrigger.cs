using System;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000992")]
public class WindmillTrigger : MonoBehaviour
{
	[Token(Token = "0x40034C8")]
	[FieldOffset(Offset = "0x18")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x4FD5C", Offset = "0x4FD5C")]
	private Action<OverworldBall2D> m_OnTriggered;

	[Token(Token = "0x14000049")]
	public event Action<OverworldBall2D> OnTriggered
	{
		[Token(Token = "0x6002CDC")]
		[Address(RVA = "0x1758FA4", Offset = "0x1758FA4", VA = "0x1758FA4")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x68264", Offset = "0x68264")]
		add
		{
		}
		[Token(Token = "0x6002CDD")]
		[Address(RVA = "0x1759048", Offset = "0x1759048", VA = "0x1759048")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x68274", Offset = "0x68274")]
		remove
		{
		}
	}

	[Token(Token = "0x6002CDE")]
	[Address(RVA = "0x17590EC", Offset = "0x17590EC", VA = "0x17590EC")]
	private void OnTriggerEnter2D(Collider2D collision)
	{
	}

	[Token(Token = "0x6002CDF")]
	[Address(RVA = "0x17591D4", Offset = "0x17591D4", VA = "0x17591D4")]
	public WindmillTrigger()
	{
	}
}
