using UnityEngine;

public class BaseLookBehaviour : MonoBehaviour
{
	[SerializeField]
	protected LookAtGolfBall pupil1;

	[SerializeField]
	protected LookAtGolfBall pupil2;

	[SerializeField]
	protected Transform lookAtObject;

	[SerializeField]
	protected Animator animator;

	[SerializeField]
	protected string blinkAnimationTrigger;

	[Range(1f, 30f)]
	[SerializeField]
	protected float minTimeBeforeNextBlink = 4f;

	[Range(1f, 30f)]
	[SerializeField]
	protected float maxTimeBeforeNextBlink = 12f;

	private float timeLeftToNextBlink;

	protected void Start()
	{
		if (lookAtObject != null)
		{
			SetLookAtTarget(lookAtObject);
		}
		if (animator != null)
		{
			timeLeftToNextBlink = Random.Range(minTimeBeforeNextBlink, maxTimeBeforeNextBlink);
		}
	}

	protected void Update()
	{
		if (animator != null)
		{
			UpdateBlinking();
		}
	}

	private void UpdateBlinking()
	{
		timeLeftToNextBlink -= Time.deltaTime;
		if (timeLeftToNextBlink <= 0f)
		{
			timeLeftToNextBlink = Random.Range(minTimeBeforeNextBlink, maxTimeBeforeNextBlink);
			if (animator != null)
			{
				animator.SetTrigger(blinkAnimationTrigger);
			}
		}
	}

	protected void SetLookAtTarget(Transform target)
	{
		if (pupil1 != null)
		{
			pupil1.SetNewLookTarget(target);
		}
		if (pupil2 != null)
		{
			pupil2.SetNewLookTarget(target);
		}
	}
}
