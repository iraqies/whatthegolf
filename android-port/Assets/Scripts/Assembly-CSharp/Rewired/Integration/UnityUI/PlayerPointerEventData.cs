using Il2CppDummyDll;
using Rewired.UI;
using UnityEngine.EventSystems;

namespace Rewired.Integration.UnityUI
{
	[Token(Token = "0x2001148")]
	public class PlayerPointerEventData : PointerEventData
	{
		[Token(Token = "0x4005B37")]
		[FieldOffset(Offset = "0x148")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x56ED0", Offset = "0x56ED0")]
		private int playerId__BackingField;

		[Token(Token = "0x4005B38")]
		[FieldOffset(Offset = "0x14C")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x56EE0", Offset = "0x56EE0")]
		private int inputSourceIndex__BackingField;

		[Token(Token = "0x4005B39")]
		[FieldOffset(Offset = "0x150")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x56EF0", Offset = "0x56EF0")]
		private IMouseInputSource mouseSource__BackingField;

		[Token(Token = "0x4005B3A")]
		[FieldOffset(Offset = "0x158")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x56F00", Offset = "0x56F00")]
		private ITouchInputSource touchSource__BackingField;

		[Token(Token = "0x4005B3B")]
		[FieldOffset(Offset = "0x160")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x56F10", Offset = "0x56F10")]
		private PointerEventType sourceType__BackingField;

		[Token(Token = "0x4005B3C")]
		[FieldOffset(Offset = "0x164")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x56F20", Offset = "0x56F20")]
		private int buttonIndex__BackingField;

		[Token(Token = "0x17000843")]
		public int playerId
		{
			[Token(Token = "0x6004E1C")]
			[Address(RVA = "0x15F9370", Offset = "0x15F9370", VA = "0x15F9370")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x6FE18", Offset = "0x6FE18")]
			get
			{
				return default;
			}
			[Token(Token = "0x6004E1D")]
			[Address(RVA = "0x15F9378", Offset = "0x15F9378", VA = "0x15F9378")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x6FE28", Offset = "0x6FE28")]
			set
			{
			}
		}

		[Token(Token = "0x17000844")]
		public int inputSourceIndex
		{
			[Token(Token = "0x6004E1E")]
			[Address(RVA = "0x15F9380", Offset = "0x15F9380", VA = "0x15F9380")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x6FE38", Offset = "0x6FE38")]
			get
			{
				return default;
			}
			[Token(Token = "0x6004E1F")]
			[Address(RVA = "0x15F9388", Offset = "0x15F9388", VA = "0x15F9388")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x6FE48", Offset = "0x6FE48")]
			set
			{
			}
		}

		[Token(Token = "0x17000845")]
		public IMouseInputSource mouseSource
		{
			[Token(Token = "0x6004E20")]
			[Address(RVA = "0x15F9390", Offset = "0x15F9390", VA = "0x15F9390")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x6FE58", Offset = "0x6FE58")]
			get
			{
				return null;
			}
			[Token(Token = "0x6004E21")]
			[Address(RVA = "0x15F9398", Offset = "0x15F9398", VA = "0x15F9398")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x6FE68", Offset = "0x6FE68")]
			set
			{
			}
		}

		[Token(Token = "0x17000846")]
		public ITouchInputSource touchSource
		{
			[Token(Token = "0x6004E22")]
			[Address(RVA = "0x15F93A0", Offset = "0x15F93A0", VA = "0x15F93A0")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x6FE78", Offset = "0x6FE78")]
			get
			{
				return null;
			}
			[Token(Token = "0x6004E23")]
			[Address(RVA = "0x15F93A8", Offset = "0x15F93A8", VA = "0x15F93A8")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x6FE88", Offset = "0x6FE88")]
			set
			{
			}
		}

		[Token(Token = "0x17000847")]
		public PointerEventType sourceType
		{
			[Token(Token = "0x6004E24")]
			[Address(RVA = "0x15F93B0", Offset = "0x15F93B0", VA = "0x15F93B0")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x6FE98", Offset = "0x6FE98")]
			get
			{
				return default;
			}
			[Token(Token = "0x6004E25")]
			[Address(RVA = "0x15F93B8", Offset = "0x15F93B8", VA = "0x15F93B8")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x6FEA8", Offset = "0x6FEA8")]
			set
			{
			}
		}

		[Token(Token = "0x17000848")]
		public int buttonIndex
		{
			[Token(Token = "0x6004E26")]
			[Address(RVA = "0x15F93C0", Offset = "0x15F93C0", VA = "0x15F93C0")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x6FEB8", Offset = "0x6FEB8")]
			get
			{
				return default;
			}
			[Token(Token = "0x6004E27")]
			[Address(RVA = "0x15F93C8", Offset = "0x15F93C8", VA = "0x15F93C8")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x6FEC8", Offset = "0x6FEC8")]
			set
			{
			}
		}

		[Token(Token = "0x6004E28")]
		[Address(RVA = "0x15F93D0", Offset = "0x15F93D0", VA = "0x15F93D0")]
		public PlayerPointerEventData(EventSystem eventSystem)
		{
		}

		[Token(Token = "0x6004E29")]
		[Address(RVA = "0x15F9404", Offset = "0x15F9404", VA = "0x15F9404", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
}
