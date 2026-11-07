using Il2CppDummyDll;

namespace RootMotion.FinalIK
{
	[Token(Token = "0x2000155")]
	public abstract class IK : SolverManager
	{
		[Token(Token = "0x6000981")]
		public abstract IKSolver GetIKSolver();

		[Token(Token = "0x6000982")]
		[Address(RVA = "0x1385198", Offset = "0x1385198", VA = "0x1385198", Slot = "5")]
		protected override void UpdateSolver()
		{
		}

		[Token(Token = "0x6000983")]
		[Address(RVA = "0x13852EC", Offset = "0x13852EC", VA = "0x13852EC", Slot = "4")]
		protected override void InitiateSolver()
		{
		}

		[Token(Token = "0x6000984")]
		[Address(RVA = "0x13854D8", Offset = "0x13854D8", VA = "0x13854D8", Slot = "6")]
		protected override void FixTransforms()
		{
		}

		[Token(Token = "0x6000985")]
		protected abstract void OpenUserManual();

		[Token(Token = "0x6000986")]
		protected abstract void OpenScriptReference();

		[Token(Token = "0x6000987")]
		[Address(RVA = "0x138553C", Offset = "0x138553C", VA = "0x138553C")]
		protected IK()
		{
		}
	}
}
