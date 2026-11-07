using UnityEngine;

namespace CameraStack
{
	public class SecondDisplayCameraManager : MonoBehaviour
	{
		private Camera secondScreenCamera;

		public Camera ActualCamera => null;

		public void Configure(Camera camera, int screenIndex)
		{
		}

		private void OnDisplaysUpdated()
		{
		}

		private void OnDisable()
		{
		}
	}
}
