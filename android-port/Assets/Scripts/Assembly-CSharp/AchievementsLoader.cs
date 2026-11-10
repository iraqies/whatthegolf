using System.Collections;
using Core;
using UnityEngine;

public class AchievementsLoader : MonoBehaviour
{
	private bool _interactionDisabled;

	private bool _wantsToEnableInteraction;

	private void EnableInteraction()
	{
		_wantsToEnableInteraction = true;
		if (OverworldManager2d.Instance != null)
		{
			OverworldManager2d.Instance.EnableInteraction();
		}
	}

	private void DisableInteraction()
	{
		_interactionDisabled = true;
		if (OverworldManager2d.Instance != null)
		{
			OverworldManager2d.Instance.DisableInteraction(hide: false);
		}
	}

	private void OnCollisionEnter2D(Collision2D collision)
	{
		ShowAchievements();
	}

	public void ShowAchievements()
	{
		if (!_interactionDisabled)
		{
			_interactionDisabled = true;
			if (OverworldManager2d.Instance != null)
			{
				OverworldManager2d.Instance.DisableInteraction(hide: false);
			}
			GameAnalytics.OnMenuButtonPressed("Achievements");
			StartCoroutine(ShowAchievementsCR());
		}
	}

	private IEnumerator ShowAchievementsCR()
	{
		if (PlatformSettings.Instance != null && PlatformSettings.Instance.GetCurrent() != null && PlatformSettings.Instance.GetCurrent().Platform != null)
		{
			PlatformSettings.Instance.GetCurrent().Platform.ShowTrophies(delegate
			{
				EnableInteraction();
			});
		}
		else
		{
			yield return new WaitForSecondsRealtime(0.1f);
			EnableInteraction();
		}
	}

	public void OnTriggerExit2D(Collider2D collider)
	{
		if (_wantsToEnableInteraction)
		{
			_interactionDisabled = false;
			_wantsToEnableInteraction = false;
		}
	}
}
