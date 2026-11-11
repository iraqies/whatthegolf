using Core;
using UnityEngine;

public class AsteroidsSatellite : GolfBallShooterBase
{
	public float ShootInterval;

	public float Speed;

	private Vector3 savedBoost;

	private new Rigidbody2D rigid;

	public GameObject LaserObject;

	public Transform BarrelTransform;

	public Animator WeaponAnim;

	public Animator SatelliteAnim;

	public GameObject FireObject;

	private bool invulnurable;

	private float shootTimer;

	protected override void Awake()
	{
		base.Awake();
		rigid = GetComponent<Rigidbody2D>();
		shootTimer = ShootInterval;
		if (GolfBallController != null && GolfBallController.Level != null)
		{
			GolfBallController.Level.OnComplete += delegate
			{
				invulnurable = true;
			};
		}
	}

	public override void OnAimUpdate(Vector3 boost, bool onlyAimArrow)
	{
		base.OnAimUpdate(boost, onlyAimArrow);
		savedBoost = boost;
		if (FireObject != null)
		{
			FireObject.SetActive(true);
		}
	}

	private void Update()
	{
		shootTimer -= Time.unscaledDeltaTime;
		if (shootTimer <= 0f)
		{
			FireLaser();
			shootTimer = ShootInterval;
		}
	}

	private void FireLaser()
	{
		if (WeaponAnim != null)
		{
			WeaponAnim.SetTrigger("Shoot");
		}
		if (LaserObject != null && BarrelTransform != null)
		{
			Object.Instantiate(LaserObject, BarrelTransform.position, BarrelTransform.rotation);
		}
	}

	public override void OnCancel()
	{
		base.OnCancel();
		if (FireObject != null)
		{
			FireObject.SetActive(false);
		}
	}

	protected override void FixedUpdate()
	{
		base.FixedUpdate();
		if (GolfBallController != null && GolfBallController.IsAiming)
		{
			if (rigid != null)
			{
				rigid.AddForce(new Vector2(savedBoost.x, savedBoost.y) * Speed * Time.fixedUnscaledDeltaTime);
			}
			float z = Mathf.Atan2(savedBoost.y, savedBoost.x) * 57.29578f;
			base.transform.rotation = Quaternion.Euler(0f, 0f, z);
		}
		else if (FireObject != null)
		{
			FireObject.SetActive(false);
		}
	}

	private void OnCollisionEnter2D(Collision2D collision)
	{
		if (invulnurable || collision == null || collision.collider == null)
		{
			return;
		}
		if (collision.collider.GetComponent<Asteroid>() != null)
		{
			if (SatelliteAnim != null)
			{
				SatelliteAnim.SetTrigger("Die");
			}
			if (GolfBallController != null)
			{
				GolfBallController.OutOfBounds("Crash!", 0.4f);
			}
		}
	}
}
