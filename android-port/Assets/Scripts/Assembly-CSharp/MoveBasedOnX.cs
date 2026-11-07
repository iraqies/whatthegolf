using UnityEngine;

public class MoveBasedOnX : MonoBehaviour
{
	public Transform trackObject;

	public Transform A;

	public Transform B;

	public float offsetTimer;

	public float Speed;

	private Rigidbody2D rigid;

	private float timer;

	private float baseX;

	private void Awake()
	{
	}

	private void FixedUpdate()
	{
	}
}
