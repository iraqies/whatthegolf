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

	public float spawnDistance = 15f;

	public int spawnCount = 3;

	public float randomRotateObstacle = 30f;

	public float upForce = 5f;

	public float xMoveTime = 1.5f;

	public int cols = 3;

	public float sineMovementSpeed = 1f;

	public float speedMultiplier = 1f;

	private Rigidbody rigid;

	private FixedJoint joint;

	private Collider[] colliders;

	private bool buttonWasPressed;

	private void Awake()
	{
		rigid = GetComponent<Rigidbody>();
		joint = GetComponent<FixedJoint>();
		colliders = GetComponentsInChildren<Collider>();
		if (button != null)
		{
			button.OnPressed += () => buttonWasPressed = true;
		}
	}

	public Vector3 GetBackPosition()
	{
		if (roadCollider != null)
		{
			return roadCollider.bounds.min;
		}
		return transform.position - transform.forward * 5f;
	}

	public IEnumerator Dettach()
	{
		if (explosions != null)
		{
			explosions.ExplodeButton();
			yield return StartCoroutine(explosions.ExplodeSmallerRoutine());
		}
		if (joint != null)
		{
			Object.Destroy(joint);
		}
		if (rigid != null)
		{
			rigid.isKinematic = false;
			rigid.AddForce(-transform.forward * 10f + Vector3.up * 3f, ForceMode.VelocityChange);
		}
		StartCoroutine(LandModuleAfterExplosionsAndCleanUp());
	}

	private IEnumerator LandModuleAfterExplosionsAndCleanUp()
	{
		yield return new WaitForSeconds(3f);
		gameObject.SetActive(false);
	}

	public IEnumerator AttackRoutine()
	{
		buttonWasPressed = false;
		if (explosions != null)
		{
			explosions.ExplodeHatch();
		}
		while (!buttonWasPressed)
		{
			switch (pattern)
			{
			case Pattern.InFrontOfPlayer:
				yield return StartCoroutine(InFrontOfPlayerRoutine());
				break;
			case Pattern.RandomClusters:
				yield return StartCoroutine(RandomClustersRoutine());
				break;
			case Pattern.RollBehind:
				yield return StartCoroutine(RollBehindRoutine());
				break;
			case Pattern.HoleBehindButton:
				yield return StartCoroutine(HoleBehindButtonRoutine());
				break;
			default:
				yield return new WaitForSeconds(1.5f);
				break;
			}
			yield return new WaitForSeconds(1f);
		}
	}

	private IEnumerator InFrontOfPlayerRoutine()
	{
		for (int i = 0; i < Mathf.Max(1, spawnCount) && !buttonWasPressed; i++)
		{
			Vector3 target = player != null ? player.transform.position + Vector3.forward * spawnDistance : GetTargetFromIndex(i % Mathf.Max(1, cols));
			yield return StartCoroutine(Shoot(target, true));
			yield return new WaitForSeconds(0.5f);
		}
	}

	private IEnumerator RandomClustersRoutine()
	{
		for (int i = 0; i < Mathf.Max(1, spawnCount) && !buttonWasPressed; i++)
		{
			int idx = Random.Range(0, Mathf.Max(1, cols));
			yield return StartCoroutine(Shoot(GetTargetFromIndex(idx), false));
			yield return new WaitForSeconds(0.35f);
		}
	}

	private IEnumerator RollBehindRoutine()
	{
		for (int i = 0; i < Mathf.Max(1, cols) && !buttonWasPressed; i++)
		{
			yield return StartCoroutine(Shoot(GetTargetFromIndex(i), false));
			yield return new WaitForSeconds(0.25f);
		}
	}

	private IEnumerator HoleBehindButtonRoutine()
	{
		int safeCol = Random.Range(0, Mathf.Max(1, cols));
		for (int i = 0; i < Mathf.Max(1, cols) && !buttonWasPressed; i++)
		{
			if (i != safeCol)
			{
				yield return StartCoroutine(Shoot(GetTargetFromIndex(i), false));
			}
		}
		yield return new WaitForSeconds(0.75f);
	}

	private Vector3 GetTargetFromIndex(int i)
	{
		float width = roadCollider != null ? roadCollider.bounds.size.x : 6f;
		float normalized = cols > 1 ? (float)i / (cols - 1) - 0.5f : 0f;
		Vector3 basePos = player != null ? player.transform.position : transform.position;
		return new Vector3(transform.position.x + normalized * width, basePos.y, basePos.z + spawnDistance);
	}

	private IEnumerator Shoot(Vector3 endPosition, bool isClose)
	{
		if (prefab != null && spawnPosition != null)
		{
			Rigidbody spawned = Object.Instantiate(prefab, spawnPosition.position, Quaternion.Euler(0f, Random.Range(-randomRotateObstacle, randomRotateObstacle), 0f));
			spawned.gameObject.SetActive(true);
			Vector3 vel = (endPosition - spawnPosition.position);
			vel.y = upForce;
			spawned.velocity = vel;
		}
		yield return null;
	}
}
