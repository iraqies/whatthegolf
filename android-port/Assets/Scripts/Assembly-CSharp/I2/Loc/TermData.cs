using System;
using UnityEngine;

namespace I2.Loc
{
	[Serializable]
	public class TermData
	{
		public string Term;

		public eTermType TermType;

		[NonSerialized]
		public string Description;

		public string[] Languages;

		public byte[] Flags;

		[SerializeField]
		private string[] Languages_Touch;

		public string GetTranslation(int idx, string specialization = null, bool editMode = false)
		{
			return null;
		}

		public void SetTranslation(int idx, string translation, string specialization = null)
		{
		}

		public void Validate()
		{
		}

		public bool IsTerm(string name, bool allowCategoryMistmatch)
		{
			return false;
		}
	}
}
