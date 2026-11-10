using System.Collections;
using Core;
using UnityEngine;

public class RattleSnakeShooter : GolfBallShooterStandard
{
	[SerializeField]
	private int length = 5;

	[SerializeField]
	private bool _inPose;

	[SerializeField]
	private Vector3 _poseHeadOffset = Vector3.up;

	[SerializeField]
	private Vector3 _bodyPartOffset = Vector3.forward * 2f;

	[SerializeField]
	private Rigidbody _snakeBodyPrefab;

	[SerializeField]
	private Rigidbody _snakeBodyConePrefab;

	[SerializeField]
	private AudioSource _hissAudio;

	[SerializeField]
	private AudioSource _shootAudio;

	private Coroutine _poseTween;

	private float lastShootTime;

	protected override void Awake()
	{
		base.Awake();
		Rigidbody prevBody = Rigidbody;
		for (int i = 1; i <= length; i++)
		{
			if (_snakeBodyPrefab == null)
				break;
			Rigidbody part = Instantiate(_snakeBodyPrefab, transform.parent);
			if (part != null)
			{
				part.transform.SetSiblingIndex(i);
				part.transform.position = transform.position + _bodyPartOffset * i;
				Joint joint = part.GetComponent<Joint>();
				if (joint != null)
					joint.connectedBody = prevBody;
				part.maxDepenetrationVelocity = 1f;
				prevBody = part;
			}
		}
		ResetSnake();
	}

	private void EatCone()
	{
		if (Rigidbody != null)
			Rigidbody.isKinematic = true;
		if (transform.parent == null)
			return;
		Rigidbody[] bodies = transform.parent.GetComponentsInChildren<Rigidbody>();
		if (bodies == null || bodies.Length < 2 || _snakeBodyConePrefab == null)
			return;
		Rigidbody firstBody = bodies[1];
		Rigidbody conePart = Instantiate(_snakeBodyConePrefab, transform.parent);
		if (conePart != null)
		{
			conePart.maxDepenetrationVelocity = 1f;
			conePart.transform.SetSiblingIndex(1);
			if (firstBody != null)
				conePart.MovePosition(firstBody.position);
			Joint coneJoint = conePart.GetComponent<Joint>();
			if (coneJoint != null)
			{
				coneJoint.connectedBody = Rigidbody;
				coneJoint.connectedAnchor = _bodyPartOffset;
			}
			if (firstBody != null)
			{
				Joint firstJoint = firstBody.GetComponent<Joint>();
				if (firstJoint != null)
					firstJoint.connectedBody = conePart;
			}
			length++;
			StartCoroutine(MakeDynamic(0.1f));
		}
	}

	private IEnumerator MakeDynamic(float delay)
	{
		yield return new WaitForSeconds(delay);
		if (!_inPose && Rigidbody != null)
		{
			Rigidbody.isKinematic = false;
		}
	}

	private void OnCollisionEnter(Collision collision)
	{
		if (collision == null || collision.gameObject == null)
			return;
		if (collision.gameObject.name.StartsWith("TrafficCone") && !_inPose)
		{
			Destroy(collision.gameObject);
			EatCone();
		}
	}

	private void ToStandingPose()
	{
		if (_inPose || Rigidbody == null)
			return;
		_inPose = true;
		Vector3 startPos = Rigidbody.transform.position;
		Vector3 endPos = startPos + _poseHeadOffset * (length - 2);
		Rigidbody.isKinematic = true;
		if (_hissAudio != null)
			_hissAudio.Play();
		Quaternion startRot = Rigidbody.transform.rotation;
		Quaternion endRot = Quaternion.LookRotation(Vector3.forward, Vector3.up);
		_poseTween = StartCoroutine(pTween.To(0.5f, t =>
		{
			if (Rigidbody != null)
			{
				Rigidbody.MovePosition(Vector3.Lerp(startPos, endPos, Mathf.Clamp01(t)));
				Rigidbody.MoveRotation(Quaternion.Lerp(startRot, endRot, t));
			}
		}));
	}

	public override void OnAimUpdate(Vector3 boost, bool onlyAimArrow)
	{
		base.OnAimUpdate(boost, onlyAimArrow);
		if (_inPose && Rigidbody != null && boost != Vector3.zero)
		{
			Rigidbody.MoveRotation(Quaternion.LookRotation(boost.normalized, Vector3.up));
		}
	}

	private void BreakStandingPose()
	{
		if (!_inPose)
			return;
		_inPose = false;
		if (transform.parent == null)
			return;
		Rigidbody[] bodies = transform.parent.GetComponentsInChildren<Rigidbody>();
		if (bodies != null)
		{
			for (int i = 0; i < bodies.Length; i++)
			{
				if (bodies[i] != null)
					bodies[i].isKinematic = false;
			}
		}
	}

	private void Update()
	{
		if (!IsBlocking() && !_inPose)
		{
			ToStandingPose();
		}
	}

	protected override bool IsBlocking()
	{
		if (Rigidbody == null)
			return false;
		return Rigidbody.velocity.sqrMagnitude > MinRestVelocity || (Time.time - lastShootTime) < 0.5f;
	}

	private void ResetSnake()
	{
		if (transform.parent == null)
			return;
		Rigidbody[] bodies = transform.parent.GetComponentsInChildren<Rigidbody>();
		if (bodies == null)
			return;
		for (int i = 0; i < bodies.Length; i++)
		{
			Rigidbody b = bodies[i];
			if (b != null)
			{
				b.velocity = Vector3.zero;
				b.angularVelocity = Vector3.zero;
				b.transform.position = transform.position + _bodyPartOffset * i;
				b.transform.rotation = Quaternion.identity;
			}
		}
		for (int i = 0; i < bodies.Length; i++)
		{
			if (bodies[i] == null)
				continue;
			Joint j = bodies[i].GetComponent<Joint>();
			if (j != null)
			{
				Rigidbody conn = j.connectedBody;
				j.autoConfigureConnectedAnchor = false;
				j.connectedBody = null;
				j.connectedBody = conn;
				j.connectedAnchor = _bodyPartOffset;
			}
		}
	}

	public override void OnReset()
	{
		base.OnReset();
		ResetSnake();
	}

	public override void OnShoot(Vector3 boost)
	{
		if (_inPose)
		{
			if (_poseTween != null)
				StopCoroutine(_poseTween);
			if (_shootAudio != null)
				_shootAudio.Play();
			BreakStandingPose();
			lastShootTime = Time.time;
		}
		base.OnShoot(boost);
	}
}
