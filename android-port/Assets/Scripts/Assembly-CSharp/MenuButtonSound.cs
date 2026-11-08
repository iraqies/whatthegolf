using Audio;
using UnityEngine;
using UnityEngine.UI;

public class MenuButtonSound : MonoBehaviour
{
	[SerializeField] private ClipSettingsCollection _pressedSFX;
	[SerializeField] private ClipSettingsCollection _selectedSFX;
	private MainMenu2Button _button;

	private void Start()
	{
		_button = GetComponentInParent<MainMenu2Button>();
		if (_button != null)
		{
			_button.onClick.AddListener(PlayClick);
			_button.onSelected.AddListener(PlaySelected);
		}
		else
		{
			var btn = GetComponentInParent<Button>();
			if (btn != null)
				btn.onClick.AddListener(PlayClick);
		}
	}

	private void PlayClick()
	{
		_pressedSFX?.Play(transform.position, 1f, 1f);
	}

	private void PlaySelected()
	{
		_selectedSFX?.Play(transform.position, 1f, 1f);
	}
}
