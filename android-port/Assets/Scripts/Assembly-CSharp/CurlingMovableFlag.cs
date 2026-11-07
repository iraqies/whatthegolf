using UnityEngine;

public class CurlingMovableFlag : MonoBehaviour
{
	public bool moveWhenBroomed;

	public float moveDistance;

	public float moveSpeed;

	private Rigidbody rbody;

	private Vector3 originPos;

	private Vector3 moveSpeedVector;

	private bool moving;

	private void Start()
	{
	}

	private void FixedUpdate()
	{
	}

	private void OnCollisionEnter(Collision collision)
	{
	}
}
