using Core;
using UnityEngine;

public class FakeSkeleton : MonoBehaviour
{
	public MonoBehaviour[] thingsToDisable;

	public Rigidbody rigid;

	public GolfBallController ballController;

	public Rigidbody fakeBall;

	public Vector3 throwDir;

	public float throwForce = 10f;

	private Vector3 fakeBallStartPos;

	private void Start()
	{
		fakeBallStartPos = fakeBall.position;
		ballController.OnShoot += BallController_OnShoot;
		Level.Instance.OnOutOfBounds += Instance_OnOutOfBounds;
	}

	public void Instance_OnOutOfBounds()
	{
		fakeBall.velocity = Vector3.zero;
		fakeBall.angularVelocity = Vector3.zero;
		fakeBall.MovePosition(fakeBallStartPos);
	}

	private void BallController_OnShoot(Vector3 obj)
	{
		for (int i = 0; i < thingsToDisable.Length; i++)
		{
			thingsToDisable[i].enabled = false;
		}
		Object.Destroy(rigid);
		fakeBall.gameObject.tag = "Untagged";
		ballController.OnShoot -= BallController_OnShoot;
		base.enabled = false;
	}

	private void OnTriggerStay(Collider other)
	{
		if (base.enabled && other.attachedRigidbody == fakeBall)
		{
			fakeBall.AddForce(base.transform.TransformDirection(throwDir) * throwForce, ForceMode.Acceleration);
		}
	}
}
