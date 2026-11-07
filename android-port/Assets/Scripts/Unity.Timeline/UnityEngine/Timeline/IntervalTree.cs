using System.Collections.Generic;
using Il2CppDummyDll;

namespace UnityEngine.Timeline
{
	[Token(Token = "0x2000022")]
	internal class IntervalTree<T> where T : IInterval
	{
		[Token(Token = "0x2000023")]
		internal struct Entry
		{
			[Token(Token = "0x40000C1")]
			[FieldOffset(Offset = "0x0")]
			public long intervalStart;

			[Token(Token = "0x40000C2")]
			[FieldOffset(Offset = "0x0")]
			public long intervalEnd;

			[Token(Token = "0x40000C3")]
			[FieldOffset(Offset = "0x0")]
			public T item;
		}

		[Token(Token = "0x40000BE")]
		[FieldOffset(Offset = "0x0")]
		private readonly List<Entry> m_Entries;

		[Token(Token = "0x40000BF")]
		[FieldOffset(Offset = "0x0")]
		private readonly List<IntervalTreeNode> m_Nodes;

		[Token(Token = "0x40000C0")]
		[FieldOffset(Offset = "0x0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1BC278", Offset = "0x1BC278")]
		private bool dirty__BackingField;

		[Token(Token = "0x1700007A")]
		public bool dirty
		{
			[Token(Token = "0x60001A0")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1BC520", Offset = "0x1BC520")]
			get
			{
				return default;
			}
			[Token(Token = "0x60001A1")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1BC530", Offset = "0x1BC530")]
			internal set
			{
			}
		}

		[Token(Token = "0x60001A2")]
		public void Add(T item)
		{
		}

		[Token(Token = "0x60001A3")]
		public void IntersectsWith(long value, List<T> results)
		{
		}

		[Token(Token = "0x60001A4")]
		private void Query(IntervalTreeNode intervalTreeNode, long value, List<T> results)
		{
		}

		[Token(Token = "0x60001A5")]
		private void Rebuild()
		{
		}

		[Token(Token = "0x60001A6")]
		private int Rebuild(int start, int end)
		{
			return default;
		}

		[Token(Token = "0x60001A7")]
		public IntervalTree()
		{
		}
	}
}
