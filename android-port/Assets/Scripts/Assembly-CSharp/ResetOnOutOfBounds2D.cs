using Core;
using UnityEngine;
using UnityEngine.Events;

public class ResetOnOutOfBounds2D : MonoBehaviour
{
	public UnityEvent AdditionalCalls;

	public bool UsePlayerOutOfBounds = true;

	public float Delay;

	private Vector2 startPos;

	private Quaternion startRot;

	private Rigidbody2D rigidbody;

	private void Start()
	{
		startPos = transform.position;
		startRot = transform.rotation;
		rigidbody = GetComponent<Rigidbody2D>();
		if (UsePlayerOutOfBounds && Level.HasInstance)
		{
			Level.Instance.OnReset += OnReset;
		}
	}

	private void OnReset()
	{
		transform.position = new Vector3(startPos.x, startPos.y, 0f);
		transform.rotation = startRot;
		if (rigidbody != null)
		{
			rigidbody.velocity = Vector2.zero;
			rigidbody.angularVelocity = 0f;
		}
		AdditionalCalls?.Invoke();
	}

	private void OnTriggerEnter2D(Collider2D other)
	{
		if (UsePlayerOutOfBounds || other == null) return;
		if (other.gameObject.CompareTag("OutOfBounds") || other.gameObject.CompareTag("OutOfBoundsReset") || other.gameObject.CompareTag("OutOfBoundsReload"))
		{
			OnReset();
		}
	}
}
