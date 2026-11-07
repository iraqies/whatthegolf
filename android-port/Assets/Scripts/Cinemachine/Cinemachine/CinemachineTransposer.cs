using UnityEngine;

namespace Cinemachine
{
	public class CinemachineTransposer : CinemachineComponentBase
	{
		public enum BindingMode
		{
			LockToTargetOnAssign = 0,
			LockToTargetWithWorldUp = 1,
			LockToTargetNoRoll = 2,
			LockToTarget = 3,
			WorldSpace = 4,
			SimpleFollowWithWorldUp = 5
		}

		public enum AngularDampingMode
		{
			Euler = 0,
			Quaternion = 1
		}

		public BindingMode m_BindingMode;

		public Vector3 m_FollowOffset;

		public float m_XDamping;

		public float m_YDamping;

		public float m_ZDamping;

		public AngularDampingMode m_AngularDampingMode;

		public float m_PitchDamping;

		public float m_YawDamping;

		public float m_RollDamping;

		public float m_AngularDamping;

		private Vector3 m_PreviousTargetPosition;

		private Quaternion m_PreviousReferenceOrientation;

		private Quaternion m_targetOrientationOnAssign;

		private Transform m_previousTarget;

		public bool HideOffsetInInspector { get; set; }

		public Vector3 EffectiveOffset => default;

		public override bool IsValid => false;

		public override CinemachineCore.Stage Stage => CinemachineCore.Stage.Body;

		protected Vector3 Damping => default;

		protected Vector3 AngularDamping => default;

		protected virtual void OnValidate()
		{
		}

		public override void MutateCameraState(ref CameraState curState, float deltaTime)
		{
		}

		public override void OnTargetObjectWarped(Transform target, Vector3 positionDelta)
		{
		}

		protected void InitPrevFrameStateInfo(ref CameraState curState, float deltaTime)
		{
		}

		protected void TrackTarget(float deltaTime, Vector3 up, Vector3 desiredCameraOffset, out Vector3 outTargetPosition, out Quaternion outTargetOrient)
		{
			outTargetPosition = default;
			outTargetOrient = default;
		}

		public virtual Vector3 GetTargetCameraPosition(Vector3 worldUp)
		{
			return default;
		}

		public Quaternion GetReferenceOrientation(Vector3 worldUp)
		{
			return default;
		}
	}
}
