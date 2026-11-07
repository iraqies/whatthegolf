using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace Kilt
{
	[Serializable]
	[Token(Token = "0x2000087")]
	public class FunctionAndParams
	{
		[Token(Token = "0x4000249")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private object m_target;

		[Token(Token = "0x400024A")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Type m_functionType;

		[Token(Token = "0x400024B")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private string m_stringFunctionName;

		[Token(Token = "0x400024C")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Delegate m_delegatePointer;

		[Token(Token = "0x400024D")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private List<object> m_params;

		[Token(Token = "0x17000046")]
		public object Target
		{
			[Token(Token = "0x600025F")]
			[Address(RVA = "0x137429C", Offset = "0x137429C", VA = "0x137429C")]
			set
			{
			}
		}

		[Token(Token = "0x17000047")]
		public Type FunctionType
		{
			[Token(Token = "0x6000260")]
			[Address(RVA = "0x13742B0", Offset = "0x13742B0", VA = "0x13742B0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000048")]
		public Delegate DelegatePointer
		{
			[Token(Token = "0x6000261")]
			[Address(RVA = "0x13742B8", Offset = "0x13742B8", VA = "0x13742B8")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000262")]
			[Address(RVA = "0x13742C0", Offset = "0x13742C0", VA = "0x13742C0")]
			set
			{
			}
		}

		[Token(Token = "0x17000049")]
		public List<object> Params
		{
			[Token(Token = "0x6000263")]
			[Address(RVA = "0x13742F4", Offset = "0x13742F4", VA = "0x13742F4")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000264")]
			[Address(RVA = "0x1374370", Offset = "0x1374370", VA = "0x1374370")]
			set
			{
			}
		}

		[Token(Token = "0x6000265")]
		[Address(RVA = "0x1374384", Offset = "0x1374384", VA = "0x1374384")]
		public bool CallFunction()
		{
			return default;
		}

		[Token(Token = "0x6000266")]
		[Address(RVA = "0x13745AC", Offset = "0x13745AC", VA = "0x13745AC")]
		protected bool CallDelegateFunction()
		{
			return default;
		}

		[Token(Token = "0x6000267")]
		[Address(RVA = "0x1374A7C", Offset = "0x1374A7C", VA = "0x1374A7C")]
		public FunctionAndParams()
		{
		}
	}
}
