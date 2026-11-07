using System;
using Il2CppDummyDll;
using UnityEngine;

namespace UnityStandardAssets.Utility
{
	[Token(Token = "0x2000043")]
	public class AutoMobileShaderSwitch : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x2000044")]
		public class ReplacementDefinition
		{
			[Token(Token = "0x4000103")]
			[FieldOffset(Offset = "0x10")]
			public Shader original;

			[Token(Token = "0x4000104")]
			[FieldOffset(Offset = "0x18")]
			public Shader replacement;

			[Token(Token = "0x600011B")]
			[Address(RVA = "0x13369AC", Offset = "0x13369AC", VA = "0x13369AC")]
			public ReplacementDefinition()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x2000045")]
		public class ReplacementList
		{
			[Token(Token = "0x4000105")]
			[FieldOffset(Offset = "0x10")]
			public ReplacementDefinition[] items;

			[Token(Token = "0x600011C")]
			[Address(RVA = "0x13369B4", Offset = "0x13369B4", VA = "0x13369B4")]
			public ReplacementList()
			{
			}
		}

		[Token(Token = "0x4000102")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private ReplacementList m_ReplacementList;

		[Token(Token = "0x6000119")]
		[Address(RVA = "0x12F37AC", Offset = "0x12F37AC", VA = "0x12F37AC")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x600011A")]
		[Address(RVA = "0x12F41EC", Offset = "0x12F41EC", VA = "0x12F41EC")]
		public AutoMobileShaderSwitch()
		{
		}
	}
}
