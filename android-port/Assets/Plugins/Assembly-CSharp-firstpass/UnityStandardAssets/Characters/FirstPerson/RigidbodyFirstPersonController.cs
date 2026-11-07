using System;
using Il2CppDummyDll;
using UnityEngine;

namespace UnityStandardAssets.Characters.FirstPerson
{
	[Token(Token = "0x200007E")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x333E0", Offset = "0x333E0")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x333E0", Offset = "0x333E0")]
	public class RigidbodyFirstPersonController : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x200007F")]
		public class MovementSettings
		{
			[Token(Token = "0x4000233")]
			[FieldOffset(Offset = "0x10")]
			public float ForwardSpeed;

			[Token(Token = "0x4000234")]
			[FieldOffset(Offset = "0x14")]
			public float BackwardSpeed;

			[Token(Token = "0x4000235")]
			[FieldOffset(Offset = "0x18")]
			public float StrafeSpeed;

			[Token(Token = "0x4000236")]
			[FieldOffset(Offset = "0x1C")]
			public float RunMultiplier;

			[Token(Token = "0x4000237")]
			[FieldOffset(Offset = "0x20")]
			public KeyCode RunKey;

			[Token(Token = "0x4000238")]
			[FieldOffset(Offset = "0x24")]
			public float JumpForce;

			[Token(Token = "0x4000239")]
			[FieldOffset(Offset = "0x28")]
			public AnimationCurve SlopeCurveModifier;

			[Token(Token = "0x400023A")]
			[FieldOffset(Offset = "0x30")]
			public float CurrentTargetSpeed;

			[Token(Token = "0x400023B")]
			[FieldOffset(Offset = "0x34")]
			private bool m_Running;

			[Token(Token = "0x17000041")]
			public bool Running
			{
				[Token(Token = "0x6000239")]
				[Address(RVA = "0x1355348", Offset = "0x1355348", VA = "0x1355348")]
				get
				{
					return default;
				}
			}

			[Token(Token = "0x6000238")]
			[Address(RVA = "0x1355288", Offset = "0x1355288", VA = "0x1355288")]
			public void UpdateDesiredTargetSpeed(Vector2 input)
			{
			}

			[Token(Token = "0x600023A")]
			[Address(RVA = "0x1355350", Offset = "0x1355350", VA = "0x1355350")]
			public MovementSettings()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x2000080")]
		public class AdvancedSettings
		{
			[Token(Token = "0x400023C")]
			[FieldOffset(Offset = "0x10")]
			public float groundCheckDistance;

			[Token(Token = "0x400023D")]
			[FieldOffset(Offset = "0x14")]
			public float stickToGroundHelperDistance;

			[Token(Token = "0x400023E")]
			[FieldOffset(Offset = "0x18")]
			public float slowDownRate;

			[Token(Token = "0x400023F")]
			[FieldOffset(Offset = "0x1C")]
			public bool airControl;

			[Token(Token = "0x4000240")]
			[FieldOffset(Offset = "0x20")]
			public float shellOffset;

			[Token(Token = "0x600023B")]
			[Address(RVA = "0x1355268", Offset = "0x1355268", VA = "0x1355268")]
			public AdvancedSettings()
			{
			}
		}

		[Token(Token = "0x4000228")]
		[FieldOffset(Offset = "0x18")]
		public Camera cam;

		[Token(Token = "0x4000229")]
		[FieldOffset(Offset = "0x20")]
		public MovementSettings movementSettings;

		[Token(Token = "0x400022A")]
		[FieldOffset(Offset = "0x28")]
		public MouseLook mouseLook;

		[Token(Token = "0x400022B")]
		[FieldOffset(Offset = "0x30")]
		public AdvancedSettings advancedSettings;

		[Token(Token = "0x400022C")]
		[FieldOffset(Offset = "0x38")]
		private Rigidbody m_RigidBody;

		[Token(Token = "0x400022D")]
		[FieldOffset(Offset = "0x40")]
		private CapsuleCollider m_Capsule;

		[Token(Token = "0x400022E")]
		[FieldOffset(Offset = "0x48")]
		private Vector3 m_GroundContactNormal;

		[Token(Token = "0x400022F")]
		[FieldOffset(Offset = "0x54")]
		private bool m_Jump;

		[Token(Token = "0x4000230")]
		[FieldOffset(Offset = "0x55")]
		private bool m_PreviouslyGrounded;

		[Token(Token = "0x4000231")]
		[FieldOffset(Offset = "0x56")]
		private bool m_Jumping;

		[Token(Token = "0x4000232")]
		[FieldOffset(Offset = "0x57")]
		private bool m_IsGrounded;

		[Token(Token = "0x1700003D")]
		public Vector3 Velocity
		{
			[Token(Token = "0x600022B")]
			[Address(RVA = "0x13DCDD8", Offset = "0x13DCDD8", VA = "0x13DCDD8")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x1700003E")]
		public bool Grounded
		{
			[Token(Token = "0x600022C")]
			[Address(RVA = "0x13DCDF4", Offset = "0x13DCDF4", VA = "0x13DCDF4")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x1700003F")]
		public bool Jumping
		{
			[Token(Token = "0x600022D")]
			[Address(RVA = "0x13DCDFC", Offset = "0x13DCDFC", VA = "0x13DCDFC")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000040")]
		public bool Running
		{
			[Token(Token = "0x600022E")]
			[Address(RVA = "0x13DCE04", Offset = "0x13DCE04", VA = "0x13DCE04")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x600022F")]
		[Address(RVA = "0x13DCE20", Offset = "0x13DCE20", VA = "0x13DCE20")]
		private void Start()
		{
		}

		[Token(Token = "0x6000230")]
		[Address(RVA = "0x13DCEDC", Offset = "0x13DCEDC", VA = "0x13DCEDC")]
		private void Update()
		{
		}

		[Token(Token = "0x6000231")]
		[Address(RVA = "0x13DD0F4", Offset = "0x13DD0F4", VA = "0x13DD0F4")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x6000232")]
		[Address(RVA = "0x13DD698", Offset = "0x13DD698", VA = "0x13DD698")]
		private float SlopeMultiplier()
		{
			return default;
		}

		[Token(Token = "0x6000233")]
		[Address(RVA = "0x13DD70C", Offset = "0x13DD70C", VA = "0x13DD70C")]
		private void StickToGroundHelper()
		{
		}

		[Token(Token = "0x6000234")]
		[Address(RVA = "0x13DD5C0", Offset = "0x13DD5C0", VA = "0x13DD5C0")]
		private Vector2 GetInput()
		{
			return default;
		}

		[Token(Token = "0x6000235")]
		[Address(RVA = "0x13DCF7C", Offset = "0x13DCF7C", VA = "0x13DCF7C")]
		private void RotateView()
		{
		}

		[Token(Token = "0x6000236")]
		[Address(RVA = "0x13DD440", Offset = "0x13DD440", VA = "0x13DD440")]
		private void GroundCheck()
		{
		}

		[Token(Token = "0x6000237")]
		[Address(RVA = "0x13DD8E0", Offset = "0x13DD8E0", VA = "0x13DD8E0")]
		public RigidbodyFirstPersonController()
		{
		}
	}
}
