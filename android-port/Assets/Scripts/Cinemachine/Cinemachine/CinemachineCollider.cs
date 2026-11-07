using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace Cinemachine
{
	[Token(Token = "0x2000015")]
	[ExecuteAlways]
	public class CinemachineCollider : CinemachineExtension
	{
		[Token(Token = "0x2000016")]
		public enum ResolutionStrategy
		{
			[Token(Token = "0x4000070")]
			PullCameraForward = 0,
			[Token(Token = "0x4000071")]
			PreserveCameraHeight = 1,
			[Token(Token = "0x4000072")]
			PreserveCameraDistance = 2
		}

		[Token(Token = "0x2000017")]
		private class VcamExtraState
		{
			[Token(Token = "0x4000073")]
			[FieldOffset(Offset = "0x10")]
			public Vector3 m_previousDisplacement;

			[Token(Token = "0x4000074")]
			[FieldOffset(Offset = "0x1C")]
			public Vector3 m_previousDisplacementCorrection;

			[Token(Token = "0x4000075")]
			[FieldOffset(Offset = "0x28")]
			public float colliderDisplacement;

			[Token(Token = "0x4000076")]
			[FieldOffset(Offset = "0x2C")]
			public bool targetObscured;

			[Token(Token = "0x4000077")]
			[FieldOffset(Offset = "0x30")]
			public float occlusionStartTime;

			[Token(Token = "0x4000078")]
			[FieldOffset(Offset = "0x38")]
			public List<Vector3> debugResolutionPath;

			[Token(Token = "0x4000079")]
			[FieldOffset(Offset = "0x40")]
			private float m_SmoothedDistance;

			[Token(Token = "0x400007A")]
			[FieldOffset(Offset = "0x44")]
			private float m_SmoothedTime;

			[Token(Token = "0x6000084")]
			[Address(RVA = "0x190EBB4", Offset = "0x190EBB4", VA = "0x190EBB4")]
			public void AddPointToDebugPath(Vector3 p)
			{
			}

			[Token(Token = "0x6000085")]
			[Address(RVA = "0x190EBB8", Offset = "0x190EBB8", VA = "0x190EBB8")]
			public float ApplyDistanceSmoothing(float distance, float smoothingTime)
			{
				return default;
			}

			[Token(Token = "0x6000086")]
			[Address(RVA = "0x190EC3C", Offset = "0x190EC3C", VA = "0x190EC3C")]
			public void UpdateDistanceSmoothing(float distance, float smoothingTime)
			{
			}

			[Token(Token = "0x6000087")]
			[Address(RVA = "0x190EC80", Offset = "0x190EC80", VA = "0x190EC80")]
			public void ResetDistanceSmoothing(float smoothingTime)
			{
			}

			[Token(Token = "0x6000088")]
			[Address(RVA = "0x190ECC4", Offset = "0x190ECC4", VA = "0x190ECC4")]
			public VcamExtraState()
			{
			}
		}

		[Token(Token = "0x400005B")]
		[FieldOffset(Offset = "0x28")]
		public LayerMask m_CollideAgainst;

		[Token(Token = "0x400005C")]
		[FieldOffset(Offset = "0x30")]
		public string m_IgnoreTag;

		[Token(Token = "0x400005D")]
		[FieldOffset(Offset = "0x38")]
		public LayerMask m_TransparentLayers;

		[Token(Token = "0x400005E")]
		[FieldOffset(Offset = "0x3C")]
		public float m_MinimumDistanceFromTarget;

		[Token(Token = "0x400005F")]
		[FieldOffset(Offset = "0x40")]
		[Attribute(Name = "FormerlySerializedAsAttribute", RVA = "0x782A4", Offset = "0x782A4")]
		public bool m_AvoidObstacles;

		[Token(Token = "0x4000060")]
		[FieldOffset(Offset = "0x44")]
		[Attribute(Name = "FormerlySerializedAsAttribute", RVA = "0x782DC", Offset = "0x782DC")]
		public float m_DistanceLimit;

		[Token(Token = "0x4000061")]
		[FieldOffset(Offset = "0x48")]
		public float m_MinimumOcclusionTime;

		[Token(Token = "0x4000062")]
		[FieldOffset(Offset = "0x4C")]
		public float m_CameraRadius;

		[Token(Token = "0x4000063")]
		[FieldOffset(Offset = "0x50")]
		public ResolutionStrategy m_Strategy;

		[Token(Token = "0x4000064")]
		[FieldOffset(Offset = "0x54")]
		[Attribute(Name = "RangeAttribute", RVA = "0x78314", Offset = "0x78314")]
		public int m_MaximumEffort;

		[Token(Token = "0x4000065")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "RangeAttribute", RVA = "0x7832C", Offset = "0x7832C")]
		public float m_SmoothingTime;

		[Token(Token = "0x4000066")]
		[FieldOffset(Offset = "0x5C")]
		[Attribute(Name = "FormerlySerializedAsAttribute", RVA = "0x78344", Offset = "0x78344")]
		[Attribute(Name = "RangeAttribute", RVA = "0x78344", Offset = "0x78344")]
		public float m_Damping;

		[Token(Token = "0x4000067")]
		[FieldOffset(Offset = "0x60")]
		[Attribute(Name = "RangeAttribute", RVA = "0x78398", Offset = "0x78398")]
		public float m_DampingWhenOccluded;

		[Token(Token = "0x4000068")]
		[FieldOffset(Offset = "0x64")]
		public float m_OptimalTargetDistance;

		[Token(Token = "0x4000069")]
		private const float PrecisionSlush = 0.001f;

		[Token(Token = "0x400006A")]
		[FieldOffset(Offset = "0x68")]
		private RaycastHit[] m_CornerBuffer;

		[Token(Token = "0x400006B")]
		private const float AngleThreshold = 0.1f;

		[Token(Token = "0x400006C")]
		[FieldOffset(Offset = "0x70")]
		private Collider[] mColliderBuffer;

		[Token(Token = "0x400006D")]
		[FieldOffset(Offset = "0x0")]
		private static SphereCollider mCameraCollider;

		[Token(Token = "0x400006E")]
		[FieldOffset(Offset = "0x8")]
		private static GameObject mCameraColliderGameObject;

		[Token(Token = "0x1700001D")]
		public List<List<Vector3>> DebugPaths
		{
			[Token(Token = "0x6000076")]
			[Address(RVA = "0x18E92C4", Offset = "0x18E92C4", VA = "0x18E92C4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000072")]
		[Address(RVA = "0x18E8FF0", Offset = "0x18E8FF0", VA = "0x18E8FF0")]
		public bool IsTargetObscured(ICinemachineCamera vcam)
		{
			return default;
		}

		[Token(Token = "0x6000073")]
		[Address(RVA = "0x18E9060", Offset = "0x18E9060", VA = "0x18E9060")]
		public bool CameraWasDisplaced(ICinemachineCamera vcam)
		{
			return default;
		}

		[Token(Token = "0x6000074")]
		[Address(RVA = "0x18E90D8", Offset = "0x18E90D8", VA = "0x18E90D8")]
		private void OnValidate()
		{
		}

		[Token(Token = "0x6000075")]
		[Address(RVA = "0x18E9160", Offset = "0x18E9160", VA = "0x18E9160", Slot = "5")]
		protected override void OnDestroy()
		{
		}

		[Token(Token = "0x6000077")]
		[Address(RVA = "0x18E94C0", Offset = "0x18E94C0", VA = "0x18E94C0", Slot = "7")]
		protected override void PostPipelineStageCallback(CinemachineVirtualCameraBase vcam, CinemachineCore.Stage stage, ref CameraState state, float deltaTime)
		{
		}

		[Token(Token = "0x6000078")]
		[Address(RVA = "0x18E9BFC", Offset = "0x18E9BFC", VA = "0x18E9BFC")]
		private Vector3 PreserveLignOfSight(ref CameraState state, ref VcamExtraState extra)
		{
			return default;
		}

		[Token(Token = "0x6000079")]
		[Address(RVA = "0x18EAB48", Offset = "0x18EAB48", VA = "0x18EAB48")]
		private Vector3 PullCameraInFrontOfNearestObstacle(Vector3 cameraPos, Vector3 lookAtPos, int layerMask, ref RaycastHit hitInfo)
		{
			return default;
		}

		[Token(Token = "0x600007A")]
		[Address(RVA = "0x18EB2EC", Offset = "0x18EB2EC", VA = "0x18EB2EC")]
		private bool RaycastIgnoreTag(Ray ray, out RaycastHit hitInfo, float rayLength, int layerMask)
		{
			return default;
		}

		[Token(Token = "0x600007B")]
		[Address(RVA = "0x18EAD58", Offset = "0x18EAD58", VA = "0x18EAD58")]
		private Vector3 PushCameraBack(Vector3 currentPos, Vector3 pushDir, RaycastHit obstacle, Vector3 lookAtPos, Plane startPlane, float targetDistance, int iterations, ref VcamExtraState extra)
		{
			return default;
		}

		[Token(Token = "0x600007C")]
		[Address(RVA = "0x18EB508", Offset = "0x18EB508", VA = "0x18EB508")]
		private bool GetWalkingDirection(Vector3 pos, Vector3 pushDir, RaycastHit obstacle, ref Vector3 outDir)
		{
			return default;
		}

		[Token(Token = "0x600007D")]
		[Address(RVA = "0x18EBAF8", Offset = "0x18EBAF8", VA = "0x18EBAF8")]
		private float GetPushBackDistance(Ray ray, Plane startPlane, float targetDistance, Vector3 lookAtPos)
		{
			return default;
		}

		[Token(Token = "0x600007E")]
		[Address(RVA = "0x18EBC88", Offset = "0x18EBC88", VA = "0x18EBC88")]
		private float ClampRayToBounds(Ray ray, float distance, Bounds bounds)
		{
			return default;
		}

		[Token(Token = "0x600007F")]
		[Address(RVA = "0x18E9190", Offset = "0x18E9190", VA = "0x18E9190")]
		private static void DestroyCollider()
		{
		}

		[Token(Token = "0x6000080")]
		[Address(RVA = "0x18E9F6C", Offset = "0x18E9F6C", VA = "0x18E9F6C")]
		private Vector3 RespectCameraRadius(Vector3 cameraPos, ref CameraState state)
		{
			return default;
		}

		[Token(Token = "0x6000081")]
		[Address(RVA = "0x18EA9E8", Offset = "0x18EA9E8", VA = "0x18EA9E8")]
		private bool CheckForTargetObstructions(CameraState state)
		{
			return default;
		}

		[Token(Token = "0x6000082")]
		[Address(RVA = "0x18EA784", Offset = "0x18EA784", VA = "0x18EA784")]
		private bool IsTargetOffscreen(CameraState state)
		{
			return default;
		}

		[Token(Token = "0x6000083")]
		[Address(RVA = "0x18EC084", Offset = "0x18EC084", VA = "0x18EC084")]
		public CinemachineCollider()
		{
		}
	}
}
