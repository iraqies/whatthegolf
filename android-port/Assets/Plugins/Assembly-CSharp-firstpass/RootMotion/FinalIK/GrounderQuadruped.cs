using Il2CppDummyDll;
using UnityEngine;

namespace RootMotion.FinalIK
{
	[Token(Token = "0x2000148")]
	public class GrounderQuadruped : Grounder
	{
		[Token(Token = "0x2000149")]
		public struct Foot
		{
			[Token(Token = "0x4000800")]
			[FieldOffset(Offset = "0x0")]
			public IKSolver solver;

			[Token(Token = "0x4000801")]
			[FieldOffset(Offset = "0x8")]
			public Transform transform;

			[Token(Token = "0x4000802")]
			[FieldOffset(Offset = "0x10")]
			public Quaternion rotation;

			[Token(Token = "0x4000803")]
			[FieldOffset(Offset = "0x20")]
			public Grounding.Leg leg;

			[Token(Token = "0x6000905")]
			[Address(RVA = "0x133B058", Offset = "0x133B058", VA = "0x133B058")]
			public Foot(IKSolver solver, Transform transform)
			{
			}
		}

		[Token(Token = "0x40007E3")]
		[FieldOffset(Offset = "0x40")]
		public Grounding forelegSolver;

		[Token(Token = "0x40007E4")]
		[FieldOffset(Offset = "0x48")]
		[Attribute(Name = "RangeAttribute", RVA = "0x35B68", Offset = "0x35B68")]
		public float rootRotationWeight;

		[Token(Token = "0x40007E5")]
		[FieldOffset(Offset = "0x4C")]
		[Attribute(Name = "RangeAttribute", RVA = "0x35B80", Offset = "0x35B80")]
		public float minRootRotation;

		[Token(Token = "0x40007E6")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "RangeAttribute", RVA = "0x35B9C", Offset = "0x35B9C")]
		public float maxRootRotation;

		[Token(Token = "0x40007E7")]
		[FieldOffset(Offset = "0x54")]
		public float rootRotationSpeed;

		[Token(Token = "0x40007E8")]
		[FieldOffset(Offset = "0x58")]
		public float maxLegOffset;

		[Token(Token = "0x40007E9")]
		[FieldOffset(Offset = "0x5C")]
		public float maxForeLegOffset;

		[Token(Token = "0x40007EA")]
		[FieldOffset(Offset = "0x60")]
		[Attribute(Name = "RangeAttribute", RVA = "0x35BB8", Offset = "0x35BB8")]
		public float maintainHeadRotationWeight;

		[Token(Token = "0x40007EB")]
		[FieldOffset(Offset = "0x68")]
		public Transform characterRoot;

		[Token(Token = "0x40007EC")]
		[FieldOffset(Offset = "0x70")]
		public Transform pelvis;

		[Token(Token = "0x40007ED")]
		[FieldOffset(Offset = "0x78")]
		public Transform lastSpineBone;

		[Token(Token = "0x40007EE")]
		[FieldOffset(Offset = "0x80")]
		public Transform head;

		[Token(Token = "0x40007EF")]
		[FieldOffset(Offset = "0x88")]
		public IK[] legs;

		[Token(Token = "0x40007F0")]
		[FieldOffset(Offset = "0x90")]
		public IK[] forelegs;

		[Token(Token = "0x40007F1")]
		[FieldOffset(Offset = "0x98")]
		public Vector3 gravity;

		[Token(Token = "0x40007F2")]
		[FieldOffset(Offset = "0xA8")]
		private Foot[] feet;

		[Token(Token = "0x40007F3")]
		[FieldOffset(Offset = "0xB0")]
		private Vector3 animatedPelvisLocalPosition;

		[Token(Token = "0x40007F4")]
		[FieldOffset(Offset = "0xBC")]
		private Quaternion animatedPelvisLocalRotation;

		[Token(Token = "0x40007F5")]
		[FieldOffset(Offset = "0xCC")]
		private Quaternion animatedHeadLocalRotation;

		[Token(Token = "0x40007F6")]
		[FieldOffset(Offset = "0xDC")]
		private Vector3 solvedPelvisLocalPosition;

		[Token(Token = "0x40007F7")]
		[FieldOffset(Offset = "0xE8")]
		private Quaternion solvedPelvisLocalRotation;

		[Token(Token = "0x40007F8")]
		[FieldOffset(Offset = "0xF8")]
		private Quaternion solvedHeadLocalRotation;

		[Token(Token = "0x40007F9")]
		[FieldOffset(Offset = "0x108")]
		private int solvedFeet;

