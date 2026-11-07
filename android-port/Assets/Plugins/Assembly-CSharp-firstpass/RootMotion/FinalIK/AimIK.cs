using Il2CppDummyDll;

namespace RootMotion.FinalIK
{
	[Token(Token = "0x200014F")]
	public class AimIK : IK
	{
		[Token(Token = "0x400083E")]
		[FieldOffset(Offset = "0x38")]
		public IKSolverAim solver;

		[Token(Token = "0x6000955")]
		[Address(RVA = "0x12EB108", Offset = "0x12EB108", VA = "0x12EB108", Slot = "8")]
		[Attribute(Name = "ContextMenu", RVA = "0x394EC", Offset = "0x394EC")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x6000956")]
		[Address(RVA = "0x12EB150", Offset = "0x12EB150", VA = "0x12EB150", Slot = "9")]
		[Attribute(Name = "ContextMenu", RVA = "0x39524", Offset = "0x39524")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000957")]
		[Address(RVA = "0x12EB198", Offset = "0x12EB198", VA = "0x12EB198")]
		[Attribute(Name = "ContextMenu", RVA = "0x3955C", Offset = "0x3955C")]
		private void OpenSetupTutorial()
		{
		}

		[Token(Token = "0x6000958")]
		[Address(RVA = "0x12EB1E0", Offset = "0x12EB1E0", VA = "0x12EB1E0")]
		[Attribute(Name = "ContextMenu", RVA = "0x39594", Offset = "0x39594")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x6000959")]
		[Address(RVA = "0x12EB228", Offset = "0x12EB228", VA = "0x12EB228")]
		[Attribute(Name = "ContextMenu", RVA = "0x395CC", Offset = "0x395CC")]
		private void ASThread()
		{
		}

		[Token(Token = "0x600095A")]
		[Address(RVA = "0x12EB270", Offset = "0x12EB270", VA = "0x12EB270", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x600095B")]
		[Address(RVA = "0x12EB278", Offset = "0x12EB278", VA = "0x12EB278")]
		public AimIK()
		{
		}
	}
}
