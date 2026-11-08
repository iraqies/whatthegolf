using UnityEngine;

namespace CameraStack
{
	public class CBOrbit : CameraBehaviorPerspective
	{
		[SerializeField] private Vector3 target;
		[SerializeField] private float distance = 15f;
		[SerializeField] private float speed = 15f;
		private float angle;

		private void Awake() { }

		public override Quaternion CalculateRotation()
		{
			angle += speed * Time.deltaTime;
			return Quaternion.Euler(30f, angle, 0f);
		}

		protected override Vector3 CalculatePosition()
		{
			Quaternion rot = CalculateRotation();
			float dist = Mathf.Abs(distance) > 0.1f ? Mathf.Abs(distance) : 15f;
			return target - (rot * Vector3.forward) * dist;
		}
	}
}
