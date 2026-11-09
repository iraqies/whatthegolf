using UnityEngine.Events;

public class SettingsMenuButton : SettingsMenuCommon
{
	public ScrollableButton button;

	public void Init(UnityAction onChange, bool active, SettingsMenu settings)
	{
		TryDestroy(active);
		if (!active) return;
		base.Init(settings);
		if (button == null)
			button = GetComponentInChildren<ScrollableButton>(true);
		if (button != null)
		{
			if (settings != null)
				button.Init(settings.scrollRect);
			button.onClick.RemoveAllListeners();
			if (onChange != null)
				button.onClick.AddListener(onChange);
			if (settings != null)
				button.onClick.AddListener(settings.PlaySoundOnUpdateValue);
		}
	}

	public override void HandleController()
	{
		if (InputHelper.GetAllPlayerButtonConfirm() && button != null && button.interactable)
			button.onClick?.Invoke();
	}
}
