using System;
using Il2CppDummyDll;
using UnityEngine;

namespace RootMotion.FinalIK
{
	[Serializable]
	[Token(Token = "0x2000174")]
	public class IKSolverCCD : IKSolverHeuristic
	{
		[Token(Token = "0x400095F")]
		[FieldOffset(Offset = "0x88")]
		public IterationDelegate OnPreIteration;

		[Token(Token = "0x6000A76")]
		[Address(RVA = "0x138BCA0", Offset = "0x138BCA0", VA = "0x138BCA0", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x6000A77")]
		[Address(RVA = "0x138BD24", Offset = "0x138BD24", VA = "0x138BD24", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x6000A78")]
		[Address(RVA = "0x138BFBC", Offset = "0x138BFBC", VA = "0x138BFBC")]
		protected void Solve(Vector3 targetPosition)
		{
		}

		[Token(Token = "0x6000A79")]
		[Address(RVA = "0x138C5C4", Offset = "0x138C5C4", VA = "0x138C5C4")]
		public IKSolverCCD()
		{
		}
	}
}
