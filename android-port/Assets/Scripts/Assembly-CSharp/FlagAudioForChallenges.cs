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
		if (PlayAudioRemotely) return;
		if (playAfterDelay > 0f)
		{
			StartCoroutine(PlayAfterDelay());
			return;
		}
		GoodHit();
		if (snapshot != null && AudioManager.Instance != null)
			AudioManager.Instance.SetMixerSnapshot(snapshot, 0.42f);
	}

	private void GoodHit()
	{
		if (Time.time < nextAudio) return;
		nextAudio = Time.time + 1f;
		if (hitFullApplauseSFX != null && hitFullApplauseSFX.Count > 0)
			hitFullApplauseSFX.Play(Vector3.zero, 1f, 1f);
		else if (sfxHit != null && AudioManager.Instance != null && AudioManager.Instance.uiEffects != null)
			AudioManager.Instance.uiEffects.PlaySimple(sfxHit, volume > 0f ? volume : 1f, 1f, Vector3.zero);
		if (rumble != null)
			rumble.Play(0, 1f);
	}

	private IEnumerator PlayAfterDelay()
	{
		yield return new WaitForSecondsRealtime(playAfterDelay);
		GoodHit();
		if (snapshot != null && AudioManager.Instance != null)
			AudioManager.Instance.SetMixerSnapshot(snapshot, 0.42f);
	}
}
