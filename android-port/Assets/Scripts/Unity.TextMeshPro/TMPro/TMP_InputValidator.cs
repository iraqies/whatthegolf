using System;
using Il2CppDummyDll;
using UnityEngine;

namespace TMPro
{
	[Serializable]
	[Token(Token = "0x200003F")]
	public abstract class TMP_InputValidator : ScriptableObject
	{
		[Token(Token = "0x6000227")]
		public abstract char Validate(ref string text, ref int pos, char ch);

		[Token(Token = "0x6000228")]
		[Address(RVA = "0x2A9870C", Offset = "0x2A9870C", VA = "0x2A9870C")]
		protected TMP_InputValidator()
		{
		}
	}
}
