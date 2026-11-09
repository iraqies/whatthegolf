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
		TryDestroy(active);
		if (!active) return;
		DefaultValue = defaultValue;
		OnChange = onChange;
		base.Init(settings);
		ResetValues();
	}

	public override void HandleController()
	{
		int h = InputHelper.GetAllPlayerAxisRoundedHorizontal();
		if (!waitForInputReset && h != 0 && slider != null)
		{
			waitForInputReset = true;
			slider.value += h;
		}
		if (waitForInputReset && h == 0)
			waitForInputReset = false;
	}

	public override void ResetValues()
	{
		if (slider == null)
			slider = GetComponentInChildren<Slider>(true);
		if (slider == null) return;
		slider.onValueChanged.RemoveAllListeners();
		if (DefaultValue != null)
			slider.value = DefaultValue();
		if (OnChange != null)
			slider.onValueChanged.AddListener(OnChange);
		if (settingsMenu != null)
			slider.onValueChanged.AddListener(_ => settingsMenu.PlaySoundOnUpdateValue());
	}

	public override void Refresh()
	{
		if (slider != null && DefaultValue != null)
			slider.SetValueWithoutNotify(DefaultValue());
	}
}
