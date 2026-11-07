using System.Collections.Generic;
using Il2CppDummyDll;
using WhatTheGolf.LevelDesigner.Events;

namespace WhatTheGolf.LevelDesigner
{
	[Token(Token = "0x200125C")]
	internal sealed class UndoSystem : BaseSystem, IRequireEvents<GUIEvent>, IRequireEvents, IRequireEvents<InputEvent>
	{
		[Token(Token = "0x40062D8")]
		[FieldOffset(Offset = "0x0")]
		private static Stack<LevelContentData> m_UndoStack;

		[Token(Token = "0x40062D9")]
		[FieldOffset(Offset = "0x8")]
		private static Stack<LevelContentData> m_RedoStack;

		[Token(Token = "0x1700098F")]
		public static bool HasUndo
		{
			[Token(Token = "0x60054BB")]
			[Address(RVA = "0x173AB50", Offset = "0x173AB50", VA = "0x173AB50")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000990")]
		public static bool HasRedo
		{
			[Token(Token = "0x60054BC")]
			[Address(RVA = "0x173ABBC", Offset = "0x173ABBC", VA = "0x173ABBC")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x60054BD")]
		[Address(RVA = "0x173AC28", Offset = "0x173AC28", VA = "0x173AC28")]
		[Attribute(Name = "RuntimeInitializeOnLoadMethodAttribute", RVA = "0x713FC", Offset = "0x713FC")]
		private static void InitOnLoad()
		{
		}

		[Token(Token = "0x60054BE")]
		[Address(RVA = "0x173ACD8", Offset = "0x173ACD8", VA = "0x173ACD8")]
		public static void RegisterUndo(bool clearRedoStack = true)
		{
		}

		[Token(Token = "0x60054BF")]
		[Address(RVA = "0x173ADD8", Offset = "0x173ADD8", VA = "0x173ADD8")]
		public static void ClearStacks()
		{
		}

		[Token(Token = "0x60054C0")]
		[Address(RVA = "0x173AE5C", Offset = "0x173AE5C", VA = "0x173AE5C", Slot = "4")]
		public override void Init()
		{
		}

		[Token(Token = "0x60054C1")]
		[Address(RVA = "0x173AE84", Offset = "0x173AE84", VA = "0x173AE84", Slot = "5")]
		public override void Update()
		{
		}

		[Token(Token = "0x60054C2")]
		[Address(RVA = "0x173AE88", Offset = "0x173AE88", VA = "0x173AE88", Slot = "6")]
		public override void Dispose()
		{
		}

		[Token(Token = "0x60054C3")]
		[Address(RVA = "0x173AE8C", Offset = "0x173AE8C", VA = "0x173AE8C")]
		private static void PerformUndo()
		{
		}

		[Token(Token = "0x60054C4")]
		[Address(RVA = "0x173AFE8", Offset = "0x173AFE8", VA = "0x173AFE8")]
		private static void PerformRedo()
		{
		}

		[Token(Token = "0x60054C5")]
		[Address(RVA = "0x173B0D8", Offset = "0x173B0D8", VA = "0x173B0D8", Slot = "7")]
		public void OnEvent(GUIEvent evt)
		{
		}

		[Token(Token = "0x60054C6")]
		[Address(RVA = "0x173B148", Offset = "0x173B148", VA = "0x173B148", Slot = "8")]
		public void OnEvent(InputEvent evt)
		{
		}

		[Token(Token = "0x60054C7")]
		[Address(RVA = "0x173B290", Offset = "0x173B290", VA = "0x173B290")]
		public UndoSystem()
		{
		}
	}
}
