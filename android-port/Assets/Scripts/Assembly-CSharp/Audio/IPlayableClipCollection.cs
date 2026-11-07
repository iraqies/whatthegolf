using Il2CppDummyDll;

namespace Audio
{
	[Token(Token = "0x20013BF")]
	public interface IPlayableClipCollection
	{
		[Token(Token = "0x17000A67")]
		CollectionPlayMode GetPlayMode
		{
			[Token(Token = "0x6005C29")]
			get;
		}

		[Token(Token = "0x17000A68")]
		int LastCollectionIndex
		{
			[Token(Token = "0x6005C2A")]
			get;
			[Token(Token = "0x6005C2B")]
			set;
		}

		[Token(Token = "0x17000A69")]
		int Count
		{
			[Token(Token = "0x6005C2C")]
			get;
		}
	}
}
