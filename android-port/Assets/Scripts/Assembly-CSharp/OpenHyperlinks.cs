using Il2CppDummyDll;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;

[Token(Token = "0x20008E8")]
[Attribute(Name = "RequireComponent", RVA = "0x41DC8", Offset = "0x41DC8")]
public class OpenHyperlinks : MonoBehaviour, IPointerClickHandler, IEventSystemHandler
{
	[Token(Token = "0x40030C2")]
	[FieldOffset(Offset = "0x18")]
	public TextMeshProUGUI pTextMeshPro;

	[Token(Token = "0x40030C3")]
	[FieldOffset(Offset = "0x20")]
	public Camera camera;

	[Token(Token = "0x6002937")]
	[Address(RVA = "0x159CA58", Offset = "0x159CA58", VA = "0x159CA58", Slot = "4")]
	public void OnPointerClick(PointerEventData eventData)
	{
	}

	[Token(Token = "0x6002938")]
	[Address(RVA = "0x159CB84", Offset = "0x159CB84", VA = "0x159CB84")]
	public void OpenLink()
	{
	}

	[Token(Token = "0x6002939")]
	[Address(RVA = "0x159CBD4", Offset = "0x159CBD4", VA = "0x159CBD4")]
	public OpenHyperlinks()
	{
	}
}
