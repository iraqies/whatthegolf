using System.Collections;
using UnityEngine;
using UnityEngine.Events;

public class LerpRotationChooseObject : MonoBehaviour
{
	public GameObject objectToRotate;

	public Vector3 targetRotation;

	public float movementSpeed;

	public AnimationCurve animationCurve;

	public UnityEvent OnRotated;

	private float movementDuration;

	public void Rotate()
	{
	}

	private IEnumerator StartRotating(Quaternion endValue, float duration)
	{
		return null;
	}
}
