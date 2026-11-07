using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Rewired
{
	[Serializable]
	[Token(Token = "0x2000103")]
	public sealed class InputLayout
	{
		[Token(Token = "0x40005FF")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private string _name;

		[Token(Token = "0x4000600")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private string _descriptiveName;

		[Token(Token = "0x4000601")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private int _id;

		[Token(Token = "0x17000261")]
		public string name
		{
			[Token(Token = "0x600078C")]
			[Address(RVA = "0x23D4010", Offset = "0x23D4010", VA = "0x23D4010")]
			get
			{
				return null;
			}
			[Token(Token = "0x600078D")]
			[Address(RVA = "0x23D4018", Offset = "0x23D4018", VA = "0x23D4018")]
			internal set
			{
				CsQOAWYijZfmerTlmIiSxDfjlXTN(text);
			}
		}

		[Token(Token = "0x17000262")]
		internal string descriptiveName
		{
			[Token(Token = "0x600078E")]
			[Address(RVA = "0x23D4020", Offset = "0x23D4020", VA = "0x23D4020")]
			set
			{
				sfIvBHTvDSWiArkDjaeZnAaDyaEo(text);
			}
		}

		[Token(Token = "0x17000263")]
		public int id
		{
			[Token(Token = "0x600078F")]
			[Address(RVA = "0x23D4028", Offset = "0x23D4028", VA = "0x23D4028")]
			get
			{
				return default;
			}
			[Token(Token = "0x6000790")]
			[Address(RVA = "0x23D4030", Offset = "0x23D4030", VA = "0x23D4030")]
			internal set
			{
				JPbZDUeCyFLRqbbbjNbTfHOyjoLk(num);
			}
		}

		[Token(Token = "0x600078D")]
		[Address(RVA = "0x23D4018", Offset = "0x23D4018", VA = "0x23D4018")]
		internal void CsQOAWYijZfmerTlmIiSxDfjlXTN(string P_0)
		{
		}

		[Token(Token = "0x600078E")]
		[Address(RVA = "0x23D4020", Offset = "0x23D4020", VA = "0x23D4020")]
		internal void sfIvBHTvDSWiArkDjaeZnAaDyaEo(string P_0)
		{
		}

		[Token(Token = "0x6000790")]
		[Address(RVA = "0x23D4030", Offset = "0x23D4030", VA = "0x23D4030")]
		internal void JPbZDUeCyFLRqbbbjNbTfHOyjoLk(int P_0)
		{
		}

		[Token(Token = "0x6000791")]
		[Address(RVA = "0x23D4038", Offset = "0x23D4038", VA = "0x23D4038")]
		public InputLayout()
		{
		}
	}
}
