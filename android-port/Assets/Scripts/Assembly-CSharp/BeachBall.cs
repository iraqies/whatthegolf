using Audio;
using Core;
using UnityEngine;

public class BeachBall : MonoBehaviour
{
	[SerializeField]
	private GolfBallController Controller;

	[SerializeField]
	private ParticleSystem explosionParticleSystem;

	[SerializeField]
	private RandomAudioClips bangClips;

	[SerializeField]
	private float popOnCollisionThreshold;

	[SerializeField]
	private bool failOnPopped;

	[SerializeField]
	private bool instantiateParticleSystem;

	private bool popped;

	private Level level;

	private void Awake()
	{
	}

	public void Bang()
	{
	}

	private void OnCollisionEnter(Collision other)
	{
	}
}
