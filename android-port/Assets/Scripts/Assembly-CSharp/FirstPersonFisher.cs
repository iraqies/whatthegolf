using Core;
using UnityEngine;
using Utility;

public class FirstPersonFisher : GolfBallShooterBase
{
	public float SleepVelocity = 0.1f;

	public float ShootInterval = 0.5f;

	public float minShootVelocity = 5f;

	public float fullShootVelocity = 25f;

	public GameObject Bullet;

	public bool CanShoot;

	private ObjectPool<GameObject> bulletPool;

	private Collider collider;

	private GolfBallController golfControl;

	private Rigidbody fishingRod;

	private float shootTimer;

	private Vector3 shootVelocity;

	public static Vector3 fishingRodTop;

	[RuntimeInitializeOnLoadMethod]
	private static void Init()
	{
		fishingRodTop = Vector3.zero;
	}

	private void Start()
	{
		if (Bullet != null)
		{
			bulletPool = new ObjectPool<GameObject>(Bullet, 0, null);
		}
		collider = GetComponent<Collider>();
		golfControl = GetComponent<GolfBallController>();
		fishingRod = GetComponentInChildren<Rigidbody>();
		Time.timeScale = 0.7f;
	}

	private void Update()
	{
		shootTimer -= Time.deltaTime;
		if ((Input.acceleration.z > 1.2f || Input.GetKeyDown(KeyCode.A)) && !CanShoot)
		{
			Yank();
		}
		if (GameObject.Find("FishingBall(Clone)") == null)
		{
			CanShoot = true;
			if (golfControl != null)
			{
				golfControl.canShoot = false;
			}
		}
		else if (golfControl != null)
		{
			golfControl.canShoot = true;
		}
	}

	protected override void FixedUpdate()
	{
		if (Camera.main == null || fishingRod == null)
			return;

		Vector3 camPos = Camera.main.transform.position;
		Vector3 camFwd = Camera.main.transform.forward;
		Vector3 camUp = Camera.main.transform.up;
		Vector3 targetPos = camPos + camFwd * 4f - camUp * 3f;
		fishingRod.transform.position = Vector3.MoveTowards(fishingRod.transform.position, targetPos, Time.deltaTime * 5f);

		Vector3 rodEuler = fishingRod.rotation.eulerAngles;
		Vector3 camEuler = Camera.main.transform.rotation.eulerAngles;
		Quaternion.Euler(rodEuler.x, camEuler.y, rodEuler.z);

		Vector3 rodPos = fishingRod.position;
		fishingRodTop = new Vector3(rodPos.x, rodPos.y + 8.3f, rodPos.z + 0.5f);
	}

	public override void OnShoot(Vector3 boost)
	{
		Vector3 minVel = base.transform.forward * minShootVelocity;
		Vector3 fullVel = base.transform.forward * fullShootVelocity;
		shootVelocity = Vector3.Lerp(minVel, fullVel, Mathf.Clamp01(boost.magnitude));
		base.OnShoot(shootVelocity);
		TryShoot(shootVelocity);
		CanShoot = false;
	}

	private void TryShoot(Vector3 boost)
	{
		if (!CanShoot || shootTimer > 0f || CameraManager.Instance == null || CameraManager.Instance.MainCamera == null || bulletPool == null)
			return;

		Vector3 start = base.transform.position;
		Vector3 end = base.transform.position + CameraManager.Instance.MainCamera.transform.up * 3f;
		if (Physics.Linecast(start, end, 1 << LayerMask.NameToLayer("Default")))
			return;

		Quaternion rot = Quaternion.LookRotation(CameraManager.Instance.MainCamera.transform.forward);
		GameObject go = bulletPool.Get(fishingRodTop, rot);
		if (go != null)
		{
			go.SetActive(true);
			FishingBall ball = go.GetComponent<FishingBall>();
			if (ball != null)
			{
				ball.BulletPool = bulletPool;
				ball.SetSpeed(boost.magnitude);
				if (collider != null && ball.collider != null)
				{
					Physics.IgnoreCollision(collider, ball.collider, true);
				}
			}
			shootTimer = ShootInterval;
		}
	}

	private void Yank()
	{
		GameObject go = GameObject.Find("FishingBall(Clone)");
		if (go == null)
			return;

		FishingBall ball = go.GetComponent<FishingBall>();
		if (ball == null)
			return;

		if (collider != null && ball.collider != null)
		{
			Physics.IgnoreCollision(collider, ball.collider, false);
		}
		Rigidbody rb = ball.GetComponent<Rigidbody>();
		if (rb != null)
		{
			rb.isKinematic = false;
			rb.position += Vector3.up * 3f;
			rb.velocity = ((base.transform.position - rb.position) + Vector3.up * 3f) * 2.5f;
		}
		Time.timeScale = 0.4f;
	}

	private void OnCollisionEnter(Collision other)
	{
		if (other == null)
			return;

		ContactPoint[] contacts = other.contacts;
		if (contacts != null)
		{
			for (int i = 0; i < contacts.Length; i++)
			{
				if (contacts[i].otherCollider != null && contacts[i].otherCollider.CompareTag("Fish"))
				{
					UnityEngine.Object.Destroy(contacts[i].otherCollider.gameObject);
				}
			}
		}
		Time.timeScale = 0.7f;
	}
}
