using Il2CppDummyDll;

namespace RootMotion.FinalIK
{
	[Token(Token = "0x2000152")]
	public class FABRIK : IK
	{
		[Token(Token = "0x4000841")]
		[FieldOffset(Offset = "0x38")]
		public IKSolverFABRIK solver;

		[Token(Token = "0x6000968")]
		[Address(RVA = "0x1368B6C", Offset = "0x1368B6C", VA = "0x1368B6C", Slot = "8")]
		[Attribute(Name = "ContextMenu", RVA = "0x397C4", Offset = "0x397C4")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x6000969")]
		[Address(RVA = "0x1368BB4", Offset = "0x1368BB4", VA = "0x1368BB4", Slot = "9")]
		[Attribute(Name = "ContextMenu", RVA = "0x397FC", Offset = "0x397FC")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x600096A")]
		[Address(RVA = "0x1368BFC", Offset = "0x1368BFC", VA = "0x1368BFC")]
		[Attribute(Name = "ContextMenu", RVA = "0x39834", Offset = "0x39834")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x600096B")]
		[Address(RVA = "0x1368C44", Offset = "0x1368C44", VA = "0x1368C44")]
		[Attribute(Name = "ContextMenu", RVA = "0x3986C", Offset = "0x3986C")]
		private void ASThread()
		{
		}

		[Token(Token = "0x600096C")]
		[Address(RVA = "0x1368C8C", Offset = "0x1368C8C", VA = "0x1368C8C", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x600096D")]
		[Address(RVA = "0x1368C94", Offset = "0x1368C94", VA = "0x1368C94")]
		public FABRIK()
		{
		}
	}
}
