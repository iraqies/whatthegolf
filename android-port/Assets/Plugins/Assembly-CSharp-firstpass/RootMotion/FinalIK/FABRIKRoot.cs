using Il2CppDummyDll;

namespace RootMotion.FinalIK
{
	[Token(Token = "0x2000153")]
	public class FABRIKRoot : IK
	{
		[Token(Token = "0x4000842")]
		[FieldOffset(Offset = "0x38")]
		public IKSolverFABRIKRoot solver;

		[Token(Token = "0x600096E")]
		[Address(RVA = "0x13691F0", Offset = "0x13691F0", VA = "0x13691F0", Slot = "8")]
		[Attribute(Name = "ContextMenu", RVA = "0x398A4", Offset = "0x398A4")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x600096F")]
		[Address(RVA = "0x1369238", Offset = "0x1369238", VA = "0x1369238", Slot = "9")]
		[Attribute(Name = "ContextMenu", RVA = "0x398DC", Offset = "0x398DC")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000970")]
		[Address(RVA = "0x1369280", Offset = "0x1369280", VA = "0x1369280")]
		[Attribute(Name = "ContextMenu", RVA = "0x39914", Offset = "0x39914")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x6000971")]
		[Address(RVA = "0x13692C8", Offset = "0x13692C8", VA = "0x13692C8")]
		[Attribute(Name = "ContextMenu", RVA = "0x3994C", Offset = "0x3994C")]
		private void ASThread()
		{
		}

		[Token(Token = "0x6000972")]
		[Address(RVA = "0x1369310", Offset = "0x1369310", VA = "0x1369310", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x6000973")]
		[Address(RVA = "0x1369318", Offset = "0x1369318", VA = "0x1369318")]
		public FABRIKRoot()
		{
		}
	}
}
