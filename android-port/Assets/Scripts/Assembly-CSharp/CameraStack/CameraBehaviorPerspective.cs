using UnityEngine;

namespace CameraStack
{
	public abstract class CameraBehaviorPerspective : CameraBehavior
	{
		[SerializeField] private float fieldOfView = 60f;
		public virtual float FOV => fieldOfView > 0f ? fieldOfView : 60f;

		public override void Init()
		{
			if (Cameras != null)
			{
				foreach (var c in Cameras)
				{
					if (c != null && !c.orthographic && fieldOfView > 0f)
						c.fieldOfView = fieldOfView;
				}
			}
		}

		public override void PreUpdate()
		{
			if (Cameras != null)
			{
				float fov = FOV;
				foreach (var c in Cameras)
				{
					if (c != null)
						c.fieldOfView = fov;
				}
			}
		}
	}
}
