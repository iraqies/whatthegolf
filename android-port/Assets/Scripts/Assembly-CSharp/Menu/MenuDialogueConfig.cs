using System;
using System.Collections.Generic;
using UnityEngine;

namespace Menu
{
	public class MenuDialogueConfig : ScriptableObject
	{
		public enum Type
		{
			Default = 0,
			SpecialDay = 1,
			NewEpisode = 2,
			Daily = 3,
			Welcome = 4
		}

		public enum EffectType
		{
			None = 0,
			HighlightBonusArrow = 1,
			HighlightEpisodesArrow = 2,
			Hide = 3
		}

		public enum DisplayType
		{
			Auto = 0,
			Exclamation = 1,
			OnHit = 2
		}

		[Serializable]
		public class TextAndEffectType
		{
			public string text;

			public EffectType EffectType;
		}

		[Serializable]
		public class Entry
		{
			public Type type;

			public List<TextAndEffectType> texts;

			public List<UserCriteria> criteriaList;

			public DisplayType displayType;

			public string SaveKey => null;

			public Entry(Entry entry)
			{
			}

			public bool HasBeenSeenBefore()
			{
				return false;
			}
		}

		public string UserName;

		public List<Entry> entries;

		public int overrideEntryIndex;

		private void OnValidate()
		{
		}

		public bool TryGetText(out Entry entry)
		{
			entry = null;
			return false;
		}

		private Type GetTextType(List<Type> typesTried)
		{
			return Type.Default;
		}

		private Entry GetEntry(Type type)
		{
			return null;
		}
	}
}
