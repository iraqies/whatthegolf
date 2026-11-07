using Il2CppDummyDll;
using UnityEngine;

namespace WhatTheGolf.LevelDesigner
{
	[Token(Token = "0x2001257")]
	internal sealed class InputSystem : BaseSystem
	{
		[Token(Token = "0x40062BD")]
		[FieldOffset(Offset = "0x0")]
		private static CursorData s_CursorData;

		[Token(Token = "0x40062BE")]
		[FieldOffset(Offset = "0x30")]
		private static KeyCode[] s_KeyCodes;

		[Token(Token = "0x40062BF")]
		[FieldOffset(Offset = "0x18")]
		private Camera m_Camera;

		[Token(Token = "0x17000986")]
		public static CursorData CursorData
		{
			[Token(Token = "0x600548C")]
			[Address(RVA = "0x14EFD28", Offset = "0x14EFD28", VA = "0x14EFD28")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000987")]
		private Camera camera
		{
			[Token(Token = "0x600548D")]
			[Address(RVA = "0x14EFD8C", Offset = "0x14EFD8C", VA = "0x14EFD8C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600548E")]
		[Address(RVA = "0x14EFE20", Offset = "0x14EFE20", VA = "0x14EFE20")]
		[Attribute(Name = "RuntimeInitializeOnLoadMethodAttribute", RVA = "0x713C0", Offset = "0x713C0")]
		private static void InitOnLoad()
		{
		}

		[Token(Token = "0x600548F")]
		[Address(RVA = "0x14EFE80", Offset = "0x14EFE80", VA = "0x14EFE80", Slot = "4")]
		public override void Init()
		{
		}

		[Token(Token = "0x6005490")]
		[Address(RVA = "0x14F0064", Offset = "0x14F0064", VA = "0x14F0064", Slot = "5")]
		public override void Update()
		{
		}

		[Token(Token = "0x6005491")]
		[Address(RVA = "0x14F0414", Offset = "0x14F0414", VA = "0x14F0414", Slot = "6")]
		public override void Dispose()
		{
		}

		[Token(Token = "0x6005492")]
		[Address(RVA = "0x14F0460", Offset = "0x14F0460", VA = "0x14F0460")]
		public InputSystem()
		{
		}
	}
}
