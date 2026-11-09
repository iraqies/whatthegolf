using UnityEngine;

public class ActiveFlagAnimation : MonoBehaviour
{
	[SerializeField]
	private float minScale = 1f;

	[SerializeField]
	private float maxScale = 1.2f;

	[SerializeField]
	private float frequency = 1f;

	[SerializeField]
	private AnimationCurve scaleCurve = AnimationCurve.Linear(0f, 1f, 1f, 1f);

	private float t;

	private Transform cachedTransform;

	private float startTime;

	private float delayedStartTime;

	private void Awake()
	{
		cachedTransform = transform;
		if (scaleCurve != null)
		{
			scaleCurve.postWrapMode = WrapMode.Loop;
			scaleCurve.preWrapMode = WrapMode.Loop;
		}
		if (cachedTransform != null)
			cachedTransform.localScale = Vector3.zero;
		delayedStartTime = Random.Range(0.1f, 0.2f);
	}

	private void Update()
	{
		delayedStartTime -= Time.deltaTime;
		if (delayedStartTime < 0f)
		{
			startTime += Time.deltaTime * 2f;
		}
		t += Mathf.Min(0.2f, Time.deltaTime);
		if (scaleCurve != null && cachedTransform != null)
		{
			float eval = scaleCurve.Evaluate(frequency * t);
			float s = Mathf.Lerp(minScale, maxScale, eval);
			float fade = Mathf.Clamp01(startTime);
			cachedTransform.localScale = Vector3.one * s * fade;
		}
	}
}
