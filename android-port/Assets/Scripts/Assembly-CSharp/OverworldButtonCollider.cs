using System;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x20009F2")]
public class OverworldButtonCollider : MonoBehaviour
{
	[Token(Token = "0x40036CF")]
	[FieldOffset(Offset = "0x18")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x50104", Offset = "0x50104")]
	private Action m_OnBallHit;

	[Token(Token = "0x1400005A")]
	public event Action OnBallHit
	{
		[Token(Token = "0x6002F1F")]
		[Address(RVA = "0x15A86A8", Offset = "0x15A86A8", VA = "0x15A86A8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x68CE8", Offset = "0x68CE8")]
		add
		{
		}
		[Token(Token = "0x6002F20")]
		[Address(RVA = "0x15ADAB8", Offset = "0x15ADAB8", VA = "0x15ADAB8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x68CF8", Offset = "0x68CF8")]
		remove
		{
		}
	}

	[Token(Token = "0x6002F21")]
	[Address(RVA = "0x15ADB5C", Offset = "0x15ADB5C", VA = "0x15ADB5C")]
	private void OnCollisionEnter(Collision collision)
	{
	}

	[Token(Token = "0x6002F22")]
	[Address(RVA = "0x15ADC30", Offset = "0x15ADC30", VA = "0x15ADC30")]
	public OverworldButtonCollider()
	{
	}
}
