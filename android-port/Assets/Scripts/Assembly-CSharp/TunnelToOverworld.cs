using Audio;
using CameraStack;
using Core;
using UnityEngine;

public class TunnelToOverworld : MonoBehaviour
{
	public CBFollow followCamera;

	public GolfGoal goal;

	public AudioSource piperollSource;

	public AudioClip sfxOnEnteringTunnel;

	public AudioClipSettings catSfxOnEnter;

	public FollowTransform BallFollower;

	private bool didActivate;

	private bool isStaticFollow;

	private bool didWin;

	public Vector3 offset;

	private Vector3 currentOffset;

	private Transform ballTransform;

	private float timeSinceStatic;

	private void OnTriggerEnter(Collider other)
	{
		if (other == null || didActivate) return;
		var ball = other.GetComponentInParent<GolfBallController>();
		if (ball == null) return;
		ballTransform = ball.transform;
		didActivate = true;
		if (catSfxOnEnter != null && AudioManager.Instance != null)
			catSfxOnEnter.Play(AudioManager.Instance.shortEffects, Vector3.zero, 0f);
		isStaticFollow = true;
		if (piperollSource != null)
			piperollSource.Play();
		if (followCamera != null && ballTransform != null)
			currentOffset = followCamera.transform.position - ballTransform.position;
		StartCoroutine(pTween.To(1.5f, 0f, 1f, t2 =>
		{
			if (BallFollower != null)
				BallFollower.PositionOffset = new Vector3(0f, Mathf.Sin(t2 * Mathf.PI * 0.5f), 1f);
			currentOffset = Vector3.Lerp(currentOffset, offset, Mathf.Clamp01(t2));
		}));
	}

	private void Update()
	{
		if (isStaticFollow)
		{
			timeSinceStatic += Time.deltaTime;
			if (timeSinceStatic > 0.75f && !didWin)
			{
				didWin = true;
				if (goal != null)
					goal.Complete(1f);
				else if (Level.HasInstance)
					Level.Instance.Complete(null, 1f);
			}
		}
	}
}
