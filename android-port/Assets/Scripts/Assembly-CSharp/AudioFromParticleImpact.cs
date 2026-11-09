using UnityEngine;

public class AudioFromParticleImpact : MonoBehaviour
{
	public AudioSource Source;

	public float minVol;

	public float maxVol = 1f;

	public float smoothTime = 0.1f;

	public float decay = 2f;

	private bool shouldDecay;

	private float shootTime;

	private void Start()
	{
		if (Source == null)
			Source = GetComponent<AudioSource>();
	}

	public void TurnOn()
	{
		shootTime = Time.time;
		shouldDecay = true;
		if (Source != null)
		{
			Source.volume = maxVol > 0f ? maxVol : 1f;
			if (!Source.isPlaying)
				Source.Play();
		}
	}

	private void Update()
	{
		if (!shouldDecay || Source == null)
			return;
		Source.volume = Mathf.MoveTowards(Source.volume, minVol, (decay > 0f ? decay : 2f) * Time.deltaTime);
		if (Source.volume <= minVol + 0.01f)
		{
			shouldDecay = false;
			if (minVol <= 0.01f && Source.isPlaying)
				Source.Stop();
		}
	}
}
