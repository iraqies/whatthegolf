using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace ch.sycoforge.Decal
{
	[Token(Token = "0x2000027")]
	public class SkinnedMeshLink : MeshLink
	{
		[Token(Token = "0x40000E4")]
		[FieldOffset(Offset = "0x20")]
		public List<SkinnedMeshRenderer> SkinnedMeshes;

		[Token(Token = "0x6000179")]
		[Address(RVA = "0x2C6FB64", Offset = "0x2C6FB64", VA = "0x2C6FB64")]
		public SkinnedMeshLink()
		{
		}
	}
}
