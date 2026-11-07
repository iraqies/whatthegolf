using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Il2CppDummyDll;

namespace UnityEngine.ProBuilder
{
	[Serializable]
	[Token(Token = "0x200000B")]
	[AttributeAttribute(Name = "DefaultMemberAttribute", RVA = "0x1B596C", Offset = "0x1B596C")]
	public sealed class Face
	{
		[Token(Token = "0x4000022")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x1B5E50", Offset = "0x1B5E50")]
		private int[] m_Indexes;

		[Token(Token = "0x4000023")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x1B5E9C", Offset = "0x1B5E9C")]
		private int m_SmoothingGroup;

		[Token(Token = "0x4000024")]
		[FieldOffset(Offset = "0x1C")]
		[SerializeField]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x1B5EE8", Offset = "0x1B5EE8")]
		private AutoUnwrapSettings m_Uv;

		[Token(Token = "0x4000025")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x1B5F34", Offset = "0x1B5F34")]
		private Material m_Material;

		[Token(Token = "0x4000026")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private int m_SubmeshIndex;

		[Token(Token = "0x4000027")]
		[FieldOffset(Offset = "0x4C")]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x1B5F90", Offset = "0x1B5F90")]
		[SerializeField]
		private bool m_ManualUV;

		[Token(Token = "0x4000028")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		internal int elementGroup;

		[Token(Token = "0x4000029")]
		[FieldOffset(Offset = "0x54")]
		[SerializeField]
		private int m_TextureGroup;

		[NonSerialized]
		[Token(Token = "0x400002A")]
		[FieldOffset(Offset = "0x58")]
		private int[] m_DistinctIndexes;

		[NonSerialized]
		[Token(Token = "0x400002B")]
		[FieldOffset(Offset = "0x60")]
		private Edge[] m_Edges;

		[Token(Token = "0x1700000D")]
		public bool manualUV
		{
			[Token(Token = "0x6000025")]
			[Address(RVA = "0x2A48E44", Offset = "0x2A48E44", VA = "0x2A48E44")]
			get
			{
				return default;
			}
			[Token(Token = "0x6000026")]
			[Address(RVA = "0x2A48E4C", Offset = "0x2A48E4C", VA = "0x2A48E4C")]
			set
			{
			}
		}

		[Token(Token = "0x1700000E")]
		public int textureGroup
		{
			[Token(Token = "0x6000027")]
			[Address(RVA = "0x2A48E54", Offset = "0x2A48E54", VA = "0x2A48E54")]
			get
			{
				return default;
			}
			[Token(Token = "0x6000028")]
			[Address(RVA = "0x2A48E5C", Offset = "0x2A48E5C", VA = "0x2A48E5C")]
			set
			{
			}
		}

		[Token(Token = "0x1700000F")]
		internal int[] indexesInternal
		{
			[Token(Token = "0x6000029")]
			[Address(RVA = "0x2A48E64", Offset = "0x2A48E64", VA = "0x2A48E64")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000010")]
		internal int[] distinctIndexesInternal
		{
			[Token(Token = "0x600002B")]
			[Address(RVA = "0x2A48F84", Offset = "0x2A48F84", VA = "0x2A48F84")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000011")]
		public ReadOnlyCollection<int> distinctIndexes
		{
			[Token(Token = "0x600002C")]
			[Address(RVA = "0x2A49018", Offset = "0x2A49018", VA = "0x2A49018")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000012")]
		internal Edge[] edgesInternal
		{
			[Token(Token = "0x600002D")]
			[Address(RVA = "0x2A490AC", Offset = "0x2A490AC", VA = "0x2A490AC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000013")]
		public ReadOnlyCollection<Edge> edges
		{
			[Token(Token = "0x600002E")]
			[Address(RVA = "0x2A492FC", Offset = "0x2A492FC", VA = "0x2A492FC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000014")]
		public int smoothingGroup
		{
			[Token(Token = "0x600002F")]
			[Address(RVA = "0x2A49390", Offset = "0x2A49390", VA = "0x2A49390")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000015")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x1B6984", Offset = "0x1B6984")]
		public Material material
		{
			[Token(Token = "0x6000030")]
			[Address(RVA = "0x2A49398", Offset = "0x2A49398", VA = "0x2A49398")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000031")]
			[Address(RVA = "0x2A493A0", Offset = "0x2A493A0", VA = "0x2A493A0")]
			set
			{
			}
		}

		[Token(Token = "0x17000016")]
		public int submeshIndex
		{
			[Token(Token = "0x6000032")]
			[Address(RVA = "0x2A493A8", Offset = "0x2A493A8", VA = "0x2A493A8")]
			get
			{
				return default;
			}
			[Token(Token = "0x6000033")]
			[Address(RVA = "0x2A493B0", Offset = "0x2A493B0", VA = "0x2A493B0")]
			set
			{
			}
		}

		[Token(Token = "0x17000017")]
		public AutoUnwrapSettings uv
		{
			[Token(Token = "0x6000034")]
			[Address(RVA = "0x2A493B8", Offset = "0x2A493B8", VA = "0x2A493B8")]
			get
			{
				return default;
			}
			[Token(Token = "0x6000035")]
			[Address(RVA = "0x2A493C8", Offset = "0x2A493C8", VA = "0x2A493C8")]
			set
			{
			}
		}

		[Token(Token = "0x600002A")]
		[Address(RVA = "0x2A48E6C", Offset = "0x2A48E6C", VA = "0x2A48E6C")]
		public void SetIndexes(IEnumerable<int> indices)
		{
		}

		[Token(Token = "0x6000036")]
		[Address(RVA = "0x2A493D8", Offset = "0x2A493D8", VA = "0x2A493D8")]
		public Face()
		{
		}

		[Token(Token = "0x6000037")]
		[Address(RVA = "0x2A49400", Offset = "0x2A49400", VA = "0x2A49400")]
		internal Face(IEnumerable<int> triangles, int submeshIndex, AutoUnwrapSettings u, int smoothing, int texture, int element, bool manualUVs)
		{
		}

		[Token(Token = "0x6000038")]
		[Address(RVA = "0x2A494C4", Offset = "0x2A494C4", VA = "0x2A494C4")]
		public Face(Face other)
		{
		}

		[Token(Token = "0x6000039")]
		[Address(RVA = "0x2A494F4", Offset = "0x2A494F4", VA = "0x2A494F4")]
		public void CopyFrom(Face other)
		{
		}

		[Token(Token = "0x600003A")]
		[Address(RVA = "0x2A48F7C", Offset = "0x2A48F7C", VA = "0x2A48F7C")]
		internal void InvalidateCache()
		{
		}

		[Token(Token = "0x600003B")]
		[Address(RVA = "0x2A490C0", Offset = "0x2A490C0", VA = "0x2A490C0")]
		private Edge[] CacheEdges()
		{
			return null;
		}

		[Token(Token = "0x600003C")]
		[Address(RVA = "0x2A48F98", Offset = "0x2A48F98", VA = "0x2A48F98")]
		private int[] CacheDistinctIndexes()
		{
			return null;
		}

		[Token(Token = "0x600003D")]
		[Address(RVA = "0x2A49640", Offset = "0x2A49640", VA = "0x2A49640")]
		public bool IsQuad()
		{
			return default;
		}

		[Token(Token = "0x600003E")]
		[Address(RVA = "0x2A496A0", Offset = "0x2A496A0", VA = "0x2A496A0")]
		public int[] ToQuad()
		{
			return null;
		}

		[Token(Token = "0x600003F")]
		[Address(RVA = "0x2A49A98", Offset = "0x2A49A98", VA = "0x2A49A98", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
}
