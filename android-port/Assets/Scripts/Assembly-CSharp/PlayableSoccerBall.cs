using UnityEngine;

public class PlayableSoccerBall : MonoBehaviour
{
	public float pickupCooldown = 0.15f;

	public Rigidbody Rigidbody;

	public Collider BallCollider;

	private PlayerSoccerInfo isHeldBy;

	private PlayerSoccerInfo lastHeldBy;

	private float previousPlayerNextPickupTime;

	public PlayerSoccerInfo GetIsHeldBy()
	{
		return isHeldBy;
	}

	private void Awake()
	{
		if (Rigidbody == null)
			Rigidbody = GetComponent<Rigidbody>();
	}

	private void OnTriggerEnter(Collider other)
	{
		if (other == null)
			return;
		var player = other.GetComponent<PlayerSoccerInfo>();
		if (player == null)
			return;

		if (isHeldBy == null)
		{
			if (lastHeldBy == player && Time.time >= previousPlayerNextPickupTime)
			{
				SetNewOwner(player);
			}
			else if (lastHeldBy != player)
			{
				SetNewOwner(player);
			}
		}
		else if (isHeldBy != player && player.IsSliding())
		{
			Disengage();
			SetNewOwner(player);
		}
	}

	private void FixedUpdate()
	{
		if (isHeldBy != null && Rigidbody != null && isHeldBy.BallPosition != null)
		{
			Rigidbody.MovePosition(Vector3.MoveTowards(Rigidbody.position, isHeldBy.BallPosition.position, Time.deltaTime * 20f));
		}
	}

	private void SetNewOwner(PlayerSoccerInfo newOwner)
	{
		isHeldBy = newOwner;
		lastHeldBy = newOwner;
		if (newOwner != null)
		{
			newOwner.OnBallRecieved?.Invoke();
			if (BallCollider != null)
				BallCollider.enabled = false;
			if (Rigidbody != null)
			{
				Rigidbody.collisionDetectionMode = CollisionDetectionMode.Discrete;
				Rigidbody.isKinematic = true;
			}
		}
	}

	public void Disengage()
	{
		if (isHeldBy != null)
		{
			isHeldBy.OnBallLost?.Invoke();
		}
		previousPlayerNextPickupTime = Time.time + pickupCooldown;
		if (Rigidbody != null)
			Rigidbody.isKinematic = false;
		isHeldBy = null;
		if (BallCollider != null)
			BallCollider.enabled = true;
		if (Rigidbody != null)
			Rigidbody.collisionDetectionMode = CollisionDetectionMode.ContinuousDynamic;
	}

	public void BallShot(Vector3 vel)
	{
		Disengage();
		if (Rigidbody != null)
			Rigidbody.velocity = vel;
	}
}
