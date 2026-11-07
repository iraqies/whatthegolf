using System;
using Il2CppDummyDll;
using UnityEngine;

namespace TMPro
{
	[Serializable]
	[Token(Token = "0x2000058")]
	public class TMP_Style
	{
		[Token(Token = "0x40002EA")]
		[FieldOffset(Offset = "0x0")]
		internal static TMP_Style k_NormalStyle;

		[Token(Token = "0x40002EB")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private string m_Name;

		[Token(Token = "0x40002EC")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private int m_HashCode;

		[Token(Token = "0x40002ED")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private string m_OpeningDefinition;

		[Token(Token = "0x40002EE")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private string m_ClosingDefinition;

		[Token(Token = "0x40002EF")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private int[] m_OpeningTagArray;

		[Token(Token = "0x40002F0")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private int[] m_ClosingTagArray;

		[Token(Token = "0x40002F1")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		internal uint[] m_OpeningTagUnicodeArray;

		[Token(Token = "0x40002F2")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		internal uint[] m_ClosingTagUnicodeArray;

		[Token(Token = "0x170000BA")]
		public static TMP_Style NormalStyle
		{
			[Token(Token = "0x60002B4")]
			[Address(RVA = "0x2A9E9C8", Offset = "0x2A9E9C8", VA = "0x2A9E9C8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000BB")]
		public int hashCode
		{
			[Token(Token = "0x60002B5")]
			[Address(RVA = "0x2A9EB8C", Offset = "0x2A9EB8C", VA = "0x2A9EB8C")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x170000BC")]
		public int[] styleOpeningTagArray
		{
			[Token(Token = "0x60002B6")]
			[Address(RVA = "0x2A9EB94", Offset = "0x2A9EB94", VA = "0x2A9EB94")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000BD")]
		public int[] styleClosingTagArray
		{
			[Token(Token = "0x60002B7")]
			[Address(RVA = "0x2A9EB9C", Offset = "0x2A9EB9C", VA = "0x2A9EB9C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60002B8")]
		[Address(RVA = "0x2A9EAEC", Offset = "0x2A9EAEC", VA = "0x2A9EAEC")]
		internal TMP_Style(string styleName, string styleOpeningDefinition, string styleClosingDefinition)
		{
		}

		[Token(Token = "0x60002B9")]
		[Address(RVA = "0x2A9EBA4", Offset = "0x2A9EBA4", VA = "0x2A9EBA4")]
		public void RefreshStyle()
		{
		}
	}
}
