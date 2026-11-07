using System;
using System.Collections.Generic;
using TMPro;
using UnityEngine.Events;

public class SettingsMenuDropdown : SettingsMenuCommon
{
	public TMP_Dropdown DropDown;

	private Func<List<string>> Options;

	private Func<int> DefaultValue;

	private UnityAction<int> OnChange;

	private bool selectedLineLockedIn;

	private float escapeDelay;

	public void Init(Func<List<string>> options, Func<int> defaultValue, UnityAction<int> onChange, bool active, SettingsMenu settings)
	{
	}

	public override void HandleController()
	{
	}

	public override void ResetValues()
	{
	}

	public override void Refresh()
	{
	}
}
