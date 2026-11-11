using System.Collections;
using UnityEngine;

public class PlayAnimationRandomIntervals : MonoBehaviour
{
	private Animator animator;

	private bool canBlink = true;

	public float minInterval;

	public float maxInterval;

	private void Start()
	{
		animator = GetComponent<Animator>();
	}

	private void Update()
	{
		if (canBlink)
		{
			StartCoroutine(Blink());
		}
	}

	private IEnumerator Blink()
	{
		canBlink = false;
		if (animator != null)
		{
			animator.SetTrigger("blink");
		}
		yield return new WaitForSeconds(Random.Range(minInterval, maxInterval));
		canBlink = true;
	}
}
