using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoopMovement : MonoBehaviour
{
	[SerializeField]
	private Vector3 endPosition;

	[SerializeField]
	private float movementSpeed;

	[SerializeField]
	private float pauseTime;

	[SerializeField]
	private bool invertedCycle;

	[SerializeField]
	private AnimationCurve animationCurve;

	[SerializeField]
	private float offset;

	public bool useRigidbody;

	public bool UseCustomInterval;

	public List<float> CustomIntervals;

	private int m_IntervalIndex;

	private int cycles;

	private Rigidbody rb;

	private Vector3 startPosition;

	private void OnDrawGizmos()
	{
	}

	private void Start()
	{
	}

	private IEnumerator MoveProp()
	{
		return null;
	}
}
