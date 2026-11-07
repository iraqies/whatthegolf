using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace ch.sycoforge.Decal
{
	[Token(Token = "0x2000025")]
	[DisallowMultipleComponent]
	public abstract class MeshLink : MonoBehaviour
	{
		[Token(Token = "0x40000E2")]
		[FieldOffset(Offset = "0x18")]
		public List<MeshFilter> MeshFilters;

		[Token(Token = "0x6000174")]
		[Address(RVA = "0x2C6A338", Offset = "0x2C6A338", VA = "0x2C6A338")]
		protected MeshLink()
		{
		}
	}
}
