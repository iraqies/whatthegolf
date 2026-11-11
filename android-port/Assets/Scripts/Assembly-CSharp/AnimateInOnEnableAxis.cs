using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimateInOnEnableAxis : MonoBehaviour
{
	[SerializeField]
	private float DurationMax = 1f;

	[SerializeField]
	private float DurationMin = 1f;

	[SerializeField]
	private Vector2 Delay = new Vector2(1f, 1f);

	[SerializeField]
	private float Stagger = 1f;

	[SerializeField]
	private AnimationCurve curveX;

	[SerializeField]
	private AnimationCurve curveY;

	[SerializeField]
	private AnimationCurve curveZ;

	public List<GameObject> gameObjects;

	[SerializeField]
	private bool useAnimation;

	[SerializeField]
	private bool disableOnAwake = true;

	[SerializeField]
	private bool shuffle;

	[SerializeField]
	private bool startOnEnable;

	private bool isStarted;

	private void Awake()
	{
		if (shuffle)
		{
			gameObjects.Shuffle();
		}
		if (disableOnAwake)
		{
			gameObjects.ForEach(delegate(GameObject g)
			{
				g.SetActive(false);
			});
		}
	}

	private IEnumerator AnimateIn()
	{
		if (isStarted)
		{
			yield break;
		}
		isStarted = true;
		yield return new WaitForSeconds(Random.Range(Delay.x, Delay.y));
		foreach (GameObject item in gameObjects)
		{
			item.SetActive(true);
			float duration = Random.Range(DurationMin, DurationMax);
			Vector3 baseScale = item.transform.localScale;
			if (!useAnimation)
			{
				StartCoroutine(pTween.To(duration, 0f, 1f, delegate(float t)
				{
					item.transform.localScale = new Vector3(Mathf.LerpUnclamped(0f, baseScale.x, curveX.Evaluate(t)), Mathf.LerpUnclamped(0f, baseScale.y, curveY.Evaluate(t)), Mathf.LerpUnclamped(0f, baseScale.z, curveZ.Evaluate(t)));
				}));
			}
			yield return new WaitForSeconds(Stagger);
		}
	}

	private void Start()
	{
		if (startOnEnable)
		{
			StartCoroutine(AnimateIn());
		}
	}

	public void StartAnimateIn()
	{
		StartCoroutine(AnimateIn());
	}
}
