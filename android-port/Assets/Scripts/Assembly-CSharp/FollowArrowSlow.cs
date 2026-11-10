using UnityEngine;

public class FollowArrowSlow : MonoBehaviour
{
	public BallShooter shooter;

	public float moveSpeed = 10f;

	public Vector3 smoothVel;

	private bool isAdjusting;

	private Collider2D collider;

	private void Start()
	{
		isAdjusting = true;
		if (shooter != null)
		{
			shooter.OnShootEvent += Shooter_OnShoot;
			if (shooter.GolfBallController != null)
				shooter.GolfBallController.OnAimUpdate += UpdateFollow;
		}
		collider = GetComponentInChildren<Collider2D>();
		if (collider != null)
			collider.isTrigger = true;
	}

	private void UpdateFollow(Vector3 boost, bool t)
	{
		if (!isAdjusting)
			return;
		Vector3 norm = boost.normalized;
		float angle = Mathf.Atan2(norm.y, norm.x) * 57.29578f;
		Quaternion targetRot = Quaternion.AngleAxis(angle, Vector3.forward);
		transform.rotation = Quaternion.Lerp(transform.rotation, targetRot, Time.deltaTime * moveSpeed);
	}

	private void Shooter_OnShoot(Vector2 obj)
	{
		isAdjusting = false;
		if (collider != null)
			collider.isTrigger = false;
	}
}
