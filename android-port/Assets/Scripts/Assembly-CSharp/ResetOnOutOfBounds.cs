using System.Collections;
using UnityEngine;
using UnityEngine.Events;

public class ResetOnOutOfBounds : MonoBehaviour
{
	public UnityEvent AdditionalCalls;

	public bool UsePlayerOutOfBounds;

	public float Delay;

	public bool FailLevel;

	public Vector3 RandomResetPositionOffsetMin;

	public Vector3 RandomResetPositionOffsetMax;

	public bool doPopInAnimation;

	public Ease.Easing ease;

	public float animationTime;

	private Vector3 startPos;

	private Quaternion startRot;

	private Rigidbody rigidbody;

	private bool resetting;

	private Vector3 baseScale;

	private void Start()
	{
	}

	private void OnReset()
	{
	}

	private IEnumerator PopInAnimation()
	{
		return null;
	}

	private void OnTriggerEnter(Collider other)
	{
	}
}
