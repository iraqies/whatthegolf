using System.Collections.Generic;
using UnityEngine;

public class MoveCollidersOnMovableSurface : MonoBehaviour
{
	private Transform _dummyTransform;

	private Dictionary<Collider, Transform> _colliderParentDict;

	private void Awake()
	{
		_colliderParentDict = new Dictionary<Collider, Transform>();
		GameObject go = new GameObject();
		_dummyTransform = go.transform;
	}

	private void FixedUpdate()
	{
		if (_dummyTransform != null)
		{
			_dummyTransform.SetPositionAndRotation(transform.position, transform.rotation);
		}
	}

	private void OnCollisionEnter(Collision collision)
	{
		if (collision == null || _colliderParentDict == null)
		{
			return;
		}
		Collider col = collision.collider;
		if (col != null && !_colliderParentDict.ContainsKey(col))
		{
			_colliderParentDict.Add(col, collision.transform.parent);
			collision.transform.SetParent(_dummyTransform);
		}
	}

	private void OnCollisionExit(Collision collision)
	{
		if (collision == null || _colliderParentDict == null)
		{
			return;
		}
		Collider col = collision.collider;
		if (col != null && _colliderParentDict.TryGetValue(col, out Transform origParent))
		{
			collision.transform.SetParent(origParent);
			_colliderParentDict.Remove(col);
		}
	}
}
