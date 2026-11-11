using UnityEngine;

namespace CameraStack
{
	public abstract class CameraBehaviorPerspective : CameraBehavior
	{
		[SerializeField] private float fieldOfView = 35f;
		public virtual float FOV => fieldOfView > 0f ? fieldOfView : 35f;

		public override void Init()
		{
			if (Cameras != null)
			{
				for (int i = 0; i < Cameras.Length; i++)
				{
					if (Cameras[i] != null)
					{
						Cameras[i].orthographic = false;
						if (fieldOfView > 0f)
							Cameras[i].fieldOfView = fieldOfView;
					}
				}
			}
		}

		public override void PreUpdate()
		{
			if (Cameras != null)
			{
				float fov = FOV;
				for (int i = 0; i < Cameras.Length; i++)
				{
					if (Cameras[i] != null)
						Cameras[i].fieldOfView = fov;
				}
			}
		}
	}
}
