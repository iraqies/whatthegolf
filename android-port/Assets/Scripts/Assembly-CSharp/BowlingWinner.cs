using System.Collections.Generic;
using Core;
using UnityEngine;

public class BowlingWinner : MonoBehaviour
{
	public List<Rigidbody> Pins;

	public float TippedOverThreshold = 0.8f;

	public int numberOfShots;

	private int numberOfPins;

	private bool didWin;

	private void Start()
	{
		if (Pins != null)
			numberOfPins = Pins.Count;
	}

	private void Update()
	{
		EvaluateShot();
	}

	public void EvaluateShot()
	{
		if (didWin || Pins == null)
			return;
		int tippedCount = 0;
		for (int i = numberOfPins - 1; i >= 0; i--)
		{
			if (i >= Pins.Count)
			{
				tippedCount++;
				continue;
			}
			Rigidbody pin = Pins[i];
			if (pin == null)
			{
				tippedCount++;
				continue;
			}
			if (pin.transform.up.y <= TippedOverThreshold)
			{
				Pins.Remove(pin);
				Rigidbody capturedPin = pin;
				Vector3 startScale = capturedPin.transform.localScale;
				float waitDelay = Random.Range(3.5f, 4.5f);
				float shrinkDuration = Random.Range(0.1f, 0.2f);
				StartCoroutine(
					pTween.To(waitDelay, _ => { }).Then(
						pTween.To(shrinkDuration, t =>
						{
							if (capturedPin != null)
								capturedPin.transform.localScale = Vector3.Lerp(startScale, Vector3.zero, t);
						}).Then(() =>
						{
							if (capturedPin != null)
								capturedPin.gameObject.SetActive(false);
						})
					)
				);
				tippedCount++;
			}
		}

		if (tippedCount == numberOfPins && numberOfPins > 0)
		{
			didWin = true;
			string msg = GetCompletionTextBasedOnScore.GetText(numberOfShots);
			if (Level.HasInstance && Level.Instance != null && Level.Instance.Goal != null)
			{
				if (msg != null)
					Level.Instance.Goal.Complete(msg);
				else
					Level.Instance.Goal.Complete();
			}
		}
	}
}
