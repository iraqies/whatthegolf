using Il2CppDummyDll;
using UnityEngine;

namespace RootMotion.FinalIK
{
	[Token(Token = "0x2000147")]
	public class GrounderIK : Grounder
	{
		[Token(Token = "0x40007D5")]
		[FieldOffset(Offset = "0x40")]
		public IK[] legs;

		[Token(Token = "0x40007D6")]
		[FieldOffset(Offset = "0x48")]
		public Transform pelvis;

		[Token(Token = "0x40007D7")]
		[FieldOffset(Offset = "0x50")]
		public Transform characterRoot;

		[Token(Token = "0x40007D8")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "RangeAttribute", RVA = "0x35B50", Offset = "0x35B50")]
		public float rootRotationWeight;

		[Token(Token = "0x40007D9")]
		[FieldOffset(Offset = "0x5C")]
		public float rootRotationSpeed;

		[Token(Token = "0x40007DA")]
		[FieldOffset(Offset = "0x60")]
		public float maxRootRotationAngle;

		[Token(Token = "0x40007DB")]
		[FieldOffset(Offset = "0x68")]
		private Transform[] feet;

		[Token(Token = "0x40007DC")]
		[FieldOffset(Offset = "0x70")]
		private Quaternion[] footRotations;

		[Token(Token = "0x40007DD")]
		[FieldOffset(Offset = "0x78")]
		private Vector3 animatedPelvisLocalPosition;

		[Token(Token = "0x40007DE")]
		[FieldOffset(Offset = "0x84")]
		private Vector3 solvedPelvisLocalPosition;

		[Token(Token = "0x40007DF")]
		[FieldOffset(Offset = "0x90")]
		private int solvedFeet;

		[Token(Token = "0x40007E0")]
		[FieldOffset(Offset = "0x94")]
		private bool solved;

		[Token(Token = "0x40007E1")]
		[FieldOffset(Offset = "0x98")]
		private float lastWeight;

		[Token(Token = "0x40007E2")]
		[FieldOffset(Offset = "0xA0")]
		private Rigidbody characterRootRigidbody;

		[Token(Token = "0x60008E7")]
		[Address(RVA = "0x137C978", Offset = "0x137C978", VA = "0x137C978", Slot = "5")]
		[Attribute(Name = "ContextMenu", RVA = "0x39164", Offset = "0x39164")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x60008E8")]
		[Address(RVA = "0x137C9C0", Offset = "0x137C9C0", VA = "0x137C9C0", Slot = "6")]
		[Attribute(Name = "ContextMenu", RVA = "0x3919C", Offset = "0x3919C")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x60008E9")]
		[Address(RVA = "0x137CA08", Offset = "0x137CA08", VA = "0x137CA08", Slot = "4")]
		public override void ResetPosition()
		{
		}

		[Token(Token = "0x60008EA")]
		[Address(RVA = "0x137CA24", Offset = "0x137CA24", VA = "0x137CA24")]
		private bool IsReadyToInitiate()
		{
			return default;
		}

		[Token(Token = "0x60008EB")]
		[Address(RVA = "0x137CC84", Offset = "0x137CC84", VA = "0x137CC84")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x60008EC")]
		[Address(RVA = "0x137CD90", Offset = "0x137CD90", VA = "0x137CD90")]
		private void Update()
		{
		}

		[Token(Token = "0x60008ED")]
		[Address(RVA = "0x137D1F0", Offset = "0x137D1F0", VA = "0x137D1F0")]
		private void Initiate()
		{
		}

		[Token(Token = "0x60008EE")]
		[Address(RVA = "0x137D630", Offset = "0x137D630", VA = "0x137D630")]
		private void OnSolverUpdate()
		{
		}

		[Token(Token = "0x60008EF")]
		[Address(RVA = "0x137D7AC", Offset = "0x137D7AC", VA = "0x137D7AC")]
		private void SetLegIK(int index)
		{
		}

		[Token(Token = "0x60008F0")]
		[Address(RVA = "0x137DA80", Offset = "0x137DA80", VA = "0x137DA80")]
		private void OnPostSolverUpdate()
		{
		}

		[Token(Token = "0x60008F1")]
		[Address(RVA = "0x137DBD0", Offset = "0x137DBD0", VA = "0x137DBD0")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60008F2")]
		[Address(RVA = "0x137DDD4", Offset = "0x137DDD4", VA = "0x137DDD4")]
		public GrounderIK()
		{
		}
	}
}
