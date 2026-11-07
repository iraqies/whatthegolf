using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace ch.sycoforge.Decal
{
	[Token(Token = "0x2000012")]
	public class DecalTextureAtlas : ScriptableObject
	{
		[Token(Token = "0x4000062")]
		[FieldOffset(Offset = "0x18")]
		private Action<DecalTextureAtlas> m_OnAtlasChanged;

		[Token(Token = "0x4000063")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Material material;

		[Token(Token = "0x4000064")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private List<AtlasRegion> regions;

		[Token(Token = "0x1700001B")]
		public Material Material
		{
			[Token(Token = "0x6000099")]
			[Address(RVA = "0x2C5F4E0", Offset = "0x2C5F4E0", VA = "0x2C5F4E0")]
			get
			{
				return null;
			}
			[Token(Token = "0x600009A")]
			[Address(RVA = "0x2C5F4E8", Offset = "0x2C5F4E8", VA = "0x2C5F4E8")]
			set
			{
			}
		}

		[Token(Token = "0x1700001C")]
		public List<AtlasRegion> Regions
		{
			[Token(Token = "0x600009B")]
			[Address(RVA = "0x2C5F4F0", Offset = "0x2C5F4F0", VA = "0x2C5F4F0")]
			get
			{
				return null;
			}
			[Token(Token = "0x600009C")]
			[Address(RVA = "0x2C5F4F8", Offset = "0x2C5F4F8", VA = "0x2C5F4F8")]
			set
			{
			}
		}

		[Token(Token = "0x14000006")]
		public event Action<DecalTextureAtlas> OnAtlasChanged
		{
			[Token(Token = "0x6000097")]
			[Address(RVA = "0x2C5F398", Offset = "0x2C5F398", VA = "0x2C5F398")]
			add
			{
			}
			[Token(Token = "0x6000098")]
			[Address(RVA = "0x2C5F43C", Offset = "0x2C5F43C", VA = "0x2C5F43C")]
			remove
			{
			}
		}

		[Token(Token = "0x600009D")]
		[Address(RVA = "0x2C5F500", Offset = "0x2C5F500", VA = "0x2C5F500")]
		public Texture2D GetThumbnail(int index)
		{
			return null;
		}

		[Token(Token = "0x600009E")]
		[Address(RVA = "0x2C5F59C", Offset = "0x2C5F59C", VA = "0x2C5F59C")]
		public Texture2D GetThumbnail(AtlasRegion region)
		{
			return null;
		}

		[Token(Token = "0x600009F")]
		[Address(RVA = "0x2C5F838", Offset = "0x2C5F838", VA = "0x2C5F838")]
		public void CallOnAtlasChanged()
		{
		}

		[Token(Token = "0x60000A0")]
		[Address(RVA = "0x2C5F898", Offset = "0x2C5F898", VA = "0x2C5F898")]
		public DecalTextureAtlas()
		{
		}
	}
}
