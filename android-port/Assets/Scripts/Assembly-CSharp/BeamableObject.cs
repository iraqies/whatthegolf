using System;
using UnityEngine;

public class BeamableObject : MonoBehaviour
{
	public GameObject Root;

	public bool isDestroyable;

	public Action<BeamableObject> onBeamed;

	public bool isBeamAble = true;

	private Rigidbody _rigidbody;

	private Transform _currentBeamPoint;

	public float beamPower = 100f;

	private void Awake()
	{
		_rigidbody = GetComponent<Rigidbody>();
		if (Root == null)
		{
			Root = base.gameObject;
		}
		isBeamAble = true;
	}

	public void BeamMeUp(Transform beamPoint)
	{
		isBeamAble = false;
		_currentBeamPoint = beamPoint;
	}

	private void FixedUpdate()
	{
		if (_currentBeamPoint == null)
		{
			return;
		}
		Vector3 normalized = (_currentBeamPoint.position - base.transform.position).normalized;
		if (_rigidbody != null)
		{
			_rigidbody.AddForce(normalized * beamPower);
		}
		base.transform.localScale = Vector3.Lerp(base.transform.localScale, Vector3.zero, Mathf.Clamp01(Time.deltaTime));
		if (Vector3.Distance(base.transform.position, _currentBeamPoint.position) < 6f)
		{
			UnityEngine.Object.Destroy(base.gameObject);
			onBeamed?.Invoke(this);
		}
	}
}
