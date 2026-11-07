using System.Collections.Generic;
using Audio;
using UnityEngine;

public class LightningEffect : MonoBehaviour
{
	public Vector2 EmissionTime;

	public List<AudioClip> Clips;

	public ClipSettingsCollection LightingSFX;

	public Gradient LightningGradient;

	public AnimationCurve LightningCurve;

	public ParticleSystem Particles;

	public Light DirectionalLight;

	public float Duration;

	public float ShakeDuration;

	public Vector2 ShakeSpeedRange;

	public float ShakeMagnitude;

	private float timer;

	private float nextLightning;

	private Camera mainCamera;

	private void Start()
	{
	}

	private void Update()
	{
	}

	private void LightningRoutine()
	{
	}
}
