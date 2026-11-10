using UnityEngine;

public class FollowArrowRotation : MonoBehaviour
{
	public BallShooter shooter;

	private void Start()
	{
		if (shooter != null && shooter.GolfBallController != null)
			shooter.GolfBallController.OnAimUpdate += OnAimUpdate;
	}

	private void OnAimUpdate(Vector3 dir, bool b)
	{
		if (dir.sqrMagnitude > 0.0001f)
			transform.rotation = Quaternion.LookRotation(dir.normalized, Vector3.forward);
	}
}
