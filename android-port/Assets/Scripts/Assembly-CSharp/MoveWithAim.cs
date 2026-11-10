using Core;
using UnityEngine;

public class MoveWithAim : MonoBehaviour
{
	public float startOffset;

	public float speed = 1f;

	public Vector3 moveDirection = Vector3.left;

	public GolfBallController Controller;

	private Vector3 lastPosition;

	private float total;

	private Vector3 basePosition;

	private void Start()
	{
		Vector3 pos = transform.position;
		basePosition = pos;
		total = startOffset;
		if (Controller != null)
			Controller.OnAimUpdate += OnAimUpdate;
	}

	private void OnAimUpdate(Vector3 dir, bool b)
	{
		total += Vector3.Distance(dir, lastPosition);
		float dist = Mathf.Max(0f, total);
		transform.position = basePosition + moveDirection * speed * dist;
		lastPosition = dir;
	}

	private void OnEnable()
	{
		total = startOffset;
	}
}
