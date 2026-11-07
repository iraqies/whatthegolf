using Il2CppDummyDll;

namespace RootMotion.FinalIK
{
	[Token(Token = "0x2000157")]
	public class LegIK : IK
	{
		[Token(Token = "0x4000848")]
		[FieldOffset(Offset = "0x38")]
		public IKSolverLeg solver;

		[Token(Token = "0x600098F")]
		[Address(RVA = "0x13A85E8", Offset = "0x13A85E8", VA = "0x13A85E8", Slot = "8")]
		[Attribute(Name = "ContextMenu", RVA = "0x39B44", Offset = "0x39B44")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x6000990")]
		[Address(RVA = "0x13A8630", Offset = "0x13A8630", VA = "0x13A8630", Slot = "9")]
		[Attribute(Name = "ContextMenu", RVA = "0x39B7C", Offset = "0x39B7C")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000991")]
		[Address(RVA = "0x13A8678", Offset = "0x13A8678", VA = "0x13A8678")]
		[Attribute(Name = "ContextMenu", RVA = "0x39BB4", Offset = "0x39BB4")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x6000992")]
		[Address(RVA = "0x13A86C0", Offset = "0x13A86C0", VA = "0x13A86C0")]
		[Attribute(Name = "ContextMenu", RVA = "0x39BEC", Offset = "0x39BEC")]
		private void ASThread()
		{
		}

		[Token(Token = "0x6000993")]
		[Address(RVA = "0x13A8708", Offset = "0x13A8708", VA = "0x13A8708", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x6000994")]
		[Address(RVA = "0x13A8710", Offset = "0x13A8710", VA = "0x13A8710")]
		public LegIK()
		{
		}
	}
}
