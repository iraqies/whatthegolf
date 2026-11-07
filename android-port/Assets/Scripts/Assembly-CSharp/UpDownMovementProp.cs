using System.Collections;
using UnityEngine;

public class UpDownMovementProp : MonoBehaviour
{
	[SerializeField]
	private Vector3 endPosition;

	[SerializeField]
	private float movementSpeed;

	[SerializeField]
	private float pauseTime;

	[SerializeField]
	private bool invertedCycle;

	[SerializeField]
	private AnimationCurve animationCurve;

	[SerializeField]
	private float offset;

	public bool useRigidbody;

	private int cycles;

	private Rigidbody rb;

	private Vector3 startPosition;

	private void OnEnable()
	{
	}

	private IEnumerator MoveProp()
	{
		return null;
	}

	public void SetSpeed(float speed)
	{
	}
}
