using UnityEngine;

namespace CameraStack
{
	public class SecondDisplayCameraInitializer : MonoBehaviour
	{
		[SerializeField]
		private Camera originalCamera;

		[SerializeField]
		private Transform secondCamParent;

		[SerializeField]
		private bool autoInitialize;

		private SecondDisplayCameraManager InitializeFromBehavior(Camera originalCamera, Transform secondCamParent, float forwardRotation)
		{
			return null;
		}

		public static SecondDisplayCameraManager Initialize(Camera originalCamera, Transform secondCamParent, Transform scriptRoot, float forwardRotation)
		{
			return null;
		}

		private static void CopyCameraValues(Camera from, Camera to)
		{
		}
	}
}
