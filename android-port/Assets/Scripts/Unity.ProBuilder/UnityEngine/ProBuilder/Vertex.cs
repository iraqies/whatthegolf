using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace UnityEngine.ProBuilder
{
	[Serializable]
	[Token(Token = "0x2000024")]
	public sealed class Vertex : IEquatable<Vertex>
	{
		[Token(Token = "0x40000AB")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private Vector3 m_Position;

		[Token(Token = "0x40000AC")]
		[FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private Color m_Color;

		[Token(Token = "0x40000AD")]
		[FieldOffset(Offset = "0x2C")]
		[SerializeField]
		private Vector3 m_Normal;

		[Token(Token = "0x40000AE")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Vector4 m_Tangent;

		[Token(Token = "0x40000AF")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Vector2 m_UV0;

		[Token(Token = "0x40000B0")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private Vector2 m_UV2;

		[Token(Token = "0x40000B1")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private Vector4 m_UV3;

		[Token(Token = "0x40000B2")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private Vector4 m_UV4;

		[Token(Token = "0x40000B3")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private MeshArrays m_Attributes;

		[Token(Token = "0x17000054")]
		public Vector3 position
		{
			[Token(Token = "0x6000134")]
			[Address(RVA = "0x2A5B8F4", Offset = "0x2A5B8F4", VA = "0x2A5B8F4")]
			get
			{
				return default;
			}
			[Token(Token = "0x6000135")]
			[Address(RVA = "0x2A5015C", Offset = "0x2A5015C", VA = "0x2A5015C")]
			set
			{
			}
		}

		[Token(Token = "0x17000055")]
		public Color color
		{
			[Token(Token = "0x6000136")]
			[Address(RVA = "0x2A50184", Offset = "0x2A50184", VA = "0x2A50184")]
			set
			{
			}
		}

		[Token(Token = "0x17000056")]
		public Vector3 normal
		{
			[Token(Token = "0x6000137")]
			[Address(RVA = "0x2A5B954", Offset = "0x2A5B954", VA = "0x2A5B954")]
			get
			{
				return default;
			}
			[Token(Token = "0x6000138")]
			[Address(RVA = "0x2A501AC", Offset = "0x2A501AC", VA = "0x2A501AC")]
			set
			{
			}
		}

		[Token(Token = "0x17000057")]
		public Vector4 tangent
		{
			[Token(Token = "0x6000139")]
			[Address(RVA = "0x2A501D4", Offset = "0x2A501D4", VA = "0x2A501D4")]
			set
			{
			}
		}

		[Token(Token = "0x17000058")]
		public Vector2 uv0
		{
			[Token(Token = "0x600013A")]
			[Address(RVA = "0x2A5B9C0", Offset = "0x2A5B9C0", VA = "0x2A5B9C0")]
			get
			{
				return default;
			}
			[Token(Token = "0x600013B")]
			[Address(RVA = "0x2A501FC", Offset = "0x2A501FC", VA = "0x2A501FC")]
			set
			{
			}
		}

		[Token(Token = "0x17000059")]
		public Vector2 uv2
		{
			[Token(Token = "0x600013C")]
			[Address(RVA = "0x2A50220", Offset = "0x2A50220", VA = "0x2A50220")]
			set
			{
			}
		}

		[Token(Token = "0x1700005A")]
		public Vector4 uv3
		{
			[Token(Token = "0x600013D")]
			[Address(RVA = "0x2A50244", Offset = "0x2A50244", VA = "0x2A50244")]
			set
			{
			}
		}

		[Token(Token = "0x1700005B")]
		public Vector4 uv4
		{
			[Token(Token = "0x600013E")]
			[Address(RVA = "0x2A5026C", Offset = "0x2A5026C", VA = "0x2A5026C")]
			set
			{
			}
		}

		[Token(Token = "0x1700005C")]
		private bool hasPosition
		{
			[Token(Token = "0x6000140")]
			[Address(RVA = "0x2A5BA88", Offset = "0x2A5BA88", VA = "0x2A5BA88")]
			get
			{
				return default;
			}
			[Token(Token = "0x6000141")]
			[Address(RVA = "0x2A5B900", Offset = "0x2A5B900", VA = "0x2A5B900")]
			set
			{
			}
		}

		[Token(Token = "0x1700005D")]
		private bool hasColor
		{
			[Token(Token = "0x6000142")]
			[Address(RVA = "0x2A5BA94", Offset = "0x2A5BA94", VA = "0x2A5BA94")]
			get
			{
				return default;
			}
			[Token(Token = "0x6000143")]
			[Address(RVA = "0x2A5B924", Offset = "0x2A5B924", VA = "0x2A5B924")]
			set
			{
			}
		}

		[Token(Token = "0x1700005E")]
		private bool hasNormal
		{
			[Token(Token = "0x6000144")]
			[Address(RVA = "0x2A5BAA0", Offset = "0x2A5BAA0", VA = "0x2A5BAA0")]
			get
			{
				return default;
			}
			[Token(Token = "0x6000145")]
			[Address(RVA = "0x2A5B960", Offset = "0x2A5B960", VA = "0x2A5B960")]
			set
			{
			}
		}

		[Token(Token = "0x1700005F")]
		private bool hasTangent
		{
			[Token(Token = "0x6000146")]
			[Address(RVA = "0x2A5BAAC", Offset = "0x2A5BAAC", VA = "0x2A5BAAC")]
			get
			{
				return default;
			}
			[Token(Token = "0x6000147")]
			[Address(RVA = "0x2A5B990", Offset = "0x2A5B990", VA = "0x2A5B990")]
			set
			{
			}
		}

		[Token(Token = "0x17000060")]
		private bool hasUV0
		{
			[Token(Token = "0x6000148")]
			[Address(RVA = "0x2A5BAB8", Offset = "0x2A5BAB8", VA = "0x2A5BAB8")]
			get
			{
				return default;
			}
			[Token(Token = "0x6000149")]
			[Address(RVA = "0x2A5B9C8", Offset = "0x2A5B9C8", VA = "0x2A5B9C8")]
			set
			{
			}
		}

		[Token(Token = "0x17000061")]
		private bool hasUV2
		{
			[Token(Token = "0x600014A")]
			[Address(RVA = "0x2A5BAC4", Offset = "0x2A5BAC4", VA = "0x2A5BAC4")]
			get
			{
				return default;
			}
			[Token(Token = "0x600014B")]
			[Address(RVA = "0x2A5B9F8", Offset = "0x2A5B9F8", VA = "0x2A5B9F8")]
			set
			{
			}
		}

		[Token(Token = "0x17000062")]
		private bool hasUV3
		{
			[Token(Token = "0x600014C")]
			[Address(RVA = "0x2A5BAD0", Offset = "0x2A5BAD0", VA = "0x2A5BAD0")]
			get
			{
				return default;
			}
			[Token(Token = "0x600014D")]
			[Address(RVA = "0x2A5BA28", Offset = "0x2A5BA28", VA = "0x2A5BA28")]
			set
			{
			}
		}

		[Token(Token = "0x17000063")]
		private bool hasUV4
		{
			[Token(Token = "0x600014E")]
			[Address(RVA = "0x2A5BADC", Offset = "0x2A5BADC", VA = "0x2A5BADC")]
			get
			{
				return default;
			}
			[Token(Token = "0x600014F")]
			[Address(RVA = "0x2A5BA58", Offset = "0x2A5BA58", VA = "0x2A5BA58")]
			set
			{
			}
		}

		[Token(Token = "0x600013F")]
		[Address(RVA = "0x2A50540", Offset = "0x2A50540", VA = "0x2A50540")]
		public bool HasArrays(MeshArrays attribute)
		{
			return default;
		}

		[Token(Token = "0x6000150")]
		[Address(RVA = "0x2A50154", Offset = "0x2A50154", VA = "0x2A50154")]
		public Vertex()
		{
		}

		[Token(Token = "0x6000151")]
		[Address(RVA = "0x2A5BAE8", Offset = "0x2A5BAE8", VA = "0x2A5BAE8", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default;
		}

		[Token(Token = "0x6000152")]
		[Address(RVA = "0x2A5BB68", Offset = "0x2A5BB68", VA = "0x2A5BB68", Slot = "4")]
		public bool Equals(Vertex other)
		{
			return default;
		}

		[Token(Token = "0x6000153")]
		[Address(RVA = "0x2A5BE0C", Offset = "0x2A5BE0C", VA = "0x2A5BE0C", Slot = "2")]
		public override int GetHashCode()
		{
			return default;
		}

		[Token(Token = "0x6000154")]
		[Address(RVA = "0x2A50518", Offset = "0x2A50518", VA = "0x2A50518")]
		public static bool operator ==(Vertex a, Vertex b)
		{
			return default;
		}

		[Token(Token = "0x6000155")]
		[Address(RVA = "0x2A506BC", Offset = "0x2A506BC", VA = "0x2A506BC")]
		public static void GetArrays(IList<Vertex> vertices, out Vector3[] position, out Color[] color, out Vector2[] uv0, out Vector3[] normal, out Vector4[] tangent, out Vector2[] uv2, out List<Vector4> uv3, out List<Vector4> uv4)
		{
		}

		[Token(Token = "0x6000156")]
		[Address(RVA = "0x2A5BFC4", Offset = "0x2A5BFC4", VA = "0x2A5BFC4")]
		public static void GetArrays(IList<Vertex> vertices, out Vector3[] position, out Color[] color, out Vector2[] uv0, out Vector3[] normal, out Vector4[] tangent, out Vector2[] uv2, out List<Vector4> uv3, out List<Vector4> uv4, MeshArrays attributes)
		{
		}
	}
}
