using System;
using Audio;
using Core;
using UnityEngine;
using Utility;

public class FirstPersonShooter : GolfBallShooterExperimental
{
	public float SmashVelocity = 5f;

	public float SleepVelocity = 0.1f;

	public float ShootInterval = 0.5f;

	public GameObject Bullet;

	public bool CanShoot;

	public bool BulletIsParticles;

	public float ParticlesVelocity = 10f;

	public RandomAudioClips ShootSounds;

	public bool BlockFromController;

	public bool SyncCooldowns = true;

	private ObjectPool<GameObject> bulletPool;

	private Collider collider;

	private float shootTimer;

	private ParticleSystem bulletParticles;

	private TimeControl _timeControll;

	public event Action<Vector3> OnActualShoot;

	private void Start()
	{
		if (BulletIsParticles)
		{
			if (Bullet != null)
			{
				bulletParticles = Bullet.GetComponent<ParticleSystem>();
			}
		}
		else if (Bullet != null)
		{
			bulletPool = new ObjectPool<GameObject>(Bullet, 20, null);
		}
		collider = GetComponent<Collider>();
		if (SyncCooldowns && GolfBallController != null)
		{
			GolfBallController.resetCountdown = ShootInterval;
		}
		if (GolfBallController != null)
		{
			GolfBallController.noCharging = true;
		}
		_timeControll = UnityEngine.Object.FindObjectOfType<TimeControl>();
	}

	private void Update()
	{
		if (_timeControll != null && _timeControll.IsPaused)
			return;

		if (GolfBallController != null && GolfBallController.shootArrow != null)
		{
			GolfBallController.shootArrow.transform.localScale = Vector3.zero;
		}
		shootTimer -= Time.deltaTime;
		bool shootPressed = false;
		if (GolfBallController != null && (GolfBallController.GetPlayerButtonDown(0, "GolfBallShoot") || GolfBallController.GetPlayerButtonUp(0, "GolfBallShoot")))
		{
			shootPressed = true;
		}
		else
		{
			shootPressed = Input.GetMouseButton(0);
		}
		if (PlatformSettings.IsAppleTV && GolfBallController != null)
		{
			if (GolfBallController.GetPlayerButton(0, "GolfBallShoot"))
			{
				shootPressed = true;
			}
			else if (GolfBallController.playerInput != null)
			{
				shootPressed = GolfBallController.playerInput.GetButtonDown("GolfBallShoot");
			}
		}
		if (shootPressed)
		{
			TryShoot(Vector3.one);
		}
	}

	private void Shoot(Vector3 boost)
	{
		if (BulletIsParticles)
		{
			this.OnActualShoot?.Invoke(boost);
			if (bulletParticles != null)
			{
				bulletParticles.Emit(1);
			}
			return;
		}
		if (CameraManager.Instance == null || CameraManager.Instance.MainCamera == null)
			return;

		Vector3 start = base.transform.position;
		Vector3 camFwd = CameraManager.Instance.MainCamera.transform.forward;
		Vector3 end = start + camFwd * 3f;
		if (Physics.Linecast(start, end, 1 << LayerMask.NameToLayer("Default")))
			return;

		this.OnActualShoot?.Invoke(boost);
		if (AudioManager.Instance != null && AudioManager.Instance.RumbleEvents != null && AudioManager.Instance.RumbleEvents.GolfBallShot != null && GolfBallController != null)
		{
			AudioManager.Instance.RumbleEvents.GolfBallShot.Play(GolfBallController.playerID, 1f);
		}
		if (bulletPool != null)
		{
			Quaternion rot = Quaternion.LookRotation(camFwd);
			GameObject go = bulletPool.Get(start + camFwd * 3f, rot);
			if (go != null)
			{
				go.SetActive(true);
				SuperGolfBullet bullet = go.GetComponent<SuperGolfBullet>();
				if (bullet != null)
				{
					bullet.BulletPool = bulletPool;
					bullet.SetSpeed(boost.magnitude);
					if (bullet.collider != null && collider != null)
					{
						Physics.IgnoreCollision(collider, bullet.collider, true);
					}
				}
			}
		}
		shootTimer = ShootInterval;
		if (ShootSounds != null)
		{
			ShootSounds.PlayRandomClip(base.transform);
		}
		if (GolfBallController != null)
		{
			GolfBallController.CountShot();
		}
	}

	private void TryShoot(Vector3 boost)
	{
		if (BlockFromController && GolfBallController != null && GolfBallController.BlockShooting)
			return;
		if (CanShoot && shootTimer <= 0f)
		{
			Shoot(boost);
		}
	}

	private void OnCollisionEnter(Collision other)
	{
		if (other == null || other.gameObject == null)
			return;
		if (other.gameObject.tag == "Destructible" && rigid != null && rigid.velocity.magnitude >= SmashVelocity)
		{
			UnityEngine.Object.Destroy(other.gameObject);
		}
	}
}
