using System.Collections.Generic;
using Il2CppDummyDll;

namespace UnityEngine.U2D.IK
{
	[Token(Token = "0x2000005")]
	[Attribute(Name = "MovedFromAttribute", RVA = "0x1B0BF4", Offset = "0x1B0BF4")]
	public class LimbSolver2D : Solver2D
	{
		[Token(Token = "0x400000A")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private IKChain2D m_Chain;

		[Token(Token = "0x400000B")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private bool m_Flip;

		[Token(Token = "0x400000C")]
		[FieldOffset(Offset = "0x48")]
		private Vector3[] m_Positions;

		[Token(Token = "0x400000D")]
		[FieldOffset(Offset = "0x50")]
		private float[] m_Lengths;

		[Token(Token = "0x400000E")]
		[FieldOffset(Offset = "0x58")]
		private float[] m_Angles;

		[Token(Token = "0x1700000B")]
		public bool flip
		{
			[Token(Token = "0x6000022")]
			[Address(RVA = "0x2A132E8", Offset = "0x2A132E8", VA = "0x2A132E8")]
			get
			{
				return default;
			}
			[Token(Token = "0x6000023")]
			[Address(RVA = "0x2A132F0", Offset = "0x2A132F0", VA = "0x2A132F0")]
			set
			{
			}
		}

		[Token(Token = "0x6000024")]
		[Address(RVA = "0x2A132F8", Offset = "0x2A132F8", VA = "0x2A132F8", Slot = "9")]
		protected override void DoInitialize()
		{
		}

		[Token(Token = "0x6000025")]
		[Address(RVA = "0x2A133D0", Offset = "0x2A133D0", VA = "0x2A133D0", Slot = "6")]
		protected override int GetChainCount()
		{
			return default;
		}

		[Token(Token = "0x6000026")]
		[Address(RVA = "0x2A133D8", Offset = "0x2A133D8", VA = "0x2A133D8", Slot = "5")]
		public override IKChain2D GetChain(int index)
		{
			return null;
		}

		[Token(Token = "0x6000027")]
		[Address(RVA = "0x2A133E0", Offset = "0x2A133E0", VA = "0x2A133E0", Slot = "10")]
		protected override void DoPrepare()
		{
		}

		[Token(Token = "0x6000028")]
		[Address(RVA = "0x2A13548", Offset = "0x2A13548", VA = "0x2A13548", Slot = "7")]
		protected override void DoUpdateIK(List<Vector3> effectorPositions)
		{
		}

		[Token(Token = "0x6000029")]
		[Address(RVA = "0x2A139D8", Offset = "0x2A139D8", VA = "0x2A139D8")]
		public LimbSolver2D()
		{
		}
	}
}
