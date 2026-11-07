using UnityEngine;

namespace CameraStack
{
	public abstract class CameraBehaviorPerspective : CameraBehavior
	{
		[SerializeField]
		private float fieldOfView;

		public virtual float FOV => 0f;

		public override void Init()
		{
		}

		public override void PreUpdate()
		{
		}
	}
}
