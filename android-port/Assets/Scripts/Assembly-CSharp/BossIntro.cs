using System;
using System.Collections;
using UnityEngine;

public class BossIntro : MonoBehaviour
{
	public bool Is2D;

	public Transform Target;

	public float InDuration;

	public float MidDuration;

	public float OutDuration;

	public float VisibleAreaPercentage;

	public RectTransform TopBar;

	public RectTransform BottomBar;

	public RectTransform LeftBar;

	public RectTransform RightBar;

	public void PlayIntro(Action onFinished)
	{
	}

	private IEnumerator IntroRoutine(Action onFinished)
	{
		return null;
	}

	private IEnumerator IntroRoutine2D(Action onFinished)
	{
		return null;
	}
}
