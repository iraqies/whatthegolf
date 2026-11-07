using System.Collections;
using System.Collections.Generic;
using Audio;
using UnityEngine;

public class Snake2D : MonoBehaviour
{
	public Transform head;

	public List<Transform> segments;

	public bool BodyCollision;

	private List<Vector2> breadcrumbs;

	public float segmentSpacing;

	public AnimationCurve EatRoutineCurve;

	public RandomAudioClips AddSegmentClips;

	private void Start()
	{
	}

	private void Update()
	{
	}

	public void AddSegment()
	{
	}

	private IEnumerator AddSegmentRoutine()
	{
		return null;
	}
}
