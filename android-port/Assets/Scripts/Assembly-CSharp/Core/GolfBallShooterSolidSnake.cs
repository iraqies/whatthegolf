using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Core
{
	[Token(Token = "0x2001452")]
	public class GolfBallShooterSolidSnake : GolfBallShooterBase, IExplodable
	{
		[Serializable]
		[Token(Token = "0x2001453")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x4911C", Offset = "0x4911C")]
		private sealed class _003C_003Ec
		{
			[Token(Token = "0x4006E9E")]
			[FieldOffset(Offset = "0x0")]
			public static readonly _003C_003Ec _003C_003E9;

			[Token(Token = "0x4006E9F")]
			[FieldOffset(Offset = "0x8")]
			public static Action<float> _003C_003E9__30_0;

			[Token(Token = "0x6005F38")]
			[Address(RVA = "0x17B5538", Offset = "0x17B5538", VA = "0x17B5538")]
			public _003C_003Ec()
			{
			}

			[Token(Token = "0x6005F39")]
			[Address(RVA = "0x17B5540", Offset = "0x17B5540", VA = "0x17B5540")]
			internal void _003COnExplode_003Eb__30_0(float v)
			{
			}
		}

		[Token(Token = "0x4006E89")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		public float minShootVelocity;

		[Token(Token = "0x4006E8A")]
		[FieldOffset(Offset = "0x64")]
		[SerializeField]
		public float fullShootVelocity;

		[Token(Token = "0x4006E8B")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		public float pitch;

		[Token(Token = "0x4006E8C")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		public AnimationCurve powerToPitchWeightCurve;

		[Token(Token = "0x4006E8D")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		public float spin;

		[Token(Token = "0x4006E8E")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		public Transform box;

		[Token(Token = "0x4006E8F")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		public Animation boxAnimation;

		[Token(Token = "0x4006E90")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		protected bool lookInShotDirection;

		[Token(Token = "0x4006E91")]
		[FieldOffset(Offset = "0x91")]
		[SerializeField]
		protected bool lookInAimDirection;

		[Token(Token = "0x4006E92")]
		[FieldOffset(Offset = "0x92")]
		[SerializeField]
		protected bool useLocalUp;

		[Token(Token = "0x4006E93")]
		[FieldOffset(Offset = "0x93")]
		[SerializeField]
		public bool zeroPitchIfNotGrouneded;

		[Token(Token = "0x4006E94")]
		[FieldOffset(Offset = "0x94")]
		[SerializeField]
		public float blockTimeOnExplode;

		[Token(Token = "0x4006E95")]
		[FieldOffset(Offset = "0x98")]
		private BlockShotIfNotGrounded blocker;

		[Token(Token = "0x4006E96")]
		[FieldOffset(Offset = "0xA0")]
		private Vector3 lastBoost;

		[Token(Token = "0x4006E97")]
		[FieldOffset(Offset = "0xAC")]
		private Vector3 baseBoxPosition;

		[Token(Token = "0x4006E98")]
		[FieldOffset(Offset = "0xB8")]
		private float up;

		[Token(Token = "0x4006E99")]
		[FieldOffset(Offset = "0xC0")]
		public AnimationClip still;

		[Token(Token = "0x4006E9A")]
		[FieldOffset(Offset = "0xC8")]
		public AnimationClip walking;

		[Token(Token = "0x4006E9B")]
		[FieldOffset(Offset = "0xD0")]
		public bool isWalking;

		[Token(Token = "0x4006E9C")]
		[FieldOffset(Offset = "0xD1")]
		[SerializeField]
		private bool countStrokesOnAimUpdate;

		[Token(Token = "0x4006E9D")]
		[FieldOffset(Offset = "0xD2")]
		private bool isAiming;

		[Token(Token = "0x6005F2B")]
		[Address(RVA = "0x14985B4", Offset = "0x14985B4", VA = "0x14985B4", Slot = "11")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x6005F2C")]
		[Address(RVA = "0x149863C", Offset = "0x149863C", VA = "0x149863C")]
		private void Start()
		{
		}

		[Token(Token = "0x6005F2D")]
		[Address(RVA = "0x1498664", Offset = "0x1498664", VA = "0x1498664", Slot = "4")]
		public override void OnActivate()
		{
		}

		[Token(Token = "0x6005F2E")]
		[Address(RVA = "0x14986AC", Offset = "0x14986AC", VA = "0x14986AC", Slot = "6")]
		public override void OnAimUpdate(Vector3 boost, bool onlyAimArrow)
		{
		}

		[Token(Token = "0x6005F2F")]
		[Address(RVA = "0x1498854", Offset = "0x1498854", VA = "0x1498854", Slot = "8")]
		public override void OnCancel()
		{
		}

		[Token(Token = "0x6005F30")]
		[Address(RVA = "0x149887C", Offset = "0x149887C", VA = "0x149887C", Slot = "9")]
		public override void OnReset()
		{
		}

		[Token(Token = "0x6005F31")]
		[Address(RVA = "0x14988A4", Offset = "0x14988A4", VA = "0x14988A4", Slot = "12")]
		protected override void FixedUpdate()
		{
		}

		[Token(Token = "0x6005F32")]
		[Address(RVA = "0x1498A84", Offset = "0x1498A84", VA = "0x1498A84")]
		private void Update()
		{
		}

		[Token(Token = "0x6005F33")]
		[Address(RVA = "0x1498B84", Offset = "0x1498B84", VA = "0x1498B84", Slot = "7")]
		public override void OnShoot(Vector3 boost)
		{
		}

		[Token(Token = "0x6005F34")]
		[Address(RVA = "0x1498DF0", Offset = "0x1498DF0", VA = "0x1498DF0", Slot = "15")]
		public void OnExplode()
		{
		}

		[Token(Token = "0x6005F35")]
		[Address(RVA = "0x1499030", Offset = "0x1499030", VA = "0x1499030")]
		public GolfBallShooterSolidSnake()
		{
		}

		[Token(Token = "0x6005F36")]
		[Address(RVA = "0x14990A8", Offset = "0x14990A8", VA = "0x14990A8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x72E04", Offset = "0x72E04")]
		private void _003COnExplode_003Eb__30_1()
		{
		}
	}
}
