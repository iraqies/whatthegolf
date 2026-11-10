using System.Linq;
using UnityEngine;
using UnityEngine.AddressableAssets;

public class ReplayDaily : MonoBehaviour
{
	[SerializeField]
	private PrizeController prizeController;

	private double time;

	private void Start()
	{
		time = Time.time;
		if (prizeController == null)
		{
			prizeController = FindObjectOfType<PrizeController>();
		}
	}

	public async void Replay()
	{
		var tc = FindObjectOfType<TimeControl>();
		if (tc != null)
		{
			tc.TogglePause(false);
		}
		var starters = FindObjectsOfType<DailyChallengePackStarter>();
		var activeStarter = starters != null ? starters.FirstOrDefault(p => p != null && p.isDailyPlaying) : null;
		if (activeStarter != null)
		{
			activeStarter.PlayLevels(true, -1);
			await Addressables.UnloadSceneAsync(activeStarter.winSceneInstance, true).Task;
		}
		Analytics();
	}

	public async void Close()
	{
		var tc = FindObjectOfType<TimeControl>();
		if (tc != null)
		{
			tc.TogglePause(false);
		}
		var starters = FindObjectsOfType<DailyChallengePackStarter>();
		var activeStarter = starters != null ? starters.FirstOrDefault(p => p != null && p.isDailyPlaying) : null;
		if (activeStarter != null)
		{
			activeStarter.Close(false);
		}
		Analytics();
	}

	private void Analytics()
	{
		if (prizeController != null)
		{
			GameAnalytics.OnPrizeSceneLeave(Time.time - time, prizeController.didUnpackPrize, prizeController.lastPackReceived);
		}
	}
}
