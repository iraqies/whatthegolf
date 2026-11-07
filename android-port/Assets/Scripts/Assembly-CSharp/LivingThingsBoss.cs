using System.Collections;
using Core;
using UnityEngine;

public class LivingThingsBoss : MonoBehaviour
{
	private GolfBallController _controller;

	[SerializeField]
	private Transform m_FrogTarget;

	[SerializeField]
	private float _ShootSpeed;

	private bool _hasThing;

	private Rigidbody thing;

	private Collider thingCollider;

	[SerializeField]
	private Collider m_BallCollider;

	[SerializeField]
	private float m_ExtraUp;

	private void Start()
	{
	}

	private void Update()
	{
	}

	private void OnCollisionEnter(Collision collision)
	{
	}

	private void BallExploded()
	{
	}

	private void ControllerOnOnShoot(Vector3 obj)
	{
	}

	private IEnumerator AfterShoot(Collider c, Vector3 Dir)
	{
		return null;
	}
}
