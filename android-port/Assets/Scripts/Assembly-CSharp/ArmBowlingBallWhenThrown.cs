using Core;
using UnityEngine;

public class ArmBowlingBallWhenThrown : MonoBehaviour
{
	[SerializeField]
	private GolfBallController controller;

	[SerializeField]
	private StickyObject handSnapper;

	[SerializeField]
	private ExplodeExplosionablesOnCollision exploder;

	private void Start()
	{
		if (exploder != null)
		{
			exploder.enabled = false;
		}
		if (controller != null)
		{
			controller.OnShoot += OnShot;
		}
	}

	private void OnShot(GolfBallController controller, Vector3 dir)
	{
		if (handSnapper != null && !handSnapper.IsConstraintActive && exploder != null)
		{
			exploder.enabled = true;
		}
	}
}
