using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x200049B")]
public class DisableObjectIfCollectableNotUnlocked : MonoBehaviour
{
	[Token(Token = "0x4001860")]
	[FieldOffset(Offset = "0x18")]
	public Collectable Collectable;

	[Token(Token = "0x6001555")]
	[Address(RVA = "0x18DD4B4", Offset = "0x18DD4B4", VA = "0x18DD4B4")]
	private void Awake()
	{
	}

	[Token(Token = "0x6001556")]
	[Address(RVA = "0x18DD50C", Offset = "0x18DD50C", VA = "0x18DD50C")]
	public DisableObjectIfCollectableNotUnlocked()
	{
	}
}
