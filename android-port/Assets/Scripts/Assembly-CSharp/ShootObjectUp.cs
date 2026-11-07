using UnityEngine;

public class ShootObjectUp : MonoBehaviour, IObjectLauncher
{
	public Rigidbody2D m_Rigidbody;

	public Vector3 direction;

	public float force;

	public float angularVelocity;

	public float startDelay;

	public float shootCooldown;

	private float lastShotTime;

	private bool isRunning;

	private bool hasShot;

	private void Awake()
	{
	}

	public void StartLauncher()
	{
	}

	public void StopLauncher()
	{
	}

	private void FixedUpdate()
	{
	}

	private void AddForce()
	{
	}
}
