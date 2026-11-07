using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace ch.sycoforge.Decal
{
	[Token(Token = "0x2000003")]
	public class CombinedDecalsGroup : MonoBehaviour
	{
		[Token(Token = "0x4000003")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private DecalTextureAtlas atlas;

		[Token(Token = "0x4000004")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private List<EasyDecal> references;

		[Token(Token = "0x17000003")]
		public DecalTextureAtlas Atlas
		{
			[Token(Token = "0x6000007")]
			[Address(RVA = "0x2C59A8C", Offset = "0x2C59A8C", VA = "0x2C59A8C")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000008")]
			[Address(RVA = "0x2C59A94", Offset = "0x2C59A94", VA = "0x2C59A94")]
			set
			{
			}
		}

		[Token(Token = "0x17000004")]
		public List<EasyDecal> References
		{
			[Token(Token = "0x6000009")]
			[Address(RVA = "0x2C59A9C", Offset = "0x2C59A9C", VA = "0x2C59A9C")]
			get
			{
				return null;
			}
			[Token(Token = "0x600000A")]
			[Address(RVA = "0x2C59AA4", Offset = "0x2C59AA4", VA = "0x2C59AA4")]
			set
			{
			}
		}

		[Token(Token = "0x600000B")]
		[Address(RVA = "0x2C59AAC", Offset = "0x2C59AAC", VA = "0x2C59AAC")]
		public CombinedDecalsGroup()
		{
		}
	}
}
