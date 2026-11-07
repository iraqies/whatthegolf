using System;
using UnityEngine;

namespace RootMotion.Demos
{
	public class SimpleLocomotion : MonoBehaviour
	{
		[Serializable]
		public enum RotationMode
		{
			Smooth = 0,
			Linear = 1
		}

		public CameraController cameraController;

		public float accelerationTime;

		public float turnTime;

		public bool walkByDefault;

		public RotationMode rotationMode;

		public float moveSpeed;

		private Animator animator;

		private float speed;

		private float angleVel;

		private float speedVel;

		private Vector3 linearTargetDirection;

		private CharacterController characterController;

		public bool isGrounded { get; private set; }

		private void Start()
		{
		}

		private void Update()
		{
		}

		private void LateUpdate()
		{
		}

		private void Rotate()
		{
		}

		private void Move()
		{
		}

		private Vector3 GetInputVector()
		{
			return default;
		}

		private Vector3 GetInputVectorRaw()
		{
			return default;
		}
	}
}
