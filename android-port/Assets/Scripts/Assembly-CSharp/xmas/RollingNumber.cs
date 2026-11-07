using UnityEngine;

namespace xmas
{
	public class RollingNumber : MonoBehaviour
	{
		public float speed;

		public float MoveSpeed;

		public float LookInAimDirectionSpeed;

		public float CorrectSideFallSpeed;

		public Transform number;

		private Rigidbody rigid;

		private void Start()
		{
		}

		private void Controller_OnAimUpdate(Vector3 boost, bool IsNotOrange)
		{
		}
	}
}
