using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace TMPro
{
	[Serializable]
	[Token(Token = "0x2000059")]
	public class TMP_StyleSheet : ScriptableObject
	{
		[Token(Token = "0x40002F3")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private List<TMP_Style> m_StyleList;

		[Token(Token = "0x40002F4")]
		[FieldOffset(Offset = "0x20")]
		private Dictionary<int, TMP_Style> m_StyleLookupDictionary;

		[Token(Token = "0x170000BE")]
		internal List<TMP_Style> styles
		{
			[Token(Token = "0x60002BA")]
			[Address(RVA = "0x2A9EDAC", Offset = "0x2A9EDAC", VA = "0x2A9EDAC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60002BB")]
		[Address(RVA = "0x2A9EDB4", Offset = "0x2A9EDB4", VA = "0x2A9EDB4")]
		private void Reset()
		{
		}

		[Token(Token = "0x60002BC")]
		[Address(RVA = "0x2A9F12C", Offset = "0x2A9F12C", VA = "0x2A9F12C")]
		public TMP_Style GetStyle(int hashCode)
		{
			return null;
		}

		[Token(Token = "0x60002BD")]
		[Address(RVA = "0x2A9F1C0", Offset = "0x2A9F1C0", VA = "0x2A9F1C0")]
		public TMP_Style GetStyle(string name)
		{
			return null;
		}

		[Token(Token = "0x60002BE")]
		[Address(RVA = "0x2A9F28C", Offset = "0x2A9F28C", VA = "0x2A9F28C")]
		public void RefreshStyles()
		{
		}

		[Token(Token = "0x60002BF")]
		[Address(RVA = "0x2A9EDB8", Offset = "0x2A9EDB8", VA = "0x2A9EDB8")]
		private void LoadStyleDictionaryInternal()
		{
		}

		[Token(Token = "0x60002C0")]
		[Address(RVA = "0x2A9F290", Offset = "0x2A9F290", VA = "0x2A9F290")]
		public TMP_StyleSheet()
		{
		}
	}
}
