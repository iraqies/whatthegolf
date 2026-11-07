using UnityEngine;

public class MovingGalleryTarget : MonoBehaviour
{
	public Transform StartPoint;

	public Transform EndPoint;

	public bool PingPong;

	public float MoveSpeed;

	private Rigidbody rigid;

	private Transform target;

	private void Awake()
	{
	}

	private void FixedUpdate()
	{
	}
}
