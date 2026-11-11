using UnityEngine;

public static class MusicMathUtils
{
	public enum Scale
	{
		PentatonicScale = 0,
		MajorChromaticScale = 1,
		Octave = 2
	}

	public static int[] PentatonicScale = new int[] { 0, 2, 4, 7, 9 };

	public static int[] MajorChromaticScale = new int[] { 0, 2, 4, 5, 7, 9, 11 };

	public static int[] Octave = new int[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11 };

	public static float MidiNoteToPitch(int midiNote, int baseNote)
	{
		return Mathf.Pow(2f, (midiNote - baseNote) / 12f);
	}

	public static int[] ReturnScaleNotes(Scale scale)
	{
		switch (scale)
		{
		case Scale.PentatonicScale:
			return PentatonicScale;
		case Scale.MajorChromaticScale:
			return MajorChromaticScale;
		case Scale.Octave:
			return Octave;
		default:
			return null;
		}
	}
}
