using UnityEngine;

namespace CameraStack
{
	public abstract class CameraBehaviorOrthographic : CameraBehavior
	{
		[SerializeField]
		protected float orthographicSize;

		public override void Init()
		{
		}
	}
}
