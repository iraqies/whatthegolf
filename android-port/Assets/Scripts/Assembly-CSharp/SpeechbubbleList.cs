using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Malee;
using UnityEngine;

[Serializable]
[Token(Token = "0x2000A5F")]
public class SpeechbubbleList : ScriptableObject
{
	[Serializable]
	[Token(Token = "0x2000A60")]
	public class SpeechbubbleTextInfo
	{
		[Token(Token = "0x4003999")]
		[FieldOffset(Offset = "0x10")]
		public string ID;

		[Token(Token = "0x400399A")]
		[FieldOffset(Offset = "0x18")]
		public int SpeakerIndex;

		[Token(Token = "0x400399B")]
		[FieldOffset(Offset = "0x1C")]
		public bool isLocalized;

		[Token(Token = "0x400399C")]
		[FieldOffset(Offset = "0x1D")]
		public bool DontPlayTalkAnimation;

		[Token(Token = "0x6003192")]
		[Address(RVA = "0x18594A0", Offset = "0x18594A0", VA = "0x18594A0")]
		public SpeechbubbleTextInfo()
		{
		}
	}

	[Serializable]
	[Token(Token = "0x2000A61")]
	public class TextIdReorderableList : ReorderableArray<SpeechbubbleTextInfo>
	{
		[Token(Token = "0x6003193")]
		[Address(RVA = "0x18594A8", Offset = "0x18594A8", VA = "0x18594A8")]
		public TextIdReorderableList()
		{
		}
	}

	[Token(Token = "0x2000A62")]
	private class Conversation : IConversation
	{
		[Token(Token = "0x400399D")]
		[FieldOffset(Offset = "0x10")]
		private int nextTextIndex;

		[Token(Token = "0x400399E")]
		[FieldOffset(Offset = "0x18")]
		private List<SpeechbubbleTextInfo> textsLeft;

		[Token(Token = "0x400399F")]
		[FieldOffset(Offset = "0x20")]
		private bool initialized;

		[Token(Token = "0x40039A0")]
		[FieldOffset(Offset = "0x28")]
		private SpeechbubbleList list;

		[Token(Token = "0x6003194")]
		[Address(RVA = "0x1859200", Offset = "0x1859200", VA = "0x1859200")]
		public Conversation(SpeechbubbleList list)
		{
		}

		[Token(Token = "0x6003195")]
		[Address(RVA = "0x18592D4", Offset = "0x18592D4", VA = "0x18592D4", Slot = "4")]
		public SpeechbubbleTextInfo GetText()
		{
			return null;
		}
	}

	[Token(Token = "0x4003994")]
	[FieldOffset(Offset = "0x18")]
	public TextIdReorderableList textIds;

	[Token(Token = "0x4003995")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private bool randomSelection;

	[Token(Token = "0x4003996")]
	[FieldOffset(Offset = "0x21")]
	[SerializeField]
	private bool discardSelectedIds;

	[Token(Token = "0x4003997")]
	[FieldOffset(Offset = "0x22")]
	[SerializeField]
	private bool loopList;

	[Token(Token = "0x4003998")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	public string translation;

	[Token(Token = "0x600318E")]
	[Address(RVA = "0x16D06BC", Offset = "0x16D06BC", VA = "0x16D06BC")]
	public bool HasRandomSelection()
	{
		return default;
	}

	[Token(Token = "0x600318F")]
	[Address(RVA = "0x16D06C4", Offset = "0x16D06C4", VA = "0x16D06C4")]
	public bool IsLooping()
	{
		return default;
	}

	[Token(Token = "0x6003190")]
	[Address(RVA = "0x16D06CC", Offset = "0x16D06CC", VA = "0x16D06CC")]
	public IConversation NewConversation()
	{
		return null;
	}

	[Token(Token = "0x6003191")]
	[Address(RVA = "0x16D0734", Offset = "0x16D0734", VA = "0x16D0734")]
	public SpeechbubbleList()
	{
	}
}
