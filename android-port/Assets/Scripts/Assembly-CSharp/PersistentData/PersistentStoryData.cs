using Ghost;
using Il2CppDummyDll;

namespace PersistentData
{
	[Token(Token = "0x2001030")]
	public class PersistentStoryData
	{
		[Token(Token = "0x4005557")]
		[FieldOffset(Offset = "0x10")]
		public int StoryID;

		[Token(Token = "0x4005558")]
		[FieldOffset(Offset = "0x14")]
		public int Stars;

		[Token(Token = "0x4005559")]
		[FieldOffset(Offset = "0x18")]
		public int Strokes;

		[Token(Token = "0x400555A")]
		[FieldOffset(Offset = "0x1C")]
		public bool Completed;

		[Token(Token = "0x400555B")]
		[FieldOffset(Offset = "0x20")]
		public GolfGhostData Ghost;

		[Token(Token = "0x6004882")]
		[Address(RVA = "0x15DFBE8", Offset = "0x15DFBE8", VA = "0x15DFBE8")]
		public PersistentStoryData()
		{
		}
	}
}