		[Token(Token = "0x40007FA")]
		[FieldOffset(Offset = "0x10C")]
		private bool solved;

		[Token(Token = "0x40007FB")]
		[FieldOffset(Offset = "0x110")]
		private float angle;

		[Token(Token = "0x40007FC")]
		[FieldOffset(Offset = "0x118")]
		private Transform forefeetRoot;

		[Token(Token = "0x40007FD")]
		[FieldOffset(Offset = "0x120")]
		private Quaternion headRotation;

		[Token(Token = "0x40007FE")]
		[FieldOffset(Offset = "0x130")]
		private float lastWeight;

		[Token(Token = "0x40007FF")]
		[FieldOffset(Offset = "0x138")]
		private Rigidbody characterRootRigidbody;

		[Token(Token = "0x60008F3")]
		[Address(RVA = "0x137DEB0", Offset = "0x137DEB0", VA = "0x137DEB0", Slot = "5")]
		[Attribute(Name = "ContextMenu", RVA = "0x391D4", Offset = "0x391D4")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x60008F4")]
		[Address(RVA = "0x137DEF8", Offset = "0x137DEF8", VA = "0x137DEF8", Slot = "6")]
		[Attribute(Name = "ContextMenu", RVA = "0x3920C", Offset = "0x3920C")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x60008F5")]
		[Address(RVA = "0x137DF40", Offset = "0x137DF40", VA = "0x137DF40", Slot = "4")]
		public override void ResetPosition()
		{
		}

		[Token(Token = "0x60008F6")]
		[Address(RVA = "0x137DF7C", Offset = "0x137DF7C", VA = "0x137DF7C")]
		private bool IsReadyToInitiate()
		{
			return default;
		}

		[Token(Token = "0x60008F7")]
		[Address(RVA = "0x137E0C0", Offset = "0x137E0C0", VA = "0x137E0C0")]
		private bool IsReadyToInitiateLegs(IK[] ikComponents)
		{
			return default;
		}

		[Token(Token = "0x60008F8")]
		[Address(RVA = "0x137E2E4", Offset = "0x137E2E4", VA = "0x137E2E4")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x60008F9")]
		[Address(RVA = "0x137E358", Offset = "0x137E358", VA = "0x137E358")]
		private void Update()
		{
		}

		[Token(Token = "0x60008FA")]
		[Address(RVA = "0x137E3BC", Offset = "0x137E3BC", VA = "0x137E3BC")]
		private void Initiate()
		{
		}

		[Token(Token = "0x60008FB")]
		[Address(RVA = "0x137E6F0", Offset = "0x137E6F0", VA = "0x137E6F0")]
		private Transform[] InitiateFeet(IK[] ikComponents, ref Foot[] f, int indexOffset)
		{
			return null;
		}

		[Token(Token = "0x60008FC")]
		[Address(RVA = "0x137EA24", Offset = "0x137EA24", VA = "0x137EA24")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60008FD")]
		[Address(RVA = "0x137EB00", Offset = "0x137EB00", VA = "0x137EB00")]
		private void RootRotation()
		{
		}

		[Token(Token = "0x60008FE")]
		[Address(RVA = "0x137EEE0", Offset = "0x137EEE0", VA = "0x137EEE0")]
		private void OnSolverUpdate()
		{
		}

		[Token(Token = "0x60008FF")]
		[Address(RVA = "0x137F58C", Offset = "0x137F58C", VA = "0x137F58C")]
		private void UpdateForefeetRoot()
		{
		}

		[Token(Token = "0x6000900")]
		[Address(RVA = "0x137F75C", Offset = "0x137F75C", VA = "0x137F75C")]
		private void SetFootIK(Foot foot, float maxOffset)
		{
		}

		[Token(Token = "0x6000901")]
		[Address(RVA = "0x137F838", Offset = "0x137F838", VA = "0x137F838")]
		private void OnPostSolverUpdate()
		{
		}

		[Token(Token = "0x6000902")]
		[Address(RVA = "0x137FA84", Offset = "0x137FA84", VA = "0x137FA84")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000903")]
		[Address(RVA = "0x137FAC0", Offset = "0x137FAC0", VA = "0x137FAC0")]
		private void DestroyLegs(IK[] ikComponents)
		{
		}

		[Token(Token = "0x6000904")]
		[Address(RVA = "0x137FCB8", Offset = "0x137FCB8", VA = "0x137FCB8")]
		public GrounderQuadruped()
		{
		}
	}
}
