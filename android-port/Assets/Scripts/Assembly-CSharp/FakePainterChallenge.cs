using Core;
using UnityEngine;

public class FakePainterChallenge : MonoBehaviour
{
	public GolfBallController FakeController;

	public GolfBallController ActualController;

	public RollingCowShooter Shooter;

	public Animator CameraAnimator;

	public Vector3 StartShot;

	private bool hasShot;

	private void Start()
	{
	}

	private void FakeControllerOnOnShoot(Vector3 obj)
	{
	}
}
