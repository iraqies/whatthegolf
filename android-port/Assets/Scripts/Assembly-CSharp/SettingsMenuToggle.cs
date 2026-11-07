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
	}

	public void Init(Func<bool> defaultValue, UnityAction onChange, bool active, SettingsMenu settings)
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
