using CameraStack;
using UnityEngine;

public class BusFightOildrum : MonoBehaviour
{
	public bool isRolling;

	public Vector3 rollForce;

	private ExplosionBarrel barrel;

	private Rigidbody rigid;

	private float stillTime;

	private bool didExplode;

	private void Awake()
	{
		barrel = GetComponent<ExplosionBarrel>();
		rigid = GetComponent<Rigidbody>();
		if (barrel != null)
		{
			barrel.OnExplode -= Barrel_OnExplode;
			barrel.OnExplode += Barrel_OnExplode;
		}
	}

	private void Barrel_OnExplode(Collider col, ExplosionBarrel barrel)
	{
		if (col != null && !didExplode)
		{
			var player = col.gameObject.GetComponentInParent<BusFightPlayer>();
			if (player != null)
			{
				didExplode = true;
				if (CameraManager.Instance != null)
				{
					CameraManager.Instance.Shake(1f, 90f, 20f);
				}
				player.Explode(transform.position);
			}
		}
	}

	private void Start()
	{
		if (isRolling && rigid != null)
		{
			float rnd = Random.Range(-160f, 160f);
			rigid.AddTorque(Vector3.up * rnd * Time.fixedDeltaTime, ForceMode.Impulse);
		}
	}

	private void Update()
	{
		if (rigid != null)
		{
			if (Mathf.Abs(rigid.velocity.y) < 2f)
			{
				stillTime += Time.deltaTime;
			}
			if (stillTime > 0.2f && barrel != null)
			{
				barrel.canExplode = true;
			}
		}
	}

	private void FixedUpdate()
	{
		if (isRolling)
		{
			if (rigid != null)
			{
				rigid.AddRelativeTorque(Vector3.up * rollForce.magnitude * Time.fixedDeltaTime, ForceMode.Acceleration);
				Vector3 force = Vector3.forward * -760f * Time.fixedDeltaTime;
				Vector3 pos = rigid.position - Vector3.forward * 10f;
				rigid.AddForceAtPosition(force, pos, ForceMode.Acceleration);
			}
		}
		else if (barrel != null && !barrel.didExplode && rigid != null)
		{
			rigid.angularVelocity = Vector3.zero;
		}
	}

	public void OnCollisionEnter(Collision collision)
	{
		if (collision == null || collision.gameObject == null)
			return;
		var player = collision.gameObject.GetComponentInParent<BusFightPlayer>();
		if (player == null)
		{
			if (barrel != null && !barrel.canExplode && isRolling)
			{
				var contacts = collision.contacts;
				if (contacts != null && contacts.Length > 0 && contacts[0].point.y > transform.position.y - 0.5f)
				{
					barrel.canExplode = true;
				}
			}
		}
		else if (barrel != null && !barrel.didExplode)
		{
			didExplode = true;
			barrel.canExplode = true;
			barrel.Explode(null);
			if (CameraManager.Instance != null)
			{
				CameraManager.Instance.Shake(1f, 90f, 20f);
			}
			player.Explode(transform.position);
		}
	}
}
