using System.Collections;
using Core;
using UnityEngine;

public class OverworldIsland : MonoBehaviour
{
	public Collider2D IslandExitCollider;

	public Collider2D WaveTrigger;

	public Collider2D DockTrigger;

	public GameObject PlayerPrefab;

	public float DockDistance;

	public float ExitDistance;

	public Transform IslandExit;

	public float WaveForce;

	public Transform DockPosition;

	public Transform BoatParkingTransform;

	private BoatPlayer boat;

	private Rigidbody2D ballOnIsland;

	private GolfBallController ballOnIslandController;

	private bool pushPlayerTowardsIsland;

	private bool playerCanLeave;

	private OverworldBallFollower follower;

	private bool routineRunning;

	private float baseBallDrag;

	private void Awake()
	{
	}

	public void OnPierTriggerEnter(Collider2D other)
	{
	}

	private void OnTriggerStay2D(Collider2D other)
	{
	}

	public void OnTriggerExit2D(Collider2D other)
	{
	}

	private IEnumerator DockRoutine()
	{
		return null;
	}

	private void InstanceOnOnNewBall(Transmogrif.BALLSHAPES obj)
	{
	}

	private IEnumerator BoardBoatRoutine()
	{
		return null;
	}

	private void FixedUpdate()
	{
	}

	private void OnDisable()
	{
	}

	private void OnEnable()
	{
	}

	public void DestroyBallOnIsland()
	{
	}

	public void ToogleBallOnIsland(bool state)
	{
	}
}
