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
		if (enableOnStart)
		{
			Move();
		}
	}

	public void Move()
	{
		if (base.gameObject.activeInHierarchy && (isMoving || (objectToMove != null && targetTransform != null && Vector3.Distance(objectToMove.transform.position, targetTransform.position) >= 0.5f)))
		{
			StartCoroutine(MoveCR());
		}
	}

	private void OnDrawGizmos()
	{
		Gizmos.color = Color.magenta;
		if (targetTransform != null)
		{
			Gizmos.DrawSphere(targetTransform.position, 1f);
			if (objectToMove != null)
			{
				Gizmos.DrawLine(objectToMove.transform.position, targetTransform.position);
			}
		}
	}

	public void Stop()
	{
		StopAllCoroutines();
	}

	private IEnumerator MoveCR()
	{
		isMoving = true;
		yield return new WaitForSeconds(delay);
		Vector3 startPos = ((objectToMove != null) ? objectToMove.transform.position : Vector3.zero);
		OnObjectMoving?.Invoke();
		yield return StartCoroutine(pTween.To(duration, 0f, 1f, delegate(float t)
		{
			if (objectToMove != null && targetTransform != null)
			{
				float t2 = ((_AnimationCurve != null) ? Mathf.Clamp01(_AnimationCurve.Evaluate(t)) : Mathf.Clamp01(t));
				objectToMove.transform.position = Vector3.Lerp(startPos, targetTransform.position, t2);
			}
		}));
		OnObjectMoved?.Invoke();
		isMoving = false;
	}

	private void OnTriggerEnter(Collider other)
	{
		if (useDefaultCollision && !isMoving && useTrigger && other != null && (AcceptedTags == null || AcceptedTags.Count < 1 || AcceptedTags.Contains(other.gameObject.tag)) && (Blacklist == null || !Blacklist.Contains(other)) && base.enabled)
		{
			Move();
		}
	}

	private void OnCollisionEnter(Collision collision)
	{
		if (!isMoving && useCollision && collision != null && (AcceptedTags == null || AcceptedTags.Count < 1 || AcceptedTags.Contains(collision.gameObject.tag)) && (Blacklist == null || !Blacklist.Contains(collision.collider)) && base.enabled)
		{
			Move();
		}
	}

	public MoveObjectToTarget()
	{
		duration = 1f;
	}
}
