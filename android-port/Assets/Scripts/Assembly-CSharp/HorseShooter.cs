using UnityEngine;

public class HorseShooter : MonoBehaviour
{
	[SerializeField]
	private Transform frontTransform;

	[SerializeField]
	private Transform backTransform;

	[SerializeField]
	private float distance;

	private Rigidbody rigidbody;

	private float sphereCastRadius;

	private int layerMask;

	private void Awake()
	{
	}

	private void FixedUpdate()
	{
	}

	private Vector3 CalculateTarget(Vector3 position)
	{
		return default;
	}

	public void Bounce()
	{
	}
}
