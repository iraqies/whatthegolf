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
			goal = GetComponentInParent<GolfGoal>();
		if (goal != null)
		{
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
		GoodHit();
	}

	public void GoodHit()
	{
		if (Time.unscaledTime < nextAudio) return;
		nextAudio = Time.unscaledTime + 0.15f;
		if (sfxHit != null && AudioManager.Instance != null && AudioManager.Instance.shortEffects != null)
			AudioManager.Instance.shortEffects.PlaySimple(sfxHit, volume > 0f ? volume : 1f, 1f, transform.position);
		if (hitFullApplauseSFX != null && hitFullApplauseSFX.Count > 0)
			hitFullApplauseSFX.Play(transform.position, volume > 0f ? volume : 1f, 1f);
		else if (hitNoApplauseSFX != null && hitNoApplauseSFX.Count > 0)
			hitNoApplauseSFX.Play(transform.position, volume > 0f ? volume : 1f, 1f);
	}

	public void BadHit()
	{
		if (hitNoApplauseSFX != null && hitNoApplauseSFX.Count > 0)
			hitNoApplauseSFX.Play(transform.position, volume > 0f ? volume : 1f, 1f);
	}

	private IEnumerator PlayAfterDelay()
	{
		yield return new WaitForSecondsRealtime(playAfterDelay);
		GoodHit();
	}
}
