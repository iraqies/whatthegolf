using Il2CppDummyDll;

namespace RootMotion.FinalIK
{
	[Token(Token = "0x2000159")]
	public class LookAtIK : IK
	{
		[Token(Token = "0x400084A")]
		[FieldOffset(Offset = "0x38")]
		public IKSolverLookAt solver;

		[Token(Token = "0x600099B")]
		[Address(RVA = "0x13A9814", Offset = "0x13A9814", VA = "0x13A9814", Slot = "8")]
		[Attribute(Name = "ContextMenu", RVA = "0x39D04", Offset = "0x39D04")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x600099C")]
		[Address(RVA = "0x13A985C", Offset = "0x13A985C", VA = "0x13A985C", Slot = "9")]
		[Attribute(Name = "ContextMenu", RVA = "0x39D3C", Offset = "0x39D3C")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x600099D")]
		[Address(RVA = "0x13A98A4", Offset = "0x13A98A4", VA = "0x13A98A4")]
		[Attribute(Name = "ContextMenu", RVA = "0x39D74", Offset = "0x39D74")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x600099E")]
		[Address(RVA = "0x13A98EC", Offset = "0x13A98EC", VA = "0x13A98EC")]
		[Attribute(Name = "ContextMenu", RVA = "0x39DAC", Offset = "0x39DAC")]
		private void ASThread()
		{
		}

		[Token(Token = "0x600099F")]
		[Address(RVA = "0x13A9934", Offset = "0x13A9934", VA = "0x13A9934", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x60009A0")]
		[Address(RVA = "0x13A993C", Offset = "0x13A993C", VA = "0x13A993C")]
		public LookAtIK()
		{
		}
	}
}
