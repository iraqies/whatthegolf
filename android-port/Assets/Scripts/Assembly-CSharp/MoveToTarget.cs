using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class MoveToTarget : MonoBehaviour
{
	[SerializeField]
	private Transform target;

	[SerializeField]
	private AnimationCurve _AnimationCurve = AnimationCurve.Linear(0f, 0f, 1f, 1f);

	[SerializeField]
	private float duration = 1f;

	[SerializeField]
	private bool usePhysics;

	[SerializeField]
	private bool enableOnStart;

	[SerializeField]
	private Rigidbody rigid;

	[SerializeField]
	private float delay;

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

	private void OnEnable()
	{
		if (enableOnStart)
		{
			Move();
		}
	}

	public void Move()
	{
		if (isMoving || target == null)
		{
			return;
		}
		if (Vector3.Distance(transform.position, target.position) > 0.01f)
		{
			StartCoroutine(MoveCR());
		}
	}

	private IEnumerator MoveCR()
	{
		isMoving = true;
		if (delay > 0f)
		{
			yield return new WaitForSeconds(delay);
		}
		Vector3 startPos = transform.position;
		yield return StartCoroutine(pTween.To(Mathf.Max(0.01f, duration), 0f, 1f, t =>
		{
			if (target == null)
			{
				return;
			}
			float eval = _AnimationCurve != null && _AnimationCurve.length > 0 ? Mathf.Clamp01(_AnimationCurve.Evaluate(t)) : t;
			Vector3 nextPos = Vector3.Lerp(startPos, target.position, eval);
			if (usePhysics && rigid != null)
			{
				rigid.MovePosition(nextPos);
			}
			else
			{
				transform.position = nextPos;
			}
		}));
		OnObjectMoved?.Invoke();
		isMoving = false;
	}

	private void OnTriggerEnter(Collider other)
	{
		if (!enabled || isMoving || !useTrigger || other == null || other.gameObject == null)
		{
			return;
		}
		if (Blacklist != null && Blacklist.Contains(other))
		{
			return;
		}
		if (useDefaultCollision || (AcceptedTags != null && AcceptedTags.Contains(other.gameObject.tag)))
		{
			Move();
		}
	}

	private void OnCollisionEnter(Collision collision)
	{
		if (!enabled || isMoving || !useCollision || collision == null || collision.gameObject == null)
		{
			return;
		}
		if (Blacklist != null && Blacklist.Contains(collision.collider))
		{
			return;
		}
		if (useDefaultCollision || (AcceptedTags != null && AcceptedTags.Contains(collision.gameObject.tag)))
		{
			Move();
		}
	}
}
