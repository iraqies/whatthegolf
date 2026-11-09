using System.Collections;
using Audio;
using UnityEngine;

public class OverworldMouth : MonoBehaviour
{
	public Transform leftMouth;

	public Transform rightMouth;

	public Transform leftMouthInPos;

	public Transform rightMouthInPos;

	public AnimationCurve closeCurve;

	public ShortcutTunnelEntry tunnelEntry;

	public float animationTime = 0.3f;

	private float nextEatTime;

	private Vector3 rightMouthOutPosition;

	private Vector3 leftMouthOutPosition;

	public Animator SuckerAnimator;

	public Animator FlagAnimator;

	public float delaySFX;

	public ClipSettingsCollection EatSFX;

	private void Start()
	{
		if (leftMouth != null)
			leftMouthOutPosition = leftMouth.position;
		if (rightMouth != null)
			rightMouthOutPosition = rightMouth.position;
	}

	private IEnumerator Eat(OverworldBall2D ball)
	{
		if (EatSFX != null && AudioManager.Instance != null)
			EatSFX.Play(AudioManager.Instance.shortEffects, transform.position, delaySFX);
		if (SuckerAnimator != null)
			SuckerAnimator.SetBool("Suck", true);
		nextEatTime = Time.time + 3f + animationTime;

		if (ball != null)
		{
			if (ball.Controller != null)
			{
				ball.Controller.CancelShooting();
				ball.Controller.enabled = false;
			}
			ball.enabled = false;
			if (ball.rigidBody != null)
			{
				ball.rigidBody.isKinematic = true;
				ball.rigidBody.velocity = Vector2.zero;
			}
		}

		Vector3 startBallPos = ball != null ? ball.transform.position : transform.position;
		float dur = animationTime > 0.01f ? animationTime : 0.3f;
		yield return StartCoroutine(pTween.To(dur, t =>
		{
			float eval = (closeCurve != null && closeCurve.length > 0) ? closeCurve.Evaluate(t) : t;
			if (leftMouth != null && leftMouthInPos != null)
				leftMouth.position = Vector3.Lerp(leftMouthOutPosition, leftMouthInPos.position, eval);
			if (rightMouth != null && rightMouthInPos != null)
				rightMouth.position = Vector3.Lerp(rightMouthOutPosition, rightMouthInPos.position, eval);
			if (ball != null)
				ball.transform.position = Vector3.Lerp(startBallPos, transform.position, t);
		}));

		if (ball != null && tunnelEntry != null)
		{
			var trav = ball.GetComponent<ShortcutTunnelTraversable>();
			if (trav != null)
				tunnelEntry.EnterTunnel(trav);
			ball.enabled = true;
		}

		yield return StartCoroutine(pTween.To(0.3f, t =>
		{
			if (leftMouth != null && leftMouthInPos != null)
				leftMouth.position = Vector3.Lerp(leftMouthInPos.position, leftMouthOutPosition, t);
			if (rightMouth != null && rightMouthInPos != null)
				rightMouth.position = Vector3.Lerp(rightMouthInPos.position, rightMouthOutPosition, t);
		}));

		if (SuckerAnimator != null)
			SuckerAnimator.SetBool("Suck", false);
	}

	private void OnCollisionEnter2D(Collision2D collision)
	{
		if (Time.time < nextEatTime || collision == null || collision.collider == null)
			return;
		var ball = collision.collider.GetComponent<OverworldBall2D>() ?? collision.collider.GetComponentInParent<OverworldBall2D>();
		if (ball != null)
			StartCoroutine(Eat(ball));
	}
}
