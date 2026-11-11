using System;
using Audio;
using UnityEngine;

public class CountdownAnimator : MonoBehaviour
{
	public Animator Animator;

	public Vector2 AmountOfBeepsBetween = new Vector2(3f, 5f);

	public string LastAnimationStateName = "Go";

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
		if (BeepClip != null)
		{
			BeepClip.Play(null, Vector3.zero, 1f, 1f);
		}
		OnBeep?.Invoke();
	}

	public void LastBeep()
	{
		if (LastBeepClip != null)
		{
			LastBeepClip.Play(null, Vector3.zero, 1f, 1f);
		}
		OnLastBeep?.Invoke();
	}

	public void PlayIntroSound()
	{
		if (IntroClip != null)
		{
			IntroClip.Play(null, Vector3.zero, 1f, 1f);
		}
	}

	public void PlayOutroSound()
	{
		if (OutroClip != null)
		{
			OutroClip.Play(null, Vector3.zero, 1f, 1f);
		}
	}
}
