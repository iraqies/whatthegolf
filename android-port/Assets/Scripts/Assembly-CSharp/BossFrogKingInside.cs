using System.Collections;
using System.Collections.Generic;
using Cinemachine;
using Core;
using UnityEngine;

public class BossFrogKingInside : MonoBehaviour
{
	public GameObject StandaloneCamera;

	public GameObject MobileCamera;

	public GameObject TentacleObstaclePrefab;

	public float TentacleSpawnRate = 3f;

	public float TentacleMoveSpeed = 1f;

	public float TentacleLifeTime = 5f;

	public AnimationCurve TentacleHeightCurve;

	public List<Transform> TentacleSpawnPositions;

	public GameObject Container;

	public Vector3 Gravity = new Vector3(0f, -80f, 0f);

	public bool SpawnTentacles;

	public CinemachineBlendListCamera OutroCamera;

	public Rigidbody Player;

	public SpiderManShooter PlayerShooter;

	public Animator OutroAnimator;

	public List<Transform> SpiderWebShootPoints;

	public Transform Brain;

	public Rigidbody BrainRigid;

	private float timer;

	private bool playingOutro;

	private void Awake()
	{
		if (PlatformSettings.Instance != null && PlatformSettings.Instance.GetCurrent() != null && PlatformSettings.Instance.GetCurrent().useRotatedOverworldAndCameraInLevels)
		{
			if (StandaloneCamera != null)
				StandaloneCamera.SetActive(false);
			if (MobileCamera != null)
				MobileCamera.SetActive(true);
		}
		else
		{
			if (StandaloneCamera != null)
				StandaloneCamera.SetActive(true);
			if (MobileCamera != null)
				MobileCamera.SetActive(false);
		}
		timer = TentacleSpawnRate * 0.75f;
		Physics.gravity = Gravity;
	}

	private void Update()
	{
		if (SpawnTentacles)
		{
			timer += Time.deltaTime;
			if (timer >= TentacleSpawnRate && TentacleSpawnPositions != null && TentacleSpawnPositions.Count > 0 && TentacleObstaclePrefab != null)
			{
				int idx = Random.Range(0, TentacleSpawnPositions.Count);
				Transform spawnTransform = TentacleSpawnPositions[idx];
				if (spawnTransform != null)
				{
					GameObject spawned = Instantiate(TentacleObstaclePrefab, spawnTransform.position, Quaternion.identity);
					if (spawned != null)
					{
						spawned.SetActive(true);
						Animator anim = spawned.GetComponentInChildren<Animator>();
						if (anim != null)
							anim.Update(0f);
						Rigidbody rb = spawned.GetComponentInChildren<Rigidbody>();
						StartCoroutine(MoveRoutine(rb));
						timer = 0f;
					}
				}
			}
		}

		if (Application.isEditor && Input.GetKeyUp(KeyCode.B))
		{
			playingOutro = true;
		}
	}

	private IEnumerator MoveRoutine(Rigidbody tentacle)
	{
		if (tentacle == null)
			yield break;
		float elapsed = 0f;
		float startY = tentacle.position.y;
		while (elapsed < TentacleLifeTime && tentacle != null)
		{
			elapsed += Time.fixedDeltaTime;
			Vector3 pos = tentacle.position;
			float heightOffset = (TentacleHeightCurve != null) ? TentacleHeightCurve.Evaluate(elapsed / TentacleLifeTime) : 0f;
			Vector3 step = Vector3.forward * (Time.fixedDeltaTime * TentacleMoveSpeed);
			tentacle.MovePosition(new Vector3(pos.x - step.x, startY + heightOffset - step.y, pos.z - step.z));
			yield return new WaitForFixedUpdate();
		}
		if (tentacle != null)
		{
			Destroy(tentacle.gameObject);
		}
	}

	public void PlayerHitBrain()
	{
		if (!playingOutro)
		{
			playingOutro = true;
		}
	}

	public IEnumerator PlayRoutine()
	{
		while (!playingOutro)
		{
			yield return null;
		}
	}

	private void OnDestroy()
	{
		Physics.gravity = new Vector3(0f, -50f, 0f);
	}
}
