using Il2CppDummyDll;

[Token(Token = "0x20003D3")]
public static class MusicMathUtils
{
	[Token(Token = "0x20003D4")]
	public enum Scale
	{
		[Token(Token = "0x4001501")]
		PentatonicScale = 0,
		[Token(Token = "0x4001502")]
		MajorChromaticScale = 1,
		[Token(Token = "0x4001503")]
		Octave = 2
	}

	[Token(Token = "0x40014FD")]
	[FieldOffset(Offset = "0x0")]
	public static int[] PentatonicScale;

	[Token(Token = "0x40014FE")]
	[FieldOffset(Offset = "0x8")]
	public static int[] MajorChromaticScale;

	[Token(Token = "0x40014FF")]
	[FieldOffset(Offset = "0x10")]
	public static int[] Octave;

	[Token(Token = "0x6001208")]
	[Address(RVA = "0x1587B80", Offset = "0x1587B80", VA = "0x1587B80")]
	public static float MidiNoteToPitch(int midiNote, int baseNote)
	{
		return default;
	}

	[Token(Token = "0x6001209")]
	[Address(RVA = "0x1587B94", Offset = "0x1587B94", VA = "0x1587B94")]
	public static int[] ReturnScaleNotes(Scale scale)
	{
		return null;
	}
}
