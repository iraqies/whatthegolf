using Audio;
using Core;
using UnityEngine;

public class BoatOar : MonoBehaviour
{
	public Rigidbody2D Rigid;

	public float MoveSpeed;

	public Vector2 Range;

	public float RingSpawnInterval;

	public ParticleSystem RingParticles;

	public ParticleSystem RingParticles2;

	public ClipSettingsCollection clips;

	[SerializeField]
	private GolfBallController boatController;

	private float timer;

	private float ringTimer;

	private void Awake()
	{
	}

	private void Update()
	{
	}
}
