using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace UnityEngine.ProBuilder
{
	[Serializable]
	[Token(Token = "0x2000021")]
	public sealed class Submesh
	{
		[Token(Token = "0x40000A0")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		internal int[] m_Indexes;

		[Token(Token = "0x40000A1")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		internal MeshTopology m_Topology;

		[Token(Token = "0x40000A2")]
		[FieldOffset(Offset = "0x1C")]
		[SerializeField]
		internal int m_SubmeshIndex;

		[Token(Token = "0x6000121")]
		[Address(RVA = "0x2A59FD8", Offset = "0x2A59FD8", VA = "0x2A59FD8")]
		public Submesh(int submeshIndex, MeshTopology topology, IEnumerable<int> indexes)
		{
		}

		[Token(Token = "0x6000122")]
		[Address(RVA = "0x2A5A0A4", Offset = "0x2A5A0A4", VA = "0x2A5A0A4", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x6000123")]
		[Address(RVA = "0x2A53298", Offset = "0x2A53298", VA = "0x2A53298")]
		public static Submesh[] GetSubmeshes(IEnumerable<Face> faces, int submeshCount, MeshTopology preferredTopology = MeshTopology.Triangles)
		{
			return null;
		}

		[Token(Token = "0x6000124")]
		[Address(RVA = "0x2A53144", Offset = "0x2A53144", VA = "0x2A53144")]
		internal static void MapFaceMaterialsToSubmeshIndex(ProBuilderMesh mesh)
		{
		}
	}
}
