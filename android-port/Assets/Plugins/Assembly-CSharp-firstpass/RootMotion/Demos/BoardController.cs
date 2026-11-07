using UnityEngine;

namespace RootMotion.Demos
{
	public class BoardController : MonoBehaviour
	{
		public int groundLayer;

		public Transform rotationTarget;

		public float torque;

		public float skidDrag;

		public float turnSensitivity;

		private Rigidbody r;

		private bool isGrounded;

		private void Awake()
		{
		}

		private void Update()
		{
		}

		private void FixedUpdate()
		{
		}

		private void OnCollisionEnter(Collision c)
		{
		}

		private void OnCollisionStay(Collision c)
		{
		}

		private void OnCollisionExit(Collision c)
		{
		}
	}
}
