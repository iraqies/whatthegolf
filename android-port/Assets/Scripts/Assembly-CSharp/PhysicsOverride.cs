using UnityEngine;

public class PhysicsOverride : MonoBehaviour
{
	[SerializeField]
	private Vector3 gravity;

	[SerializeField]
	private float bounceThreshold = 15f;

	private float oldBounceThreshold;

	private Vector3 oldGravity;

	private void Awake()
	{
		oldBounceThreshold = Physics.bounceThreshold;
		oldGravity = Physics.gravity;
		Physics.bounceThreshold = bounceThreshold;
		Physics.gravity = gravity;
	}

	private void OnDestroy()
	{
		Physics.bounceThreshold = oldBounceThreshold;
		Physics.gravity = oldGravity;
	}
}
