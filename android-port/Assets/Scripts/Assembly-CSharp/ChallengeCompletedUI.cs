using System.Collections;
using Audio;
using TMPro;
using UnityEngine;

public class ChallengeCompletedUI : MonoBehaviour
{
	public Transform Container;

	public TextMeshProUGUI ChallengeTitle;

	public float AppearDuration = 0.25f;

	public float DisappearDuration = 0.25f;

	public float HoldDuration = 1.5f;

	public float PunchMax = 1.15f;

	public float SpeechSpeed = 0.03f;

	public RandomAudioClips TextClips;

	public AudioClip DisappearClip;

	public void ChallengeCompleted(string title, bool success)
	{
		gameObject.SetActive(true);
		StopAllCoroutines();
		StartCoroutine(Routine(title, success));
	}

	private IEnumerator Routine(string title, bool success)
	{
		if (Container != null)
		{
			Container.gameObject.SetActive(true);
			Container.localScale = Vector3.zero;
		}
		if (ChallengeTitle != null)
			ChallengeTitle.text = title ?? string.Empty;
		if (TextClips != null)
			TextClips.PlayRandomClip(transform);

		float app = AppearDuration > 0.01f ? AppearDuration : 0.25f;
		yield return StartCoroutine(pTween.To(app, t =>
		{
			if (Container != null)
				Container.localScale = Vector3.one * t;
		}));

		yield return new WaitForSecondsRealtime(HoldDuration > 0.1f ? HoldDuration : 1.5f);

		if (DisappearClip != null && AudioManager.Instance != null && AudioManager.Instance.uiEffects != null)
			AudioManager.Instance.uiEffects.PlaySimple(DisappearClip, 0.8f, 1f, Vector3.zero);

		float dis = DisappearDuration > 0.01f ? DisappearDuration : 0.25f;
		yield return StartCoroutine(pTween.To(dis, t =>
		{
			if (Container != null)
				Container.localScale = Vector3.one * (1f - t);
		}));

		if (Container != null)
			Container.gameObject.SetActive(false);
		gameObject.SetActive(false);
	}
}
