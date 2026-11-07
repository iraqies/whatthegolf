using System;
using UnityEngine;

namespace SaloonPiano
{
	public class MusicPiece : ScriptableObject
	{
		[Serializable]
		public class NoteData
		{
			public int beat;

			public int position;

			public AudioClip clip;

			public bool isWrong;
		}

		public int length;

		public int minPosition;

		public int maxPosition;

		public NoteData[] notes;
	}
}
