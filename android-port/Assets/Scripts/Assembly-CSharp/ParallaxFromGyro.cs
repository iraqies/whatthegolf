using UnityEngine;

public class ParallaxFromGyro : MonoBehaviour
{
	public Vector2 magnitude = new Vector2(0.5f, 0.5f);

	public bool useMax;

	public Vector2 maxMagnitude = new Vector2(1f, 1f);

	private Vector3 basePosition;

	private float tweenTime = 0.1f;

	private void OnApplicationPause(bool pause)
	{
	}

	private void Start()
	{
		basePosition = transform.localPosition;
	}

	private void Update()
	{
		if (!Settings.UseGyroShake || !SystemInfo.supportsGyroscope)
		{
			return;
		}
		Vector3 offset = GyroController.Instance != null ? GyroController.Instance.GetOffset() : Vector3.zero;
		Vector2 targetOffset = new Vector2(offset.x * magnitude.x, offset.y * magnitude.y);
		if (useMax)
		{
			targetOffset.x = Mathf.Clamp(targetOffset.x, -maxMagnitude.x, maxMagnitude.x);
			targetOffset.y = Mathf.Clamp(targetOffset.y, -maxMagnitude.y, maxMagnitude.y);
		}
		transform.localPosition = Vector3.Lerp(transform.localPosition, basePosition + new Vector3(targetOffset.x, targetOffset.y, 0f), Time.deltaTime * 10f);
	}
}
