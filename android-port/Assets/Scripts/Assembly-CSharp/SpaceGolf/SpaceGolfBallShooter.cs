using System;
using System.Collections.Generic;
using Audio;
using Audio.Rumble;
using Core;
using GolfCourse;
using Il2CppDummyDll;
using UnityEngine;

namespace SpaceGolf
{
	[Token(Token = "0x20010AB")]
	public class SpaceGolfBallShooter : GolfBallShooterBase
	{
		[Token(Token = "0x20010AC")]
		private struct TrajectoryPoint
		{
			[Token(Token = "0x40057D8")]
			[FieldOffset(Offset = "0x0")]
			public float time;

			[Token(Token = "0x40057D9")]
			[FieldOffset(Offset = "0x4")]
			public Vector3 point;

			[Token(Token = "0x40057DA")]
			[FieldOffset(Offset = "0x10")]
			public bool outOfBounds;

			[Token(Token = "0x40057DB")]
			[FieldOffset(Offset = "0x11")]
			public bool goal;
		}

		[Token(Token = "0x20010AD")]
		private struct Step
		{
			[Token(Token = "0x40057DC")]
			[FieldOffset(Offset = "0x0")]
			public Vector3 position;

			[Token(Token = "0x40057DD")]
			[FieldOffset(Offset = "0xC")]
			public Vector3 velocity;

			[Token(Token = "0x40057DE")]
			[FieldOffset(Offset = "0x18")]
			public bool run;

			[Token(Token = "0x40057DF")]
			[FieldOffset(Offset = "0x19")]
			public bool isGoal;

			[Token(Token = "0x40057E0")]
			[FieldOffset(Offset = "0x1A")]
			public bool isOut;

			[Token(Token = "0x40057E1")]
			[FieldOffset(Offset = "0x1B")]
			public bool isGrounded;

			[Token(Token = "0x40057E2")]
			[FieldOffset(Offset = "0x20")]
			public Planet groundedPlanet;

			[Token(Token = "0x40057E3")]
			[FieldOffset(Offset = "0x28")]
			public Vector3 groundedPlanetOffset;

			[Token(Token = "0x40057E4")]
			[FieldOffset(Offset = "0x34")]
			public float sampleRate;

			[Token(Token = "0x40057E5")]
			[FieldOffset(Offset = "0x38")]
			public bool isBounce;
		}

