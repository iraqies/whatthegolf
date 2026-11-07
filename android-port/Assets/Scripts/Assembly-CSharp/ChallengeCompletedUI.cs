using System.Collections;
using Audio;
using TMPro;
using UnityEngine;

public class ChallengeCompletedUI : MonoBehaviour
{
	public Transform Container;

	public TextMeshProUGUI ChallengeTitle;

	public float AppearDuration;

	public float DisappearDuration;

	public float HoldDuration;

	public float PunchMax;

	public float SpeechSpeed;

	public RandomAudioClips TextClips;

	public AudioClip DisappearClip;

	public void ChallengeCompleted(string title, bool success)
	{
	}

	private IEnumerator Routine(string title, bool success)
	{
		return null;
	}
}
