using System;
using UnityEngine.Events;
using UnityEngine.UI;

public class SettingsMenuSlider : SettingsMenuCommon
{
	public Slider slider;

	private Func<float> DefaultValue;

	private UnityAction<float> OnChange;

	private bool waitForInputReset;

	public void Init(Func<float> defaultValue, UnityAction<float> onChange, bool active, SettingsMenu settings)
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
