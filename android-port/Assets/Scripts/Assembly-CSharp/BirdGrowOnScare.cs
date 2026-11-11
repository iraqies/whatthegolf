using System;
using System.Collections;
using Audio;
using UnityEngine;

public class BirdGrowOnScare : MonoBehaviour
{
	public float growSizeFactor;

	public AnimationCurve curve;

	public float animationTime;

	public ClipSettingsCollection growStartClip;

	private BirdNPC bird;

	private void Awake()
	{
		bird = GetComponent<BirdNPC>();
		if (bird != null)
		{
			BirdNPC birdNPC = bird;
			birdNPC.OnBirdScared = (Action<BirdNPC>)Delegate.Combine(birdNPC.OnBirdScared, new Action<BirdNPC>(Bird_OnScared));
		}
	}

	private void Bird_OnScared(BirdNPC obj)
	{
		StartCoroutine(GrowRoutine());
	}

	private IEnumerator GrowRoutine()
	{
		float timer = 0f;
		while (timer < animationTime)
		{
			bird.transform.localScale = Vector3.one * curve.Evaluate(timer / animationTime) * growSizeFactor;
			timer += Time.deltaTime;
			yield return null;
		}
	}
}
