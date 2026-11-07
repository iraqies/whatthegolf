using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000456")]
public class ObjectDestroyTrigger : ObjectDestroyable
{
	[Token(Token = "0x40017A6")]
	[FieldOffset(Offset = "0x28")]
	public bool destroyAnyObject;

	[Token(Token = "0x40017A7")]
	[FieldOffset(Offset = "0x30")]
	public string onlyWithTag;

	[Token(Token = "0x6001457")]
	[Address(RVA = "0x1591900", Offset = "0x1591900", VA = "0x1591900")]
	private void OnTriggerEnter(Collider other)
	{
	}

	[Token(Token = "0x6001458")]
	[Address(RVA = "0x1591AFC", Offset = "0x1591AFC", VA = "0x1591AFC")]
	private void OnTriggerEnter2D(Collider2D other)
	{
	}

	[Token(Token = "0x6001459")]
	[Address(RVA = "0x1591CF8", Offset = "0x1591CF8", VA = "0x1591CF8")]
	public ObjectDestroyTrigger()
	{
	}
}
