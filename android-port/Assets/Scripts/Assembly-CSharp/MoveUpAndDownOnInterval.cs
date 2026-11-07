using System.Collections;
using UnityEngine;

public class MoveUpAndDownOnInterval : MonoBehaviour
{
	[SerializeField]
	private Transform _target;

	private Vector3 _orgPos;

	[SerializeField]
	private float _waitUp;

	[SerializeField]
	private float _offset;

	[SerializeField]
	private Rigidbody _rb;

	[SerializeField]
	private float _waitDown;

	[SerializeField]
	private float _durationUp;

	[SerializeField]
	private AnimationCurve _curve;

	private IEnumerator Start()
	{
		return null;
	}

	private void OnDrawGizmos()
	{
	}

	private IEnumerator LoopCR()
	{
		return null;
	}
}
