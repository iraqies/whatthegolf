using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000802")]
public class ScaleChangePortal : SimplePortal
{
	[Token(Token = "0x4002AFC")]
	[FieldOffset(Offset = "0x10C")]
	public Vector3 MaxScaleAllowed;

	[Token(Token = "0x4002AFD")]
	[FieldOffset(Offset = "0x118")]
	public float ScaleChange;

	[Token(Token = "0x60024C5")]
	[Address(RVA = "0x1679D4C", Offset = "0x1679D4C", VA = "0x1679D4C", Slot = "5")]
	protected override void RecieveObject(GameObject go)
	{
	}

	[Token(Token = "0x60024C6")]
	[Address(RVA = "0x1679DB0", Offset = "0x1679DB0", VA = "0x1679DB0", Slot = "4")]
	protected override void ObjectEnteredTrigger(GameObject other)
	{
	}

	[Token(Token = "0x60024C7")]
	[Address(RVA = "0x1679E44", Offset = "0x1679E44", VA = "0x1679E44")]
	public ScaleChangePortal()
	{
	}
}
