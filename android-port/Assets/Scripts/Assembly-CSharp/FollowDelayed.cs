using System.Collections.Generic;
using UnityEngine;

public class FollowDelayed : MonoBehaviour
{
	public Transform follow;

	public bool moveOtherTransform;

	public Transform move;

	public float delay;

	private int maxSamples;

	private Transform moveTransform;

	private float m_lastSampleTime;

	private float sampleDelay;

	private Queue<Vector3> positions;

	private void Awake()
	{
	}

	private void CalculateMaxSamples()
	{
	}

	private void Update()
	{
	}
}
