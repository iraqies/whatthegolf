using UnityEngine;

public class HoleToWhack : MonoBehaviour
{
	public Transform ItemsContainer;

	public Animator HoleAnimator;

	public Vector2 HiddenDurationRange;

	public Vector2 StayUpDurationRange;

	public Vector2 randomRotationRange;

	public ParticleSystem HitParticles;

	private float hiddenTimer;

	private float stayUpTimer;

	private Animator[] childAnimators;

	private int currentIndex;

	private void Start()
	{
	}

	private void Update()
	{
	}

	private void SetNewTimes()
	{
	}

	public void HasBeenWhacked()
	{
	}
}
