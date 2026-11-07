using UnityEngine;

public class TweenScale : MonoBehaviour
{
	[SerializeField] private GameObject totween;
	[SerializeField] private Vector3 from = Vector3.zero;
	[SerializeField] private Vector3 to = Vector3.one;
	[SerializeField] private AnimationCurve animationCurve;
	[SerializeField] private float duration = 0.3f;
	[SerializeField] private bool StartOnAwake = true;

	private void Start()
	{
		if (StartOnAwake) Scale();
	}

	public void Scale()
	{
		var target = totween != null ? totween.transform : transform;
		if (duration <= 0f)
		{
			target.localScale = to;
			return;
		}
		StartCoroutine(pTween.To(duration, t =>
		{
			float eval = animationCurve != null && animationCurve.length > 0 ? animationCurve.Evaluate(t) : t;
			if (target != null) target.localScale = Vector3.LerpUnclamped(from, to, eval);
		}));
	}
}
