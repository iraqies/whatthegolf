using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace Core
{
	[Serializable]
	[Token(Token = "0x2001427")]
	public class CreditsData : ScriptableObject
	{
		[Serializable]
		[Token(Token = "0x2001428")]
		public class Credit
		{
			[Token(Token = "0x4006CDF")]
			[FieldOffset(Offset = "0x10")]
			public string title;

			[Token(Token = "0x4006CE0")]
			[FieldOffset(Offset = "0x18")]
			public bool isRandomizingNames;

			[Token(Token = "0x4006CE1")]
			[FieldOffset(Offset = "0x20")]
			public string twitter;

			[Token(Token = "0x4006CE2")]
			[FieldOffset(Offset = "0x28")]
			public List<string> names;

			[Token(Token = "0x6005DC7")]
			[Address(RVA = "0x1791AE0", Offset = "0x1791AE0", VA = "0x1791AE0")]
			public Credit()
			{
			}
		}

		[Token(Token = "0x4006CDE")]
		[FieldOffset(Offset = "0x18")]
		public List<Credit> credits;

		[Token(Token = "0x6005DC6")]
		[Address(RVA = "0x18C10F0", Offset = "0x18C10F0", VA = "0x18C10F0")]
		public CreditsData()
		{
		}
	}
}
