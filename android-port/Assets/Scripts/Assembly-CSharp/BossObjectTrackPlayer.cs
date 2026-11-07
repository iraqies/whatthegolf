using Audio;
using Core;
using UnityEngine;

public class BossObjectTrackPlayer : MonoBehaviour
{
	public float MoveSpeed;

	public RandomAudioClips DeathClips;

	private GolfBallController controller;

	private Rigidbody rigid;

	private ParticleSystem destroyParticles;

	private bool isGrounded;

	private void Start()
	{
	}

	private void FixedUpdate()
	{
	}

	private void OnCollisionStay(Collision other)
	{
	}

	private void OnParticleCollision(GameObject other)
	{
	}
}
