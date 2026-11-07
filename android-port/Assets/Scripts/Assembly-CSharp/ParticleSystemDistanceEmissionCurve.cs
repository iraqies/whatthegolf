using UnityEngine;

public class ParticleSystemDistanceEmissionCurve : MonoBehaviour
{
	public AnimationCurve EmissionCurve;

	private ParticleSystem particles;

	private float timer;

	private ParticleSystem.EmissionModule emission;

	private float maxTime;

	private void Awake()
	{
	}

	private void OnEnable()
	{
	}

	private void Update()
	{
	}
}
