using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;
using UnityEngine;

namespace RootMotion.Demos
{
	[Token(Token = "0x2000250")]
	public class CharacterThirdPerson : CharacterBase
	{
		[Serializable]
		[Token(Token = "0x2000251")]
		public enum MoveMode
		{
			[Token(Token = "0x4000F4C")]
			Directional = 0,
			[Token(Token = "0x4000F4D")]
			Strafe = 1
		}

		[Token(Token = "0x2000252")]
		public struct AnimState
		{
			[Token(Token = "0x4000F4E")]
			[FieldOffset(Offset = "0x0")]
			public Vector3 moveDirection;

			[Token(Token = "0x4000F4F")]
			[FieldOffset(Offset = "0xC")]
			public bool jump;

			[Token(Token = "0x4000F50")]
			[FieldOffset(Offset = "0xD")]
			public bool crouch;

			[Token(Token = "0x4000F51")]
			[FieldOffset(Offset = "0xE")]
			public bool onGround;

			[Token(Token = "0x4000F52")]
			[FieldOffset(Offset = "0xF")]
			public bool isStrafing;

			[Token(Token = "0x4000F53")]
			[FieldOffset(Offset = "0x10")]
			public float yVelocity;

			[Token(Token = "0x4000F54")]
			[FieldOffset(Offset = "0x14")]
			public bool doubleJump;
		}

