using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;

namespace Puzzle
{
	[Token(Token = "0x2001034")]
	public class LazerJoint : MonoBehaviour
	{
		[Token(Token = "0x4005563")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public LineRenderer line;

		[Token(Token = "0x4005564")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float width;

		[Token(Token = "0x4005565")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public LayerMask layerMask;

		[Token(Token = "0x4005566")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float length;

		[Token(Token = "0x4005567")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public ParticleSystem particles;

		[Token(Token = "0x4005568")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public bool emit;

		[Token(Token = "0x4005569")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private Vector3 emitDirection;

		[Token(Token = "0x400556A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private float nextBallhit;

		[Token(Token = "0x400556B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private Vector3 emitPosition;

		[Token(Token = "0x400556C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private PuzzleSwitchLaser laserSwitch;

		[Token(Token = "0x400556D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public SimplePortal enterPortal;

		[Token(Token = "0x400556E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public SimplePortal exitPortal;

		[Token(Token = "0x600488D")]
		[Address(RVA = "0x151F28C", Offset = "0x151F28C", VA = "0x151F28C")]
		public void Init(Vector3 startpos, Quaternion rotation, [Optional] SimplePortal enterPortal)
		{
		}

		[Token(Token = "0x600488E")]
		[Address(RVA = "0x151F338", Offset = "0x151F338", VA = "0x151F338")]
		private void Update()
		{
		}

		[Token(Token = "0x600488F")]
		[Address(RVA = "0x151F408", Offset = "0x151F408", VA = "0x151F408")]
		public void SetJointEmission(bool emit)
		{
		}

		[Token(Token = "0x6004890")]
		[Address(RVA = "0x151F4E8", Offset = "0x151F4E8", VA = "0x151F4E8")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x6004891")]
		[Address(RVA = "0x151F914", Offset = "0x151F914", VA = "0x151F914")]
		private void HandleHit(RaycastHit2D hit)
		{
		}

		[Token(Token = "0x6004892")]
		[Address(RVA = "0x151FCC0", Offset = "0x151FCC0", VA = "0x151FCC0")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6004893")]
		[Address(RVA = "0x151FD68", Offset = "0x151FD68", VA = "0x151FD68")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6004894")]
		[Address(RVA = "0x151FE10", Offset = "0x151FE10", VA = "0x151FE10")]
		public LazerJoint()
		{
		}
	}
}
