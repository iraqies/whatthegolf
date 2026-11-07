using Il2CppDummyDll;
using RootMotion.FinalIK;
using UnityEngine;

namespace RootMotion.Demos
{
	[Token(Token = "0x200020A")]
	[Attribute(Name = "RequireComponent", RVA = "0x33C64", Offset = "0x33C64")]
	public class PendulumExample : MonoBehaviour
	{
		[Token(Token = "0x4000DAF")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "RangeAttribute", RVA = "0x36D10", Offset = "0x36D10")]
		public float weight;

		[Token(Token = "0x4000DB0")]
		[FieldOffset(Offset = "0x1C")]
		public float hangingDistanceMlp;

		[Token(Token = "0x4000DB1")]
		[FieldOffset(Offset = "0x20")]
		public Vector3 rootTargetPosition;

		[Token(Token = "0x4000DB2")]
		[FieldOffset(Offset = "0x2C")]
		public Quaternion rootTargetRotation;

		[Token(Token = "0x4000DB3")]
		[FieldOffset(Offset = "0x40")]
		public Transform target;

		[Token(Token = "0x4000DB4")]
		[FieldOffset(Offset = "0x48")]
		public Transform leftHandTarget;

		[Token(Token = "0x4000DB5")]
		[FieldOffset(Offset = "0x50")]
		public Transform rightHandTarget;

		[Token(Token = "0x4000DB6")]
		[FieldOffset(Offset = "0x58")]
		public Transform leftFootTarget;

		[Token(Token = "0x4000DB7")]
		[FieldOffset(Offset = "0x60")]
		public Transform rightFootTarget;

		[Token(Token = "0x4000DB8")]
		[FieldOffset(Offset = "0x68")]
		public Transform pelvisTarget;

		[Token(Token = "0x4000DB9")]
		[FieldOffset(Offset = "0x70")]
		public Transform bodyTarget;

		[Token(Token = "0x4000DBA")]
		[FieldOffset(Offset = "0x78")]
		public Transform headTarget;

		[Token(Token = "0x4000DBB")]
		[FieldOffset(Offset = "0x80")]
		public Vector3 pelvisDownAxis;

		[Token(Token = "0x4000DBC")]
		[FieldOffset(Offset = "0x90")]
		private FullBodyBipedIK ik;

		[Token(Token = "0x4000DBD")]
		[FieldOffset(Offset = "0x98")]
		private Quaternion rootRelativeToPelvis;

		[Token(Token = "0x4000DBE")]
		[FieldOffset(Offset = "0xA8")]
		private Vector3 pelvisToRoot;

		[Token(Token = "0x4000DBF")]
		[FieldOffset(Offset = "0xB4")]
		private float lastWeight;

		[Token(Token = "0x6000E2D")]
		[Address(RVA = "0x13BDA88", Offset = "0x13BDA88", VA = "0x13BDA88")]
		private void Start()
		{
		}

		[Token(Token = "0x6000E2E")]
		[Address(RVA = "0x13BDD44", Offset = "0x13BDD44", VA = "0x13BDD44")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000E2F")]
		[Address(RVA = "0x13BE378", Offset = "0x13BE378", VA = "0x13BE378")]
		public PendulumExample()
		{
		}
	}
}
