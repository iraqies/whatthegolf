using System.Collections;
using UnityEngine;

public class GooseSpawnedObject : MonoBehaviour
{
	[SerializeField]
	private float destroyDelay;

	[SerializeField]
	private float tweenDuration;

	[SerializeField]
	private AnimationCurve tweenCurve;

	private IEnumerator Start()
	{
		Vector3 maxScale = base.transform.localScale;
		Vector3 minScale = Vector3.one * 0.01f;
		base.transform.localScale = minScale;
		yield return StartCoroutine(pTween.To(tweenDuration, 0f, 1f, delegate(float t)
		{
			float t2 = ((tweenCurve != null) ? tweenCurve.Evaluate(t) : t);
			base.transform.localScale = Vector3.LerpUnclamped(minScale, maxScale, t2);
		}));
		yield return new WaitForSeconds(destroyDelay - (tweenDuration + tweenDuration));
		yield return StartCoroutine(pTween.To(tweenDuration, 0f, 1f, delegate(float t)
		{
			float t2 = ((tweenCurve != null) ? tweenCurve.Evaluate(t) : t);
			base.transform.localScale = Vector3.LerpUnclamped(maxScale, minScale, t2);
		}));
		Object.Destroy(base.gameObject);
	}
}
