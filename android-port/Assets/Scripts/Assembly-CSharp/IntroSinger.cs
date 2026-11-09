using System.Collections;
using UnityEngine;

public class IntroSinger : MonoBehaviour
{
	public float movebackOffset = 1f;

	public float moveforwardOffset = 1f;

	public AnimationCurve animCurve;

	public Vector2 dir;
	private Vector3 _basePos;
	private bool _hasBase;

	public Vector2 GetBorderPos(Vector2 dir)
	{
		return (Vector2)transform.position + dir;
	}

	public void BeginAnimat(float v)
	{
		if (!_hasBase)
		{
			_basePos = transform.localPosition;
			_hasBase = true;
		}
		gameObject.SetActive(true);
		StartCoroutine(Animate(v > 0.05f ? v : 1.5f));
	}

	public void Hide()
	{
		if (!_hasBase)
		{
			_basePos = transform.localPosition;
			_hasBase = true;
		}
		transform.localPosition = _basePos - (Vector3)dir.normalized * movebackOffset;
	}

	public IEnumerator Animate(float time)
	{
		Vector3 start = _basePos - (Vector3)dir.normalized * movebackOffset;
		Vector3 end = _basePos + (Vector3)dir.normalized * moveforwardOffset;
		yield return StartCoroutine(pTween.To(time, 0f, 1f, t =>
		{
			float eval = (animCurve != null && animCurve.length > 0) ? animCurve.Evaluate(t) : Mathf.Sin(t * Mathf.PI);
			transform.localPosition = Vector3.LerpUnclamped(start, end, eval);
		}));
	}
}
