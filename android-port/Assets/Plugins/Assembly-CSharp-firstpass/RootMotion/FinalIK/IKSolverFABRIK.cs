using System;
using Il2CppDummyDll;
using UnityEngine;

namespace RootMotion.FinalIK
{
	[Serializable]
	[Token(Token = "0x2000175")]
	public class IKSolverFABRIK : IKSolverHeuristic
	{
		[Token(Token = "0x4000960")]
		[FieldOffset(Offset = "0x88")]
		public IterationDelegate OnPreIteration;

		[Token(Token = "0x4000961")]
		[FieldOffset(Offset = "0x90")]
		private bool[] limitedBones;

		[Token(Token = "0x4000962")]
		[FieldOffset(Offset = "0x98")]
		private Vector3[] solverLocalPositions;

		[Token(Token = "0x1700014D")]
		protected override bool boneLengthCanBeZero
		{
			[Token(Token = "0x6000A7F")]
			[Address(RVA = "0x138D678", Offset = "0x138D678", VA = "0x138D678", Slot = "13")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x6000A7A")]
		[Address(RVA = "0x138C5CC", Offset = "0x138C5CC", VA = "0x138C5CC")]
		public void SolveForward(Vector3 position)
		{
		}

		[Token(Token = "0x6000A7B")]
		[Address(RVA = "0x138CC18", Offset = "0x138CC18", VA = "0x138CC18")]
		public void SolveBackward(Vector3 position)
		{
		}

		[Token(Token = "0x6000A7C")]
		[Address(RVA = "0x138CD94", Offset = "0x138CD94", VA = "0x138CD94", Slot = "5")]
		public override Vector3 GetIKPosition()
		{
			return default;
		}

		[Token(Token = "0x6000A7D")]
		[Address(RVA = "0x138CE40", Offset = "0x138CE40", VA = "0x138CE40", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x6000A7E")]
		[Address(RVA = "0x138D348", Offset = "0x138D348", VA = "0x138D348", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x6000A80")]
		[Address(RVA = "0x138D680", Offset = "0x138D680", VA = "0x138D680")]
		private Vector3 SolveJoint(Vector3 pos1, Vector3 pos2, float length)
		{
			return default;
		}

		[Token(Token = "0x6000A81")]
		[Address(RVA = "0x138C6A8", Offset = "0x138C6A8", VA = "0x138C6A8")]
		private void OnPreSolve()
		{
		}

		[Token(Token = "0x6000A82")]
		[Address(RVA = "0x138CD40", Offset = "0x138CD40", VA = "0x138CD40")]
		private void OnPostSolve()
		{
		}

		[Token(Token = "0x6000A83")]
		[Address(RVA = "0x138D604", Offset = "0x138D604", VA = "0x138D604")]
		private void Solve(Vector3 targetPosition)
		{
		}

		[Token(Token = "0x6000A84")]
		[Address(RVA = "0x138CA20", Offset = "0x138CA20", VA = "0x138CA20")]
		private void ForwardReach(Vector3 position)
		{
		}

		[Token(Token = "0x6000A85")]
		[Address(RVA = "0x138DD54", Offset = "0x138DD54", VA = "0x138DD54")]
		private void SolverMove(int index, Vector3 offset)
		{
		}

		[Token(Token = "0x6000A86")]
		[Address(RVA = "0x138DDCC", Offset = "0x138DDCC", VA = "0x138DDCC")]
		private void SolverRotate(int index, Quaternion rotation, bool recursive)
		{
		}

		[Token(Token = "0x6000A87")]
		[Address(RVA = "0x138DE94", Offset = "0x138DE94", VA = "0x138DE94")]
		private void SolverRotateChildren(int index, Quaternion rotation)
		{
		}

		[Token(Token = "0x6000A88")]
		[Address(RVA = "0x138DF44", Offset = "0x138DF44", VA = "0x138DF44")]
		private void SolverMoveChildrenAroundPoint(int index, Quaternion rotation)
		{
		}

		[Token(Token = "0x6000A89")]
		[Address(RVA = "0x138D0C0", Offset = "0x138D0C0", VA = "0x138D0C0")]
		private Quaternion GetParentSolverRotation(int index)
		{
			return default;
		}

		[Token(Token = "0x6000A8A")]
		[Address(RVA = "0x138D204", Offset = "0x138D204", VA = "0x138D204")]
		private Vector3 GetParentSolverPosition(int index)
		{
			return default;
		}

		[Token(Token = "0x6000A8B")]
		[Address(RVA = "0x138E038", Offset = "0x138E038", VA = "0x138E038")]
		private Quaternion GetLimitedRotation(int index, Quaternion q, out bool changed)
		{
			return default;
		}

		[Token(Token = "0x6000A8C")]
		[Address(RVA = "0x138D8E8", Offset = "0x138D8E8", VA = "0x138D8E8")]
		private void LimitForward(int rotateBone, int limitBone)
		{
		}

		[Token(Token = "0x6000A8D")]
		[Address(RVA = "0x138CD2C", Offset = "0x138CD2C", VA = "0x138CD2C")]
		private void BackwardReach(Vector3 position)
		{
		}

		[Token(Token = "0x6000A8E")]
		[Address(RVA = "0x138E614", Offset = "0x138E614", VA = "0x138E614")]
		private void BackwardReachUnlimited(Vector3 position)
		{
		}

		[Token(Token = "0x6000A8F")]
		[Address(RVA = "0x138E180", Offset = "0x138E180", VA = "0x138E180")]
		private void BackwardReachLimited(Vector3 position)
		{
		}

		[Token(Token = "0x6000A90")]
		[Address(RVA = "0x138D700", Offset = "0x138D700", VA = "0x138D700")]
		private void MapToSolverPositions()
		{
		}

		[Token(Token = "0x6000A91")]
		[Address(RVA = "0x138D814", Offset = "0x138D814", VA = "0x138D814")]
		private void MapToSolverPositionsLimited()
		{
		}

		[Token(Token = "0x6000A92")]
		[Address(RVA = "0x138E728", Offset = "0x138E728", VA = "0x138E728")]
		public IKSolverFABRIK()
		{
		}
	}
}
