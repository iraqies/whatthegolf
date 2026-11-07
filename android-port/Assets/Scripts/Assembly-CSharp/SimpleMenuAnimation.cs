using UnityEngine;

public class SimpleMenuAnimation : MonoBehaviour
{
	private Vector3 _originalPosition;

	private Quaternion _originalRotation;

	[SerializeField]
	private AnimationCurve _posXCurve;

	[SerializeField]
	private AnimationCurve _posYCurve;

	[SerializeField]
	private AnimationCurve _rotZCurve;

	private void Start()
	{
	}

	private void Update()
	{
	}
}
