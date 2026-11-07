using System.Collections;
using System.Collections.Generic;
using Core;
using UnityEngine;

public class BusFight : MonoBehaviour
{
	public bool isDebugEasy;

	public Transform greenWithFlag;

	public Rigidbody backwallPusher;

	public List<BusFightPart> busParts;

	public GolfBallController controller;

	public ToggleGenericRagdoll catdoll;

	public BusFightModuleExplosions finalExplosions;

	public Rigidbody car;

	public float curveWidth;

	public float speed;

	public float distance;

	private BusFightPlayer player;

	private BusFightPart currentPart;

	private GolfCarShooter carController;

	private Vector3 busPosition;

	private float currentSpeed;

	private bool isDriving;

	private float xMovementMultiplier;

	private float moveDistanceForSineMovement;

	private bool isEndAnimation;

	private float introBoost;

	private float nextObstacleHit;

	private float hitMultiplier;

	private IEnumerator Start()
	{
		return null;
	}

	private void Player_OnExploded(float obj)
	{
	}

	private IEnumerator FailDelayed()
	{
		return null;
	}

	private void Player_OnHitObstacle(float extraSpeedOnObstacleCollision)
	{
	}

	private void HandleOnShoot(Vector3 obj)
	{
	}

	private IEnumerator BossRoutine()
	{
		return null;
	}

	private float GetXMovementFromZ(float z, bool useXmovementMultiplier = true)
	{
		return 0f;
	}

	private float GetMoveDistanceFromForward(float forward)
	{
		return 0f;
	}

	public Vector3 GetBusPositionForOffsetZ(float zOffset, bool useXmovementMultiplier = true)
	{
		return default;
	}

	private void Update()
	{
	}
}
