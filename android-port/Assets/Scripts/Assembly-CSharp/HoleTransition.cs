using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HoleTransition : MonoBehaviour
{
	public Transform start;

	public SpriteRenderer circle;

	public SpriteRenderer circleEnd;

	public SpriteRenderer fullCircle;

	public Color dark;

	public Color bright;

	public GameObject fullScreenUIBlocker;

	private List<SpriteRenderer> circles;

	private List<SpriteRenderer> circlesPool;

	private List<SpriteRenderer> allPool;

	private List<float> circleTimes;

	private float timescale = 8f;

	private SpriteRenderer endCircle;

	private SpriteRenderer fullCircleEnd;

	private float nextCircleSpawn;

	private int sortingOrder = 1;

	private bool isSpawning;

	private float endTimer;

	private Vector3 endCircleScale;

	private WaitForSeconds shortwait = new WaitForSeconds(0.1f);

	private WaitForSeconds longwait = new WaitForSeconds(1f);

	private void Start()
	{
		circles = new List<SpriteRenderer>();
		circlesPool = new List<SpriteRenderer>();
		allPool = new List<SpriteRenderer>();
		circleTimes = new List<float>();
		fullCircleEnd = UnityEngine.Object.Instantiate(fullCircle);
		fullCircleEnd.transform.parent = base.transform;
		fullCircleEnd.enabled = false;
		endCircle = UnityEngine.Object.Instantiate(circleEnd);
		endCircle.transform.parent = base.transform;
		endCircle.gameObject.SetActive(false);
		SpriteRenderer[] componentsInChildren = endCircle.GetComponentsInChildren<SpriteRenderer>();
		for (int i = 0; i < componentsInChildren.Length; i++)
		{
			componentsInChildren[i].color = dark;
		}
		for (int j = 0; j < 10; j++)
		{
			SpriteRenderer spriteRenderer = UnityEngine.Object.Instantiate(circle);
			spriteRenderer.transform.parent = base.transform;
			circlesPool.Add(spriteRenderer);
			spriteRenderer.enabled = false;
			allPool.Add(spriteRenderer);
		}
	}

	private void Update()
	{
		bool flag = false;
		for (int i = 0; i < circles.Count; i++)
		{
			circleTimes[i] += timescale * Time.deltaTime * 0.1f;
			Color color = Color.Lerp(dark, bright, circleTimes[i] * 4f);
			float num = circleTimes[i] * circleTimes[i] * circleTimes[i] * circleTimes[i] * circleTimes[i] * circleTimes[i] * circleTimes[i];
			circles[i].transform.localScale = Vector3.LerpUnclamped(Vector3.zero, Vector3.one * 3f, num);
			circles[i].transform.position = Vector3.MoveTowards(circles[i].transform.position, start.position, Time.deltaTime);
			if (isSpawning || circleTimes[i] > 0.45f)
			{
				circles[i].color = Color.Lerp(Color.clear, color, Mathf.Clamp01((circleTimes[i] - 0.45f) * 8f));
			}
			else
			{
				circles[i].enabled = false;
			}
			flag |= circleTimes[circles.Count - 1] > 2f;
		}
		if (flag)
		{
			circles[circles.Count - 1].enabled = false;
			circlesPool.Add(circles[circles.Count - 1]);
			circleTimes.RemoveAt(circleTimes.Count - 1);
			circles.RemoveAt(circles.Count - 1);
		}
		if (endCircle != null && circleTimes.Count > 0)
		{
			if (isSpawning)
			{
				float num2 = circleTimes[0] * circleTimes[0] * circleTimes[0] * circleTimes[0] * circleTimes[0] * circleTimes[0] * circleTimes[0];
				endCircle.transform.localScale = Vector3.Lerp(Vector3.zero, Vector3.one * 3f, Mathf.Clamp01(num2));
			}
			else
			{
				endTimer += timescale * Time.deltaTime * 0.1f;
				float num3 = circleTimes[circleTimes.Count - 1];
				endCircle.transform.localScale = endCircleScale + Vector3.one * 4000f * num3 * num3 * num3 * num3;
			}
		}
		if (isSpawning && Time.time > nextCircleSpawn && circlesPool.Count > 0)
		{
			SpriteRenderer spriteRenderer = circlesPool[0];
			spriteRenderer.enabled = true;
			circlesPool.RemoveAt(0);
			spriteRenderer.transform.position = start.position;
			sortingOrder = (sortingOrder + 1) % 100;
			spriteRenderer.sortingOrder = sortingOrder;
			spriteRenderer.color = Color.clear;
			spriteRenderer.transform.localScale = Vector3.zero;
			circleTimes.Add(0f);
			circles.Add(spriteRenderer);
			nextCircleSpawn = Time.time + 2f / timescale;
		}
	}

	public IEnumerator StartHole()
	{
		if (isSpawning)
		{
			yield break;
		}
		fullCircleEnd.enabled = false;
		endCircle.gameObject.SetActive(false);
		for (int i = 0; i < allPool.Count; i++)
		{
			allPool[i].enabled = false;
		}
		circles = new List<SpriteRenderer>();
		circleTimes = new List<float>();
		fullScreenUIBlocker.SetActive(true);
		fullCircleEnd.transform.position = start.position;
		fullCircleEnd.sortingOrder = -2;
		fullCircleEnd.transform.localScale = Vector3.zero;
		fullCircleEnd.enabled = true;
		fullCircleEnd.color = dark;
		endCircle.transform.position = start.position;
		endCircle.sortingOrder = -1;
		endCircle.color = dark;
		endCircle.transform.localScale = Vector3.zero;
		endCircle.gameObject.SetActive(true);
		isSpawning = true;
		float startTimeScale = 20f;
		timescale = startTimeScale;
		yield return shortwait;
		StartCoroutine(pTween.To(0.3f, delegate(float t)
		{
			fullCircleEnd.transform.localScale = Vector3.one * t * 0.01f;
		}));
		StartCoroutine(pTween.To(0.3f, delegate(float t)
		{
			timescale = Mathf.Lerp(startTimeScale, 3f, t * t);
		}));
		yield return shortwait;
	}

	public IEnumerator EndHole(Action onDone = null)
	{
		if (!isSpawning)
		{
			yield break;
		}
		isSpawning = false;
		endCircleScale = endCircle.transform.localScale;
		endTimer = 0f;
		StartCoroutine(pTween.To(0.5f, delegate(float t)
		{
			timescale = Mathf.Lerp(5f, 30f, t * t);
		}));
		Color clearColor = new Color(dark.r, dark.g, dark.b, 0f);
		yield return shortwait;
		StartCoroutine(pTween.To(0.1f, delegate(float t)
		{
			fullCircleEnd.color = Color.Lerp(dark, clearColor, t);
		}));
		fullScreenUIBlocker.SetActive(false);
		yield return longwait;
		fullCircleEnd.enabled = false;
		endCircle.gameObject.SetActive(false);
		for (int i = 0; i < circles.Count; i++)
		{
			circles[i].enabled = false;
		}
		onDone?.Invoke();
	}
}
