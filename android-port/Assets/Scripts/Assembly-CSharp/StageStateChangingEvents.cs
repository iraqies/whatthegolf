using UnityEngine;
using UnityEngine.Events;

public class StageStateChangingEvents : MonoBehaviour
{
	public FinalBoss FinalBoss;

	public BossStage OnlyOnThisStage;

	public UnityEvent StageBeginning;

	public UnityEvent StageEnding;

	private void Awake()
	{
	}

	private void OnStageStarted(BossStage bossStage)
	{
	}

	private void OnStageEnding(BossStage bossStage)
	{
	}
}
