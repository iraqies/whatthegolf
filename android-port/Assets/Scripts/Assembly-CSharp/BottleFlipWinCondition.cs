using Core;
using GolfCourse;
using UnityEngine;

public class BottleFlipWinCondition : MonoBehaviour
{
	public GolfBallController Bottle;

	public GolfCoursePinGoal GolfGoal;

	public AudioClip winClip;

	public float SleepThreshold;

	public float DotThreshold;

	public float CheckTimer;

	public bool disableControllerOnWin;

	public Vector3 AxisToCheck;

	public bool ResetPositionOnFaultyShot;

	public bool BlockShooting;

	private bool hasBeenShot;

	private Rigidbody bottleRigid;

	public BottleFlipWinCondition otherDie;

	private bool winPosition;

	private float timer;

	private void Start()
	{
	}

	private void BottleOnOnReset()
	{
	}

	private void Bottle_OnShoot(Vector3 obj)
	{
	}

	private void FixedUpdate()
	{
	}
}
