using Il2CppDummyDll;
using UnityEngine;

namespace WhatTheGolf.LevelDesigner.Managers
{
	[Token(Token = "0x20012C5")]
	public abstract class BaseManager : MonoBehaviour
	{
		[Token(Token = "0x4006525")]
		[FieldOffset(Offset = "0x18")]
		private MainController m_Owner;

		[Token(Token = "0x170009EB")]
		public MainController owner
		{
			[Token(Token = "0x60056E9")]
			[Address(RVA = "0x1608228", Offset = "0x1608228", VA = "0x1608228")]
			get
			{
				return null;
			}
			[Token(Token = "0x60056EA")]
			[Address(RVA = "0x1608230", Offset = "0x1608230", VA = "0x1608230")]
			internal set
			{
			}
		}

		[Token(Token = "0x60056EB")]
		public abstract void Init();

		[Token(Token = "0x60056EC")]
		[Address(RVA = "0x1608238", Offset = "0x1608238", VA = "0x1608238")]
		protected BaseManager()
		{
		}
	}
}
