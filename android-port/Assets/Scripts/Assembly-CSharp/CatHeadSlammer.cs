using UnityEngine;

public class CatHeadSlammer : MonoBehaviour
{
	public Animator Animator;

	public float SlamInterval;

	public float StartDelay;

	public AudioClip SmashRecoveryClip;

	public AudioClip AnticipationClip;

	public AudioClip SmashClip;

	public float Duration;

	public float Speed;

	public float Magnitude;

	private float timer;

	private float startTimer;

	private void Awake()
	{
	}

	private void Update()
	{
	}

	public void PlayAnticipationClip()
	{
	}

	public void DoScreenShake()
	{
	}

	public void TakeDamage()
	{
	}

	public void PlaySmashRecoverClip()
	{
	}
}
