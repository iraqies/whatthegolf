using System.Collections;
using UnityEngine;

public class BusFightPart : MonoBehaviour
{
	public enum Pattern
	{
		HoleBehindButton = 0,
		InFrontOfPlayer = 1,
		RandomClusters = 2,
		RollBehind = 3
	}

	public BusFightModuleExplosions explosions;

	public Collider buttonCollider;

	public BusButton button;

	public BoxCollider roadCollider;

	public Transform spawnPosition;

	public Rigidbody prefab;

	public BusFightPlayer player;

	public Pattern pattern;

	public float spawnDistance;

	public int spawnCount;

	public float randomRotateObstacle;

	public float upForce;

	public float xMoveTime;

	public int cols;

	public float sineMovementSpeed;

	public float speedMultiplier;

	private Rigidbody rigid;

	private FixedJoint joint;

	private Collider[] colliders;

	private void Awake()
	{
	}

	public Vector3 GetBackPosition()
	{
		return default;
	}

	public IEnumerator Dettach()
	{
		return null;
	}

	private IEnumerator LandModuleAfterExplosionsAndCleanUp()
	{
		return null;
	}

	public IEnumerator AttackRoutine()
	{
		return null;
	}

	private IEnumerator InFrontOfPlayerRoutine()
	{
		return null;
	}

	private IEnumerator RandomClustersRoutine()
	{
		return null;
	}

	private IEnumerator RollBehindRoutine()
	{
		return null;
	}

	private IEnumerator HoleBehindButtonRoutine()
	{
		return null;
	}

	private Vector3 GetTargetFromIndex(int i)
	{
		return default;
	}

	private IEnumerator Shoot(Vector3 endPosition, bool isClose)
	{
		return null;
	}
}
