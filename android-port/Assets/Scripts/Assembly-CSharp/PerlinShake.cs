using System.Collections;
using UnityEngine;

public class PerlinShake : MonoBehaviour
{
	public float duration;

	public float speed;

	public float magnitude;

	public AnimationCurve damper;

	public bool testPosition;

	public bool testRotation;

	public bool testProjection;

	private Vector3 originalPos;

	private Quaternion originalRot;

	private void OnEnable()
	{
	}

	private void UpdateOriginalInfo()
	{
	}

	public void Shake()
	{
	}

	public void StopShake()
	{
	}

	public void Shake(float duration, float speed, float magnitude)
	{
	}

	private void Update()
	{
	}

	private IEnumerator ShakePosition(Transform transform, Vector3 originalPosition, float duration, float speed, float magnitude, AnimationCurve damper = null)
	{
		return null;
	}

	private IEnumerator ShakeRotation(Transform transform, Quaternion originalRotation, float duration, float speed, float magnitude, AnimationCurve damper = null)
	{
		return null;
	}

	private IEnumerator ShakeCameraProjection(Camera camera, float duration, float speed, float magnitude, AnimationCurve damper = null)
	{
		return null;
	}
}
