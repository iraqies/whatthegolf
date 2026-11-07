using Il2CppDummyDll;

namespace WhatTheGolf.LevelDesigner
{
	[Token(Token = "0x2001250")]
	public abstract class BaseSystem
	{
		[Token(Token = "0x40062A5")]
		[FieldOffset(Offset = "0x10")]
		private MainController m_Owner;

		[Token(Token = "0x1700097F")]
		public MainController owner
		{
			[Token(Token = "0x600545B")]
			[Address(RVA = "0x16093A0", Offset = "0x16093A0", VA = "0x16093A0")]
			get
			{
				return null;
			}
			[Token(Token = "0x600545C")]
			[Address(RVA = "0x16093A8", Offset = "0x16093A8", VA = "0x16093A8")]
			internal set
			{
			}
		}

		[Token(Token = "0x600545D")]
		public abstract void Init();

		[Token(Token = "0x600545E")]
		public abstract void Update();

		[Token(Token = "0x600545F")]
		public abstract void Dispose();

		[Token(Token = "0x6005460")]
		[Address(RVA = "0x16093B0", Offset = "0x16093B0", VA = "0x16093B0")]
		protected BaseSystem()
		{
		}
	}
}
