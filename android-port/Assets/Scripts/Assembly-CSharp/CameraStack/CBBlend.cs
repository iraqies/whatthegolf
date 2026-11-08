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

		public override float FOV
		{
			get
			{
				float a = cameraA != null ? cameraA.FOV : 60f;
				float b = cameraB != null ? cameraB.FOV : 60f;
				return Mathf.Lerp(a, b, Mathf.Clamp01(AtoBBlend));
			}
		}

		public override void Init()
		{
			cameraA?.Init();
			cameraB?.Init();
			base.Init();
		}

		public void UpdateCameras()
		{
			if (Cameras != null)
			{
				foreach (var c in Cameras)
				{
					if (c != null && !c.orthographic)
						c.fieldOfView = FOV;
				}
			}
		}

		public override void OutOfBounds()
		{
			cameraA?.OutOfBounds();
			cameraB?.OutOfBounds();
		}

		public override Quaternion CalculateRotation()
		{
			Quaternion qa = cameraA != null ? cameraA.CalculateRotation() : transform.rotation;
			Quaternion qb = cameraB != null ? cameraB.CalculateRotation() : qa;
			return Quaternion.Slerp(qa, qb, Mathf.Clamp01(AtoBBlend));
		}

		private void UpdateWidthAndHeight() { }

		protected override Vector3 CalculatePosition()
		{
			Vector3 pa = cameraA != null ? cameraA.Position : transform.position;
			Vector3 pb = cameraB != null ? cameraB.Position : pa;
			return Vector3.Lerp(pa, pb, Mathf.Clamp01(AtoBBlend));
		}
	}
}
