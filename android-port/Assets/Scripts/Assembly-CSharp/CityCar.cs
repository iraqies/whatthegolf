using System;
using UnityEngine;

public class CityCar : MonoBehaviour
{
	[SerializeField]
	private float speed;

	[SerializeField]
	private LayerMask crashWithLayer;

	[SerializeField]
	private bool changeLayerOnCrash;

	[SerializeField]
	private int changeToLayer;

	private Rigidbody _rigidbody;

	public bool Crashed { get; private set; }

	public Collider EnterCollider { get; set; }

	public Collider ExitCollider { get; set; }

	public event Action<CityCar> OnEnterEnd;

	public event Action<CityCar> OnCrash;

	public void Init(Collider enter, Collider exit)
	{
		_rigidbody = GetComponent<Rigidbody>();
		EnterCollider = enter;
		ExitCollider = exit;
		if (_rigidbody != null)
		{
			_rigidbody.constraints = (RigidbodyConstraints)116;
		}
	}

	private void FixedUpdate()
	{
		if (_rigidbody == null || Crashed)
		{
			return;
		}
		_rigidbody.velocity = _rigidbody.transform.forward * speed;
	}

	private void OnTriggerEnter(Collider other)
	{
		if (other == ExitCollider)
		{
			OnEnterEnd?.Invoke(this);
		}
	}

	private void OnCollisionEnter(Collision collision)
	{
		if (collision == null || collision.gameObject == null || _rigidbody == null)
		{
			return;
		}
		int layer = collision.gameObject.layer;
		int mask = crashWithLayer;
		if (((mask >> layer) & 1) != 0 && collision.rigidbody != _rigidbody)
		{
			_rigidbody.constraints = RigidbodyConstraints.None;
			Crashed = true;
			OnCrash?.Invoke(this);
			if (changeLayerOnCrash)
			{
				gameObject.layer = changeToLayer;
			}
		}
	}
}
