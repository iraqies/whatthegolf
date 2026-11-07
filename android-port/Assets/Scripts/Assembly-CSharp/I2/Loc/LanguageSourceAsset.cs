using UnityEngine;

namespace I2.Loc
{
	public class LanguageSourceAsset : ScriptableObject, ILanguageSource
	{
		public LanguageSourceData mSource;

		public LanguageSourceData SourceData
		{
			get
			{
				return null;
			}
			set
			{
			}
		}
	}
}
