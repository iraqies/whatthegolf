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
	private float _speed;

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
	private bool _moveOnShoot;

	[SerializeField]
	private bool _constantMove;

	private GolfBallController _controller;

	private static readonly int GetUp;

	private bool hasMoved;

	private void MoveUpdate()
	{
	}

	public void Move()
	{
	}

	public void StartMove()
	{
	}

	private IEnumerator StartMoveCR()
	{
		return null;
	}

	private void Start()
	{
	}

	private void OnDrawGizmos()
	{
	}

	private void ControllerOnOnShoot(Vector3 obj)
	{
	}

	private void FixedUpdate()
	{
	}
}
