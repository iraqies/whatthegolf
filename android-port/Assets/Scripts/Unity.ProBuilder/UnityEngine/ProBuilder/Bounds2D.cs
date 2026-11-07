using System.Collections.Generic;
using Il2CppDummyDll;

namespace UnityEngine.ProBuilder
{
	[Token(Token = "0x2000007")]
	internal sealed class Bounds2D
	{
		[Token(Token = "0x400001B")]
		[FieldOffset(Offset = "0x10")]
		public Vector2 center;

		[Token(Token = "0x400001C")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Vector2 m_Size;

		[Token(Token = "0x400001D")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Vector2 m_Extents;

		[Token(Token = "0x1700000B")]
		public Vector2 size
		{
			[Token(Token = "0x6000015")]
			[Address(RVA = "0x2A47C1C", Offset = "0x2A47C1C", VA = "0x2A47C1C")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x6000016")]
		[Address(RVA = "0x2A47C24", Offset = "0x2A47C24", VA = "0x2A47C24")]
		public Bounds2D()
		{
		}

		[Token(Token = "0x6000017")]
		[Address(RVA = "0x2A47C6C", Offset = "0x2A47C6C", VA = "0x2A47C6C")]
		public void SetWithPoints(IList<Vector2> points, IList<int> indexes)
		{
		}

		[Token(Token = "0x6000018")]
		[Address(RVA = "0x2A48280", Offset = "0x2A48280", VA = "0x2A48280")]
		public static Vector2 Center(IList<Vector2> points, IList<int> indexes)
		{
			return default;
		}

		[Token(Token = "0x6000019")]
		[Address(RVA = "0x2A48774", Offset = "0x2A48774", VA = "0x2A48774", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
}
