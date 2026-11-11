using System.Collections.Generic;
using Core;
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
	private float speed = 1f;

	[SerializeField]
	private bool _contantMove;

	[SerializeField]
	private float _waitBetweenMovesIfConstant = 1f;

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

	private int from => index != 0 ? (index - 1) : ((_targets != null ? _targets.Count : 1) - 1);

	private int to => index;

	private void OnTriggerEnter(Collider other)
	{
		if (other == null) return;
		if (other.GetComponentInParent<GolfBallController>() != null || other.CompareTag("Player"))
		{
			canMove = true;
		}
	}

	private void Start()
	{
		GameObject startTarget = new GameObject();
		startTarget.transform.position = transform.position;
		if (_targets == null)
		{
			_targets = new List<Transform>();
		}
		_targets.Insert(0, startTarget.transform);
		index++;
		GolfBallController ctrl = FindObjectOfType<GolfBallController>();
		if (ctrl != null)
		{
			ctrl.OnShoot += OnShoot;
		}
		if (_targets.Count > 0 && _targets[0] != null)
		{
			transform.position = _targets[0].position;
		}
	}

	private void OnShoot(Vector3 obj)
	{
		if (!canMove || !_contantMove)
		{
			moving = true;
			OnMove?.Invoke();
		}
		if (_contantMove)
		{
			canMove = true;
			GolfBallController ctrl = FindObjectOfType<GolfBallController>();
			if (ctrl != null)
			{
				ctrl.OnShoot -= OnShoot;
			}
		}
	}

	private void OnDrawGizmos()
	{
		if (_targets == null) return;
		for (int i = 0; i < _targets.Count; i++)
		{
			if (_targets[i] == null) continue;
			Gizmos.DrawSphere(_targets[i].position, 1f);
			Vector3 p0 = _targets[i].position;
			Vector3 p1 = (i == _targets.Count - 1) ? transform.position : _targets[(i + 1) % _targets.Count].position;
			Gizmos.DrawLine(p0, p1);
		}
	}

	public void SetCanMove(bool b)
	{
		canMove = b;
	}

	private void FixedUpdate()
	{
		if (moving && animator != null)
		{
			animator.SetBool("Move", true);
		}
		else if (!moving && animator != null)
		{
			animator.SetBool("Move", false);
		}

		if (moving)
		{
			if (!canMove && accDeltaTime < 0.009999999776482582)
			{
				return;
			}
			accDeltaTime += Time.fixedDeltaTime * speed;
			if (_targets == null || _targets.Count == 0 || rb == null)
			{
				return;
			}
			Vector3 fromPos = _targets[from].position;
			Vector3 toPos = _targets[to].position;
			float tNorm = _moveTime > 0.0 ? (float)(accDeltaTime / _moveTime) : 1f;
			float xzEval = _speedgain != null ? Mathf.Clamp01(_speedgain.Evaluate(tNorm)) : Mathf.Clamp01(tNorm);
			float baseY = Mathf.Lerp(fromPos.y, toPos.y, tNorm);
			float yCurveEval = _yCurve != null ? _yCurve.Evaluate(tNorm) : 0f;
			Vector3 nextPos = new Vector3(
				Mathf.Lerp(fromPos.x, toPos.x, xzEval),
				baseY + yCurveEval * yHeight,
				Mathf.Lerp(fromPos.z, toPos.z, xzEval)
			);
			rb.MovePosition(nextPos);
			if (accDeltaTime > _moveTime)
			{
				moving = false;
				OnStop?.Invoke();
				accDeltaTime = 0.0;
				transform.position = _targets[to].position;
				index = (index + 1) % _targets.Count;
			}
		}
		else if (_contantMove && canMove)
		{
			accDeltaTime += Time.fixedDeltaTime;
			if (accDeltaTime > _waitBetweenMovesIfConstant)
			{
				moving = true;
				OnMove?.Invoke();
				accDeltaTime = 0.0;
			}
		}
	}
}
