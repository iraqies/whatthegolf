using System.Collections.Generic;
using UnityEngine;

public class RollingClouds : MonoBehaviour
{
	[SerializeField]
	private float _speed = 1f;

	[SerializeField]
	private float _width = 100f;

	[SerializeField]
	private Transform _container;

	private List<Transform> _clouds;

	private Vector3 _start => transform.position - Vector3.right * (_width * 0.5f);

	private Vector3 _end => transform.position + Vector3.right * (_width * 0.5f);

	private void Start()
	{
		_clouds = new List<Transform>();
		Transform root = _container != null ? _container : transform;
		for (int i = 0; i < root.childCount; i++)
		{
			Transform ch = root.GetChild(i);
			if (ch != null)
			{
				_clouds.Add(ch);
			}
		}
	}

	private void FixedUpdate()
	{
		if (_clouds == null || _clouds.Count == 0 || Mathf.Abs(_width) < 0.01f)
		{
			return;
		}
		float minX = _start.x;
		float maxX = _end.x;
		for (int i = 0; i < _clouds.Count; i++)
		{
			Transform c = _clouds[i];
			if (c == null)
			{
				continue;
			}
			Vector3 pos = c.position;
			pos.x += _speed * Time.fixedDeltaTime;
			if (_speed > 0f && pos.x > maxX)
			{
				pos.x -= _width;
			}
			else if (_speed < 0f && pos.x < minX)
			{
				pos.x += _width;
			}
			c.position = pos;
		}
	}

	private void OnDrawGizmos()
	{
	}
}
