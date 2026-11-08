using UnityEngine;

namespace I2.Loc
{
	public class LanguageSourceAsset : ScriptableObject, ILanguageSource
	{
		public LanguageSourceData mSource = new LanguageSourceData();

		public LanguageSourceData SourceData
		{
			get => mSource;
			set => mSource = value;
		}
	}
}
