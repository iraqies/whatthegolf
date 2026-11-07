using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;

namespace I2.Loc
{
	[Serializable]
	[Token(Token = "0x200131D")]
	public class TermData
	{
		[Token(Token = "0x400668E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string Term;

		[Token(Token = "0x400668F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public eTermType TermType;

		[NonSerialized]
		[Token(Token = "0x4006690")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public string Description;

		[Token(Token = "0x4006691")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public string[] Languages;

		[Token(Token = "0x4006692")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public byte[] Flags;

		[Token(Token = "0x4006693")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SerializeField]
		private string[] Languages_Touch;

		[Token(Token = "0x6005940")]
		[Address(RVA = "0x170F9AC", Offset = "0x170F9AC", VA = "0x170F9AC")]
		public string GetTranslation(int idx, [Optional] string specialization, bool editMode = false)
		{
			return null;
		}

		[Token(Token = "0x6005941")]
		[Address(RVA = "0x170FAE4", Offset = "0x170FAE4", VA = "0x170FAE4")]
		public void SetTranslation(int idx, string translation, [Optional] string specialization)
		{
		}

		[Token(Token = "0x6005942")]
		[Address(RVA = "0x170FBDC", Offset = "0x170FBDC", VA = "0x170FBDC")]
		public void Validate()
		{
		}

		[Token(Token = "0x6005943")]
		[Address(RVA = "0x170FDC0", Offset = "0x170FDC0", VA = "0x170FDC0")]
		public bool IsTerm(string name, bool allowCategoryMistmatch)
		{
			return default;
		}

		[Token(Token = "0x6005944")]
		[Address(RVA = "0x170FE54", Offset = "0x170FE54", VA = "0x170FE54")]
		public TermData()
		{
		}
	}
}
