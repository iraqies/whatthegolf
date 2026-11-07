using System;
using Audio;
using UnityEngine;

public class CountdownAnimator : MonoBehaviour
{
	public Animator Animator;

	public Vector2 AmountOfBeepsBetween;

	public string LastAnimationStateName;

	[SerializeField]
	private ClipSettingsCollection BeepClip;

	[SerializeField]
	private ClipSettingsCollection LastBeepClip;

	[SerializeField]
	private ClipSettingsCollection IntroClip;

	[SerializeField]
	private ClipSettingsCollection OutroClip;

	public Action OnBeep;

	public Action OnLastBeep;

	public void PlayBeep()
	{
	}

	public void LastBeep()
	{
	}

	public void PlayIntroSound()
	{
	}

	public void PlayOutroSound()
	{
	}
}
