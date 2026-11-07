using Core;
using UnityEngine;

namespace Menu
{
	public class UIBackgroundFader : AddressableSingleton<UIBackgroundFader>
	{
		[SerializeField]
		private AnimateRectTransform animateRectTransform;

		private int popupCount;

		private int lastPopupCount;

		public bool IsActive => false;

		public void Register()
		{
		}

		public void Deregister()
		{
		}

		private void DelayedUpdate()
		{
		}

		public void Clear()
		{
		}
	}
}
