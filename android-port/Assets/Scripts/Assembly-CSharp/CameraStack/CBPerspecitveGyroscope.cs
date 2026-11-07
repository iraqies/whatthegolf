using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Core;
using Il2CppDummyDll;
using UnityEngine;

namespace CameraStack
{
	[Token(Token = "0x200110D")]
	public class CBPerspecitveGyroscope : CameraBehaviorPerspective, ICameraBehaviourFollowing
	{
		[Token(Token = "0x200110E")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x47C04", Offset = "0x47C04")]
		private sealed class _003CSetup_003Ed__24 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4005A57")]
			[FieldOffset(Offset = "0x10")]
			private int _003C_003E1__state;

			[Token(Token = "0x4005A58")]
			[FieldOffset(Offset = "0x18")]
			private object _003C_003E2__current;

			[Token(Token = "0x4005A59")]
			[FieldOffset(Offset = "0x20")]
			public CBPerspecitveGyroscope _003C_003E4__this;

			[Token(Token = "0x17000819")]
			private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
			{
				[Token(Token = "0x6004CAC")]
				[Address(RVA = "0x178086C", Offset = "0x178086C", VA = "0x178086C", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
				}
			}

			[Token(Token = "0x1700081A")]
			private object System_002ECollections_002EIEnumerator_002ECurrent
			{
				[Token(Token = "0x6004CAE")]
				[Address(RVA = "0x17808B4", Offset = "0x17808B4", VA = "0x17808B4", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EIEnumerator_002Eget_Current();
				}
			}

			[Token(Token = "0x6004CA9")]
			[Address(RVA = "0x17804F8", Offset = "0x17804F8", VA = "0x17804F8")]
			[DebuggerHidden]
			public _003CSetup_003Ed__24(int _003C_003E1__state)
			{
			}

			[Token(Token = "0x6004CAA")]
			[Address(RVA = "0x1780524", Offset = "0x1780524", VA = "0x1780524", Slot = "5")]
			[DebuggerHidden]
			private void System_002EIDisposable_002EDispose()
			{
			}

			[Token(Token = "0x6004CAB")]
			[Address(RVA = "0x1780528", Offset = "0x1780528", VA = "0x1780528", Slot = "6")]
			private bool MoveNext()
			{
				return default;
			}

			[Token(Token = "0x6004CAC")]
			[Address(RVA = "0x178086C", Offset = "0x178086C", VA = "0x178086C", Slot = "4")]
			[DebuggerHidden]
			private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
			{
				return null;
			}

			[Token(Token = "0x6004CAD")]
			[Address(RVA = "0x1780874", Offset = "0x1780874", VA = "0x1780874", Slot = "8")]
			[DebuggerHidden]
			private void System_002ECollections_002EIEnumerator_002EReset()
			{
			}

			[Token(Token = "0x6004CAE")]
			[Address(RVA = "0x17808B4", Offset = "0x17808B4", VA = "0x17808B4", Slot = "7")]
			[DebuggerHidden]
			private object System_002ECollections_002EIEnumerator_002Eget_Current()
			{
				return null;
			}
		}

		[Token(Token = "0x4005A40")]
		[FieldOffset(Offset = "0x3C")]
		public Vector3 offset;

		[Token(Token = "0x4005A41")]
		[FieldOffset(Offset = "0x48")]
		public Vector3 rotationOffset;

		[Token(Token = "0x4005A42")]
		[FieldOffset(Offset = "0x58")]
		public Transform gyroTransform;

		[Token(Token = "0x4005A43")]
		[FieldOffset(Offset = "0x60")]
		public float ControllerSensitivity;

		[Token(Token = "0x4005A44")]
		[FieldOffset(Offset = "0x64")]
		public float clampAngle;

		[Token(Token = "0x4005A45")]
		[FieldOffset(Offset = "0x68")]
		public Vector2 clampInDegrees;

		[Token(Token = "0x4005A46")]
		[FieldOffset(Offset = "0x70")]
		public bool lockCursor;

		[Token(Token = "0x4005A47")]
		[FieldOffset(Offset = "0x74")]
		public Vector2 sensitivity;

		[Token(Token = "0x4005A48")]
		[FieldOffset(Offset = "0x7C")]
		public Vector2 smoothing;

		[Token(Token = "0x4005A49")]
		[FieldOffset(Offset = "0x84")]
		public Vector2 targetDirection;

		[Token(Token = "0x4005A4A")]
		[FieldOffset(Offset = "0x90")]
		public GolfBallController Controller;

		[Token(Token = "0x4005A4B")]
		[FieldOffset(Offset = "0x98")]
		public bool FreeLookWhileAiming;

		[Token(Token = "0x4005A4C")]
		[FieldOffset(Offset = "0x99")]
		public bool AutoHideArrow;

		[Token(Token = "0x4005A4D")]
		[FieldOffset(Offset = "0x9A")]
		public bool LookAtFlagOnStart;

		[Token(Token = "0x4005A4E")]
		[FieldOffset(Offset = "0xA0")]
		public FPGHelper HelperPrefab;

		[Token(Token = "0x4005A4F")]
		[FieldOffset(Offset = "0xA8")]
		private Quaternion startOffset;

		[Token(Token = "0x4005A50")]
		[FieldOffset(Offset = "0xB8")]
		private float baseControllerSensitivity;

		[Token(Token = "0x4005A51")]
		[FieldOffset(Offset = "0xBC")]
		private Vector2 _mouseAbsolute;

		[Token(Token = "0x4005A52")]
		[FieldOffset(Offset = "0xC4")]
		private Vector2 _smoothMouse;

		[Token(Token = "0x4005A53")]
		[FieldOffset(Offset = "0xCC")]
		private bool initialized;

		[Token(Token = "0x4005A54")]
		[FieldOffset(Offset = "0xD0")]
		private TimeControl _timeControll;

		[Token(Token = "0x4005A55")]
		[FieldOffset(Offset = "0xD8")]
		private Quaternion _lastRotation;

		[Token(Token = "0x4005A56")]
		private const string HNAME = "Handheld";

		[Token(Token = "0x6004C9B")]
		[Address(RVA = "0x17E17C0", Offset = "0x17E17C0", VA = "0x17E17C0", Slot = "4")]
		public override void Init()
		{
		}

		[Token(Token = "0x6004C9C")]
		[Address(RVA = "0x17E19C4", Offset = "0x17E19C4", VA = "0x17E19C4")]
		private IEnumerator Setup()
		{
			return null;
		}

		[Token(Token = "0x6004C9D")]
		[Address(RVA = "0x17E1A38", Offset = "0x17E1A38", VA = "0x17E1A38")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6004C9E")]
		[Address(RVA = "0x17E1AC0", Offset = "0x17E1AC0", VA = "0x17E1AC0")]
		private void InitPlayer()
		{
		}

		[Token(Token = "0x6004C9F")]
		[Address(RVA = "0x17E1C0C", Offset = "0x17E1C0C", VA = "0x17E1C0C")]
		private void OnReset()
		{
		}

		[Token(Token = "0x6004CA0")]
		[Address(RVA = "0x17E1C5C", Offset = "0x17E1C5C", VA = "0x17E1C5C", Slot = "7")]
		public override Quaternion CalculateRotation()
		{
			return default;
		}

		[Token(Token = "0x6004CA1")]
		[Address(RVA = "0x17E2514", Offset = "0x17E2514", VA = "0x17E2514")]
		private bool IsUsingGyro()
		{
			return default;
		}

		[Token(Token = "0x6004CA2")]
		[Address(RVA = "0x17E1C64", Offset = "0x17E1C64", VA = "0x17E1C64")]
		public Quaternion CalculateRotation(float addUpMagnitude)
		{
			return default;
		}

		[Token(Token = "0x6004CA3")]
		[Address(RVA = "0x17E2870", Offset = "0x17E2870", VA = "0x17E2870", Slot = "8")]
		protected override Vector3 CalculatePosition()
		{
			return default;
		}

		[Token(Token = "0x6004CA4")]
		[Address(RVA = "0x17E26F0", Offset = "0x17E26F0", VA = "0x17E26F0")]
		private Quaternion GetSwitchGyro()
		{
			return default;
		}

		[Token(Token = "0x6004CA5")]
		[Address(RVA = "0x17E295C", Offset = "0x17E295C", VA = "0x17E295C", Slot = "12")]
		public void SetFollowTarget(Transform target)
		{
		}

		[Token(Token = "0x6004CA6")]
		[Address(RVA = "0x17E29C4", Offset = "0x17E29C4", VA = "0x17E29C4", Slot = "13")]
		public Transform GetFollowTarget()
		{
			return null;
		}

		[Token(Token = "0x6004CA7")]
		[Address(RVA = "0x17E2A6C", Offset = "0x17E2A6C", VA = "0x17E2A6C")]
		public CBPerspecitveGyroscope()
		{
		}

		[Token(Token = "0x6004CA8")]
		[Address(RVA = "0x17E2B20", Offset = "0x17E2B20", VA = "0x17E2B20")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6FBB4", Offset = "0x6FBB4")]
		private void _003CInitPlayer_003Eb__26_0(Vector3 v, bool s)
		{
		}
	}
}
