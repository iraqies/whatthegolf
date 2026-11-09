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
		TryDestroy(active);
		if (!active) return;
		Options = options;
		DefaultValue = defaultValue;
		OnChange = onChange;
		base.Init(settings);
		ResetValues();
	}

	public override void HandleController()
	{
	}

	public override void ResetValues()
	{
		if (DropDown == null)
			DropDown = GetComponentInChildren<TMP_Dropdown>(true);
		if (DropDown == null) return;
		DropDown.onValueChanged.RemoveAllListeners();
		if (Options != null)
		{
			DropDown.ClearOptions();
			var opts = Options();
			if (opts != null && opts.Count > 0)
				DropDown.AddOptions(opts);
		}
		if (DefaultValue != null)
			DropDown.SetValueWithoutNotify(DefaultValue());
		if (OnChange != null)
			DropDown.onValueChanged.AddListener(OnChange);
		if (settingsMenu != null)
			DropDown.onValueChanged.AddListener(_ => settingsMenu.PlaySoundOnUpdateValue());
	}

	public override void Refresh()
	{
		if (DropDown != null && DefaultValue != null)
			DropDown.SetValueWithoutNotify(DefaultValue());
	}
}
