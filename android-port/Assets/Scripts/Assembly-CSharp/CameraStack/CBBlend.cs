using UnityEngine;

namespace CameraStack
{
	public class CBBlend : CameraBehaviorPerspective
	{
		public CameraBehaviorPerspective cameraA;

		public CameraBehaviorPerspective cameraB;

		public float AtoBBlend;

		private float width;

		private float height;

		public override float FOV => 0f;

		public override void Init()
		{
		}

		public void UpdateCameras()
		{
		}

		public override void OutOfBounds()
		{
		}

		public override Quaternion CalculateRotation()
		{
			return default;
		}

		private void UpdateWidthAndHeight()
		{
		}

		protected override Vector3 CalculatePosition()
		{
			return default;
		}
	}
}
