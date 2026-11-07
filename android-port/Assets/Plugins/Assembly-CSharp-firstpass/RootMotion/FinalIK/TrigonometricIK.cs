using Il2CppDummyDll;

namespace RootMotion.FinalIK
{
	[Token(Token = "0x200015A")]
	public class TrigonometricIK : IK
	{
		[Token(Token = "0x400084B")]
		[FieldOffset(Offset = "0x38")]
		public IKSolverTrigonometric solver;

		[Token(Token = "0x60009A1")]
		[Address(RVA = "0x13235C0", Offset = "0x13235C0", VA = "0x13235C0", Slot = "8")]
		[Attribute(Name = "ContextMenu", RVA = "0x39DE4", Offset = "0x39DE4")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x60009A2")]
		[Address(RVA = "0x1323608", Offset = "0x1323608", VA = "0x1323608", Slot = "9")]
		[Attribute(Name = "ContextMenu", RVA = "0x39E1C", Offset = "0x39E1C")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x60009A3")]
		[Address(RVA = "0x1323650", Offset = "0x1323650", VA = "0x1323650")]
		[Attribute(Name = "ContextMenu", RVA = "0x39E54", Offset = "0x39E54")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x60009A4")]
		[Address(RVA = "0x1323698", Offset = "0x1323698", VA = "0x1323698")]
		[Attribute(Name = "ContextMenu", RVA = "0x39E8C", Offset = "0x39E8C")]
		private void ASThread()
		{
		}

		[Token(Token = "0x60009A5")]
		[Address(RVA = "0x13236E0", Offset = "0x13236E0", VA = "0x13236E0", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x60009A6")]
		[Address(RVA = "0x13236E8", Offset = "0x13236E8", VA = "0x13236E8")]
		public TrigonometricIK()
		{
		}
	}
}
