using UnityEngine;
using UnityEngine.Events;

public class RigidbodyThresholdEvent : MonoBehaviour
{
	public float threshold;

	public Rigidbody _rigidbody3D;

	public Rigidbody2D _rigidbody2D;

	private bool overThreshold;

	private float velocity;

	public UnityEvent onAboveThreshold;

	public UnityEvent onBelowThreshold;

	private void Update()
	{
	}
}
