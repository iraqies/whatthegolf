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

	public float curveWidth = 4f;

	public float speed = 12f;

	public float distance = 15f;

	private BusFightPlayer player;

	private BusFightPart currentPart;

	private GolfCarShooter carController;

	private Vector3 busPosition;

	private float currentSpeed;

	private bool isDriving;

	private float xMovementMultiplier = 1f;

	private float moveDistanceForSineMovement;

	private bool isEndAnimation;

	private float introBoost;

	private float nextObstacleHit;

	private float hitMultiplier = 1f;

	private IEnumerator Start()
	{
		busPosition = car != null ? car.position : transform.position;
		if (controller != null)
		{
			player = controller.GetComponent<BusFightPlayer>();
			carController = controller.GetComponent<GolfCarShooter>();
			controller.OnBallShot += HandleOnShoot;
		}
		if (player != null)
		{
			player.OnExploded += Player_OnExploded;
			player.OnHitObstacle += Player_OnHitObstacle;
		}
		yield return StartCoroutine(BossRoutine());
	}

	private void Player_OnExploded(float obj)
	{
		StartCoroutine(FailDelayed());
	}

	private IEnumerator FailDelayed()
	{
		yield return new WaitForSeconds(1.5f);
		if (Level.Instance != null)
		{
			Level.Instance.FailLevel(false);
		}
	}

	private void Player_OnHitObstacle(float extraSpeedOnObstacleCollision)
	{
		if (Time.time >= nextObstacleHit)
		{
			nextObstacleHit = Time.time + 0.5f;
			hitMultiplier = Mathf.Clamp(hitMultiplier + 0.25f, 1f, 2.5f);
		}
	}

	private void HandleOnShoot(Vector3 obj)
	{
		isDriving = true;
	}

	private IEnumerator BossRoutine()
	{
		currentSpeed = speed;
		isDriving = true;
		if (busParts != null)
		{
			for (int i = 0; i < busParts.Count; i++)
			{
				currentPart = busParts[i];
				if (currentPart != null)
				{
					currentPart.player = player;
					yield return StartCoroutine(currentPart.AttackRoutine());
					yield return StartCoroutine(currentPart.Dettach());
				}
			}
		}
		isEndAnimation = true;
		if (finalExplosions != null)
		{
			finalExplosions.ExplodeAllSmaller();
		}
		if (catdoll != null)
		{
			catdoll.SetRagdoll(true);
		}
		if (greenWithFlag != null && car != null)
		{
			greenWithFlag.position = car.position + Vector3.forward * 10f;
			greenWithFlag.gameObject.SetActive(true);
		}
		isDriving = false;
	}

	private float GetXMovementFromZ(float z, bool useXmovementMultiplier = true)
	{
		float mult = useXmovementMultiplier ? xMovementMultiplier : 1f;
		return Mathf.Sin(z * 0.05f) * curveWidth * mult;
	}

	private float GetMoveDistanceFromForward(float forward)
	{
		return forward * currentSpeed * Time.deltaTime;
	}

	public Vector3 GetBusPositionForOffsetZ(float zOffset, bool useXmovementMultiplier = true)
	{
		float z = busPosition.z + zOffset;
		float x = GetXMovementFromZ(z, useXmovementMultiplier);
		return new Vector3(x, busPosition.y, z);
	}

	private void Update()
	{
		if (!isDriving || isEndAnimation)
		{
			return;
		}
		float partMult = currentPart != null ? currentPart.speedMultiplier : 1f;
		float step = GetMoveDistanceFromForward(partMult);
		busPosition.z += step;
		busPosition.x = GetXMovementFromZ(busPosition.z, true);
		if (car != null)
		{
			car.MovePosition(busPosition);
		}
		if (backwallPusher != null)
		{
			backwallPusher.MovePosition(GetBusPositionForOffsetZ(-distance, true));
		}
	}
}
