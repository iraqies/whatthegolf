using UnityEngine;

public class ShootObjectUp : MonoBehaviour, IObjectLauncher
{
	public Rigidbody2D m_Rigidbody;

	public Vector3 direction = Vector3.up;

	public float force = 15f;

	public float angularVelocity = 90f;

	public float startDelay = 0.2f;

	public float shootCooldown = 0.5f;

	private float lastShotTime;

	private bool isRunning;

	private bool hasShot;

	private void Awake()
	{
		if (m_Rigidbody != null)
		{
			m_Rigidbody.isKinematic = true;
			Collider2D col = m_Rigidbody.GetComponent<Collider2D>();
			if (col != null)
			{
				col.enabled = false;
			}
		}
	}

	public void StartLauncher()
	{
		lastShotTime = Time.time;
		isRunning = true;
		StartCoroutine(pTween.To(startDelay, _ => { }).Then(AddForce));
	}

	public void StopLauncher()
	{
		isRunning = false;
		enabled = false;
	}

	private void FixedUpdate()
	{
		if (!isRunning || m_Rigidbody == null)
		{
			return;
		}
		if (Time.time - lastShotTime > shootCooldown && Vector2.Distance(m_Rigidbody.position, transform.position) < 0.5f)
		{
			m_Rigidbody.MovePosition(transform.position);
			m_Rigidbody.velocity = Vector2.zero;
			AddForce();
		}
	}

	private void AddForce()
	{
		if (m_Rigidbody == null)
		{
			return;
		}
		Collider2D col = m_Rigidbody.GetComponent<Collider2D>();
		if (col != null)
		{
			col.enabled = true;
		}
		m_Rigidbody.isKinematic = false;
		lastShotTime = Time.time;
		m_Rigidbody.velocity = transform.up * force;
		m_Rigidbody.AddTorque(angularVelocity);
	}
}
