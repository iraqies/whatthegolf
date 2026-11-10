using System;
using System.Collections;
using System.Collections.Generic;
using Core;
using UnityEngine;

public class MoveRocksTurnBased : MonoBehaviour
{
	public Action _onMove;

	public Action _onStop;

	[SerializeField]
	private Rigidbody _rbToMoveM;

	[SerializeField]
	private List<Transform> _position;

	[SerializeField]
	private float _speed = 5f;

	private int index;

	[SerializeField]
	private PlayAudioClipSetting _onGetUp;

	[SerializeField]
	private PlayAudioClipSetting _onGetPutDown;

	[SerializeField]
	private Animator _animator;

	private bool _moving;

	private bool _startMoving;

	private double _time;

	[SerializeField]
	private bool _moveOnShoot = true;

	[SerializeField]
	private bool _constantMove;

	private GolfBallController _controller;

	private static readonly int GetUp = Animator.StringToHash("GetUp");

	private bool hasMoved;

	private void MoveUpdate()
	{
		if (!_moving || _position == null || _position.Count == 0)
		{
			return;
		}
		Transform targetTrans = _position[index % _position.Count];
		if (targetTrans == null)
		{
			_moving = false;
			return;
		}
		Vector3 curPos = _rbToMoveM != null ? _rbToMoveM.position : transform.position;
		Vector3 nextPos = Vector3.MoveTowards(curPos, targetTrans.position, Mathf.Max(1f, _speed) * Time.fixedDeltaTime);
		if (_rbToMoveM != null)
		{
			_rbToMoveM.MovePosition(nextPos);
		}
		else
		{
			transform.position = nextPos;
		}
		if (Vector3.Distance(nextPos, targetTrans.position) < 0.05f)
		{
			_moving = false;
			if (_animator != null)
			{
				_animator.SetBool(GetUp, false);
			}
			if (_onGetPutDown != null)
			{
				_onGetPutDown.Play();
			}
			_onStop?.Invoke();
			if (_constantMove)
			{
				StartMove();
			}
		}
	}

	public void Move()
	{
		StartMove();
	}

	public void StartMove()
	{
		if (!_moving && !_startMoving && _position != null && _position.Count > 0)
		{
			StartCoroutine(StartMoveCR());
		}
	}

	private IEnumerator StartMoveCR()
	{
		_startMoving = true;
		index = (index + 1) % _position.Count;
		if (_animator != null)
		{
			_animator.SetBool(GetUp, true);
		}
		if (_onGetUp != null)
		{
			_onGetUp.Play();
		}
		yield return new WaitForSeconds(0.25f);
		_startMoving = false;
		_moving = true;
		hasMoved = true;
		_onMove?.Invoke();
	}

	private void Start()
	{
		if (_rbToMoveM == null)
		{
			_rbToMoveM = GetComponent<Rigidbody>();
		}
		_controller = UnityEngine.Object.FindObjectOfType<GolfBallController>();
		if (_moveOnShoot && _controller != null)
		{
			_controller.OnShoot += ControllerOnOnShoot;
		}
		if (_constantMove)
		{
			StartMove();
		}
	}

	private void OnDrawGizmos()
	{
	}

	private void ControllerOnOnShoot(Vector3 obj)
	{
		StartMove();
	}

	private void FixedUpdate()
	{
		MoveUpdate();
	}
}
