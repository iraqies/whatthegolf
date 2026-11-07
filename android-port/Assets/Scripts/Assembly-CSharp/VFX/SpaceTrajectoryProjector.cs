using Core;
using Il2CppDummyDll;
using SpaceGolf;
using UnityEngine;

namespace VFX
{
	[Token(Token = "0x200101E")]
	public class SpaceTrajectoryProjector : MonoBehaviour
	{
		[Token(Token = "0x40054F7")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private LineRenderer trajectoryProjectionPrefab;

		[Token(Token = "0x40054F8")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private float fullShootVelocity;

		[Token(Token = "0x40054F9")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		private float pitch;

		[Token(Token = "0x40054FA")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private float ballRadius;

		[Token(Token = "0x40054FB")]
		[FieldOffset(Offset = "0x2C")]
		[SerializeField]
		private int maxSamples;

		[Token(Token = "0x40054FC")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private float sampleRate;

		[Token(Token = "0x40054FD")]
		[FieldOffset(Offset = "0x34")]
		[SerializeField]
		private bool debug;

		[Token(Token = "0x40054FE")]
		[FieldOffset(Offset = "0x38")]
		private LineRenderer trajectoryProjection;

		[Token(Token = "0x40054FF")]
		[FieldOffset(Offset = "0x40")]
		private LineRenderer circle;

		[Token(Token = "0x4005500")]
		[FieldOffset(Offset = "0x48")]
		private GolfBallController golfBallController;

		[Token(Token = "0x4005501")]
		[FieldOffset(Offset = "0x50")]
		private ConstantForce constantForce;

		[Token(Token = "0x4005502")]
		[FieldOffset(Offset = "0x58")]
		private Rigidbody rigidbody;

		[Token(Token = "0x4005503")]
		[FieldOffset(Offset = "0x60")]
		private Planet[] planets;

		[Token(Token = "0x4005504")]
		[FieldOffset(Offset = "0x68")]
		private Vector3 prev;

		[Token(Token = "0x6004803")]
		[Address(RVA = "0x16C3600", Offset = "0x16C3600", VA = "0x16C3600")]
		private void Awake()
		{
		}

		[Token(Token = "0x6004804")]
		[Address(RVA = "0x16C38EC", Offset = "0x16C38EC", VA = "0x16C38EC")]
		private void Update()
		{
		}

		[Token(Token = "0x6004805")]
		[Address(RVA = "0x16C3A10", Offset = "0x16C3A10", VA = "0x16C3A10")]
		private void OnCollisionEnter(Collision collision)
		{
		}

		[Token(Token = "0x6004806")]
		[Address(RVA = "0x16C388C", Offset = "0x16C388C", VA = "0x16C388C")]
		private void ProbActive(bool active)
		{
		}

		[Token(Token = "0x6004807")]
		[Address(RVA = "0x16C3B58", Offset = "0x16C3B58", VA = "0x16C3B58")]
		private void OnAim(Vector3 boost)
		{
		}

		[Token(Token = "0x6004808")]
		[Address(RVA = "0x16C41DC", Offset = "0x16C41DC", VA = "0x16C41DC")]
		private Vector3 CalcGravity(Vector3 ballPosition)
		{
			return default;
		}

		[Token(Token = "0x6004809")]
		[Address(RVA = "0x16C406C", Offset = "0x16C406C", VA = "0x16C406C")]
		private void DrawCircle(Vector3 worldPosition)
		{
		}

		[Token(Token = "0x600480A")]
		[Address(RVA = "0x16C4418", Offset = "0x16C4418", VA = "0x16C4418")]
		public SpaceTrajectoryProjector()
		{
		}

		[Token(Token = "0x600480B")]
		[Address(RVA = "0x16C4440", Offset = "0x16C4440", VA = "0x16C4440")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x6EE34", Offset = "0x6EE34")]
		private void _003CAwake_003Eb__13_0(Vector3 boost, bool isCancelled)
		{
		}

		[Token(Token = "0x600480C")]
		[Address(RVA = "0x16C44B4", Offset = "0x16C44B4", VA = "0x16C44B4")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x6EE44", Offset = "0x6EE44")]
		private void _003CAwake_003Eb__13_1(Vector3 boost)
		{
		}

		[Token(Token = "0x600480D")]
		[Address(RVA = "0x16C44C8", Offset = "0x16C44C8", VA = "0x16C44C8")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x6EE54", Offset = "0x6EE54")]
		private void _003CAwake_003Eb__13_2()
		{
		}
	}
}
