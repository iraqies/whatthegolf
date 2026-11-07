using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using WhatTheGolf.LevelDesigner.Events;

namespace WhatTheGolf.LevelDesigner.Audio
{
	public class ButtonAudioEvent : MonoBehaviour, IPointerEnterHandler, IEventSystemHandler
	{
		[SerializeField]
		private AudioEvent.AudioEventType eventOnButtonDown;

		[SerializeField]
		private AudioEvent.AudioEventType eventOnHover;

		private Button button;

		private float lastEnableTime;

		private void Awake()
		{
		}

		private void OnEnable()
		{
		}

		private void OnButtonClick()
		{
		}

		public void OnPointerEnter(PointerEventData eventData)
		{
		}
	}
}
