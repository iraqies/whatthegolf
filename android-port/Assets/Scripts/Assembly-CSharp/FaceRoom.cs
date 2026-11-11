using System.Collections;
using Audio;
using UnityEngine;

public class FaceRoom : MonoBehaviour
{
	public ClipSettingsCollection wakeupSFX;

	public Transform eyeLeft;

	public Transform eyeRight;

	public Transform mouth;

	private Vector3 eyeBaseScale;

	private Vector3 mouthScale;

	private Vector3 closedMouthScale;

	private bool isAwake;

	private Vector3 baseScale;

	public bool UseAnimation;

	public Animator animator;

	private bool onCooldown;

	public float CooldownDuration;

	private void Start()
	{
		eyeBaseScale = eyeLeft.localScale;
		mouthScale = mouth.localScale;
		closedMouthScale = mouthScale;
		closedMouthScale.y = 0f;
		mouth.localScale = closedMouthScale;
		eyeLeft.localScale = Vector3.zero;
		eyeRight.localScale = Vector3.zero;
		baseScale = base.transform.localScale;
	}

	private void OnCollisionEnter2D(Collision2D collision)
	{
		if (!isAwake && collision.gameObject.GetComponent<OverworldBall2D>() != null && !onCooldown)
		{
			wakeupSFX.Play(null, base.transform.position);
			if (UseAnimation)
			{
				animator.SetTrigger("Scare");
			}
			else
			{
				StartCoroutine(WakeUp());
			}
			StartCoroutine(CooldownRoutine());
		}
	}

	private IEnumerator CooldownRoutine()
	{
		onCooldown = true;
		yield return new WaitForSeconds(CooldownDuration);
		onCooldown = false;
	}

	private IEnumerator WakeUp()
	{
		isAwake = true;
		StartCoroutine(pTween.To(0.8f, delegate(float t)
		{
			eyeLeft.localScale = Vector3.Lerp(Vector3.zero, eyeBaseScale, Mathf.Clamp01(TweenFunctions.ElasticOut(t)));
		}));
		StartCoroutine(pTween.To(0.8f, delegate(float t)
		{
			eyeRight.localScale = Vector3.Lerp(Vector3.zero, eyeBaseScale, Mathf.Clamp01(TweenFunctions.ElasticOut(t)));
		}));
		StartCoroutine(pTween.To(0.3f, delegate(float t)
		{
			mouth.localScale = Vector3.Lerp(closedMouthScale, mouthScale, Mathf.Clamp01(TweenFunctions.EaseOut(t)));
		}));
		StartCoroutine(pTween.To(0.5f, delegate(float t)
		{
			base.transform.localScale = Vector3.Lerp(baseScale, baseScale * 1.2f, Mathf.Clamp01(TweenFunctions.punch(2f, t)));
		}));
		yield return new WaitForSeconds(1f);
		StartCoroutine(pTween.To(0.2f, delegate(float t)
		{
			eyeLeft.localScale = Vector3.Lerp(eyeBaseScale, Vector3.zero, Mathf.Clamp01(TweenFunctions.EaseIn(t)));
		}));
		StartCoroutine(pTween.To(0.2f, delegate(float t)
		{
			eyeRight.localScale = Vector3.Lerp(eyeBaseScale, Vector3.zero, Mathf.Clamp01(TweenFunctions.EaseIn(t)));
		}));
		yield return new WaitForSeconds(0.1f);
		StartCoroutine(pTween.To(0.4f, delegate(float t)
		{
			mouth.localScale = Vector3.Lerp(mouthScale, closedMouthScale, Mathf.Clamp01(TweenFunctions.EaseIn(t)));
		}));
		yield return new WaitForSeconds(0.4f);
		isAwake = false;
	}
}
