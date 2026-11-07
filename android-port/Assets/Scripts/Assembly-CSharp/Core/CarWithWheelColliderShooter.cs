using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace Core
{
	[Token(Token = "0x2001448")]
	public class CarWithWheelColliderShooter : GolfBallShooterBase
	{
		[Serializable]
		[Token(Token = "0x2001449")]
		public class AxleInfo
		{
			[Token(Token = "0x4006E3D")]
			[FieldOffset(Offset = "0x10")]
			public WheelCollider leftWheel;

			[Token(Token = "0x4006E3E")]
			[FieldOffset(Offset = "0x18")]
			public WheelCollider rightWheel;

			[Token(Token = "0x4006E3F")]
			[FieldOffset(Offset = "0x20")]
			public bool motor;

			[Token(Token = "0x4006E40")]
			[FieldOffset(Offset = "0x21")]
			public bool steering;

			[Token(Token = "0x4006E41")]
			[FieldOffset(Offset = "0x22")]
			public bool rewerseSteering;

			[Token(Token = "0x4006E42")]
			[FieldOffset(Offset = "0x28")]
			public Transform leftWheelTransform;

			[Token(Token = "0x4006E43")]
			[FieldOffset(Offset = "0x30")]
			public Transform rightWheelTransform;

			[Token(Token = "0x6005EF3")]
			[Address(RVA = "0x1781C1C", Offset = "0x1781C1C", VA = "0x1781C1C")]
			public AxleInfo()
			{
			}
		}

		[Token(Token = "0x4006E25")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		public float fullShootVelocity;

		[Token(Token = "0x4006E26")]
		[FieldOffset(Offset = "0x64")]
		[SerializeField]
		public float minShootVelocity;

		[Token(Token = "0x4006E27")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private float raycastDist;

		[Token(Token = "0x4006E28")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private AnimationCurve shotDampenDurve;

		[Token(Token = "0x4006E29")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private AnimationCurve BreakCurve;

		[Token(Token = "0x4006E2A")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private float shotDampenTime;

		[Token(Token = "0x4006E2B")]
		[FieldOffset(Offset = "0x84")]
		[SerializeField]
		private float shotBoostThreshold;

		[Token(Token = "0x4006E2C")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private float shotBoostMultiplierIncrement;

		[Token(Token = "0x4006E2D")]
		[FieldOffset(Offset = "0x8C")]
		[SerializeField]
		private int shotBoostMaxMultiplierIncrements;

		[Token(Token = "0x4006E2E")]
		[FieldOffset(Offset = "0x90")]
		public List<AxleInfo> axleInfos;

		[Token(Token = "0x4006E2F")]
		[FieldOffset(Offset = "0x98")]
		public float maxMotorTorque;

		[Token(Token = "0x4006E30")]
		[FieldOffset(Offset = "0x9C")]
		public float maxSteeringAngle;

		[Token(Token = "0x4006E31")]
		[FieldOffset(Offset = "0xA0")]
		public float MaxSpeed;

		[Token(Token = "0x4006E32")]
		[FieldOffset(Offset = "0xA4")]
		public float BreakSpeed;

		[Token(Token = "0x4006E33")]
		[FieldOffset(Offset = "0xA8")]
		[SerializeField]
		private float dragInAir;

		[Token(Token = "0x4006E34")]
		[FieldOffset(Offset = "0xB0")]
		[SerializeField]
		private Transform leftFlameTransform;

		[Token(Token = "0x4006E35")]
		[FieldOffset(Offset = "0xB8")]
		[SerializeField]
		private Transform rightFlameTransform;

		[Token(Token = "0x4006E36")]
		[FieldOffset(Offset = "0xC0")]
		private Vector3 lastShootVelocity;

		[Token(Token = "0x4006E37")]
		[FieldOffset(Offset = "0xCC")]
		private float baseDrag;

		[Token(Token = "0x4006E38")]
		[FieldOffset(Offset = "0xD0")]
		private float shotDampen;

		[Token(Token = "0x4006E39")]
		[FieldOffset(Offset = "0xD4")]
		private float shotDampenTimer;

		[Token(Token = "0x4006E3A")]
		[FieldOffset(Offset = "0xD8")]
		private float resetTimer;

		[Token(Token = "0x4006E3B")]
		[FieldOffset(Offset = "0xDC")]
		private float shotDampenMult;

		[Token(Token = "0x4006E3C")]
		[FieldOffset(Offset = "0xE0")]
		private int boostIncrements;

		[Token(Token = "0x6005EED")]
		[Address(RVA = "0x188A63C", Offset = "0x188A63C", VA = "0x188A63C")]
		private void Start()
		{
		}

		[Token(Token = "0x6005EEE")]
		[Address(RVA = "0x188A80C", Offset = "0x188A80C", VA = "0x188A80C", Slot = "6")]
		public override void OnAimUpdate(Vector3 boost, bool onlyAimArrow)
		{
		}

		[Token(Token = "0x6005EEF")]
		[Address(RVA = "0x188A850", Offset = "0x188A850", VA = "0x188A850", Slot = "7")]
		public override void OnShoot(Vector3 boost)
		{
		}

		[Token(Token = "0x6005EF0")]
		[Address(RVA = "0x188A8E8", Offset = "0x188A8E8", VA = "0x188A8E8")]
		private void Update()
		{
		}

		[Token(Token = "0x6005EF1")]
		[Address(RVA = "0x188AA3C", Offset = "0x188AA3C", VA = "0x188AA3C", Slot = "12")]
		protected override void FixedUpdate()
		{
		}

		[Token(Token = "0x6005EF2")]
		[Address(RVA = "0x188B480", Offset = "0x188B480", VA = "0x188B480")]
		public CarWithWheelColliderShooter()
		{
		}
	}
}
