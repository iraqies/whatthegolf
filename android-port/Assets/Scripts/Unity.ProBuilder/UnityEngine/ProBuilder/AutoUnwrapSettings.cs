using System;
using Il2CppDummyDll;

namespace UnityEngine.ProBuilder
{
	[Serializable]
	[Token(Token = "0x2000004")]
	public struct AutoUnwrapSettings
	{
		[Token(Token = "0x2000005")]
		public enum Anchor
		{
			[Token(Token = "0x400000D")]
			UpperLeft = 0,
			[Token(Token = "0x400000E")]
			UpperCenter = 1,
			[Token(Token = "0x400000F")]
			UpperRight = 2,
			[Token(Token = "0x4000010")]
			MiddleLeft = 3,
			[Token(Token = "0x4000011")]
			MiddleCenter = 4,
			[Token(Token = "0x4000012")]
			MiddleRight = 5,
			[Token(Token = "0x4000013")]
			LowerLeft = 6,
			[Token(Token = "0x4000014")]
			LowerCenter = 7,
			[Token(Token = "0x4000015")]
			LowerRight = 8,
			[Token(Token = "0x4000016")]
			None = 9
		}

		[Token(Token = "0x2000006")]
		public enum Fill
		{
			[Token(Token = "0x4000018")]
			Fit = 0,
			[Token(Token = "0x4000019")]
			Tile = 1,
			[Token(Token = "0x400001A")]
			Stretch = 2
		}

		[Token(Token = "0x4000003")]
		[FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x1B5B38", Offset = "0x1B5B38")]
		[SerializeField]
		private bool m_UseWorldSpace;

		[Token(Token = "0x4000004")]
		[FieldOffset(Offset = "0x1")]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x1B5B84", Offset = "0x1B5B84")]
		[SerializeField]
		private bool m_FlipU;

		[Token(Token = "0x4000005")]
		[FieldOffset(Offset = "0x2")]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x1B5BD0", Offset = "0x1B5BD0")]
		[SerializeField]
		private bool m_FlipV;

		[Token(Token = "0x4000006")]
		[FieldOffset(Offset = "0x3")]
		[SerializeField]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x1B5C1C", Offset = "0x1B5C1C")]
		private bool m_SwapUV;

		[Token(Token = "0x4000007")]
		[FieldOffset(Offset = "0x4")]
		[SerializeField]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x1B5C68", Offset = "0x1B5C68")]
		private Fill m_Fill;

		[Token(Token = "0x4000008")]
		[FieldOffset(Offset = "0x8")]
		[SerializeField]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x1B5CB4", Offset = "0x1B5CB4")]
		private Vector2 m_Scale;

		[Token(Token = "0x4000009")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x1B5D00", Offset = "0x1B5D00")]
		private Vector2 m_Offset;

		[Token(Token = "0x400000A")]
		[FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x1B5D4C", Offset = "0x1B5D4C")]
		[SerializeField]
		private float m_Rotation;

		[Token(Token = "0x400000B")]
		[FieldOffset(Offset = "0x1C")]
		[SerializeField]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x1B5D98", Offset = "0x1B5D98")]
		private Anchor m_Anchor;

		[Token(Token = "0x17000001")]
		public bool useWorldSpace
		{
			[Token(Token = "0x6000008")]
			[Address(RVA = "0x2A475BC", Offset = "0x2A475BC", VA = "0x2A475BC")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000002")]
		public bool flipU
		{
			[Token(Token = "0x6000009")]
			[Address(RVA = "0x2A475C4", Offset = "0x2A475C4", VA = "0x2A475C4")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000003")]
		public bool flipV
		{
			[Token(Token = "0x600000A")]
			[Address(RVA = "0x2A475CC", Offset = "0x2A475CC", VA = "0x2A475CC")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000004")]
		public bool swapUV
		{
			[Token(Token = "0x600000B")]
			[Address(RVA = "0x2A475D4", Offset = "0x2A475D4", VA = "0x2A475D4")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000005")]
		public Fill fill
		{
			[Token(Token = "0x600000C")]
			[Address(RVA = "0x2A475DC", Offset = "0x2A475DC", VA = "0x2A475DC")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000006")]
		public Vector2 scale
		{
			[Token(Token = "0x600000D")]
			[Address(RVA = "0x2A475E4", Offset = "0x2A475E4", VA = "0x2A475E4")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000007")]
		public Vector2 offset
		{
			[Token(Token = "0x600000E")]
			[Address(RVA = "0x2A475EC", Offset = "0x2A475EC", VA = "0x2A475EC")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000008")]
		public float rotation
		{
			[Token(Token = "0x600000F")]
			[Address(RVA = "0x2A475F4", Offset = "0x2A475F4", VA = "0x2A475F4")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000009")]
		public Anchor anchor
		{
			[Token(Token = "0x6000010")]
			[Address(RVA = "0x2A475FC", Offset = "0x2A475FC", VA = "0x2A475FC")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x1700000A")]
		public static AutoUnwrapSettings tile
		{
			[Token(Token = "0x6000012")]
			[Address(RVA = "0x2A47660", Offset = "0x2A47660", VA = "0x2A47660")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x6000011")]
		[Address(RVA = "0x2A47604", Offset = "0x2A47604", VA = "0x2A47604")]
		public AutoUnwrapSettings(AutoUnwrapSettings unwrapSettings)
		{
		}

		[Token(Token = "0x6000013")]
		[Address(RVA = "0x2A47678", Offset = "0x2A47678", VA = "0x2A47678")]
		public void Reset()
		{
		}

		[Token(Token = "0x6000014")]
		[Address(RVA = "0x2A47690", Offset = "0x2A47690", VA = "0x2A47690", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
}
