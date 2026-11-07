using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

[Token(Token = "0x2000E76")]
public class ClubEquipIcon : MonoBehaviour
{
	[Token(Token = "0x4004E3B")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	private Image m_background;

	[Token(Token = "0x4004E3C")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private SVGImage m_clubImage;

	[Token(Token = "0x4004E3D")]
	[FieldOffset(Offset = "0x28")]
	private RectTransform m_rectTransform;

	[Token(Token = "0x6004394")]
	[Address(RVA = "0x18A5964", Offset = "0x18A5964", VA = "0x18A5964")]
	private void Start()
	{
	}

	[Token(Token = "0x6004395")]
	[Address(RVA = "0x18A59C0", Offset = "0x18A59C0", VA = "0x18A59C0")]
	public void SetIcon(Sprite clubSprite, Color clubColor)
	{
	}

	[Token(Token = "0x6004396")]
	[Address(RVA = "0x18A5A34", Offset = "0x18A5A34", VA = "0x18A5A34")]
	public void SetAsEquipped()
	{
	}

	[Token(Token = "0x6004397")]
	[Address(RVA = "0x18A5A9C", Offset = "0x18A5A9C", VA = "0x18A5A9C")]
	public void SetAsUnequipped()
	{
	}

	[Token(Token = "0x6004398")]
	[Address(RVA = "0x18A5AF8", Offset = "0x18A5AF8", VA = "0x18A5AF8")]
	public ClubEquipIcon()
	{
	}
}
