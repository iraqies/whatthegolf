using System.Collections;
using System.Collections.Generic;
using Cinemachine;
using UnityEngine;

public class BossFrogKingInside : MonoBehaviour
{
	public GameObject StandaloneCamera;

	public GameObject MobileCamera;

	public GameObject TentacleObstaclePrefab;

	public float TentacleSpawnRate;

	public float TentacleMoveSpeed;

	public float TentacleLifeTime;

	public AnimationCurve TentacleHeightCurve;

	public List<Transform> TentacleSpawnPositions;

	public GameObject Container;

	public Vector3 Gravity;

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
	}

	private void Update()
	{
	}

	private IEnumerator MoveRoutine(Rigidbody tentacle)
	{
		return null;
	}

	public void PlayerHitBrain()
	{
	}

	public IEnumerator PlayRoutine()
	{
		return null;
	}
}
