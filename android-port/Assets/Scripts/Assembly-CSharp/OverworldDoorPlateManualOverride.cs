using System.Collections.Generic;
using UnityEngine;

public class OverworldDoorPlateManualOverride : GolfBehaviour
{
	public List<GameObject> stateSmoke;

	public List<GameObject> stateSmoke2;

	public List<GameObject> stateExploded;

	public List<GameObject> stateNormal;

	public ParticleSystem explosionParticles;

	public GameObject stateStartExploded;

	public Explosion2D explosion;

	[SerializeField]
	private OverworldMainDoorPlate plate;

	private float activeTime;

	private float cooldown;

	private float nextHitTime;

	private int hits;

	private Vector3 basePos;

	[SerializeField]
	private Animator animator;

	[SerializeField]
	private Rigidbody2D rigid;

	[SerializeField]
	private PolygonCollider2D col;

	public override void OnPrePlayOrPreCompile()
	{
	}

	private void Update()
	{
	}

	private void Awake()
	{
	}

	private void Plate_OnInit()
	{
	}

	private void Init()
	{
	}

	private void SetStateNormal()
	{
	}

	private void SetStateSmoke()
	{
	}

	private void SetStateSmoke2()
	{
	}

	private void SetStateExploded(bool fromLoad = false)
	{
	}

	private void OnCollisionEnter2D(Collision2D collision)
	{
	}

	private void HitOverride(OverworldBall2D ball)
	{
	}
}
