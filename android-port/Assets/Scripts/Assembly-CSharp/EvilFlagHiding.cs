using System.Collections;
using System.Collections.Generic;
using Audio;
using Core;
using UnityEngine;

public class EvilFlagHiding : MonoBehaviour
{
	public List<Transform> sequence;

	public float velocity = 10f;

	public float hideYOffset = 5f;

	public GolfBallController ball;

	public RandomAudioClips audioClip;

	private Rigidbody rigidbody;

	private int currentIndex;

	private bool moving;

	private void Start()
	{
		rigidbody = GetComponent<Rigidbody>();
		currentIndex = 0;
		if (sequence != null && sequence.Count > 0 && sequence[0] != null && rigidbody != null)
		{
			rigidbody.MovePosition(sequence[0].position);
		}
		if (ball != null)
		{
			ball.OnPreShoot -= Ball_OnPreShoot;
			ball.OnPreShoot += Ball_OnPreShoot;
		}
	}

	private void Ball_OnPreShoot(Vector3 aim)
	{
		if (moving) return;
		moving = true;
		StartCoroutine(SwitchHole());
	}

	private IEnumerator SwitchHole()
	{
		if (sequence == null || sequence.Count == 0 || rigidbody == null)
		{
			moving = false;
			yield break;
		}
		if (audioClip != null)
			audioClip.PlayRandomClip(transform.position);

		Vector3 startPos = transform.position;
		Vector3 hiddenStart = startPos - Vector3.up * hideYOffset;
		float spd = Mathf.Max(1f, velocity);
		while (Vector3.Distance(transform.position, hiddenStart) > 0.05f)
		{
			Vector3 next = Vector3.MoveTowards(transform.position, hiddenStart, spd * Time.fixedDeltaTime);
			rigidbody.MovePosition(next);
			yield return new WaitForFixedUpdate();
		}

		currentIndex = (currentIndex + 1) % sequence.Count;
		Transform targetT = sequence[currentIndex];
		if (targetT != null)
		{
			Vector3 targetPos = targetT.position;
			Vector3 hiddenEnd = targetPos - Vector3.up * hideYOffset;
			rigidbody.MovePosition(hiddenEnd);
			yield return new WaitForFixedUpdate();
			if (audioClip != null)
				audioClip.PlayRandomClip(targetPos);
			while (Vector3.Distance(transform.position, targetPos) > 0.05f)
			{
				Vector3 next = Vector3.MoveTowards(transform.position, targetPos, spd * Time.fixedDeltaTime);
				rigidbody.MovePosition(next);
				yield return new WaitForFixedUpdate();
			}
			rigidbody.MovePosition(targetPos);
		}
		moving = false;
	}
}
