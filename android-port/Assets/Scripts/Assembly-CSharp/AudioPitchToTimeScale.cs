using Chronos;
using UnityEngine;

public class AudioPitchToTimeScale : MonoBehaviour
{
	public GlobalClock clock;

	public float amount;

	private AudioSource audioSrc;

	public float basePitch;

	private bool didSetBasePitch;

	private float timeScale => clock != null ? clock.timeScale : Time.timeScale;

	private void Awake()
	{
		audioSrc = GetComponent<AudioSource>();
	}

	private void Update()
	{
		if (audioSrc == null) return;
		if (audioSrc.isPlaying)
		{
			if (!didSetBasePitch)
			{
				didSetBasePitch = true;
				basePitch = audioSrc.pitch;
			}
			audioSrc.pitch = basePitch - (1f - timeScale) * amount;
		}
		else
		{
			didSetBasePitch = false;
		}
	}
}
