using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace ch.sycoforge.Decal
{
	[Token(Token = "0x200003D")]
	public class StaticProxyCollection : MonoBehaviour
	{
		[Token(Token = "0x200003E")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x20B74C", Offset = "0x20B74C")]
		private sealed class _003C_003Ec__DisplayClass1
		{
			[Token(Token = "0x4000148")]
			[FieldOffset(Offset = "0x10")]
			public GameObject obj;

			[Token(Token = "0x6000211")]
			[Address(RVA = "0x2C6FEBC", Offset = "0x2C6FEBC", VA = "0x2C6FEBC")]
			public _003C_003Ec__DisplayClass1()
			{
			}

			[Token(Token = "0x6000212")]
			[Address(RVA = "0x2C710CC", Offset = "0x2C710CC", VA = "0x2C710CC")]
			public bool _003CGetMesh_003Eb__0(ProxyMesh o)
			{
				return default;
			}
		}

		[Token(Token = "0x4000146")]
		[FieldOffset(Offset = "0x18")]
		public List<GameObject> Proxies;

		[Token(Token = "0x4000147")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		public List<ProxyMesh> MeshProxies;

		[Token(Token = "0x600020B")]
		[Address(RVA = "0x2C6FBE4", Offset = "0x2C6FBE4", VA = "0x2C6FBE4")]
		public int GetStaticVertexCount()
		{
			return default;
		}

		[Token(Token = "0x600020C")]
		[Address(RVA = "0x2C6FDB8", Offset = "0x2C6FDB8", VA = "0x2C6FDB8")]
		public Mesh GetMesh(GameObject obj)
		{
			return null;
		}

		[Token(Token = "0x600020D")]
		[Address(RVA = "0x2C6FEC4", Offset = "0x2C6FEC4", VA = "0x2C6FEC4")]
		public void InitializeProxies()
		{
		}

		[Token(Token = "0x600020E")]
		[Address(RVA = "0x2C7031C", Offset = "0x2C7031C", VA = "0x2C7031C")]
		public static Mesh CloneMesh(Mesh mesh)
		{
			return null;
		}

		[Token(Token = "0x600020F")]
		[Address(RVA = "0x2C704F4", Offset = "0x2C704F4", VA = "0x2C704F4")]
		private static int GetMeshHash(Mesh clone)
		{
			return default;
		}

		[Token(Token = "0x6000210")]
		[Address(RVA = "0x2C705A4", Offset = "0x2C705A4", VA = "0x2C705A4")]
		public StaticProxyCollection()
		{
		}
	}
}
