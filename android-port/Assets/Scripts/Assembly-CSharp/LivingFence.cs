using System.Collections;
using System.Collections.Generic;
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
	private int _numRotate;

	[SerializeField]
	private float _waitDownTime;

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

	private float _dir;

	[SerializeField]
	private float _blockPlayerTime;

	[SerializeField]
	private float _lateness;

	private float spacing => 0f;

	private float speed => 0f;

	public void Place()
	{
	}

	private void Start()
	{
	}

	private void OnShoot(Vector3 obj)
	{
	}

	private void Hit(Rigidbody ball, int fencePiece)
	{
	}

	private IEnumerator Rotate(float angle, Transform parent)
	{
		return null;
	}

	private void FixedUpdate()
	{
	}
}
