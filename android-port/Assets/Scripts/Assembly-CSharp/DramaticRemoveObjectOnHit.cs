using UnityEngine;

public class DramaticRemoveObjectOnHit : MonoBehaviour
{
	public Vector2 DisappearDirection;

	public LayerMask ValidObjects;

	public float DisappearSpeed;

	public float DisappearDuration;

	private bool isDisappearing;

	private Rigidbody2D rigid;

	private float timer;

	private void Start()
	{
	}

	private void Update()
	{
	}

	private void FixedUpdate()
	{
	}

	private void ObjectHit(GameObject hit)
	{
	}

	private void OnCollisionEnter2D(Collision2D col)
	{
	}

	private void OnTriggerEnter2D(Collider2D col)
	{
	}
}
