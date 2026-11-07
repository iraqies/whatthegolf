using System.Collections.Generic;
using UnityEngine;

public class LocalizationFontMap : ScriptableObject
{
	[SerializeField]
	private List<FontMapEntry> m_Entries;

	public List<FontMapEntry> entries => null;
}
