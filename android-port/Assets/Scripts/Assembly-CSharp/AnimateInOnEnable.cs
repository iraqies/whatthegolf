using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimateInOnEnable : MonoBehaviour
{
	[SerializeField]
	private float DurationMax = 0.35f;

	[SerializeField]
	private float DurationMin = 0.2f;

	[SerializeField]
	private Vector2 Delay;

	[SerializeField]
	private float Stagger = 0.05f;

	[SerializeField]
	private AnimationCurve curve = AnimationCurve.EaseInOut(0f, 0f, 1f, 1f);

	public List<GameObject> gameObjects;

	[SerializeField]
	private bool useAnimation;

	[SerializeField]
	private bool disableOnAwake;

	[SerializeField]
	private bool shuffle;

	[SerializeField]
	private bool startOnEnable = true;

	[SerializeField]
	private bool _useSetDurations;

	[SerializeField]
	private List<float> _setDurations;

	private bool isStarted;

	[SerializeField]
	private Vector3 _startScale = Vector3.one;

	private void Awake()
	{
		if (_startScale.sqrMagnitude < 1e-4f)
		{
			_startScale = transform.localScale.sqrMagnitude > 1e-4f ? transform.localScale : Vector3.one;
		}
		if (disableOnAwake && gameObjects != null)
		{
			for (int i = 0; i < gameObjects.Count; i++)
			{
				if (gameObjects[i] != null)
				{
					gameObjects[i].SetActive(false);
				}
			}
		}
	}

	private void OnEnable()
	{
		if (startOnEnable)
		{
			StartAnimateIn();
		}
	}

	private IEnumerator AnimateIn()
	{
		float wait = Random.Range(Delay.x, Delay.y);
		if (wait > 0f)
		{
			yield return new WaitForSeconds(wait);
		}
		if (gameObjects != null && gameObjects.Count > 0)
		{
			for (int i = 0; i < gameObjects.Count; i++)
			{
				GameObject go = gameObjects[i];
				if (go != null)
				{
					go.SetActive(true);
				}
				if (Stagger > 0f)
				{
					yield return new WaitForSeconds(Stagger);
				}
			}
		}
		else
		{
			float dur = Mathf.Max(0.05f, Random.Range(DurationMin, DurationMax));
			float t = 0f;
			while (t < dur)
			{
				t += Time.deltaTime;
				float n = Mathf.Clamp01(t / dur);
				float eval = curve != null && curve.length > 0 ? curve.Evaluate(n) : n;
				transform.localScale = Vector3.Lerp(Vector3.zero, _startScale, eval);
				yield return null;
			}
			transform.localScale = _startScale;
		}
	}

	private void Start()
	{
		if (!isStarted && startOnEnable)
		{
			StartAnimateIn();
		}
	}

	public void StartAnimateIn()
	{
		isStarted = true;
		if (gameObject.activeInHierarchy)
		{
			StartCoroutine(AnimateIn());
		}
	}
}
