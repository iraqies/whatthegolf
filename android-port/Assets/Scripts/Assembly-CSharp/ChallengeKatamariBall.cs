using System;
using System.Collections.Generic;
using Core;
using UnityEngine;

public class ChallengeKatamariBall : MonoBehaviour
{
	public float maxSpin = 10f;

	private List<GameObject> _attachedObjects = new List<GameObject>();

	private Rigidbody _rigidbody;

	private float _initialMass;

	private GolfBallShooterExperimental _golfBallShooter;

	public Action<int, float> onBallGrow;

	private Bounds _bounds;

	public string excludeTag;

	private void Start()
	{
		_rigidbody = GetComponent<Rigidbody>();
		_initialMass = _rigidbody.mass;
		_golfBallShooter = GetComponent<GolfBallShooterExperimental>();
	}

	private void OnCollisionEnter(Collision other)
	{
		if (other.transform.tag == "Ground" || (excludeTag != null && other.transform.tag == excludeTag))
		{
			return;
		}
		other.transform.SetParent(base.transform);
		Joint[] componentsInChildren = other.transform.GetComponentsInChildren<Joint>();
		for (int i = 0; i < componentsInChildren.Length; i++)
		{
			UnityEngine.Object.Destroy(componentsInChildren[i]);
		}
		Rigidbody[] componentsInChildren2 = other.transform.GetComponentsInChildren<Rigidbody>();
		for (int j = 0; j < componentsInChildren2.Length; j++)
		{
			UnityEngine.Object.Destroy(componentsInChildren2[j]);
		}
		_bounds = CalculateBounds();
		_attachedObjects.Add(other.gameObject);
		_rigidbody.mass = _bounds.size.magnitude * 0.5f;
		onBallGrow?.Invoke(_attachedObjects.Count, _bounds.size.magnitude);
		_golfBallShooter.spin = Mathf.Max(maxSpin, 30f - _rigidbody.mass);
	}

	public Bounds CalculateBounds()
	{
		Bounds result = new Bounds(base.transform.position, Vector3.one);
		Renderer[] componentsInChildren = GetComponentsInChildren<Renderer>();
		foreach (Renderer renderer in componentsInChildren)
		{
			result.Encapsulate(renderer.bounds);
			Debug.DrawLine(renderer.bounds.center, renderer.bounds.min, Color.blue, 2f);
			Debug.DrawLine(renderer.bounds.center, renderer.bounds.max, Color.blue, 2f);
		}
		Debug.DrawLine(result.center, result.center + result.min, Color.yellow, 2f);
		Debug.DrawLine(result.center, result.center + result.max, Color.yellow, 2f);
		return result;
	}
}
