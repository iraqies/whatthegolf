using UnityEngine;
using UnityEngine.UI;

public class ToggleOnPause : MonoBehaviour
{
	private Image _crosshair;

	private void Awake()
	{
		_crosshair = GetComponent<Image>();
		if (_crosshair != null && _crosshair.enabled)
		{
			TimeControl.OnPauseStateChanged += ToggleCross;
		}
	}

	private void OnDestroy()
	{
		TimeControl.OnPauseStateChanged -= ToggleCross;
	}

	private void ToggleCross(bool state)
	{
		if (_crosshair != null)
		{
			_crosshair.enabled = !state;
		}
	}
}
