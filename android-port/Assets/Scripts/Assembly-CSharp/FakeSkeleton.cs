using Core;
using UnityEngine;

public class FakeSkeleton : MonoBehaviour
{
	public MonoBehaviour[] thingsToDisable;

	public Rigidbody rigid;

	public GolfBallController ballController;

	public Rigidbody fakeBall;

	public Vector3 throwDir;

	public float throwForce;

	private Vector3 fakeBallStartPos;

	private void Start()
	{
	}

	public void Instance_OnOutOfBounds()
	{
	}

	private void BallController_OnShoot(Vector3 obj)
	{
	}

	private void OnTriggerStay(Collider other)
	{
	}
}
