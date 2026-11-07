using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace ch.sycoforge.Decal
{
	[Token(Token = "0x2000026")]
	public class MeshLinkGroup : MonoBehaviour
	{
		[Token(Token = "0x40000E3")]
		[FieldOffset(Offset = "0x18")]
		public List<MeshLink> Links;

		[Token(Token = "0x6000175")]
		[Address(RVA = "0x2C6A340", Offset = "0x2C6A340", VA = "0x2C6A340", Slot = "4")]
		protected virtual void Start()
		{
		}

		[Token(Token = "0x6000176")]
		[Address(RVA = "0x2C6A3E0", Offset = "0x2C6A3E0", VA = "0x2C6A3E0")]
		public void Clear()
		{
		}

		[Token(Token = "0x6000177")]
		[Address(RVA = "0x2C6A580", Offset = "0x2C6A580", VA = "0x2C6A580")]
		public void Initialize()
		{
		}

		[Token(Token = "0x6000178")]
		[Address(RVA = "0x2C6A844", Offset = "0x2C6A844", VA = "0x2C6A844")]
		public MeshLinkGroup()
		{
		}
	}
}
