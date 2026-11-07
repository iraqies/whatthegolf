using Il2CppDummyDll;
using UnityEngine;

namespace RootMotion.FinalIK
{
	[Token(Token = "0x2000144")]
	public class GrounderBipedIK : Grounder
	{
		[Token(Token = "0x40007C2")]
		[FieldOffset(Offset = "0x40")]
		public BipedIK ik;

		[Token(Token = "0x40007C3")]
		[FieldOffset(Offset = "0x48")]
		public float spineBend;

		[Token(Token = "0x40007C4")]
		[FieldOffset(Offset = "0x4C")]
		public float spineSpeed;

		[Token(Token = "0x40007C5")]
		[FieldOffset(Offset = "0x50")]
		private Transform[] feet;

		[Token(Token = "0x40007C6")]
		[FieldOffset(Offset = "0x58")]
		private Quaternion[] footRotations;

		[Token(Token = "0x40007C7")]
		[FieldOffset(Offset = "0x60")]
		private Vector3 animatedPelvisLocalPosition;

		[Token(Token = "0x40007C8")]
		[FieldOffset(Offset = "0x6C")]
		private Vector3 solvedPelvisLocalPosition;

		[Token(Token = "0x40007C9")]
		[FieldOffset(Offset = "0x78")]
		private Vector3 spineOffset;

		[Token(Token = "0x40007CA")]
		[FieldOffset(Offset = "0x84")]
		private float lastWeight;

		[Token(Token = "0x60008CC")]
		[Address(RVA = "0x137AAB4", Offset = "0x137AAB4", VA = "0x137AAB4", Slot = "5")]
		[Attribute(Name = "ContextMenu", RVA = "0x3904C", Offset = "0x3904C")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x60008CD")]
		[Address(RVA = "0x137AAFC", Offset = "0x137AAFC", VA = "0x137AAFC", Slot = "6")]
		[Attribute(Name = "ContextMenu", RVA = "0x39084", Offset = "0x39084")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x60008CE")]
		[Address(RVA = "0x137AB44", Offset = "0x137AB44", VA = "0x137AB44", Slot = "4")]
		public override void ResetPosition()
		{
		}

		[Token(Token = "0x60008CF")]
		[Address(RVA = "0x137AB84", Offset = "0x137AB84", VA = "0x137AB84")]
		private bool IsReadyToInitiate()
		{
			return default;
		}

		[Token(Token = "0x60008D0")]
		[Address(RVA = "0x137AC48", Offset = "0x137AC48", VA = "0x137AC48")]
		private void Update()
		{
		}

		[Token(Token = "0x60008D1")]
		[Address(RVA = "0x137ACA8", Offset = "0x137ACA8", VA = "0x137ACA8")]
		private void Initiate()
		{
		}

		[Token(Token = "0x60008D2")]
		[Address(RVA = "0x137AF80", Offset = "0x137AF80", VA = "0x137AF80")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x60008D3")]
		[Address(RVA = "0x137AFC8", Offset = "0x137AFC8", VA = "0x137AFC8")]
		private void OnSolverUpdate()
		{
		}

		[Token(Token = "0x60008D4")]
		[Address(RVA = "0x137B3FC", Offset = "0x137B3FC", VA = "0x137B3FC")]
		private void SetLegIK(IKSolverLimb limb, int index)
		{
		}

		[Token(Token = "0x60008D5")]
		[Address(RVA = "0x137B4D0", Offset = "0x137B4D0", VA = "0x137B4D0")]
		private void OnPostSolverUpdate()
		{
		}

		[Token(Token = "0x60008D6")]
		[Address(RVA = "0x137B60C", Offset = "0x137B60C", VA = "0x137B60C")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60008D7")]
		[Address(RVA = "0x137B7BC", Offset = "0x137B7BC", VA = "0x137B7BC")]
		public GrounderBipedIK()
		{
		}
	}
}
