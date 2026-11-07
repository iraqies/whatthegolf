using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace Core
{
	[Token(Token = "0x2001425")]
	public class SwimmerShooter : GolfBallShooterBase
	{
		[Token(Token = "0x4006CB3")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		public float minShootVelocity;

		[Token(Token = "0x4006CB4")]
		[FieldOffset(Offset = "0x64")]
		[SerializeField]
		public float fullShootVelocity;

		[Token(Token = "0x4006CB5")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		public float pitch;

		[Token(Token = "0x4006CB6")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		public AnimationCurve powerToPitchWeightCurve;

		[Token(Token = "0x4006CB7")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		public float spin;

		[Token(Token = "0x4006CB8")]
		[FieldOffset(Offset = "0x7C")]
		[SerializeField]
		protected bool lookInShotDirection;

		[Token(Token = "0x4006CB9")]
		[FieldOffset(Offset = "0x7D")]
		public bool lookInAimDirection;

		[Token(Token = "0x4006CBA")]
		[FieldOffset(Offset = "0x7E")]
		[SerializeField]
		protected bool onlyLookWhenChargingOnController;

		[Token(Token = "0x4006CBB")]
		[FieldOffset(Offset = "0x80")]
		public float LookInAimDirectionSpeed;

		[Token(Token = "0x4006CBC")]
		[FieldOffset(Offset = "0x84")]
		[SerializeField]
		protected bool dontLookInAimDirectionWhenBlocked;

		[Token(Token = "0x4006CBD")]
		[FieldOffset(Offset = "0x85")]
		[SerializeField]
		protected bool useLocalUp;

		[Token(Token = "0x4006CBE")]
		[FieldOffset(Offset = "0x86")]
		[SerializeField]
		public bool zeroPitchIfNotGrouneded;

		[Token(Token = "0x4006CBF")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private Transform body;

		[Token(Token = "0x4006CC0")]
		[FieldOffset(Offset = "0x90")]
		private Quaternion startBodyRotation;

		[Token(Token = "0x4006CC1")]
		[FieldOffset(Offset = "0xA0")]
		private Vector3 startBodyLocalPosition;

		[Token(Token = "0x4006CC2")]
		[FieldOffset(Offset = "0xAC")]
		[SerializeField]
		[Attribute(Name = "RangeAttribute", RVA = "0x5B644", Offset = "0x5B644")]
		private float moveMaxTilt;

		[Token(Token = "0x4006CC3")]
		[FieldOffset(Offset = "0xB0")]
		[SerializeField]
		private float moveTiltSpeed;

		[Token(Token = "0x4006CC4")]
		[FieldOffset(Offset = "0xB4")]
		[SerializeField]
		private float maxTiltAngle;

		[Token(Token = "0x4006CC5")]
		[FieldOffset(Offset = "0xB8")]
		[SerializeField]
		private float speedToTiltNormalizer;

		[Token(Token = "0x4006CC6")]
		[FieldOffset(Offset = "0xC0")]
		private Transform t;

		[Token(Token = "0x4006CC7")]
		[FieldOffset(Offset = "0xC8")]
		[SerializeField]
		private AnimationCurve speedToStaticBuoyancyCurve;

		[Token(Token = "0x4006CC8")]
		[FieldOffset(Offset = "0xD0")]
		[SerializeField]
		private float staticBuoyancyBounceAmplitude;

		[Token(Token = "0x4006CC9")]
		[FieldOffset(Offset = "0xD4")]
		[SerializeField]
		private float staticBuoyancyBounceFrequency;

		[Token(Token = "0x4006CCA")]
		[FieldOffset(Offset = "0xD8")]
		[SerializeField]
		private List<AudioClip> splashSfx;

		[Token(Token = "0x4006CCB")]
		[FieldOffset(Offset = "0xE0")]
		[SerializeField]
		private float minDelayBetweenSplashes;

		[Token(Token = "0x4006CCC")]
		[FieldOffset(Offset = "0xE4")]
		[SerializeField]
		private float maxDelayBetweenSplashes;

		[Token(Token = "0x4006CCD")]
		[FieldOffset(Offset = "0xE8")]
		[SerializeField]
		private float speedToSplashDelayNormalizer;

		[Token(Token = "0x4006CCE")]
		[FieldOffset(Offset = "0xF0")]
		[SerializeField]
		private AudioSource audioPlayer;

		[Token(Token = "0x4006CCF")]
		[FieldOffset(Offset = "0xF8")]
		[SerializeField]
		private float minSplashingSpeed;

		[Token(Token = "0x4006CD0")]
		[FieldOffset(Offset = "0xFC")]
		private float lastSplashSfxTime;

		[Token(Token = "0x4006CD1")]
		[FieldOffset(Offset = "0x100")]
		[SerializeField]
		private float minSplashVolume;

		[Token(Token = "0x4006CD2")]
		[FieldOffset(Offset = "0x104")]
		[SerializeField]
		private float maxSplashVolume;

		[Token(Token = "0x4006CD3")]
		[FieldOffset(Offset = "0x108")]
		[SerializeField]
		private float speedToSplashVolumeNormalizer;

		[Token(Token = "0x4006CD4")]
		[FieldOffset(Offset = "0x10C")]
		[SerializeField]
		private float minSplashPitch;

		[Token(Token = "0x4006CD5")]
		[FieldOffset(Offset = "0x110")]
		[SerializeField]
		private float maxSplashVPitch;

		[Token(Token = "0x4006CD6")]
		[FieldOffset(Offset = "0x118")]
		[SerializeField]
		private Animator anim;

		[Token(Token = "0x4006CD7")]
		[FieldOffset(Offset = "0x120")]
		[SerializeField]
		private float animationMaxSpeed;

		[Token(Token = "0x4006CD8")]
		[FieldOffset(Offset = "0x128")]
		private string animParameterName;

		[Token(Token = "0x4006CD9")]
		[FieldOffset(Offset = "0x130")]
		private bool isPlayingCoolAnimation;

		[Token(Token = "0x4006CDA")]
		[FieldOffset(Offset = "0x131")]
		private bool hasShotAtLeastOnce;

		[Token(Token = "0x4006CDB")]
		[FieldOffset(Offset = "0x134")]
		private int lastAnimIndex;

		[Token(Token = "0x4006CDC")]
		[FieldOffset(Offset = "0x138")]
		private int[] animSequence;

		[Token(Token = "0x6005DBA")]
		[Address(RVA = "0x16F10AC", Offset = "0x16F10AC", VA = "0x16F10AC", Slot = "11")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x6005DBB")]
		[Address(RVA = "0x16F1148", Offset = "0x16F1148", VA = "0x16F1148", Slot = "4")]
		public override void OnActivate()
		{
		}

		[Token(Token = "0x6005DBC")]
		[Address(RVA = "0x16F1180", Offset = "0x16F1180", VA = "0x16F1180", Slot = "6")]
		public override void OnAimUpdate(Vector3 boost, bool onlyAimArrow)
		{
		}

		[Token(Token = "0x6005DBD")]
		[Address(RVA = "0x16F1350", Offset = "0x16F1350", VA = "0x16F1350", Slot = "7")]
		public override void OnShoot(Vector3 boost)
		{
		}

		[Token(Token = "0x6005DBE")]
		[Address(RVA = "0x16F15D4", Offset = "0x16F15D4", VA = "0x16F15D4")]
		public new void FixedUpdate()
		{
		}

		[Token(Token = "0x6005DBF")]
		[Address(RVA = "0x16F1930", Offset = "0x16F1930", VA = "0x16F1930")]
		private void Update()
		{
		}

		[Token(Token = "0x6005DC0")]
		[Address(RVA = "0x16F1AC4", Offset = "0x16F1AC4", VA = "0x16F1AC4")]
		public SwimmerShooter()
		{
		}
	}
}
