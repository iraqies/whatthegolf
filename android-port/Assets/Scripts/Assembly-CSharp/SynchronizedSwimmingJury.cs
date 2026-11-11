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
	private float initialWait = 5f;

	[SerializeField]
	private float scoreEvaluationDuration = 2f;

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
	private float scoreHistoryWeight = 0.8f;

	private string animTriggerParamName = "ShowScore";

	private string changeScoreStateName = "ChangeScore";

	private void Start()
	{
		if (ai != null)
		{
			ai.OnMoveTargetReached += AI_OnMoveTargetReached;
		}
		startTime = Time.time;
	}

	private void AI_OnMoveTargetReached(SynchronizedSwimmerAI syncSwimmerAI)
	{
		StartCoroutine(CalculateScores());
	}

	private void Update()
	{
		if (Time.time - startTime > initialWait && scores != null && scoreRenderers != null && scoresUpdated != null && animators != null)
		{
			for (int i = 0; i < scores.Count; i++)
			{
				int num = Mathf.RoundToInt(scores[i]);
				if (i < scoreRenderers.Count && scoreRenderers[i] != null && int.TryParse(scoreRenderers[i].text, out int result) && num != result && i < scoresUpdated.Count && !scoresUpdated[i])
				{
					ShowScoreUpdateAnimation(i);
					scoresUpdated[i] = true;
				}
			}
		}
		if (animators == null)
		{
			return;
		}
		for (int j = 0; j < animators.Count; j++)
		{
			if (animators[j] != null && animators[j].GetCurrentAnimatorStateInfo(0).IsName(changeScoreStateName))
			{
				UpdateScoreRenderer(j);
			}
		}
	}

	private IEnumerator CalculateScores()
	{
		float endTime = Time.time + scoreEvaluationDuration;
		float evalStartTime = Time.time;
		float bestScore = 0f;
		while (Time.time < endTime)
		{
			float num = ((timingScoreCurve != null && scoreEvaluationDuration > 0f) ? timingScoreCurve.Evaluate((Time.time - evalStartTime) / scoreEvaluationDuration) : 1f);
			if (playerReferencePoint != null && player != null && aiReferencePoint != null && ai != null)
			{
				Vector2 a = new Vector2(playerReferencePoint.position.x, playerReferencePoint.position.z);
				Vector2 b = new Vector2(player.transform.position.x, player.transform.position.z);
				float num2 = Vector2.Distance(a, b);
				Vector2 a2 = new Vector2(aiReferencePoint.position.x, aiReferencePoint.position.z);
				Vector2 b2 = new Vector2(ai.transform.position.x, ai.transform.position.z);
				float num3 = Vector2.Distance(a2, b2);
				float num4 = ((distanceScoreCurve != null && distanceScoreNormalizer > 0f) ? distanceScoreCurve.Evaluate(Mathf.Abs(num2 - num3) / distanceScoreNormalizer) : 1f);
				Debug.DrawLine(new Vector3(a.x, 0f, a.y), new Vector3(b.x, 0f, b.y), Color.red);
				Debug.DrawLine(new Vector3(a2.x, 0f, a2.y), new Vector3(b2.x, 0f, b2.y), Color.red);
				bestScore = Mathf.Max(num * num4, bestScore);
			}
			yield return null;
		}
		if (scores == null || scoresUpdated == null)
		{
			yield break;
		}
		for (int i = 0; i < scores.Count; i++)
		{
			scores[i] = Mathf.Lerp(bestScore * 10f, scores[i], scoreHistoryWeight);
			Debug.Log($"Jury {i}: {scores[i]}");
			if (i < scoresUpdated.Count)
			{
				scoresUpdated[i] = false;
			}
		}
	}

	private void ShowScoreUpdateAnimation(int juryMemberIndex)
	{
		if (animators != null && juryMemberIndex >= 0 && juryMemberIndex < animators.Count && animators[juryMemberIndex] != null)
		{
			animators[juryMemberIndex].SetTrigger(animTriggerParamName);
		}
	}

	public void UpdateScoreRenderer(Animator juryMember)
	{
		if (animators == null)
		{
			return;
		}
		int juryMemberIndex = -1;
		for (int i = 0; i < animators.Count; i++)
		{
			if (animators[i] == juryMember)
			{
				juryMemberIndex = i;
				break;
			}
		}
		UpdateScoreRenderer(juryMemberIndex);
	}

	private void UpdateScoreRenderer(int juryMemberIndex)
	{
		if (juryMemberIndex >= 0 && scoreRenderers != null && juryMemberIndex < scoreRenderers.Count && scores != null && juryMemberIndex < scores.Count && scoreRenderers[juryMemberIndex] != null)
		{
			scoreRenderers[juryMemberIndex].text = Mathf.RoundToInt(scores[juryMemberIndex]).ToString();
		}
	}
}
