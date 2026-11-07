using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.EventSystems;

namespace TMPro
{
	[Token(Token = "0x200004C")]
	public class TMP_ScrollbarEventHandler : MonoBehaviour, IPointerClickHandler, IEventSystemHandler, ISelectHandler, IDeselectHandler
	{
		[Token(Token = "0x4000259")]
		[FieldOffset(Offset = "0x18")]
		public bool isSelected;

		[Token(Token = "0x6000248")]
		[Address(RVA = "0x2A9B9D0", Offset = "0x2A9B9D0", VA = "0x2A9B9D0", Slot = "4")]
		public void OnPointerClick(PointerEventData eventData)
		{
		}

		[Token(Token = "0x6000249")]
		[Address(RVA = "0x2A9BA44", Offset = "0x2A9BA44", VA = "0x2A9BA44", Slot = "5")]
		public void OnSelect(BaseEventData eventData)
		{
		}

		[Token(Token = "0x600024A")]
		[Address(RVA = "0x2A9BAD0", Offset = "0x2A9BAD0", VA = "0x2A9BAD0", Slot = "6")]
		public void OnDeselect(BaseEventData eventData)
		{
		}

		[Token(Token = "0x600024B")]
		[Address(RVA = "0x2A9BB58", Offset = "0x2A9BB58", VA = "0x2A9BB58")]
		public TMP_ScrollbarEventHandler()
		{
		}
	}
}
