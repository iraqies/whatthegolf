using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Events;

namespace Core
{
	[Token(Token = "0x2001468")]
	public class GalfBallShooterSneakStatue : GolfBallShooterBase, IExplodable
	{
		[Serializable]
		[Token(Token = "0x2001469")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x4914C", Offset = "0x4914C")]
		private sealed class _003C_003Ec
		{
			[Token(Token = "0x4006FCE")]
			[FieldOffset(Offset = "0x0")]
			public static readonly _003C_003Ec _003C_003E9;

			[Token(Token = "0x4006FCF")]
			[FieldOffset(Offset = "0x8")]
			public static Action<float> _003C_003E9__30_0;

			[Token(Token = "0x6005FFF")]
			[Address(RVA = "0x17AB080", Offset = "0x17AB080", VA = "0x17AB080")]
			public _003C_003Ec()
			{
			}

			[Token(Token = "0x6006000")]
			[Address(RVA = "0x17AB088", Offset = "0x17AB088", VA = "0x17AB088")]
			internal void _003COnExplode_003Eb__30_0(float v)
			{
			}
		}

		[Token(Token = "0x4006FB9")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		public Animator animator;

		[Token(Token = "0x4006FBA")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		public float minShootVelocity;

		[Token(Token = "0x4006FBB")]
		[FieldOffset(Offset = "0x6C")]
		[SerializeField]
		public float fullShootVelocity;

		[Token(Token = "0x4006FBC")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		public float pitch;

		[Token(Token = "0x4006FBD")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		public AnimationCurve powerToPitchWeightCurve;

		[Token(Token = "0x4006FBE")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		public float spin;

		[Token(Token = "0x4006FBF")]
		[FieldOffset(Offset = "0x84")]
		[SerializeField]
		protected bool lookInShotDirection;

		[Token(Token = "0x4006FC0")]
		[FieldOffset(Offset = "0x85")]
		[SerializeField]
		protected bool lookInAimDirection;

		[Token(Token = "0x4006FC1")]
		[FieldOffset(Offset = "0x86")]
		[SerializeField]
		protected bool useLocalUp;

		[Token(Token = "0x4006FC2")]
		[FieldOffset(Offset = "0x87")]
		[SerializeField]
		public bool zeroPitchIfNotGrouneded;

		[Token(Token = "0x4006FC3")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		public float blockTimeOnExplode;

		[Token(Token = "0x4006FC4")]
		[FieldOffset(Offset = "0x90")]
		public UnityEvent<bool> OnRun;

		[Token(Token = "0x4006FC5")]
		[FieldOffset(Offset = "0x98")]
		public UnityEvent OnStop;

		[Token(Token = "0x4006FC6")]
		[FieldOffset(Offset = "0xA0")]
		public UnityEvent OnExploded;

		[Token(Token = "0x4006FC7")]
		[FieldOffset(Offset = "0xA8")]
		private BlockShotIfNotGrounded blocker;

		[Token(Token = "0x4006FC8")]
		[FieldOffset(Offset = "0xB0")]
		private Vector3 lastBoost;

		[Token(Token = "0x4006FC9")]
		[FieldOffset(Offset = "0xBC")]
		private Vector3 baseBoxPosition;

		[Token(Token = "0x4006FCA")]
		[FieldOffset(Offset = "0xC8")]
		private float up;

		[Token(Token = "0x4006FCB")]
		[FieldOffset(Offset = "0xCC")]
		public bool isWalking;

		[Token(Token = "0x4006FCC")]
		[FieldOffset(Offset = "0xCD")]
		[SerializeField]
		private bool countStrokesOnAimUpdate;

		[Token(Token = "0x4006FCD")]
		[FieldOffset(Offset = "0xCE")]
		private bool isAiming;

		[Token(Token = "0x6005FF2")]
		[Address(RVA = "0x14768B8", Offset = "0x14768B8", VA = "0x14768B8", Slot = "11")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x6005FF3")]
		[Address(RVA = "0x1476920", Offset = "0x1476920", VA = "0x1476920")]
		private void Start()
		{
		}

		[Token(Token = "0x6005FF4")]
		[Address(RVA = "0x1476948", Offset = "0x1476948", VA = "0x1476948", Slot = "4")]
		public override void OnActivate()
		{
		}

		[Token(Token = "0x6005FF5")]
		[Address(RVA = "0x1476950", Offset = "0x1476950", VA = "0x1476950", Slot = "6")]
		public override void OnAimUpdate(Vector3 boost, bool onlyAimArrow)
		{
		}

		[Token(Token = "0x6005FF6")]
		[Address(RVA = "0x1476AD8", Offset = "0x1476AD8", VA = "0x1476AD8", Slot = "8")]
		public override void OnCancel()
		{
		}

		[Token(Token = "0x6005FF7")]
		[Address(RVA = "0x1476B00", Offset = "0x1476B00", VA = "0x1476B00", Slot = "9")]
		public override void OnReset()
		{
		}

		[Token(Token = "0x6005FF8")]
		[Address(RVA = "0x1476B28", Offset = "0x1476B28", VA = "0x1476B28", Slot = "12")]
		protected override void FixedUpdate()
		{
		}

		[Token(Token = "0x6005FF9")]
		[Address(RVA = "0x1476C80", Offset = "0x1476C80", VA = "0x1476C80")]
		private void Update()
		{
		}

		[Token(Token = "0x6005FFA")]
		[Address(RVA = "0x1476D68", Offset = "0x1476D68", VA = "0x1476D68", Slot = "7")]
		public override void OnShoot(Vector3 boost)
		{
		}

		[Token(Token = "0x6005FFB")]
		[Address(RVA = "0x1476FDC", Offset = "0x1476FDC", VA = "0x1476FDC", Slot = "15")]
		public void OnExplode()
		{
		}

		[Token(Token = "0x6005FFC")]
		[Address(RVA = "0x1477230", Offset = "0x1477230", VA = "0x1477230")]
		public GalfBallShooterSneakStatue()
		{
		}

		[Token(Token = "0x6005FFD")]
		[Address(RVA = "0x1477284", Offset = "0x1477284", VA = "0x1477284")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x72EF4", Offset = "0x72EF4")]
		private void _003COnExplode_003Eb__30_1()
		{
		}
	}
}
