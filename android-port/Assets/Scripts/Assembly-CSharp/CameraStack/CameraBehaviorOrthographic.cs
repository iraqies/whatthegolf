using UnityEngine;

namespace CameraStack
{
	public abstract class CameraBehaviorOrthographic : CameraBehavior
	{
		[SerializeField]
		protected float orthographicSize = 5f;

		public override void Init()
		{
			if (Cameras != null)
			{
				for (int i = 0; i < Cameras.Length; i++)
				{
					var c = Cameras[i];
					if (c != null)
					{
						c.orthographic = true;
						float extra = c.aspect < 0.5f ? 3f : 0f;
						c.orthographicSize = orthographicSize + extra;
					}
				}
			}
			if (VirtualCameras != null)
			{
				for (int i = 0; i < VirtualCameras.Length; i++)
				{
					var vc = VirtualCameras[i];
					if (vc != null)
						vc.m_Lens.OrthographicSize = orthographicSize;
				}
			}
		}
	}
}
