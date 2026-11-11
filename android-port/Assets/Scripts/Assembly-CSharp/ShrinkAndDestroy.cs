using System.Collections;
using UnityEngine;

public class ShrinkAndDestroy : MonoBehaviour
{
	public AnimationCurve ShrinkCurve = new AnimationCurve(new Keyframe(0f, 1f), new Keyframe(1f, 0f));

	public float Duration = 1f;

	public bool startOnStart = true;

	private void Start()
	{
		if (startOnStart)
		{
			StartCoroutine(Shrink());
		}
	}

	public void StartShrink()
	{
		StartCoroutine(Shrink());
	}

	public IEnumerator Shrink()
	{
		float timer = Duration;
		Vector3 startScale = transform.localScale;
		while (timer > 0f)
		{
			float progress = Duration > 0f ? (1f - timer / Duration) : 1f;
			float eval = ShrinkCurve != null ? Mathf.Clamp01(ShrinkCurve.Evaluate(progress)) : (1f - progress);
			transform.localScale = Vector3.Lerp(startScale, Vector3.zero, eval);
			yield return null;
			timer -= Time.deltaTime;
		}
		Destroy(gameObject);
	}
}
