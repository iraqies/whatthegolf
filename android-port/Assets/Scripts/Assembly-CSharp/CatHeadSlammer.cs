using CameraStack;
using UnityEngine;

public class CatHeadSlammer : MonoBehaviour
{
	public Animator Animator;

	public float SlamInterval;

	public float StartDelay;

	public AudioClip SmashRecoveryClip;

	public AudioClip AnticipationClip;

	public AudioClip SmashClip;

	public float Duration = 0.5f;

	public float Speed = 20f;

	public float Magnitude = 2f;

	private float timer;

	private float startTimer;

	private void Awake()
	{
		if (Animator != null)
		{
			Animator.SetInteger("Health", 10);
			Animator.SetTrigger("Reset");
			Animator.enabled = false;
		}
	}

	private void Update()
	{
		if (startTimer > StartDelay)
		{
			if (Animator != null)
			{
				Animator.enabled = true;
			}
			timer += Time.deltaTime;
			if (timer >= SlamInterval)
			{
				if (Animator != null)
				{
					Animator.SetTrigger("SlamHead");
				}
				timer = 0f;
			}
		}
		else
		{
			startTimer += Time.deltaTime;
		}
	}

	public void PlayAnticipationClip()
	{
		if (AudioManager.Instance != null && AudioManager.Instance.golf != null)
		{
			AudioManager.Instance.golf.Play(AnticipationClip, delegate(AudioSource m)
			{
				if (m != null)
				{
					m.transform.position = base.transform.position;
				}
			});
		}
	}

	public void DoScreenShake()
	{
		if (CameraManager.Instance != null)
		{
			CameraManager.Instance.Shake(Duration, Speed, Magnitude);
		}
	}

	public void TakeDamage()
	{
		if (AudioManager.Instance != null && AudioManager.Instance.golf != null)
		{
			AudioManager.Instance.golf.Play(SmashClip, delegate(AudioSource m)
			{
				if (m != null)
				{
					m.transform.position = base.transform.position;
				}
			});
		}
	}

	public void PlaySmashRecoverClip()
	{
		if (AudioManager.Instance != null && AudioManager.Instance.golf != null)
		{
			AudioManager.Instance.golf.Play(SmashRecoveryClip, delegate(AudioSource m)
			{
				if (m != null)
				{
					m.transform.position = base.transform.position;
				}
			});
		}
	}
}
