using System.Collections;
using Audio;
using Audio.Rumble;
using UnityEngine;
using UnityEngine.Audio;

public class FlagAudioForChallenges : MonoBehaviour
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
	private RumbleEventAsset rumble;

	[SerializeField]
	private AudioMixerSnapshot snapshot;

	private float nextAudio;

	public bool PlayAudioRemotely { get; set; }

	public void PlayFlagAudio()
	{
	}

	private void GoodHit()
	{
	}

	private IEnumerator PlayAfterDelay()
	{
		return null;
	}
}
