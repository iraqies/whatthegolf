using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Audio.Rumble
{
	[Serializable]
	[Token(Token = "0x20013FA")]
	public class RumbleCollection : IPlayableClipCollection
	{
		[Token(Token = "0x4006B47")]
		[FieldOffset(Offset = "0x10")]
		public CollectionPlayMode PlayMode;

		[Token(Token = "0x4006B48")]
		[FieldOffset(Offset = "0x18")]
		public List<RumbleFileSetting> Rumbles;

		[Token(Token = "0x4006B49")]
		[FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5AC14", Offset = "0x5AC14")]
		private int LastCollectionIndex__BackingField;

		[Token(Token = "0x17000A85")]
		public CollectionPlayMode GetPlayMode
		{
			[Token(Token = "0x6005D04")]
			[Address(RVA = "0x1661AA8", Offset = "0x1661AA8", VA = "0x1661AA8", Slot = "4")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000A86")]
		public int LastCollectionIndex
		{
			[Token(Token = "0x6005D05")]
			[Address(RVA = "0x1661AB0", Offset = "0x1661AB0", VA = "0x1661AB0", Slot = "5")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x728C0", Offset = "0x728C0")]
			get
			{
				return default;
			}
			[Token(Token = "0x6005D06")]
			[Address(RVA = "0x1661AB8", Offset = "0x1661AB8", VA = "0x1661AB8", Slot = "6")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x728D0", Offset = "0x728D0")]
			set
			{
			}
		}

		[Token(Token = "0x17000A87")]
		public int Count
		{
			[Token(Token = "0x6005D07")]
			[Address(RVA = "0x1661AC0", Offset = "0x1661AC0", VA = "0x1661AC0", Slot = "7")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x6005D08")]
		[Address(RVA = "0x1661B0C", Offset = "0x1661B0C", VA = "0x1661B0C")]
		public RumbleCollection()
		{
		}
	}
}
