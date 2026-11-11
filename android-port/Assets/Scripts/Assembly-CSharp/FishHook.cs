using UnityEngine;

public class FishHook : MonoBehaviour
{
	private Transform hookedFish;

	private Collider collider;

	private Rigidbody floater;

	private bool hooked;

	private void Start()
	{
		collider = GetComponent<Collider>();
		floater = GetComponent<Rigidbody>();
		hooked = false;
	}

	private void OnCollisionEnter(Collision other)
	{
		if (other.collider.name == "FishBall")
		{
			hookedFish = other.transform;
			collider.enabled = false;
			hooked = true;
		}
	}

	private void Update()
	{
		if (hooked)
		{
			floater.MovePosition(hookedFish.position);
		}
	}

	public void ReleaseHook()
	{
		hooked = false;
		collider.enabled = true;
	}
}