		[Serializable]
		[Token(Token = "0x20010AE")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x47B04", Offset = "0x47B04")]
		private sealed class _003C_003Ec
		{
			[Token(Token = "0x40057E6")]
			[FieldOffset(Offset = "0x0")]
			public static readonly _003C_003Ec _003C_003E9;

			[Token(Token = "0x40057E7")]
			[FieldOffset(Offset = "0x8")]
			public static Func<TrajectoryPoint, Vector3> _003C_003E9__38_0;

			[Token(Token = "0x6004ACF")]
			[Address(RVA = "0x1852E40", Offset = "0x1852E40", VA = "0x1852E40")]
			public _003C_003Ec()
			{
			}

			[Token(Token = "0x6004AD0")]
			[Address(RVA = "0x1852E48", Offset = "0x1852E48", VA = "0x1852E48")]
			internal Vector3 _003CProject_003Eb__38_0(TrajectoryPoint point)
			{
				return default;
			}
		}

		[Token(Token = "0x40057BF")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private bool isVisual;

		[Token(Token = "0x40057C0")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private LineRenderer trajectoryProjectionPrefab;

		[Token(Token = "0x40057C1")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private bool liveTrajectory;

		[Token(Token = "0x40057C2")]
		[FieldOffset(Offset = "0x74")]
		[SerializeField]
		private float fullShootVelocity;

		[Token(Token = "0x40057C3")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private float minShootVelocity;

		[Token(Token = "0x40057C4")]
		[FieldOffset(Offset = "0x7C")]
		[SerializeField]
		private float sampleRate;

		[Token(Token = "0x40057C5")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private float terminationVelocity;

		[Token(Token = "0x40057C6")]
		[FieldOffset(Offset = "0x84")]
		[SerializeField]
		private bool debug;

		[Token(Token = "0x40057C7")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private float bounce;

		[Token(Token = "0x40057C8")]
		[FieldOffset(Offset = "0x8C")]
		[SerializeField]
		private float simulatedTime;

		[Token(Token = "0x40057C9")]
		[FieldOffset(Offset = "0x90")]
		public OnCollisionAudio bounceCollisionSFX;

		[Token(Token = "0x40057CA")]
		[FieldOffset(Offset = "0x98")]
		public float test;

		[Token(Token = "0x40057CB")]
		[FieldOffset(Offset = "0xA0")]
		private List<Planet> planets;

		[Token(Token = "0x40057CC")]
		[FieldOffset(Offset = "0xA8")]
		private LineRenderer trajectoryProjection;

		[Token(Token = "0x40057CD")]
		[FieldOffset(Offset = "0xB0")]
		private float shootTime;

		[Token(Token = "0x40057CE")]
		[FieldOffset(Offset = "0xB8")]
		private TrajectoryPoint[] trajectory;

		[Token(Token = "0x40057CF")]
		[FieldOffset(Offset = "0xC0")]
		private int index;

		[Token(Token = "0x40057D0")]
		[FieldOffset(Offset = "0xC4")]
		private float ballRadius;

		[Token(Token = "0x40057D1")]
		[FieldOffset(Offset = "0xC8")]
		private Step liveStep;

		[Token(Token = "0x40057D2")]
		[FieldOffset(Offset = "0x108")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x55DA0", Offset = "0x55DA0")]
		private bool isGrounded__BackingField;

		[Token(Token = "0x40057D3")]
		[FieldOffset(Offset = "0x109")]
		private bool didWin;

		[Token(Token = "0x40057D4")]
		[FieldOffset(Offset = "0x110")]
		private GolfCoursePinGoal pinGoal;

		[Token(Token = "0x40057D5")]
		[FieldOffset(Offset = "0x118")]
		private float minBoost;

		[Token(Token = "0x40057D6")]
		[FieldOffset(Offset = "0x11C")]
		private bool aimAtPlanet;

		[Token(Token = "0x40057D7")]
		[FieldOffset(Offset = "0x120")]
		private RumbleOnImpact rumbleImpact;

		[Token(Token = "0x170007E6")]
		public bool isGrounded
		{
			[Token(Token = "0x6004ABB")]
			[Address(RVA = "0x16C16C0", Offset = "0x16C16C0", VA = "0x16C16C0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6F754", Offset = "0x6F754")]
			get
			{
				return default;
			}
			[Token(Token = "0x6004ABC")]
			[Address(RVA = "0x16C16C8", Offset = "0x16C16C8", VA = "0x16C16C8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6F764", Offset = "0x6F764")]
			private set
			{
			}
		}

		[Token(Token = "0x170007E7")]
		public Vector3 BallVelocity
		{
			[Token(Token = "0x6004ABD")]
			[Address(RVA = "0x16C16D0", Offset = "0x16C16D0", VA = "0x16C16D0")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x6004ABE")]
		[Address(RVA = "0x16C16DC", Offset = "0x16C16DC", VA = "0x16C16DC", Slot = "11")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x6004ABF")]
		[Address(RVA = "0x16C17CC", Offset = "0x16C17CC", VA = "0x16C17CC")]
		public void SetPlanets(List<Planet> _planets)
		{
		}

		[Token(Token = "0x6004AC0")]
		[Address(RVA = "0x16C1854", Offset = "0x16C1854", VA = "0x16C1854")]
		private void Start()
		{
		}

		[Token(Token = "0x6004AC1")]
		[Address(RVA = "0x16C1A20", Offset = "0x16C1A20", VA = "0x16C1A20")]
		private void ProbActive(bool active)
		{
		}

		[Token(Token = "0x6004AC2")]
		[Address(RVA = "0x16C1AD0", Offset = "0x16C1AD0", VA = "0x16C1AD0", Slot = "5")]
		public override void OnAimStart()
		{
		}

		[Token(Token = "0x6004AC3")]
		[Address(RVA = "0x16C1AFC", Offset = "0x16C1AFC", VA = "0x16C1AFC", Slot = "6")]
		public override void OnAimUpdate(Vector3 boost, bool onlyAimArrow)
		{
		}

		[Token(Token = "0x6004AC4")]
		[Address(RVA = "0x16C1CD8", Offset = "0x16C1CD8", VA = "0x16C1CD8")]
		private void Project(Vector3 boost)
		{
		}

		[Token(Token = "0x6004AC5")]
		[Address(RVA = "0x16C23D0", Offset = "0x16C23D0", VA = "0x16C23D0", Slot = "7")]
		public override void OnShoot(Vector3 boost)
		{
		}

		[Token(Token = "0x6004AC6")]
		[Address(RVA = "0x16C25A8", Offset = "0x16C25A8", VA = "0x16C25A8")]
		private void Update()
		{
		}

		[Token(Token = "0x6004AC7")]
		[Address(RVA = "0x16C1EF0", Offset = "0x16C1EF0", VA = "0x16C1EF0")]
		private TrajectoryPoint[] CalculateTrajectory(Vector3 boost, float maxTime = -1f, bool stopOnCollision = false)
		{
			return null;
		}

		[Token(Token = "0x6004AC8")]
		[Address(RVA = "0x16C2C70", Offset = "0x16C2C70", VA = "0x16C2C70")]
		private Step CalculateStep(Step step)
		{
			return default;
		}

		[Token(Token = "0x6004AC9")]
		[Address(RVA = "0x16C344C", Offset = "0x16C344C", VA = "0x16C344C")]
		private Vector3 CalcGravity(Vector3 ballPosition)
		{
			return default;
		}

		[Token(Token = "0x6004ACA")]
		[Address(RVA = "0x16C332C", Offset = "0x16C332C", VA = "0x16C332C")]
		private bool IsOutOfBounds(Vector3 ballPosition)
		{
			return default;
		}

		[Token(Token = "0x6004ACB")]
		[Address(RVA = "0x16C3544", Offset = "0x16C3544", VA = "0x16C3544", Slot = "9")]
		public override void OnReset()
		{
		}

		[Token(Token = "0x6004ACC")]
		[Address(RVA = "0x16C3570", Offset = "0x16C3570", VA = "0x16C3570", Slot = "13")]
		protected override bool IsBlocking()
		{
			return default;
		}

		[Token(Token = "0x6004ACD")]
		[Address(RVA = "0x16C35B8", Offset = "0x16C35B8", VA = "0x16C35B8")]
		public SpaceGolfBallShooter()
		{
		}
	}
}
