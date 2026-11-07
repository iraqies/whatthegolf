using System.Collections;
using Audio;
using Audio.Rumble;
using Core;
using UnityEngine;
using UnityEngine.Audio;

public class FlagAudio : MonoBehaviour
{
	[SerializeField]
	private float playAfterDelay;

	[SerializeField]
	private float volume;

	[SerializeField]
	private AudioClip sfxHit;

	[SerializeField]
	private ClipSettingsCollection hitFullApplauseSFX;

	[SerializeField]
	private ClipSettingsCollection hitNoApplauseSFX;

	[SerializeField]
	private RumbleEventAsset rumble;

	[SerializeField]
	private AudioMixerSnapshot snapshot;

	private GolfGoal goal;

	private float nextAudio;

	public bool PlayAudioRemotely { get; set; }

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	private void Goal_OnGoalProgress(GolfBallController controller, string message)
	{
	}

	private void Goal_OnGoal(string obj)
	{
	}

	public void GoodHit()
	{
	}

	public void BadHit()
	{
	}

	private IEnumerator PlayAfterDelay()
	{
		return null;
	}
}
