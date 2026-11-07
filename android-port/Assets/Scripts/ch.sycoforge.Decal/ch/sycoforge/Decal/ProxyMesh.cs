using System;
using Il2CppDummyDll;
using UnityEngine;

namespace ch.sycoforge.Decal
{
	[Serializable]
	[Token(Token = "0x200003C")]
	public class ProxyMesh
	{
		[Token(Token = "0x4000142")]
		[FieldOffset(Offset = "0x10")]
		public int ID;

		[Token(Token = "0x4000143")]
		[FieldOffset(Offset = "0x18")]
		public Mesh MeshProxy;

		[Token(Token = "0x4000144")]
		[FieldOffset(Offset = "0x20")]
		public Transform transform;

		[Token(Token = "0x4000145")]
		[FieldOffset(Offset = "0x28")]
		public Bounds bounds;

		[Token(Token = "0x600020A")]
		[Address(RVA = "0x2C6BC04", Offset = "0x2C6BC04", VA = "0x2C6BC04")]
		public ProxyMesh()
		{
		}
	}
}
