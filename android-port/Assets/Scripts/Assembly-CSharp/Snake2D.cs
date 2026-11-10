using System.Collections;
using System.Collections.Generic;
using Audio;
using UnityEngine;

public class Snake2D : MonoBehaviour
{
	public Transform head;

	public List<Transform> segments;

	public bool BodyCollision = true;

	private List<Vector2> breadcrumbs;

	public float segmentSpacing;

	public AnimationCurve EatRoutineCurve;

	public RandomAudioClips AddSegmentClips;

	private void Start()
	{
		breadcrumbs = new List<Vector2>();
		if (head != null)
		{
			breadcrumbs.Add(head.position);
		}
		if (segments != null)
		{
			for (int i = 0; i < segments.Count; i++)
			{
				if (segments[i] != null)
					breadcrumbs.Add(segments[i].position);
			}
		}

		if (!BodyCollision && head != null && segments != null)
		{
			Collider2D headCol = head.gameObject.GetComponentInChildren<Collider2D>();
			for (int i = 0; i < segments.Count; i++)
			{
				if (segments[i] == null)
					continue;
				Collider2D segCol = segments[i].GetComponentInChildren<Collider2D>();
				if (segCol != null && headCol != null)
				{
					Physics2D.IgnoreCollision(segCol, headCol, true);
				}
				for (int j = i + 1; j < segments.Count; j++)
				{
					if (segments[j] != null)
					{
						Collider2D otherCol = segments[j].GetComponentInChildren<Collider2D>();
						if (segCol != null && otherCol != null)
						{
							Physics2D.IgnoreCollision(segCol, otherCol, true);
						}
					}
				}
			}
		}
	}

	private void Update()
	{
		if (head == null || breadcrumbs == null || breadcrumbs.Count == 0 || segments == null || segments.Count == 0)
			return;

		Vector2 headPos = head.position;
		float dist = (headPos - breadcrumbs[0]).magnitude;
		if (dist >= segmentSpacing && segmentSpacing > 0f)
		{
			breadcrumbs.RemoveAt(breadcrumbs.Count - 1);
			breadcrumbs.Insert(0, headPos);
			dist %= segmentSpacing;
		}

		if (dist == 0f || segmentSpacing <= 0f)
			return;

		if (breadcrumbs.Count > 1 && segments[0] != null)
		{
			float t = Mathf.Clamp01(dist / segmentSpacing);
			Vector2 p0 = breadcrumbs[1];
			Vector2 p1 = breadcrumbs[0];
			segments[0].position = new Vector3(Mathf.Lerp(p0.x, p1.x, t), Mathf.Lerp(p0.y, p1.y, t), 0f);

			if (breadcrumbs.Count > 2)
			{
				Vector2 d0 = breadcrumbs[1] - breadcrumbs[2];
				Vector2 d1 = headPos - breadcrumbs[1];
				Quaternion r0 = Quaternion.Euler(0f, 0f, Mathf.Atan2(d0.y, d0.x) * 57.29578f);
				Quaternion r1 = Quaternion.Euler(0f, 0f, Mathf.Atan2(d1.y, d1.x) * 57.29578f);
				segments[0].rotation = Quaternion.Slerp(r0, r1, dist / segmentSpacing);
			}
		}

		for (int i = 1; i < segments.Count; i++)
		{
			if (segments[i] == null || i + 1 >= breadcrumbs.Count)
				continue;
			float t = Mathf.Clamp01(dist / segmentSpacing);
			Vector2 p0 = breadcrumbs[i + 1];
			Vector2 p1 = breadcrumbs[i];
			segments[i].position = new Vector3(Mathf.Lerp(p0.x, p1.x, t), Mathf.Lerp(p0.y, p1.y, t), 0f);

			if (i - 1 >= 0 && i + 1 < breadcrumbs.Count)
			{
				Vector2 d0 = breadcrumbs[i] - breadcrumbs[i + 1];
				Vector2 d1 = breadcrumbs[i - 1] - breadcrumbs[i];
				Quaternion r0 = Quaternion.Euler(0f, 0f, Mathf.Atan2(d0.y, d0.x) * 57.29578f);
				Quaternion r1 = Quaternion.Euler(0f, 0f, Mathf.Atan2(d1.y, d1.x) * 57.29578f);
				segments[i].rotation = Quaternion.Slerp(r0, r1, dist / segmentSpacing);
			}
		}
	}

	public void AddSegment()
	{
		if (segments == null || segments.Count == 0 || segments[0] == null)
			return;
		Transform lastSeg = segments[segments.Count - 1];
		if (lastSeg == null)
			return;
		GameObject spawned = Instantiate(segments[0].gameObject, lastSeg.position, Quaternion.identity);
		if (spawned != null)
		{
			segments.Add(spawned.transform);
			if (breadcrumbs != null)
				breadcrumbs.Add(spawned.transform.position);
			StartCoroutine(AddSegmentRoutine());
		}
	}

	private IEnumerator AddSegmentRoutine()
	{
		if (segments == null || segments.Count == 0)
			yield break;
		Transform lastSeg = segments[segments.Count - 1];
		if (lastSeg == null)
			yield break;
		Vector3 targetScale = lastSeg.localScale;
		lastSeg.localScale = Vector3.zero;

		yield return new WaitForSeconds(0.1f);

		for (int i = 0; i < segments.Count - 1; i++)
		{
			Transform seg = segments[i];
			if (seg != null)
			{
				Vector3 origScale = seg.localScale;
				if (AddSegmentClips != null)
				{
					AddSegmentClips.PlayRandomClip(transform.position, i * 0.06f, i * 0.06f);
				}
				StartCoroutine(pTween.To(0.2f, t =>
				{
					if (seg != null && EatRoutineCurve != null)
					{
						float eval = Mathf.Clamp01(EatRoutineCurve.Evaluate(t));
						seg.localScale = Vector3.Lerp(origScale, origScale * 2f, eval);
					}
				}));
			}
			yield return new WaitForSecondsRealtime(0.1f);
		}

		yield return StartCoroutine(pTween.To(0.2f, t =>
		{
			if (lastSeg != null)
			{
				lastSeg.localScale = Vector3.Lerp(Vector3.zero, targetScale, Mathf.Clamp01(TweenFunctions.EaseOut(t)));
			}
		}));
	}
}
