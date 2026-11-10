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
		if (invertedCycle)
		{
			cycles++;
		}
		startPosition = base.transform.position;
		rb = GetComponent<Rigidbody>();
		StartCoroutine(MoveProp());
	}

	private IEnumerator MoveProp()
	{
		yield return new WaitForSeconds(offset);
		while (true)
		{
			float elapsed = 0f;
			while (elapsed < 1f)
			{
				float t = ((animationCurve != null) ? Mathf.Clamp01(animationCurve.Evaluate(elapsed)) : Mathf.Clamp01(elapsed));
				Vector3 targetPos = ((cycles % 2 == 1) ? Vector3.Lerp(startPosition, startPosition + endPosition, t) : Vector3.Lerp(startPosition + endPosition, startPosition, t));
				if (useRigidbody && rb != null)
				{
					rb.MovePosition(targetPos);
				}
				else
				{
					base.transform.position = targetPos;
				}
				elapsed += Time.fixedDeltaTime * movementSpeed;
				yield return new WaitForFixedUpdate();
			}
			yield return new WaitForSeconds(pauseTime);
			cycles++;
		}
	}

	public void SetSpeed(float speed)
	{
		movementSpeed = speed;
	}

	public UpDownMovementProp()
	{
		movementSpeed = 2f;
		useRigidbody = true;
	}
}
