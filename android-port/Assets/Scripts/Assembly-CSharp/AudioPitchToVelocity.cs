using UnityEngine;

public class AudioPitchToVelocity : MonoBehaviour
{
	public bool use2D;

	public Rigidbody target;

	public Rigidbody2D target2D;

	public float minPitch;

	public float maxPitch;

	public float minVelocity;

	public float maxVelocity;

	public float currentVelocity;

	private AudioSource audioSrc;

	private float dampVelocity;

	private AudioPitchToTimeScale timeScalePitcher;

	private void Awake()
	{
	}

	private void Update()
	{
	}

	private void Check2D()
	{
	}

	private void Check3D()
	{
	}
}
