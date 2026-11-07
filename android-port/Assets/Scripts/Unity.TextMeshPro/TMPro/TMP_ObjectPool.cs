using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine.Events;

namespace TMPro
{
	[Token(Token = "0x2000048")]
	internal class TMP_ObjectPool<T> where T : new()
	{
		[Token(Token = "0x40001CD")]
		[FieldOffset(Offset = "0x0")]
		private readonly Stack<T> m_Stack;

		[Token(Token = "0x40001CE")]
		[FieldOffset(Offset = "0x0")]
		private readonly UnityAction<T> m_ActionOnGet;

		[Token(Token = "0x40001CF")]
		[FieldOffset(Offset = "0x0")]
		private readonly UnityAction<T> m_ActionOnRelease;

		[Token(Token = "0x40001D0")]
		[FieldOffset(Offset = "0x0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1B9CEC", Offset = "0x1B9CEC")]
		private int countAll__BackingField;

		[Token(Token = "0x1700008D")]
		public int countAll
		{
			[Token(Token = "0x6000243")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1BA788", Offset = "0x1BA788")]
			get
			{
				return default;
			}
			[Token(Token = "0x6000244")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1BA798", Offset = "0x1BA798")]
			private set
			{
			}
		}

		[Token(Token = "0x6000245")]
		public TMP_ObjectPool(UnityAction<T> actionOnGet, UnityAction<T> actionOnRelease)
		{
		}

		[Token(Token = "0x6000246")]
		public T Get()
		{
			return (T)null;
		}

		[Token(Token = "0x6000247")]
		public void Release(T element)
		{
		}
	}
}