		[Token(Token = "0x2000253")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x340F0", Offset = "0x340F0")]
		private sealed class _003CJumpSmooth_003Ed__74 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000F55")]
			[FieldOffset(Offset = "0x10")]
			private int _003C_003E1__state;

			[Token(Token = "0x4000F56")]
			[FieldOffset(Offset = "0x18")]
			private object _003C_003E2__current;

			[Token(Token = "0x4000F57")]
			[FieldOffset(Offset = "0x20")]
			public CharacterThirdPerson _003C_003E4__this;

			[Token(Token = "0x4000F58")]
			[FieldOffset(Offset = "0x28")]
			public Vector3 jumpVelocity;

			[Token(Token = "0x4000F59")]
			[FieldOffset(Offset = "0x34")]
			private int _003Csteps_003E5__2;

			[Token(Token = "0x4000F5A")]
			[FieldOffset(Offset = "0x38")]
			private int _003CstepsToTake_003E5__3;

			[Token(Token = "0x170001E3")]
			private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
			{
				[Token(Token = "0x6000F66")]
				[Address(RVA = "0x1339294", Offset = "0x1339294", VA = "0x1339294", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
				}
			}

			[Token(Token = "0x170001E4")]
			private object System_002ECollections_002EIEnumerator_002ECurrent
			{
				[Token(Token = "0x6000F68")]
				[Address(RVA = "0x13392DC", Offset = "0x13392DC", VA = "0x13392DC", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EIEnumerator_002Eget_Current();
				}
			}

			[Token(Token = "0x6000F63")]
			[Address(RVA = "0x133917C", Offset = "0x133917C", VA = "0x133917C")]
			[DebuggerHidden]
			public _003CJumpSmooth_003Ed__74(int _003C_003E1__state)
			{
			}

			[Token(Token = "0x6000F64")]
			[Address(RVA = "0x13391A8", Offset = "0x13391A8", VA = "0x13391A8", Slot = "5")]
			[DebuggerHidden]
			private void System_002EIDisposable_002EDispose()
			{
			}

			[Token(Token = "0x6000F65")]
			[Address(RVA = "0x13391AC", Offset = "0x13391AC", VA = "0x13391AC", Slot = "6")]
			private bool MoveNext()
			{
				return default;
			}

			[Token(Token = "0x6000F66")]
			[Address(RVA = "0x1339294", Offset = "0x1339294", VA = "0x1339294", Slot = "4")]
			[DebuggerHidden]
			private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
			{
				return null;
			}

			[Token(Token = "0x6000F67")]
			[Address(RVA = "0x133929C", Offset = "0x133929C", VA = "0x133929C", Slot = "8")]
			[DebuggerHidden]
			private void System_002ECollections_002EIEnumerator_002EReset()
			{
			}

			[Token(Token = "0x6000F68")]
			[Address(RVA = "0x13392DC", Offset = "0x13392DC", VA = "0x13392DC", Slot = "7")]
			[DebuggerHidden]
			private object System_002ECollections_002EIEnumerator_002Eget_Current()
			{
				return null;
			}
		}

		[Token(Token = "0x4000F13")]
		[FieldOffset(Offset = "0x68")]
		public CharacterAnimationBase characterAnimation;

		[Token(Token = "0x4000F14")]
		[FieldOffset(Offset = "0x70")]
		public UserControlThirdPerson userControl;

		[Token(Token = "0x4000F15")]
		[FieldOffset(Offset = "0x78")]
		public CameraController cam;

		[Token(Token = "0x4000F16")]
		[FieldOffset(Offset = "0x80")]
		public MoveMode moveMode;

		[Token(Token = "0x4000F17")]
		[FieldOffset(Offset = "0x84")]
		public bool smoothPhysics;

		[Token(Token = "0x4000F18")]
		[FieldOffset(Offset = "0x88")]
		public float smoothAccelerationTime;

		[Token(Token = "0x4000F19")]
		[FieldOffset(Offset = "0x8C")]
		public float linearAccelerationSpeed;

		[Token(Token = "0x4000F1A")]
		[FieldOffset(Offset = "0x90")]
		public float platformFriction;

		[Token(Token = "0x4000F1B")]
		[FieldOffset(Offset = "0x94")]
		public float groundStickyEffect;

		[Token(Token = "0x4000F1C")]
		[FieldOffset(Offset = "0x98")]
		public float maxVerticalVelocityOnGround;

		[Token(Token = "0x4000F1D")]
		[FieldOffset(Offset = "0x9C")]
		public float velocityToGroundTangentWeight;

		[Token(Token = "0x4000F1E")]
		[FieldOffset(Offset = "0xA0")]
		public bool lookInCameraDirection;

		[Token(Token = "0x4000F1F")]
		[FieldOffset(Offset = "0xA4")]
		public float turnSpeed;

		[Token(Token = "0x4000F20")]
		[FieldOffset(Offset = "0xA8")]
		public float stationaryTurnSpeedMlp;

		[Token(Token = "0x4000F21")]
		[FieldOffset(Offset = "0xAC")]
		public bool smoothJump;

		[Token(Token = "0x4000F22")]
		[FieldOffset(Offset = "0xB0")]
		public float airSpeed;

		[Token(Token = "0x4000F23")]
		[FieldOffset(Offset = "0xB4")]
		public float airControl;

		[Token(Token = "0x4000F24")]
		[FieldOffset(Offset = "0xB8")]
		public float jumpPower;

		[Token(Token = "0x4000F25")]
		[FieldOffset(Offset = "0xBC")]
		public float jumpRepeatDelayTime;

		[Token(Token = "0x4000F26")]
		[FieldOffset(Offset = "0xC0")]
		public bool doubleJumpEnabled;

		[Token(Token = "0x4000F27")]
		[FieldOffset(Offset = "0xC4")]
		public float doubleJumpPowerMlp;

		[Token(Token = "0x4000F28")]
		[FieldOffset(Offset = "0xC8")]
		public LayerMask wallRunLayers;

		[Token(Token = "0x4000F29")]
		[FieldOffset(Offset = "0xCC")]
		public float wallRunMaxLength;

		[Token(Token = "0x4000F2A")]
		[FieldOffset(Offset = "0xD0")]
		public float wallRunMinMoveMag;

		[Token(Token = "0x4000F2B")]
		[FieldOffset(Offset = "0xD4")]
		public float wallRunMinVelocityY;

		[Token(Token = "0x4000F2C")]
		[FieldOffset(Offset = "0xD8")]
		public float wallRunRotationSpeed;

		[Token(Token = "0x4000F2D")]
		[FieldOffset(Offset = "0xDC")]
		public float wallRunMaxRotationAngle;

		[Token(Token = "0x4000F2E")]
		[FieldOffset(Offset = "0xE0")]
		public float wallRunWeightSpeed;

		[Token(Token = "0x4000F2F")]
		[FieldOffset(Offset = "0xE4")]
		public float crouchCapsuleScaleMlp;

		[Token(Token = "0x4000F30")]
		[FieldOffset(Offset = "0xE8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x36EC8", Offset = "0x36EC8")]
		private bool onGround__BackingField;

		[Token(Token = "0x4000F31")]
		[FieldOffset(Offset = "0xEC")]
		public AnimState animState;

		[Token(Token = "0x4000F32")]
		[FieldOffset(Offset = "0x104")]
		protected Vector3 moveDirection;

		[Token(Token = "0x4000F33")]
		[FieldOffset(Offset = "0x110")]
		private Animator animator;

		[Token(Token = "0x4000F34")]
		[FieldOffset(Offset = "0x118")]
		private Vector3 normal;

		[Token(Token = "0x4000F35")]
		[FieldOffset(Offset = "0x124")]
		private Vector3 platformVelocity;

		[Token(Token = "0x4000F36")]
		[FieldOffset(Offset = "0x130")]
		private Vector3 platformAngularVelocity;

		[Token(Token = "0x4000F37")]
		[FieldOffset(Offset = "0x13C")]
		private RaycastHit hit;

		[Token(Token = "0x4000F38")]
		[FieldOffset(Offset = "0x168")]
		private float jumpLeg;

		[Token(Token = "0x4000F39")]
		[FieldOffset(Offset = "0x16C")]
		private float jumpEndTime;

		[Token(Token = "0x4000F3A")]
		[FieldOffset(Offset = "0x170")]
		private float forwardMlp;

		[Token(Token = "0x4000F3B")]
		[FieldOffset(Offset = "0x174")]
		private float groundDistance;

		[Token(Token = "0x4000F3C")]
		[FieldOffset(Offset = "0x178")]
		private float lastAirTime;

		[Token(Token = "0x4000F3D")]
		[FieldOffset(Offset = "0x17C")]
		private float stickyForce;

		[Token(Token = "0x4000F3E")]
		[FieldOffset(Offset = "0x180")]
		private Vector3 wallNormal;

		[Token(Token = "0x4000F3F")]
		[FieldOffset(Offset = "0x18C")]
		private Vector3 moveDirectionVelocity;

		[Token(Token = "0x4000F40")]
		[FieldOffset(Offset = "0x198")]
		private float wallRunWeight;

		[Token(Token = "0x4000F41")]
		[FieldOffset(Offset = "0x19C")]
		private float lastWallRunWeight;

		[Token(Token = "0x4000F42")]
		[FieldOffset(Offset = "0x1A0")]
		private Vector3 fixedDeltaPosition;

		[Token(Token = "0x4000F43")]
		[FieldOffset(Offset = "0x1AC")]
		private Quaternion fixedDeltaRotation;

		[Token(Token = "0x4000F44")]
		[FieldOffset(Offset = "0x1BC")]
		private bool fixedFrame;

		[Token(Token = "0x4000F45")]
		[FieldOffset(Offset = "0x1C0")]
		private float wallRunEndTime;

		[Token(Token = "0x4000F46")]
		[FieldOffset(Offset = "0x1C4")]
		private Vector3 gravity;

		[Token(Token = "0x4000F47")]
		[FieldOffset(Offset = "0x1D0")]
		private Vector3 verticalVelocity;

		[Token(Token = "0x4000F48")]
		[FieldOffset(Offset = "0x1DC")]
		private float velocityY;

		[Token(Token = "0x4000F49")]
		[FieldOffset(Offset = "0x1E0")]
		private bool doubleJumped;

		[Token(Token = "0x4000F4A")]
		[FieldOffset(Offset = "0x1E1")]
		private bool jumpReleased;

		[Token(Token = "0x170001E2")]
		public bool onGround
		{
			[Token(Token = "0x6000F51")]
			[Address(RVA = "0x135E4E4", Offset = "0x135E4E4", VA = "0x135E4E4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3B35C", Offset = "0x3B35C")]
			get
			{
				return default;
			}
			[Token(Token = "0x6000F52")]
			[Address(RVA = "0x135E4EC", Offset = "0x135E4EC", VA = "0x135E4EC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3B36C", Offset = "0x3B36C")]
			private set
			{
			}
		}

		[Token(Token = "0x6000F53")]
		[Address(RVA = "0x135DA34", Offset = "0x135DA34", VA = "0x135DA34", Slot = "5")]
		protected override void Start()
		{
		}

		[Token(Token = "0x6000F54")]
		[Address(RVA = "0x135E4F4", Offset = "0x135E4F4", VA = "0x135E4F4")]
		private void OnAnimatorMove()
		{
		}

		[Token(Token = "0x6000F55")]
		[Address(RVA = "0x135DC28", Offset = "0x135DC28", VA = "0x135DC28", Slot = "4")]
		public override void Move(Vector3 deltaPosition, Quaternion deltaRotation)
		{
		}

		[Token(Token = "0x6000F56")]
		[Address(RVA = "0x135E588", Offset = "0x135E588", VA = "0x135E588")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x6000F57")]
		[Address(RVA = "0x135D79C", Offset = "0x135D79C", VA = "0x135D79C", Slot = "7")]
		protected virtual void Update()
		{
		}

		[Token(Token = "0x6000F58")]
		[Address(RVA = "0x135F364", Offset = "0x135F364", VA = "0x135F364", Slot = "8")]
		protected virtual void LateUpdate()
		{
		}

		[Token(Token = "0x6000F59")]
		[Address(RVA = "0x135EAA8", Offset = "0x135EAA8", VA = "0x135EAA8")]
		private void MoveFixed(Vector3 deltaPosition)
		{
		}

		[Token(Token = "0x6000F5A")]
		[Address(RVA = "0x135F458", Offset = "0x135F458", VA = "0x135F458")]
		private void WallRun()
		{
		}

		[Token(Token = "0x6000F5B")]
		[Address(RVA = "0x135F980", Offset = "0x135F980", VA = "0x135F980")]
		private bool CanWallRun()
		{
			return default;
		}

		[Token(Token = "0x6000F5C")]
		[Address(RVA = "0x135F194", Offset = "0x135F194", VA = "0x135F194")]
		private Vector3 GetMoveDirection()
		{
			return default;
		}

		[Token(Token = "0x6000F5D")]
		[Address(RVA = "0x135DE60", Offset = "0x135DE60", VA = "0x135DE60", Slot = "9")]
		protected virtual void Rotate()
		{
		}

		[Token(Token = "0x6000F5E")]
		[Address(RVA = "0x135FA2C", Offset = "0x135FA2C", VA = "0x135FA2C")]
		private Vector3 GetForwardDirection()
		{
			return default;
		}

		[Token(Token = "0x6000F5F")]
		[Address(RVA = "0x135E214", Offset = "0x135E214", VA = "0x135E214", Slot = "10")]
		protected virtual bool Jump()
		{
			return default;
		}

		[Token(Token = "0x6000F60")]
		[Address(RVA = "0x135FB1C", Offset = "0x135FB1C", VA = "0x135FB1C")]
		private IEnumerator JumpSmooth(Vector3 jumpVelocity)
		{
			return null;
		}

		[Token(Token = "0x6000F61")]
		[Address(RVA = "0x135EE08", Offset = "0x135EE08", VA = "0x135EE08")]
		private void GroundCheck()
		{
		}

		[Token(Token = "0x6000F62")]
		[Address(RVA = "0x135E3E8", Offset = "0x135E3E8", VA = "0x135E3E8")]
		public CharacterThirdPerson()
		{
		}
	}
}
