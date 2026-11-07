using System.Collections.Generic;
using Audio;
using UnityEngine;

public class MainMenu2Music : MonoBehaviour
{
	[SerializeField]
	private LevelMusicSettings _menuMusic;

	[SerializeField]
	private List<AmbientAudio> _menuAmbients;

	[SerializeField]
	private ClipSettingsCollection _showSubmenuSFX;

	[SerializeField]
	private ClipSettingsCollection _hideSubmenuSFX;

	private bool _initialized;

	public void Play()
	{
	}

	public void StopAmbience()
	{
	}

	public void OnShowSubmenu()
	{
	}

	public void OnHideSubmenu()
	{
	}
}
