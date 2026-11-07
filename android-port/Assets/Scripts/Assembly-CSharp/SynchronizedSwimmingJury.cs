using System.Collections;
using System.Collections.Generic;
using Core;
using TMPro;
using UnityEngine;

public class SynchronizedSwimmingJury : MonoBehaviour
{
	[SerializeField]
	private SynchronizedSwimmerAI ai;

	[SerializeField]
	private Transform aiReferencePoint;

	[SerializeField]
	private SwimmerShooter player;

	[SerializeField]
	private Transform playerReferencePoint;

	[SerializeField]
	private List<TextMeshProUGUI> scoreRenderers;

	[SerializeField]
	private List<Animator> animators;

	[SerializeField]
	private float initialWait;

	[SerializeField]
	private float scoreEvaluationDuration;

	[SerializeField]
	private List<float> scores;

	[SerializeField]
	private List<bool> scoresUpdated;

	private float startTime;

	[SerializeField]
	private AnimationCurve timingScoreCurve;

	[SerializeField]
	private float distanceScoreNormalizer;

	[SerializeField]
	private AnimationCurve distanceScoreCurve;

	[SerializeField]
	private float scoreHistoryWeight;

	private string animTriggerParamName;

	private string changeScoreStateName;

	private void Start()
	{
	}

	private void AI_OnMoveTargetReached(SynchronizedSwimmerAI syncSwimmerAI)
	{
	}

	private void Update()
	{
	}

	private IEnumerator CalculateScores()
	{
		return null;
	}

	private void ShowScoreUpdateAnimation(int juryMemberIndex)
	{
	}

	public void UpdateScoreRenderer(Animator juryMember)
	{
	}

	private void UpdateScoreRenderer(int juryMemberIndex)
	{
	}
}
