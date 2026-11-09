using System;
using UnityEngine;
using UnityEngine.Events;

public class SettingsMenuToggle : SettingsMenuCommon
{
	public Animator toggleAnim;

	public GameObject On;

	public GameObject Off;

	public ScrollableButton button;

	private Func<bool> DefaultValue;

	public void SetToggle(bool on)
	{
		if (On != null) On.SetActive(on);
		if (Off != null) Off.SetActive(!on);
	}

	public void Init(Func<bool> defaultValue, UnityAction onChange, bool active, SettingsMenu settings)
	{
		if (toggleAnim != null)
			toggleAnim.enabled = false;
		TryDestroy(active);
		if (!active) return;
		DefaultValue = defaultValue;
		bool val = DefaultValue != null && DefaultValue();
		SetToggle(val);
		if (button == null)
			button = GetComponentInChildren<ScrollableButton>(true);
		if (button != null)
		{
			if (settings != null)
				button.Init(settings.scrollRect);
			button.onClick.RemoveAllListeners();
			if (onChange != null)
				button.onClick.AddListener(onChange);
			button.onClick.AddListener(() =>
			{
				if (DefaultValue != null)
					SetToggle(DefaultValue());
				settings?.PlaySoundOnUpdateValue();
			});
		}
		base.Init(settings);
	}

	public override void HandleController()
	{
		if (InputHelper.GetAllPlayerButtonConfirm() && button != null && button.interactable)
			button.onClick?.Invoke();
	}

	public override void ResetValues()
	{
		if (DefaultValue != null)
			SetToggle(DefaultValue());
	}

	public override void Refresh()
	{
		if (DefaultValue != null)
			SetToggle(DefaultValue());
	}
}
