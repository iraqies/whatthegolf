using System.Collections;
using Audio;
using Audio.Rumble;
using Core;
using UnityEngine;
using UnityEngine.Audio;

public class FlagAudio : MonoBehaviour
{
	[SerializeField] private float playAfterDelay;
	[SerializeField] private float volume = 1f;
	[SerializeField] private AudioClip sfxHit;
	[SerializeField] private ClipSettingsCollection hitFullApplauseSFX;
	[SerializeField] private ClipSettingsCollection hitNoApplauseSFX;
	[SerializeField] private RumbleEventAsset rumble;
	[SerializeField] private AudioMixerSnapshot snapshot;

	private GolfGoal goal;
	private float nextAudio;

	public bool PlayAudioRemotely { get; set; }

	private void OnEnable()
	{
		if (goal == null)
			goal = GetComponent<GolfGoal>();
		if (goal != null)
		{
			goal.OnGoal -= Goal_OnGoal;
			goal.OnGoal += Goal_OnGoal;
		}
	}

	private void OnDisable()
	{
		if (goal != null)
		{
			goal.OnGoal -= Goal_OnGoal;
		}
	}

	private void Goal_OnGoalProgress(GolfBallController controller, string message)
	{
		GoodHit();
	}

	private void Goal_OnGoal(string obj)
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

	public void GoodHit()
	{
		if (Time.time < nextAudio) return;
		nextAudio = Time.time + 1f;
		if (hitFullApplauseSFX != null && hitFullApplauseSFX.Count > 0)
			hitFullApplauseSFX.Play(Vector3.zero, 1f, 1f);
		else if (sfxHit != null && AudioManager.Instance != null && AudioManager.Instance.uiEffects != null)
			AudioManager.Instance.uiEffects.PlaySimple(sfxHit, volume > 0f ? volume : 1f, 1f, Vector3.zero);
		if (rumble != null)
			rumble.PlayOnAllDevices(1f);
	}

	public void BadHit()
	{
		if (Time.time < nextAudio) return;
		nextAudio = Time.time + 1f;
		if (hitNoApplauseSFX != null && hitNoApplauseSFX.Count > 0)
			hitNoApplauseSFX.Play(Vector3.zero, 1f, 1f);
		if (rumble != null)
			rumble.PlayOnAllDevices(1f);
	}

	private IEnumerator PlayAfterDelay()
	{
		yield return new WaitForSecondsRealtime(playAfterDelay);
		GoodHit();
		if (snapshot != null && AudioManager.Instance != null)
			AudioManager.Instance.SetMixerSnapshot(snapshot, 0.42f);
	}
}
