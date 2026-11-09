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
		if (other == null)
			return;
		if (other.CompareTag("OutOfBounds") || other.CompareTag("OutOfBoundsReload") || other.CompareTag("Water"))
		{
			OnOutOfBounds?.Invoke();
		}
	}

	public bool IsSliding()
	{
		if (Animator != null)
			return Animator.GetBool("Sliding");
		return false;
	}

	public void Slide(Vector3 dir)
	{
		if (SlideParticles != null)
			SlideParticles.Play();
		if (SlideClips != null)
			SlideClips.PlayRandomClip(null);
		if (Rigidbody != null)
			Rigidbody.AddForce(dir, ForceMode.Impulse);
	}
}
