using Chronos;
using UnityEngine;

public class AudioPitchToTimeScale : MonoBehaviour
{
	public GlobalClock clock;

	public float amount;

	private AudioSource audioSrc;

	public float basePitch;

	private bool didSetBasePitch;

	private float timeScale => 0f;

	private void Awake()
	{
	}

	private void Update()
	{
	}
}
