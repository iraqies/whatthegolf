using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using WhatTheGolf.LevelDesigner.Events;

namespace WhatTheGolf.LevelDesigner.Audio
{
	[Token(Token = "0x20012D7")]
	public class ButtonAudioEvent : MonoBehaviour, IPointerEnterHandler, IEventSystemHandler
	{
		[Token(Token = "0x4006583")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private AudioEvent.AudioEventType eventOnButtonDown;

		[Token(Token = "0x4006584")]
		[FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private AudioEvent.AudioEventType eventOnHover;

		[Token(Token = "0x4006585")]
		[FieldOffset(Offset = "0x20")]
		private Button button;

		[Token(Token = "0x4006586")]
		[FieldOffset(Offset = "0x28")]
		private float lastEnableTime;

		[Token(Token = "0x6005761")]
		[Address(RVA = "0x17D9DA0", Offset = "0x17D9DA0", VA = "0x17D9DA0")]
		private void Awake()
		{
		}

		[Token(Token = "0x6005762")]
		[Address(RVA = "0x17D9EB8", Offset = "0x17D9EB8", VA = "0x17D9EB8")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6005763")]
		[Address(RVA = "0x17D9EE0", Offset = "0x17D9EE0", VA = "0x17D9EE0")]
		private void OnButtonClick()
		{
		}

		[Token(Token = "0x6005764")]
		[Address(RVA = "0x17D9F5C", Offset = "0x17D9F5C", VA = "0x17D9F5C", Slot = "4")]
		public void OnPointerEnter(PointerEventData eventData)
		{
		}

		[Token(Token = "0x6005765")]
		[Address(RVA = "0x17DA018", Offset = "0x17DA018", VA = "0x17DA018")]
		public ButtonAudioEvent()
		{
		}
	}
}
