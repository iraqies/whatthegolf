using RootMotion.FinalIK;
using UnityEngine;

namespace RootMotion.Demos
{
	public class FPSAiming : MonoBehaviour
	{
		public float aimWeight;

		public float sightWeight;

		public float maxAngle;

		public Vector3 aimOffset;

		public bool animatePhysics;

		public Transform gun;

		public Transform gunTarget;

		public FullBodyBipedIK ik;

		public AimIK gunAim;

		public CameraControllerFPS cam;

		public Recoil recoil;

		public float cameraRecoilWeight;

		public Vector3 gunTargetDefaultLocalPosition;

		public Vector3 gunTargetDefaultLocalRotation;

		private Vector3 camDefaultLocalPosition;

		private Vector3 camRelativeToGunTarget;

		private bool updateFrame;

		private void Start()
		{
		}

		private void FixedUpdate()
		{
		}

		private void LateUpdate()
		{
		}

		private void Aiming()
		{
		}

		private void LookDownTheSight()
		{
		}

		private void RotateCharacter()
		{
		}
	}
}
