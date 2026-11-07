using System;
using Cinemachine.Utility;
using UnityEngine;

namespace Cinemachine
{
	public class CinemachineOrbitalTransposer : CinemachineTransposer
	{
		[Serializable]
		public struct Heading
		{
			public enum HeadingDefinition
			{
				PositionDelta = 0,
				Velocity = 1,
				TargetForward = 2,
				WorldForward = 3
			}

			public HeadingDefinition m_Definition;

			public int m_VelocityFilterStrength;

			public float m_Bias;

			public Heading(HeadingDefinition def, int filterStrength, float bias)
			{
				m_Definition = HeadingDefinition.PositionDelta;
				m_VelocityFilterStrength = 0;
				m_Bias = 0f;
			}
		}

		internal delegate float UpdateHeadingDelegate(CinemachineOrbitalTransposer orbital, float deltaTime, Vector3 up);

		public Heading m_Heading;

		public AxisState.Recentering m_RecenterToTargetHeading;

		public AxisState m_XAxis;

		[SerializeField]
		private float m_LegacyRadius;

		[SerializeField]
		private float m_LegacyHeightOffset;

		[SerializeField]
		private float m_LegacyHeadingBias;

		public bool m_HeadingIsSlave;

		internal UpdateHeadingDelegate HeadingUpdater;

		private Vector3 mLastTargetPosition;

		private HeadingTracker mHeadingTracker;

		private Rigidbody mTargetRigidBody;

		private Quaternion mHeadingPrevFrame;

		private Vector3 mOffsetPrevFrame;

		private Transform PreviousTarget { get; set; }

		private float LastHeading { get; set; }

		protected override void OnValidate()
		{
		}

		public float UpdateHeading(float deltaTime, Vector3 up, ref AxisState axis)
		{
			return 0f;
		}

		public float UpdateHeading(float deltaTime, Vector3 up, ref AxisState axis, ref AxisState.Recentering recentering, bool isLive)
		{
			return 0f;
		}

		private void OnEnable()
		{
		}

		public override void OnTargetObjectWarped(Transform target, Vector3 positionDelta)
		{
		}

		public override bool OnTransitionFromCamera(ICinemachineCamera fromCam, Vector3 worldUp, float deltaTime, ref CinemachineVirtualCameraBase.TransitionParams transitionParams)
		{
			return false;
		}

		public float GetAxisClosestValue(Vector3 cameraPos, Vector3 up)
		{
			return 0f;
		}

		public override void MutateCameraState(ref CameraState curState, float deltaTime)
		{
		}

		public override Vector3 GetTargetCameraPosition(Vector3 worldUp)
		{
			return default;
		}

		private static string GetFullName(GameObject current)
		{
			return null;
		}

		private float GetTargetHeading(float currentHeading, Quaternion targetOrientation)
		{
			return 0f;
		}
	}
}
