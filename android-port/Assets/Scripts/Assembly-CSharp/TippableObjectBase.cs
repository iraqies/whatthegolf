using System;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000B35")]
public abstract class TippableObjectBase : MonoBehaviour
{
	[Token(Token = "0x4003E8E")]
	[FieldOffset(Offset = "0x18")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x508B8", Offset = "0x508B8")]
	private Action<GameObject> OnTip__BackingField;

	[Token(Token = "0x1700056E")]
	public Action<GameObject> OnTip
	{
		[Token(Token = "0x6003559")]
		[Address(RVA = "0x1718794", Offset = "0x1718794", VA = "0x1718794")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6A938", Offset = "0x6A938")]
		get
		{
			return null;
		}
		[Token(Token = "0x600355A")]
		[Address(RVA = "0x171879C", Offset = "0x171879C", VA = "0x171879C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6A948", Offset = "0x6A948")]
		set
		{
		}
	}

	[Token(Token = "0x600355B")]
	[Address(RVA = "0x1718560", Offset = "0x1718560", VA = "0x1718560")]
	protected TippableObjectBase()
	{
	}
}
