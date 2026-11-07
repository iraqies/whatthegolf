using Il2CppDummyDll;

namespace RootMotion.FinalIK
{
	[Token(Token = "0x2000151")]
	public class CCDIK : IK
	{
		[Token(Token = "0x4000840")]
		[FieldOffset(Offset = "0x38")]
		public IKSolverCCD solver;

		[Token(Token = "0x6000962")]
		[Address(RVA = "0x130CCE4", Offset = "0x130CCE4", VA = "0x130CCE4", Slot = "8")]
		[Attribute(Name = "ContextMenu", RVA = "0x396E4", Offset = "0x396E4")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x6000963")]
		[Address(RVA = "0x130CD2C", Offset = "0x130CD2C", VA = "0x130CD2C", Slot = "9")]
		[Attribute(Name = "ContextMenu", RVA = "0x3971C", Offset = "0x3971C")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000964")]
		[Address(RVA = "0x130CD74", Offset = "0x130CD74", VA = "0x130CD74")]
		[Attribute(Name = "ContextMenu", RVA = "0x39754", Offset = "0x39754")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x6000965")]
		[Address(RVA = "0x130CDBC", Offset = "0x130CDBC", VA = "0x130CDBC")]
		[Attribute(Name = "ContextMenu", RVA = "0x3978C", Offset = "0x3978C")]
		private void ASThread()
		{
		}

		[Token(Token = "0x6000966")]
		[Address(RVA = "0x130CE04", Offset = "0x130CE04", VA = "0x130CE04", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x6000967")]
		[Address(RVA = "0x130CE0C", Offset = "0x130CE0C", VA = "0x130CE0C")]
		public CCDIK()
		{
		}
	}
}
