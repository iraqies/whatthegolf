using CameraStack;
using UnityEngine;

namespace Core
{
	public class OffScreenOutOfBounds : MonoBehaviour
	{
		private void Update()
		{
			if (!Level.HasInstance) return;
			GolfBallController ball = Level.Instance.Ball;
			if (ball == null) return;
			if (CameraManager.Instance == null || CameraManager.Instance.Cameras == null || CameraManager.Instance.Cameras.Length == 0)
				return;
			Camera cam = CameraManager.Instance.Cameras[0];
			if (cam == null) return;
			Vector3 sp = cam.WorldToScreenPoint(ball.transform.position);
			if (sp.x < 0f || sp.x > Screen.width || sp.y < 0f || sp.y > Screen.height)
			{
				ball.OutOfBounds("OUT OF BOUNDS", 0f);
			}
		}
	}
}
