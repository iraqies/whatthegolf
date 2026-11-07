using UnityEngine;

namespace CameraStack
{
	public class CBStatic : CameraBehaviorPerspective
	{
		[SerializeField]
		private Transform trans;

		public override void Init()
		{
		}

		protected override Vector3 CalculatePosition()
		{
			return default;
		}

		public override Quaternion CalculateRotation()
		{
			return default;
		}
	}
}
