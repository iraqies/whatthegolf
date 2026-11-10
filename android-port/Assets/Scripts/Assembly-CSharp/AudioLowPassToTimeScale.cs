using UnityEngine;

public class AudioLowPassToTimeScale : MonoBehaviour
{
	public float normalAmount;

	public float slowDownAmount;

	private AudioLowPassFilter filter;

	private void Awake()
	{
		filter = GetComponent<AudioLowPassFilter>();
	}

	private void Update()
	{
		if (filter == null) return;
		filter.cutoffFrequency = normalAmount - slowDownAmount * (1f - Time.timeScale);
	}
}
