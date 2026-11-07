using Il2CppDummyDll;

namespace RootMotion.FinalIK
{
	[Token(Token = "0x2000158")]
	public class LimbIK : IK
	{
		[Token(Token = "0x4000849")]
		[FieldOffset(Offset = "0x38")]
		public IKSolverLimb solver;

		[Token(Token = "0x6000995")]
		[Address(RVA = "0x13A8800", Offset = "0x13A8800", VA = "0x13A8800", Slot = "8")]
		[Attribute(Name = "ContextMenu", RVA = "0x39C24", Offset = "0x39C24")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x6000996")]
		[Address(RVA = "0x13A8848", Offset = "0x13A8848", VA = "0x13A8848", Slot = "9")]
		[Attribute(Name = "ContextMenu", RVA = "0x39C5C", Offset = "0x39C5C")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000997")]
		[Address(RVA = "0x13A8890", Offset = "0x13A8890", VA = "0x13A8890")]
		[Attribute(Name = "ContextMenu", RVA = "0x39C94", Offset = "0x39C94")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x6000998")]
		[Address(RVA = "0x13A88D8", Offset = "0x13A88D8", VA = "0x13A88D8")]
		[Attribute(Name = "ContextMenu", RVA = "0x39CCC", Offset = "0x39CCC")]
		private void ASThread()
		{
		}

		[Token(Token = "0x6000999")]
		[Address(RVA = "0x13A8920", Offset = "0x13A8920", VA = "0x13A8920", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x600099A")]
		[Address(RVA = "0x13A8928", Offset = "0x13A8928", VA = "0x13A8928")]
		public LimbIK()
		{
		}
	}
}
