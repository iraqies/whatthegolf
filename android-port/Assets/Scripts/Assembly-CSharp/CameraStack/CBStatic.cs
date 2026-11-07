using UnityEngine;

namespace CameraStack
{
	public class CBStatic : CameraBehaviorPerspective
	{
		[SerializeField] private Transform trans;

		public override void Init()
		{
			base.Init();
			if (trans == null) trans = transform;
		}

		protected override Vector3 CalculatePosition() => (trans != null ? trans : transform).position;
		public override Quaternion CalculateRotation() => (trans != null ? trans : transform).rotation;
	}
}
