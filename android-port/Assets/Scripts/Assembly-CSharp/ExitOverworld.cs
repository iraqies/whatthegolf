using System.Collections;
using UnityEngine;

public class ExitOverworld : MonoBehaviour
{
	public float delay;

	private bool _exiting;

	public Transition.TransitionEffect TransitionEffectType;

	public void ExitToMenu()
	{
		if (!_exiting)
		{
			_exiting = true;
			StartCoroutine(ExitOverworldRoutine());
		}
	}

	private IEnumerator ExitOverworldRoutine()
	{
		yield return new WaitForSeconds(delay);
		GameAnalytics.OnExitOverworld();
		SaveThrobber.ShowThrobber(1f);
		if (LevelManager.Instance != null)
		{
			yield return StartCoroutine(LevelManager.Instance.StartTransition(null, null, showWaitAnimation: false, isAsync: false, showWaitingText: false, TransitionEffectType, null));
		}
		if (HubSceneLoader.Instance != null)
		{
			yield return HubSceneLoader.Instance.LoadSceneAsync(UnityEngine.SceneManagement.LoadSceneMode.Single, null, forceReload: false).YieldTask();
		}
	}
}
