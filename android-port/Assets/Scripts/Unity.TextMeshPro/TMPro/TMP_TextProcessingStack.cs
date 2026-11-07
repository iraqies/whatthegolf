using Il2CppDummyDll;

namespace TMPro
{
	[Token(Token = "0x2000073")]
	public struct TMP_TextProcessingStack<T>
	{
		[Token(Token = "0x4000497")]
		[FieldOffset(Offset = "0x0")]
		public T[] itemStack;

		[Token(Token = "0x4000498")]
		[FieldOffset(Offset = "0x0")]
		public int index;

		[Token(Token = "0x4000499")]
		[FieldOffset(Offset = "0x0")]
		private T m_DefaultItem;

		[Token(Token = "0x400049A")]
		[FieldOffset(Offset = "0x0")]
		private int m_Capacity;

		[Token(Token = "0x400049B")]
		[FieldOffset(Offset = "0x0")]
		private int m_RolloverSize;

		[Token(Token = "0x400049C")]
		[FieldOffset(Offset = "0x0")]
		private int m_Count;

		[Token(Token = "0x400049D")]
		private const int k_DefaultCapacity = 4;

		[Token(Token = "0x1700013A")]
		public int Count
		{
			[Token(Token = "0x600046D")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x1700013B")]
		public T current
		{
			[Token(Token = "0x600046E")]
			get
			{
				return (T)null;
			}
		}

		[Token(Token = "0x600046A")]
		public TMP_TextProcessingStack(T[] stack)
		{
		}

		[Token(Token = "0x600046B")]
		public TMP_TextProcessingStack(int capacity)
		{
		}

		[Token(Token = "0x600046C")]
		public TMP_TextProcessingStack(int capacity, int rolloverSize)
		{
		}

		[Token(Token = "0x600046F")]
		internal static void SetDefault(TMP_TextProcessingStack<T>[] stack, T item)
		{
		}

		[Token(Token = "0x6000470")]
		public void Clear()
		{
		}

		[Token(Token = "0x6000471")]
		public void SetDefault(T item)
		{
		}

		[Token(Token = "0x6000472")]
		public void Add(T item)
		{
		}

		[Token(Token = "0x6000473")]
		public T Remove()
		{
			return (T)null;
		}

		[Token(Token = "0x6000474")]
		public void Push(T item)
		{
		}

		[Token(Token = "0x6000475")]
		public T Pop()
		{
			return (T)null;
		}

		[Token(Token = "0x6000476")]
		public T Peek()
		{
			return (T)null;
		}

		[Token(Token = "0x6000477")]
		public T CurrentItem()
		{
			return (T)null;
		}
	}
}
