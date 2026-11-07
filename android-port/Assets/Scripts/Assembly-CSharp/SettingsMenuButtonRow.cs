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
	}

	private void OnEnable()
	{
	}

	private void SetText(int arg0)
	{
	}

	private IEnumerator SetFocusCR()
	{
		return null;
	}

	private void SetFocus()
	{
	}

	private void privateOnChange(int selected)
	{
	}

	public override void HandleController()
	{
	}

	public override void SetIsHighlighted(bool active)
	{
	}

	public override void ResetValues()
	{
	}

	public override void Refresh()
	{
	}
}
