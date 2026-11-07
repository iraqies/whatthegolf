using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class MoveObjectToTarget : MonoBehaviour
{
	public GameObject objectToMove;

	public Transform targetTransform;

	[SerializeField]
	private AnimationCurve _AnimationCurve;

	[SerializeField]
	private float duration;

	[SerializeField]
	private bool usePhysics;

	[SerializeField]
	private bool enableOnStart;

	[SerializeField]
	private Rigidbody rigid;

	[SerializeField]
	private float delay;

	[SerializeField]
	private UnityEvent OnObjectMoving;

	[SerializeField]
	private UnityEvent OnObjectMoved;

	[SerializeField]
	private bool useDefaultCollision;

	[SerializeField]
	private bool useCollision;

	[SerializeField]
	private bool useTrigger;

	[SerializeField]
	private List<string> AcceptedTags;

	[SerializeField]
	private List<Collider> Blacklist;

	private bool isMoving;

	private void Start()
	{
	}

	public void Move()
	{
	}

	private void OnDrawGizmos()
	{
	}

	public void Stop()
	{
	}

	private IEnumerator MoveCR()
	{
		return null;
	}

	private void OnTriggerEnter(Collider other)
	{
	}

	private void OnCollisionEnter(Collision collision)
	{
	}
}
