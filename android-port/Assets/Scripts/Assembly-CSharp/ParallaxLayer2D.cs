using CameraStack;
using UnityEngine;

public class ParallaxLayer2D : MonoBehaviour
{
	public Camera Camera;

	[SerializeField]
	private float parallaxCoefficient = 0.5f;

	private Vector3 lastCameraPos;

	private void LateUpdate()
	{
		if (Camera == null && CameraManager.Instance != null)
			Camera = CameraManager.Instance.MainCamera;
		if (Camera == null)
			return;
		if (lastCameraPos == Vector3.zero)
			lastCameraPos = Camera.transform.position;
		Vector3 camPos = Camera.transform.position;
		Vector3 delta = (camPos - lastCameraPos) * parallaxCoefficient;
		transform.position += new Vector3(delta.x, delta.y, 0f);
		lastCameraPos = camPos;
	}
}
