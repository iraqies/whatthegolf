using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class LivingHouse : MonoBehaviour
{
	[SerializeField]
	private List<Transform> _targets;

	public bool canMove;

	[SerializeField]
	private Rigidbody rb;

	[SerializeField]
	private float speed;

	[SerializeField]
	private bool _contantMove;

	[SerializeField]
	private float _waitBetweenMovesIfConstant;

	[SerializeField]
	private AnimationCurve _speedgain;

	[SerializeField]
	private double _moveTime;

	[SerializeField]
	private AnimationCurve _yCurve;

	[SerializeField]
	private float yHeight;

	[SerializeField]
	private Animator animator;

	public UnityEvent OnMove;

	public UnityEvent OnStop;

	private bool moving;

	private int index;

	private double accDeltaTime;

	private int from => 0;

	private int to => 0;

	private void OnTriggerEnter(Collider other)
	{
	}

	private void Start()
	{
	}

	private void OnShoot(Vector3 obj)
	{
	}

	private void OnDrawGizmos()
	{
	}

	public void SetCanMove(bool b)
	{
	}

	private void FixedUpdate()
	{
	}
}
