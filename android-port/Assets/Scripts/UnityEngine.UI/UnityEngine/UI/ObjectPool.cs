using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine.Events;

namespace UnityEngine.UI
{
	[Token(Token = "0x200006D")]
	internal class ObjectPool<T> where T : new()
	{
		[Token(Token = "0x400022E")]
		[FieldOffset(Offset = "0x0")]
		private readonly Stack<T> m_Stack;

		[Token(Token = "0x400022F")]
		[FieldOffset(Offset = "0x0")]
		private readonly UnityAction<T> m_ActionOnGet;

		[Token(Token = "0x4000230")]
		[FieldOffset(Offset = "0x0")]
		private readonly UnityAction<T> m_ActionOnRelease;

		[Token(Token = "0x4000231")]
		[FieldOffset(Offset = "0x0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1F83DC", Offset = "0x1F83DC")]
		private int countAll__BackingField;

		[Token(Token = "0x1700014D")]
		public int countAll
		{
			[Token(Token = "0x60004C0")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1F8A58", Offset = "0x1F8A58")]
			get
			{
				return default;
			}
			[Token(Token = "0x60004C1")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1F8A68", Offset = "0x1F8A68")]
			private set
			{
			}
		}

		[Token(Token = "0x60004C2")]
		public ObjectPool(UnityAction<T> actionOnGet, UnityAction<T> actionOnRelease)
		{
		}

		[Token(Token = "0x60004C3")]
		public T Get()
		{
			return (T)null;
		}

		[Token(Token = "0x60004C4")]
		public void Release(T element)
		{
		}
	}
}
