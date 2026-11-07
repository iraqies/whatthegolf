using System;
using System.Collections.Generic;
using UnityEngine;

public class OverworldPianoManager : MonoBehaviour
{
	[Serializable]
	public class Octave
	{
		public AudioClip baseNoteClip;

		public List<OverworldPianoKey> childNotes;
	}

	public float volume;

	public List<Octave> octaves;

	private void Awake()
	{
	}
}
