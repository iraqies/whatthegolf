using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x20006E6")]
public class OutOfBoundsTrigger : MonoBehaviour
{
	[Token(Token = "0x4002421")]
	[FieldOffset(Offset = "0x18")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x4E644", Offset = "0x4E644")]
	private Action<OutOfBoundsTrigger> m_OnOutOfBounds;

	[Token(Token = "0x4002422")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private List<string> boundsTags;

	[Token(Token = "0x4002423")]
	[FieldOffset(Offset = "0x28")]
	private bool didTrigger;

	[Token(Token = "0x1400002F")]
	public event Action<OutOfBoundsTrigger> OnOutOfBounds
	{
		[Token(Token = "0x6001FD2")]
		[Address(RVA = "0x159E730", Offset = "0x159E730", VA = "0x159E730")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x65758", Offset = "0x65758")]
		add
		{
		}
		[Token(Token = "0x6001FD3")]
		[Address(RVA = "0x159EA64", Offset = "0x159EA64", VA = "0x159EA64")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x65768", Offset = "0x65768")]
		remove
		{
		}
	}

	[Token(Token = "0x6001FD4")]
	[Address(RVA = "0x159EB08", Offset = "0x159EB08", VA = "0x159EB08")]
	public void Reset()
	{
	}

	[Token(Token = "0x6001FD5")]
	[Address(RVA = "0x159EB10", Offset = "0x159EB10", VA = "0x159EB10")]
	public void OutOfBounds()
	{
	}

	[Token(Token = "0x6001FD6")]
	[Address(RVA = "0x159EB68", Offset = "0x159EB68", VA = "0x159EB68")]
	private void OnTriggerEnter(Collider other)
	{
	}

	[Token(Token = "0x6001FD7")]
	[Address(RVA = "0x159EC40", Offset = "0x159EC40", VA = "0x159EC40")]
	public OutOfBoundsTrigger()
	{
	}
}
