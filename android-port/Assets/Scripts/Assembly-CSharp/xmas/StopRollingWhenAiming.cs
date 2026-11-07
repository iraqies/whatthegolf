using UnityEngine;

namespace xmas
{
	public class StopRollingWhenAiming : MonoBehaviour
	{
		public float brake;

		private Rigidbody rigid;

		private void Start()
		{
		}

		private void Controller_OnAimUpdate(Vector3 boost, bool IsNotOrange)
		{
		}
	}
}
