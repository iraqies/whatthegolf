using Core;
using UnityEngine;

public class AsteroidsSatellite : GolfBallShooterBase
{
	public float ShootInterval;

	public float Speed;

	private Vector3 savedBoost;

	private Rigidbody2D rigid;

	public GameObject LaserObject;

	public Transform BarrelTransform;

	public Animator WeaponAnim;

	public Animator SatelliteAnim;

	public GameObject FireObject;

	private bool invulnurable;

	private float shootTimer;

	protected override void Awake()
	{
	}

	public override void OnAimUpdate(Vector3 boost, bool onlyAimArrow)
	{
	}

	private void Update()
	{
	}

	private void FireLaser()
	{
	}

	public override void OnCancel()
	{
	}

	protected override void FixedUpdate()
	{
	}

	private void OnCollisionEnter2D(Collision2D collision)
	{
	}
}
