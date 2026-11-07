using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Events;

namespace Cinemachine
{
	[Token(Token = "0x200000B")]
	[ExecuteAlways]
	[DisallowMultipleComponent]
	public class CinemachineBrain : MonoBehaviour
	{
		[Token(Token = "0x200000C")]
		public enum UpdateMethod
		{
			[Token(Token = "0x4000036")]
			FixedUpdate = 0,
			[Token(Token = "0x4000037")]
			LateUpdate = 1,
			[Token(Token = "0x4000038")]
			SmartUpdate = 2
		}

		[Token(Token = "0x200000D")]
		public enum BrainUpdateMethod
		{
			[Token(Token = "0x400003A")]
			FixedUpdate = 0,
			[Token(Token = "0x400003B")]
			LateUpdate = 1
		}

		[Serializable]
		[Token(Token = "0x200000E")]
		public class BrainEvent : UnityEvent<CinemachineBrain>
		{
			[Token(Token = "0x6000049")]
			[Address(RVA = "0x190E924", Offset = "0x190E924", VA = "0x190E924")]
			public BrainEvent()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x200000F")]
		public class VcamActivatedEvent : UnityEvent<ICinemachineCamera, ICinemachineCamera>
		{
			[Token(Token = "0x600004A")]
			[Address(RVA = "0x190EABC", Offset = "0x190EABC", VA = "0x190EABC")]
			public VcamActivatedEvent()
			{
			}
		}

		[Token(Token = "0x2000010")]
		private class BrainFrame
		{
			[Token(Token = "0x400003C")]
			[FieldOffset(Offset = "0x10")]
			public int id;

			[Token(Token = "0x400003D")]
			[FieldOffset(Offset = "0x18")]
			public CinemachineBlend blend;

			[Token(Token = "0x400003E")]
			[FieldOffset(Offset = "0x20")]
			public CinemachineBlend workingBlend;

			[Token(Token = "0x400003F")]
			[FieldOffset(Offset = "0x28")]
			public BlendSourceVirtualCamera workingBlendSource;

			[Token(Token = "0x4000040")]
			[FieldOffset(Offset = "0x30")]
			public float deltaTimeOverride;

			[Token(Token = "0x4000041")]
			[FieldOffset(Offset = "0x34")]
			public float timeOfOverride;

			[Token(Token = "0x17000011")]
			public bool Active
			{
				[Token(Token = "0x600004B")]
				[Address(RVA = "0x190E97C", Offset = "0x190E97C", VA = "0x190E97C")]
				get
				{
					return default;
				}
			}

			[Token(Token = "0x17000012")]
			public bool TimeOverrideExpired
			{
				[Token(Token = "0x600004C")]
				[Address(RVA = "0x190E998", Offset = "0x190E998", VA = "0x190E998")]
				get
				{
					return default;
				}
			}

			[Token(Token = "0x600004D")]
			[Address(RVA = "0x190E9E0", Offset = "0x190E9E0", VA = "0x190E9E0")]
			public BrainFrame()
			{
			}
		}

