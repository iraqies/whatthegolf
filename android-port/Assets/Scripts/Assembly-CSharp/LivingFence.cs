using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Core;
using Triband.Splines;
using UnityEngine;

public class LivingFence : MonoBehaviour
{
	private List<Rigidbody> _rbs;

	[SerializeField]
	private Spline _spline;

	[SerializeField]
	private float _speed;

	private float _mT;

	[SerializeField]
	private Vector3 _rotationOffSet;

	private double _time;

	private bool _moving;

	[SerializeField]
	private bool _canMove;

	[SerializeField]
	private int _numRotate = 5;

	[SerializeField]
	private float _waitDownTime = 0.1f;

	[SerializeField]
	private AnimationCurve _curve;

	[SerializeField]
	private AnimationCurve _up;

	[SerializeField]
	private float angleDiff;

	private float _splineLength;

	[SerializeField]
	private float _spacing;

	[SerializeField]
	private float _duration;

	[SerializeField]
	private List<GameObject> _faceThings;

	[SerializeField]
	private bool _looping;

	private float _dir = 1f;

	[SerializeField]
	private float _blockPlayerTime = 1f;

	[SerializeField]
	private float _lateness = 0.05f;

	private float spacing => _spacing / _splineLength;

	private float speed => _speed / _splineLength;

	public void Place()
	{
		_rbs = base.gameObject.GetComponentsInChildren<Rigidbody>().ToList();
		if (_spline == null || _rbs == null)
		{
			return;
		}
		_splineLength = _spline.GetLength();
		_mT = spacing * (float)_rbs.Count;
		for (int i = 0; i < _rbs.Count; i++)
		{
			float num = _mT - spacing * (float)i;
			if (num < 0f)
			{
				num += 1f;
			}
			SplinePoint splinePoint = _spline.Evaluate(num, true);
			if (_rbs[i] != null)
			{
				_rbs[i].transform.position = splinePoint.point;
				_rbs[i].transform.rotation = splinePoint.rotation * Quaternion.Euler(_rotationOffSet);
			}
		}
	}

	private void Start()
	{
		GolfBallController golfBallController = UnityEngine.Object.FindObjectOfType<GolfBallController>();
		if (golfBallController != null)
		{
			golfBallController.OnShoot += OnShoot;
		}
		_rbs = base.gameObject.GetComponentsInChildren<Rigidbody>().ToList();
		if (_spline == null || _rbs == null)
		{
			return;
		}
		_splineLength = _spline.GetLength();
		_mT = spacing * (float)_rbs.Count;
		foreach (Rigidbody rb in _rbs)
		{
			if (rb == null)
			{
				continue;
			}
			CollisionEvents component = rb.GetComponent<CollisionEvents>();
			if (component != null)
			{
				CollisionEvents collisionEvents = component;
				collisionEvents.OnTriggerEnterRigidbody = (Action<Rigidbody>)Delegate.Combine(collisionEvents.OnTriggerEnterRigidbody, (Action<Rigidbody>)delegate(Rigidbody rigidbody1)
				{
					if (!(rigidbody1 == null))
					{
						Hit(rigidbody1, _rbs.IndexOf(rb));
					}
				});
			}
		}
		for (int i = 0; i < _rbs.Count; i++)
		{
			float num = _mT - spacing * (float)i;
			if (num < 0f)
			{
				num += 1f;
			}
			SplinePoint splinePoint = _spline.Evaluate(num, true);
			if (_rbs[i] != null)
			{
				_rbs[i].position = splinePoint.point;
				_rbs[i].rotation = splinePoint.rotation * Quaternion.Euler(_rotationOffSet);
			}
		}
	}

	private void OnShoot(Vector3 obj)
	{
		_time = Time.time;
		_moving = true;
		if (_faceThings == null)
		{
			return;
		}
		foreach (GameObject faceThing in _faceThings)
		{
			if (faceThing != null)
			{
				faceThing.SetActive(true);
			}
		}
	}

	private void Hit(Rigidbody ball, int fencePiece)
	{
		if (ball == null || _rbs == null)
		{
			return;
		}
		GolfBallController component = ball.GetComponent<GolfBallController>();
		if (component != null)
		{
			component.TimedBlockShot(_blockPlayerTime);
		}
		int num = Math.Max(fencePiece - _numRotate, 0);
		for (int i = num; i < Math.Min(_numRotate + fencePiece, _rbs.Count); i++)
		{
			int num2 = Mathf.Abs(i - fencePiece);
			if (_rbs[i] != null)
			{
				StartCoroutine(Rotate(90f - angleDiff * (float)num2, _rbs[i].transform));
			}
		}
	}

	private IEnumerator Rotate(float angle, Transform parent)
	{
		if (parent == null || parent.childCount == 0)
		{
			yield break;
		}
		Transform child = parent.GetChild(0);
		Quaternion startRot = child.localRotation;
		Vector3 startPos = child.localPosition;
		Quaternion endRot = child.localRotation * Quaternion.Euler(0f, 0f, 0f - angle);
		yield return StartCoroutine(pTween.To(_duration, 0f, 1f, delegate(float t)
		{
			if (child != null && _curve != null)
			{
				child.localRotation = Quaternion.LerpUnclamped(startRot, endRot, _curve.Evaluate(t));
			}
		}));
		yield return new WaitForSeconds(_waitDownTime);
		yield return StartCoroutine(pTween.To(_duration, 1f, 0f, delegate(float t)
		{
			if (child != null && _up != null)
			{
				child.localRotation = Quaternion.LerpUnclamped(startRot, endRot, _up.Evaluate(t));
			}
		}));
		if (child != null)
		{
			child.localRotation = startRot;
			child.localPosition = startPos;
		}
	}

	private void FixedUpdate()
	{
		if (!_canMove || _rbs == null || _spline == null)
		{
			return;
		}
		for (int i = 0; i < _rbs.Count; i++)
		{
			float num = _mT - spacing * (float)i;
			if (num < 0f)
			{
				num += 1f;
			}
			SplinePoint splinePoint = _spline.Evaluate(num, true);
			if (_rbs[i] != null)
			{
				_rbs[i].position = splinePoint.point;
				_rbs[i].rotation = splinePoint.rotation * Quaternion.Euler(_rotationOffSet);
			}
		}
		if (_moving)
		{
			_mT += speed * Time.fixedDeltaTime * _dir;
		}
		if (_looping)
		{
			if (_mT > 1f)
			{
				_mT = 0f;
			}
			return;
		}
		if (_mT > 1f)
		{
			_dir = -1f;
		}
		if (_mT < spacing * (float)_rbs.Count)
		{
			_dir = 1f;
		}
	}
}
