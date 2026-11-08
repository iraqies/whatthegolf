using UnityEngine;

namespace CameraStack
{
	public abstract class CameraBehaviorOrthographic : CameraBehavior
	{
		[SerializeField]
		protected float orthographicSize = 8f;

		public override void Init()
		{
			base.Init();
			if (Cameras != null)
			{
				foreach (var c in Cameras)
				{
					if (c != null)
					{
						c.orthographic = true;
						if (orthographicSize > 0.01f)
							c.orthographicSize = orthographicSize;
					}
				}
			}
		}
	}
}
