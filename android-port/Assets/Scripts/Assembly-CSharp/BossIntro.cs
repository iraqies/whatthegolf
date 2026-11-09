using System;
using System.Collections;
using UnityEngine;

public class BossIntro : MonoBehaviour
{
	public bool Is2D;

	public Transform Target;

	public float InDuration = 0.5f;

	public float MidDuration = 1f;

	public float OutDuration = 0.5f;

	public float VisibleAreaPercentage = 0.7f;

	public RectTransform TopBar;

	public RectTransform BottomBar;

	public RectTransform LeftBar;

	public RectTransform RightBar;

	public void PlayIntro(Action onFinished)
	{
		if (!gameObject.activeInHierarchy)
			gameObject.SetActive(true);
		if (Is2D)
			StartCoroutine(IntroRoutine2D(onFinished));
		else
			StartCoroutine(IntroRoutine(onFinished));
	}

	private IEnumerator IntroRoutine(Action onFinished)
	{
		if (InDuration > 0f)
			yield return new WaitForSeconds(InDuration);
		if (MidDuration > 0f)
			yield return new WaitForSeconds(MidDuration);
		if (OutDuration > 0f)
			yield return new WaitForSeconds(OutDuration);
		onFinished?.Invoke();
	}

	private IEnumerator IntroRoutine2D(Action onFinished)
	{
		yield return StartCoroutine(IntroRoutine(onFinished));
	}
}
