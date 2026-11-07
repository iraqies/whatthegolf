using System;
using Audio;
using UnityEngine;

public class PlayerSoccerInfo : MonoBehaviour
{
	public Rigidbody Rigidbody;

	public Transform BallPosition;

	public Animator Animator;

	public ParticleSystem SlideParticles;

	public RandomAudioClips SlideClips;

	public BoxCollider FieldArea;

	public Action OnOutOfBounds;

	public Action OnBallRecieved;

	public Action OnBallLost;

	private void OnTriggerEnter(Collider other)
	{
	}

	public bool IsSliding()
	{
		return false;
	}

	public void Slide(Vector3 dir)
	{
	}
}
