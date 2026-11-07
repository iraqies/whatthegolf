using System.Collections;
using Chronos;
using UnityEngine;

public class TimeScaleToVolume : MonoBehaviour
{
	public float minVolume;

	public float maxVolume;

	public float minPitch;

	public float maxPitch;

	private AudioSource audio;

	private Clock clock;

	private Coroutine findAudio;

	private float volumeRef;

	private float pitchRef;

	private float volume;

	private float pitch;

	private void Update()
	{
	}

	private IEnumerator LookForAudio()
	{
		return null;
	}
}
