using UnityEngine;

public class PhysicsOverride : MonoBehaviour
{
	[SerializeField]
	private Vector3 gravity;

	[SerializeField]
	private float bounceThreshold;

	private float oldBounceThreshold;

	private Vector3 oldGravity;

	private void Awake()
	{
	}

	private void OnDestroy()
	{
	}
}
