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

	public float speed = 5f;

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
		Initialize();
	}

	public void Initialize()
	{
		if (objectToMove == null)
			objectToMove = gameObject;
		objectRigidbody = objectToMove.GetComponent<Rigidbody2D>();
		if (movementBehaviour == MovementBehaviour.onStart && gameObject.activeInHierarchy)
			Move();
	}

	private void OnEnable()
	{
		if (movementBehaviour == MovementBehaviour.onStart && objectToMove != null)
			Move();
	}

	private void OnDisable()
	{
		isMoving = false;
	}

	public void Move()
	{
		if (isMoving || (moveOnce && hasMoved) || positionsToMoveTo == null || positionsToMoveTo.Length == 0)
			return;
		if (moveContinously)
			StartCoroutine(CyclePositions());
		else
			MoveToNext();
	}

	private void OnTriggerEnter2D(Collider2D collision)
	{
		if (movementBehaviour == MovementBehaviour.onTrigger && collision != null && collision.GetComponentInParent<OverworldBall2D>() != null)
			Move();
	}

	public void OnCollisionEnter2D(Collision2D collision)
	{
		if (movementBehaviour == MovementBehaviour.onCollision && collision != null && collision.collider != null && collision.collider.GetComponentInParent<OverworldBall2D>() != null)
			Move();
	}

	public void MoveToNext()
	{
		if (positionsToMoveTo == null || positionsToMoveTo.Length == 0 || objectToMove == null)
			return;
		Transform target = positionsToMoveTo[currentTarget % positionsToMoveTo.Length];
		currentTarget = (currentTarget + 1) % positionsToMoveTo.Length;
		if (target == null) return;
		float dist = Vector2.Distance(objectToMove.transform.position, target.position);
		float dur = speed > 0.01f ? (dist / speed) : 0.5f;
		StartCoroutine(MoveToNextPosition(target.position, dur));
	}

	private IEnumerator MoveToNextPosition(Vector2 targetPosition, float duration)
	{
		isMoving = true;
		hasMoved = true;
		if (delay > 0f)
			yield return new WaitForSeconds(delay);
		OnStartMoving?.Invoke();
		Vector2 startPos = objectToMove != null ? (Vector2)objectToMove.transform.position : targetPosition;
		yield return StartCoroutine(pTween.To(Mathf.Max(0.05f, duration), t =>
		{
			float eval = (animationCurve != null && animationCurve.length > 0) ? animationCurve.Evaluate(t) : t;
			Vector2 p = Vector2.Lerp(startPos, targetPosition, eval);
			if (objectRigidbody != null)
				objectRigidbody.MovePosition(p);
			else if (objectToMove != null)
				objectToMove.transform.position = new Vector3(p.x, p.y, objectToMove.transform.position.z);
		}));
		OnMoved?.Invoke();
		isMoving = false;
	}

	private IEnumerator CyclePositions()
	{
		isMoving = true;
		if (delay > 0f)
			yield return new WaitForSeconds(delay);
		while (enabled && gameObject.activeInHierarchy && positionsToMoveTo != null && positionsToMoveTo.Length > 0)
		{
			Transform target = positionsToMoveTo[currentTarget % positionsToMoveTo.Length];
			currentTarget = (currentTarget + 1) % positionsToMoveTo.Length;
			if (target != null && objectToMove != null)
			{
				float dist = Vector2.Distance(objectToMove.transform.position, target.position);
				float dur = speed > 0.01f ? (dist / speed) : 0.5f;
				yield return StartCoroutine(MoveToNextPosition(target.position, dur));
			}
			if (interval > 0f)
				yield return new WaitForSeconds(interval);
			else
				yield return null;
		}
		isMoving = false;
	}
}
