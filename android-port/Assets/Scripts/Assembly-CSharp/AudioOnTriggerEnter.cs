using System.Collections.Generic;
using UnityEngine;

public class AudioOnTriggerEnter : MonoBehaviour
{
	public GameObject objectToCollideWith;

	public bool playSoundAtCollisionPosition;

	public List<AudioClip> clips;

	public float baseVolume;

	public float volumeDeviance;

	public float basePitch;

	public float pitchDeviance;

	public float minDistance;

	public float maxDistance;

	public float cooldown;

	private float nextSoundTime;

	private void OnTriggerEnter(Collider other)
	{
	}
}
