using System.Threading.Tasks;
using Core;
using UnityEngine;

namespace Menu
{
	public class UIBackgroundFader : AddressableSingleton<UIBackgroundFader>
	{
		[SerializeField] private AnimateRectTransform animateRectTransform;
		private int popupCount;
		private int lastPopupCount;

		public bool IsActive => popupCount > 0;

		public void Register()
		{
			if (!gameObject.activeSelf && animateRectTransform != null)
				animateRectTransform.Hide();
			popupCount++;
			DelayedUpdate();
		}

		public void Deregister()
		{
			if (popupCount > 0)
				popupCount--;
			DelayedUpdate();
		}

		private async void DelayedUpdate()
		{
			await Task.Yield();
			if (this == null || gameObject == null) return;
			if (lastPopupCount != popupCount)
			{
				if (lastPopupCount == 0 && popupCount >= 1)
				{
					gameObject.SetActive(true);
					if (animateRectTransform != null)
						animateRectTransform.Show();
				}
				else if (popupCount <= 0)
				{
					if (animateRectTransform != null)
						animateRectTransform.Hide();
					else
						gameObject.SetActive(false);
				}
			}
			lastPopupCount = popupCount;
		}

		public void Clear()
		{
			popupCount = 0;
			DelayedUpdate();
		}
	}
}
