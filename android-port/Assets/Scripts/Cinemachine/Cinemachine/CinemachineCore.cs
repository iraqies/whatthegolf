using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace Cinemachine
{
	[Token(Token = "0x2000063")]
	public sealed class CinemachineCore
	{
		[Token(Token = "0x2000064")]
		public enum Stage
		{
			[Token(Token = "0x4000261")]
			Body = 0,
			[Token(Token = "0x4000262")]
			Aim = 1,
			[Token(Token = "0x4000263")]
			Noise = 2,
			[Token(Token = "0x4000264")]
			Finalize = 3
		}

		[Token(Token = "0x2000065")]
		public delegate float AxisInputDelegate(string axisName);

		[Token(Token = "0x2000066")]
		public delegate CinemachineBlendDefinition GetBlendOverrideDelegate(ICinemachineCamera fromVcam, ICinemachineCamera toVcam, CinemachineBlendDefinition defaultBlend, MonoBehaviour owner);

		[Token(Token = "0x2000067")]
		private class UpdateStatus
		{
			[Token(Token = "0x4000265")]
			[FieldOffset(Offset = "0x10")]
			public int lastUpdateFrame;

			[Token(Token = "0x4000266")]
			[FieldOffset(Offset = "0x14")]
			public int lastUpdateFixedFrame;

			[Token(Token = "0x4000267")]
			[FieldOffset(Offset = "0x18")]
			public UpdateTracker.UpdateClock lastUpdateMode;

			[Token(Token = "0x4000268")]
			[FieldOffset(Offset = "0x1C")]
			public float lastUpdateDeltaTime;

			[Token(Token = "0x6000283")]
			[Address(RVA = "0x190FC08", Offset = "0x190FC08", VA = "0x190FC08")]
			public UpdateStatus()
			{
			}
		}

		[Token(Token = "0x2000068")]
		internal enum UpdateFilter
		{
			[Token(Token = "0x400026A")]
			Fixed = 0,
			[Token(Token = "0x400026B")]
			Late = 1,
			[Token(Token = "0x400026C")]
			Smart = 8,
			[Token(Token = "0x400026D")]
			SmartFixed = Smart,
			[Token(Token = "0x400026E")]
			SmartLate = 9
		}

		[Token(Token = "0x400024F")]
		[FieldOffset(Offset = "0x0")]
		public static readonly int kStreamingVersion;

		[Token(Token = "0x4000250")]
		[FieldOffset(Offset = "0x8")]
		public static readonly string kVersionString;

		[Token(Token = "0x4000251")]
		[FieldOffset(Offset = "0x10")]
		private static CinemachineCore sInstance;

		[Token(Token = "0x4000252")]
		[FieldOffset(Offset = "0x18")]
		public static bool sShowHiddenObjects;

		[Token(Token = "0x4000253")]
		[FieldOffset(Offset = "0x20")]
		public static AxisInputDelegate GetInputAxis;

		[Token(Token = "0x4000254")]
		[FieldOffset(Offset = "0x28")]
		public static float UniformDeltaTimeOverride;

		[Token(Token = "0x4000255")]
		[FieldOffset(Offset = "0x30")]
		public static GetBlendOverrideDelegate GetBlendOverride;

		[Token(Token = "0x4000256")]
		[FieldOffset(Offset = "0x38")]
		public static CinemachineBrain.BrainEvent CameraUpdatedEvent;

		[Token(Token = "0x4000257")]
		[FieldOffset(Offset = "0x40")]
		public static CinemachineBrain.BrainEvent CameraCutEvent;

		[Token(Token = "0x4000258")]
		[FieldOffset(Offset = "0x10")]
		private List<CinemachineBrain> mActiveBrains;

		[Token(Token = "0x4000259")]
		[FieldOffset(Offset = "0x18")]
		private List<CinemachineVirtualCameraBase> mActiveCameras;

		[Token(Token = "0x400025A")]
		[FieldOffset(Offset = "0x20")]
		private List<List<CinemachineVirtualCameraBase>> mAllCameras;

		[Token(Token = "0x400025B")]
		[FieldOffset(Offset = "0x28")]
		private CinemachineVirtualCameraBase mRoundRobinVcamLastFrame;

		[Token(Token = "0x400025C")]
		[FieldOffset(Offset = "0x48")]
		private static float mLastUpdateTime;

		[Token(Token = "0x400025D")]
		[FieldOffset(Offset = "0x4C")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x79220", Offset = "0x79220")]
		private static int FixedFrameCount__BackingField;

		[Token(Token = "0x400025E")]
		[FieldOffset(Offset = "0x30")]
		private Dictionary<CinemachineVirtualCameraBase, UpdateStatus> mUpdateStatus;

		[Token(Token = "0x400025F")]
		[FieldOffset(Offset = "0x38")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x79230", Offset = "0x79230")]
		private UpdateFilter CurrentUpdateFilter__BackingField;

		[Token(Token = "0x170000A9")]
		public static CinemachineCore Instance
		{
			[Token(Token = "0x6000261")]
			[Address(RVA = "0x18E2B90", Offset = "0x18E2B90", VA = "0x18E2B90")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000AA")]
		public int BrainCount
		{
			[Token(Token = "0x6000262")]
			[Address(RVA = "0x18EF9CC", Offset = "0x18EF9CC", VA = "0x18EF9CC")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x170000AB")]
		public int VirtualCameraCount
		{
			[Token(Token = "0x6000266")]
			[Address(RVA = "0x18E725C", Offset = "0x18E725C", VA = "0x18E725C")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x170000AC")]
		private static int FixedFrameCount
		{
			[Token(Token = "0x600026C")]
			[Address(RVA = "0x18EFF1C", Offset = "0x18EFF1C", VA = "0x18EFF1C")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x79A58", Offset = "0x79A58")]
			get
			{
				return default;
			}
			[Token(Token = "0x600026D")]
			[Address(RVA = "0x18EFF80", Offset = "0x18EFF80", VA = "0x18EFF80")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x79A68", Offset = "0x79A68")]
			set
			{
			}
		}

		[Token(Token = "0x170000AD")]
		internal UpdateFilter CurrentUpdateFilter
		{
			[Token(Token = "0x6000271")]
			[Address(RVA = "0x18F05E8", Offset = "0x18F05E8", VA = "0x18F05E8")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x79A88", Offset = "0x79A88")]
			get
			{
				return default;
			}
			[Token(Token = "0x6000272")]
			[Address(RVA = "0x18F05F0", Offset = "0x18F05F0", VA = "0x18F05F0")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x79A98", Offset = "0x79A98")]
			set
			{
			}
		}

		[Token(Token = "0x6000263")]
		[Address(RVA = "0x18EFA18", Offset = "0x18EFA18", VA = "0x18EFA18")]
		public CinemachineBrain GetActiveBrain(int index)
		{
			return null;
		}

		[Token(Token = "0x6000264")]
		[Address(RVA = "0x18E4348", Offset = "0x18E4348", VA = "0x18E4348")]
		internal void AddActiveBrain(CinemachineBrain brain)
		{
		}

		[Token(Token = "0x6000265")]
		[Address(RVA = "0x18E45E8", Offset = "0x18E45E8", VA = "0x18E45E8")]
		internal void RemoveActiveBrain(CinemachineBrain brain)
		{
		}

		[Token(Token = "0x6000267")]
		[Address(RVA = "0x18E72A8", Offset = "0x18E72A8", VA = "0x18E72A8")]
		public CinemachineVirtualCameraBase GetVirtualCamera(int index)
		{
			return null;
		}

		[Token(Token = "0x6000268")]
		[Address(RVA = "0x18EFA8C", Offset = "0x18EFA8C", VA = "0x18EFA8C")]
		internal void AddActiveCamera(CinemachineVirtualCameraBase vcam)
		{
		}

		[Token(Token = "0x6000269")]
		[Address(RVA = "0x18EFBA8", Offset = "0x18EFBA8", VA = "0x18EFBA8")]
		internal void RemoveActiveCamera(CinemachineVirtualCameraBase vcam)
		{
		}

		[Token(Token = "0x600026A")]
		[Address(RVA = "0x18EFC0C", Offset = "0x18EFC0C", VA = "0x18EFC0C")]
		internal void CameraAwakened(CinemachineVirtualCameraBase vcam)
		{
		}

		[Token(Token = "0x600026B")]
		[Address(RVA = "0x18EFDDC", Offset = "0x18EFDDC", VA = "0x18EFDDC")]
		internal void CameraDestroyed(CinemachineVirtualCameraBase vcam)
		{
		}

		[Token(Token = "0x600026E")]
		[Address(RVA = "0x18E5F98", Offset = "0x18E5F98", VA = "0x18E5F98")]
		internal void UpdateAllActiveVirtualCameras(int layerMask, Vector3 worldUp, float deltaTime)
		{
		}

		[Token(Token = "0x600026F")]
		[Address(RVA = "0x18EFFF0", Offset = "0x18EFFF0", VA = "0x18EFFF0")]
		internal void UpdateVirtualCamera(CinemachineVirtualCameraBase vcam, Vector3 worldUp, float deltaTime)
		{
		}

		[Token(Token = "0x6000270")]
		[Address(RVA = "0x18F0538", Offset = "0x18F0538", VA = "0x18F0538")]
		[Attribute(Name = "RuntimeInitializeOnLoadMethodAttribute", RVA = "0x79A78", Offset = "0x79A78")]
		private static void InitializeModule()
		{
		}

		[Token(Token = "0x6000273")]
		[Address(RVA = "0x18F03BC", Offset = "0x18F03BC", VA = "0x18F03BC")]
		private static Transform GetUpdateTarget(CinemachineVirtualCameraBase vcam)
		{
			return null;
		}

		[Token(Token = "0x6000274")]
		[Address(RVA = "0x18F05F8", Offset = "0x18F05F8", VA = "0x18F05F8")]
		internal UpdateTracker.UpdateClock GetVcamUpdateStatus(CinemachineVirtualCameraBase vcam)
		{
			return default;
		}

		[Token(Token = "0x6000275")]
		[Address(RVA = "0x18E3E6C", Offset = "0x18E3E6C", VA = "0x18E3E6C")]
		public bool IsLive(ICinemachineCamera vcam)
		{
			return default;
		}

		[Token(Token = "0x6000276")]
		[Address(RVA = "0x18E2C4C", Offset = "0x18E2C4C", VA = "0x18E2C4C")]
		public void GenerateCameraActivationEvent(ICinemachineCamera vcam, ICinemachineCamera vcamFrom)
		{
		}

		[Token(Token = "0x6000277")]
		[Address(RVA = "0x18E2DC4", Offset = "0x18E2DC4", VA = "0x18E2DC4")]
		public void GenerateCameraCutEvent(ICinemachineCamera vcam)
		{
		}

		[Token(Token = "0x6000278")]
		[Address(RVA = "0x18F0688", Offset = "0x18F0688", VA = "0x18F0688")]
		public CinemachineBrain FindPotentialTargetBrain(CinemachineVirtualCameraBase vcam)
		{
			return null;
		}

		[Token(Token = "0x6000279")]
		[Address(RVA = "0x18EF8BC", Offset = "0x18EF8BC", VA = "0x18EF8BC")]
		public CinemachineCore()
		{
		}
	}
}
