using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;
using UnityEngine;

namespace CameraStack
{
	[Token(Token = "0x200111A")]
	public class OverworldCamera : MonoBehaviour
	{
		[Token(Token = "0x200111B")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x47C24", Offset = "0x47C24")]
		private sealed class _003CResetCameraNextFrame_003Ed__28 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4005A92")]
			[FieldOffset(Offset = "0x10")]
			private int _003C_003E1__state;

			[Token(Token = "0x4005A93")]
			[FieldOffset(Offset = "0x18")]
			private object _003C_003E2__current;

			[Token(Token = "0x4005A94")]
			[FieldOffset(Offset = "0x20")]
			public OverworldCamera _003C_003E4__this;

			[Token(Token = "0x1700082A")]
			private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
			{
				[Token(Token = "0x6004D0F")]
				[Address(RVA = "0x180EDA0", Offset = "0x180EDA0", VA = "0x180EDA0", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
				}
			}

			[Token(Token = "0x1700082B")]
			private object System_002ECollections_002EIEnumerator_002ECurrent
			{
				[Token(Token = "0x6004D11")]
				[Address(RVA = "0x180EDE8", Offset = "0x180EDE8", VA = "0x180EDE8", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EIEnumerator_002Eget_Current();
				}
			}

			[Token(Token = "0x6004D0C")]
			[Address(RVA = "0x180ECAC", Offset = "0x180ECAC", VA = "0x180ECAC")]
			[DebuggerHidden]
			public _003CResetCameraNextFrame_003Ed__28(int _003C_003E1__state)
			{
			}

			[Token(Token = "0x6004D0D")]
			[Address(RVA = "0x180ECD8", Offset = "0x180ECD8", VA = "0x180ECD8", Slot = "5")]
			[DebuggerHidden]
			private void System_002EIDisposable_002EDispose()
			{
			}

			[Token(Token = "0x6004D0E")]
			[Address(RVA = "0x180ECDC", Offset = "0x180ECDC", VA = "0x180ECDC", Slot = "6")]
			private bool MoveNext()
			{
				return default;
			}

			[Token(Token = "0x6004D0F")]
			[Address(RVA = "0x180EDA0", Offset = "0x180EDA0", VA = "0x180EDA0", Slot = "4")]
			[DebuggerHidden]
			private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
			{
				return null;
			}

			[Token(Token = "0x6004D10")]
			[Address(RVA = "0x180EDA8", Offset = "0x180EDA8", VA = "0x180EDA8", Slot = "8")]
			[DebuggerHidden]
			private void System_002ECollections_002EIEnumerator_002EReset()
			{
			}

			[Token(Token = "0x6004D11")]
			[Address(RVA = "0x180EDE8", Offset = "0x180EDE8", VA = "0x180EDE8", Slot = "7")]
			[DebuggerHidden]
			private object System_002ECollections_002EIEnumerator_002Eget_Current()
			{
				return null;
			}
		}

		[Token(Token = "0x4005A81")]
		[FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x56C60", Offset = "0x56C60")]
		private Action m_OnPreLateUpdate;

		[Token(Token = "0x4005A82")]
		[FieldOffset(Offset = "0x20")]
		private Camera[] _cameras;

		[Token(Token = "0x4005A83")]
		[FieldOffset(Offset = "0x0")]
		public static OverworldCamera Instance;

		[Token(Token = "0x4005A84")]
		[FieldOffset(Offset = "0x28")]
		public Transform OverridePositionTransform;

		[Token(Token = "0x4005A85")]
		[FieldOffset(Offset = "0x30")]
		public float OverridePositionWeight;

		[Token(Token = "0x4005A86")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private CameraBehavior MobileCameraBehaviour;

		[Token(Token = "0x4005A87")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private CameraBehavior StandaloneCameraBehaviour;

		[Token(Token = "0x4005A88")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private CBOverworldRoomStatic PuzzleRoomCameraBehaviour;

		[Token(Token = "0x4005A89")]
		[FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x56CA0", Offset = "0x56CA0")]
		private CameraBehavior ActiveBehavior__BackingField;

		[Token(Token = "0x4005A8A")]
		[FieldOffset(Offset = "0x58")]
		private PerlinShake shake;

		[Token(Token = "0x4005A8B")]
		[FieldOffset(Offset = "0x60")]
		private List<OverworldCameraSettings> cameraSettings;

		[Token(Token = "0x4005A8C")]
		[FieldOffset(Offset = "0x68")]
		private GyroShakeOverworld gyro;

		[Token(Token = "0x4005A8D")]
		[FieldOffset(Offset = "0x70")]
		public OverworldCameraSettings defaultSettings;

		[Token(Token = "0x4005A8E")]
		[FieldOffset(Offset = "0x78")]
		public OverworldCameraSettings resetCamearaSettings;

		[Token(Token = "0x4005A8F")]
		[FieldOffset(Offset = "0x80")]
		private float currentCameraSettingsTweenTime;

		[Token(Token = "0x4005A90")]
		[FieldOffset(Offset = "0x84")]
		private Vector3 lastBallPosition;

		[Token(Token = "0x4005A91")]
		[FieldOffset(Offset = "0x90")]
		private Vector3 lookAhead;

		[Token(Token = "0x17000827")]
		public Camera[] Cameras
		{
			[Token(Token = "0x6004CFD")]
			[Address(RVA = "0x15AE834", Offset = "0x15AE834", VA = "0x15AE834")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000828")]
		public Camera MainCamera
		{
			[Token(Token = "0x6004CFE")]
			[Address(RVA = "0x15AE89C", Offset = "0x15AE89C", VA = "0x15AE89C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000829")]
		public CameraBehavior ActiveBehavior
		{
			[Token(Token = "0x6004CFF")]
			[Address(RVA = "0x15AE924", Offset = "0x15AE924", VA = "0x15AE924")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6FC74", Offset = "0x6FC74")]
			get
			{
				return null;
			}
			[Token(Token = "0x6004D00")]
			[Address(RVA = "0x15AE92C", Offset = "0x15AE92C", VA = "0x15AE92C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6FC84", Offset = "0x6FC84")]
			private set
			{
			}
		}

		[Token(Token = "0x1400007F")]
		public event Action OnPreLateUpdate
		{
			[Token(Token = "0x6004CFB")]
			[Address(RVA = "0x15AE6EC", Offset = "0x15AE6EC", VA = "0x15AE6EC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6FC54", Offset = "0x6FC54")]
			add
			{
			}
			[Token(Token = "0x6004CFC")]
			[Address(RVA = "0x15AE790", Offset = "0x15AE790", VA = "0x15AE790")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6FC64", Offset = "0x6FC64")]
			remove
			{
			}
		}

		[Token(Token = "0x6004D01")]
		[Address(RVA = "0x15AE934", Offset = "0x15AE934", VA = "0x15AE934")]
		[AttributeAttribute(Name = "RuntimeInitializeOnLoadMethodAttribute", RVA = "0x6FC94", Offset = "0x6FC94")]
		private static void Init()
		{
		}

		[Token(Token = "0x6004D02")]
		[Address(RVA = "0x15AE980", Offset = "0x15AE980", VA = "0x15AE980")]
		private void Awake()
		{
		}

		[Token(Token = "0x6004D03")]
		[Address(RVA = "0x15AF178", Offset = "0x15AF178", VA = "0x15AF178")]
		private IEnumerator ResetCameraNextFrame()
		{
			return null;
		}

		[Token(Token = "0x6004D04")]
		[Address(RVA = "0x15AF1EC", Offset = "0x15AF1EC", VA = "0x15AF1EC")]
		private void OnCameraSettingsChanged(OverworldCameraSettings settings, float pct)
		{
		}

		[Token(Token = "0x6004D05")]
		[Address(RVA = "0x15AF4E8", Offset = "0x15AF4E8", VA = "0x15AF4E8")]
		public void OnRoomEnter(CBOverworldRoomStatic camSettings)
		{
		}

		[Token(Token = "0x6004D06")]
		[Address(RVA = "0x15AF594", Offset = "0x15AF594", VA = "0x15AF594")]
		public void OnRoomExit()
		{
		}

		[Token(Token = "0x6004D07")]
		[Address(RVA = "0x15AF62C", Offset = "0x15AF62C", VA = "0x15AF62C")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6004D08")]
		[Address(RVA = "0x15AF020", Offset = "0x15AF020", VA = "0x15AF020")]
		public void SwitchBehavior(CameraBehavior newCameraBehavior)
		{
		}

		[Token(Token = "0x6004D09")]
		[Address(RVA = "0x15AF8D4", Offset = "0x15AF8D4", VA = "0x15AF8D4")]
		public void Shake(float duration, float speed, float magnitude)
		{
		}

		[Token(Token = "0x6004D0A")]
		[Address(RVA = "0x15AF9BC", Offset = "0x15AF9BC", VA = "0x15AF9BC")]
		public bool IsWorldPosNearScreen(Vector3 pos, float nearThreshold = 0.25f)
		{
			return default;
		}

		[Token(Token = "0x6004D0B")]
		[Address(RVA = "0x15AFA44", Offset = "0x15AFA44", VA = "0x15AFA44")]
		public OverworldCamera()
		{
		}
	}
}
