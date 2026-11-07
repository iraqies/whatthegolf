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
	}

	private void Barrel_OnExplode(Collider col, ExplosionBarrel barrel)
	{
	}

	private void Start()
	{
	}

	private void Update()
	{
	}

	private void FixedUpdate()
	{
	}

	public void OnCollisionEnter(Collision collision)
	{
	}
}
