using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

[Token(Token = "0x200003D")]
public class AlphaButtonClickMask : MonoBehaviour, ICanvasRaycastFilter
{
	[Token(Token = "0x40000F1")]
	[FieldOffset(Offset = "0x18")]
	protected Image _image;

	[Token(Token = "0x600010C")]
	[Address(RVA = "0x12EB554", Offset = "0x12EB554", VA = "0x12EB554")]
	public void Start()
	{
	}

	[Token(Token = "0x600010D")]
	[Address(RVA = "0x12EB750", Offset = "0x12EB750", VA = "0x12EB750", Slot = "4")]
	public bool IsRaycastLocationValid(Vector2 sp, Camera eventCamera)
	{
		return default;
	}

	[Token(Token = "0x600010E")]
	[Address(RVA = "0x12EBA4C", Offset = "0x12EBA4C", VA = "0x12EBA4C")]
	public AlphaButtonClickMask()
	{
	}
}
