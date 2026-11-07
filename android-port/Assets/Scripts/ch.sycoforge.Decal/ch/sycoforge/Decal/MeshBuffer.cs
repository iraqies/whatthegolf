using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using ch.sycoforge.Decal.Projectors.Geometry;

namespace ch.sycoforge.Decal
{
	[Token(Token = "0x2000028")]
	public static class MeshBuffer
	{
		[Token(Token = "0x40000E5")]
		[FieldOffset(Offset = "0x0")]
		private static Dictionary<int, SimpleMesh> mappings;

		[Token(Token = "0x40000E6")]
		[FieldOffset(Offset = "0x8")]
		private static int[] ringBuffer;

		[Token(Token = "0x40000E7")]
		[FieldOffset(Offset = "0x10")]
		private static int bufferSize;

		[Token(Token = "0x40000E8")]
		[FieldOffset(Offset = "0x14")]
		private static int index;

		[Token(Token = "0x600017A")]
		[Address(RVA = "0x2C5FF80", Offset = "0x2C5FF80", VA = "0x2C5FF80")]
		public static void Add(Mesh mesh, int submesh)
		{
		}

		[Token(Token = "0x600017B")]
		[Address(RVA = "0x2C601D0", Offset = "0x2C601D0", VA = "0x2C601D0")]
		public static SimpleMesh Get(Mesh mesh, int submesh)
		{
			return null;
		}

		[Token(Token = "0x600017C")]
		[Address(RVA = "0x2C6A148", Offset = "0x2C6A148", VA = "0x2C6A148")]
		private static SimpleMesh Convert(Mesh mesh, int submesh)
		{
			return null;
		}
	}
}
