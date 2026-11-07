using UnityEngine;
using UnityEngine.Events;

public class ResetOnOutOfBounds2D : MonoBehaviour
{
	public UnityEvent AdditionalCalls;

	public bool UsePlayerOutOfBounds;

	public float Delay;

	private Vector2 startPos;

	private Quaternion startRot;

	private Rigidbody2D rigidbody;

	private void Start()
	{
	}

	private void OnReset()
	{
	}

	private void OnTriggerEnter2D(Collider2D other)
	{
	}
}
