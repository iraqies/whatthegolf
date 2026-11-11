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
		_controller = GetComponent<GolfBallController>();
	}

	private void Update()
	{
		if (_hasThing && thing != null)
		{
			thing.transform.position = base.transform.position.WithY(base.transform.position.y + m_ExtraUp);
		}
	}

	private void OnCollisionEnter(Collision collision)
	{
		if (collision == null || collision.rigidbody == null || !collision.rigidbody.gameObject.CompareTag("RaceSheep"))
		{
			return;
		}
		thing = collision.rigidbody;
		ExplodingDynamiteForLivingThings component = thing.GetComponent<ExplodingDynamiteForLivingThings>();
		if (component != null)
		{
			component.OnPickedUp(m_BallCollider);
			if (component.OnExplodeEvent != null)
			{
				component.OnExplodeEvent.AddListener(BallExploded);
			}
		}
		_hasThing = true;
		thingCollider = collision.collider;
		Physics.IgnoreCollision(thingCollider, m_BallCollider, true);
		if (_controller != null)
		{
			_controller.OnShoot += ControllerOnOnShoot;
		}
	}

	private void BallExploded()
	{
		if (thingCollider != null)
		{
			Physics.IgnoreCollision(thingCollider, m_BallCollider, false);
		}
		_hasThing = false;
	}

	private void ControllerOnOnShoot(Vector3 obj)
	{
		if (_controller != null)
		{
			_controller.OnShoot -= ControllerOnOnShoot;
		}
		_hasThing = false;
		if (thing != null)
		{
			ExplodingDynamiteForLivingThings component = thing.GetComponent<ExplodingDynamiteForLivingThings>();
			if (component != null)
			{
				component.OnPickedUp(null);
			}
			Rigidbody component2 = thing.GetComponent<Rigidbody>();
			if (component2 != null)
			{
				component2.isKinematic = false;
			}
		}
		if (_controller != null)
		{
			Rigidbody component3 = _controller.GetComponent<Rigidbody>();
			if (component3 != null)
			{
				component3.velocity = Vector3.zero;
			}
		}
		StartCoroutine(AfterShoot(thingCollider, obj));
	}

	private IEnumerator AfterShoot(Collider c, Vector3 Dir)
	{
		yield return null;
		if (thing != null && m_FrogTarget != null)
		{
			thing.velocity = Vector3.zero;
			thing.position += Vector3.up * m_ExtraUp;
			thing.transform.position = thing.position + Vector3.up * m_ExtraUp;
			Vector3 throwVelocityWithGravity = PhysicsAimUtility.GetThrowVelocityWithGravity(thing.position, m_FrogTarget.position, _ShootSpeed);
			Debug.Log(Dir.magnitude + " " + Dir.ToString());
			Debug.Log(Dir);
			thing.AddForce((Dir * _ShootSpeed).WithY(throwVelocityWithGravity.y), ForceMode.VelocityChange);
		}
		yield return new WaitForSeconds(0.5f);
		if (c != null)
		{
			Physics.IgnoreCollision(c, m_BallCollider, false);
		}
	}
}