		[Token(Token = "0x2000011")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x77FB4", Offset = "0x77FB4")]
		private sealed class _003CAfterPhysics_003Ed__30 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000042")]
			[FieldOffset(Offset = "0x10")]
			private int _003C_003E1__state;

			[Token(Token = "0x4000043")]
			[FieldOffset(Offset = "0x18")]
			private object _003C_003E2__current;

			[Token(Token = "0x4000044")]
			[FieldOffset(Offset = "0x20")]
			public CinemachineBrain _003C_003E4__this;

			[Token(Token = "0x17000013")]
			private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
			{
				[Token(Token = "0x6000051")]
				[Address(RVA = "0x190E8D4", Offset = "0x190E8D4", VA = "0x190E8D4", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
				}
			}

			[Token(Token = "0x17000014")]
			private object System_002ECollections_002EIEnumerator_002ECurrent
			{
				[Token(Token = "0x6000053")]
				[Address(RVA = "0x190E91C", Offset = "0x190E91C", VA = "0x190E91C", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EIEnumerator_002Eget_Current();
				}
			}

			[Token(Token = "0x600004E")]
			[Address(RVA = "0x190E790", Offset = "0x190E790", VA = "0x190E790")]
			[DebuggerHidden]
			public _003CAfterPhysics_003Ed__30(int _003C_003E1__state)
			{
			}

			[Token(Token = "0x600004F")]
			[Address(RVA = "0x190E7BC", Offset = "0x190E7BC", VA = "0x190E7BC", Slot = "5")]
			[DebuggerHidden]
			private void System_002EIDisposable_002EDispose()
			{
			}

			[Token(Token = "0x6000050")]
			[Address(RVA = "0x190E7C0", Offset = "0x190E7C0", VA = "0x190E7C0", Slot = "6")]
			private bool MoveNext()
			{
				return default;
			}

			[Token(Token = "0x6000051")]
			[Address(RVA = "0x190E8D4", Offset = "0x190E8D4", VA = "0x190E8D4", Slot = "4")]
			[DebuggerHidden]
			private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
			{
				return null;
			}

			[Token(Token = "0x6000052")]
			[Address(RVA = "0x190E8DC", Offset = "0x190E8DC", VA = "0x190E8DC", Slot = "8")]
			[DebuggerHidden]
			private void System_002ECollections_002EIEnumerator_002EReset()
			{
			}

			[Token(Token = "0x6000053")]
			[Address(RVA = "0x190E91C", Offset = "0x190E91C", VA = "0x190E91C", Slot = "7")]
			[DebuggerHidden]
			private object System_002ECollections_002EIEnumerator_002Eget_Current()
			{
				return null;
			}
		}

		[Token(Token = "0x4000022")]
		[FieldOffset(Offset = "0x18")]
		public bool m_ShowDebugText;

		[Token(Token = "0x4000023")]
		[FieldOffset(Offset = "0x19")]
		public bool m_ShowCameraFrustum;

		[Token(Token = "0x4000024")]
		[FieldOffset(Offset = "0x1A")]
		public bool m_IgnoreTimeScale;

		[Token(Token = "0x4000025")]
		[FieldOffset(Offset = "0x20")]
		public Transform m_WorldUpOverride;

		[Token(Token = "0x4000026")]
		[FieldOffset(Offset = "0x28")]
		public UpdateMethod m_UpdateMethod;

		[Token(Token = "0x4000027")]
		[FieldOffset(Offset = "0x2C")]
		public BrainUpdateMethod m_BlendUpdateMethod;

		[Token(Token = "0x4000028")]
		[FieldOffset(Offset = "0x30")]
		public CinemachineBlendDefinition m_DefaultBlend;

		[Token(Token = "0x4000029")]
		[FieldOffset(Offset = "0x40")]
		public CinemachineBlenderSettings m_CustomBlends;

		[Token(Token = "0x400002A")]
		[FieldOffset(Offset = "0x48")]
		private Camera m_OutputCamera;

		[Token(Token = "0x400002B")]
		[FieldOffset(Offset = "0x50")]
		public BrainEvent m_CameraCutEvent;

		[Token(Token = "0x400002C")]
		[FieldOffset(Offset = "0x58")]
		public VcamActivatedEvent m_CameraActivatedEvent;

		[Token(Token = "0x400002D")]
		[FieldOffset(Offset = "0x0")]
		private static ICinemachineCamera mSoloCamera;

		[Token(Token = "0x400002E")]
		[FieldOffset(Offset = "0x60")]
		private Coroutine mPhysicsCoroutine;

		[Token(Token = "0x400002F")]
		[FieldOffset(Offset = "0x68")]
		private WaitForFixedUpdate mWaitForFixedUpdate;

		[Token(Token = "0x4000030")]
		[FieldOffset(Offset = "0x70")]
		private List<BrainFrame> mFrameStack;

		[Token(Token = "0x4000031")]
		[FieldOffset(Offset = "0x78")]
		private int mNextFrameId;

		[Token(Token = "0x4000032")]
		[FieldOffset(Offset = "0x80")]
		private CinemachineBlend mCurrentLiveCameras;

		[Token(Token = "0x4000033")]
		[FieldOffset(Offset = "0x88")]
		private ICinemachineCamera mActiveCameraPreviousFrame;

		[Token(Token = "0x4000034")]
		[FieldOffset(Offset = "0x90")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x78264", Offset = "0x78264")]
		private CameraState CurrentCameraState__BackingField;

		[Token(Token = "0x1700000A")]
		public Camera OutputCamera
		{
			[Token(Token = "0x600002B")]
			[Address(RVA = "0x18E3C0C", Offset = "0x18E3C0C", VA = "0x18E3C0C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700000B")]
		public static ICinemachineCamera SoloCamera
		{
			[Token(Token = "0x600002C")]
			[Address(RVA = "0x18E3CC4", Offset = "0x18E3CC4", VA = "0x18E3CC4")]
			get
			{
				return null;
			}
			[Token(Token = "0x600002D")]
			[Address(RVA = "0x18E3D10", Offset = "0x18E3D10", VA = "0x18E3D10")]
			set
			{
			}
		}

		[Token(Token = "0x1700000C")]
		public Vector3 DefaultWorldUp
		{
			[Token(Token = "0x600002F")]
			[Address(RVA = "0x18E4034", Offset = "0x18E4034", VA = "0x18E4034")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x1700000D")]
		public ICinemachineCamera ActiveVirtualCamera
		{
			[Token(Token = "0x6000038")]
			[Address(RVA = "0x18E4F48", Offset = "0x18E4F48", VA = "0x18E4F48")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700000E")]
		public bool IsBlending
		{
			[Token(Token = "0x600003A")]
			[Address(RVA = "0x18E4E20", Offset = "0x18E4E20", VA = "0x18E4E20")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x1700000F")]
		public CinemachineBlend ActiveBlend
		{
			[Token(Token = "0x600003B")]
			[Address(RVA = "0x18E4EB8", Offset = "0x18E4EB8", VA = "0x18E4EB8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000010")]
		public CameraState CurrentCameraState
		{
			[Token(Token = "0x6000043")]
			[Address(RVA = "0x18E71E4", Offset = "0x18E71E4", VA = "0x18E71E4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x79438", Offset = "0x79438")]
			get
			{
				return default;
			}
			[Token(Token = "0x6000044")]
			[Address(RVA = "0x18E7220", Offset = "0x18E7220", VA = "0x18E7220")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x79448", Offset = "0x79448")]
			private set
			{
			}
		}

		[Token(Token = "0x600002E")]
		[Address(RVA = "0x18E3FB8", Offset = "0x18E3FB8", VA = "0x18E3FB8")]
		public static Color GetSoloGUIColor()
		{
			return default;
		}

		[Token(Token = "0x6000030")]
		[Address(RVA = "0x18E40E8", Offset = "0x18E40E8", VA = "0x18E40E8")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000031")]
		[Address(RVA = "0x18E4460", Offset = "0x18E4460", VA = "0x18E4460")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6000032")]
		[Address(RVA = "0x18E464C", Offset = "0x18E464C", VA = "0x18E464C")]
		private void Start()
		{
		}

		[Token(Token = "0x6000033")]
		[Address(RVA = "0x18E48F8", Offset = "0x18E48F8", VA = "0x18E48F8")]
		private void OnGuiHandler()
		{
		}

		[Token(Token = "0x6000034")]
		[Address(RVA = "0x18E43EC", Offset = "0x18E43EC", VA = "0x18E43EC")]
		private IEnumerator AfterPhysics()
		{
			return null;
		}

		[Token(Token = "0x6000035")]
		[Address(RVA = "0x18E4FE0", Offset = "0x18E4FE0", VA = "0x18E4FE0")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000036")]
		[Address(RVA = "0x18E5240", Offset = "0x18E5240", VA = "0x18E5240")]
		private float GetEffectiveDeltaTime(bool fixedDelta)
		{
			return default;
		}

		[Token(Token = "0x6000037")]
		[Address(RVA = "0x18E4658", Offset = "0x18E4658", VA = "0x18E4658")]
		private void UpdateVirtualCameras(CinemachineCore.UpdateFilter updateFilter, float deltaTime)
		{
		}

		[Token(Token = "0x6000039")]
		[Address(RVA = "0x18E6424", Offset = "0x18E6424", VA = "0x18E6424")]
		private static ICinemachineCamera DeepCamBFromBlend(CinemachineBlend blend)
		{
			return null;
		}

		[Token(Token = "0x600003C")]
		[Address(RVA = "0x18E6554", Offset = "0x18E6554", VA = "0x18E6554")]
		private int GetBrainFrame(int withId)
		{
			return default;
		}

		[Token(Token = "0x600003D")]
		[Address(RVA = "0x18E6688", Offset = "0x18E6688", VA = "0x18E6688")]
		internal int SetCameraOverride(int overrideId, ICinemachineCamera camA, ICinemachineCamera camB, float weightB, float deltaTime)
		{
			return default;
		}

		[Token(Token = "0x600003E")]
		[Address(RVA = "0x18E6794", Offset = "0x18E6794", VA = "0x18E6794")]
		internal void ReleaseCameraOverride(int overrideId)
		{
		}

		[Token(Token = "0x600003F")]
		[Address(RVA = "0x18E5AB4", Offset = "0x18E5AB4", VA = "0x18E5AB4")]
		private void ProcessActiveCamera(float deltaTime)
		{
		}

		[Token(Token = "0x6000040")]
		[Address(RVA = "0x18E5428", Offset = "0x18E5428", VA = "0x18E5428")]
		private void UpdateFrame0(float deltaTime)
		{
		}

		[Token(Token = "0x6000041")]
		[Address(RVA = "0x18E5778", Offset = "0x18E5778", VA = "0x18E5778")]
		private void UpdateCurrentLiveCameras()
		{
		}

		[Token(Token = "0x6000042")]
		[Address(RVA = "0x18E6F70", Offset = "0x18E6F70", VA = "0x18E6F70")]
		public bool IsLive(ICinemachineCamera vcam, bool dominantChildOnly = false)
		{
			return default;
		}

		[Token(Token = "0x6000045")]
		[Address(RVA = "0x18E6AC4", Offset = "0x18E6AC4", VA = "0x18E6AC4")]
		private ICinemachineCamera TopCameraFromPriorityQueue()
		{
			return null;
		}

		[Token(Token = "0x6000046")]
		[Address(RVA = "0x18E6CE0", Offset = "0x18E6CE0", VA = "0x18E6CE0")]
		private CinemachineBlendDefinition LookupBlend(ICinemachineCamera fromKey, ICinemachineCamera toKey)
		{
			return default;
		}

		[Token(Token = "0x6000047")]
		[Address(RVA = "0x18E6888", Offset = "0x18E6888", VA = "0x18E6888")]
		private void PushStateToUnityCamera(CameraState state)
		{
		}

		[Token(Token = "0x6000048")]
		[Address(RVA = "0x18E731C", Offset = "0x18E731C", VA = "0x18E731C")]
		public CinemachineBrain()
		{
		}
	}
}
