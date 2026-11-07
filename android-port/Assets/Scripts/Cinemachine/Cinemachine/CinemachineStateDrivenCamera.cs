using System;
using System.Collections.Generic;
using UnityEngine;

namespace Cinemachine
{
	[DisallowMultipleComponent]
	[ExecuteAlways]
	public class CinemachineStateDrivenCamera : CinemachineVirtualCameraBase
	{
		[Serializable]
		public struct Instruction
		{
			public int m_FullHash;

			public CinemachineVirtualCameraBase m_VirtualCamera;

			public float m_ActivateAfter;

			public float m_MinDuration;
		}

		[Serializable]
		internal struct ParentHash
		{
			public int m_Hash;

			public int m_ParentHash;
		}

		private struct HashPair
		{
			public int parentHash;

			public int hash;
		}

		public Transform m_LookAt;

		public Transform m_Follow;

		public Animator m_AnimatedTarget;

		public int m_LayerIndex;

		public bool m_ShowDebugText;

		[SerializeField]
		internal CinemachineVirtualCameraBase[] m_ChildCameras;

		public Instruction[] m_Instructions;

		public CinemachineBlendDefinition m_DefaultBlend;

		public CinemachineBlenderSettings m_CustomBlends;

		[SerializeField]
		internal ParentHash[] m_ParentHash;

		private CameraState m_State;

		private Dictionary<AnimationClip, List<HashPair>> mHashCache;

		private float mActivationTime;

		private Instruction mActiveInstruction;

		private float mPendingActivationTime;

		private Instruction mPendingInstruction;

		private CinemachineBlend mActiveBlend;

		private Dictionary<int, int> mInstructionDictionary;

		private Dictionary<int, int> mStateParentLookup;

		private List<AnimatorClipInfo> m_clipInfoList;

		public override string Description => null;

		public ICinemachineCamera LiveChild { get; set; }

		public override CameraState State => default;

		public override Transform LookAt
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public override Transform Follow
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		private ICinemachineCamera TransitioningFrom { get; set; }

		public CinemachineVirtualCameraBase[] ChildCameras => null;

		public bool IsBlending => false;

		public override bool IsLiveChild(ICinemachineCamera vcam, bool dominantChildOnly = false)
		{
			return false;
		}

		public override void OnTargetObjectWarped(Transform target, Vector3 positionDelta)
		{
		}

		public override void OnTransitionFromCamera(ICinemachineCamera fromCam, Vector3 worldUp, float deltaTime)
		{
		}

		public override void InternalUpdateCameraState(Vector3 worldUp, float deltaTime)
		{
		}

		protected override void OnEnable()
		{
		}

		protected override void OnDisable()
		{
		}

		public void OnTransformChildrenChanged()
		{
		}

		private void OnGuiHandler()
		{
		}

		public static int CreateFakeHash(int parentHash, AnimationClip clip)
		{
			return 0;
		}

		private int LookupFakeHash(int parentHash, AnimationClip clip)
		{
			return 0;
		}

		private void InvalidateListOfChildren()
		{
		}

		private void UpdateListOfChildren()
		{
		}

		internal void ValidateInstructions()
		{
		}

		private CinemachineVirtualCameraBase ChooseCurrentCamera()
		{
			return null;
		}

		private int GetClipHash(int hash, List<AnimatorClipInfo> clips)
		{
			return 0;
		}

		private CinemachineBlendDefinition LookupBlend(ICinemachineCamera fromKey, ICinemachineCamera toKey)
		{
			return default;
		}
	}
}
