using System.Collections.Generic;
using UnityEngine;

public class AudioOnTriggerEnter : MonoBehaviour
{
	public GameObject objectToCollideWith;

	public bool playSoundAtCollisionPosition;

	public List<AudioClip> clips;

	public float baseVolume = 1f;

	public float volumeDeviance;

	public float basePitch = 1f;

	public float pitchDeviance;

	public float minDistance = 1f;

	public float maxDistance = 30f;

	public float cooldown = 0.1f;

	private float nextSoundTime;

	private void OnTriggerEnter(Collider other)
	{
		if (other == null || Time.time < nextSoundTime || clips == null || clips.Count == 0)
			return;
		if (objectToCollideWith != null && other.gameObject != objectToCollideWith)
			return;
		var clip = clips[Random.Range(0, clips.Count)];
		if (clip != null && AudioManager.Instance != null && AudioManager.Instance.shortEffects != null)
		{
			float vol = (baseVolume > 0f ? baseVolume : 1f) + Random.Range(-volumeDeviance, volumeDeviance);
			float pit = (basePitch > 0.05f ? basePitch : 1f) + Random.Range(-pitchDeviance, pitchDeviance);
			Vector3 pos = playSoundAtCollisionPosition ? other.transform.position : transform.position;
			AudioManager.Instance.shortEffects.PlaySimple(clip, vol, pit, pos, maxDistance);
			nextSoundTime = Time.time + cooldown;
		}
	}
}
