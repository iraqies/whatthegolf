using Core;
using UnityEngine;

public class MoveWithAim : MonoBehaviour
{
	public float startOffset;

	public float speed;

	public Vector3 moveDirection;

	public GolfBallController Controller;

	private Vector3 lastPosition;

	private float total;

	private Vector3 basePosition;

	private void Start()
	{
	}

	private void OnAimUpdate(Vector3 dir, bool b)
	{
	}

	private void OnEnable()
	{
	}
}
