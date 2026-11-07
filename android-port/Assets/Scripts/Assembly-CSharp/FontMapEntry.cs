using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AddressableAssets;

[Serializable]
public class FontMapEntry
{
	[SerializeField]
	private string m_Name;

	[SerializeField]
	private AssetReference m_FontCollectionAssetReference;

	[SerializeField]
	private List<string> m_CharSets;

	private LocalizationFontCollection loadedFontCollection;
}
