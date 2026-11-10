using UnityEngine;

public class AudioPitchToVelocity : MonoBehaviour
{
	public bool use2D;

	public Rigidbody target;

	public Rigidbody2D target2D;

	public float minPitch = 0.9f;

	public float maxPitch = 1.1f;

	public float minVelocity = 1f;

	public float maxVelocity = 5f;

	public float currentVelocity;

	private AudioSource audioSrc;

	private float dampVelocity;

	private AudioPitchToTimeScale timeScalePitcher;

	private void Awake()
	{
		audioSrc = GetComponent<AudioSource>();
		timeScalePitcher = GetComponent<AudioPitchToTimeScale>();
	}

	private void Update()
	{
		if (use2D)
			Check2D();
		else
			Check3D();
	}

	private void Check2D()
	{
		if (target2D == null) return;
		float mag = target2D.velocity.magnitude;
		currentVelocity = Mathf.SmoothDamp(currentVelocity, mag, ref dampVelocity, 0.06f);
		float denom = maxVelocity - minVelocity;
		float t = denom != 0f ? ((currentVelocity - minVelocity) / denom) : 0f;
		float p = Mathf.Lerp(minPitch, maxPitch, t);
		if (timeScalePitcher != null && timeScalePitcher.enabled)
			timeScalePitcher.basePitch = p;
		else if (audioSrc != null)
			audioSrc.pitch = p;
	}

	private void Check3D()
	{
		if (target == null) return;
		float mag = target.velocity.magnitude;
		currentVelocity = Mathf.SmoothDamp(currentVelocity, mag, ref dampVelocity, 0.06f);
		float denom = maxVelocity - minVelocity;
		float t = denom != 0f ? ((currentVelocity - minVelocity) / denom) : 0f;
		float p = Mathf.Lerp(minPitch, maxPitch, t);
		if (timeScalePitcher != null && timeScalePitcher.enabled)
			timeScalePitcher.basePitch = p;
		else if (audioSrc != null)
			audioSrc.pitch = p;
	}
}
