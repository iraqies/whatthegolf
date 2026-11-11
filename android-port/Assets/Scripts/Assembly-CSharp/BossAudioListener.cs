using Core;
using UnityEngine;

public class BossAudioListener : MonoBehaviour
{
	public FinalBoss FinalBoss;

	private GolfBallController currentController;

	private bool foundController;

	private void Awake()
	{
	}

	private void OnStageStarted(BossStage bossStage)
	{
		Debug.Log("Started stage " + bossStage);
		currentController = bossStage.Egg.PlayerController;
		foundController = true;
		if (MainAudioListener.Instance != null)
		{
			MainAudioListener.Instance.SetFollowTarget(base.transform);
		}
	}

	private void Update()
	{
		if (foundController)
		{
			base.transform.position = currentController.transform.position;
		}
	}
}
