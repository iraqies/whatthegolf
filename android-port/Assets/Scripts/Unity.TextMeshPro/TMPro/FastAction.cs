using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace TMPro
{
	[Token(Token = "0x2000002")]
	public class FastAction
	{
		[Token(Token = "0x4000001")]
		[FieldOffset(Offset = "0x10")]
		private LinkedList<Action> delegates;

		[Token(Token = "0x4000002")]
		[FieldOffset(Offset = "0x18")]
		private Dictionary<Action, LinkedListNode<Action>> lookup;

		[Token(Token = "0x6000001")]
		[Address(RVA = "0x2A7A2D0", Offset = "0x2A7A2D0", VA = "0x2A7A2D0")]
		public FastAction()
		{
		}
	}
	[Token(Token = "0x2000003")]
	public class FastAction<A>
	{
		[Token(Token = "0x4000003")]
		[FieldOffset(Offset = "0x0")]
		private LinkedList<Action<A>> delegates;

		[Token(Token = "0x4000004")]
		[FieldOffset(Offset = "0x0")]
		private Dictionary<Action<A>, LinkedListNode<Action<A>>> lookup;

		[Token(Token = "0x6000002")]
		public void Add(Action<A> rhs)
		{
		}

		[Token(Token = "0x6000003")]
		public void Remove(Action<A> rhs)
		{
		}

		[Token(Token = "0x6000004")]
		public void Call(A a)
		{
		}

		[Token(Token = "0x6000005")]
		public FastAction()
		{
		}
	}
	[Token(Token = "0x2000004")]
	public class FastAction<A, B>
	{
		[Token(Token = "0x4000005")]
		[FieldOffset(Offset = "0x0")]
		private LinkedList<Action<A, B>> delegates;

		[Token(Token = "0x4000006")]
		[FieldOffset(Offset = "0x0")]
		private Dictionary<Action<A, B>, LinkedListNode<Action<A, B>>> lookup;

		[Token(Token = "0x6000006")]
		public FastAction()
		{
		}
	}
	[Token(Token = "0x2000005")]
	public class FastAction<A, B, C>
	{
		[Token(Token = "0x4000007")]
		[FieldOffset(Offset = "0x0")]
		private LinkedList<Action<A, B, C>> delegates;

		[Token(Token = "0x4000008")]
		[FieldOffset(Offset = "0x0")]
		private Dictionary<Action<A, B, C>, LinkedListNode<Action<A, B, C>>> lookup;

		[Token(Token = "0x6000007")]
		public FastAction()
		{
		}
	}
}
