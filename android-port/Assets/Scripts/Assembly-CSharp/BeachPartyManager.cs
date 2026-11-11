using System.Collections;
using Core;
using UnityEngine;

public class BeachPartyManager : MonoBehaviour
{
	public float StartDelay;

	public float EndDelay;

	public ParticleSystem HintParticleSystem;

	private GolfBallController controller;

	private QuestState[] allStates;

	private void OnEnable()
	{
		controller = Object.FindObjectOfType<GolfBallController>();
		allStates = GetComponentsInChildren<QuestState>();
		for (int i = 0; i < allStates.Length; i++)
		{
			allStates[i].Init(controller, HintParticleSystem);
		}
		StartCoroutine(PartyRoutine());
		if (AddressableSingleton<LevelManager>.Instance != null && AddressableSingleton<LevelManager>.Instance.CurrentLevel != null)
		{
			AddressableSingleton<LevelManager>.Instance.InGameMenu.SetChallengeInfoToShowForMinSeconds(true);
		}
	}

	private void OnDisable()
	{
		if (AddressableSingleton<LevelManager>.Instance != null && AddressableSingleton<LevelManager>.Instance.CurrentLevel != null)
		{
			AddressableSingleton<LevelManager>.Instance.InGameMenu.SetChallengeInfoToShowForMinSeconds(false);
		}
	}

	private IEnumerator PartyRoutine()
	{
		yield return new WaitForSeconds(StartDelay);
		QuestState[] array = allStates;
		foreach (QuestState state in array)
		{
			state.OnStart();
			if (AddressableSingleton<LevelManager>.Instance != null && AddressableSingleton<LevelManager>.Instance.CurrentLevel != null)
			{
				AddressableSingleton<LevelManager>.Instance.InGameMenu.ShowChallengeInfo(Localization.Instance.GetString(state.NameID));
			}
			while (!state.HasCompletedState())
			{
				yield return null;
			}
			state.OnComplete();
			yield return new WaitForSeconds(0.5f);
		}
		yield return new WaitForSeconds(EndDelay);
		Level.Instance.Complete();
	}
}
