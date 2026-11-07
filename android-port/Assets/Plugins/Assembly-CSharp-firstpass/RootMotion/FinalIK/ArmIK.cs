using Il2CppDummyDll;

namespace RootMotion.FinalIK
{
	[Token(Token = "0x2000150")]
	public class ArmIK : IK
	{
		[Token(Token = "0x400083F")]
		[FieldOffset(Offset = "0x38")]
		public IKSolverArm solver;

		[Token(Token = "0x600095C")]
		[Address(RVA = "0x12F13F0", Offset = "0x12F13F0", VA = "0x12F13F0", Slot = "8")]
		[Attribute(Name = "ContextMenu", RVA = "0x39604", Offset = "0x39604")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x600095D")]
		[Address(RVA = "0x12F1438", Offset = "0x12F1438", VA = "0x12F1438", Slot = "9")]
		[Attribute(Name = "ContextMenu", RVA = "0x3963C", Offset = "0x3963C")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x600095E")]
		[Address(RVA = "0x12F1480", Offset = "0x12F1480", VA = "0x12F1480")]
		[Attribute(Name = "ContextMenu", RVA = "0x39674", Offset = "0x39674")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x600095F")]
		[Address(RVA = "0x12F14C8", Offset = "0x12F14C8", VA = "0x12F14C8")]
		[Attribute(Name = "ContextMenu", RVA = "0x396AC", Offset = "0x396AC")]
		private void ASThread()
		{
		}

		[Token(Token = "0x6000960")]
		[Address(RVA = "0x12F1510", Offset = "0x12F1510", VA = "0x12F1510", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x6000961")]
		[Address(RVA = "0x12F1518", Offset = "0x12F1518", VA = "0x12F1518")]
		public ArmIK()
		{
		}
	}
}
