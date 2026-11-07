using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Events;

namespace Core
{
	[Token(Token = "0x200146A")]
	public class GolfBallShooterSolidSnakeAlive : GolfBallShooterBase, IExplodable
	{
		[Serializable]
		[Token(Token = "0x200146B")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x4915C", Offset = "0x4915C")]
		private sealed class _003C_003Ec
		{
			[Token(Token = "0x4006FE8")]
			[FieldOffset(Offset = "0x0")]
			public static readonly _003C_003Ec _003C_003E9;

			[Token(Token = "0x4006FE9")]
			[FieldOffset(Offset = "0x8")]
			public static Action<float> _003C_003E9__33_0;

			[Token(Token = "0x600600E")]
			[Address(RVA = "0x17B55A4", Offset = "0x17B55A4", VA = "0x17B55A4")]
			public _003C_003Ec()
			{
			}

			[Token(Token = "0x600600F")]
			[Address(RVA = "0x17B55AC", Offset = "0x17B55AC", VA = "0x17B55AC")]
			internal void _003COnExplode_003Eb__33_0(float v)
			{
			}
		}

		[Token(Token = "0x4006FD0")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		public float minShootVelocity;

		[Token(Token = "0x4006FD1")]
		[FieldOffset(Offset = "0x64")]
		[SerializeField]
		public float fullShootVelocity;

		[Token(Token = "0x4006FD2")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		public float pitch;

		[Token(Token = "0x4006FD3")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		public AnimationCurve powerToPitchWeightCurve;

		[Token(Token = "0x4006FD4")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		public float spin;

		[Token(Token = "0x4006FD5")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		public Transform box;

		[Token(Token = "0x4006FD6")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		public Animation boxAnimation;

		[Token(Token = "0x4006FD7")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		protected bool lookInShotDirection;

		[Token(Token = "0x4006FD8")]
		[FieldOffset(Offset = "0x91")]
		[SerializeField]
		protected bool lookInAimDirection;

		[Token(Token = "0x4006FD9")]
		[FieldOffset(Offset = "0x92")]
		[SerializeField]
		protected bool useLocalUp;

		[Token(Token = "0x4006FDA")]
		[FieldOffset(Offset = "0x93")]
		[SerializeField]
		public bool zeroPitchIfNotGrouneded;

		[Token(Token = "0x4006FDB")]
		[FieldOffset(Offset = "0x94")]
		[SerializeField]
		public float blockTimeOnExplode;

		[Token(Token = "0x4006FDC")]
		[FieldOffset(Offset = "0x98")]
		private BlockShotIfNotGrounded blocker;

		[Token(Token = "0x4006FDD")]
		[FieldOffset(Offset = "0xA0")]
		private Vector3 lastBoost;

		[Token(Token = "0x4006FDE")]
		[FieldOffset(Offset = "0xAC")]
		private Vector3 baseBoxPosition;

		[Token(Token = "0x4006FDF")]
		[FieldOffset(Offset = "0xB8")]
		private float up;

		[Token(Token = "0x4006FE0")]
		[FieldOffset(Offset = "0xBC")]
		public float animationSpeed;

		[Token(Token = "0x4006FE1")]
		[FieldOffset(Offset = "0xC0")]
		public AnimationClip still;

		[Token(Token = "0x4006FE2")]
		[FieldOffset(Offset = "0xC8")]
		public AnimationClip walking;

		[Token(Token = "0x4006FE3")]
		[FieldOffset(Offset = "0xD0")]
		public bool isWalking;

		[Token(Token = "0x4006FE4")]
		[FieldOffset(Offset = "0xD1")]
		[SerializeField]
		private bool countStrokesOnAimUpdate;

		[Token(Token = "0x4006FE5")]
		[FieldOffset(Offset = "0xD2")]
		private bool isAiming;

		[Token(Token = "0x4006FE6")]
		[FieldOffset(Offset = "0xD8")]
		public UnityEvent OnWalking;

		[Token(Token = "0x4006FE7")]
		[FieldOffset(Offset = "0xE0")]
		public UnityEvent OnStopped;

		[Token(Token = "0x6006001")]
		[Address(RVA = "0x14990C8", Offset = "0x14990C8", VA = "0x14990C8", Slot = "11")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x6006002")]
		[Address(RVA = "0x1499154", Offset = "0x1499154", VA = "0x1499154")]
		private void Start()
		{
		}

		[Token(Token = "0x6006003")]
		[Address(RVA = "0x149917C", Offset = "0x149917C", VA = "0x149917C", Slot = "4")]
		public override void OnActivate()
		{
		}

		[Token(Token = "0x6006004")]
		[Address(RVA = "0x14991C4", Offset = "0x14991C4", VA = "0x14991C4", Slot = "6")]
		public override void OnAimUpdate(Vector3 boost, bool onlyAimArrow)
		{
		}

		[Token(Token = "0x6006005")]
		[Address(RVA = "0x149934C", Offset = "0x149934C", VA = "0x149934C", Slot = "8")]
		public override void OnCancel()
		{
		}

		[Token(Token = "0x6006006")]
		[Address(RVA = "0x1499374", Offset = "0x1499374", VA = "0x1499374", Slot = "9")]
		public override void OnReset()
		{
		}

		[Token(Token = "0x6006007")]
		[Address(RVA = "0x149939C", Offset = "0x149939C", VA = "0x149939C", Slot = "12")]
		protected override void FixedUpdate()
		{
		}

		[Token(Token = "0x6006008")]
		[Address(RVA = "0x1499598", Offset = "0x1499598", VA = "0x1499598")]
		private void Update()
		{
		}

		[Token(Token = "0x6006009")]
		[Address(RVA = "0x1499698", Offset = "0x1499698", VA = "0x1499698", Slot = "7")]
		public override void OnShoot(Vector3 boost)
		{
		}

		[Token(Token = "0x600600A")]
		[Address(RVA = "0x149990C", Offset = "0x149990C", VA = "0x149990C", Slot = "15")]
		public void OnExplode()
		{
		}

		[Token(Token = "0x600600B")]
		[Address(RVA = "0x1499B50", Offset = "0x1499B50", VA = "0x1499B50")]
		public GolfBallShooterSolidSnakeAlive()
		{
		}

		[Token(Token = "0x600600C")]
		[Address(RVA = "0x1499BA4", Offset = "0x1499BA4", VA = "0x1499BA4")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x72F04", Offset = "0x72F04")]
		private void _003COnExplode_003Eb__33_1()
		{
		}
	}
}
