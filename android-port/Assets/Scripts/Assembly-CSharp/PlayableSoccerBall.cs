using UnityEngine;

public class PlayableSoccerBall : MonoBehaviour
{
	public float pickupCooldown;

	public Rigidbody Rigidbody;

	public Collider BallCollider;

	private PlayerSoccerInfo isHeldBy;

	private PlayerSoccerInfo lastHeldBy;

	private float previousPlayerNextPickupTime;

	public PlayerSoccerInfo GetIsHeldBy()
	{
		return null;
	}

	private void Awake()
	{
	}

	private void OnTriggerEnter(Collider other)
	{
	}

	private void FixedUpdate()
	{
	}

	private void SetNewOwner(PlayerSoccerInfo newOwner)
	{
	}

	private void Disengage()
	{
	}

	public void BallShot(Vector3 vel)
	{
	}
}
