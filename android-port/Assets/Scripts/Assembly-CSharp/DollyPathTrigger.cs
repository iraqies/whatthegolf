using System;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x200024E")]
public class DollyPathTrigger : MonoBehaviour
{
	[Token(Token = "0x4000BC1")]
	[FieldOffset(Offset = "0x18")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x4A844", Offset = "0x4A844")]
	private Action<SecondaryDollyPath> m_OnDollyPathEnter;

	[Token(Token = "0x4000BC2")]
	[FieldOffset(Offset = "0x20")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x4A854", Offset = "0x4A854")]
	private Action<SecondaryDollyPath> m_OnDollyPathExit;

	[Token(Token = "0x14000005")]
	public event Action<SecondaryDollyPath> OnDollyPathEnter
	{
		[Token(Token = "0x6000A54")]
		[Address(RVA = "0x14305E8", Offset = "0x14305E8", VA = "0x14305E8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5FC64", Offset = "0x5FC64")]
		add
		{
		}
		[Token(Token = "0x6000A55")]
		[Address(RVA = "0x143068C", Offset = "0x143068C", VA = "0x143068C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5FC74", Offset = "0x5FC74")]
		remove
		{
		}
	}

	[Token(Token = "0x14000006")]
	public event Action<SecondaryDollyPath> OnDollyPathExit
	{
		[Token(Token = "0x6000A56")]
		[Address(RVA = "0x1430730", Offset = "0x1430730", VA = "0x1430730")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5FC84", Offset = "0x5FC84")]
		add
		{
		}
		[Token(Token = "0x6000A57")]
		[Address(RVA = "0x14307D4", Offset = "0x14307D4", VA = "0x14307D4")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5FC94", Offset = "0x5FC94")]
		remove
		{
		}
	}

	[Token(Token = "0x6000A58")]
	[Address(RVA = "0x1430878", Offset = "0x1430878", VA = "0x1430878")]
	private void OnTriggerEnter(Collider other)
	{
	}

	[Token(Token = "0x6000A59")]
	[Address(RVA = "0x14309EC", Offset = "0x14309EC", VA = "0x14309EC")]
	private void OnTriggerExit(Collider other)
	{
	}

	[Token(Token = "0x6000A5A")]
	[Address(RVA = "0x14308F8", Offset = "0x14308F8", VA = "0x14308F8")]
	private bool GetPathOnTrigger(Collider other, out SecondaryDollyPath path)
	{
		return default;
	}

	[Token(Token = "0x6000A5B")]
	[Address(RVA = "0x1430A6C", Offset = "0x1430A6C", VA = "0x1430A6C")]
	public DollyPathTrigger()
	{
	}
}
