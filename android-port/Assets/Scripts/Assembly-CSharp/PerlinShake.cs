using System.Collections;
using UnityEngine;

public class PerlinShake : MonoBehaviour
{
	public float duration = 2f;

	public float speed = 20f;

	public float magnitude = 2f;

	public AnimationCurve damper = new AnimationCurve(
		new Keyframe(0f, 1f),
		new Keyframe(0.9f, 0.33f, -2f, -2f),
		new Keyframe(1f, 0f, -5.65f, -5.65f)
	);

	public bool testPosition;

	public bool testRotation;

	public bool testProjection;

	private Vector3 originalPos;

	private Quaternion originalRot;

	private void OnEnable()
	{
		UpdateOriginalInfo();
	}

	private void UpdateOriginalInfo()
	{
		originalPos = base.transform.localPosition;
		originalRot = base.transform.localRotation;
	}

	public void Shake()
	{
		UpdateOriginalInfo();
		testPosition = true;
	}

	public void StopShake()
	{
		duration = 0f;
		speed = 0f;
		magnitude = 0f;
		StopAllCoroutines();
		base.transform.localPosition = originalPos;
		base.transform.localRotation = originalRot;
	}

	public void Shake(float duration, float speed, float magnitude)
	{
		float mult = Settings.ScreenshakeValue;
		this.duration = duration * mult;
		this.speed = speed * mult;
		this.magnitude = magnitude * mult;
		UpdateOriginalInfo();
		testPosition = true;
	}

	private void Update()
	{
		if (testPosition)
		{
			UpdateOriginalInfo();
			testPosition = false;
			StopAllCoroutines();
			StartCoroutine(ShakePosition(base.transform, originalPos, duration, speed, magnitude, damper));
		}
		else if (testRotation)
		{
			UpdateOriginalInfo();
			testRotation = false;
			StopAllCoroutines();
			StartCoroutine(ShakeRotation(base.transform, originalRot, duration, speed, magnitude, damper));
		}
		else if (testProjection)
		{
			UpdateOriginalInfo();
			testProjection = false;
			StopAllCoroutines();
			StartCoroutine(ShakeCameraProjection(Camera.main, duration, speed, magnitude, damper));
		}
	}

	private IEnumerator ShakePosition(Transform transform, Vector3 originalPosition, float duration, float speed, float magnitude, AnimationCurve damper = null)
	{
		float elapsed = 0f;
		while (elapsed < duration)
		{
			elapsed += Time.deltaTime;
			float mag = (damper != null) ? (damper.Evaluate(elapsed / duration) * magnitude) : magnitude;
			float x = Mathf.PerlinNoise(Time.time * speed, 0f) * mag - mag * 0.5f;
			float y = Mathf.PerlinNoise(0f, Time.time * speed) * mag - mag * 0.5f;
			if (transform != null)
			{
				transform.localPosition = new Vector3(originalPosition.x + x, originalPosition.y + y, originalPosition.z);
			}
			yield return null;
		}
		if (transform != null)
		{
			transform.localPosition = originalPosition;
		}
		StopShake();
	}

	private IEnumerator ShakeRotation(Transform transform, Quaternion originalRotation, float duration, float speed, float magnitude, AnimationCurve damper = null)
	{
		Vector3 originalEuler = originalRotation.eulerAngles;
		float elapsed = 0f;
		while (elapsed < duration)
		{
			elapsed += Time.deltaTime;
			float mag = (damper != null) ? (damper.Evaluate(elapsed / duration) * magnitude) : magnitude;
			float x = Mathf.PerlinNoise(Time.time * speed, 0f) * mag - mag * 0.5f;
			float y = Mathf.PerlinNoise(0f, Time.time * speed) * mag - mag * 0.5f;
			float z = Mathf.PerlinNoise(0.5f, Time.time * speed * 0.5f) * mag - mag * 0.5f;
			if (transform != null)
			{
				transform.localRotation = Quaternion.Euler(originalEuler.x + x, originalEuler.y + y, originalEuler.z + z);
			}
			yield return null;
		}
		if (transform != null)
		{
			transform.localRotation = originalRotation;
		}
		StopShake();
	}

	private IEnumerator ShakeCameraProjection(Camera camera, float duration, float speed, float magnitude, AnimationCurve damper = null)
	{
		float elapsed = 0f;
		while (elapsed < duration)
		{
			elapsed += Time.deltaTime;
			float mag = (damper != null) ? (damper.Evaluate(elapsed / duration) * magnitude) : magnitude;
			float x = Mathf.PerlinNoise(Time.time * speed, 0f) * mag - mag * 0.5f;
			float y = Mathf.PerlinNoise(0f, Time.time * speed) * mag - mag * 0.5f;
			if (camera != null)
			{
				float near = camera.nearClipPlane;
				float tanHalfFov = Mathf.Tan(camera.fieldOfView * 0.5f * ((float)System.Math.PI / 180f));
				float aspect = camera.aspect;
				float height = 2f * near * tanHalfFov;
				float width = height * aspect;
				Matrix4x4 proj = camera.projectionMatrix;
				proj[0, 2] = (x + x) / width;
				proj[1, 2] = (y + y) / height;
				camera.projectionMatrix = proj;
			}
			yield return null;
		}
		if (camera != null)
		{
			camera.ResetProjectionMatrix();
		}
	}
}
