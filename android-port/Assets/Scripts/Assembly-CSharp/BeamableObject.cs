using System;
using UnityEngine;

public class BeamableObject : MonoBehaviour
{
	public GameObject Root;

	public bool isDestroyable;

	public Action<BeamableObject> onBeamed;

	public bool isBeamAble;

	private Rigidbody _rigidbody;

	private Transform _currentBeamPoint;

	public float beamPower;

	private void Awake()
	{
	}

	public void BeamMeUp(Transform beamPoint)
	{
	}

	private void FixedUpdate()
	{
	}
}
