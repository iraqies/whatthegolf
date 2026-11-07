using Il2CppDummyDll;

namespace UnityEngine.EventSystems
{
	[Token(Token = "0x20000A4")]
	public class BaseInput : UIBehaviour
	{
		[Token(Token = "0x1700019B")]
		public virtual string compositionString
		{
			[Token(Token = "0x60005F1")]
			[Address(RVA = "0x2BF7FA4", Offset = "0x2BF7FA4", VA = "0x2BF7FA4", Slot = "17")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700019C")]
		public virtual IMECompositionMode imeCompositionMode
		{
			[Token(Token = "0x60005F2")]
			[Address(RVA = "0x2BF7FAC", Offset = "0x2BF7FAC", VA = "0x2BF7FAC", Slot = "18")]
			get
			{
				return default;
			}
			[Token(Token = "0x60005F3")]
			[Address(RVA = "0x2BF7FB4", Offset = "0x2BF7FB4", VA = "0x2BF7FB4", Slot = "19")]
			set
			{
			}
		}

		[Token(Token = "0x1700019D")]
		public virtual Vector2 compositionCursorPos
		{
			[Token(Token = "0x60005F4")]
			[Address(RVA = "0x2BF7FC0", Offset = "0x2BF7FC0", VA = "0x2BF7FC0", Slot = "20")]
			get
			{
				return default;
			}
			[Token(Token = "0x60005F5")]
			[Address(RVA = "0x2BF7FC8", Offset = "0x2BF7FC8", VA = "0x2BF7FC8", Slot = "21")]
			set
			{
			}
		}

		[Token(Token = "0x1700019E")]
		public virtual bool mousePresent
		{
			[Token(Token = "0x60005F6")]
			[Address(RVA = "0x2BF7FD0", Offset = "0x2BF7FD0", VA = "0x2BF7FD0", Slot = "22")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x1700019F")]
		public virtual Vector2 mousePosition
		{
			[Token(Token = "0x60005FA")]
			[Address(RVA = "0x2BF7FFC", Offset = "0x2BF7FFC", VA = "0x2BF7FFC", Slot = "26")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x170001A0")]
		public virtual Vector2 mouseScrollDelta
		{
			[Token(Token = "0x60005FB")]
			[Address(RVA = "0x2BF8004", Offset = "0x2BF8004", VA = "0x2BF8004", Slot = "27")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x170001A1")]
		public virtual bool touchSupported
		{
			[Token(Token = "0x60005FC")]
			[Address(RVA = "0x2BF800C", Offset = "0x2BF800C", VA = "0x2BF800C", Slot = "28")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x170001A2")]
		public virtual int touchCount
		{
			[Token(Token = "0x60005FD")]
			[Address(RVA = "0x2BF8014", Offset = "0x2BF8014", VA = "0x2BF8014", Slot = "29")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x60005F7")]
		[Address(RVA = "0x2BF7FD8", Offset = "0x2BF7FD8", VA = "0x2BF7FD8", Slot = "23")]
		public virtual bool GetMouseButtonDown(int button)
		{
			return default;
		}

		[Token(Token = "0x60005F8")]
		[Address(RVA = "0x2BF7FE4", Offset = "0x2BF7FE4", VA = "0x2BF7FE4", Slot = "24")]
		public virtual bool GetMouseButtonUp(int button)
		{
			return default;
		}

		[Token(Token = "0x60005F9")]
		[Address(RVA = "0x2BF7FF0", Offset = "0x2BF7FF0", VA = "0x2BF7FF0", Slot = "25")]
		public virtual bool GetMouseButton(int button)
		{
			return default;
		}

		[Token(Token = "0x60005FE")]
		[Address(RVA = "0x2BF801C", Offset = "0x2BF801C", VA = "0x2BF801C", Slot = "30")]
		public virtual Touch GetTouch(int index)
		{
			return default;
		}

		[Token(Token = "0x60005FF")]
		[Address(RVA = "0x2BF8028", Offset = "0x2BF8028", VA = "0x2BF8028", Slot = "31")]
		public virtual float GetAxisRaw(string axisName)
		{
			return default;
		}

		[Token(Token = "0x6000600")]
		[Address(RVA = "0x2BF8034", Offset = "0x2BF8034", VA = "0x2BF8034", Slot = "32")]
		public virtual bool GetButtonDown(string buttonName)
		{
			return default;
		}

		[Token(Token = "0x6000601")]
		[Address(RVA = "0x2BF8040", Offset = "0x2BF8040", VA = "0x2BF8040")]
		public BaseInput()
		{
		}
	}
}
