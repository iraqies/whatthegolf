using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000457")]
public abstract class ObjectDestroyable : MonoBehaviour
{
	[Token(Token = "0x40017A8")]
	[FieldOffset(Offset = "0x18")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x4D6C4", Offset = "0x4D6C4")]
	private Action<GameObject> onDestroyObject__BackingField;

	[Token(Token = "0x40017A9")]
	[FieldOffset(Offset = "0x20")]
	public List<GameObject> destroyableObjects;

	[Token(Token = "0x17000240")]
	public Action<GameObject> onDestroyObject
	{
		[Token(Token = "0x600145A")]
		[Address(RVA = "0x1591D60", Offset = "0x1591D60", VA = "0x1591D60")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x621BC", Offset = "0x621BC")]
		get
		{
			return null;
		}
		[Token(Token = "0x600145B")]
		[Address(RVA = "0x1591D68", Offset = "0x1591D68", VA = "0x1591D68")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x621CC", Offset = "0x621CC")]
		set
		{
		}
	}

	[Token(Token = "0x600145C")]
	[Address(RVA = "0x1591D58", Offset = "0x1591D58", VA = "0x1591D58")]
	protected ObjectDestroyable()
	{
	}
}
