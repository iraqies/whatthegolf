using System.Collections.Generic;
using Il2CppDummyDll;
using Rewired.Integration.UnityUI;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace Rewired.Demos
{
	[Token(Token = "0x200116A")]
	public sealed class PlayerPointerEventHandlerExample : MonoBehaviour, IPointerEnterHandler, IEventSystemHandler, IPointerExitHandler, IPointerUpHandler, IPointerDownHandler, IPointerClickHandler, IScrollHandler, IBeginDragHandler, IDragHandler, IEndDragHandler
	{
		[Token(Token = "0x4005C1A")]
		[FieldOffset(Offset = "0x18")]
		public Text text;

		[Token(Token = "0x4005C1B")]
		private const int logLength = 10;

		[Token(Token = "0x4005C1C")]
		[FieldOffset(Offset = "0x20")]
		private List<string> log;

		[Token(Token = "0x6004F8C")]
		[Address(RVA = "0x15F96B0", Offset = "0x15F96B0", VA = "0x15F96B0")]
		private void Log(string o)
		{
		}

		[Token(Token = "0x6004F8D")]
		[Address(RVA = "0x15F9764", Offset = "0x15F9764", VA = "0x15F9764")]
		private void Update()
		{
		}

		[Token(Token = "0x6004F8E")]
		[Address(RVA = "0x15F9968", Offset = "0x15F9968", VA = "0x15F9968", Slot = "4")]
		public void OnPointerEnter(PointerEventData eventData)
		{
		}

		[Token(Token = "0x6004F8F")]
		[Address(RVA = "0x15F9C70", Offset = "0x15F9C70", VA = "0x15F9C70", Slot = "5")]
		public void OnPointerExit(PointerEventData eventData)
		{
		}

		[Token(Token = "0x6004F90")]
		[Address(RVA = "0x15F9EC8", Offset = "0x15F9EC8", VA = "0x15F9EC8", Slot = "6")]
		public void OnPointerUp(PointerEventData eventData)
		{
		}

		[Token(Token = "0x6004F91")]
		[Address(RVA = "0x15FA1A0", Offset = "0x15FA1A0", VA = "0x15FA1A0", Slot = "7")]
		public void OnPointerDown(PointerEventData eventData)
		{
		}

		[Token(Token = "0x6004F92")]
		[Address(RVA = "0x15FA478", Offset = "0x15FA478", VA = "0x15FA478", Slot = "8")]
		public void OnPointerClick(PointerEventData eventData)
		{
		}

		[Token(Token = "0x6004F93")]
		[Address(RVA = "0x15FA750", Offset = "0x15FA750", VA = "0x15FA750", Slot = "9")]
		public void OnScroll(PointerEventData eventData)
		{
		}

		[Token(Token = "0x6004F94")]
		[Address(RVA = "0x15FA9A8", Offset = "0x15FA9A8", VA = "0x15FA9A8", Slot = "10")]
		public void OnBeginDrag(PointerEventData eventData)
		{
		}

		[Token(Token = "0x6004F95")]
		[Address(RVA = "0x15FAC80", Offset = "0x15FAC80", VA = "0x15FAC80", Slot = "11")]
		public void OnDrag(PointerEventData eventData)
		{
		}

		[Token(Token = "0x6004F96")]
		[Address(RVA = "0x15FAF58", Offset = "0x15FAF58", VA = "0x15FAF58", Slot = "12")]
		public void OnEndDrag(PointerEventData eventData)
		{
		}

		[Token(Token = "0x6004F97")]
		[Address(RVA = "0x15F9BC0", Offset = "0x15F9BC0", VA = "0x15F9BC0")]
		private static string GetSourceName(PlayerPointerEventData playerEventData)
		{
			return null;
		}

		[Token(Token = "0x6004F98")]
		[Address(RVA = "0x15FB230", Offset = "0x15FB230", VA = "0x15FB230")]
		public PlayerPointerEventHandlerExample()
		{
		}
	}
}
