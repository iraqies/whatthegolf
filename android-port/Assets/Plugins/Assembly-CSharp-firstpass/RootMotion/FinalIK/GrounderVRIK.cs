using Il2CppDummyDll;
using UnityEngine;

namespace RootMotion.FinalIK
{
	[Token(Token = "0x200014A")]
	public class GrounderVRIK : Grounder
	{
		[Token(Token = "0x4000804")]
		[FieldOffset(Offset = "0x40")]
		public VRIK ik;

		[Token(Token = "0x4000805")]
		[FieldOffset(Offset = "0x48")]
		private Transform[] feet;

		[Token(Token = "0x6000906")]
		[Address(RVA = "0x137FDB8", Offset = "0x137FDB8", VA = "0x137FDB8")]
		[Attribute(Name = "ContextMenu", RVA = "0x39244", Offset = "0x39244")]
		private void OpenTutorial()
		{
		}

		[Token(Token = "0x6000907")]
		[Address(RVA = "0x137FE00", Offset = "0x137FE00", VA = "0x137FE00", Slot = "5")]
		[Attribute(Name = "ContextMenu", RVA = "0x3927C", Offset = "0x3927C")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x6000908")]
		[Address(RVA = "0x137FE48", Offset = "0x137FE48", VA = "0x137FE48", Slot = "6")]
		[Attribute(Name = "ContextMenu", RVA = "0x392B4", Offset = "0x392B4")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000909")]
		[Address(RVA = "0x137FE90", Offset = "0x137FE90", VA = "0x137FE90", Slot = "4")]
		public override void ResetPosition()
		{
		}

		[Token(Token = "0x600090A")]
		[Address(RVA = "0x137FF3C", Offset = "0x137FF3C", VA = "0x137FF3C")]
		private bool IsReadyToInitiate()
		{
			return default;
		}

		[Token(Token = "0x600090B")]
		[Address(RVA = "0x137FFE4", Offset = "0x137FFE4", VA = "0x137FFE4")]
		private void Update()
		{
		}

		[Token(Token = "0x600090C")]
		[Address(RVA = "0x1380044", Offset = "0x1380044", VA = "0x1380044")]
		private void Initiate()
		{
		}

		[Token(Token = "0x600090D")]
		[Address(RVA = "0x1380514", Offset = "0x1380514", VA = "0x1380514")]
		private void OnSolverUpdate()
		{
		}

		[Token(Token = "0x600090E")]
		[Address(RVA = "0x138095C", Offset = "0x138095C", VA = "0x138095C")]
		private void SetLegIK(IKSolverVR.PositionOffset positionOffset, Transform bone, Grounding.Leg leg)
		{
		}

		[Token(Token = "0x600090F")]
		[Address(RVA = "0x13809EC", Offset = "0x13809EC", VA = "0x13809EC")]
		private void OnPostSolverUpdate()
		{
		}

		[Token(Token = "0x6000910")]
		[Address(RVA = "0x1380BA8", Offset = "0x1380BA8", VA = "0x1380BA8")]
		private void OnDrawGizmosSelected()
		{
		}

		[Token(Token = "0x6000911")]
		[Address(RVA = "0x1380D08", Offset = "0x1380D08", VA = "0x1380D08")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000912")]
		[Address(RVA = "0x1380EA8", Offset = "0x1380EA8", VA = "0x1380EA8")]
		public GrounderVRIK()
		{
		}
	}
}
