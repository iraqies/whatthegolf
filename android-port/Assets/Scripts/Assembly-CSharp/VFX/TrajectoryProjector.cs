using System.Collections.Generic;
using Core;
using Il2CppDummyDll;
using UnityEngine;

namespace VFX
{
	[Token(Token = "0x200101F")]
	public class TrajectoryProjector : MonoBehaviour
	{
		[Token(Token = "0x4005505")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private LineRenderer trajectoryProjectionPrefab;

		[Token(Token = "0x4005506")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private bool copyShootVelocityFromShooter;

		[Token(Token = "0x4005507")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		private float fullShootVelocity;

		[Token(Token = "0x4005508")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private float pitch;

		[Token(Token = "0x4005509")]
		[FieldOffset(Offset = "0x2C")]
		[SerializeField]
		private float ballRadius;

		[Token(Token = "0x400550A")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private int maxSamples;

		[Token(Token = "0x400550B")]
		[FieldOffset(Offset = "0x34")]
		[SerializeField]
		private float sampleRate;

		[Token(Token = "0x400550C")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private float lineLength;

		[Token(Token = "0x400550D")]
		[FieldOffset(Offset = "0x3C")]
		[SerializeField]
		private float lineWidth;

		[Token(Token = "0x400550E")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private bool debug;

		[Token(Token = "0x400550F")]
		[FieldOffset(Offset = "0x44")]
		[SerializeField]
		private LayerMask collideLayers;

		[Token(Token = "0x4005510")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private float circleRadius;

		[Token(Token = "0x4005511")]
		[FieldOffset(Offset = "0x4C")]
		[SerializeField]
		private bool normalizeBoost;

		[Token(Token = "0x4005512")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private GolfBallController controllerOverride;

		[Token(Token = "0x4005513")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private GolfBallShooterExperimental shooterOverride;

		[Token(Token = "0x4005514")]
		[FieldOffset(Offset = "0x60")]
		private LineRenderer trajectoryProjection;

		[Token(Token = "0x4005515")]
		[FieldOffset(Offset = "0x68")]
		private LineRenderer circle;

		[Token(Token = "0x4005516")]
		[FieldOffset(Offset = "0x70")]
		private GolfBallController golfBallController;

		[Token(Token = "0x4005517")]
		[FieldOffset(Offset = "0x78")]
		private ConstantForce constantForce;

		[Token(Token = "0x4005518")]
		[FieldOffset(Offset = "0x80")]
		private Rigidbody rigidbody;

		[Token(Token = "0x4005519")]
		[FieldOffset(Offset = "0x88")]
		private GolfBallShooterExperimental golfBallShooterExperimental;

		[Token(Token = "0x400551A")]
		[FieldOffset(Offset = "0x90")]
		private float lineLengthSqr;

		[Token(Token = "0x400551B")]
		[FieldOffset(Offset = "0x98")]
		private List<Collider> ignoredObjects;

		[Token(Token = "0x400551C")]
		[FieldOffset(Offset = "0xA0")]
		private Vector3 prev;

		[Token(Token = "0x600480E")]
		[Address(RVA = "0x17298CC", Offset = "0x17298CC", VA = "0x17298CC", Slot = "4")]
		protected virtual void Awake()
		{
		}

		[Token(Token = "0x600480F")]
		[Address(RVA = "0x1729C04", Offset = "0x1729C04", VA = "0x1729C04", Slot = "5")]
		protected virtual void Start()
		{
		}

		[Token(Token = "0x6004810")]
		[Address(RVA = "0x1729DFC", Offset = "0x1729DFC", VA = "0x1729DFC")]
		public void AddIgnoreObject(Collider go)
		{
		}

		[Token(Token = "0x6004811")]
		[Address(RVA = "0x1729E9C", Offset = "0x1729E9C", VA = "0x1729E9C")]
		public void RemoveIgnoreObject(Collider go)
		{
		}

		[Token(Token = "0x6004812")]
		[Address(RVA = "0x1729F3C", Offset = "0x1729F3C", VA = "0x1729F3C")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x6004813")]
		[Address(RVA = "0x1729F40", Offset = "0x1729F40", VA = "0x1729F40")]
		private void Update()
		{
		}

		[Token(Token = "0x6004814")]
		[Address(RVA = "0x172A064", Offset = "0x172A064", VA = "0x172A064")]
		private void OnCollisionEnter(Collision collision)
		{
		}

		[Token(Token = "0x6004815")]
		[Address(RVA = "0x1729CEC", Offset = "0x1729CEC", VA = "0x1729CEC")]
		private void ProbActive(bool active)
		{
		}

		[Token(Token = "0x6004816")]
		[Address(RVA = "0x172A1AC", Offset = "0x172A1AC", VA = "0x172A1AC")]
		private void OnAim(Vector3 boost)
		{
		}

		[Token(Token = "0x6004817")]
		[Address(RVA = "0x172AAE8", Offset = "0x172AAE8", VA = "0x172AAE8", Slot = "6")]
		protected virtual void OnDisable()
		{
		}

		[Token(Token = "0x6004818")]
		[Address(RVA = "0x172A934", Offset = "0x172A934", VA = "0x172A934")]
		private Vector3 CalcGravity(Vector3 ballPosition)
		{
			return default;
		}

		[Token(Token = "0x6004819")]
		[Address(RVA = "0x172A7B8", Offset = "0x172A7B8", VA = "0x172A7B8")]
		private void DrawCircle(Vector3 worldPosition)
		{
		}

		[Token(Token = "0x600481A")]
		[Address(RVA = "0x172ABE8", Offset = "0x172ABE8", VA = "0x172ABE8")]
		public TrajectoryProjector()
		{
		}

		[Token(Token = "0x600481B")]
		[Address(RVA = "0x172AC28", Offset = "0x172AC28", VA = "0x172AC28")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x6EE64", Offset = "0x6EE64")]
		private void _003CAwake_003Eb__23_0(Vector3 boost, bool isCancelled)
		{
		}

		[Token(Token = "0x600481C")]
		[Address(RVA = "0x172ACB0", Offset = "0x172ACB0", VA = "0x172ACB0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x6EE74", Offset = "0x6EE74")]
		private void _003CAwake_003Eb__23_1(Vector3 boost)
		{
		}

		[Token(Token = "0x600481D")]
		[Address(RVA = "0x172ACC4", Offset = "0x172ACC4", VA = "0x172ACC4")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x6EE84", Offset = "0x6EE84")]
		private void _003CAwake_003Eb__23_2()
		{
		}

		[Token(Token = "0x600481E")]
		[Address(RVA = "0x172ACCC", Offset = "0x172ACCC", VA = "0x172ACCC")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x6EE94", Offset = "0x6EE94")]
		private void _003CAwake_003Eb__23_3()
		{
		}
	}
}
