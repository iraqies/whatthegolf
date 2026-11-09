using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.Events;

public class SettingsMenuButtonRow : SettingsMenuCommon
{
	public List<ScrollableButton> buttons;

	private UnityAction<int> OnChange;

	public TextMeshProUGUI text;

	public Transform focusBox;

	public Transform selctedBox;

	private Func<int> DefaultValue;

	private Func<int> MaxVisible;

	private int focusedButtonIndex;

	private float selectedSwitchDelay;

	public void Init(UnityAction<int> onChange, Func<int> defaultValue, Func<int> maxVisible, bool active, SettingsMenu settings, Action init = null)
	{
		TryDestroy(active);
		if (!active) return;
		base.Init(settings);
		OnChange = onChange;
		DefaultValue = defaultValue;
		MaxVisible = maxVisible;
		if (buttons != null)
		{
			for (int i = 0; i < buttons.Count; i++)
			{
				int idx = i;
				var btn = buttons[i];
				if (btn == null) continue;
				if (settings != null)
					btn.Init(settings.scrollRect);
				btn.onClick.RemoveAllListeners();
				btn.onClick.AddListener(() => privateOnChange(idx));
			}
		}
		init?.Invoke();
		ResetValues();
		if (gameObject.activeInHierarchy)
			StartCoroutine(SetFocusCR());
	}

	private void OnEnable()
	{
		if (isInitialized)
			StartCoroutine(SetFocusCR());
	}

	private void SetText(int arg0)
	{
		if (text != null)
			text.text = (arg0 + 1).ToString();
	}

	private IEnumerator SetFocusCR()
	{
		yield return null;
		SetFocus();
	}

	private void SetFocus()
	{
		int sel = DefaultValue != null ? DefaultValue() : 0;
		if (buttons != null && sel >= 0 && sel < buttons.Count && buttons[sel] != null)
		{
			if (selctedBox != null)
				selctedBox.position = buttons[sel].transform.position;
			if (focusBox != null && focusedButtonIndex >= 0 && focusedButtonIndex < buttons.Count && buttons[focusedButtonIndex] != null)
				focusBox.position = buttons[focusedButtonIndex].transform.position;
		}
	}

	private void privateOnChange(int selected)
	{
		focusedButtonIndex = selected;
		SetText(selected);
		OnChange?.Invoke(selected);
		SetFocus();
		settingsMenu?.PlaySoundOnUpdateValue();
	}

	public override void HandleController()
	{
	}

	public override void SetIsHighlighted(bool active)
	{
		base.SetIsHighlighted(active);
		if (focusBox != null)
			focusBox.gameObject.SetActive(active);
	}

	public override void ResetValues()
	{
		int sel = DefaultValue != null ? DefaultValue() : 0;
		focusedButtonIndex = sel;
		SetText(sel);
		if (buttons != null && MaxVisible != null)
		{
			int max = MaxVisible();
			for (int i = 0; i < buttons.Count; i++)
			{
				if (buttons[i] != null)
					buttons[i].gameObject.SetActive(i < max);
			}
		}
		SetFocus();
	}

	public override void Refresh()
	{
		ResetValues();
	}
}
