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
		controller = GetComponent<GolfBallController>();
	}

	private void FixedUpdate()
	{
		if (controller == null)
			return;

		if (is2D)
		{
			Collider2D col = Physics2D.OverlapCircle(base.transform.position, CheckRadius, groundMask);
			controller.canShoot = col == null;
		}
		else
		{
			Collider[] cols = Physics.OverlapSphere(base.transform.position, CheckRadius, groundMask);
			controller.canShoot = cols != null && cols.Length == 0;
		}
		isBlocked = controller.BlockShooting;
	}
}
