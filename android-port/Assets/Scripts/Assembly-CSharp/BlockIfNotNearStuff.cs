using Core;
using UnityEngine;

public class BlockIfNotNearStuff : MonoBehaviour
{
	[SerializeField]
	private LayerMask groundMask;

	[SerializeField]
	private float CheckRadius;

	[SerializeField]
	private bool is2D;

	[SerializeField]
	public bool isBlocked;

	private GolfBallController controller;

	private void Awake()
	{
	}

	private void FixedUpdate()
	{
	}
}
