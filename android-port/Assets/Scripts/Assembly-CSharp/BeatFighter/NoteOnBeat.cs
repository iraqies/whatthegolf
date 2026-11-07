using Il2CppDummyDll;

namespace BeatFighter
{
	[Token(Token = "0x20010E5")]
	public class NoteOnBeat
	{
		[Token(Token = "0x4005908")]
		[FieldOffset(Offset = "0x10")]
		public BeatTrackNote note;

		[Token(Token = "0x4005909")]
		[FieldOffset(Offset = "0x18")]
		public bool wasHit;

		[Token(Token = "0x6004BAC")]
		[Address(RVA = "0x158DF9C", Offset = "0x158DF9C", VA = "0x158DF9C")]
		public NoteOnBeat()
		{
		}
	}
}
