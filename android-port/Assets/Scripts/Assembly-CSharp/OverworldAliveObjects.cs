using System.Collections;
using UnityEngine;
using UnityEngine.Events;

public class OverworldAliveObjects : MonoBehaviour
{
	public enum MovementBehaviour
	{
		none = 0,
		onStart = 1,
		onTrigger = 2,
		onCollision = 3
	}

	public GameObject objectToMove;

	public Transform[] positionsToMoveTo;

	public float speed;

	public float interval;

	public float delay;

	public AnimationCurve animationCurve;

	public MovementBehaviour movementBehaviour;

	public bool moveContinously;

	public bool moveOnce;

	private bool hasMoved;

	public UnityEvent OnStartMoving;

	public UnityEvent OnMoved;

	private bool isMoving;

	private int currentTarget;

	private Rigidbody2D objectRigidbody;

	private void Start()
	{
	}

	public void Initialize()
	{
	}

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	public void Move()
	{
	}

	private void OnTriggerEnter2D(Collider2D collision)
	{
	}

	public void OnCollisionEnter2D(Collision2D collision)
	{
	}

	public void MoveToNext()
	{
	}

	private IEnumerator MoveToNextPosition(Vector2 targetPosition, float duration)
	{
		return null;
	}

	private IEnumerator CyclePositions()
	{
		return null;
	}
}
