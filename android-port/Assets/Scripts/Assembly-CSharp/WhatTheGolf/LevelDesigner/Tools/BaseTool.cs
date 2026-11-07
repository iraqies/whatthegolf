using Il2CppDummyDll;

namespace WhatTheGolf.LevelDesigner.Tools
{
	[Token(Token = "0x200126A")]
	public abstract class BaseTool
	{
		[Token(Token = "0x40062FD")]
		[FieldOffset(Offset = "0x10")]
		private MainController m_Owner;

		[Token(Token = "0x1700099D")]
		public MainController owner
		{
			[Token(Token = "0x6005505")]
			[Address(RVA = "0x16093B8", Offset = "0x16093B8", VA = "0x16093B8")]
			get
			{
				return null;
			}
			[Token(Token = "0x6005506")]
			[Address(RVA = "0x16093C0", Offset = "0x16093C0", VA = "0x16093C0")]
			internal set
			{
			}
		}

		[Token(Token = "0x6005507")]
		public abstract void Init();

		[Token(Token = "0x6005508")]
		public abstract void Update(bool guiHasFocus);

		[Token(Token = "0x6005509")]
		public abstract void Dispose();
	}
}
