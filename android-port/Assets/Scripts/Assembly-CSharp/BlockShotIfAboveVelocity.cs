using Core;
using UnityEngine;

public class BlockShotIfAboveVelocity : MonoBehaviour
{
	[SerializeField]
	private float sqrMagnitudeThreshold;

	[SerializeField]
	private Rigidbody rigidbody;

	[SerializeField]
	private Rigidbody2D rigidbody2D;

	[SerializeField]
	private bool AddToControllerBlockingFunctions;

	private GolfBallController controller;

	private float sqrVelocity;

	private void Awake()
	{
	}

	public bool IsBlocking()
	{
		return false;
	}
}
