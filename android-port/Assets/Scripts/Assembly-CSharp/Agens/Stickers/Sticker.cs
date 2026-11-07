using System.Collections.Generic;
using UnityEngine;

namespace Agens.Stickers
{
	public class Sticker : ScriptableObject
	{
		public string Name;

		public int Fps;

		public int Repetitions;

		public int Index;

		public bool Sequence;

		public List<Texture2D> Frames;

		public void CopyFrom(Sticker sticker, int i)
		{
		}
	}
}
